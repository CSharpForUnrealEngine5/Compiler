#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardData.h")]
///<summary>blackboard entry definition</summary>
public partial struct FBlackboardEntry {
// BlackboardEntry
	public sbyte EntryName;
	public sbyte EntryDescription;
	public sbyte EntryCategory;
	public UBlackboardKeyType KeyType;
	public bool bInstanceSynced;
}
