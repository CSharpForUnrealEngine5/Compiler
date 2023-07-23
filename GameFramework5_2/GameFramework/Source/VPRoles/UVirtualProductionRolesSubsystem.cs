#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPRolesSubsystem.h")]
///<summary>Subsystem for common Virtual Production roles operations.</summary>
public partial class UVirtualProductionRolesSubsystem : UEngineSubsystem {
// VirtualProductionRolesSubsystem
	public void FOnRolesChanged(TArray<sbyte> EnabledRoles) {}
	public TArray<sbyte> GetActiveRoles(TArray<sbyte> ReturnValue) { return default; }
	public bool HasActiveRole(sbyte Role,bool ReturnValue) { return default; }
	public sbyte GetActiveRolesString(sbyte ReturnValue) { return default; }
	public void SetActiveRoles(TArray<sbyte> Roles) {}
	public TArray<sbyte> GetAllRoles(TArray<sbyte> ReturnValue) { return default; }
	public bool AddRole(sbyte RoleName,bool ReturnValue) { return default; }
	public bool RemoveRole(sbyte RoleName,bool ReturnValue) { return default; }
	public FOnRolesChanged OnRolesChangedBP;
}
