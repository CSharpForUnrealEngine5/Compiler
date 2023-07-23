#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSAssetImportData.h")]
public partial struct FTexturesList {
// TexturesList
	public sbyte textureID;
	public sbyte type;
	public sbyte resolution;
	public sbyte name;
	public sbyte path;
	public bool isChannelPacked;
	public TArray<FChannelPackedInfo> channelPackInfo;
	public TArray<FTextureUsage> pluggedIn;
}
