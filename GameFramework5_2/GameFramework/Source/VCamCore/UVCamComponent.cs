#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamComponent.h")]
///<summary>Provides a modular system for editing a UCineCameraComponent using user widgets.</summary>
public partial class UVCamComponent : USceneComponent {
// VCamComponent
	public FOnComponentReplaced OnComponentReplaced;
	public void HandleObjectReplaced(TMap<UObject,UObject> ReplacementMap) {}
	public bool SetInputProfileFromName(sbyte ProfileName,bool ReturnValue) { return default; }
	public bool AddInputProfileWithCurrentlyActiveMappings(sbyte ProfileName,bool bUpdateIfProfileAlreadyExists=true,bool ReturnValue) { return default; }
	public bool SaveCurrentInputProfileToSettings(sbyte ProfileName,bool ReturnValue) { return default; }
	public TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings(TArray<FEnhancedActionKeyMapping> ReturnValue) { return default; }
	public FKey GetPlayerMappedKey(sbyte MappingName,FKey ReturnValue) { return default; }
	public void SetEnabled(bool bNewEnabled) {}
	public bool IsEnabled(bool ReturnValue) { return default; }
	public UObject GetTargetCamera(UObject ReturnValue) { return default; }
	public bool AddModifier(sbyte Name,UClass ModifierClass,UObject CreatedModifier,bool ReturnValue) { return default; }
	public bool InsertModifier(sbyte Name,int Index,UClass ModifierClass,UObject CreatedModifier,bool ReturnValue) { return default; }
	public bool SetModifierIndex(int OriginalIndex,int NewIndex,bool ReturnValue) { return default; }
	public void RemoveAllModifiers() {}
	public bool RemoveModifier(UObject Modifier,bool ReturnValue) { return default; }
	public bool RemoveModifierByIndex(int ModifierIndex,bool ReturnValue) { return default; }
	public bool RemoveModifierByName(sbyte Name,bool ReturnValue) { return default; }
	public int GetNumberOfModifiers(int ReturnValue) { return default; }
	public void GetAllModifiers(TArray<UObject> Modifiers) {}
	public TArray<sbyte> GetAllModifierNames(TArray<sbyte> ReturnValue) { return default; }
	public UObject GetModifierByIndex(int Index,UObject ReturnValue) { return default; }
	public UObject GetModifierByName(sbyte Name,UObject ReturnValue) { return default; }
	public void GetModifiersByClass(UClass ModifierClass,TArray<UObject> FoundModifiers) {}
	public void GetModifiersByInterface(UClass InterfaceClass,TArray<UObject> FoundModifiers) {}
	public void SetModifierContextClass(UClass ContextClass,UObject CreatedContext) {}
	public UObject GetModifierContext(UObject ReturnValue) { return default; }
	public bool AddOutputProvider(UClass ProviderClass,UObject CreatedProvider,bool ReturnValue) { return default; }
	public bool InsertOutputProvider(int Index,UClass ProviderClass,UObject CreatedProvider,bool ReturnValue) { return default; }
	public bool SetOutputProviderIndex(int OriginalIndex,int NewIndex,bool ReturnValue) { return default; }
	public void RemoveAllOutputProviders() {}
	public bool RemoveOutputProvider(UObject Provider,bool ReturnValue) { return default; }
	public bool RemoveOutputProviderByIndex(int ProviderIndex,bool ReturnValue) { return default; }
	public int GetNumberOfOutputProviders(int ReturnValue) { return default; }
	public void GetAllOutputProviders(TArray<UObject> Providers) {}
	public UObject GetOutputProviderByIndex(int ProviderIndex,UObject ReturnValue) { return default; }
	public void GetOutputProvidersByClass(UClass ProviderClass,TArray<UObject> FoundProviders) {}
	public void GetLiveLinkDataForCurrentFrame(FLiveLinkCameraBlueprintData LiveLinkData) {}
	public void RegisterObjectForInput(UObject Object) {}
	public void UnregisterObjectForInput(UObject Object) {}
	public TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys(TArray<FEnhancedActionKeyMapping> ReturnValue) { return default; }
	public void InjectInputForAction(UObject Action,FInputActionValue RawValue,TArray<UObject> Modifiers,TArray<UObject> Triggers) {}
	public void InjectInputVectorForAction(UObject Action,FVector Value,TArray<UObject> Modifiers,TArray<UObject> Triggers) {}
	public FGameplayTag GetRole(FGameplayTag ReturnValue) { return default; }
	public void SetRole(FGameplayTag Value) {}
	public FLiveLinkSubjectName GetLiveLinkSubobject(FLiveLinkSubjectName ReturnValue) { return default; }
	public void SetLiveLinkSubobject(FLiveLinkSubjectName Value) {}
	public bool GetDisableComponentWhenSpawnedBySequencer(bool ReturnValue) { return default; }
	public void SetDisableComponentWhenSpawnedBySequencer(bool bValue) {}
	public bool GetDisableOutputOnMultiUserReceiver(bool ReturnValue) { return default; }
	public void SetDisableOutputOnMultiUserReceiver(bool bValue) {}
	public FVCamInputProfile GetInputProfile(FVCamInputProfile ReturnValue) { return default; }
	public void SetInputProfile(FVCamInputProfile NewInputProfile) {}
	public FVCamInputDeviceConfig GetInputDeviceSettings(FVCamInputDeviceConfig ReturnValue) { return default; }
	public void SetInputDeviceSettings(FVCamInputDeviceConfig NewInputProfile) {}
	public TArray<UObject> GetSubsystemArray(UClass Class,TArray<UObject> ReturnValue) { return default; }
	public UObject GetInputVCamSubsystem(UObject ReturnValue) { return default; }
	public bool bEnabled;
	public FGameplayTag Role;
	public FLiveLinkSubjectName LiveLinkSubject;
	public bool bLockViewportToCamera_DEPRECATED;
	public FVCamViewportLocker ViewportLocker;
	public bool bDisableComponentWhenSpawnedBySequencer;
	public bool bDisableOutputOnMultiUserReceiver;
	public float UpdateFrequencyMs;
	public EVCamTargetViewportID TargetViewport_DEPRECATED;
	public FVCamInputProfile InputProfile;
	public FVCamInputDeviceConfig InputDeviceSettings;
	public TArray<UVCamOutputProviderBase> OutputProviders;
	public UVCamModifierContext ModifierContext;
	public TArray<FModifierStackEntry> ModifierStack;
	public UInputComponent InputComponent;
	public TArray<UInputMappingContext> AppliedInputContexts;
}
