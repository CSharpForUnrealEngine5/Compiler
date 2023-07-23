#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheCreateParameters {
// NiagaraSimCacheCreateParameters
	public ENiagaraSimCacheAttributeCaptureMode AttributeCaptureMode;
	public bool bAllowRebasing;
	public bool bAllowDataInterfaceCaching;
	public bool bAllowInterpolation;
	public bool bAllowVelocityExtrapolation;
	public TArray<sbyte> RebaseIncludeAttributes;
	public TArray<sbyte> RebaseExcludeAttributes;
	public TArray<sbyte> InterpolationIncludeAttributes;
	public TArray<sbyte> InterpolationExcludeAttributes;
	public TArray<sbyte> ExplicitCaptureAttributes;
}
