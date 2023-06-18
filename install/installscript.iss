#define Name = "ContactsApp"
#define Version = "1.0.0"       
#define Publisher = "Kovalev"
#define URL = "https://github.com/kovalev70"
#define SourseFolder = "src\ContactsApp\ContactsApp.View\bin\Release\net6.0-windows\"

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
Source: "{#SourcePath}\\..\\{#SourseFolder}\*.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\\..\\{#SourseFolder}\*.dll"  ; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\\..\\{#SourseFolder}\*.runtimeconfig.json"  ; DestDir: "{app}"; Flags: ignoreversion 

[UninstallDelete]
Type: filesandordirs; Name: {app};