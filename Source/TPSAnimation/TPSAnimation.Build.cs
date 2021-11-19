// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TPSAnimation : ModuleRules
{
	public TPSAnimation(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
