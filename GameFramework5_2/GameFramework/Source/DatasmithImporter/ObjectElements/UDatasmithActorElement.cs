#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>* UDatasmithActorElement</summary>
public partial class UDatasmithActorElement : UDatasmithObjectElement {
// DatasmithActorElement
	public FVector GetTranslation(FVector ReturnValue) { return default; }
	public void SetTranslation(FVector Value) {}
	public FVector GetScale(FVector ReturnValue) { return default; }
	public void SetScale(FVector Value) {}
	public FQuat GetRotation(FQuat ReturnValue) { return default; }
	public void SetRotation(FQuat Value) {}
	public sbyte GetLayer(sbyte ReturnValue) { return default; }
	public void SetLayer(sbyte InLayer) {}
	public TArray<sbyte> GetTags(TArray<sbyte> ReturnValue) { return default; }
	public void SetTags(TArray<sbyte> InTags) {}
	public void AddChild(UObject InChild) {}
	public int GetChildrenCount(int ReturnValue) { return default; }
	public TArray<UObject> GetChildren(TArray<UObject> ReturnValue) { return default; }
	public void RemoveChild(UObject InChild) {}
	public bool GetVisibility(bool ReturnValue) { return default; }
	public void SetVisibility(bool bInVisibility) {}
}
