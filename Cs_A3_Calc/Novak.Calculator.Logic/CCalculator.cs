/*************************
 * [CCalculator.cs]
 * C# Intermediate
 * Shawn Novak
 * 2012-10-07
 *************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.Calculator.Logic
{
    public class CCalculator
    {
    // Private Properties
        private string _sOp;
        private bool _bPend;
        private bool _bEx;
        private decimal _dA, _dB;
        private decimal _dResult;

    // Public Properties
        public string Op
        {
            get { return _sOp; }
            set { _sOp = value; _bPend = true; }
        }

        public bool PendingOp
        {
            get { return _bPend; }
            set { _bPend = value; }
        }

        public bool Exception
        {
            get { return _bEx; }
            set { _bEx = value; }
        }

        public decimal A
        {
            get { return _dA; }
            set { _dA = value; }
        }

        public decimal B
        {
            get { return _dB; }
            set { _dB = value; }
        }

        public decimal Result
        {
            get { return _dResult; }
            set { _dResult = value; }
        }

    // Constructors
        public CCalculator()
        {
            _bPend = false;
        }

    // Private Methods
        private decimal Add()
        {
            _dResult = _dA + _dB;
            return _dResult;
        }

        private decimal Subtract()
        {
            _dResult = _dA - _dB;
            return _dResult;
        }

        private decimal Multiply()
        {
            _dResult =  _dA * _dB;
            return _dResult;
        }

        private decimal Divide()
        {
            if (_dB == 0)
            {
                _bEx = true;
                throw new Exception("Divide By Zero");
            }
            else
            {
                _dResult = _dA / _dB;
                return _dResult;
            }
        }

    //Public Methods
        public void Update()
        {
            switch (_sOp)
            {
                case "+":
                    this.Add();
                    break;
                case "-":
                    this.Subtract();
                    break;
                case "*":
                    this.Multiply();
                    break;
                case "/":
                    try
                    {
                        this.Divide();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
            }
            _bPend = false;
            _dA = _dResult;
        }

        public decimal Sign(decimal dA)
        {
            return dA * -1;
        }

        public decimal SquareRoot(decimal dA)
        {
            return (decimal)Math.Sqrt(decimal.ToDouble(dA));
        }

        public decimal Reciprocal(decimal dA)
        {
            return 1 / dA;
        }

        public void Clear()
        {
            _dA = 0;
            _dB = 0;
            _dResult = 0;
            _sOp = string.Empty;
            _bPend = false;
            _bEx = false;
        }
    }
}
