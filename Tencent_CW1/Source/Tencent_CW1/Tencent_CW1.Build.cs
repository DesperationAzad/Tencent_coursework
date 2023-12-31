// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Tencent_CW1 : ModuleRules
{
    public Tencent_CW1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
