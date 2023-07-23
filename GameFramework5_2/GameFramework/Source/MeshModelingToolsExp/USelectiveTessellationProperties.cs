#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplaceMeshTool.h")]
///<summary>PropertySet for properties affecting the selective tessellation.</summary>
public partial class USelectiveTessellationProperties : UInteractiveToolPropertySet {
// SelectiveTessellationProperties
	public EDisplaceMeshToolTriangleSelectionType SelectionType;
	public sbyte ActiveMaterial;
	public TArray<sbyte> GetMaterialIDsFunc(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> MaterialIDList;
}
