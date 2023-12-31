#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/NavLocalGridManager.h")]
///<summary>Manager for local navigation grids</summary>
public partial class UNavLocalGridManager : UObject {
// NavLocalGridManager
	public bool SetLocalNavigationGridDensity(UObject WorldContextObject,float CellSize) { return default; }
	public int AddLocalNavigationGridForPoint(UObject WorldContextObject,FVector Location,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	public int AddLocalNavigationGridForPoints(UObject WorldContextObject,TArray<FVector> Locations,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	public int AddLocalNavigationGridForBox(UObject WorldContextObject,FVector Location,FVector Extent/*=new FVector(1,1,1)*/,FRotator Rotation/*=FRotator.ZeroRotator*/,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	public int AddLocalNavigationGridForCapsule(UObject WorldContextObject,FVector Location,float CapsuleRadius,float CapsuleHalfHeight,int Radius2D/*=5*/,float Height/*=100.0f*/,bool bRebuildGrids/*=true*/) { return default; }
	public void RemoveLocalNavigationGrid(UObject WorldContextObject,int GridId,bool bRebuildGrids/*=true*/) {}
	public bool FindLocalNavigationGridPath(UObject WorldContextObject,FVector Start,FVector End,TArray<FVector> PathPoints) { return default; }
}
