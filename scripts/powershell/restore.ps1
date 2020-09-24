$Projects = @('eShopClone.Catalog.Domain', 'eShopClone.Catalog.Application', 'eShopClone.Catalog.Infrastructure', 'eShopClone.Catalog.Api')

Foreach($Project in $Projects)
{
    Write-host "Restoring dependencies for"$Project 
    $Path = $PSScriptRoot + '\..\..\src\' + $Project + '\' + $Project + '.csproj'
    dotnet restore $Path
    Write-host
}