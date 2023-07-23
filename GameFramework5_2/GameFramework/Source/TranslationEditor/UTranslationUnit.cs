#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TranslationUnit.h")]
public partial class UTranslationUnit : UObject {
// TranslationUnit
	public sbyte Namespace;
	public sbyte Key;
	public sbyte Source;
	public sbyte Translation;
	public TArray<FTranslationContextInfo> Contexts;
	public bool HasBeenReviewed;
	public sbyte TranslationBeforeImport;
	public sbyte LocresPath;
}
