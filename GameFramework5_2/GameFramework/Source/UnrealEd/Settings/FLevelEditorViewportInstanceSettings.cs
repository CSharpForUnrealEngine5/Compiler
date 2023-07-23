#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorViewportSettings.h")]
///<summary>Implements the Level Editor's per-instance view port settings.</summary>
public partial struct FLevelEditorViewportInstanceSettings {
// LevelEditorViewportInstanceSettings
	public byte ViewportType;
	public byte PerspViewModeIndex;
	public byte OrthoViewModeIndex;
	public sbyte EditorShowFlagsString;
	public sbyte GameShowFlagsString;
	public sbyte BufferVisualizationMode;
	public sbyte NaniteVisualizationMode;
	public sbyte LumenVisualizationMode;
	public sbyte StrataVisualizationMode;
	public sbyte GroomVisualizationMode;
	public sbyte VirtualShadowMapVisualizationMode;
	public sbyte RayTracingDebugVisualizationMode;
	public sbyte GPUSkinCacheVisualizationMode;
	public FExposureSettings ExposureSettings;
	public float FOVAngle;
	public float FarViewPlane;
	public bool bIsRealtime;
	public bool bShowFPS_DEPRECATED;
	public bool bShowOnScreenStats;
	public TArray<sbyte> EnabledStats;
	public bool bShowFullToolbar;
}
