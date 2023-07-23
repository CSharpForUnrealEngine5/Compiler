#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
public partial struct FNiagaraModuleDependency {
// NiagaraModuleDependency
	public sbyte Id;
	public ENiagaraModuleDependencyType Type;
	public ENiagaraModuleDependencyScriptConstraint ScriptConstraint;
	public sbyte RequiredVersion;
	public int OnlyEvaluateInScriptUsage;
	public sbyte Description;
}
