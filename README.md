[![CI](https://github.com/nitro-codes/csts-codegen/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/nitro-codes/csts-codegen/actions/workflows/ci.yml)

## Usage

### .csproj (project file)

```XML
<Project Sdk="Microsoft.NET.Sdk.Web">

  //...

  <Target Name="BuildInterfaces" BeforeTargets="PrepareForBuild">
    <CoderTask InputDirectory="Dtos\" OutputDirectory="..\src\app\dtos\" PathStyle="Kebab" />
  </Target>
  
</Project>
```

## Notes

**The destination directory is always deleted prior to generation**