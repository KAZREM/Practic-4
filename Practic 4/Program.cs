using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practic_4
{
    class Program
    {
        //double nominalCup = 0;
      //  double nominalCup;
     // double N;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите наминал купюры");
            int nominalCupure = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите количество купюр");
           int countCupure = int.Parse(Console.ReadLine());

            Money nominalCup = new Money(nominalCupure, countCupure);

            Console.WriteLine("Сумма денежных средств: {2}", nominalCupure, countCupure, nominalCupure * countCupure);

            Console.WriteLine("Введите цену товара");
            int priceTovar = int.Parse(Console.ReadLine());

            if (nominalCup.IsEnoght(priceTovar))
            {
                Console.WriteLine("Достаточно средств");
            }
            else { Console.WriteLine("Не достаточнор средств"); }

            Console.WriteLine("Введите цену товара");
            int priceTovar_ = int.Parse(Console.ReadLine());

            Console.WriteLine($"количество товара : {nominalCup.Count(priceTovar_)}");

            Console.ReadKey();
            


         Console.WriteLine("Сумма денежных средств: {2}", nominalCupure, countCupure, nominalCupure * countCupure);
            // double N = nominalCup - priceTovar;

           // Console.WriteLine("Результат покупки: {3}", ;


           
        }

    }
}
