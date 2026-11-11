using LAB05;

// ========== 1) Создание объекта и чтение свойств ==========
Console.WriteLine("--- 1. Чтение свойств ---");
AProgression p1 = new AProgression(2, 3);
Console.WriteLine($"First = {p1.First}, Step = {p1.Step}");
p1.PrintInfo();

// ========== 2) Изменение свойств ==========
Console.WriteLine("\n--- 2. Изменение свойств ---");
p1.First = 5;
p1.Step = 4;
Console.WriteLine($"First = {p1.First}, Step = {p1.Step}");
p1.PrintInfo();

// ========== 3) Валидация: попытка установить Step = 0 ==========
Console.WriteLine("\n--- 3. Валидация Step = 0 ---");
try
{
    p1.Step = 0;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

// ========== 4) Работа GetSum(n) ==========
Console.WriteLine("\n--- 4. Метод GetSum(n) ---");
AProgression p2 = new AProgression(2, 3); // 2, 5, 8, 11, 14...
Console.WriteLine($"Сумма первых 5 членов (n=5): {p2.GetSum(5)}");   // 2+5+8+11+14 = 40
Console.WriteLine($"Сумма первых 10 членов (n=10): {p2.GetSum(10)}"); // 155

// ========== 5) Обработка ошибки при n <= 0 ==========
Console.WriteLine("\n--- 5. Ошибка при некорректном n ---");
try
{
    p2.GetSum(0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

try
{
    p2.GetSum(-3);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

// ========== 6) Ещё один объект для наглядности ==========
Console.WriteLine("\n--- 6. Дополнительный объект ---");
AProgression p3 = new AProgression(1, -2); // убывающая: 1, -1, -3, -5...
p3.PrintInfo();
Console.WriteLine($"Сумма первых 4 членов: {p3.GetSum(4)}");