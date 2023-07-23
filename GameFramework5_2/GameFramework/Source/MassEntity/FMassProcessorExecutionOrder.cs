#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial struct FMassProcessorExecutionOrder {
// MassProcessorExecutionOrder
	public sbyte ExecuteInGroup;
	public TArray<sbyte> ExecuteBefore;
	public TArray<sbyte> ExecuteAfter;
}
