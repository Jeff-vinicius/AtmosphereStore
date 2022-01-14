using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atmosphere.Core.Messages
{
    public class Event : Message, INotification
    {
        public DateTime TimeStamp { get; private set; }

        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
