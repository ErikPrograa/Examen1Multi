// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ExamenMulti : ModuleRules
{
	public ExamenMulti(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ExamenMulti",
			"ExamenMulti/Variant_Platforming",
			"ExamenMulti/Variant_Platforming/Animation",
			"ExamenMulti/Variant_Combat",
			"ExamenMulti/Variant_Combat/AI",
			"ExamenMulti/Variant_Combat/Animation",
			"ExamenMulti/Variant_Combat/Gameplay",
			"ExamenMulti/Variant_Combat/Interfaces",
			"ExamenMulti/Variant_Combat/UI",
			"ExamenMulti/Variant_SideScrolling",
			"ExamenMulti/Variant_SideScrolling/AI",
			"ExamenMulti/Variant_SideScrolling/Gameplay",
			"ExamenMulti/Variant_SideScrolling/Interfaces",
			"ExamenMulti/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
