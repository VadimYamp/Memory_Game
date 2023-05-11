using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_X
{
    public partial class Screen : Form
    {
        byte X, Y, Z;
        Label L;
        int ran_num;
        Random ran = new Random();
        List<string> icons = new List<string>()
        {
        "א'","ב'","ז'","ח'","מ'","נ'",
        "א'","ב'","ז'","ח'","מ'","נ'",
        "ג'","ד'","ט'","י'","ס'","ע'",
        "ג'","ד'","ט'","י'","ס'","ע'",
        "ה'","ו'","כ'","ל'","פ'","צ'",
        "ה'","ו'","כ'","ל'","פ'","צ'"
        };

        Label click0,click1;
        public Screen()
        {
            InitializeComponent();
            Assign();
        }

        private void L_C(object sender, EventArgs e)
        {
            if (click0 != null && click1 != null)
                return;

            Label click = sender as Label;
            if (click == null)
                return;

            if (click.ForeColor == Color.White)
                return;

            if (click0 == null)
            {
                click0 = click;
                click.ForeColor = Color.White;
                return;
            }
            click1 = click;
            click1.ForeColor = Color.White;
            Win();

            if (click0.Text == click1.Text)
            {
                click0.BackColor = Color.FromArgb(0x80, 0x80, 0x00);
                click1.BackColor = Color.FromArgb(0x80, 0x80, 0x00);
                Nb.Value++;
                click0 = null;
                click1 = null;
            }
            else
                Timer.Start();
        }
        private void Reset_L()
        {
            if (Nc.Value < Nd.Value)
            {
                Nd.Value = Nc.Value;
            }
            Ld.Visible = true;
            Nd.Visible = true;
            Nc.Value = -1;
            Nb.Value = 0;
            Na.Value++;

            switch (Na.Value % 5)
            {
                case 0:
                    X = 0xFF; Y = 0xFF; Z = 0xFF;
                    break;

                case 1:
                    X = 0x00; Y = 0xFF; Z = 0xFF;
                    break;

                case 2:
                    X = 0xFF; Y = 0x00; Z = 0xFF;
                    break;

                case 3:
                    X = 0xFF; Y = 0xFF; Z = 0x00;
                    break;

                case 4:
                    X = 0x00; Y = 0xFF; Z = 0x80;
                    break;

                default:
                    break;
            }
            La.ForeColor = Color.FromArgb(Y, Z, X);
            Lb.ForeColor = Color.FromArgb(Y, Z, X);
            Lc.ForeColor = Color.FromArgb(Y, Z, X);
            Ld.ForeColor = Color.FromArgb(Y, Z, X);
            Na.ForeColor = Color.FromArgb(Y, Z, X);
            Nb.ForeColor = Color.FromArgb(Y, Z, X);
            Nc.ForeColor = Color.FromArgb(Y, Z, X);
            Nd.ForeColor = Color.FromArgb(Y, Z, X);

            click0.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            click1.BackColor = Color.FromArgb(0x00, 0x00, 0x80);

            L00.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L01.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L02.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L03.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L04.BackColor = Color.FromArgb(0x00, 0x00, 0x80);

            L05.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L06.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L07.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L08.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L09.BackColor = Color.FromArgb(0x00, 0x00, 0x80);

            L10.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L11.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L12.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L13.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L14.BackColor = Color.FromArgb(0x00, 0x00, 0x80);

            L15.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L16.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L17.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L18.BackColor = Color.FromArgb(0x00, 0x00, 0x80);
            L19.BackColor = Color.FromArgb(0x00, 0x00, 0x80);

            L00.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L01.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L02.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L03.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L04.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);

            L05.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L06.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L07.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L08.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L09.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);

            L10.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L11.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L12.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L13.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L14.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);

            L15.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L16.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L17.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L18.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);
            L19.ForeColor = Color.FromArgb(0x00, 0x00, 0x80);

            Table.Controls[0].Text = null;
            Table.Controls[1].Text = null;
            Table.Controls[2].Text = null;
            Table.Controls[3].Text = null;
            Table.Controls[4].Text = null;

            Table.Controls[5].Text = null;
            Table.Controls[6].Text = null;
            Table.Controls[7].Text = null;
            Table.Controls[8].Text = null;
            Table.Controls[9].Text = null;

            Table.Controls[10].Text = null;
            Table.Controls[11].Text = null;
            Table.Controls[12].Text = null;
            Table.Controls[13].Text = null;
            Table.Controls[14].Text = null;

            Table.Controls[15].Text = null;
            Table.Controls[16].Text = null;
            Table.Controls[17].Text = null;
            Table.Controls[18].Text = null;
            Table.Controls[19].Text = null;
        List<string> icons = new List<string>()
        {
        "א'","ב'","ז'","ח'","מ'","נ'",
        "א'","ב'","ז'","ח'","מ'","נ'",
        "ג'","ד'","ט'","י'","ס'","ע'",
        "ג'","ד'","ט'","י'","ס'","ע'",
        "ה'","ו'","כ'","ל'","פ'","צ'",
        "ה'","ו'","כ'","ל'","פ'","צ'"
        };
            for (int i = 0; i < Table.Controls.Count; i++)
            {
                if (Table.Controls[i] is Label)
                    L = (Label)Table.Controls[i];
                else
                    continue;
                ran_num = ran.Next(0, icons.Count);
                L.Text = icons[ran_num];
                icons.RemoveAt(ran_num);
            }
        }
        private void Win()
        {
            Label L;
            for (int i = 0; i < Table.Controls.Count; i++)
            {
                L = Table.Controls[i] as Label;
                if (L != null && L.ForeColor == L.BackColor)
                return;
            }
            click0.BackColor = Color.FromArgb(0x80, 0x80, 0x00);
            click1.BackColor = Color.FromArgb(0x80, 0x80, 0x00);
            Nb.Value++;

            MessageBox.Show("כל-הכבוד");
            Reset_L();
        }
        private void T_T(object sender, EventArgs e)
        { 
            Timer.Stop();
            Nc.Value++;
            click0.ForeColor = click0.BackColor;
            click1.ForeColor = click1.BackColor;
            click0 = null;
            click1 = null;
        }

        private void Assign()
        {
            for (int i = 0; i < Table.Controls.Count; i++)
            {
                if (Table.Controls[i] is Label)
                    L = (Label)Table.Controls[i];
                else
                    continue;
                ran_num = ran.Next(0, icons.Count);
                L.Text = icons[ran_num];
                icons.RemoveAt(ran_num);
            }
        }
    }
}