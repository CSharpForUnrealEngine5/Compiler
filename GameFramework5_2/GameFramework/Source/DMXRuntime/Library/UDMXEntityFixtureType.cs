#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixtureType.h")]
///<summary>Class to describe a type of Fixture. Fixture Patches can be created from Fixture Types (see UDMXEntityFixturePatch::ParentFixtureTypeTemplate).</summary>
public partial class UDMXEntityFixtureType : UDMXEntity {
// DMXEntityFixtureType
	public UObject CreateFixtureTypeInLibrary(FDMXEntityFixtureTypeConstructionParams ConstructionParams,string DesiredName/*=TEXT("")*/,bool bMarkDMXLibraryDirty/*=true*/) { return default; }
	public void RemoveFixtureTypeFromLibrary(FDMXEntityFixtureTypeRef FixtureTypeRef) {}
	public void SetModesFromDMXImport(UObject DMXImportAsset) {}
	public UDMXImport DMXImport;
	public FDMXFixtureCategory DMXCategory;
	public TArray<FDMXFixtureMode> Modes;
	public TArray<UDMXModulator> InputModulators;
	public bool bFixtureMatrixEnabled;
}
