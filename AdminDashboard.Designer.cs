namespace _18028944_Sujan_Khadka
{
    partial class FormAdmin
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
            this.ratingForm = new System.Windows.Forms.Button();
            this.importfilebutton = new System.Windows.Forms.Button();
            this.exportfilebutton = new System.Windows.Forms.Button();
            this.sortResultButton = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ratingForm
            // 
            this.ratingForm.BackColor = System.Drawing.SystemColors.GrayText;
            this.ratingForm.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.ratingForm.FlatAppearance.BorderSize = 2;
            this.ratingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingForm.Location = new System.Drawing.Point(106, 713);
            this.ratingForm.Margin = new System.Windows.Forms.Padding(4);
            this.ratingForm.Name = "ratingForm";
            this.ratingForm.Size = new System.Drawing.Size(209, 74);
            this.ratingForm.TabIndex = 0;
            this.ratingForm.Text = "Rate Services";
            this.ratingForm.UseVisualStyleBackColor = false;
            this.ratingForm.Click += new System.EventHandler(this.ratingClick_Form);
            // 
            // importfilebutton
            // 
            this.importfilebutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.importfilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importfilebutton.Location = new System.Drawing.Point(1478, 705);
            this.importfilebutton.Margin = new System.Windows.Forms.Padding(4);
            this.importfilebutton.Name = "importfilebutton";
            this.importfilebutton.Size = new System.Drawing.Size(147, 82);
            this.importfilebutton.TabIndex = 2;
            this.importfilebutton.Text = "Import File";
            this.importfilebutton.UseVisualStyleBackColor = false;
            this.importfilebutton.Click += new System.EventHandler(this.import_Click);
            // 
            // exportfilebutton
            // 
            this.exportfilebutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.exportfilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportfilebutton.Location = new System.Drawing.Point(1675, 705);
            this.exportfilebutton.Margin = new System.Windows.Forms.Padding(4);
            this.exportfilebutton.Name = "exportfilebutton";
            this.exportfilebutton.Size = new System.Drawing.Size(147, 82);
            this.exportfilebutton.TabIndex = 3;
            this.exportfilebutton.Text = "Export File";
            this.exportfilebutton.UseVisualStyleBackColor = false;
            this.exportfilebutton.Click += new System.EventHandler(this.export_Click);
            // 
            // sortResultButton
            // 
            this.sortResultButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.sortResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortResultButton.Location = new System.Drawing.Point(611, 713);
            this.sortResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortResultButton.Name = "sortResultButton";
            this.sortResultButton.Size = new System.Drawing.Size(268, 74);
            this.sortResultButton.TabIndex = 4;
            this.sortResultButton.Text = "View Data by Sorting";
            this.sortResultButton.UseVisualStyleBackColor = false;
            this.sortResultButton.Click += new System.EventHandler(this.sortResult_Button);
            // 
            // buttonChart
            // 
            this.buttonChart.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChart.Location = new System.Drawing.Point(378, 713);
            this.buttonChart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(151, 74);
            this.buttonChart.TabIndex = 5;
            this.buttonChart.Text = "View Chart";
            this.buttonChart.UseVisualStyleBackColor = false;
            this.buttonChart.Click += new System.EventHandler(this.button_ViewChart);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.Location = new System.Drawing.Point(8, 44);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1748, 462);
            this.dataGridView.TabIndex = 8;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(85, 116);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(1764, 544);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Rating Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(775, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rating Management System";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 955);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.sortResultButton);
            this.Controls.Add(this.exportfilebutton);
            this.Controls.Add(this.importfilebutton);
            this.Controls.Add(this.ratingForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ratingForm;
        private System.Windows.Forms.Button importfilebutton;
        private System.Windows.Forms.Button exportfilebutton;
        private System.Windows.Forms.Button sortResultButton;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
    }
}

