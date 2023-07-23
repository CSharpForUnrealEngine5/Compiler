#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
public partial class UImportanceSamplingLibrary : UBlueprintFunctionLibrary {
// ImportanceSamplingLibrary
	public float RandomSobolFloat(int Index,int Dimension,float Seed,float ReturnValue) { return default; }
	public float NextSobolFloat(int Index,int Dimension,float PreviousValue,float ReturnValue) { return default; }
	public FVector2D RandomSobolCell2D(int Index,int NumCells=1,FVector2D Cell=FVector2D,FVector2D Seed=FVector2D,FVector2D ReturnValue) { return default; }
	public FVector2D NextSobolCell2D(int Index,int NumCells=1,FVector2D PreviousValue=FVector2D,FVector2D ReturnValue) { return default; }
	public FVector RandomSobolCell3D(int Index,int NumCells=1,FVector Cell=FVector,FVector Seed=FVector,FVector ReturnValue) { return default; }
	public FVector NextSobolCell3D(int Index,int NumCells=1,FVector PreviousValue=FVector,FVector ReturnValue) { return default; }
	public FImportanceTexture MakeImportanceTexture(UObject Texture,byte WeightingFunc,FImportanceTexture ReturnValue) { return default; }
	public void BreakImportanceTexture(FImportanceTexture ImportanceTexture,UObject Texture,byte WeightingFunc) {}
	public void ImportanceSample(FImportanceTexture Texture,FVector2D Rand,int Samples,float Intensity,FVector2D SamplePosition,FLinearColor SampleColor,float SampleIntensity,float SampleSize) {}
}
