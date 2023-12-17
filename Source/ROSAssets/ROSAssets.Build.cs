// Copyright 2020-2023 Rapyuta Robotics Co., Ltd.

using System;
using System.IO;
using UnrealBuildTool;

public class ROSAssets : ModuleRules
{
    private string ModulePath
    {
        get { return ModuleDirectory; }
    }

    public ROSAssets(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        CppStandard = CppStandardVersion.Cpp17;
        bEnableExceptions = true;

        // Runtime modules
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "RenderCore", "Renderer", "RHI", "PhysicsCore",
                                                            "ImageWrapper", "XmlParser", "Json", "PakFile", "IESFile",
                                                            "AIModule", "NavigationSystem", "TimeManagement", "UMG",
                                                            "ProceduralMeshComponent", "MeshDescription", "StaticMeshDescription", "MeshConversion",
                                                            "rclUE", "RapyutaSimulationPlugins"});

        PrivateDependencyModuleNames.AddRange(new string[] { });

        // Developer/Editor modules
        if (Target.bBuildEditor)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "UnrealEd",
                    "AssetTools",
                    "PhysicsUtilities"
                }
            );
        }

    }
}
