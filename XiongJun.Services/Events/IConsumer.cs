using System;
using System.Collections.Generic;
using System.Text;

namespace XiongJun.Services.Events
{
   public interface IConsumer<T>
    {
        void HandleEvent(T eventMessage);
    }
}
