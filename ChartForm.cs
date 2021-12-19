using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _18028944_Sujan_Khadka
{
    public partial class FormChart : Form
    {
        BindingList<Rating> RatingList;
        public FormChart(BindingList<Rating> newList)
        {
            InitializeComponent();
            RatingList = newList;
        }

        private void ChartForm_Loader(object sender, EventArgs e)
        {
            FoodRating();
            StaffRating();
            gridView.Columns["Rating_Food"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridView.Columns["total_RatingFood"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["Rating_Staff"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["total_RatingStaff"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void StaffRating()
        {
            int ExcellentCount = 0;
            int GoodCount = 0;
            int AverageCount = 0;
            int DissatisfiedCount = 0;
            int NeutralCount = 0;
            string Excellent = "Excellent";
            string Good = "Good";
            string Average = "Average";
            string Dissatisfied = "Dissatisfied";
            string Neutral = "Neutral";

            foreach (Rating cst in RatingList)
            {
                if (cst.StaffFriendliness.ToUpper().Contains(Excellent.ToUpper()))
                {
                    ExcellentCount++;
                }
                else if (cst.StaffFriendliness.ToUpper().Contains(Good.ToUpper()))
                {
                    GoodCount++;
                }
                else if (cst.StaffFriendliness.ToUpper().Contains(Average.ToUpper()))
                {
                    AverageCount++;
                }
                else if (cst.StaffFriendliness.ToUpper().Contains(Dissatisfied.ToUpper()))
                {
                    DissatisfiedCount++;
                }
                else if (cst.StaffFriendliness.ToUpper().Contains(Neutral.ToUpper()))
                {
                    NeutralCount++;
                }
            }


            chart01.Series[0].Points.AddXY("Excellent", ExcellentCount);
            chart01.Series[0].Points.AddXY("Good", GoodCount);
            chart01.Series[0].Points.AddXY("Average", AverageCount);
            chart01.Series[0].Points.AddXY("Dissatisfied", DissatisfiedCount);
            chart01.Series[0].Points.AddXY("Neutral", NeutralCount);
            chart01.Series[0].IsValueShownAsLabel = true;
            chart01.Series[0].IsVisibleInLegend = true;
            comboBox1.SelectedIndex = 0;

            BindingList<StaffsRating> list1 = new BindingList<StaffsRating>();
            StaffsRating gr1 = new StaffsRating(Excellent, ExcellentCount.ToString());
            StaffsRating gr2 = new StaffsRating(Good, GoodCount.ToString());
            StaffsRating gr3 = new StaffsRating(Average, AverageCount.ToString());
            StaffsRating gr4 = new StaffsRating(Dissatisfied, DissatisfiedCount.ToString());
            StaffsRating gr5 = new StaffsRating(Neutral, NeutralCount.ToString());
            list1.Add(gr1);
            list1.Add(gr2);
            list1.Add(gr3);
            list1.Add(gr4);
            list1.Add(gr5);
            dataGridView.DataSource = list1;
        }

        private void FoodRating()
        {
            int ExcellentCount = 0;
            int GoodCount = 0;
            int AverageCount = 0;
            int DissatisfiedCount = 0;
            int NeutralCount = 0;
            string Excellent = "Excellent";
            string Good = "Good";
            string Average = "Average";
            string Dissatisfied = "Dissatisfied";
            string Neutral = "Neutral";

            foreach (Rating cst in RatingList)
            {
                if (cst.FoodQuality.ToUpper().Contains(Excellent.ToUpper()))
                {
                    ExcellentCount++;
                }
                else if (cst.FoodQuality.ToUpper().Contains(Good.ToUpper()))
                {
                    GoodCount++;
                }
                else if (cst.FoodQuality.ToUpper().Contains(Average.ToUpper()))
                {
                    AverageCount++;
                }
                else if (cst.FoodQuality.ToUpper().Contains(Dissatisfied.ToUpper()))
                {
                    DissatisfiedCount++;
                }
                else if (cst.FoodQuality.ToUpper().Contains(Neutral.ToUpper()))
                {
                    NeutralCount++;
                }
            }


            chart.Series[0].Points.AddXY("Excellent", ExcellentCount);
            chart.Series[0].Points.AddXY("Good", GoodCount);
            chart.Series[0].Points.AddXY("Average", AverageCount);
            chart.Series[0].Points.AddXY("Dissatisfied", DissatisfiedCount);
            chart.Series[0].Points.AddXY("Neutral", NeutralCount);
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].IsVisibleInLegend = true;
            comboBox1.SelectedIndex = 0;

            BindingList<RatingFood> list = new BindingList<RatingFood>();
            RatingFood sr1 = new RatingFood(Excellent, ExcellentCount.ToString());
            RatingFood sr2 = new RatingFood(Good, GoodCount.ToString());
            RatingFood sr3 = new RatingFood(Average, AverageCount.ToString());
            RatingFood sr4 = new RatingFood(Dissatisfied, DissatisfiedCount.ToString());
            RatingFood sr5 = new RatingFood(Neutral, NeutralCount.ToString());
            list.Add(sr1);
            list.Add(sr2);
            list.Add(sr3);
            list.Add(sr4);
            list.Add(sr5);
            gridView.DataSource = list;
        }

        private void comboBox_SelectedIndexChange(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                chart.Series[0].ChartType = SeriesChartType.Pie;
            else if (comboBox1.SelectedIndex == 1)
                chart.Series[0].ChartType = SeriesChartType.Column;
            else if (comboBox1.SelectedIndex == 2)
                chart.Series[0].ChartType = SeriesChartType.Line;
        }

        private void comboBox1_SelectedIndexChange(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                chart01.Series[0].ChartType = SeriesChartType.Pie;
            else if (comboBox2.SelectedIndex == 1)
                chart01.Series[0].ChartType = SeriesChartType.Column;
            else if (comboBox2.SelectedIndex == 2)
                chart01.Series[0].ChartType = SeriesChartType.Line;
        }
    }
    public class RatingFood
    {
        public string Rating_Food { get; set; }
        public string total_RatingFood { get; set; }
        public RatingFood(string fname, string fnum)
        {
            setData(fname, fnum);
        }

        public void setData(string fname, string fnum)
        {
            this.Rating_Food = fname;
            this.total_RatingFood = fnum;
        }
    }
    public class StaffsRating
    {
        public string Rating_Staff { get; set; }
        public string total_RatingStaff { get; set; }
        public StaffsRating(string pname, string tnum)
        {
            setData(pname, tnum);
        }

        public void setData(string pname, string tnum)
        {
            this.Rating_Staff = pname;
            this.total_RatingStaff = tnum;
        }
    }
}
