#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperGroupedSpriteComponent.h")]
///<summary>A component that handles rendering and collision for many instances of one or more UPaperSprite assets.</summary>
public partial class UPaperGroupedSpriteComponent : UMeshComponent {
// PaperGroupedSpriteComponent
	public TArray<UMaterialInterface> InstanceMaterials;
	public TArray<FSpriteInstanceData> PerInstanceSpriteData;
	public int AddInstance(FTransform Transform,UObject Sprite,bool bWorldSpace=false,FLinearColor Color=FLinearColor,int ReturnValue) { return default; }
	public bool GetInstanceTransform(int InstanceIndex,FTransform OutInstanceTransform,bool bWorldSpace=false,bool ReturnValue) { return default; }
	public bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace=false,bool bMarkRenderStateDirty=true,bool bTeleport=false,bool ReturnValue) { return default; }
	public bool UpdateInstanceColor(int InstanceIndex,FLinearColor NewInstanceColor,bool bMarkRenderStateDirty=true,bool ReturnValue) { return default; }
	public bool RemoveInstance(int InstanceIndex,bool ReturnValue) { return default; }
	public void ClearInstances() {}
	public int GetInstanceCount(int ReturnValue) { return default; }
	public void SortInstancesAlongAxis(FVector WorldSpaceSortAxis) {}
}
