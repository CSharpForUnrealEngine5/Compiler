#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/AsyncActionHandleSaveGame.h")]
///<summary>Async action to handle async load/save of a USaveGame. This can be subclassed by a specific game</summary>
public partial class UAsyncActionHandleSaveGame : UBlueprintAsyncActionBase {
// AsyncActionHandleSaveGame
	public UObject AsyncSaveGameToSlot(UObject WorldContextObject,UObject SaveGameObject,sbyte SlotName,int UserIndex,UObject ReturnValue) { return default; }
	public UObject AsyncLoadGameFromSlot(UObject WorldContextObject,sbyte SlotName,int UserIndex,UObject ReturnValue) { return default; }
	public FOnAsyncHandleSaveGame Completed;
	public USaveGame SaveGameObject;
}
