#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheDataBuffersLayout {
// NiagaraSimCacheDataBuffersLayout
	public sbyte LayoutName;
	public ENiagaraSimTarget SimTarget;
	public TArray<FNiagaraSimCacheVariable> Variables;
	public ushort FloatCount;
	public ushort HalfCount;
	public ushort Int32Count;
	public bool bLocalSpace;
	public bool bAllowInterpolation;
	public bool bAllowVelocityExtrapolation;
	public TArray<sbyte> RebaseVariableNames;
	public TArray<sbyte> InterpVariableNames;
	public ushort ComponentVelocity;
}
