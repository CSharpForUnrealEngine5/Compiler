#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>The default float precision for material's pixel shaders on mobile devices</summary>
public enum EMaterialFloatPrecisionMode {
	MFPM_Default=0,
	MFPM_Full_MaterialExpressionOnly=1,
	MFPM_Full=2,
	MFPM_Half=3,
	MFPM_MAX=4,
}
