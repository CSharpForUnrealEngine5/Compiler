#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CryptoKeysSettings.h")]
///<summary>Implements the settings for imported Paper2D assets, such as sprite sheet textures.</summary>
public partial class UCryptoKeysSettings : UObject {
// CryptoKeysSettings
	public sbyte EncryptionKey;
	public TArray<FCryptoEncryptionKey> SecondaryEncryptionKeys;
	public bool bEncryptPakIniFiles;
	public bool bEncryptPakIndex;
	public bool bEncryptUAssetFiles;
	public bool bEncryptAllAssetFiles;
	public sbyte SigningPublicExponent;
	public sbyte SigningModulus;
	public sbyte SigningPrivateExponent;
	public bool bEnablePakSigning;
}
