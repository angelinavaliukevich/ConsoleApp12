using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Затем создайте класс инвентаря, который отслеживает различные продукты и может суммировать стоимость инвентаря.
namespace ConsoleApp12
{
    class Inventar
    {
        List<int> tovar = new List<int>();
        public int Stoimost(string name,int price);
        string[] name = new string[] { };
        int[] price = new int[] { };
        int[] quantity = new int[] { };
        
    }
   
}
