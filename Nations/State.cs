using System;
using SFML.Graphics;
using SFML.Window;

namespace Nations
{
    public abstract class State
    {
        RenderTarget renderTarget;

        public abstract void Update();
        public abstract void Render();
        public State(Game game)
        {
            renderTarget = game.renderWindow;
        }
    }
}
