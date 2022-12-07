using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXDLB1
{
    enum Tariffs
    {
        LoveUAnaMAX = 17, 
        SuperGIGACHAD = 30,
        VashBesLim = 50,
       
    }

    enum SuperPower  //послуги у Київстар)))
    {
        KievSatrTV = 32, 
        SimsForOtherDevice = 22,
        International_100min_forcalls = 1200
    }

    struct JustCall
    {
        public string phoneNumber;
        public int duration;
    }

    internal class Tariff
    {
        public string name;
        public double pricepermin;

        public List<SuperPower> powers = new List<SuperPower>();

        public Tariff()
        {
            name = getTariffName(Tariffs.VashBesLim);
            pricepermin = (int)Tariffs.VashBesLim;
        }

        public Tariff(Tariffs t)
        {
            name = getTariffName(t);
            pricepermin = (int)t;
        }

        private string getTariffName(Tariffs t)
        {
            switch (t)
            {
                case Tariffs.LoveUAnaMAX:
                    return "LoveUAnaMAX";
                case Tariffs.SuperGIGACHAD:
                    return "SuperGIGACHAD";
                case Tariffs.VashBesLim:
                    return "VashBesLim";
                default:
                    return "VashBesLim";
            }
        }

        public string getPowerName(SuperPower t)
        {
            switch (t)
            {
                case SuperPower.KievSatrTV:
                    return "KievSatrTV";
                case SuperPower.SimsForOtherDevice:
                    return "SimsForOtherDevice";
                case SuperPower.International_100min_forcalls:
                    return "International_100min_forcalls";
                default:
                    return "NO POWER?";
            }
        }
    }
}
