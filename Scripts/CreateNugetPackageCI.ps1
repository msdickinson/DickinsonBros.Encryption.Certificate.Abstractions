$Name = "DickinsonBros.Encryption.Certificate.Abstractions"
$DateTime = [datetime]::UtcNow.ToString("yyyyMMdd-HHmmss")
$VersionSuffix = "-alpha" + $DateTime
dotnet pack $Name --version-suffix $VersionSuffix --output C:\Packages