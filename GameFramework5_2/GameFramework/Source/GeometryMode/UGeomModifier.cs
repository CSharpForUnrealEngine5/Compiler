#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier.h")]
public partial class UGeomModifier : UObject {
// GeomModifier
	public sbyte Description;
	public sbyte Tooltip;
	public sbyte ToolbarIconName;
	public bool bPushButton;
	public bool bInitialized;
	public bool bPendingPivotOffsetUpdate;
	public bool bAppearsInToolbar;
	public UPolys CachedPolys;
}
