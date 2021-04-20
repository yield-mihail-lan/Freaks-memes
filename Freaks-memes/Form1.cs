using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freaks_memes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var label = new Label
            {
                Text = "Freaks and memes",
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Arial", 30, FontStyle.Bold),
                ForeColor = Color.DeepSkyBlue,
                Dock = DockStyle.Fill
            };

            var text = new Label
            {
                Text = "Выбери своего бойца:",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Bisque,
                Dock = DockStyle.Fill
            };

            var button1 = new Button
            {
                Text = "Стас Барецкий",
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Red,
                BackColor = Color.DarkGray,
                Dock = DockStyle.Fill,
                Image = Image.FromFile("C://Users//1//source//repos//Freaks-memes//Images/baretsky.bmp"),
                ImageAlign = ContentAlignment.TopCenter,
                TextImageRelation = TextImageRelation.TextAboveImage
            };

            var button2 = new Button
            {
                Text = "Виктор Пузо",
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Green,
                BackColor = Color.DarkGray,
                Dock = DockStyle.Fill,
                Image = Image.FromFile("C://Users//1//source//repos//Freaks-memes//Images/victorpuzo.bmp"),
                ImageAlign = ContentAlignment.TopCenter,
                TextImageRelation = TextImageRelation.TextAboveImage
            };

            var button3 = new Button
            {
                Text = "Наталья Морская-Пехота",
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.BlueViolet,
                BackColor = Color.DarkGray,
                Dock = DockStyle.Fill,
                Image = Image.FromFile("C://Users//1//source//repos//Freaks-memes//Images/natamorpeh.bmp"),
                ImageAlign = ContentAlignment.TopCenter,
                TextImageRelation = TextImageRelation.TextAboveImage
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();

            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));

            table.Controls.Add(label, 1, 0);
            table.Controls.Add(text, 1, 1);
            table.Controls.Add(button1, 0, 2);
            table.Controls.Add(button2, 1, 2);
            table.Controls.Add(button3, 2, 2);
            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            InitializeComponent();

            FormClosing += (sender, eventArgs) =>
            {
                var result = MessageBox.Show("Выйти?", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    eventArgs.Cancel = true;
            };
        }
    }
}