using System;
using System.IO;
using System.Text;

namespace 한글
{
    public static class 출력창
    {
        #region 속성

        public static bool 입력이리디렉션됨 => Console.IsInputRedirected;
        public static int 버퍼높이 { get { return Console.BufferHeight; } set { Console.BufferHeight = value; } }
        public static int 버퍼가로 { get { return Console.BufferWidth; } set { Console.BufferWidth = value; } }
        public static bool 캡스잠금 => Console.CapsLock;
        public static int 이동막대왼쪽 { get { return Console.CursorLeft; } set { Console.CursorLeft = value; } }
        public static int 이동막대크기 { get { return Console.CursorSize; } set { Console.CursorSize = value; } }
        public static int 이동막대위 { get { return Console.CursorTop; } set { Console.CursorTop = value; } }
        public static bool 이동막대보임 { get { return Console.CursorVisible; } set { Console.CursorVisible = value; } }
        public static TextWriter 에러 => Console.Error;
        public static ConsoleColor 전경색 { get { return Console.ForegroundColor; } set { Console.ForegroundColor = value; } }
        public static TextReader 안 => Console.In;
        public static Encoding 입력부호화 { get { return Console.InputEncoding; } set { Console.InputEncoding = value; } }
        public static bool 에러가리디렉션됨 => Console.IsErrorRedirected;
        public static int 창가로 { get { return Console.WindowWidth; } set { Console.WindowWidth = value; } }
        public static bool 출력이리디렉션됨 => Console.IsOutputRedirected;
        public static bool 누름자판사용 => Console.KeyAvailable;
        public static int 가장큰창높이 => Console.LargestWindowHeight;
        public static int 가장큰창가로 => Console.LargestWindowWidth;
        public static bool 숫자잠금 => Console.NumberLock;
        public static TextWriter 밖 => Console.Out;
        public static Encoding 출력부호화 { get { return Console.OutputEncoding; } set { Console.OutputEncoding = value; } }
        public static string 제목 { get { return Console.Title; } set { Console.Title = value; } }
        public static bool 컨트롤씨를입력으로처리 { get { return Console.TreatControlCAsInput; } set { Console.TreatControlCAsInput = value; } }
        public static int 창높이 { get { return Console.WindowHeight; } set { Console.WindowHeight = value; } }
        public static int 창왼쪽 { get { return Console.WindowLeft; } set { Console.WindowLeft = value; } }
        public static int 창위 { get { return Console.WindowTop; } set { Console.WindowTop = value; } }
        public static ConsoleColor 배경색 { get { return Console.BackgroundColor; } set { Console.BackgroundColor = value; } }

        #endregion

        #region 이벤트

        public static event ConsoleCancelEventHandler CancelKeyPress;

        #endregion

        #region 기능

        public static void 삑소리() => Console.Beep();
        public static void 삑소리(int frequency, int duration) => Console.Beep(frequency, duration);
        public static void 치우기() => Console.Clear();
        public static void 버퍼공간이동(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) => Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
        public static void 버퍼공간이동(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor) => Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
        public static Stream 표준에러열기(int bufferSize) => Console.OpenStandardError(bufferSize);
        public static Stream 표준에러열기() => Console.OpenStandardError();
        public static Stream 표준입력열기(int bufferSize) => Console.OpenStandardInput(bufferSize);
        public static Stream 표준입력열기() => Console.OpenStandardInput();
        public static Stream 표준출력열기(int bufferSize) => Console.OpenStandardOutput(bufferSize);
        public static Stream 표준출력열기() => Console.OpenStandardOutput();
        public static int 읽기() => Console.Read();
        public static ConsoleKeyInfo 누름자판읽기(bool intercept) => Console.ReadKey(intercept);
        public static ConsoleKeyInfo 누름자판읽기() => Console.ReadKey();
        public static string 줄읽기() => Console.ReadLine();
        public static void 색초기화() => Console.ResetColor();
        public static void 버퍼크기설정(int width, int height) => Console.SetBufferSize(width, height);
        public static void 이동막대위치설정(int left, int top) => Console.SetCursorPosition(left, top);
        public static void 에러설정(TextWriter newError) => Console.SetError(newError);
        public static void 입력설정(TextReader newIn) => Console.SetIn(newIn);
        public static void 출력설정(TextWriter newOut) => Console.SetOut(newOut);
        public static void 창위치설정(int left, int top) => Console.SetWindowPosition(left, top);
        public static void 창크기설정(int width, int height) => Console.SetWindowSize(width, height);

        #region 출력

        [CLSCompliant(false)]
        public static void 출력(ulong value) => Console.Write(value);
        public static void 출력(bool value) => Console.Write(value);
        public static void 출력(char value) => Console.Write(value);
        public static void 출력(char[] buffer) => Console.Write(buffer);
        public static void 출력(char[] buffer, int index, int count) => Console.Write(buffer, index, count);
        public static void 출력(double value) => Console.Write(value);
        public static void 출력(long value) => Console.Write(value);
        public static void 출력(object value) => Console.Write(value);
        public static void 출력(float value) => Console.Write(value);
        public static void 출력(string value) => Console.Write(value);
        public static void 출력(string format, object arg0) => Console.Write(format, arg0);
        public static void 출력(string format, object arg0, object arg1) => Console.Write(format, arg0, arg1);
        public static void 출력(string format, object arg0, object arg1, object arg2) => Console.Write(format, arg0, arg1, arg2);
        public static void 출력(string format, params object[] arg) => Console.Write(format, arg);
        [CLSCompliant(false)]
        public static void 출력(uint value) => Console.Write(value);
        public static void 출력(decimal value) => Console.Write(value);
        public static void 출력(int value) => Console.Write(value);

        #endregion

        #region 출력줄

        [CLSCompliant(false)]
        public static void 출력줄(ulong value) => Console.WriteLine(value);
        public static void 출력줄(string format, params object[] arg) => Console.WriteLine(format, arg);
        public static void 출력줄() => Console.WriteLine();
        public static void 출력줄(bool value) => Console.WriteLine(value);
        public static void 출력줄(char[] buffer) => Console.WriteLine(buffer);
        public static void 출력줄(char[] buffer, int index, int count) => Console.WriteLine(buffer, index, count);
        public static void 출력줄(decimal value) => Console.WriteLine(value);
        public static void 출력줄(double value) => Console.WriteLine(value);
        [CLSCompliant(false)]
        public static void 출력줄(uint value) => Console.WriteLine(value);
        public static void 출력줄(int value) => Console.WriteLine(value);
        public static void 출력줄(object value) => Console.WriteLine(value);
        public static void 출력줄(float value) => Console.WriteLine(value);
        public static void 출력줄(string value) => Console.WriteLine(value);
        public static void 출력줄(string format, object arg0) => Console.WriteLine(format, arg0);
        public static void 출력줄(string format, object arg0, object arg1) => Console.WriteLine(format, arg0, arg1);
        public static void 출력줄(string format, object arg0, object arg1, object arg2) => Console.WriteLine(format, arg0, arg1, arg2);
        public static void 출력줄(long value) => Console.WriteLine(value);
        public static void 출력줄(char value) => Console.WriteLine(value);

        #endregion

        #endregion
    }
}
