#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackSection.h")]
///<summary>Defines data for sections visible in the stack view.</summary>
public partial struct FNiagaraStackSection {
// NiagaraStackSection
	public sbyte SectionIdentifier;
	public sbyte SectionDisplayName;
	public TArray<sbyte> Categories;
	public bool bEnabled;
}
