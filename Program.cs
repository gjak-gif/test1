int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000) {
    int result = num / 100 * 10 + 1;
    Console.WriteLine($"Полученное число {result}");
} else {
    Console.WriteLine("Некорректное число");
}
