﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace PInvoke
{
    using System;
    using System.Runtime.InteropServices;

    /// <content>
    /// Exported functions from the DwmApi.dll Windows library
    /// that are available to Desktop apps only.
    /// </content>
    [OfferFriendlyOverloads]
    public static partial class DwmApi
    {
        /// <summary>
        /// Issues a flush call that blocks the caller until the next present, when all of the Microsoft DirectX surface updates that are currently outstanding have been made. This compensates for very complex scenes or calling processes with very low priority.
        /// </summary>
        /// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
        /// <remarks>
        /// DwmFlush waits for any queued DirectX changes that were queued by the calling application to be drawn to the screen before returning. It does not flush the entire session rendering batch.
        /// </remarks>
        [DllImport(nameof(DwmApi))]
        public static extern HResult DwmFlush();

        /// <summary>
        /// Retrieves the current color used for Desktop Window Manager (DWM) glass composition. This value is based on the current color scheme and can be modified by the user. Applications can listen for color changes by handling the WM_DWMCOLORIZATIONCOLORCHANGED notification.
        /// </summary>
        /// <param name="pcrColorization">A pointer to a value that, when this function returns successfully, receives the current color used for glass composition. The color format of the value is 0xAARRGGBB.</param>
        /// <param name="pfOpaqueBlend">A pointer to a value that, when this function returns successfully, indicates whether the color is an opaque blend. TRUE if the color is an opaque blend; otherwise, FALSE.</param>
        /// <returns>If this function succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
        [DllImport(nameof(DwmApi))]
        public static extern HResult DwmGetColorizationColor(
            out uint pcrColorization,
            [MarshalAs(UnmanagedType.Bool)] out bool pfOpaqueBlend);
    }
}