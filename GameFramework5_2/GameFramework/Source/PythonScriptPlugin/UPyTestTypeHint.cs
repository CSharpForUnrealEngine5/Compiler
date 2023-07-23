#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Used to verify if the generated Python stub is correctly type-hinted (if type hint is enabled). The stub is generated</summary>
public partial class UPyTestTypeHint : UObject {
// PyTestTypeHint
	public sbyte GetStringConst(sbyte ReturnValue) { return default; }
	public int GetIntConst(int ReturnValue) { return default; }
	public bool BoolProp;
	public int IntProp;
	public float FloatProp;
	public EPyTestEnum EnumProp;
	public sbyte StringProp;
	public sbyte NameProp;
	public sbyte TextProp;
	public object FieldPathProp;
	public FPyTestStruct StructProp;
	public UPyTestObject ObjectProp;
	public TArray<sbyte> StrArrayProp;
	public TArray<sbyte> NameArrayProp;
	public TArray<sbyte> TextArrayProp;
	public TArray<UObject> ObjectArrayProp;
	public TSet<sbyte> SetProp;
	public TMap<int,sbyte> MapProp;
	public FPyTestDelegate DelegateProp;
	public FPyTestMulticastDelegate MulticastDelegateProp;
	public bool CheckBoolTypeHints(bool bParam1,bool bParam2=true,bool bParam3=false,bool ReturnValue) { return default; }
	public int CheckIntegerTypeHints(byte Param1,int Param2=4,long Param3=5,int ReturnValue) { return default; }
	public double CheckFloatTypeHints(float Param1,double Param2,float Param3=-3.3f,double Param4=4.4,double ReturnValue) { return default; }
	public EPyTestEnum CheckEnumTypeHints(EPyTestEnum Param1,EPyTestEnum Param2=EPyTestEnum,EPyTestEnum ReturnValue) { return default; }
	public sbyte CheckStringTypeHints(sbyte Param1,sbyte Param2=TEXT,sbyte ReturnValue) { return default; }
	public sbyte CheckNameTypeHints(sbyte Param1,sbyte Param2=FName,sbyte ReturnValue) { return default; }
	public sbyte CheckTextTypeHints(sbyte Param1,sbyte Param2=INVTEXT,sbyte ReturnValue) { return default; }
	public object CheckFieldPathTypeHints(object Param1,object ReturnValue) { return default; }
	public FPyTestStruct CheckStructTypeHints(FPyTestStruct Param1,FPyTestStruct Param2=FPyTestStruct,FPyTestStruct ReturnValue) { return default; }
	public UObject CheckObjectTypeHints(UObject Param1,UObject Param4=nullptr,UObject ReturnValue) { return default; }
	public TArray<sbyte> CheckArrayTypeHints(TArray<sbyte> Param1,TArray<sbyte> Param2,TArray<sbyte> Param3,TArray<UObject> Param4,TArray<sbyte> ReturnValue) { return default; }
	public TSet<sbyte> CheckSetTypeHints(TSet<sbyte> Param1,TSet<sbyte> Param2,TSet<UObject> Param3,TSet<sbyte> ReturnValue) { return default; }
	public TMap<sbyte,UObject> CheckMapTypeHints(TMap<int,sbyte> Param1,TMap<int,sbyte> Param2,TMap<int,sbyte> Param3,TMap<int,UObject> Param4,TMap<sbyte,UObject> ReturnValue) { return default; }
	public FPyTestDelegate CheckDelegateTypeHints(FPyTestDelegate Param1,FPyTestDelegate ReturnValue) { return default; }
	public bool CheckStaticFunction(bool Param1,int Param2,double Param3,sbyte Param4,bool ReturnValue) { return default; }
	public int CheckTupleReturnType(sbyte InOutString,int ReturnValue) { return default; }
	public FPyTestSlateTickDelegate SlateTickDelegate;
}
