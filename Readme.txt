you have to edit the main console application and add the property specify the runtime. you can refer https://docs.microsoft.com/en-us/dotnet/core/rid-catalog for the runtime.

<PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <RuntimeIdentifiers>win10-x64;osx.10.11-x64</RuntimeIdentifiers>
</PropertyGroup>


Then run the publish-profile.ps1 which is at the root of the project folder.
We have to do a dotnet restore after adding the runtime and
then we have to do a dotnet publish

the result exe will be available at bin\Release\netcoreapp2.0

There are two ways to deploy a .NET Core application. FDD (Framework-dependent deployments) and SCD (Self-contained deployments)
SCD is what is handled by the publish-profile.ps1