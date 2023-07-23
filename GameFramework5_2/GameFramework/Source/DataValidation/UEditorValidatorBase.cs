#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorValidatorBase.h")]
///<summary>* The EditorValidatorBase is a class which verifies that an asset meets a specific ruleset.</summary>
public partial class UEditorValidatorBase : UObject {
// EditorValidatorBase
	public bool CanValidate(EDataValidationUsecase InUsecase,bool ReturnValue) { return default; }
	public bool CanValidateAsset(UObject InAsset,bool ReturnValue) { return default; }
	public EDataValidationResult ValidateLoadedAsset(UObject InAsset,TArray<sbyte> ValidationErrors,EDataValidationResult ReturnValue) { return default; }
	public void AssetFails(UObject InAsset,sbyte InMessage,TArray<sbyte> ValidationErrors) {}
	public void AssetPasses(UObject InAsset) {}
	public void AssetWarning(UObject InAsset,sbyte InMessage) {}
	public EDataValidationResult GetValidationResult(EDataValidationResult ReturnValue) { return default; }
	public bool bIsEnabled;
}
