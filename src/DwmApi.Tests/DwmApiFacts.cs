﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System;
using PInvoke;
using Xunit;
using static PInvoke.DwmApi;

public class DwmApiFacts
{
    [Fact]
    public void Flush()
    {
        DwmFlush().ThrowOnFailure();
    }

    [Fact]
    public void GetColorizationColor()
    {
        uint colorization;
        bool opaqueBlend;
        DwmGetColorizationColor(out colorization, out opaqueBlend).ThrowOnFailure();
        Assert.NotEqual(colorization, 0u);
    }
}