// -----------------------------------------------------------------------------------------------------------------
// <copyright file="UxThemeWrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI
{
    public class UxThemeWrapper : IUxTheme
    {
        public uint GetImmersiveUserColorSetPreference(bool forceCheckRegistry, bool skipCheckOnFail)
        {
            return UxTheme.GetImmersiveUserColorSetPreference(forceCheckRegistry, skipCheckOnFail);
        }

        public uint GetImmersiveColorSetCount()
        {
            return UxTheme.GetImmersiveColorSetCount();
        }

        public uint GetImmersiveColorFromColorSetEx(uint immersiveColorSet, uint immersiveColorType, bool ignoreHighContrast, uint highContrastCacheMode)
        {
            return UxTheme.GetImmersiveColorFromColorSetEx(immersiveColorSet, immersiveColorType, ignoreHighContrast, highContrastCacheMode);
        }

        public uint GetImmersiveColorTypeFromName(IntPtr name)
        {
            return UxTheme.GetImmersiveColorTypeFromName(name);
        }

        public IntPtr GetImmersiveColorNamedTypeByIndex(uint index)
        {
            return UxTheme.GetImmersiveColorNamedTypeByIndex(index);
        }
    }
}