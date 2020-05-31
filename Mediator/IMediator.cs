﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // Интерфейс Посредника предоставляет метод, используемый компонентами для
    // уведомления посредника о различных событиях. Посредник может реагировать
    // на эти события  и передавать исполнение другим компонентам.
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
