using UnrealBuildTool;

public class PS2_Mankiewicz_TofelTarget : TargetRules
{
	public PS2_Mankiewicz_TofelTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PS2_Mankiewicz_Tofel");
	}
}
