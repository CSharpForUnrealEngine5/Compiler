#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorSettings.h")]
public partial struct FNiagaraNamespaceMetadata {
// NiagaraNamespaceMetadata
	public TArray<sbyte> Namespaces;
	public sbyte RequiredNamespaceModifier;
	public sbyte DisplayName;
	public sbyte DisplayNameLong;
	public sbyte Description;
	public FLinearColor BackgroundColor;
	public sbyte ForegroundStyle;
	public int SortId;
	public TArray<sbyte> OptionalNamespaceModifiers;
	public TArray<ENiagaraNamespaceMetadataOptions> Options;
	public FGuid Guid;
}
