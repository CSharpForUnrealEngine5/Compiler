#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMessages.h")]
public partial struct FNiagaraStackMessage {
// NiagaraStackMessage
	public sbyte MessageText;
	public sbyte ShortDescription;
	public ENiagaraMessageSeverity MessageSeverity;
	public bool bAllowDismissal;
	public FGuid Guid;
}
