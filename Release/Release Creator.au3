#Region ;**** Directives created by AutoIt3Wrapper_GUI ****
#AutoIt3Wrapper_UseX64=n
#AutoIt3Wrapper_Res_Fileversion=0.0.0.20
#AutoIt3Wrapper_Res_Fileversion_AutoIncrement=y
#AutoIt3Wrapper_Add_Constants=n
#AutoIt3Wrapper_AU3Check_Stop_OnWarning=y
#EndRegion ;**** Directives created by AutoIt3Wrapper_GUI ****
; *** Start added by AutoIt3Wrapper ***
#include <ButtonConstants.au3>
; *** End added by AutoIt3Wrapper ***

#include <File.au3>
#include <GUIConstantsEx.au3>
#include <GuiButton.au3>
#include <EditConstants.au3>
#include "D:\Programming (Work)\AutoIt Scripts\_Standard UDFs\ReleaseCreatorFunctions.au3"

; Script Start - Add your code below here
Local $ReleaseVersion = ""

; Folders
Local $ProgramName = "Bulk Find and Replace"
Local $WebSiteFolder = _GetLocalWebsiteFilesFolder()
Local $ProjectWebSiteHelpFolder = _GetLocalWebsiteHelpFolder() & "\Bulk_Find_and_Replace"
Local $ProjectWebSiteFolder = $WebSiteFolder & "\Bulk_Find_and_Replace"
Local $RemoteProjectFolder = _GetRemoteWebsiteFilesFolder() & "Bulk_Find_and_Replace"

Local $ProjectFolder = StringTrimRight(_PathFull(@ScriptDir & "..\..\"), 1)
Local $WhatsNew = _PathFull($ProjectFolder & "\Help\Output\html\WhatsNew.html")

Local $HTMLHelpOutputFolder = $ProjectFolder & "\Help\Output\html"

Local $AutoUpdateFolder = $ProjectFolder & "\Auto Update"
Local $AutoUpdateLocalINIFilename = "Update Program Settings.ini"
Local $AutoUpdateRemoteINIFilename = "Version.ini"

Local $VSProjectFolder = $ProjectFolder & "\dotNet"

Local $InnoInstallationFolder = _GetInnoSetupInstallationFolder()
Local $InnoInstallerFile = "Bulk Find and Replace Inno Script.iss"

; Determine New Version Number
FindNewVersionNumber()

; Final Settings that need be calculated after the others
Local $OutputFilename = "Bulk Find and Replace Setup v" & $ReleaseVersion & ".exe"
Local $OutputFilenameRegEx = '(Bulk Find and Replace Setup v.*?exe)'

#include <GUIConstants.au3>
#Region ### START Koda GUI section ### Form=Release Creator.kxf
Local $ReleaseCreator = GUICreate("Release Creator", 393, 125, 237, 122)
Local $lblNewVersionNumber = GUICtrlCreateLabel("New Version Number:", 80, 8, 107, 17, 0)
Local $txtNewVersionNumber = GUICtrlCreateInput("txtNewVersionNumber", 200, 8, 105, 21, $GUI_SS_DEFAULT_INPUT)
Local $cmdUpdateVersionNumbers = GUICtrlCreateButton("Update Version Numbers", 8, 40, 185, 33, $BS_NOTIFY)
Local $cmdCreateInstallationPackage = GUICtrlCreateButton("Create NSIS Installation Package", 200, 40, 185, 33, $BS_NOTIFY)
Local $cmdCopySetupFilesToWebFolder = GUICtrlCreateButton("Copy Setup Files to Web Folder", 200, 80, 185, 33, $BS_NOTIFY)
GUISetState(@SW_SHOW)
#EndRegion ### END Koda GUI section ###

; Set other form info not covered by the Koda Script
GUICtrlSetData($txtNewVersionNumber, $ReleaseVersion)
GUISetState()
While 1
	Local $msg = GUIGetMsg()
	Select
		Case $msg = $cmdUpdateVersionNumbers
			UpdateVersionNumbers()
		Case $msg = $cmdCopySetupFilesToWebFolder
			CopySetupFilesToWebFolder()
		Case $msg = $cmdCreateInstallationPackage
			CreateInnoSetupPackage()
		Case $msg = $GUI_EVENT_CLOSE
			ExitLoop
		Case Else
			;;;
	EndSelect
WEnd
Exit

Func UpdateVersionNumbers()
	; Update Version Numbers in NSIS file
	;ReplaceLineInFile($InnoInstallerFile, "!define PRODUCT_VERSION", "!define PRODUCT_VERSION " & Chr(34) & $ReleaseVersion & Chr(34))
	
	; Update Version Numbers in Inno Setup file
	ReplaceLineInFile($InnoInstallerFile, "#define MyAppVersion", "#define MyAppVersion " & Chr(34) & $ReleaseVersion & Chr(34))

	Local $CurrentDateTime = @YEAR & "/" & @MON & "/" & @MDAY & " " & @HOUR & ":" & @MIN & ":" & @SEC

	;Update 'Update Program Settings' ini
	;IniWrite($AutoUpdateFolder & "\" & $AutoUpdateLocalINIFilename, "Settings", "Program", $ProgramName)
	IniWrite($AutoUpdateFolder & "\" & $AutoUpdateLocalINIFilename, "Settings", "CurrentVersion", $ReleaseVersion)
	IniWrite($AutoUpdateFolder & "\" & $AutoUpdateLocalINIFilename, "Settings", "CurrentDateTime", $CurrentDateTime)
	;IniWrite($AutoUpdateFolder & "\" & $AutoUpdateLocalINIFilename, "Settings", "LatestVersionINILocation", $RemoteProjectFolder & "/Version.ini")

	;Update 'Version.ini'
	IniWrite($AutoUpdateFolder & "\" & $AutoUpdateRemoteINIFilename, "Settings", "LatestVersion", $ReleaseVersion)
	IniWrite($AutoUpdateFolder & "\" & $AutoUpdateRemoteINIFilename, "Settings", "LatestDateTime", $CurrentDateTime)
	;IniWrite($AutoUpdateFolder & "\" & $AutoUpdateRemoteINIFilename, "Settings", "ChangeDoc", $WhatsNewDocPath)
	;IniWrite($AutoUpdateFolder & "\" & $AutoUpdateRemoteINIFilename, "Settings", "DownloadFilePath", $RemoteProjectFolder & "/" & $OutputFilename)

	StepComplete()
EndFunc   ;==>UpdateVersionNumbers


Func CopySetupFilesToWebFolder()
	; Copy the setup files to the web folder
	If Not FileExists($ProjectWebSiteFolder & "\") Then
		DirCreate($ProjectWebSiteFolder & "\")
	EndIf
	; Copy the setup files to the web folder
	FileCopy($ProjectFolder & "\Release\" & $OutputFilename, $ProjectWebSiteFolder & "\", 1)
	FileCopy($AutoUpdateFolder & "\" & $AutoUpdateRemoteINIFilename, $ProjectWebSiteFolder & "\", 1)

	; Copy help files
	DirCopy($HTMLHelpOutputFolder, $ProjectWebSiteHelpFolder, 1)

	StepComplete()
EndFunc   ;==>CopySetupFilesToWebFolder


Func CreateInnoSetupPackage()
	; Create the Installer Package
	RunWait($InnoInstallationFolder & "\Compil32.exe /cc """ & @ScriptDir & "\" & $InnoInstallerFile & """")

	; Wait for the compiler to close
	;WinClose("MakeNSISW")
EndFunc   ;==>CreateInnoSetupPackage


Func ReplaceLineInFile($SourceFile, $LineToFind, $ReplacementLine)
	Local $ReadFile = FileOpen($SourceFile, 0)
	Local $WriteFile = FileOpen($SourceFile & "tmp", 2)
	; Check if file opened for reading OK
	If $ReadFile <> -1 Then
		; Read in lines of text until the EOF is reached#region --- GuiBuilder code Start ---
		While 1
			Local $line = FileReadLine($ReadFile)
			If @error = -1 Then ExitLoop
			If StringInStr($line, $LineToFind) Then
				$line = $ReplacementLine
			EndIf
			FileWriteLine($WriteFile, $line)
		WEnd
	EndIf
	FileClose($ReadFile)
	FileClose($WriteFile)
	FileDelete($SourceFile)
	FileMove($SourceFile & "tmp", $SourceFile)
EndFunc   ;==>ReplaceLineInFile


Func StepComplete()
	#Region --- CodeWizard generated code Start ---
	;MsgBox features: Title=Yes, Text=Yes, Buttons=OK, Icon=Info
	MsgBox(64, "Release Creator", "Action Completed.")
	#EndRegion --- CodeWizard generated code Start ---
EndFunc   ;==>StepComplete


Func FindNewVersionNumber()
	$ReleaseVersion = _FindLatestVersionNumberFromLocalHTML($WhatsNew)
EndFunc   ;==>FindNewVersionNumber
