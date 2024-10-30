// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MassAITestingEditorTarget : TargetRules
{
	public MassAITestingEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		ExtraModuleNames.Add("MassAITesting");
	}
}
