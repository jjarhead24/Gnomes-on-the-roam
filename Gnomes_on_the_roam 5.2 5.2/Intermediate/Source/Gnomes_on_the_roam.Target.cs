using UnrealBuildTool;

public class Gnomes_on_the_roamTarget : TargetRules
{
	public Gnomes_on_the_roamTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Gnomes_on_the_roam");
	}
}
