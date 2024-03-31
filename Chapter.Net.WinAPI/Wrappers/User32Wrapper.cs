// -----------------------------------------------------------------------------------------------------------------
// <copyright file="User32Wrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Text;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI
{
    public class User32Wrapper : IUser32
    {
        public bool SetForegroundWindow(IntPtr hWnd)
        {
            return User32.SetForegroundWindow(hWnd);
        }

        public bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow)
        {
            return User32.ShowWindow(hWnd, nCmdShow);
        }

        public int DestroyIcon(IntPtr hIcon)
        {
            return User32.DestroyIcon(hIcon);
        }

        public uint GetDoubleClickTime()
        {
            return User32.GetDoubleClickTime();
        }

        public IntPtr SetWindowsHookEx(int hookId, User32.Proc callbackFunction, IntPtr moduleHandle, uint threadId)
        {
            return User32.SetWindowsHookEx(hookId, callbackFunction, moduleHandle, threadId);
        }

        public bool UnhookWindowsHookEx(IntPtr hookId)
        {
            return User32.UnhookWindowsHookEx(hookId);
        }

        public IntPtr CallNextHookEx(IntPtr hookId, int code, IntPtr wParam, IntPtr lParam)
        {
            return User32.CallNextHookEx(hookId, code, wParam, lParam);
        }

        public int LoadString(IntPtr hInstance, uint stringId, StringBuilder lpBuffer, int nBufferMax)
        {
            return User32.LoadString(hInstance, stringId, lpBuffer, nBufferMax);
        }

        public int GetWindowLong(IntPtr hwnd, int index)
        {
            return User32.GetWindowLong(hwnd, index);
        }

        public int SetWindowLong(IntPtr hwnd, int index, int newStyle)
        {
            return User32.SetWindowLong(hwnd, index, newStyle);
        }

        public bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height, uint flags)
        {
            return User32.SetWindowPos(hwnd, hwndInsertAfter, x, y, width, height, flags);
        }

        public IntPtr GetSystemMenu(IntPtr windowHandle, bool revert)
        {
            return User32.GetSystemMenu(windowHandle, revert);
        }

        public bool EnableMenuItem(IntPtr menuHandle, uint itemId, uint enable)
        {
            return User32.EnableMenuItem(menuHandle, itemId, enable);
        }
    }
}