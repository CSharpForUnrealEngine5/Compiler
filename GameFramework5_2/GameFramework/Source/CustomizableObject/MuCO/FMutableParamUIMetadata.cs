#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectUIData.h")]
public partial struct FMutableParamUIMetadata {
// MutableParamUIMetadata
	public sbyte ObjectFriendlyName;
	public sbyte UISectionName;
	public int UIOrder;
	public TSoftObjectPtr<UTexture2D> UIThumbnail;
	public TMap<sbyte,sbyte> ExtraInformation;
	public TMap<sbyte,TSoftObjectPtr<UObject>> ExtraAssets;
	public float MinimumValue;
	public float MaximumValue;
}
