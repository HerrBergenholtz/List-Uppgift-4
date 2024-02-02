using System;

namespace Uppgift_4
{
    class Program
    {
        static void Main()
        {
            string[] arr = { "Tjena", "Hejsan", "Ameen" };
            Console.WriteLine(FinnsTecknetIAllaSträngar(arr, 'A'));
        }
        
        static bool FinnsTecknetIAllaSträngar(string[] sträng, char tecken)
        {
            for (int i = 0; i < sträng.Length; i++)
            {
                if (sträng[i].ToLower().Contains(tecken.ToString().ToLower())) {
                    return true;
                }
            }
            return false;
        }
    }
}