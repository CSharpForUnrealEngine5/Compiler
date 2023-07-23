#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetSystemLibrary.h")]
public partial class UKismetSystemLibrary : UBlueprintFunctionLibrary {
// KismetSystemLibrary
	public void StackTrace() {}
	public bool IsValid(UObject Object,bool ReturnValue) { return default; }
	public bool IsValidClass(UClass Class,bool ReturnValue) { return default; }
	public sbyte GetObjectName(UObject Object,sbyte ReturnValue) { return default; }
	public sbyte GetPathName(UObject Object,sbyte ReturnValue) { return default; }
	public FSoftObjectPath GetSoftObjectPath(UObject Object,FSoftObjectPath ReturnValue) { return default; }
	public sbyte GetSystemPath(UObject Object,sbyte ReturnValue) { return default; }
	public sbyte GetDisplayName(UObject Object,sbyte ReturnValue) { return default; }
	public sbyte GetClassDisplayName(UClass Class,sbyte ReturnValue) { return default; }
	public FSoftClassPath GetSoftClassPath(UClass Class,FSoftClassPath ReturnValue) { return default; }
	public UObject GetOuterObject(UObject Object,UObject ReturnValue) { return default; }
	public sbyte GetEngineVersion(sbyte ReturnValue) { return default; }
	public sbyte GetBuildVersion(sbyte ReturnValue) { return default; }
	public sbyte GetBuildConfiguration(sbyte ReturnValue) { return default; }
	public sbyte GetGameName(sbyte ReturnValue) { return default; }
	public sbyte GetProjectDirectory(sbyte ReturnValue) { return default; }
	public sbyte GetProjectContentDirectory(sbyte ReturnValue) { return default; }
	public sbyte GetProjectSavedDirectory(sbyte ReturnValue) { return default; }
	public sbyte ConvertToRelativePath(sbyte Filename,sbyte ReturnValue) { return default; }
	public sbyte ConvertToAbsolutePath(sbyte Filename,sbyte ReturnValue) { return default; }
	public sbyte NormalizeFilename(sbyte InFilename,sbyte ReturnValue) { return default; }
	public sbyte GetGameBundleId(sbyte ReturnValue) { return default; }
	public sbyte GetPlatformUserName(sbyte ReturnValue) { return default; }
	public sbyte GetPlatformUserDir(sbyte ReturnValue) { return default; }
	public bool DoesImplementInterface(UObject TestObject,UClass Interface,bool ReturnValue) { return default; }
	public double GetGameTimeInSeconds(UObject WorldContextObject,double ReturnValue) { return default; }
	public long GetFrameCount(long ReturnValue) { return default; }
	public bool IsServer(UObject WorldContextObject,bool ReturnValue) { return default; }
	public bool IsDedicatedServer(UObject WorldContextObject,bool ReturnValue) { return default; }
	public bool IsStandalone(UObject WorldContextObject,bool ReturnValue) { return default; }
	public bool IsSplitScreen(UObject WorldContextObject,bool ReturnValue) { return default; }
	public bool HasMultipleLocalPlayers(UObject WorldContextObject,bool ReturnValue) { return default; }
	public bool IsPackagedForDistribution(bool ReturnValue) { return default; }
	public sbyte GetUniqueDeviceId(sbyte ReturnValue) { return default; }
	public sbyte GetDeviceId(sbyte ReturnValue) { return default; }
	public UClass Conv_ObjectToClass(UObject Object,UClass Class,UClass ReturnValue) { return default; }
	public UObject Conv_InterfaceToObject(object /*Interface*/ Interface,UObject ReturnValue) { return default; }
	public FSoftObjectPath MakeSoftObjectPath(sbyte PathString,FSoftObjectPath ReturnValue) { return default; }
	public void BreakSoftObjectPath(FSoftObjectPath InSoftObjectPath,sbyte PathString) {}
	public TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef(FSoftObjectPath SoftObjectPath,TSoftObjectPtr<UObject> ReturnValue) { return default; }
	public FSoftObjectPath Conv_SoftObjRefToSoftObjPath(TSoftObjectPtr<UObject> SoftObjectReference,FSoftObjectPath ReturnValue) { return default; }
	public FTopLevelAssetPath MakeTopLevelAssetPath(sbyte PackageName,sbyte AssetName,FTopLevelAssetPath ReturnValue) { return default; }
	public void BreakTopLevelAssetPath(FTopLevelAssetPath TopLevelAssetPath,sbyte PathString) {}
	public FSoftClassPath MakeSoftClassPath(sbyte PathString,FSoftClassPath ReturnValue) { return default; }
	public void BreakSoftClassPath(FSoftClassPath InSoftClassPath,sbyte PathString) {}
	public TSoftObjectPtr<UClass> Conv_SoftClassPathToSoftClassRef(FSoftClassPath SoftClassPath,TSoftObjectPtr<UClass> ReturnValue) { return default; }
	public FSoftClassPath Conv_SoftObjRefToSoftClassPath(TSoftObjectPtr<UClass> SoftClassReference,FSoftClassPath ReturnValue) { return default; }
	public bool IsValidSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference,bool ReturnValue) { return default; }
	public sbyte Conv_SoftObjectReferenceToString(TSoftObjectPtr<UObject> SoftObjectReference,sbyte ReturnValue) { return default; }
	public bool EqualEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B,bool ReturnValue) { return default; }
	public bool NotEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B,bool ReturnValue) { return default; }
	public UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset,UObject ReturnValue) { return default; }
	public bool IsValidSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference,bool ReturnValue) { return default; }
	public sbyte Conv_SoftClassReferenceToString(TSoftObjectPtr<UClass> SoftClassReference,sbyte ReturnValue) { return default; }
	public bool EqualEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B,bool ReturnValue) { return default; }
	public bool NotEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B,bool ReturnValue) { return default; }
	public UClass LoadClassAsset_Blocking(TSoftObjectPtr<UClass> AssetClass,UClass ReturnValue) { return default; }
	public UObject Conv_SoftObjectReferenceToObject(TSoftObjectPtr<UObject> SoftObject,UObject ReturnValue) { return default; }
	public UClass Conv_SoftClassReferenceToClass(TSoftObjectPtr<UClass> SoftClass,UClass ReturnValue) { return default; }
	public TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference(UObject Object,TSoftObjectPtr<UObject> ReturnValue) { return default; }
	public TSoftObjectPtr<UClass> Conv_ClassToSoftClassReference(UClass Class,TSoftObjectPtr<UClass> ReturnValue) { return default; }
	public void FOnAssetLoaded(UObject Loaded) {}
	public void LoadAsset(UObject WorldContextObject,TSoftObjectPtr<UObject> Asset,FOnAssetLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	public void FOnAssetClassLoaded(UClass Loaded) {}
	public void LoadAssetClass(UObject WorldContextObject,TSoftObjectPtr<UClass> AssetClass,FOnAssetClassLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	public int MakeLiteralInt(int Value,int ReturnValue) { return default; }
	public long MakeLiteralInt64(long Value,long ReturnValue) { return default; }
	public double MakeLiteralDouble(double Value,double ReturnValue) { return default; }
	public bool MakeLiteralBool(bool Value,bool ReturnValue) { return default; }
	public sbyte MakeLiteralName(sbyte Value,sbyte ReturnValue) { return default; }
	public byte MakeLiteralByte(byte Value,byte ReturnValue) { return default; }
	public sbyte MakeLiteralString(sbyte Value,sbyte ReturnValue) { return default; }
	public sbyte MakeLiteralText(sbyte Value,sbyte ReturnValue) { return default; }
	public void LogString(sbyte InString=FString,bool bPrintToLog=true) {}
	public void PrintString(UObject WorldContextObject,sbyte InString=FString,bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=FLinearColor,float Duration=2.f,sbyte Key=NAME_None) {}
	public void PrintText(UObject WorldContextObject,sbyte InText=INVTEXT,bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=FLinearColor,float Duration=2.f,sbyte Key=NAME_None) {}
	public void PrintWarning(sbyte InString) {}
	public void SetWindowTitle(sbyte Title) {}
	public void ExecuteConsoleCommand(UObject WorldContextObject,sbyte Command,UObject SpecificPlayer=NULL) {}
	public sbyte GetConsoleVariableStringValue(sbyte VariableName,sbyte ReturnValue) { return default; }
	public float GetConsoleVariableFloatValue(sbyte VariableName,float ReturnValue) { return default; }
	public int GetConsoleVariableIntValue(sbyte VariableName,int ReturnValue) { return default; }
	public bool GetConsoleVariableBoolValue(sbyte VariableName,bool ReturnValue) { return default; }
	public void QuitGame(UObject WorldContextObject,UObject SpecificPlayer,byte QuitPreference,bool bIgnorePlatformRestrictions) {}
	public void QuitEditor() {}
	public void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	public void DelayUntilNextTick(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	public void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	public void MoveComponentTo(UObject Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,byte MoveAction,FLatentActionInfo LatentInfo) {}
	public FTimerHandle K2_SetTimerDelegate(FTimerDynamicDelegate Delegate,float Time,bool bLooping,float InitialStartDelay=0.f,float InitialStartDelayVariance=0.f,FTimerHandle ReturnValue) { return default; }
	public FTimerHandle K2_SetTimerForNextTickDelegate(FTimerDynamicDelegate Delegate,FTimerHandle ReturnValue) { return default; }
	public void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate,bool ReturnValue) { return default; }
	public bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate,bool ReturnValue) { return default; }
	public bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate,bool ReturnValue) { return default; }
	public float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate,float ReturnValue) { return default; }
	public float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate,float ReturnValue) { return default; }
	public bool K2_IsValidTimerHandle(FTimerHandle Handle,bool ReturnValue) { return default; }
	public FTimerHandle K2_InvalidateTimerHandle(FTimerHandle Handle,FTimerHandle ReturnValue) { return default; }
	public void K2_ClearTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public void K2_PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public void K2_UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public bool K2_IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle,bool ReturnValue) { return default; }
	public bool K2_IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle,bool ReturnValue) { return default; }
	public bool K2_TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle,bool ReturnValue) { return default; }
	public float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle,float ReturnValue) { return default; }
	public float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle,float ReturnValue) { return default; }
	public FTimerHandle K2_SetTimer(UObject Object,sbyte FunctionName,float Time,bool bLooping,float InitialStartDelay=0.f,float InitialStartDelayVariance=0.f,FTimerHandle ReturnValue) { return default; }
	public FTimerHandle K2_SetTimerForNextTick(UObject Object,sbyte FunctionName,FTimerHandle ReturnValue) { return default; }
	public void K2_ClearTimer(UObject Object,sbyte FunctionName) {}
	public void K2_PauseTimer(UObject Object,sbyte FunctionName) {}
	public void K2_UnPauseTimer(UObject Object,sbyte FunctionName) {}
	public bool K2_IsTimerActive(UObject Object,sbyte FunctionName,bool ReturnValue) { return default; }
	public bool K2_IsTimerPaused(UObject Object,sbyte FunctionName,bool ReturnValue) { return default; }
	public bool K2_TimerExists(UObject Object,sbyte FunctionName,bool ReturnValue) { return default; }
	public float K2_GetTimerElapsedTime(UObject Object,sbyte FunctionName,float ReturnValue) { return default; }
	public float K2_GetTimerRemainingTime(UObject Object,sbyte FunctionName,float ReturnValue) { return default; }
	public void SetIntPropertyByName(UObject Object,sbyte PropertyName,int Value) {}
	public void SetInt64PropertyByName(UObject Object,sbyte PropertyName,long Value) {}
	public void SetBytePropertyByName(UObject Object,sbyte PropertyName,byte Value) {}
	public void SetDoublePropertyByName(UObject Object,sbyte PropertyName,double Value) {}
	public void SetBoolPropertyByName(UObject Object,sbyte PropertyName,bool Value) {}
	public void SetObjectPropertyByName(UObject Object,sbyte PropertyName,UObject Value) {}
	public void SetClassPropertyByName(UObject Object,sbyte PropertyName,UClass Value) {}
	public void SetInterfacePropertyByName(UObject Object,sbyte PropertyName,object /*Value*/ Value) {}
	public void SetNamePropertyByName(UObject Object,sbyte PropertyName,sbyte Value) {}
	public void SetSoftObjectPropertyByName(UObject Object,sbyte PropertyName,TSoftObjectPtr<UObject> Value) {}
	public void SetSoftClassPropertyByName(UObject Object,sbyte PropertyName,TSoftObjectPtr<UClass> Value) {}
	public void SetStringPropertyByName(UObject Object,sbyte PropertyName,sbyte Value) {}
	public void SetTextPropertyByName(UObject Object,sbyte PropertyName,sbyte Value) {}
	public void SetVectorPropertyByName(UObject Object,sbyte PropertyName,FVector Value) {}
	public void SetVector3fPropertyByName(UObject Object,sbyte PropertyName,FVector3f Value) {}
	public void SetRotatorPropertyByName(UObject Object,sbyte PropertyName,FRotator Value) {}
	public void SetLinearColorPropertyByName(UObject Object,sbyte PropertyName,FLinearColor Value) {}
	public void SetColorPropertyByName(UObject Object,sbyte PropertyName,FColor Value) {}
	public void SetTransformPropertyByName(UObject Object,sbyte PropertyName,FTransform Value) {}
	public void SetCollisionProfileNameProperty(UObject Object,sbyte PropertyName,FCollisionProfileName Value) {}
	public void SetFieldPathPropertyByName(UObject Object,sbyte PropertyName,object Value) {}
	public void SetStructurePropertyByName(UObject Object,sbyte PropertyName,FGenericStruct Value) {}
	public bool SphereOverlapActors(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors,bool ReturnValue) { return default; }
	public bool SphereOverlapComponents(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents,bool ReturnValue) { return default; }
	public bool BoxOverlapActors(UObject WorldContextObject,FVector BoxPos,FVector BoxExtent,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors,bool ReturnValue) { return default; }
	public bool BoxOverlapComponents(UObject WorldContextObject,FVector BoxPos,FVector Extent,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents,bool ReturnValue) { return default; }
	public bool CapsuleOverlapActors(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors,bool ReturnValue) { return default; }
	public bool CapsuleOverlapComponents(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents,bool ReturnValue) { return default; }
	public bool ComponentOverlapActors(UObject Component,FTransform ComponentTransform,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors,bool ReturnValue) { return default; }
	public bool ComponentOverlapComponents(UObject Component,FTransform ComponentTransform,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents,bool ReturnValue) { return default; }
	public bool LineTraceSingle(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool LineTraceMulti(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool SphereTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool SphereTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool BoxTraceSingle(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool BoxTraceMulti(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool CapsuleTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool CapsuleTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool LineTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool LineTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool SphereTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool SphereTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool BoxTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool BoxTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool CapsuleTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool CapsuleTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool LineTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool LineTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool SphereTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool SphereTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool BoxTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool BoxTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool CapsuleTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public bool CapsuleTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,sbyte ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor=FLinearColor,FLinearColor TraceHitColor=FLinearColor,float DrawTime=5.0f,bool ReturnValue) { return default; }
	public void GetActorListFromComponentList(TArray<UObject> ComponentList,UClass ActorClassFilter,TArray<UObject> OutActorList) {}
	public void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments=12,FLinearColor LineColor=FLinearColor,float Duration=0.f,float Thickness=0.f,FVector YAxis=FVector,FVector ZAxis=FVector,bool bDrawAxis=false) {}
	public void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration=0.f) {}
	public void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation=FRotator,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale=1.f,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius=100.f,int Segments=12,FLinearColor LineColor=FLinearColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius=100.f,int Segments=12,FLinearColor LineColor=FLinearColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugCone(UObject WorldContextObject,FVector Origin,FVector Direction,float Length,float AngleWidth,float AngleHeight,int NumSides,FLinearColor LineColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length=100.f,float AngleWidth=45.f,float AngleHeight=45.f,int NumSides=12,FLinearColor LineColor=FLinearColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor=FLinearColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugString(UObject WorldContextObject,FVector TextLocation,sbyte Text,UObject TestBaseActor=NULL,FLinearColor TextColor=FLinearColor,float Duration=0.f) {}
	public void FlushDebugStrings(UObject WorldContextObject) {}
	public void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor=FLinearColor,float Duration=0.f) {}
	public void FlushPersistentDebugLines(UObject WorldContextObject) {}
	public void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor=FLinearColor,float Duration=0.f,float Thickness=0.f) {}
	public void DrawDebugCamera(UObject CameraActor,FLinearColor CameraColor=FLinearColor,float Duration=0.f) {}
	public void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor=FLinearColor,float Duration=0.f) {}
	public void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor=FLinearColor,float Duration=0.f) {}
	public FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory,FDebugFloatHistory ReturnValue) { return default; }
	public void CreateCopyForUndoBuffer(UObject ObjectToModify) {}
	public void GetComponentBounds(UObject Component,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public void GetActorBounds(UObject Actor,FVector Origin,FVector BoxExtent) {}
	public int GetRenderingDetailMode(int ReturnValue) { return default; }
	public int GetRenderingMaterialQualityLevel(int ReturnValue) { return default; }
	public bool GetSupportedFullscreenResolutions(TArray<FIntPoint> Resolutions,bool ReturnValue) { return default; }
	public bool GetConvenientWindowedResolutions(TArray<FIntPoint> Resolutions,bool ReturnValue) { return default; }
	public int GetMinYResolutionForUI(int ReturnValue) { return default; }
	public int GetMinYResolutionFor3DView(int ReturnValue) { return default; }
	public void LaunchURL(sbyte URL) {}
	public bool CanLaunchURL(sbyte URL,bool ReturnValue) { return default; }
	public void CollectGarbage() {}
	public void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen) {}
	public int GetAdIDCount(int ReturnValue) { return default; }
	public void HideAdBanner() {}
	public void ForceCloseAdBanner() {}
	public void LoadInterstitialAd(int AdIdIndex) {}
	public bool IsInterstitialAdAvailable(bool ReturnValue) { return default; }
	public bool IsInterstitialAdRequested(bool ReturnValue) { return default; }
	public void ShowInterstitialAd() {}
	public void ShowPlatformSpecificLeaderboardScreen(sbyte CategoryName) {}
	public void ShowPlatformSpecificAchievementsScreen(UObject SpecificPlayer) {}
	public bool IsLoggedIn(UObject SpecificPlayer,bool ReturnValue) { return default; }
	public bool IsScreensaverEnabled(bool ReturnValue) { return default; }
	public void ControlScreensaver(bool bAllowScreenSaver) {}
	public void SetVolumeButtonsHandledBySystem(bool bEnabled) {}
	public bool GetVolumeButtonsHandledBySystem(bool ReturnValue) { return default; }
	public void SetGamepadsBlockDeviceFeedback(bool bBlock) {}
	public void ResetGamepadAssignments() {}
	public void ResetGamepadAssignmentToController(int ControllerId) {}
	public bool IsControllerAssignedToGamepad(int ControllerId,bool ReturnValue) { return default; }
	public sbyte GetGamepadControllerName(int ControllerId,sbyte ReturnValue) { return default; }
	public UObject GetGamepadButtonGlyph(sbyte ButtonKey,int ControllerIndex,UObject ReturnValue) { return default; }
	public void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState) {}
	public TArray<sbyte> GetPreferredLanguages(TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetDefaultLanguage(sbyte ReturnValue) { return default; }
	public sbyte GetDefaultLocale(sbyte ReturnValue) { return default; }
	public sbyte GetLocalCurrencyCode(sbyte ReturnValue) { return default; }
	public sbyte GetLocalCurrencySymbol(sbyte ReturnValue) { return default; }
	public void RegisterForRemoteNotifications() {}
	public void UnregisterForRemoteNotifications() {}
	public void SetUserActivity(FUserActivity UserActivity) {}
	public sbyte GetCommandLine(sbyte ReturnValue) { return default; }
	public void ParseCommandLine(sbyte InCmdLine,TArray<sbyte> OutTokens,TArray<sbyte> OutSwitches,TMap<sbyte,sbyte> OutParams) {}
	public bool ParseParam(sbyte InString,sbyte InParam,bool ReturnValue) { return default; }
	public bool ParseParamValue(sbyte InString,sbyte InParam,sbyte OutValue,bool ReturnValue) { return default; }
	public bool IsUnattended(bool ReturnValue) { return default; }
	public bool GetEditorProperty(UObject Object,sbyte PropertyName,int PropertyValue,bool ReturnValue) { return default; }
	public bool SetEditorProperty(UObject Object,sbyte PropertyName,int PropertyValue,EPropertyAccessChangeNotifyMode ChangeNotifyMode,bool ReturnValue) { return default; }
	public int BeginTransaction(sbyte Context,sbyte Description,UObject PrimaryObject,int ReturnValue) { return default; }
	public int EndTransaction(int ReturnValue) { return default; }
	public void CancelTransaction(int Index) {}
	public void TransactObject(UObject Object) {}
	public void SnapshotObject(UObject Object) {}
	public UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId,UObject ReturnValue) { return default; }
	public UClass GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId,UClass ReturnValue) { return default; }
	public TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId,TSoftObjectPtr<UObject> ReturnValue) { return default; }
	public TSoftObjectPtr<UClass> GetSoftClassReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId,TSoftObjectPtr<UClass> ReturnValue) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromObject(UObject Object,FPrimaryAssetId ReturnValue) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromClass(UClass Class,FPrimaryAssetId ReturnValue) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference,FPrimaryAssetId ReturnValue) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference,FPrimaryAssetId ReturnValue) { return default; }
	public void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	public bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId,bool ReturnValue) { return default; }
	public sbyte Conv_PrimaryAssetIdToString(FPrimaryAssetId PrimaryAssetId,sbyte ReturnValue) { return default; }
	public bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B,bool ReturnValue) { return default; }
	public bool NotEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B,bool ReturnValue) { return default; }
	public bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType,bool ReturnValue) { return default; }
	public sbyte Conv_PrimaryAssetTypeToString(FPrimaryAssetType PrimaryAssetType,sbyte ReturnValue) { return default; }
	public bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B,bool ReturnValue) { return default; }
	public bool NotEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B,bool ReturnValue) { return default; }
	public void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId) {}
	public void UnloadPrimaryAssetList(TArray<FPrimaryAssetId> PrimaryAssetIdList) {}
	public bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId,bool bForceCurrentState,TArray<sbyte> OutBundles,bool ReturnValue) { return default; }
	public void GetPrimaryAssetsWithBundleState(TArray<sbyte> RequiredBundles,TArray<sbyte> ExcludedBundles,TArray<FPrimaryAssetType> ValidTypes,bool bForceCurrentState,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	public FARFilter MakeARFilter(TArray<sbyte> PackageNames,TArray<sbyte> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<sbyte> ClassNames,TSet<sbyte> RecursiveClassesExclusionSet,bool bRecursivePaths=false,bool bRecursiveClasses=false,bool bIncludeOnlyOnDiskAssets=false,FARFilter ReturnValue) { return default; }
	public void BreakARFilter(FARFilter InARFilter,TArray<sbyte> PackageNames,TArray<sbyte> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<sbyte> ClassNames,TSet<sbyte> RecursiveClassesExclusionSet,bool bRecursivePaths,bool bRecursiveClasses,bool bIncludeOnlyOnDiskAssets) {}
}
