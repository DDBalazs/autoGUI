namespace autoGUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sz�mol�sToolStripMenuItem_Click(object sender, EventArgs e)
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
            lbtank1.Text = "A tank megt�lt�s�nek d�ja: 0 Ft";
            lbtank2.Text = "A teljes tankkal megtehet� �t: 0 km";
            lbtank3.Text = "Az egy km-re es� benzin �ra: 0 Ft";
        }

        private void btszam_Click(object sender, EventArgs e)
        {
            if (txtank.Text == "")
            {
                MessageBox.Show("Adja meg a tank m�ret�t!","�zenet",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtank.Focus();
            }
            else if (txfogy.Text == "")
            {
                MessageBox.Show("Adja meg az aut� fogyaszt�s�t!", "�zenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txfogy.Focus();
            }
            else if (txtank.Text == "" && txfogy.Text == "")
            {
                MessageBox.Show("Adja meg a tank m�ret�t �s az aut� fogyaszt�s�t!", "�zenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double tankmeret = Convert.ToDouble(txtank.Text);
                double fogyasztas = Convert.ToDouble(txfogy.Text);
                if(rb95.Checked == true)
                {
                    double ar = 579.9;
                    lbtank1.Text = ("A tank megt�lt�s�nek d�ja: "+tankmeret * ar+"Ft");
                    lbtank2.Text = ("A teljes tankkal megtehet� �t: " + tankmeret * 100 / fogyasztas+ " km");
                    double megtoltesar = tankmeret * ar;
                    double telitankut = tankmeret * 100 / fogyasztas;
                    lbtank3.Text = ("Az egy km-re es� benzin �ra: " + megtoltesar / telitankut + " Ft");
                }
                else if(rbpremium.Checked == true)
                {
                    double ar = 615.9;
                    lbtank1.Text = ("A tank megt�lt�s�nek d�ja: " + tankmeret * ar + " Ft");
                    lbtank2.Text = ("A teljes tankkal megtehet� �t: " + tankmeret * 100 / fogyasztas+" km");
                    double megtoltesar = tankmeret * ar;
                    double telitankut = tankmeret * 100 / fogyasztas;
                    lbtank3.Text = ("Az egy km-re es� benzin �ra: " + megtoltesar / telitankut + " Ft");
                }
                else if(rbgazolaj.Checked == true)
                {
                    double ar = 583.9;
                    lbtank1.Text = ("A tank megt�lt�s�nek d�ja: " + tankmeret * ar + " Ft");
                    lbtank2.Text = ("A teljes tankkal megtehet� �t: " + tankmeret * 100 / fogyasztas+" km");
                    double megtoltesar = tankmeret * ar;
                    double telitankut = tankmeret * 100 / fogyasztas;
                    lbtank3.Text = ("Az egy km-re es� benzin �ra: " + megtoltesar / telitankut + " Ft");
                }
            }
        }
    }
}
