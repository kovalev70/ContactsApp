#define Name = "ContactsApp"
#define Version = "1.0.0"       
#define Publisher = "Kovalev"
#define URL = "https://github.com/kovalev70"

[Setup]
AppName={#Name}
AppVersion={#Version}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}

DefaultDirName={pf}\{#Name}
DefaultGroupName={#Name}

SetupIconFile={#SourcePath}\{#Name}.ico
Compression=lzma
SolidCompression=yes     
OutputDir={#SourcePath}\Output
OutputBaseFileName={#Name}

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkablealone
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkablealone

[Icons]
Name: "{commondesktop}\ContactsApp"; Filename: "{app}\\ContactsApp.View.exe"; IconFilename: {app}\ContactsApp.ico; Tasks: desktopicon quicklaunchicon

[Files]
Source: "{#SourcePath}\\{#Name}.ico"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs;
Source: "{#SourcePath}\\..\\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\ContactsApp.View.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\\..\\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\ContactsApp.Model.dll"  ; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs;
Source: "{#SourcePath}\\..\\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\ContactsApp.View.dll"  ; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs;
Source: "{#SourcePath}\\..\\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\Newtonsoft.Json.dll"  ; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs;
Source: "{#SourcePath}\\..\\src\ContactsApp\ContactsApp.View\bin\Debug\net6.0-windows\ContactsApp.View.runtimeconfig.json"  ; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs;
[UninstallDelete]
Type: filesandordirs; Name: {app};