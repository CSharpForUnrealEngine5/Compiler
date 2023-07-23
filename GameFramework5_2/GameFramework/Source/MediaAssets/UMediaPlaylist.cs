#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlaylist.h")]
///<summary>Implements a media play list.</summary>
public partial class UMediaPlaylist : UObject {
// MediaPlaylist
	public bool Add(UObject MediaSource,bool ReturnValue) { return default; }
	public bool AddFile(sbyte FilePath,bool ReturnValue) { return default; }
	public bool AddUrl(sbyte Url,bool ReturnValue) { return default; }
	public UObject Get(int Index,UObject ReturnValue) { return default; }
	public UObject GetNext(int InOutIndex,UObject ReturnValue) { return default; }
	public UObject GetPrevious(int InOutIndex,UObject ReturnValue) { return default; }
	public UObject GetRandom(int OutIndex,UObject ReturnValue) { return default; }
	public void Insert(UObject MediaSource,int Index) {}
	public int Num(int ReturnValue) { return default; }
	public bool Remove(UObject MediaSource,bool ReturnValue) { return default; }
	public bool RemoveAt(int Index,bool ReturnValue) { return default; }
	public bool Replace(int Index,UObject Replacement,bool ReturnValue) { return default; }
	public TArray<UMediaSource> Items;
}
