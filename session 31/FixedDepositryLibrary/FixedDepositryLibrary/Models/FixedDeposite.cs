using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixedDepositryLibrary.Models;
namespace FixedDepositryLibrary
{
    public delegate double DFestival();
    public class FixedDeposite
    {
        private int _id;
        private string _name;
        private double _principle;
        private int _duration;
        private DFestival _ratePolicy;

        public FixedDeposite(int id, string name, double principle, int duration, DFestival ratePolicy)
        {
            _id = id;
            _name = name;
            _principle = principle;
            _duration = duration;
            _ratePolicy = ratePolicy;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Principle { get { return _principle; } }
        public int Duration { get { return _duration; } }

        public DFestival RatePolicy { get { return _ratePolicy; } }

        public double CalculateSimpleIntrest()
        {
            return _principle * _duration * RatePolicy();
        }

       
    }
}
