﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linecomp
{
    internal class length
    {
             public static void linecomparison()
            {

                double[] length = new double[2];
                for (int i = 0; i< 2; i++)
                {
                    int x1;
                    int y1;
                    Console.WriteLine("Enter the 1st co-ordinates x1");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the 1st co-ordinates y1");
                    y1 = Convert.ToInt32(Console.ReadLine());

                    int x2;
                    int y2;

                    Console.WriteLine("Enter the 1st co-ordinates x2");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the 1st co-ordinates y2");
                    y2 = Convert.ToInt32(Console.ReadLine());

                    length[i] = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    Console.WriteLine("length of the line is : " + length);
                }

                bool result = length[1].Equals(length[0]);
                Console.WriteLine("Both lines are equals : " + result);
                Console.ReadLine();
            }



        }
    }



