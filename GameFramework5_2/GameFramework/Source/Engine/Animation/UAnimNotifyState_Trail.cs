#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotifyState_Trail.h")]
public partial class UAnimNotifyState_Trail : UAnimNotifyState {
// AnimNotifyState_Trail
	public UParticleSystem PSTemplate;
	public UObject OverridePSTemplate(UObject MeshComp,UObject Animation,UObject ReturnValue) { return default; }
	public sbyte FirstSocketName;
	public sbyte SecondSocketName;
	public byte WidthScaleMode;
	public sbyte WidthScaleCurve;
	public bool bRecycleSpawnedSystems;
	public bool bRenderGeometry;
	public bool bRenderSpawnPoints;
	public bool bRenderTangents;
	public bool bRenderTessellation;
}
