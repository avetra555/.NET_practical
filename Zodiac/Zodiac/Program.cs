using System;
using System.Text;
namespace Zodiac;

    class Program
    {
    static void Main(string[] args)
    {
        string dateofbirth;
        DateTime date = new DateTime();

        Console.WriteLine("Please write your birthday: MM/DD/YYYY");
        dateofbirth = Console.ReadLine();
        Console.WriteLine("\n");

        try
        {
            date = Convert.ToDateTime(dateofbirth);
        }
        catch
        {
            Console.WriteLine("Error: Please write date as given example - MM/DD/YYYY");

        }

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        switch (date.Month)
        {
            case 1:
                if (date.Day <= 20)
                {
                    char CAPRICORN = '\u2651';
                    Console.WriteLine("Your zodiac sign is CAPRICORN" + "  " + CAPRICORN); }
                else
                {
                    Console.WriteLine("Your zodiac sign is AQUARIUS" + " " + '\u2652');
                }
                break;

            case 2:
                if (date.Day <= 19)
                {
                    char AQUARIUS = '\u2652';
                    Console.WriteLine("Your zodiac sign is AQUARIUS" + "  " + AQUARIUS);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is PISCES" + "  " + '\u2653');
                }
                break;


            case 3:
                if (date.Day <= 19)
                {
                    char PISCES = '\u2653';
                    Console.WriteLine("Your zodiac sign is PISCES" + "  " + PISCES);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is ARIES" + "  " + '\u2648');
                }
                break;

            case 4:
                if (date.Day <= 20)
                {
                    char ARIES = '\u2648';
                    Console.WriteLine("Your zodiac sign is ARIES" + "  " + ARIES);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is TAURUS" + "  " + '\u2649');
                }
                break;


            case 5:
                if (date.Day <= 21)
                {
                    char TAURUS = '\u2649';
                    Console.WriteLine("Your zodiac sign is TAURUS" + "  " + TAURUS);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is GEMINI" + "  " + '\u264a');
                }
                break;


            case 6:
                if (date.Day <= 22)
                {
                    char GEMINI = '\u264A';
                    Console.WriteLine("Your zodiac sign is GEMINI" + "  " + GEMINI);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is CANCER" + "  " + '\u264b');
                }
                break;

            case 7:
                if (date.Day <= 22)
                {
                    char CANCER = '\u264b';
                    Console.WriteLine("Your zodiac sign is CANCER" + "  " + CANCER);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is LEO" + "  " + '\u264c');
                }
                break;

            case 8:
                if (date.Day <= 23)
                {
                    char LEO = '\u264c';
                    Console.WriteLine("Your zodiac sign is LEO" + "  " + LEO);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is VIRGO" + "  " + '\u264d');
                }
                break;

            case 9:
                if (date.Day <= 23)
                {
                    char VIRGO = '\u264d';
                    Console.WriteLine("Your zodiac sign is VIRGO" + "  " + VIRGO);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is LIBRA" + "  " + '\u264e');
                }
                break;

            case 10:
                if (date.Day <= 23)
                {
                    char LIBRA = '\u264d';
                    Console.WriteLine("Your zodiac sign is LIBRA" + "  " + LIBRA);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is SCORPIUS" + "  " + '\u264f');
                }
                break;

            case 11:
                if (date.Day <= 22)
                {
                    char SCORPIUS = '\u264F';
                    Console.WriteLine("Your zodiac sign is SCORPIUS" + "  " + SCORPIUS);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is SAGITTARIUS" + "  " + '\u2650');
                }
                break;


            case 12:
                if (date.Day <= 21)
                {
                    char SAGITTARIUS = '\u2650';
                    Console.WriteLine("Your zodiac sign is SAGITTARIUS" + "  " + SAGITTARIUS);
                }
                else
                {
                    Console.WriteLine("Your zodiac sign is CAPRICORN" + "  " + '\u2652');
                }
                break;

            default:
                Console.WriteLine("Please try again!");
                break;


        }
        }
    }
