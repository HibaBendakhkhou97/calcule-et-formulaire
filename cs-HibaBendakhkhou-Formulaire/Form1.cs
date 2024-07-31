using System;
using System.Windows.Forms;

namespace TpCalculette
{
    public partial class frmCalculette : Form
    {
        FormDB objetBD = new FormDB();

        bool validClicked = false;
        string flage = "";

        public frmCalculette()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnLoadState();
            objetBD.ListElements(comboBox1);
        }

        private void OnLoadState()
        {
            comboBox1.Enabled = true;
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            ageFiled.Enabled = false;
            Créer.Enabled = true;
            Modifier.Enabled = false;
            Annuler.Enabled = false;
            Supprimer.Enabled = false;
            Valider.Enabled = false;
            labelError0.Visible = false;
            labelError1.Visible = false;
            labelError2.Visible = false;
        }

        private void OnCreateState()
        {
            Créer.Enabled = false;
            Modifier.Enabled = false;
            Supprimer.Enabled = false;
            Annuler.Enabled = true;
            Valider.Enabled = true;
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            ageFiled.Enabled = true;
        }

        private void OnUpdateState(string name, string lastName, int age)
        {
            Créer.Enabled = false;
            Modifier.Enabled = false;
            Supprimer.Enabled = true;
            Annuler.Enabled = true;
            Valider.Enabled = true;
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            ageFiled.Enabled = true;
        }

        private void OnDeleteState(string name, string lastName, int age)
        {
            Créer.Enabled = false;
            Modifier.Enabled = false;
            Supprimer.Enabled = false;
            Annuler.Enabled = true;
            Valider.Enabled = true;
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            ageFiled.Enabled = false;

            txtNom.Text = name;
            txtPrenom.Text = lastName;
            ageFiled.Value = age;
        }

        private bool ChampEstValide()
        {
            int n = 0;
            if (txtNom.TextLength < 4)
            {
                labelError0.Visible = true;
                labelError0.Text = "Longueur de champ invalide (minimum 4 caractères)";
                n++;
            }
            else
                labelError0.Visible = false;

            if (txtPrenom.TextLength < 4)
            {
                labelError1.Visible = true;
                labelError1.Text = "Longueur de champ invalide (minimum 4 caractères)";
                n++;
            }
            else
                labelError1.Visible = false;

            if (ageFiled.Value < 6)
            {
                labelError2.Visible = true;
                labelError2.Text = "Age invalide (6 ans au minimum)";
                n++;
            }
            else
                labelError2.Visible = false;

            return n == 0;
        }

        private void Créer_Click(object sender, EventArgs e)
        {
            OnCreateState();
            flage = "créer";
        }

        string selectedValue;

        private void Modifier_Click(object sender, EventArgs e)
        {
            labelError0.Visible = false;
            labelError1.Visible = false;
            labelError2.Visible = false;
            Créer.Enabled = true;

            if (comboBox1.SelectedIndex != -1)
            {
                Supprimer.Enabled = false;
                Modifier.Enabled = false;

                selectedValue = comboBox1.SelectedItem.ToString();

                string[] values = selectedValue.Split('|');

                if (values.Length >= 3)
                {
                    string nom = values[1];
                    string prenom = values[2];
                    string ageValue = values[3];

                    txtNom.Text = nom;
                    txtPrenom.Text = prenom;
                    if (int.TryParse(ageValue, out int parsedAge))
                    {
                        ageFiled.Value = parsedAge;
                    }
                }
                flage = "modifier";
            }
            else
            {
                MessageBox.Show("Select a person from the list");
            }
        }

        private void ClearFields()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            ageFiled.Value = 0;
        }

        public void AddElement(string toAdd)
        {
            if (!comboBox1.Items.Contains(toAdd))
            {
                comboBox1.Items.Add(toAdd);
                ClearFields();
            }
            else
                MessageBox.Show("Champ dupliqué");
        }

        public void ModifyElement()
        {
            comboBox1.Items[comboBox1.SelectedIndex] = $"{txtNom.Text} | {txtPrenom.Text} | {ageFiled.Value}";
            ClearFields();
        }

        public void DeleteElement()
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            ClearFields();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Modifier.Enabled = true;
            Supprimer.Enabled = true;

            if (flage == "créer")
            {
                string toAdd = $"{txtNom.Text}|{txtPrenom.Text}|{ageFiled.Value}";
                if (ChampEstValide())
                {
                    int res = objetBD.AddElement(txtNom.Text, txtPrenom.Text, (int)ageFiled.Value);
                    if (res == 1)
                        MessageBox.Show("Updated successfully!");
                }
            }
            else if (flage == "modifier")
            {
                if (ChampEstValide())
                {
                    int res = objetBD.UpdateElement(txtNom.Text, txtPrenom.Text, (int)ageFiled.Value, comboBox1.SelectedIndex,comboBox1);
                    if (res == 1)
                        MessageBox.Show("Updated successfully!");
                    else
                        MessageBox.Show("Delete operation failed!");
                    flage = "créer";
                }
            }
            else if (flage == "supprimer")
            {
                int res = objetBD.DeleteElement(comboBox1.SelectedIndex,comboBox1);
                if (res == 1)
                    MessageBox.Show("Deleted successfully!");
                else
                    MessageBox.Show("Delete operation failed!");
                flage = "créer";
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            labelError0.Visible = false;
            labelError1.Visible = false;
            labelError2.Visible = false;
            Créer.Enabled = false;

            if (comboBox1.SelectedIndex != -1)
            {
                Supprimer.Enabled = false;
                Modifier.Enabled = false;

                selectedValue = comboBox1.SelectedItem.ToString();
                string[] values = selectedValue.Split('|');

                if (values.Length >= 3)
                {
                    string nom = values[1];
                    string prenom = values[2];
                    string ageString = values[3];

                    if (int.TryParse(ageString, out int ageValue))
                    {
                        txtNom.Text = nom;
                        txtPrenom.Text = prenom;
                        ageFiled.Value = ageValue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a person from the list");
            }
            flage = "supprimer";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supprimer.Enabled = true;
            Modifier.Enabled = true;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            ageFiled.Value = 0;
            comboBox1.SelectedIndex = -1;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr(e) que vous voulez quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
