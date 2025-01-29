while (true) 
        {
            // Ввод первого числа с проверкой
            double num1;
            Console.Write("Введите первое число (или 'exit' для выхода): ");
            string input = Console.ReadLine()!;
            if (input.ToLower() == "exit") break;
            if (!double.TryParse(input, out num1)) 
            {
                Console.WriteLine("Ошибка: введите число!");
                continue;
            }

            // Ввод второго числа с проверкой
            double num2;
            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out num2)) 
            {
                Console.WriteLine("Ошибка: введите число!");
                continue;
            }

            // Выбор операции
            Console.Write("Выберите операцию (+ - * /): ");
            string? mathOperator = Console.ReadLine();

            switch (mathOperator) 
            {
                case "+":
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0) 
                    {
                        Console.WriteLine("Ошибка: на ноль делить нельзя!");
                    } 
                    else 
                    {
                        Console.WriteLine($"Результат: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    break;
            }

            Console.WriteLine(); // Пустая строка для разделения итераций
        }