using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace ExerciseUI
{
    public partial class Program : Form
    {
        private Panel panel1;
        private CheckedListBox checkedListBox1;
        private ProgressBar progressBar1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private int checks = 4;

        public Program()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(0, 435);
            CheckBoxSetUp(checkedListBox1);
            ProgressBarSetUp(progressBar1);
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }

        private void CheckBoxSetUp(System.Windows.Forms.CheckedListBox checkedListBox1)
        {
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Items.Add("Morning", CheckState.Unchecked);
            checkedListBox1.Items.Add("Lunch", CheckState.Unchecked);
            checkedListBox1.Items.Add("Dinner", CheckState.Unchecked);
            checkedListBox1.Items.Add("Jog", CheckState.Unchecked);
        }

        private void ProgressBarSetUp(System.Windows.Forms.ProgressBar progressBar1)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = checks;


        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 269);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(710, 40);
            this.progressBar1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 85);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(107, 184);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 266);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Program";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                progressBar1.Value++;
            }
            else
            {
                progressBar1.Value--;
            }
        }
    }
}
