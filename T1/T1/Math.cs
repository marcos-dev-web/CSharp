using System.Globalization;

namespace T1 {
    internal class Math {
        private double _number;

        internal Math( double number ) {
            _number = number;
        }
        internal double Number {
            get => _number;
            set {
                if ( value > 0 && value < 10 ) {
                    _number = value;
                }
            }
        }

        internal Math Increment( double value ) {
            _number += value;
            return this;
        }

        internal Math Decrement( double value ) {
            _number -= value;
            return this;
        }

        public override string ToString() {
            return _number.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
