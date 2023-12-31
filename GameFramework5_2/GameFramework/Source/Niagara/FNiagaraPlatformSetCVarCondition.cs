#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPlatformSet.h")]
///<summary>Imposes a condition that a CVar must contain a set value or range of values for a platform set to be enabled.</summary>
public partial struct FNiagaraPlatformSetCVarCondition {
// NiagaraPlatformSetCVarCondition
	public string CVarName;
	public ENiagaraCVarConditionResponse PassResponse;
	public ENiagaraCVarConditionResponse FailResponse;
	public bool Value;
	public int MinInt;
	public int MaxInt;
	public float MinFloat;
	public float MaxFloat;
	public bool bUseMinInt;
	public bool bUseMaxInt;
	public bool bUseMinFloat;
	public bool bUseMaxFloat;
}
