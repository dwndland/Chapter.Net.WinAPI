﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IUser32.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Chapter.Net.WinAPI;

public interface IUser32
{
    bool SetForegroundWindow(IntPtr hWnd);

    bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

    int DestroyIcon(IntPtr hIcon);

    uint GetDoubleClickTime();

    IntPtr SetWindowsHookEx(int hookId, User32.Proc callbackFunction, IntPtr moduleHandle, uint threadId);

    bool UnhookWindowsHookEx(IntPtr hookId);

    IntPtr CallNextHookEx(IntPtr hookId, int code, IntPtr wParam, IntPtr lParam);

    int LoadString(IntPtr hInstance, uint stringId, StringBuilder lpBuffer, int nBufferMax);

    int GetWindowLong(IntPtr hwnd, int index);

    int SetWindowLong(IntPtr hwnd, int index, int newStyle);

    bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height, uint flags);

    IntPtr GetSystemMenu(IntPtr windowHandle, bool revert);

    bool EnableMenuItem(IntPtr menuHandle, uint itemId, uint enable);

    int ToUnicode(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out] [MarshalAs(UnmanagedType.LPWStr, SizeParamIndex = 4)] StringBuilder pwszBuff, int cchBuff, uint wFlags);

    bool GetKeyboardState(byte[] lpKeyState);

    uint MapVirtualKey(uint uCode, MAPVK uMapType);
}