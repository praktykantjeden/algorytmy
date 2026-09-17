using System;
namespace zadanie1;

class Program {

    static void Main(string[] args) 
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            bool CzyLiczbaP = true;

            int liczba = int.Parse(Console.ReadLine());

            if (liczba == 0 || liczba == 1)
            {
                CzyLiczbaP = false;
            }
            else
            {

                for (int i = 2; i < liczba - 1; i++)
                {
                    if (liczba % i == 0)
                    {
                        CzyLiczbaP = false;
                        break;
                    }
                    else
                    {

                    }

                }

            }

            if (CzyLiczbaP == false)
            {
                Console.WriteLine("NIE");
            }
            else if(CzyLiczbaP == true)
            {
                Console.WriteLine("TAK");

            }
        }

        
    }
    
}