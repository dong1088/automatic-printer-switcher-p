; Inno Setup Script for PrinterSwitcher v2.4.0
; Author: Automatic Printer Switcher Plus Team

[Setup]
AppName=Automatic Printer Switcher Plus
AppVersion=2.4.0
AppPublisher=Automatic Printer Switcher Plus Team
AppPublisherURL=https://github.com/dong1088/automatic-printer-switcher-p
AppSupportURL=https://github.com/dong1088/automatic-printer-switcher-p/issues
DefaultDirName={autopf}\PrinterSwitcher
DefaultGroupName=Automatic Printer Switcher Plus
OutputDir=..\release
OutputBaseFilename=PrinterSwitcher-2.4.0-setup
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=lowest
UninstallDisplayIcon={app}\PrinterSwitcher.exe
UninstallDisplayName=Automatic Printer Switcher Plus
SetupIconFile=icon.ico
LicenseFile=..\LICENSE

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "chinesesimplified"; MessagesFile: "compiler:Languages\ChineseSimplified.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "bin\Release\net8.0-windows\PrinterSwitcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\net8.0-windows\PrinterSwitcher.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\net8.0-windows\PrinterSwitcher.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\net8.0-windows\System.Text.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\net8.0-windows\*.dll"; DestDir: "{app}"; Flags: ignoreversion skipifsourcedoesntexist

[Icons]
Name: "{group}\Automatic Printer Switcher Plus"; Filename: "{app}\PrinterSwitcher.exe"
Name: "{group}\{cm:UninstallProgram,Automatic Printer Switcher Plus}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\Automatic Printer Switcher Plus"; Filename: "{app}\PrinterSwitcher.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\PrinterSwitcher.exe"; Description: "{cm:LaunchProgram,Automatic Printer Switcher Plus}"; Flags: nowait postinstall skipifsilent

[Registry]
Root: HKCU; Subkey: "Software\Microsoft\Windows\CurrentVersion\Run"; ValueType: string; ValueName: "AutomaticPrinterSwitcher"; ValueData: """{app}\PrinterSwitcher.exe"" /tray"; Flags: uninsdeletevalue createvalueifdoesntexist; Check: IsAutoStart

[Code]
var
  AutoStartCheckBox: TNewCheckBox;

function IsAutoStart: Boolean;
begin
  Result := AutoStartCheckBox.Checked;
end;

procedure InitializeWizard;
begin
  AutoStartCheckBox := TNewCheckBox.Create(WizardForm);
  AutoStartCheckBox.Parent := WizardForm.SelectTasksPage;
  AutoStartCheckBox.Caption := 'Launch at Windows startup (auto-start)';
  AutoStartCheckBox.Left := WizardForm.TasksList.Left;
  AutoStartCheckBox.Top := WizardForm.TasksList.Top + WizardForm.TasksList.Height + ScaleY(8);
  AutoStartCheckBox.Width := WizardForm.TasksList.Width;
  AutoStartCheckBox.Height := ScaleY(17);
  AutoStartCheckBox.Checked := False;
end;