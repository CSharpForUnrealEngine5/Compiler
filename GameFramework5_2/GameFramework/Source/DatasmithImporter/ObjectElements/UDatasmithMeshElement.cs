#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>UDatasmithMeshElement defines an actual geometry.</summary>
public partial class UDatasmithMeshElement : UDatasmithObjectElement {
// DatasmithMeshElement
	public sbyte GetFile(sbyte ReturnValue) { return default; }
	public float GetBoundingBoxWidth(float ReturnValue) { return default; }
	public float GetBoundingBoxHeight(float ReturnValue) { return default; }
	public float GetBoundingBoxDepth(float ReturnValue) { return default; }
	public FVector GetBoundingBoxSize(FVector ReturnValue) { return default; }
	public float GetLightMapArea(float ReturnValue) { return default; }
	public int GetLightmapCoordinateIndex(int ReturnValue) { return default; }
	public void SetLightmapCoordinateIndex(int UVChannel) {}
	public int GetLightmapSourceUV(int ReturnValue) { return default; }
	public void SetLightmapSourceUV(int UVChannel) {}
	public void SetMaterial(sbyte MaterialName,int SlotId) {}
	public sbyte GetMaterial(int SlotId,sbyte ReturnValue) { return default; }
}
