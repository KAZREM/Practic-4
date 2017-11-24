using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_4
{
    public class Money
    {

        private int _nominalCupure;
        private int _countCupure;
        private double _priceTovar;
        private double _nominalCup;

       // public int priceTovar { get; private set; }

        public Money()
        {
            _nominalCupure = 0;
            _countCupure = 0;
            _priceTovar = 0;
           _nominalCup = 0;
        }
        public Money(int nominalCupure, int countCupure)
        {
            _nominalCupure = nominalCupure;
            _countCupure = countCupure;
           
        }
        public Money(double priceTovar, double nominalCup)
        {
            _priceTovar = priceTovar;
            _nominalCup = nominalCup;
        }
        public int GetNominalCupure()
        {
            return _nominalCupure;
        }
        public void SetNominalCupure(int nominalCupure)
        {
            _nominalCupure = nominalCupure;
        }
        public int GetCountCupure()
        {
            return _countCupure;
        }
        public void SetCountCupure(int countCupure)
        {
            _countCupure = countCupure;
        }
        public double GetPriceTovar()
        {
            return _nominalCup;
        }
        public void SetNominalCup(int nominalCup)
        {
            _nominalCup = nominalCup;
        }
       
        public bool IsEnoght(int sum)
        {
            if (sum <= _nominalCupure * _countCupure)
            {
                return true;
            }
            else return false;
        }
        public int Count(int price)
        {
            return _nominalCupure * _countCupure / price;
        }
    }







    }
