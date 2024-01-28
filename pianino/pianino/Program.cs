using System.Media;

namespace PianoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение массивов октав
            int[] firstOctave = new int[] { 200, 300, 400 };
            int[] secondOctave = new int[] { 500, 600, 700 };
            int[] thirdOctave = new int[] { 800, 900, 1000 };

            int currentOctave = 1; // Текущая октава

            while (true)
            {
                Console.WriteLine("Выберите октаву:");
                Console.WriteLine("1 - Октава 1");
                Console.WriteLine("2 - Октава 2");
                Console.WriteLine("3 - Октава 3");
                Console.WriteLine("0 - Выход");

                ConsoleKeyInfo key = Console.ReadKey();

                Console.Clear();

                if (key.Key == ConsoleKey.D0 || key.Key == ConsoleKey.NumPad0)
                    break;

                if (key.Key == ConsoleKey.F1)
                    currentOctave = 1;
                else if (key.Key == ConsoleKey.F2)
                    currentOctave = 2;
                else if (key.Key == ConsoleKey.F3)
                    currentOctave = 3;

                int[] currentOctaves = GetOctaves(currentOctave);

                // Воспроизведение звука
                PlaySound(currentOctaves);
            }
        }

        static int[] GetOctaves(int octave)
        {
            // Возвращение нужного массива октав в зависимости от выбранной октавы
            switch (octave)
            {
                case 1:
                    return new int[] { 200, 300, 400 };
                case 2:
                    return new int[] { 500, 600, 700 };
                case 3:
                    return new int[] { 800, 900, 1000 };
                default:
                    return new int[] { };
            }
        }

        static void PlaySound(int[] octaves)
        {
            // Воспроизведение звука для каждой ноты в октаве
            foreach (int frequency in octaves)
            {
                if (frequency > 0)
                {
                    Console.WriteLine($"Воспроизведение ноты с частотой {frequency} Гц");
                    // здесь можно реализовать воспроизведение звука
                }
            }
        }
    }
}
