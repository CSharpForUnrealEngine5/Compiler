#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertServerSettings.h")]
public partial class UConcertServerConfig : UObject {
// ConcertServerConfig
	public bool bAutoArchiveOnReboot;
	public bool bAutoArchiveOnShutdown;
	public bool bCleanWorkingDir;
	public int NumSessionsToKeep;
	public sbyte ServerName;
	public sbyte DefaultSessionName;
	public TSet<sbyte> AuthorizedClientKeys;
	public sbyte DefaultSessionToRestore;
	public FConcertSessionVersionInfo DefaultVersionInfo;
	public FConcertSessionSettings DefaultSessionSettings;
	public FConcertServerSettings ServerSettings;
	public FConcertEndpointSettings EndpointSettings;
	public sbyte WorkingDir;
	public sbyte ArchiveDir;
	public sbyte SessionRepositoryRootDir;
	public bool bMountDefaultSessionRepository;
}
