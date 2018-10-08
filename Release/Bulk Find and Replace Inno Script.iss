#define MyAppName "Bulk Find and Replace"
#define MyAppVersion "1.0.2"
#define MyAppPublisher "Steve Towner"
#define MyAppURL "http://www.thefoolonthehill.net/drupal/"
#define MyAppExeName "Bulk Find and Replace.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E331478C-B383-4958-A27D-9A48740E0AA3}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}

;Installation Pages
DisableReadyPage=True
DisableProgramGroupPage=yes

DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}

AllowUNCPath=False
UninstallDisplayIcon={uninstallexe}

; Compiler Settings
OutputDir=.
OutputBaseFilename={#MyAppName} Setup v{#MyAppVersion}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "de"; MessagesFile: "compiler:Languages\German.isl"

[Files]
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "..\Source\Bulk Find and Replace\bin\Debug\Bulk Find and Replace.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Source\Bulk Find and Replace\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Source\Bulk Find and Replace\bin\Debug\ScintillaNET.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Source\Bulk Find and Replace\bin\Debug\ScintillaNET FindReplaceDialog.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Source\Bulk Find and Replace\bin\Debug\SNT.FileFolderTextBox.3.5.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Source\Bulk Find and Replace\bin\Debug\SNT.Tools.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Auto Update\Update Program Settings.ini"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\Programming (Work)\AutoIt Scripts\Update Program\Source\InnoSetup\Update Program.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\Programming (Work)\AutoIt Scripts\Update Program\Source\InnoSetup\NoUpdate.htm"; DestDir: "{app}"; Flags: ignoreversion

[Tasks]
; This section is optional. It defines all of the user-customizable tasks Setup
; will perform during installation. These tasks appear as check boxes and radio
; buttons on the Select Additional Tasks wizard page.
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[CustomMessages]
CheckForUpdates=Check for updates

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{group}\{cm:CheckForUpdates}"; Filename: "{app}\Update Program.exe"; IconFilename: "{app}\Update Program.exe"; IconIndex: 0
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon


[ThirdParty]
UseRelativePaths=True

[Components]
; This section is optional. It defines all of the components Setup will show
; on the Select Components page of the wizard for setup type customization.

[Types]
; This section is optional. It defines all of the setup types Setup will show
; on the Select Components page of the wizard. For examle Full/Compact/Custom
[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
// shared code for installing the products
#include "scripts\products.iss"
// helper functions
#include "scripts\products\stringversion.iss"
#include "scripts\products\winversion.iss"
#include "scripts\products\fileversion.iss"
#include "scripts\products\dotnetfxversion.iss"
// actual products
#include "scripts\products\dotnetfx40client.iss"
