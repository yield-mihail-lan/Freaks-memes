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
        public double X { get; set; }
        public double Y { get; set; }
        public Stas(double health, double strength, double velocity, double hitReboot, double skillReboot, double x, double y)
        {

        }

        public void Act(Keys key, IFreak opponent)
        {
            switch (key)
            {
                case Keys.Up:
                    if (Y - 1 >= 0) Y--;
                    break;
                case Keys.Down:
                    if (Y + 1 <= 500) Y++;
                    break;
                case Keys.Left:
                    if (X - 1 >= 0) X--;
                    break;
                case Keys.Right:
                    if (X + 1 <= 1000) X++;
                    break;
                case Keys.Space:
                    //hit
                    break;
                case Keys.B:
                    //skill
                    break;
            }
        }
    }
}
