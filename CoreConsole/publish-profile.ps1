
dotnet restore

$Dir = get-childitem .\
$List = $Dir | where {$_.extension -eq ".csproj"}
$items = $List | format-table name
$List | ForEach {
$_
$file = [xml](gc .\$_)
$file

$Platforms = $file.Project.PropertyGroup.RuntimeIdentifiers

$Platforms.Split(";") | ForEach {
$_
dotnet publish -c Release -r $_ 
}

}



