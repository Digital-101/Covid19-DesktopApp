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

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Covid19 Keywords responses
        string[] What = new string[]
        {
            "Covid is a virus.",
            "Covid is an infectious disease.",
            "Corona Virus are a group of related diseases in mammals and birds."
        };

        string[] Prevent = new string[]
        {
            "Wear a Mask.",
            "Sanitize or wash ur hands with soap.",
            "Stay home if you feel sick."
        };

        string[] Protect = new string[]
        {
            "Wash your hands.",
            "Maintain safe distance.",
            "Cover your mouth and nose when outside."
        };

        string[] Symptoms = new string[]
        {
            "Covid19 symptoms include cough and fever.",
            "Corona Virus symptom include sore throat."
        };

        Random random = new Random(); // Randomize
       
        //Quit App
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            //Application.ExitThread();
            this.Close();
        }

        //Reset Button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Dispose(false);
        }


        // Ask Question
        private void BtnAsk_Click(object sender, EventArgs e)
        {
            // Randomly generated responses according to keywords
            if (txtQuestion.Text.Contains("what"))
            {
                int index = random.Next(What.Length);
                lblResponse.Text = What[index];
            }
            else if (txtQuestion.Text.Contains("prevent"))
            {
                int index = random.Next(Prevent.Length);
                lblResponse.Text = Prevent[index];
            }
            else if (txtQuestion.Text.Contains("protect"))
            {
                int index = random.Next(Protect.Length);
                lblResponse.Text = Protect[index];
            }
            else if (txtQuestion.Text.Contains("symptom"))
            {
                int index = random.Next(Symptoms.Length);
                lblResponse.Text = Symptoms[index];
            }
        }

    }
}
