using System;
namespace Phon
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string verstionNumber, int batteryPercentage, string carrier, string ringTone): base(verstionNumber, batteryPercentage, carrier, ringTone){}
        public string Ring()
        {
            return $"...{ringTone}...";
        }
        public string Unlock()
        {
            return $"Galaxy {versionNumber} unlocked with Blood Sacrifice";
        }
        public override void DisplayInfo()
        {

            Console.WriteLine("#####################");
            Console.WriteLine($"Galaxy {versionNumber}");
            Console.WriteLine($"Battery Percentage: {batteryPercentage}");
            Console.WriteLine($"Carrier: {carrier}");
            Console.WriteLine($"Ring Tone: {ringTone}");
            Console.WriteLine("#####################");
        }
    }
}