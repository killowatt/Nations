using System;
using System.Diagnostics;
using SFML.Graphics;
using SFML.Window;
using Nations.Common;
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

        public void Close()
        {
            running = false;
            renderWindow.Close();
        }

        #region Events
        void closed(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        public Game()
        {
            Settings settings = Settings.Load("settings.txt");

            renderWindow = new RenderWindow(new VideoMode(settings.Width, settings.Height), "Nations", Styles.Close);
            renderWindow.Closed += closed;
            
            currentState = new TestState(this);

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
                    renderWindow.DispatchEvents();
                    currentState.Update();
                    lag -= updateRate;
                }

                currentState.Render();
            }
        }
    }
}
