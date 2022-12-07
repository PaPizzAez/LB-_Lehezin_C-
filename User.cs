using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXDLB1
{
    internal class User
    {
        public Tariff tariff;
        public string phoneNum;

        public double balance = 32;

        public List<JustCall> callsHistory = new List<JustCall>();

        public User()
        {
            phoneNum = "+380777777777";

            Console.WriteLine("Created user with number: " + phoneNum);
        }

        public User(string number)
        {
            phoneNum = number;
            Console.WriteLine("Created user with number: " + phoneNum);
        }

        public void setTariff(Tariffs x)
        {
                Tariff plan = new Tariff(x);
                tariff = plan;

                Console.WriteLine("You set tariff: " + tariff.name);
            
        }

        public double callSomeone(string otherphonenum, int minutes)
        {
            if (tariff is null)
            {
                Console.WriteLine("Set tariff before callSomeone");

                return 0;
            }

            JustCall history;
            history.phoneNumber = otherphonenum;
            history.duration = minutes;

            callsHistory.Add(history);

            double price = minutes * tariff.pricepermin;

            if (balance < price)
            {
                Console.WriteLine("Not enough cash?");

                return 0;
            }
            else
            {
                balance -= price;

                Console.WriteLine("You called " + otherphonenum + ". U have spoken for " + minutes + " minutes.");
                return balance;
            }
        }

        public void getCallPrice(int minutes)
        {
            double price = minutes * tariff.pricepermin;
            Console.WriteLine("You spend " + price + " UAH ");
            
        }
        public double accountreplenishment(double x)
        {
            balance += x;

            Console.WriteLine("Your account was replenished, Check it out: " + balance);
            return balance;
        }

        public double getBalance() { 
            return balance; 
        }
        public void showBalance()
        {
            Console.WriteLine("Your balance now: " + balance);
        }
        public List<SuperPower> getPower()
        {
            if (tariff is null)
            {
                Console.WriteLine("No choosen power");

                return new List<SuperPower>();
            }

            return tariff.powers;
        }

        public void showPower()
        {
            if (tariff is null)
            {
                Console.WriteLine("U have no power(");
                return;
            }

            Console.WriteLine("SuperPower: ");
            foreach (SuperPower poslug in tariff.powers)
            {
                Console.WriteLine("- " + tariff.getPowerName(poslug));
            }
        }

        public void adPowere(SuperPower poslug)
        {
            if (tariff is null)
            {
                Console.WriteLine("U have no power(");
                return;
            }

           

            int price = (int)poslug;
          

            if (balance < price)
            {
                Console.WriteLine("Not enough cahs");
            }
            else
            {
                tariff.powers.Add(poslug);
                balance -= price;
                Console.WriteLine("Service " + tariff.getPowerName(poslug) + " was added to your tariff line");
            }
        }

        public void removePower(SuperPower poslug)
        {
            if (tariff is null)
            {
                Console.WriteLine("Set tariff before removing");
                return;
            }

            tariff.powers.Remove(poslug);
            Console.WriteLine("Service " + tariff.getPowerName(poslug) + " was removed from your tariff line");
        }

        public void printCallHistory()
        {
            if (tariff is null)
            {
                Console.WriteLine("Set tariff before");
                return;
            }

            Console.WriteLine("Call history: ");
            foreach (JustCall call in callsHistory)
            {
                Console.WriteLine("U  spoke with " + call.phoneNumber + "  " + call.duration + "minutes");
            }
        }
    }
}
