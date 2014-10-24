using System;

namespace Nations.States
{
    public class TestState : State
    {
        public override void Update()
        {
            Console.WriteLine("update");
        }
        public override void Render()
        {
            Console.WriteLine("render");
        }
        public TestState(Game game)
            : base(game)
        {
        }
    }
}
