#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationPath.h")]
///<summary>UObject wrapper for FNavigationPath</summary>
public partial class UNavigationPath : UObject {
// NavigationPath
	public FOnNavigationPathUpdated PathUpdatedNotifier;
	public TArray<FVector> PathPoints;
	public byte RecalculateOnInvalidation;
	public sbyte GetDebugString(sbyte ReturnValue) { return default; }
	public void EnableDebugDrawing(bool bShouldDrawDebugData,FLinearColor PathColor=FLinearColor) {}
	public void EnableRecalculationOnInvalidation(byte DoRecalculation) {}
	public double GetPathLength(double ReturnValue) { return default; }
	public double GetPathCost(double ReturnValue) { return default; }
	public bool IsPartial(bool ReturnValue) { return default; }
	public bool IsValid(bool ReturnValue) { return default; }
	public bool IsStringPulled(bool ReturnValue) { return default; }
}
