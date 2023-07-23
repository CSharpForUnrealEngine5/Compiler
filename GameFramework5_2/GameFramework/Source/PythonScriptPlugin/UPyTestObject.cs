#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Object to allow testing of the various UObject features that are exposed to Python wrapped types.</summary>
public partial class UPyTestObject : UObject {
// PyTestObject
	public bool Bool;
	public int Int;
	public float Float;
	public EPyTestEnum Enum;
	public sbyte String;
	public sbyte Name;
	public sbyte Text;
	public object FieldPath;
	public object StructFieldPath;
	public TArray<sbyte> StringArray;
	public TSet<sbyte> StringSet;
	public TMap<sbyte,int> StringIntMap;
	public FPyTestDelegate Delegate;
	public FPyTestMulticastDelegate MulticastDelegate;
	public FPyTestStruct Struct;
	public TArray<FPyTestStruct> StructArray;
	public FPyTestChildStruct ChildStruct;
	public bool BoolInstanceOnly;
	public bool BoolDefaultsOnly;
	public int FuncBlueprintImplementable(int InValue,int ReturnValue) { return default; }
	public int FuncBlueprintNative(int InValue,int ReturnValue) { return default; }
	public void FuncBlueprintNativeRef(FPyTestStruct InOutStruct) {}
	public int CallFuncBlueprintImplementable(int InValue,int ReturnValue) { return default; }
	public int CallFuncBlueprintNative(int InValue,int ReturnValue) { return default; }
	public void CallFuncBlueprintNativeRef(FPyTestStruct InOutStruct) {}
	public void FuncTakingPyTestStruct(FPyTestStruct InStruct) {}
	public void FuncTakingPyTestChildStruct(FPyTestChildStruct InStruct) {}
	public void LegacyFuncTakingPyTestStruct(FPyTestStruct InStruct) {}
	public void FuncTakingPyTestStructDefault(FPyTestStruct InStruct=FPyTestStruct) {}
	public int FuncTakingPyTestDelegate(FPyTestDelegate InDelegate,int InValue,int ReturnValue) { return default; }
	public void FuncTakingFieldPath(object InFieldPath) {}
	public int DelegatePropertyCallback(int InValue,int ReturnValue) { return default; }
	public void MulticastDelegatePropertyCallback(sbyte InStr) {}
	public TArray<int> ReturnArray(TArray<int> ReturnValue) { return default; }
	public TSet<int> ReturnSet(TSet<int> ReturnValue) { return default; }
	public TMap<int,bool> ReturnMap(TMap<int,bool> ReturnValue) { return default; }
	public object ReturnFieldPath(object ReturnValue) { return default; }
	public void EmitScriptError() {}
	public void EmitScriptWarning() {}
	public int GetConstantValue(int ReturnValue) { return default; }
}
