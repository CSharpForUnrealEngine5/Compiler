#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CalibrationPointComponent.h")]
///<summary>One or more instances of this component can be added to an actor (e.g. a static mesh actor blueprint),</summary>
public partial class UCalibrationPointComponent : UProceduralMeshComponent {
// CalibrationPointComponent
	public TMap<sbyte,FVector> SubPoints;
	public bool bVisualizePointsInEditor;
	public float PointVisualizationScale;
	public byte VisualizationShape;
	public bool GetWorldLocation(sbyte InPointName,FVector OutLocation,bool ReturnValue) { return default; }
	public bool NamespacedSubpointName(sbyte InSubpointName,sbyte OutNamespacedName,bool ReturnValue) { return default; }
	public void GetNamespacedPointNames(TArray<sbyte> OutNamespacedNames) {}
	public void RebuildVertices() {}
}
