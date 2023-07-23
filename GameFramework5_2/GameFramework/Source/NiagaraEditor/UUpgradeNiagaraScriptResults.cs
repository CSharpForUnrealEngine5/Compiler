#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpgradeNiagaraScriptResults.h")]
///<summary>Wrapper class for passing results back from the version upgrade python script.</summary>
public partial class UUpgradeNiagaraScriptResults : UObject {
// UpgradeNiagaraScriptResults
	public bool bCancelledByPythonError;
	public TArray<UNiagaraPythonScriptModuleInput> OldInputs;
	public TArray<UNiagaraPythonScriptModuleInput> NewInputs;
	public UObject GetOldInput(sbyte InputName,UObject ReturnValue) { return default; }
	public void SetFloatInput(sbyte InputName,float Value) {}
	public void SetIntInput(sbyte InputName,int Value) {}
	public void SetBoolInput(sbyte InputName,bool Value) {}
	public void SetVec2Input(sbyte InputName,FVector2D Value) {}
	public void SetVec3Input(sbyte InputName,FVector Value) {}
	public void SetVec4Input(sbyte InputName,FVector4 Value) {}
	public void SetColorInput(sbyte InputName,FLinearColor Value) {}
	public void SetQuatInput(sbyte InputName,FQuat Value) {}
	public void SetEnumInput(sbyte InputName,sbyte Value) {}
	public void SetLinkedInput(sbyte InputName,sbyte Value) {}
	public UNiagaraPythonScriptModuleInput DummyInput;
}
