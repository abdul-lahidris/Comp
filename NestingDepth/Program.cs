using System;

namespace NestingDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            string[] testAnswers = new string[testCase];


            for (int t = 1; t <= testCase; t++)
            {
                string binString = (Console.ReadLine());
                //string binString = Convert.ToString(inputString, 2);
                // Console.WriteLine(binString);
                string ParString = "";
                for (int i = 0; i < binString.Length; i++)
                {
                    if (binString[i].ToString() == "1" && i == 0)
                    {
                        ParString = ParString + "(" + binString[i];
                        if (binString.Length == 1)
                            ParString += ")";
                    }
                    else if (binString[i].ToString() == "1" && i != 0)
                    {
                        if (i == binString.Length - 1)
                        {
                            if (binString[i - 1].ToString() == "0")
                            {
                                ParString += "(";
                            }
                            ParString = ParString + binString[i] + ")";
                        }
                        else if (i < binString.Length - 1)
                        {
                            if (binString[i - 1].ToString() == "0")
                            {
                                ParString += "(";
                            }
                            if (binString[i + 1].ToString() == "1")
                            {
                                ParString += binString[i];
                            }
                            else if (binString[i + 1].ToString() == "0")
                            {
                                ParString = ParString + binString[i];
                            }
                        }

                    }
                    else
                    {
                        if (i == 0)
                        {
                            ParString += binString[i];
                        }
                        else
                        {
                            if (binString[i - 1].ToString() == "1")
                            {
                                ParString += ")";
                            }
                            ParString += binString[i];
                        }

                    }
                }
                testAnswers[t - 1] = string.Format("Case #{0}: {1}", t, ParString) ;
               
            }
            foreach (var item in testAnswers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
