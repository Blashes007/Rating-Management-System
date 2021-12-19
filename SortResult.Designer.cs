namespace _18028944_Sujan_Khadka
{
    partial class sortingResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sortDataGridViewRating = new System.Windows.Forms.DataGridView();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.sortdatabyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sortDataGridViewRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortDataGridViewRating
            // 
            this.sortDataGridViewRating.BackgroundColor = System.Drawing.Color.Aqua;
            this.sortDataGridViewRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortDataGridViewRating.Location = new System.Drawing.Point(43, 31);
            this.sortDataGridViewRating.Margin = new System.Windows.Forms.Padding(4);
            this.sortDataGridViewRating.Name = "sortDataGridViewRating";
            this.sortDataGridViewRating.RowHeadersWidth = 51;
            this.sortDataGridViewRating.Size = new System.Drawing.Size(1375, 378);
            this.sortDataGridViewRating.TabIndex = 9;
            this.sortDataGridViewRating.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sortDataGridView_CellContentClick);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Phone",
            "Name",
            "Address",
            "RatingDate"});
            this.comboBoxSort.Location = new System.Drawing.Point(230, 53);
            this.comboBoxSort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(285, 24);
            this.comboBoxSort.TabIndex = 10;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // sortdatabyLabel
            // 
            this.sortdatabyLabel.AutoSize = true;
            this.sortdatabyLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortdatabyLabel.Location = new System.Drawing.Point(58, 48);
            this.sortdatabyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortdatabyLabel.Name = "sortdatabyLabel";
            this.sortdatabyLabel.Size = new System.Drawing.Size(164, 26);
            this.sortdatabyLabel.TabIndex = 11;
            this.sortdatabyLabel.Text = "Sort Data By:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortDataGridViewRating);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1407, 430);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rating Management System";
            // 
            // sortingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1581, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sortdatabyLabel);
            this.Controls.Add(this.comboBoxSort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sortingResult";
            this.Text = "SortResult";
            this.Load += new System.EventHandler(this.SortResult_Loader);
            ((System.ComponentModel.ISupportInitialize)(this.sortDataGridViewRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sortDataGridViewRating;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label sortdatabyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}