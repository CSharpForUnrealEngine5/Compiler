#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Account/IPortalUser.h")]
public partial struct FPortalUserIsEntitledToItemResult {
// PortalUserIsEntitledToItemResult
	public sbyte ItemId;
	public bool IsEntitled;
	public EEntitlementCacheLevelRetrieved RetrievedFromCacheLevel;
}
