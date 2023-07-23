#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Struct used to configure which NetDriver is started with Iris enabled or not</summary>
public partial struct FIrisNetDriverConfig {
// IrisNetDriverConfig
	public sbyte NetDriverDefinition;
	public sbyte NetDriverName;
	public sbyte NetDriverWildcardName;
	public bool bEnableIris;
}
