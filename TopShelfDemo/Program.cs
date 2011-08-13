using Topshelf;

namespace TopShelfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>                                 //1
            {
                x.Service<TownCrier>(s =>                        //2
                {
                    s.SetServiceName("tc");                       //3
                    s.ConstructUsing(name => new TownCrier());     //4
                    s.WhenStarted(tc => tc.Start());              //5
                    s.WhenStopped(tc => tc.Stop());               //6
                });
                x.RunAsLocalSystem();                            //7

                x.SetDescription("Sample Topshelf Host");        //8
                x.SetDisplayName("Stuff");                       //9
                x.SetServiceName("stuff");                       //10
            });                                                  //11
        }
    }
}
