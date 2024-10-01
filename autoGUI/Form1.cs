namespace autoGUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void számolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtank.Enabled = true;
            txfogy.Enabled = true;
            btszam.Enabled = true;
            btszam.ForeColor = Color.Black;
            gbuzem.Enabled = true;
            gbuzem.ForeColor = Color.Black;
            rb95.Focus();
            lbtank1.Visible = true;
            lbtank2.Visible = true;
            lbtank3.Visible = true;
            lbtank1.Text = "A tank megtöltésének díja: 0 Ft";
            lbtank2.Text = "A teljes tankkal megtehetõ út: 0 km";
            lbtank3.Text = "Az egy km-re esõ benzin ára: 0 Ft";
        }

        private void btszam_Click(object sender, EventArgs e)
        {
            if (txtank.Text == "")
            {
                MessageBox.Show("Adja meg a tank méretét!","Üzenet",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtank.Focus();
            }
            else if (txfogy.Text == "")
            {
                MessageBox.Show("Adja meg az autó fogyasztását!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txfogy.Focus();
            }
            else if (txtank.Text == "" && txfogy.Text == "")
            {
                MessageBox.Show("Adja meg a tank méretét és az autó fogyasztását!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double tankmeret = Convert.ToDouble(txtank.Text);
                double fogyasztas = Convert.ToDouble(txfogy.Text);
                if(rb95.Checked == true)
                {
                    double ar = 579.9;
                    lbtank1.Text = ("A tank megtöltésének díja: "+tankmeret * ar+"Ft");
                    lbtank2.Text = ("A teljes tankkal megtehetõ út: " + tankmeret * 100 / fogyasztas+ " km");
                    double megtoltesar = tankmeret * ar;
                    double telitankut = tankmeret * 100 / fogyasztas;
                    lbtank3.Text = ("Az egy km-re esõ benzin ára: " + megtoltesar / telitankut + " Ft");
                }
                else if(rbpremium.Checked == true)
                {
                    double ar = 615.9;
                    lbtank1.Text = ("A tank megtöltésének díja: " + tankmeret * ar + " Ft");
                    lbtank2.Text = ("A teljes tankkal megtehetõ út: " + tankmeret * 100 / fogyasztas+" km");
                    double megtoltesar = tankmeret * ar;
                    double telitankut = tankmeret * 100 / fogyasztas;
                    lbtank3.Text = ("Az egy km-re esõ benzin ára: " + megtoltesar / telitankut + " Ft");
                }
                else if(rbgazolaj.Checked == true)
                {
                    double ar = 583.9;
                    lbtank1.Text = ("A tank megtöltésének díja: " + tankmeret * ar + " Ft");
                    lbtank2.Text = ("A teljes tankkal megtehetõ út: " + tankmeret * 100 / fogyasztas+" km");
                    double megtoltesar = tankmeret * ar;
                    double telitankut = tankmeret * 100 / fogyasztas;
                    lbtank3.Text = ("Az egy km-re esõ benzin ára: " + megtoltesar / telitankut + " Ft");
                }
            }
        }
    }
}
