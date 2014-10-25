using System;
using SFML.Graphics;

namespace Nations.States
{
    public class TestState : State
    {
        public override void Update()
        {
        }
        public override void Render()
        {
            renderWindow.Clear(new Color(234, 225, 225));

            renderWindow.Display();
        }
        public TestState(Game game)
            : base(game)
        {
        }
    }
}
