using System;

namespace Keyboard
{
    class Key
    {
        public static string Ask(string message)
        {
            Console.Write(message);

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException("The question was not answered."),
                _ => Output
            };
        }
        public static string Ask(string message, string exceptionmsg)
        {
            Console.Write(message);

            var Output = Console.ReadLine();

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => Output
            };
        }
        public static string Ask(string message, bool newline)
        {
            if (newline == default) { newline = false; }

            if (newline == true) { Console.WriteLine(message); }
            else { Console.Write(message); }

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException("The question was not answered."),
                _ => Output
            };
        }
        public static string Ask(string message, string exceptionmsg, bool newline)
        {
            if (newline == true) { Console.WriteLine(message); }
            else { Console.Write(message); }

            var Output = Console.ReadLine();

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => Output
            };
        }

        public static object AskObj(string message)
        {
            Console.Write(message);

            object Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException("The question was not answered."),
                _ => Output
            };
        }
        public static object AskObj(string message, string exceptionmsg)
        {
            Console.Write(message);

            string Output = Console.ReadLine();

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }

            return Output switch
            {
            null => throw new ArgumentException(exceptionmsg),
            _ => Output
            };
        }
        public static object AskObj(string message, bool newline)
        {
            //if (newline == default) { newline = false; }

            //if (newline == true) { Console.WriteLine(message); }
            //else { Console.Write(message); }

            switch(newline)
            {
                case true:
                    Console.WriteLine(message);
                    break;
                case false:
                default:
                    Console.Write(message);
                    break;
            }

            object Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException("The question was not answered."),
                _ => Output
            };
        }
        public static object AskObj(string message, string exceptionmsg, bool newline)
        {
            if (newline == default) { newline = false; }

            if (newline == true) { Console.WriteLine(message); }
            else { Console.Write(message); }

            var Output = Console.ReadLine();

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => Output
            };
        }

        public static T Ask<T>(string message)
        {
            Console.Write(message);

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException("The question was not answered."),
                _ => (T)Convert.ChangeType(Output, typeof(T))
            };
        }
        public static T Ask<T>(string message, string exceptionmsg)
        {
            Console.Write(message);

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => (T)Convert.ChangeType(Output, typeof(T)),
            };
        }
        public static T Ask<T>(string message, bool newline)
        {
            //if (newline == default) { newline = false; }

            //if (newline == true) { Console.WriteLine(message); }
            //else { Console.Write(message); }

            switch (newline)
            {
                case true:
                    Console.WriteLine(message);
                    break;
                case false:
                default:
                    Console.Write(message);
                    break;
            }

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException("The question was not answered."),
                _ => (T)Convert.ChangeType(Output, typeof(T)),
            };
        }
        public static T Ask<T>(string message, string exceptionmsg, bool newline)
        {
            switch(newline)
            {
                case true:
                    Console.WriteLine(message);
                    break;
                case false:
                default:
                    Console.Write(message);
                    break;
            }

            var Output = Console.ReadLine();

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }
            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => (T)Convert.ChangeType(Output, typeof(T)),
            };
        }
    }
}
