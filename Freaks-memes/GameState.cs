using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Freaks_memes
{ 
    public class GameState
    {
        public const int ElementSize = 16;
        public List<FreakAnimation> Animations = new List<FreakAnimation>();

        public void BeginAct()
        {
            Animations.Clear();
            var freak = Game.Freak;
            var command = freak.Act(freak.X, freak.Y);
            Animations.Add(
                new FreakAnimation
                {
                    Command = command,
                    Freak = freak,
                    Location = new Point(freak.X, freak.Y),
                    TargetLogicalLocation = new Point(freak.X + command.DeltaX, freak.Y+ command.DeltaY)
                });
        }
    }
}
