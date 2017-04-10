using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int sum = 0;
            bool noMultOrDiv = true;
            bool noParens = true;
            int parenStart = 0;
            int parenEnd = 0;
            while (true)
            {
                Console.WriteLine("Input the values and how you want them added?");
                var InputVar = Console.ReadLine();
                List<String> InputList = InputVar.Split(' ').ToList();
                while (InputList.Count != 1)
                {

                    for (int parensCheck = 0; parensCheck < InputList.Count(); parensCheck++)
                    {
                        noParens = true;
                        if (InputList[parensCheck] == "(")
                        {
                            noParens = false;
                        }
                    }
                    if (noParens == false)
                    {
                        for (x = 0; x < InputList.Count(); x++)
                        {
                            if (InputList[x] == "(")
                            {

                                for (int z = 0; z < InputList.Count(); z++)
                                {
                                    if (InputList[z] == ")")
                                    {
                                        parenEnd = z;
                                        for (int y = z; y >= 0; y--)
                                        {
                                            if (InputList[y] == "(")
                                            {
                                                parenStart = y;
                                                if (y + 2 == z)
                                                {
                                                    InputList.Remove(InputList[y]);
                                                    InputList.Remove(InputList[y + 1]);
                                                    break;

                                                }
                                            }

                                            noMultOrDiv = true;
                                            for (int n = 0; n < InputList.Count(); n++)
                                            {
                                                if (noMultOrDiv == false)
                                                {
                                                    break;
                                                }
                                                else if (InputList[n] == "x")
                                                {
                                                    noMultOrDiv = false;
                                                }
                                                else if (InputList[n] == "/")
                                                {
                                                    noMultOrDiv = false;
                                                }
                                            }
                                            for (int p = 0; p < InputList.Count(); p++)
                                            {
                                                if (noMultOrDiv == false)
                                                {
                                                    if (InputList[p] == "x")
                                                    {
                                                        InputList[p] = int.Parse(InputList[p - 1]) * int.Parse(InputList[p + 1]) + "";
                                                        sum = int.Parse(InputList[p]);
                                                        if (p != 0)
                                                        {
                                                            InputList.Remove(InputList[p - 1]);
                                                            InputList.Remove(InputList[p]);
                                                            y = y - 1;
                                                            z = z - 2;
                                                        }
                                                        else
                                                        {
                                                            InputList.Remove(InputList[p + 1]);
                                                            InputList.Remove(InputList[p]);
                                                        }

                                                        break;
                                                    }
                                                    else if (InputList[p] == "/")
                                                    {
                                                        InputList[p] = int.Parse(InputList[p - 1]) / int.Parse(InputList[p + 1]) + "";
                                                        sum = int.Parse(InputList[p]);
                                                        if (p != 0)
                                                        {
                                                            InputList.Remove(InputList[p - 1]);
                                                            InputList.Remove(InputList[p]);
                                                            y = y - 1;
                                                            z = z - 2;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            InputList.Remove(InputList[p + 1]);
                                                            InputList.Remove(InputList[p]);
                                                        }
                                                        break;
                                                    }
                                                }

                                                else if (noMultOrDiv == true)
                                                {
                                                    if (InputList[p] == "+")
                                                    {
                                                        InputList[p] = int.Parse(InputList[p - 1]) + int.Parse(InputList[p + 1]) + "";
                                                        sum = int.Parse(InputList[p]);
                                                        if (p != 0)
                                                        {
                                                            InputList.Remove(InputList[p - 1]);
                                                            InputList.Remove(InputList[p]);
                                                            y = y - 1;
                                                            z = z - 2;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            InputList.Remove(InputList[p + 1]);
                                                            InputList.Remove(InputList[p]);
                                                        }
                                                        break;
                                                    }
                                                    else if (InputList[p] == "-")
                                                    {
                                                        InputList[p] = int.Parse(InputList[p - 1]) - int.Parse(InputList[p + 1]) + "";
                                                        sum = int.Parse(InputList[p]);
                                                        if (p != 0)
                                                        {
                                                            InputList.Remove(InputList[p - 1]);
                                                            InputList.Remove(InputList[p]);
                                                            y = y - 1;
                                                            z = z - 2;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            InputList.Remove(InputList[p + 1]);
                                                            InputList.Remove(InputList[p]);
                                                        }
                                                        break;
                                                    }
                                                }
                                            }

                                        }

                                    }


                                }
                            }




                            else
                            {
                                noMultOrDiv = true;
                                for (int a = 0; a < InputList.Count(); a++)
                                {
                                    if (noMultOrDiv == false)
                                    {
                                        break;
                                    }
                                    else if (InputList[a] == "x")
                                    {
                                        noMultOrDiv = false;
                                    }
                                    else if (InputList[a] == "/")
                                    {
                                        noMultOrDiv = false;
                                    }
                                }




                                for (int b = 0; b < InputList.Count(); b++)
                                {
                                    if (noMultOrDiv == false)
                                    {
                                        if (InputList[b] == "x")
                                        {
                                            InputList[b] = int.Parse(InputList[b - 1]) * int.Parse(InputList[b + 1]) + "";
                                            sum = int.Parse(InputList[b]);
                                            if (b != 0)
                                            {
                                                InputList.Remove(InputList[b - 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            else
                                            {
                                                InputList.Remove(InputList[b + 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            break;
                                        }
                                        else if (InputList[b] == "/")
                                        {
                                            InputList[b] = int.Parse(InputList[b - 1]) / int.Parse(InputList[b + 1]) + "";
                                            sum = int.Parse(InputList[b]);
                                            if (b != 0)
                                            {
                                                InputList.Remove(InputList[b - 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            else
                                            {
                                                InputList.Remove(InputList[b + 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            break;
                                        }
                                    }

                                    else if (noMultOrDiv == true)
                                    {
                                        if (InputList[b] == "+")
                                        {
                                            InputList[b] = int.Parse(InputList[b - 1]) + int.Parse(InputList[b + 1]) + "";
                                            sum = int.Parse(InputList[b]);
                                            if (b != 0)
                                            {
                                                InputList.Remove(InputList[b - 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            else
                                            {
                                                InputList.Remove(InputList[b + 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            break;
                                        }
                                        else if (InputList[b] == "-")
                                        {
                                            InputList[b] = int.Parse(InputList[b - 1]) - int.Parse(InputList[b + 1]) + "";
                                            sum = int.Parse(InputList[b]);
                                            if (b != 0)
                                            {
                                                InputList.Remove(InputList[b - 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            else
                                            {
                                                InputList.Remove(InputList[b + 1]);
                                                InputList.Remove(InputList[b]);
                                            }
                                            break;
                                        }
                                    }

                                }
                                if (InputList.Count == 1)
                                {
                                    Console.WriteLine(InputList[0]);
                                    sum = 0;
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}

   


