#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Account/IPortalUser.h")]
///<summary>The basic data for the last or currently signed-in user.</summary>
public partial struct FPortalUserDetails {
// PortalUserDetails
	public sbyte DisplayName;
	public sbyte Email;
	public sbyte RealName;
	public bool IsSignedIn;
}
