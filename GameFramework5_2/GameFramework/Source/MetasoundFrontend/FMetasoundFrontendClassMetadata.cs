#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendClassMetadata {
// MetasoundFrontendClassMetadata
	public FMetasoundFrontendClassName ClassName;
	public FMetasoundFrontendVersionNumber Version;
	public EMetasoundFrontendClassType Type;
	public sbyte DisplayName;
	public sbyte DisplayNameTransient;
	public sbyte Description;
	public sbyte DescriptionTransient;
	public sbyte PromptIfMissingTransient;
	public sbyte Author;
	public TArray<sbyte> Keywords;
	public TArray<sbyte> KeywordsTransient;
	public TArray<sbyte> CategoryHierarchy;
	public TArray<sbyte> CategoryHierarchyTransient;
	public bool bIsDeprecated;
	public bool bAutoUpdateManagesInterface;
	public bool bSerializeText;
	public FGuid ChangeID;
}
