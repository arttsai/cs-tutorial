using System;
using System.Threading.Channels;

namespace Engine2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var engine = new Engine();
            engine.StatusChanged += (obj, e) => Console.WriteLine($"{e.Status}");

        }
    }
    
    public enum Status { Started, Stopped }
    public delegate void StatusChange(object sender, EngineEventArgs args);
    
    public class EngineEventArgs : EventArgs
    {
        public Status Status { get; private set; }
        
        public EngineEventArgs(Status s)
        {
            Status = s; 
        }
    }
    
    public class Engine
    {
        public event StatusChange StatusChanged;
        
        public void Start()
        {
            StatusChanged?.Invoke(this, new EngineEventArgs(Status. Started));
        }
        public void Stop()
        {
            StatusChanged?.Invoke(this, new EngineEventArgs(Status.Stopped));
        } 
    }
}