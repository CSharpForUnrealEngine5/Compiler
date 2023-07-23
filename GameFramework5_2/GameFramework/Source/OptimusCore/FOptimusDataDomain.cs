#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDataDomain.h")]
///<summary>A struct to specify the domain range of a resource buffer, as defined by compute kernels and data</summary>
public partial struct FOptimusDataDomain {
// OptimusDataDomain
	public EOptimusDataDomainType Type;
	public TArray<sbyte> DimensionNames;
	public int Multiplier;
	public sbyte Expression;
	public TArray<sbyte> LevelNames_DEPRECATED;
}
