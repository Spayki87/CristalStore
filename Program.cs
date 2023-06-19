using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystals_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int cristalCount;
            int cristalPrice = 5;
            Console.Write("Введите начальное количество монет:");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы можете купить кристалы по " + cristalPrice + " монет.");
            Console.Write("Сколько кристалов вам нужно:");
            cristalCount = Convert.ToInt32(Console.ReadLine());
            money -= cristalCount * cristalPrice;
            Console.WriteLine("У вас осталось " + money + " монет и " + cristalCount + " кристалов.");
        }
    }
}
