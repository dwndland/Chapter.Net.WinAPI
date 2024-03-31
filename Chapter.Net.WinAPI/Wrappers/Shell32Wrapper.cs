// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Shell32Wrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI
{
    public class Shell32Wrapper : IShell32
    {
        public IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags)
        {
            return Shell32.SHGetFileInfo(pszPath, dwFileAttributes, ref psfi, cbSizeFileInfo, uFlags);
        }
    }
}