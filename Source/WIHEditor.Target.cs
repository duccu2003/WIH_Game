// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class WIHEditorTarget : TargetRules
{
	public WIHEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "WIH" } );

		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_2;
    }
}
