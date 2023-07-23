#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
///<summary>Script-exposed functionality for wrapping native functionality and constructing valid FAnimationCurveIdentifier instances</summary>
public partial class UAnimationCurveIdentifierExtensions : UBlueprintFunctionLibrary {
// AnimationCurveIdentifierExtensions
	public bool IsValid(FAnimationCurveIdentifier Identifier,bool ReturnValue) { return default; }
	public sbyte GetName(FAnimationCurveIdentifier Identifier,sbyte ReturnValue) { return default; }
	public ERawCurveTrackTypes GetType(FAnimationCurveIdentifier Identifier,ERawCurveTrackTypes ReturnValue) { return default; }
	public FAnimationCurveIdentifier GetCurveIdentifier(UObject InSkeleton,sbyte Name,ERawCurveTrackTypes CurveType,FAnimationCurveIdentifier ReturnValue) { return default; }
	public FAnimationCurveIdentifier FindCurveIdentifier(UObject InSkeleton,sbyte Name,ERawCurveTrackTypes CurveType,FAnimationCurveIdentifier ReturnValue) { return default; }
	public TArray<FAnimationCurveIdentifier> GetCurveIdentifiers(UObject InSkeleton,ERawCurveTrackTypes CurveType,TArray<FAnimationCurveIdentifier> ReturnValue) { return default; }
	public bool GetTransformChildCurveIdentifier(FAnimationCurveIdentifier InOutIdentifier,ETransformCurveChannel Channel,EVectorCurveChannel Axis,bool ReturnValue) { return default; }
}
