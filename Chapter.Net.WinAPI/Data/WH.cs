// -----------------------------------------------------------------------------------------------------------------
// <copyright file="WH.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI.Data;

public enum WH
{
    MSGFILTER = -1,
    JOURNALRECORD = 0,
    JOURNALPLAYBACK = 1,
    KEYBOARD = 2,
    GETMESSAGE = 3,
    CALLWNDPROC = 4,
    CBT = 5,
    SYSMSGFILTER = 6,
    MOUSE = 7,
    HARDWARE = 8,
    DEBUG = 9,
    SHELL = 10,
    FOREGROUNDIDLE = 11,
    CALLWNDPROCRET = 12,
    KEYBOARD_LL = 13,
    MOUSE_LL = 14
}