#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShaderCookerStats.h")]
///<summary>Statistics page for shader cooker stats.</summary>
public partial class UShaderCookerStats : UObject {
// ShaderCookerStats
	public sbyte Name;
	public sbyte Platform;
	public sbyte Category;
	public int Compiled;
	public int Cooked;
	public int Permutations;
	public float CompileTime;
	public sbyte Path;
}
