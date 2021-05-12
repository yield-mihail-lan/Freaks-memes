using System.Windows.Forms;

namespace Freaks_memes
{
    public interface IFreak
    {
        double Health { get; set; }
        double Strength { get; set; }
        double Velocity { get; set; }
        double HitReboot { get; set; }
        double SkillReboot { get; set; }
        double X { get; set; }
        double Y { get; set; }
        void Act(Keys key, IFreak opponent);
    }
}
