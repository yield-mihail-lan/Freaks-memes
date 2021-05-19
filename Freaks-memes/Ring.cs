using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Freaks_memes
{
    public partial class Ring : Form
    {
        private readonly GameState gameState;
        private readonly Dictionary<string, Bitmap> bitmaps = new Dictionary<string, Bitmap>();
        private readonly HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private int tickCount;
        public Ring()
        {
            gameState = new GameState();
            BackColor = Color.Coral;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
            var imagesDirectory = new DirectoryInfo("Skinы");
            bitmaps.Add("baretskyskin.png", (Bitmap) Image.FromFile("C://Users//1//source//repos//Freaks-memes//Skinы/baretskyskin.png"));
            var timer = new Timer();
            timer.Interval = 15;
            timer.Tick += TimerTick;
            timer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = "Freaks-memes";
            DoubleBuffered = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            Game.KeyPressed = e.KeyCode;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
            Game.KeyPressed = pressedKeys.Any() ? pressedKeys.Min() : Keys.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var a in gameState.Animations)
                e.Graphics.DrawImage(bitmaps[a.Freak.GetSkinFile()], a.Location);
            e.Graphics.ResetTransform();
        }

        private void TimerTick(object sender, EventArgs eventArgs)
        {
            if (tickCount == 0) gameState.BeginAct();
            foreach (var e in gameState.Animations)
                e.Location = new Point(e.Location.X + 4 * e.Command.DeltaX, e.Location.Y + 4 * e.Command.DeltaY);
            if (tickCount == 7)
                Game.Freak = new Stas(gameState.Animations.Single().Location.X, gameState.Animations.Single().Location.Y);
            tickCount++;
            if (tickCount == 8) tickCount = 0;
            Invalidate();
        }
    }
}
