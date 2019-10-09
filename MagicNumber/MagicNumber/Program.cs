using System;
using System.Collections.Generic;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_FROM = 100000;
            const int NUMBER_TO = 999999;

            GetMagicNumber(NUMBER_FROM, NUMBER_TO);

        }

        static void GetMagicNumber(int NUMBER_FROM, int NUMBER_TO)
        {
            int magicNumber = NUMBER_FROM;
            int magicNumberMultiplied2;
            int magicNumberMultiplied3;
            int magicNumberMultiplied4;
            int magicNumberMultiplied5;
            int magicNumberMultiplied6;

            for (int i = NUMBER_FROM; i < NUMBER_TO; i++)
            {
                magicNumber++;


                if (AreAllDigitsDifferent(IntToList(magicNumber)))
                {

                    magicNumberMultiplied2 = magicNumber * 2;

                    if (IsMultipliedNumberProper(magicNumber, magicNumberMultiplied2))
                    {

                        magicNumberMultiplied3 = magicNumber * 3;

                        if (IsMultipliedNumberProper(magicNumber, magicNumberMultiplied3))
                        {
                            magicNumberMultiplied4 = magicNumber * 4;

                            if (IsMultipliedNumberProper(magicNumber, magicNumberMultiplied4))
                            {

                                magicNumberMultiplied5 = magicNumber * 5;

                                if (IsMultipliedNumberProper(magicNumber, magicNumberMultiplied5))
                                {
                                    magicNumberMultiplied6 = magicNumber * 6;

                                    if (IsMultipliedNumberProper(magicNumber, magicNumberMultiplied6))
                                    {
                                        Console.WriteLine($"Magic number: {magicNumber}");
                                        Console.WriteLine($"Magic number multiplied 2 times: {magicNumberMultiplied2}");
                                        Console.WriteLine($"Magic number multiplied 3 times: {magicNumberMultiplied3}");
                                        Console.WriteLine($"Magic number multiplied 4 times: {magicNumberMultiplied4}");
                                        Console.WriteLine($"Magic number multiplied 5 times: {magicNumberMultiplied5}");
                                        Console.WriteLine($"Magic number multiplied 6 times: {magicNumberMultiplied6}");

                                        break;
                                    }
                                }
                            }

                        }
                    }

                }
                else
                {
                    continue;
                }

            }
        }

        static List<char> IntToList(int number)
        {
            List<char> listOfDigits = new List<char>();

            string numberAsText = number.ToString();
            int length = numberAsText.Length;


            for (int i = 0; i < length; i++)
            {
                char digit = numberAsText[i];
                listOfDigits.Add(numberAsText[i]);
            }
            return listOfDigits;
        }


        static void PrintList(List<char> listOfDigits)
        {
            for (int i = 0; i < listOfDigits.Count; i++)
            {
                Console.Write(listOfDigits[i] + " ");
            }
            Console.WriteLine();
        }


        static bool AreAllDigitsDifferent(List<char> listOfDigits)
        {

            for (int i = 0; i < listOfDigits.Count; i++)
            {
                for (int j = i + 1; j < listOfDigits.Count; j++)
                {
                    if (listOfDigits[i] == listOfDigits[j])

                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool AreElementsOfListsTheSameInDiffPlaces(List<char> listOfDigits1, List<char> listOfDigits2)
        {
            bool foundEqual = false;

            for (int i = 0; i < listOfDigits1.Count; i++)
            {
                for (int j = 0; j < listOfDigits2.Count; j++)
                {
                    if (listOfDigits1[i] == listOfDigits2[j])
                    {
                        foundEqual = true;
                        if (i != j)
                        {
                            break;
                        }
                        return false;
                    }
                }

                if (foundEqual)
                {
                    foundEqual = false;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsMultipliedNumberProper(int magicNumber, int multipliedNumber)
        {
            if (AreAllDigitsDifferent(IntToList(multipliedNumber)) && AreElementsOfListsTheSameInDiffPlaces(IntToList(magicNumber), IntToList(multipliedNumber)))
            {
                return true;
            }
            {
                return false;
            }
        }

    }
}
