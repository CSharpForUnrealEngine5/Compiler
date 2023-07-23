#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InAppPurchaseCallbackProxy2.h")]
public partial class UInAppPurchaseCallbackProxy2 : UObject {
// InAppPurchaseCallbackProxy2
	public FInAppPurchaseResult2 OnSuccess;
	public FInAppPurchaseResult2 OnFailure;
	public UObject CreateProxyObjectForInAppPurchase(UObject PlayerController,FInAppPurchaseProductRequest2 ProductRequest,UObject ReturnValue) { return default; }
	public UObject CreateProxyObjectForInAppPurchaseUnprocessedPurchases(UObject PlayerController,UObject ReturnValue) { return default; }
	public UObject CreateProxyObjectForInAppPurchaseQueryOwned(UObject PlayerController,UObject ReturnValue) { return default; }
}
