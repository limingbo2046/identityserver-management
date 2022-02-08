. ".\update_version.ps1" #执行更新版本

# Rebuild all solutions 重新生成所有解决方案
#foreach($solution in $solutions) {
#    $solutionFolder = Join-Path $rootFolder $solution
#    Set-Location $solutionFolder
#    & dotnet restore
#}

#因为我们只有一个解决方案,那就去到该解决方案进行还原包
Set-Location $rootFolder
##解决方案还原包
& dotnet restore

# Create all packages #对项目进行打包
foreach($project in $projects) {
    
    $projectFolder = Join-Path $rootFolder $project
	#Write-Host "项目:"
    #Write-Host $projectFolder
    # Create nuget pack
    Set-Location $projectFolder
    Remove-Item -Recurse (Join-Path $projectFolder "bin/Release") #删除发布文件夹
    & dotnet build -c Release ##生成
    if (-Not $?) {
        Write-Host ("生成失败，失败项目: " + $projectFolder)
        exit $LASTEXITCODE
    }

    & dotnet pack -c Release ##打包

    if (-Not $?) {
        Write-Host ("打包失败，失败项目: " + $projectFolder)
        exit $LASTEXITCODE
    }

    ##版本
    [xml]$commonPropsXml = Get-Content (Join-Path $rootFolder "common.props")#拿到common的版本号
    $version = $commonPropsXml.Project.PropertyGroup.Version

    # Copy nuget package 拷贝nuget
    $projectName = $project.Substring($project.LastIndexOf("/") + 1)
    $projectPackPath = Join-Path $projectFolder ("/bin/Release/" + $projectName + ".$version.nupkg")
    #Write-Host $projectName
    Move-Item $projectPackPath $packFolder
    ##把项目路径留空
    $projectFolder=""
}
##回到脚本包的位置
# Go back to the pack folder
Set-Location $packFolder