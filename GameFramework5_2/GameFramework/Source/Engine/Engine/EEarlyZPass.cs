#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>Enumerates available options for early Z-passes.</summary>
public enum EEarlyZPass {
	None=0,
	OpaqueOnly=1,
	OpaqueAndMasked=2,
	Auto=3,
}
