// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IShell32.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

namespace Chapter.Net.WinAPI
{
    public interface IShell32
    {
        IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
    }
}