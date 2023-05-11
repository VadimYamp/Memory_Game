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

namespace MG_Z
{
    public partial class Screen : Form
    {
        Random ran = new Random();
        List<string> icons = new List<string>()
        {
        "'א","'ב","'ג","'ד","'ה","'ו","'ק","'ק",
        "'א","'ב","'ג","'ד","'ה","'ו","'ר","'ר",
        "'ז","'ח","'ט","'י","'כ","'ל","'ש","'ש",
        "'ז","'ח","'ט","'י","'כ","'ל","'ת","'ת",
        "'מ","'נ","'ס","'ע","'פ","'צ","0" ,"0" ,
        "'מ","'נ","'ס","'ע","'פ","'צ","1" ,"1" ,
        "2" ,"3" ,"4" ,"5" ,"6" ,"7" ,"8" ,"9" ,
        "2" ,"3" ,"4" ,"5" ,"6" ,"7" ,"8" ,"9" 
        };

        Label click0, click1;
        public Screen()
        {
            InitializeComponent();
            Assign();
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
            click0.BackColor = Color.FromArgb(096, 000, 096);
            click1.BackColor = Color.FromArgb(096, 000, 096);
            Nb.Value++;
            //click0 = null;
            //click1 = null;
            MessageBox.Show("!!!ניצחון");
            Close();
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
                click0.BackColor = Color.FromArgb(096,000,096);
                click1.BackColor = Color.FromArgb(096, 000, 096);
                Nb.Value++;
                click0 = null;
                click1 = null;
            }
            else
            Timer.Start();
        }

        private void T_T(object sender, EventArgs e)
        {
            Nc.Value++;
            Timer.Stop();
            click0.ForeColor = click0.BackColor;
            click1.ForeColor = click1.BackColor;
            click0 = null;
            click1 = null;
        }

        private void Assign()
        {
            Label L;
            int ran_num;

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