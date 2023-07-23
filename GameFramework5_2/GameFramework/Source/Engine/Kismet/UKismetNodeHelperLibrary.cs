#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetNodeHelperLibrary.h")]
public partial class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary {
// KismetNodeHelperLibrary
	public bool BitIsMarked(int Data,int Index,bool ReturnValue) { return default; }
	public void MarkBit(int Data,int Index) {}
	public void ClearBit(int Data,int Index) {}
	public void ClearAllBits(int Data) {}
	public bool HasUnmarkedBit(int Data,int NumBits,bool ReturnValue) { return default; }
	public bool HasMarkedBit(int Data,int NumBits,bool ReturnValue) { return default; }
	public int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom,int ReturnValue) { return default; }
	public int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits,int ReturnValue) { return default; }
	public int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits,int ReturnValue) { return default; }
	public sbyte GetEnumeratorName(UObject Enum,byte EnumeratorValue,sbyte ReturnValue) { return default; }
	public sbyte GetEnumeratorUserFriendlyName(UObject Enum,byte EnumeratorValue,sbyte ReturnValue) { return default; }
	public byte GetValidValue(UObject Enum,byte EnumeratorValue,byte ReturnValue) { return default; }
	public byte GetEnumeratorValueFromIndex(UObject Enum,byte EnumeratorIndex,byte ReturnValue) { return default; }
}
