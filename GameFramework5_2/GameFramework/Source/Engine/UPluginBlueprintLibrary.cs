#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PluginBlueprintLibrary.h")]
///<summary>A function library of utilities for querying information about plugins.</summary>
public partial class UPluginBlueprintLibrary : UBlueprintFunctionLibrary {
// PluginBlueprintLibrary
	public TArray<sbyte> GetAdditionalPluginSearchPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetAdditionalProjectPluginSearchPaths(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetEnabledPluginNames(TArray<sbyte> ReturnValue) { return default; }
	public bool GetPluginNameForObjectPath(FSoftObjectPath ObjectPath,sbyte OutPluginName,bool ReturnValue) { return default; }
	public bool GetPluginDescriptorFilePath(sbyte PluginName,sbyte OutFilePath,bool ReturnValue) { return default; }
	public bool GetPluginBaseDir(sbyte PluginName,sbyte OutBaseDir,bool ReturnValue) { return default; }
	public bool GetPluginContentDir(sbyte PluginName,sbyte OutContentDir,bool ReturnValue) { return default; }
	public bool GetPluginMountedAssetPath(sbyte PluginName,sbyte OutAssetPath,bool ReturnValue) { return default; }
	public bool GetPluginVersion(sbyte PluginName,int OutVersion,bool ReturnValue) { return default; }
	public bool GetPluginVersionName(sbyte PluginName,sbyte OutVersionName,bool ReturnValue) { return default; }
	public bool GetPluginDescription(sbyte PluginName,sbyte OutDescription,bool ReturnValue) { return default; }
	public bool GetPluginEditorCustomVirtualPath(sbyte PluginName,sbyte OutVirtualPath,bool ReturnValue) { return default; }
	public bool IsPluginMounted(sbyte PluginName,bool ReturnValue) { return default; }
}
