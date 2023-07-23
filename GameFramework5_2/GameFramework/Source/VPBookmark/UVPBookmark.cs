#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmark.h")]
public partial class UVPBookmark : UBookmarkBase {
// VPBookmark
	public bool bIsActive;
	public TLazyObjectPtr<AActor> OwnedActor;
	public FVPBookmarkCreationContext CreationContext;
	public FVPBookmarkViewportData CachedViewportData;
	public bool IsActive(bool ReturnValue) { return default; }
	public int GetBookmarkIndex(int ReturnValue) { return default; }
	public UObject GetAssociatedBookmarkActor(UObject ReturnValue) { return default; }
	public sbyte GetDisplayName(sbyte ReturnValue) { return default; }
}
