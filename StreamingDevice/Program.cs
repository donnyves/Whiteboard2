using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingDevice
{
    public interface IStreamingDevice
    {
        string devicename { get; set; }
        bool Play();
        void Pause();
        void fFwd();
        void Rewind();
        bool Stop();
    }
    public class EightTrack : IStreamingDevice
    {
        //constructor

        public EightTrackPlayer(string PlayerName)
        {
            public string DeviceName { set => DeviceName = "8trck"; get }
    }

    }
    public bool Play()
    {

    }
    public void Pause()
    {

    }
    public void fFwd()
    {

    }
    public void Rewind()
    {

    }
    public bool Stop()
    {
    return false;
    }


}



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
