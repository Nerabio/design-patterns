using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }
}
