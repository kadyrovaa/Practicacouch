//задание 1

//Console.Write("Стоимость елки:\t");
//int aa = Convert.ToInt32(Console.ReadLine());
//if(aa > 100000 || aa < 1)
//{
//    Console.WriteLine("Введите стоимость елки в диапазоне от 1 до 100000");
//    aa = Convert.ToInt32(Console.ReadLine());
//}
//Console.Write("Скидка:\t");
//int d = Convert.ToInt32(Console.ReadLine());
//if (d > 100 || d < 1)
//{
//    Console.WriteLine("Введите скидку в диапазоне от 1 до 100");
//    d = Convert.ToInt32(Console.ReadLine());
//}
//int cost = aa-(aa / 100 * d); 
//Console.Write("Василий потратил: " + cost);



//задание 2

//    Console.Write("Введите количество учащихся в первом классе:\t");
//    int class1 = Convert.ToInt32(Console.ReadLine());
//    while (class1 > Math.Pow(10, 5) || class1 <= 0)
//    {
//        Console.Write("Введите количество учащихся в первом классе от 1 до 10^5 :\t");
//        class1 = Convert.ToInt32(Console.ReadLine());

//    }

//    Console.Write("Введите количество учащихся во втором классе:\t");
//    int class2 = Convert.ToInt32(Console.ReadLine());
//    while (class2 > Math.Pow(10, 5) || class2 <= 0)
//    {
//        Console.Write("Введите количество учащихся во втором классе от 1 до 10^5 :\t");
//        class2 = Convert.ToInt32(Console.ReadLine());

//    }

//    Console.Write("Введите количество учащихся в третьем классе:\t");
//    int class3 = Convert.ToInt32(Console.ReadLine());
//    while (class3 > Math.Pow(10, 5) || class3 <= 0)
//    {
//        Console.Write("Введите количество учащихся в третьем классе от 1 до 10^5 :\t");
//        class3 = Convert.ToInt32(Console.ReadLine());

//    }
//double tables1 = class1 / 2;
//if (class1 % 2 != 0)
//{
//    tables1 += 1;
//}

//double tables2 = class2 / 2;
//if (class2 % 2 != 0)
//{
//    tables2 += 1;
//}

//double tables3 = class3 / 2;
//if (class3 % 2 != 0)
//{
//    tables3 += 1;
//}

//double all = tables1 + tables2 + tables3;

//Console.Write("Нужно парт: " + all);


//задание 3

//Console.Write("Введите сторону a = ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите сторону b = ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите сторону c = ");
//int c = Convert.ToInt32(Console.ReadLine());

//TriType(a, b, c);

//   static void TriType(int a, int b, int c)
//    {
//        if (((a + b) > c) && ((a + c) > b) && ((c + b) > a))
//        {
//            Console.WriteLine("Yes");
//        }
//        else
//        {
//            Console.WriteLine("No");
//        }

//    }