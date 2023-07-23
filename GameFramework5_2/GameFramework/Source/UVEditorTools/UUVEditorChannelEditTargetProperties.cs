#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayerEditTool.h")]
public partial class UUVEditorChannelEditTargetProperties : UInteractiveToolPropertySet {
// UVEditorChannelEditTargetProperties
	public sbyte Asset;
	public TArray<sbyte> GetAssetNames(TArray<sbyte> ReturnValue) { return default; }
	public sbyte TargetChannel;
	public sbyte ReferenceChannel;
	public TArray<sbyte> GetUVChannelNames(TArray<sbyte> ReturnValue) { return default; }
	public bool bActionNeedsAsset;
	public bool bActionNeedsReference;
	public bool bActionNeedsTarget;
}
