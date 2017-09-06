// Copyright (C) 2013-2015 iFunFactory Inc. All Rights Reserved.
//
// This work is confidential and proprietary to iFunFactory Inc. and
// must not be used, disclosed, copied, or distributed without the prior
// consent of iFunFactory Inc.

using UnrealBuildTool;
using System.Collections.Generic;

public class funapi_plugin_ue4EditorTarget : TargetRules
{
    public funapi_plugin_ue4EditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;

        ExtraModuleNames.Add("funapi_plugin_ue4");
    }

    //
    // TargetRules interface.
    //
}
