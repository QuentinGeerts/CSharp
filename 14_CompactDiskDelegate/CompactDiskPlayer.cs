using System;

namespace _14_CompactDiskDelegate
{
    public delegate void CDPlayerProgram();

    internal class CompactDiskPlayer
    {
        public CompactDisk CurrentDisk { get; set; }
        public CDPlayerProgram Program = null;

        public CDPlayerProgram SelectTrack(int number)
        {
            return delegate ()
            {
                Console.WriteLine($"Nous lisons la piste {number} au temps {CurrentDisk.TimerTrack[number - 1]}");
            };
        }

        public void AddTrack(CDPlayerProgram selectedTrack)
        {
            Program += selectedTrack;
        }

        public void Play()
        {
            if (Program != null) Program();
        }
    }
}