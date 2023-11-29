//Средний уровень 25 вариант
        char[] charArray = new char[17];
        Console.WriteLine("Введите массив символов из 17 элементов:");

        for (int i = 0; i < charArray.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            charArray[i] = Console.ReadLine()[0];
            Console.WriteLine();
        }

        int[] charCount = new int[256]; 
        int maxCount = 0;
        char mostFrequentChar = '\0';

        foreach (char c in charArray)
        {
            charCount[c]++;
            if (charCount[c] > maxCount)
            {
                maxCount = charCount[c];
                mostFrequentChar = c;
            }
        }

   Console.WriteLine($"\nСимвол с наибольшим числом повторений: {mostFrequentChar}");

