. ".\common.ps1"

## TODO 需要修改这里获取代码的方式



##获取代码并自增版本号
Write-Host "============准备获取代码==================="
##获取代码 需要系统配置好tf.exe的路径
& tf get $/Modules/lcn.identityserver_management /recursive /overwrite #强制遍历获取项目代码 其中$符号代表是工作区映射的本地文件夹

if (-Not $?) {
        Write-Host ("获取源代码失败，脚本停止继续执行，将退出 ")
        exit $LASTEXITCODE
    }
Write-Host "============完成获取代码==================="
##签出项目用于升级引用包（如果有的话）
##签出共有版本号保存地方
&tf checkout $/Modules/lcn.identityserver_management/common.props
Write-Host "============签出共同项目配置文件==================="
##定位到要操作的文件夹根
Set-Location $rootFolder

##自增版本号###

##读取xml文件
[xml]$xmlDoc = Get-Content $xmlFileName
##获取版本号
$version=$xmlDoc.Project.PropertyGroup.Version
Write-Host ("当前版本"+$version)
##移动备份
##$otherFileName=Join-Path $rootFolder ("/common"+$version+".props")
##Move-Item $xmlFileName $otherFileName
#修改版本号
$devVersion=$version.Substring($version.LastIndexOf(".") + 1) #开发版本
##Write-Host ("开发版本"+$devVersion)
##if($devVersion -gt 100)
##{
##    Write-Host ("小等于100")
##}
##else
##{
##Write-Host("大于100")
##}
$mainVersion=$version.Substring(0,$version.LastIndexOf(".")) #主线版本
##Write-Host ("主要版本"+$mainVersion)
$intDevNo=[int]$devVersion
$intDevNo=$intDevNo+1

$xmlDoc.Project.PropertyGroup.Version =($mainVersion+"."+[string]$intDevNo)

#保存文件
$xmlDoc.Save($xmlFileName)
##chcp 3a8 #激活中文
##Write-Host "保存成功！"
Write-Host ("将更新版本号"+$xmlDoc.Project.PropertyGroup.Version)