#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Replaces all names within the collection</summary>
public partial struct FRigUnit_CollectionReplaceItems {
// RigUnit_CollectionReplaceItems
	public FRigElementKeyCollection Items;
	public sbyte Old;
	public sbyte New;
	public bool RemoveInvalidItems;
	public bool bAllowDuplicates;
	public FRigElementKeyCollection Collection;
}