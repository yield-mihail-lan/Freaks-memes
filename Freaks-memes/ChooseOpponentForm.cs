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
    public partial class ChooseOpponentForm : Form
    {
        public ChooseOpponentForm()
        {
            var label = new Label
            {
                Text = "Freaks and memes",
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Arial", 30, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                Dock = DockStyle.Fill
            };

            var text = new Label
            {
                Text = "Выбери своего соперника:",
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
                Dock = DockStyle.Fill,
                Size = new Size(ClientSize.Width / 2, ClientSize.Height / 3),
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
                Dock = DockStyle.Fill,
                Image = Image.FromFile("C://Users//1//source//repos//Freaks-memes//Images/natamorpeh.bmp"),
                ImageAlign = ContentAlignment.TopCenter,
                TextImageRelation = TextImageRelation.TextAboveImage
            };

            var flag = new CheckBox
            {
                Text = "1 уровень",
                ForeColor = Color.Green,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(ClientSize.Width / 6, ClientSize.Height / 6),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoCheck = true,
                Checked = false,
                CheckAlign = ContentAlignment.MiddleCenter,
                Size = new Size(140, 30),
                Appearance = Appearance.Button
            };

            var info = new ComboBox();
            info.Text = "Информация о фриках";
            info.Items.Add("Стас Барецкий");
            info.Items.Add("Виктор Пузо");
            info.Items.Add("Наталья Морская-Пехота");
            info.Dock = DockStyle.Top;

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();

            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));

            table.Controls.Add(flag, 0, 0);
            table.Controls.Add(label, 1, 0);
            table.Controls.Add(info, 1, 1);
            table.Controls.Add(text, 1, 1);
            table.Controls.Add(button1, 0, 2);
            table.Controls.Add(button2, 1, 2);
            table.Controls.Add(button3, 2, 2);
            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            InitializeComponent();

            button1.Click += (sender, eventArs) =>
            {
                //Add remembering
            };

            button2.Click += (sender, eventArs) =>
            {
                //Add remembering
            };

            button3.Click += (sender, eventArs) =>
            {
                //Add remembering
            };

            flag.CheckedChanged += (sender, eventArgs) =>
            {
                if (flag.Checked)
                {
                    flag.Text = "2 уровень";
                    flag.ForeColor = Color.Red;
                    //Add remembering
                }
                else
                {
                    flag.Text = "1 уровень";
                    flag.ForeColor = Color.Green;
                    //Add remembering
                }
            };

            info.SelectedIndexChanged += (sender, eventArgs) =>
            {
                var selectedFreak = info.SelectedItem.ToString();
                switch (selectedFreak)
                {
                    case "Стас Барецкий":
                        this.Hide();
                        new StasInfoForm()
                        {
                            WindowState = FormWindowState.Maximized,
                            BackColor = Color.Gray
                        }.Show();
                        break;
                    case "Виктор Пузо":
                        this.Hide();
                        new VictorInfoForm()
                        {
                            WindowState = FormWindowState.Maximized,
                            BackColor = Color.Gray
                        }.Show();
                        break;
                    case "Наталья Морская-Пехота":
                        this.Hide();
                        new NataliaInfoForm()
                        {
                            WindowState = FormWindowState.Maximized,
                            BackColor = Color.Gray
                        }.Show();
                        break;
                }
            };

            FormClosed += (sender, eventArgs) => Application.Exit();
            InitializeComponent();
        }
    }
}
