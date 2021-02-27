using System;
using System.Windows.Forms;

namespace FlowTimer {
    public partial class CalibrationInput : Form {

        public double time;

        public CalibrationInput(double time) {
            this.time = time;
            InitializeComponent();
            this.comboBoxChoco2.Items.AddRange(FF7Util.CHOCO_NAMES);
            this.comboBoxChoco3.Items.AddRange(FF7Util.CHOCO_NAMES);
            this.comboBoxChoco4.Items.AddRange(FF7Util.CHOCO_NAMES);
            this.comboBoxChoco5.Items.AddRange(FF7Util.CHOCO_NAMES);
            this.comboBoxChoco6.Items.AddRange(FF7Util.CHOCO_NAMES);

            this.comboBoxItem1.Items.AddRange(FF7Util.ITEM_NAMES);
            this.comboBoxItem2.Items.AddRange(FF7Util.ITEM_NAMES);
            this.comboBoxItem3.Items.AddRange(FF7Util.ITEM_NAMES);
            ButtonSubmit.Click += new EventHandler(ButtonSubmit_Click);

            if(FlowTimer.MainForm.RadioButtonC.Checked) {
                this.RadioButtonC.Select();
            } else if(FlowTimer.MainForm.RadioButtonB.Checked) {
                this.RadioButtonB.Select();
            } else if(FlowTimer.MainForm.RadioButtonA.Checked) {
                this.RadioButtonA.Select();
            } else if(FlowTimer.MainForm.RadioButtonS.Checked) {
                this.RadioButtonS.Select();
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) {

            uint[] itemArr = { (uint) comboBoxItem1.SelectedIndex, 
                (uint) comboBoxItem2.SelectedIndex, 
                (uint) comboBoxItem3.SelectedIndex };
            uint[] chocoNameArr = { (uint) comboBoxChoco2.SelectedIndex, 
                (uint) comboBoxChoco3.SelectedIndex, 
                (uint) comboBoxChoco4.SelectedIndex, 
                (uint) comboBoxChoco5.SelectedIndex, 
                (uint) comboBoxChoco6.SelectedIndex };

            char rank = 'C';
            if (this.RadioButtonC.Checked) {
                FlowTimer.MainForm.RadioButtonC.Select();
                rank = 'C';
            } else if (this.RadioButtonB.Checked) {
                FlowTimer.MainForm.RadioButtonB.Select();
                rank = 'B';
            } else if (this.RadioButtonA.Checked) {
                FlowTimer.MainForm.RadioButtonA.Select();
                rank = 'A';
            } else if (this.RadioButtonS.Checked) {
                FlowTimer.MainForm.RadioButtonS.Select();
                rank = 'S';
            }

            FlowTimer.Chocobo.Sync(this.time, itemArr, chocoNameArr, rank);
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void RadioButtonS_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
