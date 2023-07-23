#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentRendererProperties.h")]
public partial struct FNiagaraComponentPropertyBinding {
// NiagaraComponentPropertyBinding
	public FNiagaraVariableAttributeBinding AttributeBinding;
	public sbyte PropertyName;
	public FNiagaraTypeDefinition PropertyType;
	public sbyte MetadataSetterName;
	public TMap<sbyte,sbyte> PropertySetterParameterDefaults;
}
