#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListProjectLanguagesResponseDataItem {
// OneSkyListProjectLanguagesResponseDataItem
	public sbyte code;
	public sbyte english_name;
	public sbyte local_name;
	public sbyte locale;
	public sbyte region;
	public bool is_base_language;
	public bool is_ready_to_publish;
	public sbyte translation_progress;
}
