#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerComponent.h")]
///<summary>The ML mesh deformer component.</summary>
public partial class UMLDeformerComponent : UActorComponent {
// MLDeformerComponent
	public float GetWeight(float ReturnValue) { return default; }
	public void SetWeight(float NormalizedWeightValue) {}
	public void SetQualityLevel(int InQualityLevel) {}
	public int GetQualityLevel(int ReturnValue) { return default; }
	public UObject GetDeformerAsset(UObject ReturnValue) { return default; }
	public void SetDeformerAsset(UObject InDeformerAsset) {}
	public UObject FindSkeletalMeshComponent(UObject Asset,UObject ReturnValue) { return default; }
	public UObject GetSkeletalMeshComponent(UObject ReturnValue) { return default; }
	public void UpdateSkeletalMeshComponent() {}
	public UMLDeformerAsset DeformerAsset;
	public float Weight;
	public int QualityLevel;
	public UMLDeformerModelInstance ModelInstance;
}
