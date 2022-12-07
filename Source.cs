using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXDLB1
{
    internal class Source
    {
        static void Main(string[] args)
        {
            User User = new User("+380777777777");

            double balance = User.accountreplenishment(500);

            User.setTariff(Tariffs.LoveUAnaMAX);
          
            
            double costOfCall = User.callSomeone("+380878888888", 3);
            User.getCallPrice(3);

            User.adPowere(SuperPower.KievSatrTV);
            User.adPowere(SuperPower.SimsForOtherDevice);
            User.adPowere(SuperPower.International_100min_forcalls);

            User.showBalance();

            User.removePower(SuperPower.KievSatrTV);

            List<SuperPower> myServices = User.getPower();

            User.showPower();

            User.printCallHistory();
            Console.ReadKey();
        }
    }
}
