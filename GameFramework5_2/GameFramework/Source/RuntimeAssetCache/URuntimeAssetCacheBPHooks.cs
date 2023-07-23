#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RuntimeAssetCacheBPHooks.h")]
public partial class URuntimeAssetCacheBPHooks : UBlueprintFunctionLibrary {
// RuntimeAssetCacheBPHooks
	public FVoidPtrParam GetSynchronous(object /*CacheBuilder*/ CacheBuilder,FVoidPtrParam ReturnValue) { return default; }
	public int GetAsynchronous(object /*CacheBuilder*/ CacheBuilder,FOnRuntimeAssetCacheAsyncComplete CompletionDelegate,int ReturnValue) { return default; }
	public int GetCacheSize(sbyte Bucket,int ReturnValue) { return default; }
	public bool ClearCache(sbyte Bucket,bool ReturnValue) { return default; }
	public void WaitAsynchronousCompletion(int Handle) {}
	public FVoidPtrParam GetAsynchronousResults(int Handle,FVoidPtrParam ReturnValue) { return default; }
	public bool PollAsynchronousCompletion(int Handle,bool ReturnValue) { return default; }
}
