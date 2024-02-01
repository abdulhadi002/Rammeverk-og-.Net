namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            
            IHarborSimulation simulation = new HarborSimulation();
            simulation.Initialize();
            simulation.Start();
            Console.WriteLine("Status: " + simulation.GetStatus());
            simulation.Pause();
            Console.WriteLine("Status: " + simulation.GetStatus());
            simulation.Resume();
            Console.WriteLine("Status: " + simulation.GetStatus());
            simulation.Stop();

        }
    }
}
