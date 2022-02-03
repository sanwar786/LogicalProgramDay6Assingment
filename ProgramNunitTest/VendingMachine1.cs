using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramingDay6.ProgramNunitTest
{
    /// <summary>          
    /// Simulate a candy bar vending machine that starts with
    /// 5 candy bars, where each candy bar costs 3 quarters.
    /// </summary>
    internal class VendingMachine1
    {
        // private instance variables
        private int _numQuarters, _numCandyBars, _numCandyBars2, _numCandyBars3;
        // Public noarg constructor
        public VendingMachine1()
        {
            // Set the candy bar cost in quarters.  
            _numQuarters = 3;

            // Set initial number of candy bars.
            _numCandyBars = 5;
            _numCandyBars2 = 5;
            _numCandyBars3 = 8;
        }
        // Public read only properties:
        public int NumQuarters
        {
            get { return _numQuarters; }
        }
        public int NumCandyBars
        {
            get { return _numCandyBars; }
        }
        public int NumCandyBars2
        {
            get { return _numCandyBars2; }
        }
        public int NumCandyBars3
        {
            get { return _numCandyBars3; }
        }
        // Public methods:

        public string DepositQuarter()
        {
            _numQuarters++;
            return "Quarter deposited.";
        }
        public string SelectCandy()
        {
            if (_numQuarters >= 3 && _numCandyBars > 0 && _numCandyBars2 > 0 && _numCandyBars3 > 0)
            {
                _numQuarters = _numQuarters - 3;
                _numCandyBars--;
                _numCandyBars2--;
                _numCandyBars3--;
                return "Candy bar dispensed";
            }
            else if (_numCandyBars > 0)
            {
                return "No candy bars in machine.";
            }
            else if (_numCandyBars2 > 0)
            {
                _numQuarters = _numQuarters - 3;
                _numCandyBars2--;
                return "No candy bars in machine.";
            }
            else if (_numCandyBars3 > 0)
            {
                _numQuarters = _numQuarters - 3;
                _numCandyBars3--;
                return "No candy bar.";
            }
            else
            {
                return "No candy bars in machine.";
            }
        }

        public override string ToString()
        {
            return "Total Quarters: " + _numQuarters + " Total Number of Sneaker Bars :" + _numCandyBars + " Total Number of Kitkat Bars: " + _numCandyBars2 + " Total Number of Milkyway Bars: " + _numCandyBars3;
        }
    }
}
