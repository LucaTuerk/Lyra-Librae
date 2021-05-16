// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Lyra_Librae : ModuleRules
{
	public Lyra_Librae(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
