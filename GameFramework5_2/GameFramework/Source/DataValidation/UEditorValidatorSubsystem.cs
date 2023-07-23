#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorValidatorSubsystem.h")]
///<summary>UEditorValidatorSubsystem manages all the asset validation in the engine.</summary>
public partial class UEditorValidatorSubsystem : UEditorSubsystem {
// EditorValidatorSubsystem
	public void AddValidator(UObject InValidator) {}
	public EDataValidationResult IsObjectValid(UObject InObject,TArray<sbyte> ValidationErrors,TArray<sbyte> ValidationWarnings,EDataValidationUsecase InValidationUsecase,EDataValidationResult ReturnValue) { return default; }
	public EDataValidationResult IsAssetValid(FAssetData AssetData,TArray<sbyte> ValidationErrors,TArray<sbyte> ValidationWarnings,EDataValidationUsecase InValidationUsecase,EDataValidationResult ReturnValue) { return default; }
	public int ValidateAssetsWithSettings(TArray<FAssetData> AssetDataList,FValidateAssetsSettings InSettings,FValidateAssetsResults OutResults,int ReturnValue) { return default; }
	public int ValidateAssets(TArray<FAssetData> AssetDataList,bool bSkipExcludedDirectories=true,bool bShowIfNoFailures=true,int ReturnValue) { return default; }
	public TArray<FDirectoryPath> ExcludedDirectories;
	public bool bValidateOnSave;
	public TMap<sbyte,UEditorValidatorBase> Validators;
	public bool bValidateAssetsWhileSavingForCook;
	public bool bAllowBlueprintValidators;
}
