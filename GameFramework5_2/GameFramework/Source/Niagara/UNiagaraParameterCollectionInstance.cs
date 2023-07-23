#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterCollection.h")]
public partial class UNiagaraParameterCollectionInstance : UObject {
// NiagaraParameterCollectionInstance
	public UNiagaraParameterCollection Collection;
	public TArray<FNiagaraVariable> OverridenParameters;
	public FNiagaraParameterStore ParameterStorage;
	public bool GetBoolParameter(sbyte InVariableName,bool ReturnValue) { return default; }
	public float GetFloatParameter(sbyte InVariableName,float ReturnValue) { return default; }
	public int GetIntParameter(sbyte InVariableName,int ReturnValue) { return default; }
	public FVector2D GetVector2DParameter(sbyte InVariableName,FVector2D ReturnValue) { return default; }
	public FVector GetVectorParameter(sbyte InVariableName,FVector ReturnValue) { return default; }
	public FVector4 GetVector4Parameter(sbyte InVariableName,FVector4 ReturnValue) { return default; }
	public FQuat GetQuatParameter(sbyte InVariableName,FQuat ReturnValue) { return default; }
	public FLinearColor GetColorParameter(sbyte InVariableName,FLinearColor ReturnValue) { return default; }
	public void SetBoolParameter(sbyte InVariableName,bool InValue) {}
	public void SetFloatParameter(sbyte InVariableName,float InValue) {}
	public void SetIntParameter(sbyte InVariableName,int InValue) {}
	public void SetVector2DParameter(sbyte InVariableName,FVector2D InValue) {}
	public void SetVectorParameter(sbyte InVariableName,FVector InValue) {}
	public void SetVector4Parameter(sbyte InVariableName,FVector4 InValue) {}
	public void SetColorParameter(sbyte InVariableName,FLinearColor InValue) {}
	public void SetQuatParameter(sbyte InVariableName,FQuat InValue) {}
}
