﻿using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace FlowTimer {
    
    public static class Win32 {

        public const int WH_KEYBOARD_LL = 0x000D;

        public const int WM_SETREDRAW  = 0x000B;
        public const int WM_KEYDOWN    = 0x0100;
        public const int WM_KEYUP      = 0x0101;
        public const int WM_SYSKEYDOWN = 0x0104;
        public const int WM_SYSKEYUP   = 0x0105;

        private static double Frequency;

        public delegate IntPtr Proc(int nCode, int wParam, IntPtr lParam);

        public static IntPtr SetHook(int id, Proc proc) {
            using(Process curProcess = Process.GetCurrentProcess()) {
                using(ProcessModule curModule = curProcess.MainModule) {
                    return SetWindowsHookEx(id, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        public static Keys GetAsyncKey(params Keys[] keys) {
            foreach(Keys key in keys) {
                if(GetAsyncKeyState(key) != 0) {
                    return key;
                }
            }

            return Keys.None;
        }

        public static void InitTiming() {
            long freq;
            QueryPerformanceFrequency(out freq);
            Frequency = freq / 1000.0;
        }

        public static double GetTime() {
            long timeStamp;
            QueryPerformanceCounter(out timeStamp);
            return timeStamp / Frequency;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, Proc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, int wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern short GetKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        public static extern bool SetDllDirectory(string lpPathName);

        [DllImport("kernel32.dll")]
        public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("kernel32.dll")]
        public static extern bool QueryPerformanceFrequency(out long lpFrequency);
    }
}
