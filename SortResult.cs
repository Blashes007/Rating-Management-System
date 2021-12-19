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
    public partial class sortingResult : Form
    {
        BindingList<Rating> List = new BindingList<Rating>();
        public sortingResult(BindingList<Rating> newList)
        {
            InitializeComponent();
            foreach (Rating x in newList)
                List.Add(x);
        }
        private void SortResult_Loader(object sender, EventArgs e)
        {
            comboBoxSort.SelectedIndex = 0;
        }
        private void DataSwap(int y, int z)
        {
            Rating temp;
            temp = List[y];
            List[y] = List[z];
            List[z] = temp;
        }
        private void SortingDataList()
        {
            for (int i = 0; i < List.Count - 1; i++)
                for (int j = 0; j < List.Count - 1; j++)
                {
                    switch (comboBoxSort.SelectedIndex)
                    {
                        case 0:
                            if (List[j].Phone.CompareTo(List[j + 1].Phone) > 0)
                            {
                                DataSwap(j, j + 1);
                            }
                            break;
                        case 1:
                            if (List[j].Name.CompareTo(List[j + 1].Name) > 0)
                            {
                                DataSwap(j, j + 1);
                            }
                            break;
                        case 2:
                            if (List[j].Address.CompareTo(List[j + 1].Address) > 0)
                            {
                                DataSwap(j, j + 1);
                            }
                            break;
                        case 3:
                            if (List[j].RatingDate.CompareTo(List[j + 1].RatingDate) > 0)
                            {
                                DataSwap(j, j + 1);
                            }
                            break;
                    }
                }
            sortDataGridViewRating.DataSource = List;
            sortDataGridViewRating.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["FoodQuality"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["StaffFriendliness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["Cleanliness"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["OrderAccuracy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["RestaurantAmbiance"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["ValueforMoney"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sortDataGridViewRating.Columns["RatingDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortingDataList();
        }

        private void sortDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}