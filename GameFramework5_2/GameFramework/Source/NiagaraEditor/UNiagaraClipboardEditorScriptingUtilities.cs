#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardEditorScriptingUtilities : UObject {
// NiagaraClipboardEditorScriptingUtilities
	public void TryGetInputByName(TArray<UObject> InInputs,sbyte InInputName,bool bOutSucceeded,UObject OutInput) {}
	public void TryGetLocalValueAsFloat(UObject InInput,bool bOutSucceeded,float OutValue) {}
	public void TryGetLocalValueAsInt(UObject InInput,bool bOutSucceeded,int OutValue) {}
	public void TrySetLocalValueAsInt(UObject InInput,bool bOutSucceeded,int InValue,bool bLooseTyping=true) {}
	public sbyte GetTypeName(UObject InInput,sbyte ReturnValue) { return default; }
	public UObject CreateFloatLocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,float InLocalValue,UObject ReturnValue) { return default; }
	public UObject CreateVec2LocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector2D InVec2Value,UObject ReturnValue) { return default; }
	public UObject CreateVec3LocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,FVector InVec3Value,UObject ReturnValue) { return default; }
	public UObject CreateIntLocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,int InLocalValue,UObject ReturnValue) { return default; }
	public UObject CreateBoolLocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,bool InBoolValue,UObject ReturnValue) { return default; }
	public UObject CreateStructLocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UObject InStructValue,UObject ReturnValue) { return default; }
	public UObject CreateEnumLocalValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditCoditionValue,UObject InEnumType,int InEnumValue,UObject ReturnValue) { return default; }
	public UObject CreateLinkedValueInput(UObject InOuter,sbyte InInputName,sbyte InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,sbyte InLinkedValue,UObject ReturnValue) { return default; }
	public UObject CreateDataValueInput(UObject InOuter,sbyte InInputName,bool bInHasEditCondition,bool bInEditConditionValue,UObject InDataValue,UObject ReturnValue) { return default; }
	public UObject CreateExpressionValueInput(UObject InOuter,sbyte InInputName,sbyte InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,sbyte InExpressionValue,UObject ReturnValue) { return default; }
	public UObject CreateDynamicValueInput(UObject InOuter,sbyte InInputName,sbyte InInputTypeName,bool bInHasEditCondition,bool bInEditConditionValue,sbyte InDynamicValueName,UObject InDynamicValue,UObject ReturnValue) { return default; }
}
