using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dynamic_button
{
    public partial class FormDynamicButton : Form
    {
        public FormDynamicButton()
        {
            InitializeComponent();
        }

        void newButton_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Location = new Point(100, 30 * i + 10);
                button.Click += new EventHandler(buttonclickedoneevent);
                button.Tag = i;
                button.Text = i.ToString();
                this.Controls.Add(button);
            }
        }

        void buttonclickedoneevent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (button.Text == i.ToString())
                    {
                        MessageBox.Show(i.ToString());
                        return;
                    }
                }
            }
        }

        void createbuttons(object sender, EventArgs e)
        {
            Button newButton = new Button();
            newButton.Click += new EventHandler(newButton_Clicked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Location = new Point(Height/2, 30 * i + 10);
                button.Click += new EventHandler(createbuttons);
                button.Tag = i;
                button.Text = i.ToString();
                this.Controls.Add(button);
            }
        }
    }
}
