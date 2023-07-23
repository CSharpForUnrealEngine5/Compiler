#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensData.h")]
///<summary>Information about the lens rig</summary>
public partial struct FLensInfo {
// LensInfo
	public sbyte LensModelName;
	public sbyte LensSerialNumber;
	public UClass LensModel;
	public FVector2D SensorDimensions;
	public FIntPoint ImageDimensions;
}
