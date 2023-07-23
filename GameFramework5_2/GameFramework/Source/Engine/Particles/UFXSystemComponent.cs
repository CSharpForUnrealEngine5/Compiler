#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
public partial class UFXSystemComponent : UPrimitiveComponent {
// FXSystemComponent
	public void SetBoolParameter(sbyte ParameterName,bool Param) {}
	public void SetIntParameter(sbyte ParameterName,int Param) {}
	public void SetFloatParameter(sbyte ParameterName,float Param) {}
	public void SetVectorParameter(sbyte ParameterName,FVector Param) {}
	public void SetColorParameter(sbyte ParameterName,FLinearColor Param) {}
	public void SetActorParameter(sbyte ParameterName,UObject Param) {}
	public UObject GetFXSystemAsset(UObject ReturnValue) { return default; }
	public void SetEmitterEnable(sbyte EmitterName,bool bNewEnableState) {}
	public void SetAutoAttachmentParameters(UObject Parent,sbyte SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule) {}
	public void SetUseAutoManageAttachment(bool bAutoManage) {}
	public void ReleaseToPool() {}
}
