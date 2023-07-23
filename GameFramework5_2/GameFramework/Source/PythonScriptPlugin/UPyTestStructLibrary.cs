#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>Function library containing methods that should be hoisted onto the test struct in Python.</summary>
public partial class UPyTestStructLibrary : UBlueprintFunctionLibrary {
// PyTestStructLibrary
	public bool IsBoolSet(FPyTestStruct InStruct,bool ReturnValue) { return default; }
	public bool LegacyIsBoolSet(FPyTestStruct InStruct,bool ReturnValue) { return default; }
	public int GetConstantValue(int ReturnValue) { return default; }
	public FPyTestStruct AddInt(FPyTestStruct InStruct,int InValue,FPyTestStruct ReturnValue) { return default; }
	public FPyTestStruct AddFloat(FPyTestStruct InStruct,float InValue,FPyTestStruct ReturnValue) { return default; }
	public FPyTestStruct AddStr(FPyTestStruct InStruct,sbyte InValue,FPyTestStruct ReturnValue) { return default; }
	public void SetBoolMutable(FPyTestStruct InStruct) {}
	public void ClearBoolMutable(FPyTestStruct InStruct) {}
	public void SetBoolMutableViaRef(FPyTestStruct InStruct) {}
	public void ClearBoolMutableViaRef(FPyTestStruct InStruct) {}
}
