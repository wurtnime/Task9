using System;


namespace ConsoleApp0303;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Практическая работа номер 9");
        Console.WriteLine("1-30");
        int sm = Convert.ToInt32(Console.ReadLine());

        switch (sm)
        {
            case 1:

                Console.WriteLine("Введите число A (A < B)");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B (A < B)");
                int B = Convert.ToInt32(Console.ReadLine());

                Сalculation1 numberRange = new Сalculation1(A, B);

                List<int> numbers = numberRange.GetNumbers();
                Console.WriteLine("Числа от А до В:");
                Console.WriteLine(string.Join(",", numbers));

                int count = numberRange.GetCount();

                Console.WriteLine($"Количество чисел N: {count}");

                break;

            case 2:

                Console.WriteLine("Введите число A (A < B)");
                int A2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B (A < B)");
                int B2 = Convert.ToInt32(Console.ReadLine());

                Сalculation2 numberRange2 = new Сalculation2(A2, B2);

                List<int> numbers2 = numberRange2.GetNumbers();
                Console.WriteLine("Числа от А до В:");
                Console.WriteLine(string.Join(",", numbers2));

                int count2 = numberRange2.GetCount();

                Console.WriteLine($"Количество чисел N: {count2}");
                break;

            case 3:
                Console.WriteLine("Введите A и N:");
                double A3 = double.Parse(Console.ReadLine());
                int N3 = int.Parse(Console.ReadLine());

                Сalculation3 calculation3 = new Сalculation3(A3, N3);
                Console.WriteLine($"{A3} в степени {N3} = {calculation3.CalculatePower()}");
                break;

            case 4:

                Console.WriteLine("Введите число A ");
                int A4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число N (N > 0)");
                int N4 = Convert.ToInt32(Console.ReadLine());

                double result4 = 1;

                Console.WriteLine($"Степени числа {A4} от 1 до {N4}:");
                for (int i = 1; i <= N4; i++)
                {
                    result4 *= A4;
                    Console.WriteLine($"{A4} в степени {i} = {result4}");
                }
                break;

            case 5:
                Console.WriteLine("Введите A и N:");
                double A5 = double.Parse(Console.ReadLine());
                int N5 = int.Parse(Console.ReadLine());
                Calculation5 seriesSum = new Calculation5(A5, N5);
                Console.WriteLine($"1 + A + A^2 + ... + A^N = {seriesSum.CalculateSum1()}");
                Console.WriteLine($"1 - A + A^2 - ... + (-1)^N*A^N = {seriesSum.CalculateSum2()}");
                break;

            case 6:
                Console.WriteLine("Введите N и M:");
                int N6 = int.Parse(Console.ReadLine());
                int M6 = int.Parse(Console.ReadLine());
                Сalculation6 inequalitySolver = new Сalculation6(N6, M6);
                var result6 = inequalitySolver.FindSmallestK();
                Console.WriteLine($"Наименьшее K: {result6.K}, 3*K = {result6.Value}");
                break;

            case 7:
                Console.WriteLine("Введите N и M:");
                int N7 = int.Parse(Console.ReadLine());
                int M7 = int.Parse(Console.ReadLine());
                Сalculation7 inequalitySolverMax = new Сalculation7(N7, M7);
                var result7 = inequalitySolverMax.FindLargestK();
                Console.WriteLine($"Наибольшее K: {result7.K}, 3*K = {result7.Value}");
                break;

            case 8:
                Console.WriteLine("Введите A:");
                double A8 = double.Parse(Console.ReadLine());
                Сalculation8 harmonicSeries = new Сalculation8(A8);
                var result8 = harmonicSeries.FindSmallestN();
                Console.WriteLine($"Наименьшее N: {result8.N}, Сумма: {result8.Sum}");
                break;


            case 9:
                Console.WriteLine("Введите N:");
                int N9 = int.Parse(Console.ReadLine());
                Сalculation9 factorialCalculator = new Сalculation9(N9);
                Console.WriteLine($"Факториал {N9} = {factorialCalculator.CalculateFactorial()}");
                break;

            case 10:
                Console.WriteLine("Введите N:");
                int N10 = int.Parse(Console.ReadLine());
                Сalculation10 productCalculator = new Сalculation10(N10);
                Console.WriteLine($"Произведение 2 * 1/2 * 1/3 * ... * 1/{N10} = {productCalculator.CalculateProduct()}");
                break;

            case 11:
                Console.WriteLine("Введите X и N:");
                double X11 = double.Parse(Console.ReadLine());
                int N11 = int.Parse(Console.ReadLine());
                Сalculation11 seriesSumX = new Сalculation11(X11, N11);
                Console.WriteLine($"1 + X + X^2/2 + ... + X^N/N = {seriesSumX.CalculateSum()}");
                break;

            case 12:
                Console.WriteLine("Введите X и N:");
                double X12 = double.Parse(Console.ReadLine());
                int N12 = int.Parse(Console.ReadLine());
                Сalculation12 alternatingSeriesX = new Сalculation12(X12, N12);
                Console.WriteLine($"X - X^3/3 + X^5/5 - ... + (-1)^N*X^(2N+1)/(2N+1) = {alternatingSeriesX.CalculateSum()}");
                break;

            case 13:
                Console.WriteLine("Введите X и N:");
                double X13 = double.Parse(Console.ReadLine());
                int N13 = int.Parse(Console.ReadLine());
                Сalculation13 alternatingSeriesX2 = new Сalculation13(X13, N13);
                Console.WriteLine($"1 - X^2/2 + X^4/4 - ... + (-1)^N*X^(2N)/(2N) = {alternatingSeriesX2.CalculateSum()}");
                break;

            case 14:
                Console.WriteLine("Введите X и N:");
                double X14 = double.Parse(Console.ReadLine());
                int N14 = int.Parse(Console.ReadLine());
                Сalculation14 naturalLogApproximation = new Сalculation14(X14, N14);
                Console.WriteLine($"X - X^2/2 + X^3/3 - ... + (-1)^(N-1)*X^N/N = {naturalLogApproximation.CalculateSum()}");
                break;

            case 15:
                Console.WriteLine("Введите X (|X| < 1) и N:");
                double X15 = double.Parse(Console.ReadLine());
                int N15 = int.Parse(Console.ReadLine());
                Сalculation15 arctgApproximation = new Сalculation15(X15, N15);
                Console.WriteLine($"Приближенное значение arctg(X) = {arctgApproximation.CalculateArctg()}");
                break;

            case 16:
                Console.WriteLine("Введите N (> 2), A и B (A < B):");
                int N16 = int.Parse(Console.ReadLine());
                double A16 = double.Parse(Console.ReadLine());
                double B16 = double.Parse(Console.ReadLine());
                Сalculation16 segmentPartition = new Сalculation16(N16, A16, B16);
                Console.WriteLine($"Шаг H = {segmentPartition.CalculateH()}");
                Console.WriteLine("Точки разбиения:");
                Console.WriteLine(string.Join(" ", segmentPartition.GetPartitionPoints()));
                break;

            case 17:
                Console.WriteLine("Введите N (> 2), A и B (A < B):");
                int N17 = int.Parse(Console.ReadLine());
                double A17 = double.Parse(Console.ReadLine());
                double B17 = double.Parse(Console.ReadLine());
                Сalculation17 functionValues = new Сalculation17(N17, A17, B17);
                Console.WriteLine("Значения функции F(X) = 1 - sin(X):");
                Console.WriteLine(string.Join(" ", functionValues.CalculateFunctionValues()));
                break;

            case 18:
                Console.WriteLine("Введите D (> 0):");
                double D18 = double.Parse(Console.ReadLine());
                Сalculation18 sequenceConvergence = new Сalculation18(D18);
                var result18 = sequenceConvergence.FindConvergence();
                Console.WriteLine($"Номер K: {result18.K}, A(K-1): {result18.AKMinus1}, A(K): {result18.AK}");
                break;

            case 19:
                Console.WriteLine("Введите D (> 0):");
                double D19 = double.Parse(Console.ReadLine());
                Сalculation19 sequenceConvergence2 = new Сalculation19(D19);
                var result19 = sequenceConvergence2.FindConvergence();
                Console.WriteLine($"Номер K: {result19.K}, A(K-1): {result19.AKMinus1}, A(K): {result19.AK}");
                break;

            case 20:
                Console.WriteLine("Введите N (> 10):");
                int N20 = int.Parse(Console.ReadLine());
                Сalculation20 oddMultiplesOfFive = new Сalculation20(N20);
                Console.WriteLine("Нечетные числа, кратные пяти:");
                Console.WriteLine(string.Join(" ", oddMultiplesOfFive.GetNumbers()));
                break;

            case 21:
                Сalculation21 squaresFrom11To99 = new Сalculation21();
                Console.WriteLine("Квадраты чисел от 11 до 99:");
                Console.WriteLine(string.Join(" ", squaresFrom11To99.GetSquares()));
                break;

            case 22:
                Console.WriteLine("Вводите значения X (для завершения введите 'exit'):");
                List<double> results22 = new List<double>();
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit") break;
                    double X22 = double.Parse(input);
                    Сalculation22 functionCalculator = new Сalculation22(X22);
                    results22.Add(functionCalculator.CalculateFunction());
                }
                Console.WriteLine("Результаты вычислений:");
                Console.WriteLine(string.Join(" ", results22));
                break;

            case 23:
                Console.WriteLine("Введите N:");
                int N23 = int.Parse(Console.ReadLine());
                Сalculation23 factorialAndPower = new Сalculation23(N23);
                Console.WriteLine($"N! = {factorialAndPower.CalculateFactorial()}, 2^N = {factorialAndPower.CalculatePower()}");
                break;

            case 24:
                Console.WriteLine("Введите N (> 10):");
                int N24 = int.Parse(Console.ReadLine());
                Сalculation24 largestDigit = new Сalculation24(N24);
                Console.WriteLine($"Наибольшая цифра числа {N24}: {largestDigit.FindLargestDigit()}");
                break;

            case 25:
                Console.WriteLine("Введите N (> 10):");
                int N25 = int.Parse(Console.ReadLine());
                Сalculation25 firstDigitAndSum = new Сalculation25(N25);
                Console.WriteLine($"Первая цифра: {firstDigitAndSum.GetFirstDigit()}, Сумма цифр: {firstDigitAndSum.GetSumOfDigits()}");
                break;

            case 26:
                Console.WriteLine("Введите число:");
                int number26 = int.Parse(Console.ReadLine());
                Сalculation26 palindromeChecker = new Сalculation26(number26);
                Console.WriteLine(palindromeChecker.IsPalindrome() ? "Число является палиндромом." : "Число не является палиндромом.");
                break;

            case 27:
                Сalculation27 sumOfSquares = new Сalculation27();
                Console.WriteLine("Сумма квадратов чисел от 12 до 80:");
                sumOfSquares.PrintSumOfSquares();
                break;

            case 28:
                Сalculation28 differenceOfSquares = new Сalculation28();
                Console.WriteLine("Разность квадратов чисел от 22 до 88:");
                differenceOfSquares.PrintDifferenceOfSquares();
                break;

            case 29:
                Console.WriteLine("Введите A и N:");
                double A29 = double.Parse(Console.ReadLine());
                int N29 = int.Parse(Console.ReadLine());
                Сalculation29 squareDifferences = new Сalculation29(A29, N29);
                Console.WriteLine("Разности квадратов:");
                Console.WriteLine(string.Join(" ", squareDifferences.CalculateDifferences()));
                break;

            case 30:
                Console.WriteLine("Введите N (> 10):");
                int N30 = int.Parse(Console.ReadLine());
                Сalculation30 smallestDigit = new Сalculation30(N30);
                Console.WriteLine($"Наименьшая цифра числа {N30}: {smallestDigit.FindSmallestDigit()}");
                break;

            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}
