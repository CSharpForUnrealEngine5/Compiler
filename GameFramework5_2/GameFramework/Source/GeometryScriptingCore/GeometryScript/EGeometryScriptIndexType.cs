#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/GeometryScriptTypes.h")]
///<summary>By default structs exposed to Python will use a per-UPROPERTY comparison. When this doesn't give correct results</summary>
public enum EGeometryScriptIndexType {
	Any=0,
	Triangle=1,
	Vertex=2,
	MaterialID=3,
	PolygroupID=4,
}
