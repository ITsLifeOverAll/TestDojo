using System.Collections;

namespace TestDojoTests.DBTestUtils
{
    public class TestDbEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;

        public TestDbEnumerator(IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public T Current
        {
            get
            {
                return _inner.Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return _inner.Current;
            }
        }

        public void Dispose()
        {
            // Do not dispose the inner enumerator, since it might be enumerated again, 
            // reset it instead
            _inner.Reset();
        }

        public bool MoveNext()
        {
            return _inner.MoveNext();
        }

        public void Reset()
        {
            _inner.Reset();
        }
    }
}
