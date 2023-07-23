#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/BrushBuilder.h")]
///<summary>Base class of UnrealEd brush builders.</summary>
public partial class UBrushBuilder : UObject {
// BrushBuilder
	public sbyte BitmapFilename;
	public sbyte ToolTip;
	public bool NotifyBadParams;
	public TArray<FVector> Vertices;
	public TArray<FBuilderPoly> Polys;
	public sbyte Layer;
	public bool MergeCoplanars;
}
