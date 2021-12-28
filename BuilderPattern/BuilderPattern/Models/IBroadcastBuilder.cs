using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public interface IBroadcastBuilder
    {
        IBroadcastBuilder BuildStartChime();
        IBroadcastBuilder BuildEndChime();
        IBroadcastBuilder BuildRepeat(int repeat, int interval);
        IBroadcastBuilder BuildDisplayText(string text);
        IBroadcastBuilder BuildTransmitter(string id);

        Broadcast Builder();
    }
}
