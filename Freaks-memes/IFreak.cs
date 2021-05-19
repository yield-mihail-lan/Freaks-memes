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
        int X { get; set; }
        int Y { get; set; }
        FreakCommand Act(int x, int y);
        string GetSkinFile();
    }
}
