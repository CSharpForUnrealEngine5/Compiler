#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Note: Must match r.DynamicGlobalIlluminationMethod, this is used in URendererSettings</summary>
public enum EDynamicGlobalIlluminationMethod {
	None=0,
	Lumen=1,
	ScreenSpace=2,
	RayTraced=3,
	Plugin=4,
}
