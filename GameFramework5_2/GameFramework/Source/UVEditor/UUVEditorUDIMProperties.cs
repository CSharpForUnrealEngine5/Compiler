#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorMode.h")]
///<summary>Settings for UDIMs in the UVEditor</summary>
public partial class UUVEditorUDIMProperties : UInteractiveToolPropertySet {
// UVEditorUDIMProperties
	public sbyte UDIMSourceAsset;
	public TArray<sbyte> GetAssetNames(TArray<sbyte> ReturnValue) { return default; }
	public int AssetByIndex(int ReturnValue) { return default; }
	public void SetUDIMsFromAsset() {}
	public UTexture2D UDIMSourceTexture;
	public void SetUDIMsFromTexture() {}
	public TArray<FUDIMSpecifier> ActiveUDIMs;
}
