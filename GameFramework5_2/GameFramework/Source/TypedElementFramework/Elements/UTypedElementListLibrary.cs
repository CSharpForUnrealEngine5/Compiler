#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementListLibrary.h")]
public partial class UTypedElementListLibrary : UObject {
// TypedElementListLibrary
	public FScriptTypedElementListProxy CreateScriptElementList(UObject Registry,FScriptTypedElementListProxy ReturnValue) { return default; }
	public FScriptTypedElementListProxy Clone(FScriptTypedElementListProxy ElementList,FScriptTypedElementListProxy ReturnValue) { return default; }
	public FScriptTypedElementHandle GetElementHandleAt(FScriptTypedElementListProxy ElementList,int Index,FScriptTypedElementHandle ReturnValue) { return default; }
	public UObject GetElementInterface(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,UClass BaseInterfaceType,UObject ReturnValue) { return default; }
	public bool HasElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType=nullptr,bool ReturnValue) { return default; }
	public int CountElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType=nullptr,int ReturnValue) { return default; }
	public bool HasElementsOfType(FScriptTypedElementListProxy ElementList,sbyte ElementTypeName,bool ReturnValue) { return default; }
	public int CountElementsOfType(FScriptTypedElementListProxy ElementList,sbyte ElementTypeName,int ReturnValue) { return default; }
	public TArray<FScriptTypedElementHandle> GetElementHandles(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType,TArray<FScriptTypedElementHandle> ReturnValue) { return default; }
	public bool IsValidIndex(FScriptTypedElementListProxy ElementList,int Index,bool ReturnValue) { return default; }
	public int Num(FScriptTypedElementListProxy ElementList,int ReturnValue) { return default; }
	public void Shrink(FScriptTypedElementListProxy ElementList) {}
	public void Reserve(FScriptTypedElementListProxy ElementList,int Size) {}
	public void Empty(FScriptTypedElementListProxy ElementList,int Slack=0) {}
	public void Reset(FScriptTypedElementListProxy ElementList) {}
	public bool Contains(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,bool ReturnValue) { return default; }
	public bool Add(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,bool ReturnValue) { return default; }
	public void Append(FScriptTypedElementListProxy ElementList,TArray<FScriptTypedElementHandle> ElementHandles) {}
	public void AppendList(FScriptTypedElementListProxy ElementList,FScriptTypedElementListProxy OtherElementList) {}
	public bool Remove(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,bool ReturnValue) { return default; }
}
