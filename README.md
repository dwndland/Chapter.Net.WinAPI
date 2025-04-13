![Chapter](https://raw.githubusercontent.com/dwndland/Chapter.Net.WinAPI/master/Icon.png)

# Chapter.Net.WinAPI Library

## Overview
Chapter.Net.WinAPI is an internal library that provides low-level WinAPI bindings used by other Chapter libraries; it is not intended for standalone use and remains incomplete by design.

## Features
- **Dwmapi:** Access to the WinAPI methods within the "dwmapi.dll"
- **Kernel32:** Access to WinAPI methods within the "kernel32.dll".
- **Shell32:** Access to WinAPI methods within the "shell32.dll".
- **User32:** Access to WinAPI methods within the "user32.dll".
- **UxTheme:** Access to WinAPI methods within the "uxtheme.dll".
- **Data:** Values and structures to use within any of those above. Like WM (WindowMessages), WH (WindowHandle) and many more.

## Getting Started

1. **Installation:**
    - Install the Chapter.Net.WinAPI library via NuGet Package Manager:
    ```bash
    dotnet add package Chapter.Net.WinAPI
    ```

2. **Usage:**
    - Direct access the objects like
    ```csharp
    User32.ShowWindow(windowHandle, WindowShowStyle.Restore);
    ```
    - Or a wrapper
    ```csharp
    public class Demo
    {
        public Demo(IUser32 user32)
        {
            _user32 = user32;
        }

        public void RestoreWindow(Window window)
        {
            var windowHandle = ((HwndSource)PresentationSource.FromVisual(window))!.Handle;
            _user32.ShowWindow(windowHandle, WindowShowStyle.Restore);
        }
    }
    ```

## Example
- Target
    ```csharp
    public class Demo
    {
        public Demo(IUser32 user32)
        {
            _user32 = user32;
        }

        public void RestoreWindow(Window window)
        {
            var windowHandle = ((HwndSource)PresentationSource.FromVisual(window))!.Handle;
            _user32.ShowWindow(windowHandle, WindowShowStyle.Restore);
        }
    }
    ```
- UnitTest
    ```csharp
    public class DemoTests
    {
        private Demo _target,

        [Setup]
        public void Setup()
        {
            _user32 = new Mock<IUser32>();
            _target = new Demo(_user32.Object);
        }

        [Test]
        public void RestoreWindow_CalledAfterMinimizedFromNormal_RestoresTheWindowBackToNormal()
        {
            var window = Utils.OpenDummyWindow();
            window.WindowState = WindowState.Normal;

            window.WindowState = WindowState.Minimized;
            _target.RestoreWindow(window);

            _user32.Verify(x => x.ShowWindow(It.IsAny<nint>(), WindowShowStyle.Restore), Times.Once());
            Assert.That(window.WindowState, Is.EqualTo(WindowState.Normal));
        }

        [Test]
        public void RestoreWindow_CalledAfterMinimizedFromNormal_RestoresTheWindowBackToMaximized()
        {
            var window = Utils.OpenDummyWindow();
            window.WindowState = WindowState.Maximized;

            window.WindowState = WindowState.Minimized;
            _target.RestoreWindow(window);

            _user32.Verify(x => x.ShowWindow(It.IsAny<nint>(), WindowShowStyle.Restore), Times.Once());
            Assert.That(window.WindowState, Is.EqualTo(WindowState.Maximized));
        }
    }
    ```

## Links
* [NuGet](https://www.nuget.org/packages/Chapter.Net.WinAPI)
* [GitHub](https://github.com/dwndland/Chapter.Net.WinAPI)

## License
Copyright (c) David Wendland. All rights reserved.
Licensed under the MIT License. See LICENSE file in the project root for full license information.
