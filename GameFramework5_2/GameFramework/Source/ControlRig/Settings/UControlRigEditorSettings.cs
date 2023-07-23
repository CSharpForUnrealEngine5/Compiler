#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ControlRigSettings.h")]
///<summary>Customize Control Rig Editor.</summary>
public partial class UControlRigEditorSettings : UDeveloperSettings {
// ControlRigEditorSettings
	public bool bAutoLinkMutableNodes;
	public bool bResetControlsOnCompile;
	public bool bResetControlsOnPinValueInteraction;
	public bool bEnableUndoForPoseInteraction;
	public bool bResetControlTransformsOnCompile;
	public TMap<sbyte,FControlRigSettingsPerPinBool> RigUnitPinExpansion;
	public FLinearColor ConstructionEventBorderColor;
	public FLinearColor BackwardsSolveBorderColor;
	public FLinearColor BackwardsAndForwardsBorderColor;
	public bool bShowStackedHierarchy;
	public int MaxStackSize;
	public sbyte NodeSnippet_1;
	public sbyte NodeSnippet_2;
	public sbyte NodeSnippet_3;
	public sbyte NodeSnippet_4;
	public sbyte NodeSnippet_5;
	public sbyte NodeSnippet_6;
	public sbyte NodeSnippet_7;
	public sbyte NodeSnippet_8;
	public sbyte NodeSnippet_9;
	public sbyte NodeSnippet_0;
}
