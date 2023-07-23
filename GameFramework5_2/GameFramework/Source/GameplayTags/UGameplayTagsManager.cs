#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagsManager.h")]
///<summary>Holds data about the tag dictionary, is in a singleton UObject</summary>
public partial class UGameplayTagsManager : UObject {
// GameplayTagsManager
	public TMap<sbyte,FGameplayTagSource> TagSources;
	public TArray<UDataTable> GameplayTagTables;
}
