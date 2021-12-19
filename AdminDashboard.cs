using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace _18028944_Sujan_Khadka
{
    public partial class FormAdmin : Form
    {
        public static BindingList<Rating> RatingList = new BindingList<Rating>();


        public FormAdmin()
        {
            InitializeComponent();
        }
       
        public void Add(Rating s)
        {
            Boolean idRepeat = false;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (s.Phone.ToString() == dataGridView.Rows[i].Cells[0].Value.ToString())
                {
                    idRepeat = true;
                }
            }

            if (idRepeat == true)
            {
                MessageBox.Show("Phone Number Already Exists");
            }
            else
            {
                RatingList.Add(s);
                dataGridView.DataSource = null;
                dataGridView.DataSource = RatingList;
                dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["FoodQuality"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["StaffFriendliness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["Cleanliness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["OrderAccuracy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["RestaurantAmbiance"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["ValueforMoney"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["RatingDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AdminForm(object sender, EventArgs e)
        {
          
            dataGridView.DataSource = RatingList;
            dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["FoodQuality"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["StaffFriendliness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["Cleanliness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["OrderAccuracy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["RestaurantAmbiance"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["ValueforMoney"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["RatingDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ratingClick_Form(object sender, EventArgs e)
        {
            if (Application.OpenForms["RatingForm"] == null)
            {
                ratingForm zx = new ratingForm();
                zx.Edit = false;
                zx.Show();
            }
            else
            {
                ((ratingForm)Application.OpenForms["RatingForm"]).Edit = false;
                Application.OpenForms["RatingForm"].BringToFront();
            }
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream gs = new FileStream("ratingDetails.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(gs, RatingList);
            gs.Close();
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog gnn = new SaveFileDialog();
            gnn.Filter = "CSV File|*.csv;";
            gnn.DefaultExt = ".csv";
            if (gnn.ShowDialog() == DialogResult.OK)
            {
                StreamWriter gr = new StreamWriter(gnn.FileName);
                StringBuilder br = new StringBuilder();
                br.AppendLine("Phone No, Name, Address, Food Quality, Staff Friendliness, Cleanliness, Order Accuracy, Restaurant Ambiance, Value For Money, Rating Date");
                foreach (Rating std in RatingList)
                {
                    br.AppendLine(
                        std.Phone.ToString() + ","
                        + std.Name + "," +
                        std.Address + ","
                        + std.FoodQuality + ","
                        + std.StaffFriendliness + ","
                        + std.Cleanliness + ","
                        + std.OrderAccuracy + ","
                        + std.RestaurantAmbiance + ","
                        + std.ValueforMoney + ","
                        + std.RatingDate.ToString());
                }
                gr.Write(br.ToString());
                gr.Close();
                MessageBox.Show("Exported Successfully");
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataGridView.Rows.Clear(); 
                String[] lines = File.ReadAllLines(ofd.FileName);
                String[] items;
                lines.Skip(0);
                bool firstline = true;
                foreach (string line in lines)
                {
                    items = line.Split(',');
                    if (firstline == true)
                    {
                        firstline = false;
                    }
                    else
                    {
                        Rating std = new Rating(Convert.ToDecimal(items[0]), items[1].ToString(),
                            items[2].ToString(), items[3].ToString(), items[4].ToString(), 
                            items[5].ToString(), items[6].ToString(), items[7].ToString(), 
                            items[8].ToString(),Convert.ToDateTime(items[9]));
                        Add(std);
                    }
                }
                MessageBox.Show("Imported Successfully");
            }
        }


        private void sortResult_Button(object sender, EventArgs e)
        {
            if (Application.OpenForms["SortResult"] == null)
            {
                sortingResult f = new sortingResult(RatingList);
                f.ShowDialog();
            }
            else
            {
                Application.OpenForms["SortedForm"].BringToFront();
            }
        }


        private void button_ViewChart(object sender, EventArgs e)
        {
            if (Application.OpenForms["ChartForm"] == null)
            {
                FormChart chrt = new FormChart(RatingList);
                chrt.ShowDialog();
            }
            else
            {
                Application.OpenForms["Chart"].BringToFront();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    public class Rating
    {
        public decimal Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string FoodQuality { get; set; }
        public string StaffFriendliness { get; set; }
        public string Cleanliness { get; set; }
        public string OrderAccuracy { get; set; }
        public string RestaurantAmbiance { get; set; }
        public string ValueforMoney { get; set; }
        public DateTime RatingDate { get; set; }
         
        public Rating(decimal phone, string name, string addr,
        string food, string staff, string clean, string order, string restaurant,
        string money, DateTime rgrdt)
        {
            SetCustomer(phone, name, addr, food, staff, clean, order, restaurant, money, rgrdt);
        }

        public void SetCustomer(decimal phone, string name, string addr,
        string food, string staff, string clean, string order, string restaurant,
        string money, DateTime rgrdt)
        {
            Phone = phone;
            Name = name;
            Address = addr;
            FoodQuality = food;
            StaffFriendliness = staff;
            Cleanliness = clean;
            OrderAccuracy = order;
            RestaurantAmbiance = restaurant;
            ValueforMoney = money;
            RatingDate = rgrdt;
        }

    }
}
