namespace CodeTestOnsdag
{
    public class Program
    {
        public static int MestFrekventSiffra(int[] talArray)
        {
            // Listor för att hålla koll på siffror och deras respektive frekvenser
            List<int> unikaSiffror = new List<int>();
            List<int> siffrasFrekvenser = new List<int>();

            // Räkna förekomster av varje siffra
            foreach (int aktuellSiffra in talArray)
            {
                int indexAvSiffra = unikaSiffror.IndexOf(aktuellSiffra);
                if (indexAvSiffra != -1)
                {
                    siffrasFrekvenser[indexAvSiffra]++;
                }
                else
                {
                    unikaSiffror.Add(aktuellSiffra);
                    siffrasFrekvenser.Add(1);
                }
            }

            // Hitta högsta frekvensen
            int hogstaFrekvens = siffrasFrekvenser.Max();

            // Filtrera ut de siffror som har högsta frekvensen och välj den minsta
            int minstFrekventaSiffra = int.MaxValue;
            for (int i = 0; i < unikaSiffror.Count; i++)
            {
                if (siffrasFrekvenser[i] == hogstaFrekvens)
                {
                    minstFrekventaSiffra = Math.Min(minstFrekventaSiffra, unikaSiffror[i]);
                }
            }

            return minstFrekventaSiffra;
        }

        // Testfall
        public static void Main(string[] args)
        {
            Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // Output: 2
            Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // Output: 1
            Console.WriteLine(MestFrekventSiffra(new int[] { -1, -1, -2, -2, -2, 3 })); // Output: -2
            Console.WriteLine(MestFrekventSiffra(new int[] { 42 })); // Output: 42 (ensam siffra)
            Console.WriteLine(MestFrekventSiffra(new int[] { 3, 3, 2, 2, 1, 1 })); // Output: 1 (Alla har samma frekvens, välj minsta)
        }
    }
}
