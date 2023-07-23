#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CookerSettings.h")]
///<summary>Various cooker settings.</summary>
public partial class UCookerSettings : UDeveloperSettings {
// CookerSettings
	public bool bEnableCookOnTheSide;
	public bool bEnableBuildDDCInBackground;
	public bool bIterativeCookingForLaunchOn;
	public bool bIterativeCookingForFileCookContent;
	public bool bCookOnTheFlyForLaunchOn;
	public ECookProgressDisplayMode CookProgressDisplayMode;
	public bool bIgnoreIniSettingsOutOfDateForIteration;
	public bool bIgnoreScriptPackagesOutOfDateForIteration;
	public bool bCompileBlueprintsInDevelopmentMode;
	public EBlueprintComponentDataCookingMethod BlueprintComponentDataCookingMethod;
	public EBlueprintPropertyGuidsCookingMethod BlueprintPropertyGuidsCookingMethod;
	public TArray<sbyte> ClassesExcludedOnDedicatedServer;
	public TArray<sbyte> ModulesExcludedOnDedicatedServer;
	public TArray<sbyte> ClassesExcludedOnDedicatedClient;
	public TArray<sbyte> ModulesExcludedOnDedicatedClient;
	public TArray<sbyte> VersionedIntRValues;
	public int DefaultASTCQualityBySpeed;
	public int DefaultASTCQualityBySize;
	public ETextureFormatASTCCompressor DefaultASTCCompressor;
	public bool bAllowASTCHDRProfile;
	public bool bAllowCookedDataInEditorBuilds;
	public bool bCookBlueprintComponentTemplateData;
}
