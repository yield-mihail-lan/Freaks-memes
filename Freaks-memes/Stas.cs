using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freaks_memes
{
    public class Stas : IFreak
    {
        public double Health { get; set; }
        public double Strength { get; set; }
        public double Velocity { get; set; }
        public double HitReboot { get; set; }
        public double SkillReboot { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Stas(int x, int y)
        {
            (X, Y) = (x, y);
        }

        public FreakCommand Act(int x, int y)
        {
            var cmd = new FreakCommand();
            switch (Game.KeyPressed)
            {
                case Keys.Up:
                    if (Y - 1 >= 0) cmd.DeltaY--;
                    break;
                case Keys.Down:
                    if (Y + 1 <= 600) cmd.DeltaY += 3;
                    break;
                case Keys.Left:
                    if (X - 1 >= 0) cmd.DeltaX--;
                    break;
                case Keys.Right:
                    if (X + 1 <= 1000) cmd.DeltaX++;
                    break;
                default:
                    if (Y + 1 <= 600) cmd.DeltaY += 2;
                    break;
                /*case Keys.Space:
                    //hit
                    break;
                case Keys.B:
                    //skill
                    break;*/
            }
            return cmd;
        }

        public string GetSkinFile() => "baretskyskin.png";
    }
}
