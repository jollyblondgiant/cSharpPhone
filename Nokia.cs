using System;
namespace Phon
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
        {}
        public string Ring()
        {
            return $"...{ringTone}...";
        }
        public string Unlock()
        {
            return $"Nokia {versionNumber} unlocked with Guttural Scream";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("#####################");
            Console.WriteLine($"Nokia {versionNumber}");
            Console.WriteLine($"Battery Percentage: {batteryPercentage}");
            Console.WriteLine($"Carrier: {carrier}");
            Console.WriteLine($"Ring Tone: {ringTone}");
            Console.WriteLine("#####################");
        }
    }
}