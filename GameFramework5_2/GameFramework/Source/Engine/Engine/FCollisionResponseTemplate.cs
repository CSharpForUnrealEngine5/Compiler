#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CollisionProfile.h")]
///<summary>Structure for collision response templates.</summary>
public partial struct FCollisionResponseTemplate {
// CollisionResponseTemplate
	public sbyte Name;
	public byte CollisionEnabled;
	public bool bCanModify;
	public sbyte ObjectTypeName;
	public TArray<FResponseChannel> CustomResponses;
	public sbyte HelpMessage;
}
