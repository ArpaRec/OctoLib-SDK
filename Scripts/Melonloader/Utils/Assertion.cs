﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MelonLoader.Utils
{
    internal static class Assertion
    {
        internal static bool ShouldContinue = true;

        //TODO: Could this be done in a better way? net35/6 load PresentationFramework differently so I could not rely on it
        //This crashes with start screen enabled
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);

        internal static void ThrowInternalFailure(string msg)
        {

        }
    }
}