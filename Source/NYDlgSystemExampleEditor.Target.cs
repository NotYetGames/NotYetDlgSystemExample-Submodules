// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NYDlgSystemExampleEditorTarget : TargetRules
{
	public NYDlgSystemExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		bUseUnityBuild = true;
		// bUseSharedPCHs = false;
		// bUsePCHFiles = false;

		ExtraModuleNames.AddRange( new string[] { "NYDlgSystemExample" } );
	}
}
