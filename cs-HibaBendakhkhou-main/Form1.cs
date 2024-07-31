using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TpCalculette
{
    public partial class frmCalculette : Form
    {
        private string operateur = "";
        private string op1 = "";
        private double resultat = 0;
        private bool entre_value = false;
        private string premierNbr, deuxiemeNbr;
        private double memoryValue = 0;




        public frmCalculette()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAffichage.TextAlign = HorizontalAlignment.Right;
      
            memory.Visible = false;
            listBox1.Visible = false;
            trash.Visible = false;
            trash2.Visible = false;
            trash3.Visible = false;


        }
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                txtAffichage.Text = (int.Parse(txtAffichage.Text) + int.Parse(op1)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de conversion.");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op1 = txtAffichage.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            //   txtAffichage.Text = btn5.Text;
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((txtAffichage.Text == "0") || (entre_value))
                txtAffichage.Text = "";

            entre_value = false;

            if (btn.Text == ",")
            {
                if (!txtAffichage.Text.Contains(','))
                    txtAffichage.Text += btn.Text;
            }
            else
            {
                txtAffichage.Text += btn.Text;
            }

        }

        private bool historyAdded = false;
        private bool resultUsed = false;

        private void Operations(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultat != 0)
            {
                if (resultUsed)
                {
                    premierNbr = txtAffichage.Text;
                    resultUsed = false;
                }

                btnEql.PerformClick();
                operateur = btn.Text;
                Standars.Text = $"{resultat}  {operateur}";

            }
            else
            {
                operateur = btn.Text;
                if (double.TryParse(txtAffichage.Text, out resultat))
                {
                    txtAffichage.Text = "";
                    Standars.Text = $"{resultat}  {operateur}";
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }

            entre_value = true;
            premierNbr = Standars.Text;
            historyAdded = false;
        }

        //  memory.Visible = false;
        //  menu.Visible = false;

        private void btnEql_Click(object sender, EventArgs e)
        {
            deuxiemeNbr = txtAffichage.Text;


            // Perform the current operation
            switch (operateur)
            {
                case "+":
                    txtAffichage.Text = (resultat + double.Parse(txtAffichage.Text)).ToString();
                    break;
                case "-":
                    txtAffichage.Text = (resultat - double.Parse(txtAffichage.Text)).ToString();
                    break;
                case "X":
                    txtAffichage.Text = (resultat * double.Parse(txtAffichage.Text)).ToString();
                    break;
                case "÷":
                    if (double.Parse(txtAffichage.Text) != 0)
                        txtAffichage.Text = (resultat / double.Parse(txtAffichage.Text)).ToString();
                    else
                        MessageBox.Show("Division par zéro.");
                    break;
                default:
                    break;
            }
            if (!Standars.Text.Contains("="))
                Standars.Text += deuxiemeNbr + "= ";

        
        

            // Append the calculation to the history
            if (!historyAdded && !string.IsNullOrEmpty(premierNbr)){
                    history.Text += $"\n{premierNbr} {deuxiemeNbr}  =\n\n\t{txtAffichage.Text}\n";
                   listBox1.Items.Add($"\n{premierNbr} {deuxiemeNbr}  =\n\n\t{txtAffichage.Text}\n");
                   historyAdded = true; 
            }

            resultat = double.Parse(txtAffichage.Text);
            operateur = "";
            trash.Visible = true;
            premierNbr = Standars.Text;
        }

        private void memory_TextChanged(object sender, EventArgs e)
        {
            // La gestion du texte dand memory /!\
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            double nombre;
            if (double.TryParse(txtAffichage.Text, out nombre))
            {
                memoryValue += nombre;
                memory.AppendText(memoryValue.ToString() + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Erreur de conversion du nombre.");
            }

        }

        private void MS_Click(object sender, EventArgs e)
        {
            double nombre;
            if (double.TryParse(txtAffichage.Text, out nombre))
            {
                memoryValue = nombre;
                memory.Text = "M";
            }
            else
            {
                MessageBox.Show("Erreur de conversion du nombre.");
            }

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text.Length > 0)
            {
                txtAffichage.Text = txtAffichage.Text.Remove(txtAffichage.Text.Length - 1, 1);
            }

            if (txtAffichage.Text == "")
            {
                txtAffichage.Text = "0";
            }

        }



      private void frmCalculette_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
        }
        private void txtAffichage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string c = e.KeyChar.ToString();
            //txtAffichage.Text += c;
            //com
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "0";
            
        }
        private void memory_TextChanged_1(object sender, EventArgs e)
        {

        }
        

        private void menu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void shortHistory_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Visible = false;
                trash2.Visible = false;
            }
            else
            {
                listBox1.Visible = true;
                trash2.Visible = true;
            }
        }
        private void shortHistoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void trash2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            trash2.Visible = false;
        }

        private void showMemory_Click(object sender, EventArgs e)
        {
            if(memory.Visible==true)
            {
                memory.Visible = false;
                trash3.Visible = false;
            }
            else
            {
                memory.Visible = true;
                trash3.Visible = true;
            }
        }

        private void MS_Click_1(object sender, EventArgs e)
        {
            memory.Text = txtAffichage.Text;
        }

        private void Mmoins_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txtAffichage.Text, out value))
            {
                double memoryValue;
                if (double.TryParse(memory.Text, out memoryValue))
                {
                    memory.Text = (memoryValue - value).ToString();
                }
            }
        }

        private void Mplus_Click_1(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txtAffichage.Text, out value))
            {
                double memoryValue;
                if (double.TryParse(memory.Text, out memoryValue))
                {
                    memory.Text = (memoryValue + value).ToString();
                }
            }
        }

        private void MR_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = memory.Text;
        }

        private void MC_Click(object sender, EventArgs e)
        {
            memory.Text = "";
        }

        private void trash3_Click(object sender, EventArgs e)
        {
            memory.Text = "";
            memory.Text = "aucun element dans la memoire !";
            trash3.Visible = false;
        }

        private void trash_Click(object sender, EventArgs e)
        {
            history.Clear();
            trash.Visible = false;
        }

        private void btlC_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "0";
            resultat = 0;
            Standars.Text = "";
        }

        private void btnCalculer_MouseMove(object sender, MouseEventArgs e)
        {

        }

    }
}

