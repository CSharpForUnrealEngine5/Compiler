#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagAssetInterface.h")]
public partial class UGameplayTagAssetInterface : UInterface {
// GameplayTagAssetInterface
	public void GetOwnedGameplayTags(FGameplayTagContainer TagContainer) {}
	public bool HasMatchingGameplayTag(FGameplayTag TagToCheck,bool ReturnValue) { return default; }
	public bool HasAllMatchingGameplayTags(FGameplayTagContainer TagContainer,bool ReturnValue) { return default; }
	public bool HasAnyMatchingGameplayTags(FGameplayTagContainer TagContainer,bool ReturnValue) { return default; }
}
