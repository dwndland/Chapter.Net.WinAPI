// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IUxTheme.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

namespace Chapter.Net.WinAPI;

public interface IUxTheme
{
    uint GetImmersiveUserColorSetPreference(bool forceCheckRegistry, bool skipCheckOnFail);

    uint GetImmersiveColorSetCount();

    uint GetImmersiveColorFromColorSetEx(uint immersiveColorSet, uint immersiveColorType, bool ignoreHighContrast, uint highContrastCacheMode);

    uint GetImmersiveColorTypeFromName(IntPtr name);

    IntPtr GetImmersiveColorNamedTypeByIndex(uint index);
}