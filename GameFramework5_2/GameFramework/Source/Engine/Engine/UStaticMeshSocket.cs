#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMeshSocket.h")]
public partial class UStaticMeshSocket : UObject {
// StaticMeshSocket
	public sbyte SocketName;
	public FVector RelativeLocation;
	public FRotator RelativeRotation;
	public FVector RelativeScale;
	public sbyte Tag;
	public UStaticMesh PreviewStaticMesh;
	public bool bSocketCreatedAtImport;
}
