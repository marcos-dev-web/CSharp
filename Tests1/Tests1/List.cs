
namespace Tests1 {
    class List<T> {

        private T[] _array;
        public List() {}

        public List(T[] array) {
            _array = array;
        }

        private bool AreEqual( int currentIndex ) {
            if ( _array.Length - 1 < currentIndex ) {
                T e1 = _array[currentIndex];
                T e2 = _array[currentIndex + 1];

                bool r = e1.Equals(e2);

                return r;
            }
            else {
                T e1 = _array[currentIndex];
                T e2 = _array[^2];

                bool r = e1.Equals(e2);

                return r;
            }
        }

        public bool ArrayIsEqual() {
            if (_array == null) {
                return false;
            }

            if ( _array.Length == 1 ) {
                return true;
            }

            for ( int i = 0; i < _array.Length; i++ ) {
                if ( !AreEqual(i) ) {
                    return false;
                }
            }
            return true;
        }

        public bool ArrayIsEqual( T[] array ) {
            _array = array;

            if ( array.Length == 1 ) {
                return true;
            }

            for ( int i = 0; i < array.Length; i++ ) {
                if ( !AreEqual(i) ) {
                    return false;
                }
            }
            return true;
        }
    }
}
