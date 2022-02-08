
##把脚本执行路径导向到当前文件夹 
Set-Location $PSScriptRoot 

# 路径
$packFolder = (Get-Item -Path "./" -Verbose).FullName #当前包路径
$rootFolder = Join-Path $packFolder "../"  #解决方案路径
$xmlFileName =Join-Path $rootFolder "./common.props" ##获取要修改的公共信息版本号
Write-Host $xmlFileName

$solutions= Get-ChildItem -Path $rootFolder -Filter *.sln
$solution_name="lcn.identityserver_management"

if($solutions.count -ge 1)
{

$solution_name=$solutions[0].BaseName
}
Write-Host "解决方案名称："+$solution_name
##项目所在位置，把lcn.identityserver_management修改成实际的项目名称就可以了
$projects =(
("src/"+$solution_name+".Application"),
("src/"+$solution_name+".Application.Contracts"),
("src/"+$solution_name+".Domain"),
("src/"+$solution_name+".Domain.Shared"),
("src/"+$solution_name+".EntityFrameworkCore"),
("src/"+$solution_name+".HttpApi")
)

Write-Host "加载完成路径，下一个打包！"

foreach($project in $projects) {
Write-Host $project

}