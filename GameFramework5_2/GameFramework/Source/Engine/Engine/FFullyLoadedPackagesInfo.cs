#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Struct to help hold information about packages needing to be fully-loaded for DLC, etc.</summary>
public partial struct FFullyLoadedPackagesInfo {
// FullyLoadedPackagesInfo
	public byte FullyLoadType;
	public sbyte Tag;
	public TArray<sbyte> PackagesToLoad;
	public TArray<UObject> LoadedObjects;
}
