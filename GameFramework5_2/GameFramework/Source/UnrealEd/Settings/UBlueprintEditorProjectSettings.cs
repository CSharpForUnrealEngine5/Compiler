#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/BlueprintEditorProjectSettings.h")]
public partial class UBlueprintEditorProjectSettings : UDeveloperSettings {
// BlueprintEditorProjectSettings
	public bool bForceAllDependenciesToRecompile;
	public bool bValidateUnloadedSoftActorReferences;
	public bool bEnableChildActorExpansionInTreeView;
	public EChildActorComponentTreeViewVisualizationMode DefaultChildActorTreeViewMode;
	public TArray<sbyte> NamespacesToAlwaysInclude;
	public TArray<sbyte> DisabledCompilerMessagesExceptEditor;
	public TArray<sbyte> DisabledCompilerMessages;
	public TArray<sbyte> SuppressedDeprecationMessages;
	public TArray<TSoftObjectPtr<UClass>> BaseClassesToAllowRecompilingDuringPlayInEditor;
}
