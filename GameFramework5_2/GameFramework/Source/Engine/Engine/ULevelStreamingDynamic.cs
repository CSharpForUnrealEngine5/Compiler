#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelStreamingDynamic.h")]
public partial class ULevelStreamingDynamic : ULevelStreaming {
// LevelStreamingDynamic
	public bool bInitiallyLoaded;
	public bool bInitiallyVisible;
	public UObject LoadLevelInstance(UObject WorldContextObject,sbyte LevelName,FVector Location,FRotator Rotation,bool bOutSuccess,sbyte OptionalLevelNameOverride=TEXT,UClass OptionalLevelStreamingClass=nullptr,bool bLoadAsTempPackage=false,UObject ReturnValue) { return default; }
	public UObject LoadLevelInstanceBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,FVector Location,FRotator Rotation,bool bOutSuccess,sbyte OptionalLevelNameOverride=TEXT,UClass OptionalLevelStreamingClass=nullptr,bool bLoadAsTempPackage=false,UObject ReturnValue) { return default; }
}
