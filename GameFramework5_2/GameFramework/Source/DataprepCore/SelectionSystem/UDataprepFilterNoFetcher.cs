#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepFilter.h")]
///<summary>The Dataprep Filter a base class for the Dataprep selection system</summary>
public partial class UDataprepFilterNoFetcher : UDataprepParameterizableObject {
// DataprepFilterNoFetcher
	public sbyte GetDisplayFilterName(sbyte ReturnValue) { return default; }
	public sbyte GetNodeDisplayFilterName(sbyte ReturnValue) { return default; }
	public sbyte GetTooltipText(sbyte ReturnValue) { return default; }
	public sbyte GetAdditionalKeyword(sbyte ReturnValue) { return default; }
	public bool bIsExcludingResult;
}
