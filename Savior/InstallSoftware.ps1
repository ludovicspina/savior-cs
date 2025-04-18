param (
    [string]$softwareName
)

function Install-VLC {
    $url = "https://get.videolan.org/vlc/3.0.17.4/win64/vlc-3.0.17.4-win64.exe"
    $installerPath = "vlc-installer.exe"
    Invoke-WebRequest -Uri $url -OutFile $installerPath
    Start-Process -FilePath $installerPath -ArgumentList "/S" -Wait
    Remove-Item $installerPath
}

function Install-7Zip {
    $url = "https://www.7-zip.org/a/7z1900-x64.exe"
    $installerPath = "7zip-installer.exe"
    Invoke-WebRequest -Uri $url -OutFile $installerPath
    Start-Process -FilePath $installerPath -ArgumentList "/S" -Wait
    Remove-Item $installerPath
}

switch ($softwareName) {
    "vlc" { Install-VLC }
    "7zip" { Install-7Zip }
    default { Write-Host "Logiciel non pris en charge : $softwareName" }
}
