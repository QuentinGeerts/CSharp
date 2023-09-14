namespace _14_CompactDiskDelegate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cd1 = new CompactDisk(0, 120, 340, 720, 980);

            var player = new CompactDiskPlayer();
            player.CurrentDisk = cd1;

            player.AddTrack(player.SelectTrack(1));
            player.AddTrack(player.SelectTrack(4));
            player.AddTrack(player.SelectTrack(3));
            player.AddTrack(player.SelectTrack(2));
            player.AddTrack(player.SelectTrack(5));

            player.Play();
        }
    }
}