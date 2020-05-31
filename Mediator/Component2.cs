﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // Конкретные Компоненты реализуют различную функциональность. Они не
    // зависят от других компонентов. Они также не зависят от каких-либо
    // конкретных классов посредников.
    public class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");

            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");

            this._mediator.Notify(this, "D");
        }
    }
}
