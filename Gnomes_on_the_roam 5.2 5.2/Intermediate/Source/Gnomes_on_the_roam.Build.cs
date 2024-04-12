using UnrealBuildTool;

public class Gnomes_on_the_roam : ModuleRules
{
	public Gnomes_on_the_roam(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
