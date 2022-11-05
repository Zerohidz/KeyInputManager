using System.Runtime.InteropServices;

namespace KeyInputManager
{
    /// <summary>
    /// Use these
    /// </summary>
    public static class KeyInputManager
    {
        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(Int32 i);

        
        private static Dictionary<KeyCode, int> keyCodeStates = Enum.GetValues(typeof(KeyCode)).Cast<KeyCode>().ToDictionary(k => k, k => 0);

        /// <summary>
        /// Use this inside a while like loop!<br/><br/>Don't use double &amp;&amp; operator between two calls to combine keys,<br/>use single &amp; for it to get updated the right way!!
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns>True if the key is pressed</returns>
        public static bool GetKey(KeyCode keyCode)
        {
            int keyState = GetAsyncKeyState((int)keyCode);
            SaveKeyCodeState(keyCode, keyState);
            
            return keyCodeStates[keyCode] > 0;
        }

        /// <summary>
        /// Use this inside a while like loop!<br/><br/>Don't use double &amp;&amp; operator between two calls to combine keys,<br/>use single &amp; for it to get updated the right way!!
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns>True if the key just started being pressed</returns>
        public static bool GetKeyDown(KeyCode keyCode)
        {
            int keyState = GetAsyncKeyState((int)keyCode);
            bool keyDown = keyState > 0 && keyCodeStates[keyCode] == 0;
            SaveKeyCodeState(keyCode, keyState);

            return keyDown;
        }

        /// <summary>
        /// Use this inside a while like loop!<br/><br/>Don't use double &amp;&amp; operator between two calls to combine keys,<br/>use single &amp; for it to get updated the right way!!
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns>True if the key just ended being pressed</returns>
        public static bool GetKeyUp(KeyCode keyCode)
        {
            int keyState = GetAsyncKeyState((int)keyCode);
            bool keyUp = keyState == 0 && keyCodeStates[keyCode] > 0;
            SaveKeyCodeState(keyCode, keyState);

            return keyUp;
        }

        private static void SaveKeyCodeState(KeyCode keyCode, int state)
        {
            keyCodeStates[keyCode] = state;
        }
    }

    public enum KeyCode
    {
        Mouse_Left = 1,
        Mouse_Right = 2,
        Mouse_Middle = 4,
        Backspace = 8,
        TAB = 9,
        Enter = 13,
        Pause = 19,
        CapsLock = 20,
        Esc = 27,
        Space = 32,
        PageUp = 33,
        PageDown = 34,
        End = 35,
        Home = 36,
        Left = 37,
        Up = 38,
        Right = 39,
        Down = 40,
        PrintScreen = 44,
        Insert = 45,
        Delete = 46,
        Num0_Keyboard = 48,
        Num1_Keyboard = 49,
        Num2_Keyboard = 50,
        Num3_Keyboard = 51,
        Num4_Keyboard = 52,
        Num5_Keyboard = 53,
        Num6_Keyboard = 54,
        Num7_Keyboard = 55,
        Num8_Keyboard = 56,
        Num9_Keyboard = 57,
        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        z = 90,
        Windows = 91,
        _Windows = 92,
        List = 93,
        Num0_Numpad = 96,
        Num1_Numpad = 97,
        Num2_Numpad = 98,
        Num3_Numpad = 99,
        Num4_Numpad = 100,
        Num5_Numpad = 101,
        Num6_Numpad = 102,
        Num7_Numpad = 103,
        Num8_Numpad = 104,
        Num9_Numpad = 105,
        F1 = 112,
        F2 = 113,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        NumLock = 144,
        ScrollLock = 145,
        Shift_Left = 160,
        Shift_Right = 161,
        Ctrl_Left = 162,
        Ctrl_Right = 163,
        Alt = 164,
        AltGr = 165
    }
}
