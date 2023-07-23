#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlaySettings.h")]
///<summary>Holds information about a screen resolution to be used for playing.</summary>
public partial struct FPlayScreenResolution {
// PlayScreenResolution
	public sbyte Description;
	public int Width;
	public int Height;
	public sbyte AspectRatio;
	public bool bCanSwapAspectRatio;
	public sbyte ProfileName;
	public float ScaleFactor;
	public int LogicalHeight;
	public int LogicalWidth;
}
