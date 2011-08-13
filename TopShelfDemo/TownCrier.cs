using System;
using System.IO;
using System.Timers;

namespace TopShelfDemo
{
    public class TownCrier
    {
        readonly Timer _timer;
        public TownCrier()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => File.WriteAllText(@"C:\temp\bus\FileBasedTextSender" + DateTime.Now.Millisecond.ToString() + ".txt",
                DateTime.Now.ToString());
        }
        public void Start() { _timer.Start(); }
        public void Stop() { _timer.Stop(); }
    }
}