using Microsoft.CodeAnalysis;

namespace VsaApiTemplate.SourceGen;

[Generator]
public sealed partial class Generator : IIncrementalGenerator
{
	public void Initialize(IncrementalGeneratorInitializationContext context)
	{
		context.RegisterPostInitializationOutput(ctx => ctx.AddSource(
			"Attributes.generator.cs", ThisAssembly.Resources.Attributes.Text));

		GenerateSyncEnums(context);
		GenerateConfigureOptions(context);
	}
}
