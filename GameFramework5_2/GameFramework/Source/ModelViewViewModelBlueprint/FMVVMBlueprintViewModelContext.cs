#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewModelContext.h")]
public partial struct FMVVMBlueprintViewModelContext {
// MVVMBlueprintViewModelContext
	public FGuid ViewModelContextId;
	public UClass NotifyFieldValueClass;
	public UClass ViewModelClass_DEPRECATED;
	public sbyte OverrideDisplayName_DEPRECATED;
	public sbyte ViewModelName;
	public EMVVMBlueprintViewModelContextCreationType CreationType;
	public sbyte GlobalViewModelIdentifier;
	public sbyte ViewModelPropertyPath;
	public bool bCreateSetterFunction;
	public bool bOptional;
}
