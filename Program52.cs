﻿
    
        static void main()

        {
            int[,] mas = new int[3,3] {{1, 2, 3}, {3, 5, 7}, {5, 6, 1}};

            for (int i = 0; i < 3; i++)
            {

                int SrAr = 0;
                for (int t = 0; t < 3; t++)

                {

                    SrAr += mas[t, i];

                }
                Console.WriteLine($"Среднее арифметическое");
            }
        }
    