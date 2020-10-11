using System;

namespace CheckPangramText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPangram("we promptly judge antique ivory buckles for the next prize"));
        }

        public static string CheckPangram(string text)
        {
            try
            {
                int count = 0;
                var data = new string(text.Distinct().ToArray());
                foreach (var item in data)
                {
                    switch (item)
                    {
                        case 'a':
                            count = count + 1;
                            break;
                        case 'b':
                            count = count + 1;
                            break;
                        case 'c':
                            count = count + 1;
                            break;
                        case 'd':
                            count = count + 1;
                            break;
                        case 'e':
                            count = count + 1;
                            break;
                        case 'f':
                            count = count + 1;
                            break;
                        case 'g':
                            count = count + 1;
                            break;
                        case 'h':
                            count = count + 1;
                            break;
                        case 'i':
                            count = count + 1;
                            break;
                        case 'j':
                            count = count + 1;
                            break;
                        case 'k':
                            count = count + 1;
                            break;
                        case 'l':
                            count = count + 1;
                            break;
                        case 'm':
                            count = count + 1;
                            break;
                        case 'n':
                            count = count + 1;
                            break;
                        case 'o':
                            count = count + 1;
                            break;
                        case 'p':
                            count = count + 1;
                            break;
                        case 'q':
                            count = count + 1;
                            break;
                        case 'r':
                            count = count + 1;
                            break;
                        case 's':
                            count = count + 1;
                            break;
                        case 't':
                            count = count + 1;
                            break;
                        case 'u':
                            count = count + 1;
                            break;
                        case 'v':
                            count = count + 1;
                            break;
                        case 'w':
                            count = count + 1;
                            break;
                        case 'x':
                            count = count + 1;
                            break;
                        case 'y':
                            count = count + 1;
                            break;
                        case 'z':
                            count = count + 1;
                            break;
                        default:
                            break;
                    }
                }
                if (count == 26)
                    return "pangram";
                else
                    return "not pangram";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
