#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCVirtualProperty.h")]
///<summary>Base class for dynamic virtual properties</summary>
public partial class URCVirtualPropertyBase : UObject {
// RCVirtualPropertyBase
	public bool GetValueBool(bool OutBoolValue,bool ReturnValue) { return default; }
	public bool GetValueInt8(short OutInt8,bool ReturnValue) { return default; }
	public bool GetValueByte(byte OutByte,bool ReturnValue) { return default; }
	public bool GetValueInt16(short OutInt16,bool ReturnValue) { return default; }
	public bool GetValueUint16(ushort OutUInt16,bool ReturnValue) { return default; }
	public bool GetValueInt32(int OutInt32,bool ReturnValue) { return default; }
	public bool GetValueUInt32(uint OutUInt32,bool ReturnValue) { return default; }
	public bool GetValueInt64(long OuyInt64,bool ReturnValue) { return default; }
	public bool GetValueUint64(ulong OuyUInt64,bool ReturnValue) { return default; }
	public bool GetValueFloat(float OutFloat,bool ReturnValue) { return default; }
	public bool GetValueDouble(double OutDouble,bool ReturnValue) { return default; }
	public bool GetValueString(sbyte OutStringValue,bool ReturnValue) { return default; }
	public bool GetValueName(sbyte OutNameValue,bool ReturnValue) { return default; }
	public bool GetValueText(sbyte OutTextValue,bool ReturnValue) { return default; }
	public bool GetValueNumericInteger(long OutInt64Value,bool ReturnValue) { return default; }
	public bool GetValueVector(FVector OutVector,bool ReturnValue) { return default; }
	public bool GetValueRotator(FRotator OutRotator,bool ReturnValue) { return default; }
	public bool GetValueColor(FColor OutColor,bool ReturnValue) { return default; }
	public sbyte GetDisplayValueAsString(sbyte ReturnValue) { return default; }
	public bool SetValueBool(bool InBoolValue,bool ReturnValue) { return default; }
	public bool SetValueInt8(short InInt8,bool ReturnValue) { return default; }
	public bool SetValueByte(byte InByte,bool ReturnValue) { return default; }
	public bool SetValueInt16(short InInt16,bool ReturnValue) { return default; }
	public bool SetValueUint16(ushort InUInt16,bool ReturnValue) { return default; }
	public bool SetValueInt32(int InInt32,bool ReturnValue) { return default; }
	public bool SetValueUInt32(uint InUInt32,bool ReturnValue) { return default; }
	public bool SetValueInt64(long InInt64,bool ReturnValue) { return default; }
	public bool SetValueUint64(ulong InUInt64,bool ReturnValue) { return default; }
	public bool SetValueFloat(float InFloat,bool ReturnValue) { return default; }
	public bool SetValueDouble(double InDouble,bool ReturnValue) { return default; }
	public bool SetValueString(sbyte InStringValue,bool ReturnValue) { return default; }
	public bool SetValueName(sbyte InNameValue,bool ReturnValue) { return default; }
	public bool SetValueText(sbyte InTextValue,bool ReturnValue) { return default; }
	public bool SetValueNumericInteger(long InInt64Value,bool ReturnValue) { return default; }
	public bool SetValueVector(FVector InVector,bool ReturnValue) { return default; }
	public bool SetValueRotator(FRotator InRotator,bool ReturnValue) { return default; }
	public bool SetValueColor(FColor InColor,bool ReturnValue) { return default; }
	public sbyte GetPropertyName(sbyte ReturnValue) { return default; }
	public sbyte PropertyName;
	public FGuid Id;
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
	public sbyte DisplayName;
	public int DisplayIndex;
	public TMap<sbyte,sbyte> Metadata;
}
