#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetTextLibrary.h")]
public partial class UKismetTextLibrary : UBlueprintFunctionLibrary {
// KismetTextLibrary
	public sbyte Conv_VectorToText(FVector InVec,sbyte ReturnValue) { return default; }
	public sbyte Conv_Vector2dToText(FVector2D InVec,sbyte ReturnValue) { return default; }
	public sbyte Conv_RotatorToText(FRotator InRot,sbyte ReturnValue) { return default; }
	public sbyte Conv_TransformToText(FTransform InTrans,sbyte ReturnValue) { return default; }
	public sbyte Conv_ObjectToText(UObject InObj,sbyte ReturnValue) { return default; }
	public sbyte Conv_ColorToText(FLinearColor InColor,sbyte ReturnValue) { return default; }
	public sbyte Conv_TextToString(sbyte InText,sbyte ReturnValue) { return default; }
	public sbyte Conv_StringToText(sbyte InString,sbyte ReturnValue) { return default; }
	public sbyte Conv_NameToText(sbyte InName,sbyte ReturnValue) { return default; }
	public bool TextIsEmpty(sbyte InText,bool ReturnValue) { return default; }
	public bool TextIsTransient(sbyte InText,bool ReturnValue) { return default; }
	public bool TextIsCultureInvariant(sbyte InText,bool ReturnValue) { return default; }
	public sbyte TextToLower(sbyte InText,sbyte ReturnValue) { return default; }
	public sbyte TextToUpper(sbyte InText,sbyte ReturnValue) { return default; }
	public sbyte TextTrimPreceding(sbyte InText,sbyte ReturnValue) { return default; }
	public sbyte TextTrimTrailing(sbyte InText,sbyte ReturnValue) { return default; }
	public sbyte TextTrimPrecedingAndTrailing(sbyte InText,sbyte ReturnValue) { return default; }
	public sbyte GetEmptyText(sbyte ReturnValue) { return default; }
	public bool FindTextInLocalizationTable(sbyte Namespace,sbyte Key,sbyte OutText,bool ReturnValue) { return default; }
	public bool EqualEqual_TextText(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool EqualEqual_IgnoreCase_TextText(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool NotEqual_TextText(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public bool NotEqual_IgnoreCase_TextText(sbyte A,sbyte B,bool ReturnValue) { return default; }
	public sbyte Conv_BoolToText(bool InBool,sbyte ReturnValue) { return default; }
	public sbyte Conv_ByteToText(byte Value,sbyte ReturnValue) { return default; }
	public sbyte Conv_IntToText(int Value,bool bAlwaysSign=false,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,sbyte ReturnValue) { return default; }
	public sbyte Conv_Int64ToText(long Value,bool bAlwaysSign=false,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,sbyte ReturnValue) { return default; }
	public sbyte Conv_DoubleToText(double Value,byte RoundingMode,bool bAlwaysSign=false,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,sbyte ReturnValue) { return default; }
	public sbyte AsCurrencyBase(int BaseValue,sbyte CurrencyCode,sbyte ReturnValue) { return default; }
	public sbyte AsCurrency_Integer(int Value,byte RoundingMode,bool bAlwaysSign=false,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,sbyte CurrencyCode=TEXT,sbyte ReturnValue) { return default; }
	public sbyte AsCurrency_Float(float Value,byte RoundingMode,bool bAlwaysSign=false,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,sbyte CurrencyCode=TEXT,sbyte ReturnValue) { return default; }
	public sbyte AsPercent_Float(float Value,byte RoundingMode,bool bAlwaysSign=false,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,sbyte ReturnValue) { return default; }
	public sbyte AsDate_DateTime(FDateTime InDateTime,sbyte ReturnValue) { return default; }
	public sbyte AsTimeZoneDate_DateTime(FDateTime InDateTime,sbyte InTimeZone=TEXT,sbyte ReturnValue) { return default; }
	public sbyte AsDateTime_DateTime(FDateTime In,sbyte ReturnValue) { return default; }
	public sbyte AsTimeZoneDateTime_DateTime(FDateTime InDateTime,sbyte InTimeZone=TEXT,sbyte ReturnValue) { return default; }
	public sbyte AsTime_DateTime(FDateTime In,sbyte ReturnValue) { return default; }
	public sbyte AsTimeZoneTime_DateTime(FDateTime InDateTime,sbyte InTimeZone=TEXT,sbyte ReturnValue) { return default; }
	public sbyte AsTimespan_Timespan(FTimespan InTimespan,sbyte ReturnValue) { return default; }
	public sbyte Format(sbyte InPattern,TArray<FFormatArgumentData> InArgs,sbyte ReturnValue) { return default; }
	public bool TextIsFromStringTable(sbyte Text,bool ReturnValue) { return default; }
	public sbyte TextFromStringTable(sbyte TableId,sbyte Key,sbyte ReturnValue) { return default; }
	public bool StringTableIdAndKeyFromText(sbyte Text,sbyte OutTableId,sbyte OutKey,bool ReturnValue) { return default; }
	public void IsPolyglotDataValid(FPolyglotTextData PolyglotData,bool IsValid,sbyte ErrorMessage) {}
	public sbyte PolyglotDataToText(FPolyglotTextData PolyglotData,sbyte ReturnValue) { return default; }
}
