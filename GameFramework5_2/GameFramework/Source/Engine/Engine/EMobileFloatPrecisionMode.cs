#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>The default float precision for material's pixel shaders on mobile devices</summary>
public enum EMobileFloatPrecisionMode {
	Half=0,
	Full_MaterialExpressionOnly=1,
	Full=2,
}
