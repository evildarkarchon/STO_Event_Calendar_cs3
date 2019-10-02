using System;
using System.Globalization;
using System.Resources;

namespace Keyboard
{
    class Key
    {
        private static CultureInfo GetEnUs()
        {
            return new CultureInfo("en-US");
        }
        private static ResourceManager GetResources()
        {
            return new ResourceManager("Strings", typeof(Key).Assembly);
        }

        public static string Ask(string message)
        {
            ResourceManager rm = GetResources();
            Console.Write(message);

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException(rm.GetString("KeyNotAnswered", GetEnUs())),
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
            // if (newline == default) { newline = false; }

            // if (newline == true) { Console.WriteLine(message); }
            // else { Console.Write(message); }
            ResourceManager rm = GetResources();
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
                null => throw new ArgumentException(rm.GetString("NotAnswered", GetEnUs())),
                _ => Output
            };
        }
        public static string Ask(string message, string exceptionmsg, bool newline)
        {
            // if (newline == true) { Console.WriteLine(message); }
            // else { Console.Write(message); }
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

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => Output
            };
        }

        public static object AskObj(string message)
        {
            ResourceManager rm = GetResources();
            Console.Write(message);

            object Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException(rm.GetString("NotAnswered", GetEnUs())),
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

            ResourceManager rm = GetResources();

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

            object Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException(rm.GetString("NotAnswered", GetEnUs())),
                _ => Output
            };
        }
        public static object AskObj(string message, string exceptionmsg, bool newline)
        {
            // if (newline == default) { newline = false; }

            // if (newline == true) { Console.WriteLine(message); }
            // else { Console.Write(message); }
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

            //if (string.IsNullOrEmpty(Output) || Output == default) { throw new ArgumentException(exceptionmsg); }

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => Output
            };
        }

        public static T Ask<T>(string message)
        {
            ResourceManager rm = GetResources();

            Console.Write(message);

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException(rm.GetString("NotAnswered", GetEnUs())),
                _ => (T)Convert.ChangeType(Output, typeof(T), GetEnUs())
            };
        }
        public static T Ask<T>(string message, string exceptionmsg)
        {
            Console.Write(message);

            var Output = Console.ReadLine();

            return Output switch
            {
                null => throw new ArgumentException(exceptionmsg),
                _ => (T)Convert.ChangeType(Output, typeof(T), GetEnUs()),
            };
        }
        public static T Ask<T>(string message, bool newline)
        {
            //if (newline == default) { newline = false; }

            //if (newline == true) { Console.WriteLine(message); }
            //else { Console.Write(message); }

            ResourceManager rm = GetResources();

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
                null => throw new ArgumentException(rm.GetString("NotAnswered", GetEnUs())),
                _ => (T)Convert.ChangeType(Output, typeof(T), GetEnUs()),
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
                _ => (T)Convert.ChangeType(Output, typeof(T), GetEnUs())
            };
        }
    }
}
