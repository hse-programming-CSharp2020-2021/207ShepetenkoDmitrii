using System;

namespace Task2
{    

    public class PlayIsStartedEventArgs : EventArgs
    {
        public int Number { get; set; }
    }

    class Bandmaster 
    {
        
        public event EventHandler<PlayIsStartedEventArgs> ev;
        public void StartPlay()
        {
            Random rnd = new Random();
            ev?.Invoke(this, new PlayIsStartedEventArgs() { Number = rnd.Next(2,6)} );
        }
    }

    public abstract class OrchestraPlayer
    {
        public string Name { get; set; }
        public abstract void PlayIsStatedEventHandler(object sender, PlayIsStartedEventArgs e);
    }

    class Violinist : OrchestraPlayer
    {
        public override void PlayIsStatedEventHandler(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Violinist {Name}  plays composition {e.Number}");
        }
    }

    class Hornist: OrchestraPlayer
    {
        public override void PlayIsStatedEventHandler(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Hornist {Name}  plays composition {e.Number}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bandmaster mas = new Bandmaster();
            Random r = new Random();
            OrchestraPlayer[] players = new OrchestraPlayer[5];
            for(int i = 0; i < players.Length; i++)
            {
                if (r.Next(0, 2) == 0)
                    players[i] = new Violinist() { Name = r.Next(100, 900).ToString() };
                else
                    players[i] = new Hornist() { Name = r.Next(100, 900).ToString() };
                mas.ev += players[i].PlayIsStatedEventHandler;
            }
            mas.StartPlay();
         }
    }
}
