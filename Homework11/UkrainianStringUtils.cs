using System;
using System.Linq;

namespace Homework11
{
    public static class UkrainianStringUtils
    {
        private static readonly char[] vowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
        private static readonly char[] consonants = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

        // Метод для підрахунку кількості голосних літер у рядку
        public static int CountVowels(string input)
        {
            // Перевірка на null або порожній рядок
            if (string.IsNullOrEmpty(input))
                return 0;

            // Підрахунок голосних літер
            return input.ToLower().Count(c => vowels.Contains(c));
        }

        // Метод для підрахунку кількості приголосних літер у рядку
        public static int CountConsonants(string input)
        {
            // Перевірка на null або порожній рядок
            if (string.IsNullOrEmpty(input))
                return 0;

            // Підрахунок приголосних літер
            return input.ToLower().Count(c => consonants.Contains(c));
        }

        // Метод для обернення рядка
        public static string ReverseString(string input)
        {
            // Перевірка на null або порожній рядок
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Обернення рядка
            return new string(input.Reverse().ToArray());
        }

        // Метод для видалення дублікатів символів з рядка
        public static string RemoveDuplicates(string input)
        {
            // Перевірка на null або порожній рядок
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Видалення дублікатів символів
            return new string(input.Distinct().ToArray());
        }

        // Метод для видалення всіх знаків пунктуації з рядка
        public static string RemovePunctuation(string input)
        {
            // Перевірка на null або порожній рядок
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Видалення знаків пунктуації
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }
}
