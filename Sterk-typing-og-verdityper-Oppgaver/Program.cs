namespace Sterk_typing_og_verdityper_Oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oppgave 1
            void Oppgave1()
            {
                int number = 0;
                long number2 = 0;

                decimal decimals = 0.24M;
                float decimals2 = 0.22F;
                double decimals3 = 0.55D;

                string text = "Dette er en tekst";
                char character = 'Y';

                bool IsThisTrue = true;
            }
            
            // Oppgave 2
            int a = 5;
            decimal b = 3M;

            decimal sum = a + b;
            // sum må være en decimal fordi jeg tror at:
            // int kan bli konvertert til en decimal, men en decimal kan ikke bli kovertert til en int uten å bruke Convert.ToInt32()
            int sum2 = a + Convert.ToInt32(b);
        }
    }
}
