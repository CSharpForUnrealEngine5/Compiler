#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringLibrary.h")]
public partial class UKismetStringLibrary : UBlueprintFunctionLibrary {
// KismetStringLibrary
	public sbyte Conv_DoubleToString(double InDouble,sbyte ReturnValue) { return default; }
	public sbyte Conv_IntToString(int InInt,sbyte ReturnValue) { return default; }
	public sbyte Conv_Int64ToString(long InInt,sbyte ReturnValue) { return default; }
	public sbyte Conv_ByteToString(byte InByte,sbyte ReturnValue) { return default; }
	public sbyte Conv_BoolToString(bool InBool,sbyte ReturnValue) { return default; }
	public sbyte Conv_VectorToString(FVector InVec,sbyte ReturnValue) { return default; }
	public sbyte Conv_Vector3fToString(FVector3f InVec,sbyte ReturnValue) { return default; }
	public sbyte Conv_IntVectorToString(FIntVector InIntVec,sbyte ReturnValue) { return default; }
	public sbyte Conv_IntPointToString(FIntPoint InIntPoint,sbyte ReturnValue) { return default; }
	public sbyte Conv_Vector2dToString(FVector2D InVec,sbyte ReturnValue) { return default; }
	public sbyte Conv_RotatorToString(FRotator InRot,sbyte ReturnValue) { return default; }
	public sbyte Conv_TransformToString(FTransform InTrans,sbyte ReturnValue) { return default; }
	public sbyte Conv_ObjectToString(UObject InObj,sbyte ReturnValue) { return default; }
	public sbyte Conv_InputDeviceIdToString(FInputDeviceId InDeviceId,sbyte ReturnValue) { return default; }
	public sbyte Conv_PlatformUserIdToString(FPlatformUserId InPlatformUserId,sbyte ReturnValue) { return default; }
	public sbyte Conv_ColorToString(FLinearColor InColor,sbyte ReturnValue) { return default; }
	public sbyte Conv_NameToString(sbyte InName,sbyte ReturnValue) { return default; }
	public sbyte Conv_MatrixToString(FMatrix InMatrix,sbyte ReturnValue) { return default; }
	public sbyte Conv_StringToName(sbyte InString,sbyte ReturnValue) { return default; }
	public int Conv_StringToInt(sbyte InString,int ReturnValue) { return default; }
	public long Conv_StringToInt64(sbyte InString,long ReturnValue) { return default; }
	public double Conv_StringToDouble(sbyte InString,double ReturnValue) { return default; }
	public void Conv_StringToVector(sbyte InString,FVector OutConvertedVector,bool OutIsValid) {}
	public void Conv_StringToVector3f(sbyte InString,FVector3f OutConvertedVector,bool OutIsValid) {}
	public void Conv_StringToVector2D(sbyte InString,FVector2D OutConvertedVector2D,bool OutIsValid) {}
	public void Conv_StringToRotator(sbyte InString,FRotator OutConvertedRotator,bool OutIsValid) {}
	public void Conv_StringToColor(sbyte InString,FLinearColor OutConvertedColor,bool OutIsValid) {}
	public sbyte BuildString_Double(sbyte AppendTo,sbyte Prefix,double InDouble,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Int(sbyte AppendTo,sbyte Prefix,int InInt,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Bool(sbyte AppendTo,sbyte Prefix,bool InBool,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Vector(sbyte AppendTo,sbyte Prefix,FVector InVector,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_IntVector(sbyte AppendTo,sbyte Prefix,FIntVector InIntVector,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Vector2d(sbyte AppendTo,sbyte Prefix,FVector2D InVector2d,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Rotator(sbyte AppendTo,sbyte Prefix,FRotator InRot,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Object(sbyte AppendTo,sbyte Prefix,UObject InObj,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Color(sbyte AppendTo,sbyte Prefix,FLinearColor InColor,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte BuildString_Name(sbyte AppendTo,sbyte Prefix,sbyte InName,sbyte Suffix,sbyte ReturnValue) { return default; }
	public sbyte Concat_StrStr(sbyte A,sbyte B,sbyte ReturnValue) { return default; }
	public bool EqualEqual_StrStr(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool EqualEqual_StriStri(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool NotEqual_StrStr(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool NotEqual_StriStri(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public int Len(sbyte S,int ReturnValue) { return default; }
	public bool IsEmpty(sbyte InString,bool ReturnValue) { return default; }
	public sbyte GetSubstring(sbyte SourceString,int StartIndex=0,int Length=1,sbyte ReturnValue) { return default; }
	public int FindSubstring(sbyte SearchIn,sbyte Substring,bool bUseCase=false,bool bSearchFromEnd=false,int StartPosition=-1,int ReturnValue) { return default; }
	public bool Contains(sbyte SearchIn,sbyte Substring,bool bUseCase=false,bool bSearchFromEnd=false,bool ReturnValue) { return default; }
	public int GetCharacterAsNumber(sbyte SourceString,int Index=0,int ReturnValue) { return default; }
	public TArray<sbyte> ParseIntoArray(sbyte SourceString,sbyte Delimiter=FString,bool CullEmptyStrings=true,TArray<sbyte> ReturnValue) { return default; }
	public sbyte JoinStringArray(TArray<sbyte> SourceArray,sbyte Separator=FString,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetCharacterArrayFromString(sbyte SourceString,TArray<sbyte> ReturnValue) { return default; }
	public sbyte ToUpper(sbyte SourceString,sbyte ReturnValue) { return default; }
	public sbyte ToLower(sbyte SourceString,sbyte ReturnValue) { return default; }
	public sbyte LeftPad(sbyte SourceString,int ChCount,sbyte ReturnValue) { return default; }
	public sbyte RightPad(sbyte SourceString,int ChCount,sbyte ReturnValue) { return default; }
	public bool IsNumeric(sbyte SourceString,bool ReturnValue) { return default; }
	public bool StartsWith(sbyte SourceString,sbyte InPrefix,ESearchCase SearchCase=ESearchCase,bool ReturnValue) { return default; }
	public bool EndsWith(sbyte SourceString,sbyte InSuffix,ESearchCase SearchCase=ESearchCase,bool ReturnValue) { return default; }
	public bool MatchesWildcard(sbyte SourceString,sbyte Wildcard,ESearchCase SearchCase=ESearchCase,bool ReturnValue) { return default; }
	public sbyte Trim(sbyte SourceString,sbyte ReturnValue) { return default; }
	public sbyte TrimTrailing(sbyte SourceString,sbyte ReturnValue) { return default; }
	public int CullArray(sbyte SourceString,TArray<sbyte> InArray,int ReturnValue) { return default; }
	public sbyte Reverse(sbyte SourceString,sbyte ReturnValue) { return default; }
	public sbyte Replace(sbyte SourceString,sbyte From,sbyte To,ESearchCase SearchCase=ESearchCase,sbyte ReturnValue) { return default; }
	public int ReplaceInline(sbyte SourceString,sbyte SearchText,sbyte ReplacementText,ESearchCase SearchCase=ESearchCase,int ReturnValue) { return default; }
	public bool Split(sbyte SourceString,sbyte InStr,sbyte LeftS,sbyte RightS,ESearchCase SearchCase=ESearchCase,ESearchDir SearchDir=ESearchDir,bool ReturnValue) { return default; }
	public sbyte Left(sbyte SourceString,int Count,sbyte ReturnValue) { return default; }
	public sbyte LeftChop(sbyte SourceString,int Count,sbyte ReturnValue) { return default; }
	public sbyte Right(sbyte SourceString,int Count,sbyte ReturnValue) { return default; }
	public sbyte RightChop(sbyte SourceString,int Count,sbyte ReturnValue) { return default; }
	public sbyte Mid(sbyte SourceString,int Start,int Count,sbyte ReturnValue) { return default; }
	public sbyte TimeSecondsToString(float InSeconds,sbyte ReturnValue) { return default; }
}
