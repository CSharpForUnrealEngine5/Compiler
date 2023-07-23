#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VCamUIFunctionLibrary.h")]
///<summary>* Function Library primarily used for exposing functionality of UI related structs to Blueprints</summary>
public partial class UVCamUIFunctionLibrary : UBlueprintFunctionLibrary {
// VCamUIFunctionLibrary
	public bool IsConnected_VCamConnection(FVCamConnection Connection,bool ReturnValue) { return default; }
	public sbyte GetConnectionPointName_VCamConnection(FVCamConnection Connection,sbyte ReturnValue) { return default; }
	public UObject GetConnectedModifier_VCamConnection(FVCamConnection Connection,UObject ReturnValue) { return default; }
	public UObject GetConnectedInputAction_VCamConnection(FVCamConnection Connection,UObject ReturnValue) { return default; }
	public bool GetConnectionByName_VCamWidget(UObject Widget,sbyte ConnectionId,FVCamConnection OutConnection,bool ReturnValue) { return default; }
	public bool IsConnected_VCamWidget(UObject Widget,sbyte ConnectionId,bool bOutIsConnected,bool ReturnValue) { return default; }
	public bool GetConnectionPointName_VCamWidget(UObject Widget,sbyte ConnectionId,sbyte OutConnectionPointName,bool ReturnValue) { return default; }
	public bool GetConnectedModifier_VCamWidget(UObject Widget,sbyte ConnectionId,UObject OutModifier,bool ReturnValue) { return default; }
	public bool GetConnectedInputAction_VCamWidget(UObject Widget,sbyte ConnectionId,UObject OutInputAction,bool ReturnValue) { return default; }
}
