//высокий уровень 25 вариант 
        string word1 = "apple";
        string word2 = "banana";
        string word3 = "cherry";

        int[] letterCount = new int[26];

        
        foreach (char letter in word1.ToLower())
        {
            if (char.IsLetter(letter))
            {
                letterCount[letter - 'a']++;
            }
        }

        
        foreach (char letter in word2.ToLower())
        {
            if (char.IsLetter(letter))
            {
                letterCount[letter - 'a']++;
            }
        }

        
        foreach (char letter in word3.ToLower())
        {
            if (char.IsLetter(letter))
            {
                letterCount[letter - 'a']++;
            }
        }

        Console.WriteLine("Неповторяющиеся буквы: ");
        for (int i = 0; i < letterCount.Length; i++)
        {
            if (letterCount[i] == 1)
            {
                Console.Write((char)('a' + i) + " ");
            }
        }
