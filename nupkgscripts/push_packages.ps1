. "./pack.ps1"

##推送包到包服务端

[xml]$commonPropsXml = Get-Content (Join-Path $rootFolder "common.props")#拿到common的版本号
$version = $commonPropsXml.Project.PropertyGroup.Version
Write-Host ("去到目录" +$packFolder+"推送包")
Set-Location $packFolder
# Publish all packages
foreach($project in $projects) {
    $projectName = $project.Substring($project.LastIndexOf("/") + 1)
#    & dotnet nuget push ($projectName + "." + $version + ".nupkg") -s https://api.nuget.org/v3/index.json --api-key "$apiKey"
& dotnet nuget push ($projectName + "." + $version + ".nupkg") -s http://10.161.117.131:8888/nuget --api-key guang-zhou-nuget-server --skip-duplicate
}


##回到解决方案
Set-Location $rootFolder

tf checkin common.props /noprompt /comment:"更新版本"
