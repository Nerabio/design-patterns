﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Возвращает ключ текущего элемента
        public abstract int Key();

        // Возвращает текущий элемент.
        public abstract object Current();

        // Переходит к следующему элементу.
        public abstract bool MoveNext();

        // Перематывает Итератор к первому элементу.
        public abstract void Reset();
    }
}
