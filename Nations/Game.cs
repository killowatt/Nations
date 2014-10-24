using System;
using System.Diagnostics;
using SFML.Graphics;
using SFML.Window;
using Nations.States;

namespace Nations
{
    public class Game
    {
        State currentState;
        internal RenderWindow renderWindow; // should this be CamelCase?

        Stopwatch time;
        bool running;
        double updateRate;

        public Game()
        {
            currentState = new TestState(this);
            renderWindow = new RenderWindow(new VideoMode(1280, 720), "Nations");

            // Loop
            time = new Stopwatch();
            running = true;
            updateRate = 1.0 / 60.0;

            time.Start();
            double previous = time.Elapsed.TotalSeconds;
            double lag = 0;

            while (running)
            {
                double current = time.Elapsed.TotalSeconds;
                double elapsed = current - previous;
                previous = current;
                lag += elapsed;

                while (lag >= updateRate)
                {
                    currentState.Update();
                    lag -= updateRate;
                }

                currentState.Render();
            }
        }
    }
}
