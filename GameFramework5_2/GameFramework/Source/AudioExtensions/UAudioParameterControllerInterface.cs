#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioParameterControllerInterface.h")]
public partial class UAudioParameterControllerInterface : UInterface {
// AudioParameterControllerInterface
	public void ResetParameters() {}
	public void SetTriggerParameter(sbyte InName) {}
	public void SetBoolParameter(sbyte InName,bool InBool) {}
	public void SetBoolArrayParameter(sbyte InName,TArray<bool> InValue) {}
	public void SetIntParameter(sbyte InName,int InInt) {}
	public void SetIntArrayParameter(sbyte InName,TArray<int> InValue) {}
	public void SetFloatParameter(sbyte InName,float InFloat) {}
	public void SetFloatArrayParameter(sbyte InName,TArray<float> InValue) {}
	public void SetStringParameter(sbyte InName,sbyte InValue) {}
	public void SetStringArrayParameter(sbyte InName,TArray<sbyte> InValue) {}
	public void SetObjectParameter(sbyte InName,UObject InValue) {}
	public void SetObjectArrayParameter(sbyte InName,TArray<UObject> InValue) {}
	public void SetParameters_Blueprint(TArray<FAudioParameter> InParameters) {}
}
