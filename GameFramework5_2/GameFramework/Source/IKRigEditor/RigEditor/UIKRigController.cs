#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigEditor/IKRigController.h")]
///<summary>A singleton (per-asset) class used to make modifications to a UIKRigDefinition asset</summary>
public partial class UIKRigController : UObject {
// IKRigController
	public UObject GetController(UObject InIKRigDefinition,UObject ReturnValue) { return default; }
	public bool SetSkeletalMesh(UObject SkeletalMesh,bool bTransact=false,bool ReturnValue) { return default; }
	public UObject GetSkeletalMesh(UObject ReturnValue) { return default; }
	public bool IsSkeletalMeshCompatible(UObject SkeletalMeshToCheck,bool ReturnValue) { return default; }
	public int AddSolver(UClass InSolverClass,int ReturnValue) { return default; }
	public bool RemoveSolver(int SolverIndex,bool ReturnValue) { return default; }
	public UObject GetSolverAtIndex(int Index,UObject ReturnValue) { return default; }
	public int GetIndexOfSolver(UObject Solver,int ReturnValue) { return default; }
	public int GetNumSolvers(int ReturnValue) { return default; }
	public bool MoveSolverInStack(int SolverToMoveIndex,int TargetSolverIndex,bool ReturnValue) { return default; }
	public bool SetSolverEnabled(int SolverIndex,bool bIsEnabled,bool ReturnValue) { return default; }
	public bool GetSolverEnabled(int SolverIndex,bool ReturnValue) { return default; }
	public bool SetRootBone(sbyte RootBoneName,int SolverIndex,bool ReturnValue) { return default; }
	public sbyte GetRootBone(int SolverIndex,sbyte ReturnValue) { return default; }
	public bool SetEndBone(sbyte EndBoneName,int SolverIndex,bool ReturnValue) { return default; }
	public sbyte GetEndBone(int SolverIndex,sbyte ReturnValue) { return default; }
	public sbyte AddNewGoal(sbyte GoalName,sbyte BoneName,sbyte ReturnValue) { return default; }
	public bool RemoveGoal(sbyte GoalName,bool ReturnValue) { return default; }
	public sbyte RenameGoal(sbyte OldName,sbyte PotentialNewName,sbyte ReturnValue) { return default; }
	public bool SetGoalBone(sbyte GoalName,sbyte NewBoneName,bool ReturnValue) { return default; }
	public sbyte GetBoneForGoal(sbyte GoalName,sbyte ReturnValue) { return default; }
	public sbyte GetGoalNameForBone(sbyte BoneName,sbyte ReturnValue) { return default; }
	public bool ConnectGoalToSolver(sbyte GoalName,int SolverIndex,bool ReturnValue) { return default; }
	public bool DisconnectGoalFromSolver(sbyte GoalToRemove,int SolverIndex,bool ReturnValue) { return default; }
	public bool IsGoalConnectedToSolver(sbyte GoalName,int SolverIndex,bool ReturnValue) { return default; }
	public bool IsGoalConnectedToAnySolver(sbyte GoalName,bool ReturnValue) { return default; }
	public UObject GetGoal(sbyte GoalName,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllGoals(TArray<UObject> ReturnValue) { return default; }
	public UObject GetGoalSettingsForSolver(sbyte GoalName,int SolverIndex,UObject ReturnValue) { return default; }
	public bool SetBoneExcluded(sbyte BoneName,bool bExclude,bool ReturnValue) { return default; }
	public bool GetBoneExcluded(sbyte BoneName,bool ReturnValue) { return default; }
	public bool AddBoneSetting(sbyte BoneName,int SolverIndex,bool ReturnValue) { return default; }
	public bool RemoveBoneSetting(sbyte BoneName,int SolverIndex,bool ReturnValue) { return default; }
	public UObject GetBoneSettings(sbyte BoneName,int SolverIndex,UObject ReturnValue) { return default; }
	public FTransform GetRefPoseTransformOfBone(sbyte BoneName,FTransform ReturnValue) { return default; }
	public sbyte AddRetargetChain(sbyte ChainName,sbyte StartBoneName,sbyte EndBoneName,sbyte GoalName,sbyte ReturnValue) { return default; }
	public bool RemoveRetargetChain(sbyte ChainName,bool ReturnValue) { return default; }
	public sbyte RenameRetargetChain(sbyte ChainName,sbyte NewChainName,sbyte ReturnValue) { return default; }
	public bool SetRetargetChainStartBone(sbyte ChainName,sbyte StartBoneName,bool ReturnValue) { return default; }
	public bool SetRetargetChainEndBone(sbyte ChainName,sbyte EndBoneName,bool ReturnValue) { return default; }
	public bool SetRetargetChainGoal(sbyte ChainName,sbyte GoalName,bool ReturnValue) { return default; }
	public sbyte GetRetargetChainGoal(sbyte ChainName,sbyte ReturnValue) { return default; }
	public sbyte GetRetargetChainStartBone(sbyte ChainName,sbyte ReturnValue) { return default; }
	public sbyte GetRetargetChainEndBone(sbyte ChainName,sbyte ReturnValue) { return default; }
	public TArray<FBoneChain> GetRetargetChains(TArray<FBoneChain> ReturnValue) { return default; }
	public bool SetRetargetRoot(sbyte RootBoneName,bool ReturnValue) { return default; }
	public sbyte GetRetargetRoot(sbyte ReturnValue) { return default; }
	public UIKRigDefinition Asset;
}
