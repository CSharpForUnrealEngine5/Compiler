#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetInternationalizationLibrary.h")]
public partial class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary {
// KismetInternationalizationLibrary
	public bool SetCurrentCulture(sbyte Culture,bool SaveToConfig=false,bool ReturnValue) { return default; }
	public sbyte GetCurrentCulture(sbyte ReturnValue) { return default; }
	public bool SetCurrentLanguage(sbyte Culture,bool SaveToConfig=false,bool ReturnValue) { return default; }
	public sbyte GetCurrentLanguage(sbyte ReturnValue) { return default; }
	public bool SetCurrentLocale(sbyte Culture,bool SaveToConfig=false,bool ReturnValue) { return default; }
	public sbyte GetCurrentLocale(sbyte ReturnValue) { return default; }
	public bool SetCurrentLanguageAndLocale(sbyte Culture,bool SaveToConfig=false,bool ReturnValue) { return default; }
	public bool SetCurrentAssetGroupCulture(sbyte AssetGroup,sbyte Culture,bool SaveToConfig=false,bool ReturnValue) { return default; }
	public sbyte GetCurrentAssetGroupCulture(sbyte AssetGroup,sbyte ReturnValue) { return default; }
	public void ClearCurrentAssetGroupCulture(sbyte AssetGroup,bool SaveToConfig=false) {}
	public sbyte GetNativeCulture(ELocalizedTextSourceCategory TextCategory,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetLocalizedCultures(bool IncludeGame=true,bool IncludeEngine=false,bool IncludeEditor=false,bool IncludeAdditional=false,TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetSuitableCulture(TArray<sbyte> AvailableCultures,sbyte CultureToMatch,sbyte FallbackCulture=TEXT,sbyte ReturnValue) { return default; }
	public sbyte GetCultureDisplayName(sbyte Culture,bool Localized=true,sbyte ReturnValue) { return default; }
}
