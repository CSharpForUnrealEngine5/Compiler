#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerTrainingModel.h")]
///<summary>The training model base class.</summary>
public partial class UMLDeformerTrainingModel : UObject {
// MLDeformerTrainingModel
	public UObject GetModel(UObject ReturnValue) { return default; }
	public int GetNumberSampleTransforms(int ReturnValue) { return default; }
	public int GetNumberSampleCurves(int ReturnValue) { return default; }
	public int GetNumberSampleDeltas(int ReturnValue) { return default; }
	public int NumSamples(int ReturnValue) { return default; }
	public bool SetCurrentSampleIndex(int Index,bool ReturnValue) { return default; }
	public bool GetNeedsResampling(bool ReturnValue) { return default; }
	public void SetNeedsResampling(bool bNeedsResampling) {}
	public void SetNumFloatsPerCurve(int NumFloatsPerCurve) {}
	public TArray<float> SampleDeltas;
	public TArray<float> SampleCurveValues;
	public TArray<float> SampleBoneRotations;
}
