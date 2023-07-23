#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/PreviewGeometryActor.h")]
///<summary>UPreviewGeometry creates and manages an APreviewGeometryActor and a set of preview geometry Components.</summary>
public partial class UPreviewGeometry : UObject {
// PreviewGeometry
	public void CreateInWorld(UObject World,FTransform WithTransform) {}
	public void Disconnect() {}
	public UObject GetActor(UObject ReturnValue) { return default; }
	public UObject AddLineSet(sbyte LineSetIdentifier,UObject ReturnValue) { return default; }
	public UObject FindLineSet(sbyte LineSetIdentifier,UObject ReturnValue) { return default; }
	public bool RemoveLineSet(sbyte LineSetIdentifier,bool bDestroy,bool ReturnValue) { return default; }
	public void RemoveAllLineSets(bool bDestroy) {}
	public bool SetLineSetVisibility(sbyte LineSetIdentifier,bool bVisible,bool ReturnValue) { return default; }
	public bool SetLineSetMaterial(sbyte LineSetIdentifier,UObject NewMaterial,bool ReturnValue) { return default; }
	public void SetAllLineSetsMaterial(UObject Material) {}
	public UObject AddPointSet(sbyte PointSetIdentifier,UObject ReturnValue) { return default; }
	public UObject FindPointSet(sbyte PointSetIdentifier,UObject ReturnValue) { return default; }
	public bool RemovePointSet(sbyte PointSetIdentifier,bool bDestroy,bool ReturnValue) { return default; }
	public void RemoveAllPointSets(bool bDestroy) {}
	public bool SetPointSetVisibility(sbyte PointSetIdentifier,bool bVisible,bool ReturnValue) { return default; }
	public bool SetPointSetMaterial(sbyte PointSetIdentifier,UObject NewMaterial,bool ReturnValue) { return default; }
	public void SetAllPointSetsMaterial(UObject Material) {}
	public APreviewGeometryActor ParentActor;
	public TMap<sbyte,ULineSetComponent> LineSets;
	public TMap<sbyte,UPointSetComponent> PointSets;
}
