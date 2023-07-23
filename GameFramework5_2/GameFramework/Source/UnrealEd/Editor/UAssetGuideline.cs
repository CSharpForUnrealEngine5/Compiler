#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/AssetGuideline.h")]
///<summary>User data that can be attached to assets to check on load for guidlelines (plugins, project settings, etc).</summary>
public partial class UAssetGuideline : UAssetUserData {
// AssetGuideline
	public TArray<sbyte> Plugins;
	public TArray<FIniStringValue> ProjectSettings;
	public sbyte GuidelineName;
}
