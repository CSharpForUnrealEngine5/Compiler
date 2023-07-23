#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeaturesEditorSettings.h")]
///<summary>* Data for specifying a usable plugin template.</summary>
public partial struct FPluginTemplateData {
// PluginTemplateData
	public FDirectoryPath Path;
	public sbyte Label;
	public sbyte Description;
	public UClass DefaultGameFeatureDataClass;
	public sbyte DefaultGameFeatureDataName;
	public bool bIsEnabledByDefault;
}
