#region ?????? System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.1\System.Windows.Forms.dll
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System.Runtime.InteropServices;

namespace InApp
{
    //
    // ??????:
    //     ?????? ???? ? ???????????? ??????.
    [ComVisible(true)]
    public enum Keys
    {
        //
        // ??????:
        //     ??????? ????? ??? ?????????? ???? ??????? ?? ???????? ???????.
        KeyCode = 0xFFFF,
        //
        // ??????:
        //     ??????? ????? ??? ?????????? ????????????? ?? ???????? ???????.
        Modifiers = -65536,
        //
        // ??????:
        //     ??? ??????? ??????.
        None = 0x0,
        //
        // ??????:
        //     ????? ?????? ????.
        LButton = 0x1,
        //
        // ??????:
        //     ?????? ?????? ????.
        RButton = 0x2,
        //
        // ??????:
        //     ??????? ??????.
        Cancel = 0x3,
        //
        // ??????:
        //     ??????? ?????? ???? (????????????? ????).
        MButton = 0x4,
        //
        // ??????:
        //     ?????? ?????? ???? (????????????? ????).
        XButton1 = 0x5,
        //
        // ??????:
        //     ?????? ?????? ???? (????????????? ????).
        XButton2 = 0x6,
        //
        // ??????:
        //     ??????? BACKSPACE.
        Back = 0x8,
        //
        // ??????:
        //     ??????? TAB.
        Tab = 0x9,
        //
        // ??????:
        //     ??????? LINEFEED.
        LineFeed = 0xA,
        //
        // ??????:
        //     ??????? CLEAR.
        Clear = 0xC,
        //
        // ??????:
        //     ??????? RETURN.
        Return = 0xD,
        //
        // ??????:
        //     ??????? ????.
        Enter = 0xD,
        //
        // ??????:
        //     ??????? SHIFT.
        ShiftKey = 0x10,
        //
        // ??????:
        //     ??????? CTRL.
        ControlKey = 0x11,
        //
        // ??????:
        //     ??????? ALT.
        Menu = 0x12,
        //
        // ??????:
        //     ??????? PAUSE.
        Pause = 0x13,
        //
        // ??????:
        //     ??????? CAPS LOCK.
        Capital = 0x14,
        //
        // ??????:
        //     ??????? CAPS LOCK.
        CapsLock = 0x14,
        //
        // ??????:
        //     ??????? ?????? "????" ????????? ?????? ?????.
        KanaMode = 0x15,
        //
        // ??????:
        //     ??????? ?????? IME Hanguel (?????????????? ??? ??????????? ?????????????; ???????????
        //     ??????? HangulMode).
        HanguelMode = 0x15,
        //
        // ??????:
        //     ??????? ?????? "???????" ????????? ?????? ?????.
        HangulMode = 0x15,
        //
        // ??????:
        //     ??????? ?????? "???????" ????????? ?????? ?????.
        JunjaMode = 0x17,
        //
        // ??????:
        //     ??????? ?????????????? ?????? IME.
        FinalMode = 0x18,
        //
        // ??????:
        //     ??????? ?????? "??????" ????????? ?????? ?????.
        HanjaMode = 0x19,
        //
        // ??????:
        //     ??????? ?????? "??????" ????????? ?????? ?????.
        KanjiMode = 0x19,
        //
        // ??????:
        //     ??????? ESC.
        Escape = 0x1B,
        //
        // ??????:
        //     ??????? ?????????????? IME.
        IMEConvert = 0x1C,
        //
        // ??????:
        //     ??????? ??? ?????????????? IME.
        IMENonconvert = 0x1D,
        //
        // ??????:
        //     ??????? ???????? IME, ???????? ??????? System.Windows.Forms.Keys.IMEAceept.
        IMEAccept = 0x1E,
        //
        // ??????:
        //     ??????? ???????? IME. ???????? ??????????, ?????? ??? ???????????? ??????? System.Windows.Forms.Keys.IMEAccept.
        IMEAceept = 0x1E,
        //
        // ??????:
        //     ??????? ????????? ?????? IME.
        IMEModeChange = 0x1F,
        //
        // ??????:
        //     ??????? ??????.
        Space = 0x20,
        //
        // ??????:
        //     ??????? PAGE UP.
        Prior = 0x21,
        //
        // ??????:
        //     ??????? PAGE UP.
        PageUp = 0x21,
        //
        // ??????:
        //     ??????? PAGE DOWN.
        Next = 0x22,
        //
        // ??????:
        //     ??????? PAGE DOWN.
        PageDown = 0x22,
        //
        // ??????:
        //     ??????? END.
        End = 0x23,
        //
        // ??????:
        //     ??????? HOME.
        Home = 0x24,
        //
        // ??????:
        //     ??????? ??????? ?????.
        Left = 0x25,
        //
        // ??????:
        //     ??????? ??????? ?????.
        Up = 0x26,
        //
        // ??????:
        //     ??????? ??????? ??????.
        Right = 0x27,
        //
        // ??????:
        //     ??????? ??????? ????.
        Down = 0x28,
        //
        // ??????:
        //     ??????? SELECT.
        Select = 0x29,
        //
        // ??????:
        //     ??????? PRINT.
        Print = 0x2A,
        //
        // ??????:
        //     ??????? EXECUTE.
        Execute = 0x2B,
        //
        // ??????:
        //     ??????? PRINT SCREEN.
        Snapshot = 0x2C,
        //
        // ??????:
        //     ??????? PRINT SCREEN.
        PrintScreen = 0x2C,
        //
        // ??????:
        //     ??????? INS.
        Insert = 0x2D,
        //
        // ??????:
        //     ??????? DEL.
        Delete = 0x2E,
        //
        // ??????:
        //     ??????? HELP.
        Help = 0x2F,
        //
        // ??????:
        //     ??????? 0.
        D0 = 0x30,
        //
        // ??????:
        //     ??????? 1.
        D1 = 0x31,
        //
        // ??????:
        //     ??????? 2.
        D2 = 0x32,
        //
        // ??????:
        //     ??????? 3.
        D3 = 0x33,
        //
        // ??????:
        //     ??????? 4.
        D4 = 0x34,
        //
        // ??????:
        //     ??????? 5.
        D5 = 0x35,
        //
        // ??????:
        //     ??????? 6.
        D6 = 0x36,
        //
        // ??????:
        //     ??????? 7.
        D7 = 0x37,
        //
        // ??????:
        //     ??????? 8.
        D8 = 0x38,
        //
        // ??????:
        //     ??????? 9.
        D9 = 0x39,
        //
        // ??????:
        //     ??????? A.
        A = 0x41,
        //
        // ??????:
        //     ??????? B.
        B = 0x42,
        //
        // ??????:
        //     ??????? C.
        C = 0x43,
        //
        // ??????:
        //     ??????? D.
        D = 0x44,
        //
        // ??????:
        //     ??????? E.
        E = 0x45,
        //
        // ??????:
        //     ??????? F.
        F = 0x46,
        //
        // ??????:
        //     ??????? G.
        G = 0x47,
        //
        // ??????:
        //     ??????? H.
        H = 0x48,
        //
        // ??????:
        //     ??????? I.
        I = 0x49,
        //
        // ??????:
        //     ??????? J.
        J = 0x4A,
        //
        // ??????:
        //     ??????? K.
        K = 0x4B,
        //
        // ??????:
        //     ??????? L.
        L = 0x4C,
        //
        // ??????:
        //     ??????? M.
        M = 0x4D,
        //
        // ??????:
        //     ??????? N.
        N = 0x4E,
        //
        // ??????:
        //     ??????? O.
        O = 0x4F,
        //
        // ??????:
        //     ??????? P.
        P = 0x50,
        //
        // ??????:
        //     ??????? Q.
        Q = 0x51,
        //
        // ??????:
        //     ??????? R.
        R = 0x52,
        //
        // ??????:
        //     ??????? S.
        S = 0x53,
        //
        // ??????:
        //     ??????? T.
        T = 0x54,
        //
        // ??????:
        //     ??????? U.
        U = 0x55,
        //
        // ??????:
        //     ??????? V.
        V = 0x56,
        //
        // ??????:
        //     ??????? W.
        W = 0x57,
        //
        // ??????:
        //     ??????? X.
        X = 0x58,
        //
        // ??????:
        //     ??????? Y.
        Y = 0x59,
        //
        // ??????:
        //     ??????? Z.
        Z = 0x5A,
        //
        // ??????:
        //     ????? ??????? ? ????????? Windows (?????????? Microsoft Natural Keyboard).
        LWin = 0x5B,
        //
        // ??????:
        //     ?????? ??????? ? ????????? Windows (?????????? Microsoft Natural Keyboard).
        RWin = 0x5C,
        //
        // ??????:
        //     ??????? ???????????? ???? (?????????? Microsoft Natural).
        Apps = 0x5D,
        //
        // ??????:
        //     ??????? ???????? ?????????? ? ?????? ?????.
        Sleep = 0x5F,
        //
        // ??????:
        //     ??????? 0 ?? ???????? ??????????.
        NumPad0 = 0x60,
        //
        // ??????:
        //     ??????? 1 ?? ???????? ??????????.
        NumPad1 = 0x61,
        //
        // ??????:
        //     ??????? 2 ?? ???????? ??????????.
        NumPad2 = 0x62,
        //
        // ??????:
        //     ??????? 3 ?? ???????? ??????????.
        NumPad3 = 0x63,
        //
        // ??????:
        //     ??????? 4 ?? ???????? ??????????.
        NumPad4 = 0x64,
        //
        // ??????:
        //     ??????? 5 ?? ???????? ??????????.
        NumPad5 = 0x65,
        //
        // ??????:
        //     ??????? 6 ?? ???????? ??????????.
        NumPad6 = 0x66,
        //
        // ??????:
        //     ??????? 7 ?? ???????? ??????????.
        NumPad7 = 0x67,
        //
        // ??????:
        //     ??????? 8 ?? ???????? ??????????.
        NumPad8 = 0x68,
        //
        // ??????:
        //     ??????? 9 ?? ???????? ??????????.
        NumPad9 = 0x69,
        //
        // ??????:
        //     ??????? ?????????.
        Multiply = 0x6A,
        //
        // ??????:
        //     ??????? ????????.
        Add = 0x6B,
        //
        // ??????:
        //     ??????? ???????????.
        Separator = 0x6C,
        //
        // ??????:
        //     ??????? ?????????.
        Subtract = 0x6D,
        //
        // ??????:
        //     ??????? ??????????? ???????????.
        Decimal = 0x6E,
        //
        // ??????:
        //     ??????? ???????.
        Divide = 0x6F,
        //
        // ??????:
        //     ??????? F1.
        F1 = 0x70,
        //
        // ??????:
        //     ??????? F2.
        F2 = 0x71,
        //
        // ??????:
        //     ??????? F3.
        F3 = 0x72,
        //
        // ??????:
        //     ??????? F4.
        F4 = 0x73,
        //
        // ??????:
        //     ??????? F5.
        F5 = 0x74,
        //
        // ??????:
        //     ??????? F6.
        F6 = 0x75,
        //
        // ??????:
        //     ??????? F7.
        F7 = 0x76,
        //
        // ??????:
        //     ??????? F8.
        F8 = 0x77,
        //
        // ??????:
        //     ??????? F9.
        F9 = 0x78,
        //
        // ??????:
        //     ??????? F10.
        F10 = 0x79,
        //
        // ??????:
        //     ??????? F11.
        F11 = 0x7A,
        //
        // ??????:
        //     ??????? F12.
        F12 = 0x7B,
        //
        // ??????:
        //     ??????? F13.
        F13 = 0x7C,
        //
        // ??????:
        //     ??????? F14.
        F14 = 0x7D,
        //
        // ??????:
        //     ??????? F15.
        F15 = 0x7E,
        //
        // ??????:
        //     ??????? F16.
        F16 = 0x7F,
        //
        // ??????:
        //     ??????? F17.
        F17 = 0x80,
        //
        // ??????:
        //     ??????? F18.
        F18 = 0x81,
        //
        // ??????:
        //     ??????? F19.
        F19 = 0x82,
        //
        // ??????:
        //     ??????? F20.
        F20 = 0x83,
        //
        // ??????:
        //     ??????? F21.
        F21 = 0x84,
        //
        // ??????:
        //     ??????? F22.
        F22 = 0x85,
        //
        // ??????:
        //     ??????? F23.
        F23 = 0x86,
        //
        // ??????:
        //     ??????? F24.
        F24 = 0x87,
        //
        // ??????:
        //     ??????? NUM LOCK.
        NumLock = 0x90,
        //
        // ??????:
        //     ??????? SCROLL LOCK.
        Scroll = 0x91,
        //
        // ??????:
        //     ????? ??????? SHIFT.
        LShiftKey = 0xA0,
        //
        // ??????:
        //     ?????? ??????? SHIFT.
        RShiftKey = 0xA1,
        //
        // ??????:
        //     ????? ??????? CTRL.
        LControlKey = 0xA2,
        //
        // ??????:
        //     ?????? ??????? CTRL.
        RControlKey = 0xA3,
        //
        // ??????:
        //     ????? ??????? ALT.
        LMenu = 0xA4,
        //
        // ??????:
        //     ?????? ??????? ALT.
        RMenu = 0xA5,
        //
        // ??????:
        //     ??????? ???????? ????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserBack = 0xA6,
        //
        // ??????:
        //     ??????? ???????? ?????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserForward = 0xA7,
        //
        // ??????:
        //     ??????? ?????????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserRefresh = 0xA8,
        //
        // ??????:
        //     ??????? ????????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserStop = 0xA9,
        //
        // ??????:
        //     ??????? ?????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserSearch = 0xAA,
        //
        // ??????:
        //     ??????? ?????????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserFavorites = 0xAB,
        //
        // ??????:
        //     ??????? ???????? ???????? ? ???????? (Windows 2000 ??? ????? ??????? ??????).
        BrowserHome = 0xAC,
        //
        // ??????:
        //     ??????? ?????????? ????? (Windows 2000 ??? ????? ??????? ??????).
        VolumeMute = 0xAD,
        //
        // ??????:
        //     ??????? ?????????? ????????? (Windows 2000 ??? ????? ??????? ??????).
        VolumeDown = 0xAE,
        //
        // ??????:
        //     ??????? ?????????? ????????? (Windows 2000 ??? ????? ??????? ??????).
        VolumeUp = 0xAF,
        //
        // ??????:
        //     ??????? ???????? ?? ????????? ?????? (Windows 2000 ??? ????? ??????? ??????).
        MediaNextTrack = 0xB0,
        //
        // ??????:
        //     ??????? ???????? ?? ?????????? ?????? (Windows 2000 ??? ????? ??????? ??????).
        MediaPreviousTrack = 0xB1,
        //
        // ??????:
        //     ??????? ????????? ??????????????? (Windows 2000 ??? ????? ??????? ??????).
        MediaStop = 0xB2,
        //
        // ??????:
        //     ??????? ???????????? ??????????????? (Windows 2000 ??? ????? ??????? ??????).
        MediaPlayPause = 0xB3,
        //
        // ??????:
        //     ??????? ??????? ????? (Windows 2000 ??? ????? ??????? ??????).
        LaunchMail = 0xB4,
        //
        // ??????:
        //     ??????? ?????? ?????? (Windows 2000 ??? ????? ??????? ??????).
        SelectMedia = 0xB5,
        //
        // ??????:
        //     ??????? ??????? ?????????? ???? (Windows 2000 ??? ????? ??????? ??????).
        LaunchApplication1 = 0xB6,
        //
        // ??????:
        //     ??????? ??????? ?????????? ??? (Windows 2000 ??? ????? ??????? ??????).
        LaunchApplication2 = 0xB7,
        //
        // ??????:
        //     ??????? OEM ? ?????? ? ??????? ?? ??????????? ?????????? ??? (Windows 2000 ???
        //     ????? ??????? ??????).
        OemSemicolon = 0xBA,
        //
        // ??????:
        //     ??????? OEM 1.
        Oem1 = 0xBA,
        //
        // ??????:
        //     ??????? OEM ?? ?????? ????? ?? ?????????? ????? ?????? ??? ??????? (Windows 2000
        //     ??? ????? ??????? ??????).
        Oemplus = 0xBB,
        //
        // ??????:
        //     ??????? OEM ? ??????? ?? ?????????? ????? ?????? ??? ??????? (Windows 2000 ???
        //     ????? ??????? ??????).
        Oemcomma = 0xBC,
        //
        // ??????:
        //     ??????? OEM ?? ?????? ?????? ?? ?????????? ????? ?????? ??? ??????? (Windows
        //     2000 ??? ????? ??????? ??????).
        OemMinus = 0xBD,
        //
        // ??????:
        //     ??????? OEM ? ?????? ?? ?????????? ????? ?????? ??? ??????? (Windows 2000 ???
        //     ????? ??????? ??????).
        OemPeriod = 0xBE,
        //
        // ??????:
        //     ??????? OEM ? ?????????????? ?????? ?? ??????????? ?????????? ??? (Windows 2000
        //     ??? ????? ??????? ??????).
        OemQuestion = 0xBF,
        //
        // ??????:
        //     ??????? OEM 2.
        Oem2 = 0xBF,
        //
        // ??????:
        //     ??????? OEM ?? ?????? ?????? ?? ??????????? ?????????? ??? (Windows 2000 ???
        //     ????? ??????? ??????).
        Oemtilde = 0xC0,
        //
        // ??????:
        //     ??????? OEM 3.
        Oem3 = 0xC0,
        //
        // ??????:
        //     ??????? OEM ? ??????????? ?????????? ??????? ?? ??????????? ?????????? ??? (Windows
        //     2000 ??? ????? ??????? ??????).
        OemOpenBrackets = 0xDB,
        //
        // ??????:
        //     ??????? OEM 4.
        Oem4 = 0xDB,
        //
        // ??????:
        //     ??????? OEM ? ???????????? ?????? ?? ??????????? ?????????? ??? (Windows 2000
        //     ??? ????? ??????? ??????).
        OemPipe = 0xDC,
        //
        // ??????:
        //     ??????? OEM 5.
        Oem5 = 0xDC,
        //
        // ??????:
        //     ??????? OEM ? ??????????? ?????????? ??????? ?? ??????????? ?????????? ??? (Windows
        //     2000 ??? ????? ??????? ??????).
        OemCloseBrackets = 0xDD,
        //
        // ??????:
        //     ??????? OEM 6.
        Oem6 = 0xDD,
        //
        // ??????:
        //     ??????? OEM ? ?????????/??????? ???????? ?? ??????????? ?????????? ??? (Windows
        //     2000 ??? ????? ??????? ??????).
        OemQuotes = 0xDE,
        //
        // ??????:
        //     ??????? OEM 7.
        Oem7 = 0xDE,
        //
        // ??????:
        //     ??????? OEM 8.
        Oem8 = 0xDF,
        //
        // ??????:
        //     ??????? OEM ? ??????? ??????? ??? ???????? ????? ?????? ?? ?????????? RT ?? 102
        //     ????????? (Windows 2000 ??? ????? ??????? ??????).
        OemBackslash = 0xE2,
        //
        // ??????:
        //     ??????? OEM 102.
        Oem102 = 0xE2,
        //
        // ??????:
        //     ??????? PROCESS KEY.
        ProcessKey = 0xE5,
        //
        // ??????:
        //     ???????????? ??? ???????? ???????? ? ??????? ? ???? ??????? ??????. ????????
        //     ??????? ?????? ???????? ??????? ?????? 32-?????????? ???????????? ???????? ???????,
        //     ????????????? ??? ??????????????? ??????? ?????.
        Packet = 0xE7,
        //
        // ??????:
        //     ??????? ATTN.
        Attn = 0xF6,
        //
        // ??????:
        //     ??????? CRSEL.
        Crsel = 0xF7,
        //
        // ??????:
        //     ??????? EXSEL.
        Exsel = 0xF8,
        //
        // ??????:
        //     ??????? ERASE EOF.
        EraseEof = 0xF9,
        //
        // ??????:
        //     ??????? PLAY.
        Play = 0xFA,
        //
        // ??????:
        //     ??????? ZOOM.
        Zoom = 0xFB,
        //
        // ??????:
        //     ?????????, ????????????????? ??? ????????????? ? ???????.
        NoName = 0xFC,
        //
        // ??????:
        //     ??????? PA1.
        Pa1 = 0xFD,
        //
        // ??????:
        //     ??????? CLEAR.
        OemClear = 0xFE,
        //
        // ??????:
        //     ??????? SHIFT.
        Shift = 0x10000,
        //
        // ??????:
        //     ??????? CTRL.
        Control = 0x20000,
        //
        // ??????:
        //     ??????? ALT.
        Alt = 0x40000
    }
}
#if false // ?????? ????????????
????????? ? ????: "259"
------------------
?????????: "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
??????? ???? ??????: "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
????????? ??: "C:\Program Files\Unity\Hub\Editor\2022.2.1f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\mscorlib.dll"
------------------
?????????: "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
??????? ???? ??????: "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
????????? ??: "C:\Program Files\Unity\Hub\Editor\2022.2.1f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Drawing.dll"
------------------
?????????: "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
??????? ???? ??????: "System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
????????? ??: "C:\Program Files\Unity\Hub\Editor\2022.2.1f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Xml.dll"
------------------
?????????: "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
??????? ???? ??????: "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
????????? ??: "C:\Program Files\Unity\Hub\Editor\2022.2.1f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.dll"
------------------
?????????: "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
??????? ???? ??????: "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
????????? ??: "C:\Program Files\Unity\Hub\Editor\2022.2.1f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Core.dll"
------------------
?????????: "System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "Microsoft.Win32.Registry, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "Microsoft.Win32.Registry, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"
??????? ???? ??????: "netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"
????????? ??: "C:\Program Files\Unity\Hub\Editor\2022.2.1f1\Editor\Data\NetStandard\ref\2.1.0\netstandard.dll"
------------------
?????????: "System.Security.Principal.Windows, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "System.Security.Principal.Windows, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "System.Security.AccessControl, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
?? ??????? ????? ?? ?????: "System.Security.AccessControl, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
------------------
?????????: "System.CodeDom, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"
?? ??????? ????? ?? ?????: "System.CodeDom, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"
#endif
