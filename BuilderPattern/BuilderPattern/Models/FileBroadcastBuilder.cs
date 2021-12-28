using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class FileBroadcastBuilder : IBroadcastBuilder
    {
        public FileBroadcastBuilder(string url)
        {
            broadcast.type = BroadcastType.FILE;
            broadcast.url = url;
        }

        public Broadcast broadcast { get; private set; } = new Broadcast();

        public IBroadcastBuilder BuildDisplayText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                broadcast.displayText = "";
                broadcast.displayTextOption = false;
            }
            else
            {
                broadcast.displayText = text;
                broadcast.displayTextOption = true;
            }
            return this;
        }

        public IBroadcastBuilder BuildEndChime()
        {
            broadcast.endChime = true;
            return this;
        }

        public IBroadcastBuilder BuildRepeat(int repeat, int interval)
        {
            broadcast.repeat = repeat;
            broadcast.repeatInterval = interval;
            return this;
        }

        public IBroadcastBuilder BuildStartChime()
        {
            broadcast.startChime = true;
            return this;
        }

        public Broadcast Builder()
        {
            return this.broadcast;

        }

        public IBroadcastBuilder BuildTransmitter(string id)
        {
            broadcast.AddTarget(id);
            return this;
        }
    }
}
