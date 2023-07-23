#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreAugmentedImageDatabase.h")]
///<summary>A collection of processed images for ARCore to track.</summary>
public partial class UGoogleARCoreAugmentedImageDatabase : UDataAsset {
// GoogleARCoreAugmentedImageDatabase
	public int AddRuntimeAugmentedImageFromTexture(UObject ImageTexture,sbyte ImageName,float ImageWidthInMeter=0,int ReturnValue) { return default; }
	public TArray<FGoogleARCoreAugmentedImageDatabaseEntry> Entries;
	public TArray<byte> SerializedDatabase;
}
