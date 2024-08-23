// -----------------------------------------------------------------------------------------------------------------
// <copyright file="SHGFI.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI;

public struct SHGFI
{
    public const uint ICON = 0x000000100;
    public const uint LARGEICON = 0x000000000;
    public const uint SMALLICON = 0x000000001;
    public const uint USEFILEATTRIBUTE = 0x000000010;
    public const uint FileAttributeNormal = 0x00000080;
}