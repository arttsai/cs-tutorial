﻿using System;
using System.IO;

namespace Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Engine engine = new Engine();
            engine.RegisterStatusChangeHandler(OnEngineStatusChanged);
            engine.RegisterStatusChangeHandler(OnEngineStatusChanged2);
            engine.Start();
            engine.Stop();
            engine.UnregisterStatusChangeHandler(OnEngineStatusChanged2);
            engine.Start();
        }
        
        private static void OnEngineStatusChanged(Status status)
        {
            Console.WriteLine($"Engine is now {status}");
        }
        private static void OnEngineStatusChanged2(Status status)
        {
            File.AppendAllText(@"c:\temp\engine.log", $"Engine is now {status}\n");
        }
    }
    
    public enum Status { Started, Stopped }
    public delegate void StatusChange(Status status);
    
    public class Engine
    {
        private StatusChange statusChangeHandler;
        public void RegisterStatusChangeHandler(StatusChange handler)
        {
            statusChangeHandler += handler;
        }
        public void UnregisterStatusChangeHandler(StatusChange handler)
        {
            statusChangeHandler -= handler;
        }
        public void Start()
        {
            statusChangeHandler?.Invoke(Status.Started);
        }
        public void Stop()
        {
            statusChangeHandler?.Invoke(Status.Stopped);
        }
    }
    
}