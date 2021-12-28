using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class TTSBroadcastBuilder : IBroadcastBuilder
    {
        public Broadcast broadcast { get; private set; } = new Broadcast();

        public TTSBroadcastBuilder(string text)
        {
            broadcast.type = BroadcastType.TTS;
            broadcast.url = Text2Url(text);
            broadcast.cid = Guid.NewGuid().ToString().ToLower();
        }

        private string Text2Url(string text)
        {
            // TODO: Text to speech will change txt to a wav file, upload to blob storage immeadiatley and get url.
            return text;
        }

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
