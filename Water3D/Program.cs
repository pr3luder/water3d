using System;

namespace Water3D
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (GraphicsSystem game = new GraphicsSystem())
            {
                game.Run();
            }
        }
    }
}

