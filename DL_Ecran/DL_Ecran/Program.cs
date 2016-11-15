/*

*/

using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using GHI.Pins;
using System.Threading;

namespace DL_Ecran
{
    public class Program
    {
        public static void Main()
        {
            OutputPort enable = new OutputPort(FEZSpider.Socket11.Pin3, false);

            OutputPort RegisterSelect = new OutputPort(FEZSpider.Socket11.Pin4, false);

            OutputPort D4 = new OutputPort(FEZSpider.Socket11.Pin5, false);
            OutputPort D7 = new OutputPort(FEZSpider.Socket11.Pin6, false);
            OutputPort D5 = new OutputPort(FEZSpider.Socket11.Pin7, false);
            OutputPort D6 = new OutputPort(FEZSpider.Socket11.Pin9, false);

            OutputPort Backlight = new OutputPort(FEZSpider.Socket11.Pin8, false);

            
        }
    }
}
