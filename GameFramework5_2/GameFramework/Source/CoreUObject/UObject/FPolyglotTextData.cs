#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Polyglot data that may be registered to the text localization manager at runtime.</summary>
public partial struct FPolyglotTextData {
// PolyglotTextData
	public ELocalizedTextSourceCategory Category;
	public sbyte NativeCulture;
	public sbyte Namespace;
	public sbyte Key;
	public sbyte NativeString;
	public TMap<sbyte,sbyte> LocalizedStrings;
	public bool bIsMinimalPatch;
	public sbyte CachedText;
}
