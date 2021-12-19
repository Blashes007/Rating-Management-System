using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18028944_Sujan_Khadka
{
    public partial class ratingForm : Form
    {
        public Boolean Edit { get; set; }
        public ratingForm()
        {
            InitializeComponent();
        }

        private void Rating_Form(object sender, EventArgs e)
        {
            if (Edit.Equals(false))
            {
                comboBoxFood.SelectedIndex = 0;
                comboBoxFriendliness.SelectedIndex = 0;
                cleanlinessBox.SelectedIndex = 0;
                orderAccuracyBox.SelectedIndex = 0;
                restaurantComboBox.SelectedIndex = 0;
                valueformoneyBox.SelectedIndex = 0;
                comboboxdateTimePicker.Value = DateTime.Now;
            }
        }

        private void textPhone_OnPress(object sender, KeyPressEventArgs e)
        {
            txtPhone.MaxLength = 10;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Do not allow decimal point             
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Button(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                if (
                    string.IsNullOrEmpty(txtPhone.Text.ToString())
                     || string.IsNullOrEmpty(txtName.Text.ToString())
                     || string.IsNullOrEmpty(txtAddress.Text.ToString())
                     || string.IsNullOrEmpty(comboBoxFood.Text.ToString())
                     || string.IsNullOrEmpty(comboBoxFriendliness.Text.ToString())
                     || string.IsNullOrEmpty(cleanlinessBox.Text.ToString())
                     || string.IsNullOrEmpty(orderAccuracyBox.Text.ToString())
                     || string.IsNullOrEmpty(restaurantComboBox.Text.ToString())
                     || string.IsNullOrEmpty(valueformoneyBox.Text.ToString())
                     || string.IsNullOrEmpty(comboboxdateTimePicker.ToString()))
                {
                    MessageBox.Show("Please fill all the information");
                }
                else
                {
                        Rating cst = new Rating(Convert.ToDecimal(txtPhone.Text),
                            txtName.Text.ToString(),
                            txtAddress.Text.ToString(),
                            comboBoxFood.Text.ToString(),
                            comboBoxFriendliness.Text.ToString(),
                            cleanlinessBox.Text.ToString(),
                            orderAccuracyBox.Text.ToString(),
                            restaurantComboBox.Text.ToString(),
                            valueformoneyBox.Text.ToString(),
                            Convert.ToDateTime(comboboxdateTimePicker.Value));
                        ((FormAdmin)Application.OpenForms["FormAdmin"]).Add(cst);
                        clearData();
                    

                }
            }
        }

        private void clearData()
        {
            txtPhone.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            comboBoxFood.SelectedIndex = 0;
            comboBoxFriendliness.SelectedIndex = 0;
            cleanlinessBox.SelectedIndex = 0;
            orderAccuracyBox.SelectedIndex = 0;
            restaurantComboBox.SelectedIndex = 0;
            valueformoneyBox.SelectedIndex = 0;
        }

        private void button_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Click_label(object sender, EventArgs e)
        {

        }

        private void enter_GroupBox(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void entergroup_Box(object sender, EventArgs e)
        {

        }
    }
}
