#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>A way of identifying something to be highlighted by a tutorial</summary>
public partial struct FTutorialContentAnchor {
// TutorialContentAnchor
	public byte Type;
	public sbyte WrapperIdentifier;
	public FSoftObjectPath Asset;
	public bool bDrawHighlight;
	public sbyte TabToFocusOrOpen;
	public sbyte FriendlyName;
	public sbyte GUIDString;
	public sbyte OuterName;
}
