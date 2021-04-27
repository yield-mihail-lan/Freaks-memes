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
    public partial class Form2 : Form
    {
        public Form2()
        {
            var name = new Label
            {
                Text = "Стас Барецкий",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                Dock = DockStyle.Fill
            };

            //create and add GIF
            //var skin = new Label
            //{
            //    Image = Image.FromFile("C://Users//1//source//repos//Freaks-memes//Images/baretsky.bmp")
            //};

            var statistic = new Label
            {
                Text = "Характеристики:",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var easy = new Label
            {
                Text = "1 уровень",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Green,
                Dock = DockStyle.Fill
            };            
            
            var hard = new Label
            {
                Text = "2 уровень",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Red,
                Dock = DockStyle.Fill
            };            
            
            var strength = new Label
            {
                Text = "Сила",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var easyStrength = new Label
            {
                Text = "5",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Green,
                Dock = DockStyle.Fill
            };            
            
            var hardStrength = new Label
            {
                Text = "8",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Red,
                Dock = DockStyle.Fill
            };            
            
            var health = new Label
            {
                Text = "Здоровье",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var easyHealth = new Label
            {
                Text = "200",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Green,
                Dock = DockStyle.Fill
            };            
            
            var hardHealth = new Label
            {
                Text = "300",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Red,
                Dock = DockStyle.Fill
            };            
            
            var hitReboot = new Label
            {
                Text = "Скорость удара",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var easyHitReboot = new Label
            {
                Text = "1,5",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Green,
                Dock = DockStyle.Fill
            };            
            
            var hardHitReboot = new Label
            {
                Text = "1",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Red,
                Dock = DockStyle.Fill
            };            
            
            var velocity = new Label
            {
                Text = "Скорость",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var velocityValue = new Label
            {
                Text = "низкая",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Brown,
                Dock = DockStyle.Fill
            };

            var velocityValueCopy = new Label
            {
                Text = "низкая",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Brown,
                Dock = DockStyle.Fill
            };

            var skill = new Label
            {
                Text = "Cпособность",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var skillValue = new Label
            {
                Text = "Разрывает банку с пивом, что замедляет соперника на 10с",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Gold,
                Dock = DockStyle.Fill
            };

            var skillValueCopy = new Label
            {
                Text = "Разрывает банку с пивом, что замедляет соперника на 10с",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Gold,
                Dock = DockStyle.Fill
            };

            var freqSkill = new Label
            {
                Text = "Частота способности",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Yellow,
                Dock = DockStyle.Fill
            };            
            
            var easyFreqSkill = new Label
            {
                Text = "30с",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Green,
                Dock = DockStyle.Fill
            };            
            
            var hardFreqSkill = new Label
            {
                Text = "20с",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Red,
                Dock = DockStyle.Fill
            };

            var button = new Button
            {
                Text = "Назад",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkBlue,
                Size = new Size(ClientSize.Width / 5, ClientSize.Height / 8)
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();

            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));

            table.Controls.Add(button, 0, 0);
            table.Controls.Add(name, 1, 0);
            //table.Controls.Add(skin, 2, 0);
            table.Controls.Add(statistic, 0, 1);
            table.Controls.Add(easy, 1, 1);
            table.Controls.Add(hard, 2, 1);
            table.Controls.Add(strength, 0, 2);
            table.Controls.Add(easyStrength, 1, 2);
            table.Controls.Add(hardStrength, 2, 2);
            table.Controls.Add(health, 0, 3);
            table.Controls.Add(easyHealth, 1, 3);
            table.Controls.Add(hardHealth, 2, 3);
            table.Controls.Add(hitReboot, 0, 4);
            table.Controls.Add(easyHitReboot, 1, 4);
            table.Controls.Add(hardHitReboot, 2, 4);
            table.Controls.Add(velocity, 0, 5);
            table.Controls.Add(velocityValue, 1, 5);
            table.Controls.Add(velocityValueCopy, 2, 5);
            table.Controls.Add(skill, 0, 6);
            table.Controls.Add(skillValue, 1, 6);
            table.Controls.Add(skillValueCopy, 2, 6);
            table.Controls.Add(freqSkill, 0, 7);
            table.Controls.Add(easyFreqSkill, 1, 7);
            table.Controls.Add(hardFreqSkill, 2, 7);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            InitializeComponent();

            button.Click += (sender, eventArgs) =>
            {
                this.Hide();
                new Form1()
                {
                    WindowState = FormWindowState.Maximized,
                    BackColor = Color.Gray
                }.Show();
            };

            FormClosed += (sender, eventArgs) => Application.Exit();
        }
    }
}