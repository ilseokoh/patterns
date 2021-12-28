using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Broadcast
    {
        public BroadcastType type { get; set; }
        public string cid { get; set; }     // mandatory
        public string url { get; set; }     // madatory
        public bool startChime { get; set; } = false;
        public bool endChime { get; set; } = false;
        public int repeat { get; set; } = 0;
        public int repeatInterval { get; set; } = 0;
        public bool displayTextOption { get; set; } = false;
        public string displayText { get; set; } = string.Empty;
        public List<string> targets { get; set; }

        public void AddTarget(string target)
        {
            // TODO: Check target is available
            targets.Add(target);
        }

        public override string ToString()
        {
            return $"{this.type} Broadcast with option: startChime-{startChime}, endChime={endChime}, repeate-{repeat}times with {repeatInterval} interval ";
        }
    }
}
