namespace Freaks_memes
{
    public interface IFreak
    {
        int Health { get; set; }
        int Strength { get; set; }
        int Velocity { get; set; }
        double HitReboot { get; set; }
        double SkillReboot { get; set; }
        int X { get; set; }
        int Y { get; set; }
        void Act(Keys key, IFreak opponent);
    }
}