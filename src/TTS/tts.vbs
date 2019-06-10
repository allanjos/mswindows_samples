Option Explicit

Dim fso: Set fso = CreateObject("Scripting.FileSystemObject")

Dim file: Set file = fso.OpenTextFile("list.txt")

Dim fileName, message, sapi, outputFileStream

Set outputFileStream = CreateObject("SAPI.SpFileStream")
Set sapi = CreateObject("sapi.spvoice")

Function paddingZero(ByVal number)
  If number < 10 Then
    paddingZero = "0" & CStr(number)
  Else
    paddingZero = CStr(number)
  End If
End Function

Dim fileIndex

fileIndex = 0

Do Until file.AtEndOfStream
    fileIndex = fileIndex + 1

    message = file.ReadLine

    ' WScript.Echo message

    Dim currentTime

    currentTime = Now()

    Dim outputFilePath

    outputFilePath = "tts_audio_" _
                & CStr(Year(currentTime)) _
                & paddingZero(Month(currentTime)) _
                & paddingZero(Day(currentTime)) _
                & paddingZero(Hour(currentTime)) _
                & paddingZero(Minute(currentTime)) _
                & paddingZero(Second(currentTime)) _
                & "_" _
                & fileIndex _
                & ".wav"

    ' WScript.Echo outputFilePath

    ' Output file

    outputFileStream.Format.Type = 18

    outputFileStream.Open outputFilePath, 3, False

    ' TTS

    SET sapi.AudioOutputStream = outputFileStream

    sapi.Speak "<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='pt-BR'>" + message + "</speak>"

    outputFileStream.Close
Loop

file.Close
