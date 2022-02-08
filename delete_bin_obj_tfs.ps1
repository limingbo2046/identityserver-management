$tfs_solution =(Get-ChildItem -Filter *.vssscc )

#Remove-Item $tfs_solution -Force -Recurse

$tfs_projects=(Get-ChildItem -Filter *.vspscc )

foreach($proj in $tfs_projects)
{
Write-Host $proj.FullName
Remove-Item $proj.FullName  -Recurse
}

$bins= Get-ChildItem -Directory -Recurse -Filter bin
foreach($bin in $bins)
{
Write-Host $bin.FullName
Remove-Item $bin.FullName -Recurse
}

$objs= Get-ChildItem -Directory -Recurse -Filter obj

foreach($obj in $objs)
{
Write-Host $obj.FullName
Remove-Item $obj.FullName -Recurse
}


$vs=Get-ChildItem -Directory -Recurse -Filter vs

foreach($v in $vs)
{
Write-Host $v.FullName
}