#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphSchema.h")]
///<summary>This structure represents a context dependent action, with sufficient information for the schema to perform it.</summary>
public partial struct FEdGraphSchemaAction {
// EdGraphSchemaAction
	public sbyte MenuDescription;
	public sbyte TooltipDescription;
	public sbyte Category;
	public sbyte Keywords;
	public int Grouping;
	public int SectionID;
	public TArray<sbyte> MenuDescriptionArray;
	public TArray<sbyte> FullSearchTitlesArray;
	public TArray<sbyte> FullSearchKeywordsArray;
	public TArray<sbyte> FullSearchCategoryArray;
	public TArray<sbyte> LocalizedMenuDescriptionArray;
	public TArray<sbyte> LocalizedFullSearchTitlesArray;
	public TArray<sbyte> LocalizedFullSearchKeywordsArray;
	public TArray<sbyte> LocalizedFullSearchCategoryArray;
	public sbyte SearchText;
}
