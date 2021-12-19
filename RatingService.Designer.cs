namespace _18028944_Sujan_Khadka
{
    partial class ratingForm
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboboxdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxFriendliness = new System.Windows.Forms.ComboBox();
            this.cleanlinessBox = new System.Windows.Forms.ComboBox();
            this.orderAccuracyBox = new System.Windows.Forms.ComboBox();
            this.restaurantComboBox = new System.Windows.Forms.ComboBox();
            this.valueformoneyBox = new System.Windows.Forms.ComboBox();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.staffFriendlinessLabel = new System.Windows.Forms.Label();
            this.cleanlinessLabel = new System.Windows.Forms.Label();
            this.orderAccuracLabel = new System.Windows.Forms.Label();
            this.restaurantAmbianeLabel = new System.Windows.Forms.Label();
            this.valueformoneLabel = new System.Windows.Forms.Label();
            this.ratingdateLabel = new System.Windows.Forms.Label();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtPhone.Location = new System.Drawing.Point(317, 105);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(341, 32);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_OnPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(317, 169);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 32);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(317, 244);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(341, 32);
            this.txtAddress.TabIndex = 2;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied",
            "Neutral"});
            this.comboBoxFood.Location = new System.Drawing.Point(317, 311);
            this.comboBoxFood.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(341, 34);
            this.comboBoxFood.TabIndex = 5;
            // 
            // comboboxdateTimePicker
            // 
            this.comboboxdateTimePicker.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxdateTimePicker.Location = new System.Drawing.Point(1031, 414);
            this.comboboxdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.comboboxdateTimePicker.Name = "comboboxdateTimePicker";
            this.comboboxdateTimePicker.Size = new System.Drawing.Size(367, 27);
            this.comboboxdateTimePicker.TabIndex = 6;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.White;
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSubmit.Location = new System.Drawing.Point(39, 48);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(192, 44);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.btnSubmit_Button);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonClose.Location = new System.Drawing.Point(283, 48);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 44);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button_Close);
            // 
            // comboBoxFriendliness
            // 
            this.comboBoxFriendliness.FormattingEnabled = true;
            this.comboBoxFriendliness.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied",
            "Neutral"});
            this.comboBoxFriendliness.Location = new System.Drawing.Point(1031, 321);
            this.comboBoxFriendliness.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFriendliness.Name = "comboBoxFriendliness";
            this.comboBoxFriendliness.Size = new System.Drawing.Size(341, 34);
            this.comboBoxFriendliness.TabIndex = 9;
            // 
            // cleanlinessBox
            // 
            this.cleanlinessBox.FormattingEnabled = true;
            this.cleanlinessBox.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied",
            "Neutral"});
            this.cleanlinessBox.Location = new System.Drawing.Point(1029, 166);
            this.cleanlinessBox.Margin = new System.Windows.Forms.Padding(4);
            this.cleanlinessBox.Name = "cleanlinessBox";
            this.cleanlinessBox.Size = new System.Drawing.Size(343, 34);
            this.cleanlinessBox.TabIndex = 10;
            // 
            // orderAccuracyBox
            // 
            this.orderAccuracyBox.FormattingEnabled = true;
            this.orderAccuracyBox.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied",
            "Neutral"});
            this.orderAccuracyBox.Location = new System.Drawing.Point(1029, 75);
            this.orderAccuracyBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderAccuracyBox.Name = "orderAccuracyBox";
            this.orderAccuracyBox.Size = new System.Drawing.Size(343, 34);
            this.orderAccuracyBox.TabIndex = 11;
            // 
            // restaurantComboBox
            // 
            this.restaurantComboBox.FormattingEnabled = true;
            this.restaurantComboBox.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied",
            "Neutral"});
            this.restaurantComboBox.Location = new System.Drawing.Point(1031, 250);
            this.restaurantComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.restaurantComboBox.Name = "restaurantComboBox";
            this.restaurantComboBox.Size = new System.Drawing.Size(343, 34);
            this.restaurantComboBox.TabIndex = 12;
            // 
            // valueformoneyBox
            // 
            this.valueformoneyBox.FormattingEnabled = true;
            this.valueformoneyBox.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied",
            "Neutral"});
            this.valueformoneyBox.Location = new System.Drawing.Point(315, 411);
            this.valueformoneyBox.Margin = new System.Windows.Forms.Padding(4);
            this.valueformoneyBox.Name = "valueformoneyBox";
            this.valueformoneyBox.Size = new System.Drawing.Size(343, 34);
            this.valueformoneyBox.TabIndex = 13;
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Location = new System.Drawing.Point(136, 113);
            this.phoneNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(126, 26);
            this.phoneNoLabel.TabIndex = 14;
            this.phoneNoLabel.Text = "Phone No:";
            this.phoneNoLabel.Click += new System.EventHandler(this.Click_label);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(193, 181);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 26);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(165, 244);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(98, 26);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Food Quality";
            // 
            // staffFriendlinessLabel
            // 
            this.staffFriendlinessLabel.AutoSize = true;
            this.staffFriendlinessLabel.Location = new System.Drawing.Point(752, 332);
            this.staffFriendlinessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffFriendlinessLabel.Name = "staffFriendlinessLabel";
            this.staffFriendlinessLabel.Size = new System.Drawing.Size(206, 26);
            this.staffFriendlinessLabel.TabIndex = 19;
            this.staffFriendlinessLabel.Text = "Staff Friendliness";
            // 
            // cleanlinessLabel
            // 
            this.cleanlinessLabel.AutoSize = true;
            this.cleanlinessLabel.Location = new System.Drawing.Point(809, 174);
            this.cleanlinessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cleanlinessLabel.Name = "cleanlinessLabel";
            this.cleanlinessLabel.Size = new System.Drawing.Size(137, 26);
            this.cleanlinessLabel.TabIndex = 20;
            this.cleanlinessLabel.Text = "Cleanliness";
            // 
            // orderAccuracLabel
            // 
            this.orderAccuracLabel.AutoSize = true;
            this.orderAccuracLabel.Location = new System.Drawing.Point(758, 83);
            this.orderAccuracLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderAccuracLabel.Name = "orderAccuracLabel";
            this.orderAccuracLabel.Size = new System.Drawing.Size(181, 26);
            this.orderAccuracLabel.TabIndex = 21;
            this.orderAccuracLabel.Text = "Order Accuracy";
            // 
            // restaurantAmbianeLabel
            // 
            this.restaurantAmbianeLabel.AutoSize = true;
            this.restaurantAmbianeLabel.Location = new System.Drawing.Point(711, 252);
            this.restaurantAmbianeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restaurantAmbianeLabel.Name = "restaurantAmbianeLabel";
            this.restaurantAmbianeLabel.Size = new System.Drawing.Size(247, 26);
            this.restaurantAmbianeLabel.TabIndex = 22;
            this.restaurantAmbianeLabel.Text = "Restaurant Ambiance";
            this.restaurantAmbianeLabel.Click += new System.EventHandler(this.label_Click);
            // 
            // valueformoneLabel
            // 
            this.valueformoneLabel.AutoSize = true;
            this.valueformoneLabel.Location = new System.Drawing.Point(70, 411);
            this.valueformoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueformoneLabel.Name = "valueformoneLabel";
            this.valueformoneLabel.Size = new System.Drawing.Size(192, 26);
            this.valueformoneLabel.TabIndex = 23;
            this.valueformoneLabel.Text = "Value for Money";
            // 
            // ratingdateLabel
            // 
            this.ratingdateLabel.AutoSize = true;
            this.ratingdateLabel.Location = new System.Drawing.Point(824, 419);
            this.ratingdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingdateLabel.Name = "ratingdateLabel";
            this.ratingdateLabel.Size = new System.Drawing.Size(142, 26);
            this.ratingdateLabel.TabIndex = 24;
            this.ratingdateLabel.Text = "Rating Date";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBoxForm.Controls.Add(this.groupBoxButton);
            this.groupBoxForm.Controls.Add(this.txtName);
            this.groupBoxForm.Controls.Add(this.ratingdateLabel);
            this.groupBoxForm.Controls.Add(this.txtPhone);
            this.groupBoxForm.Controls.Add(this.valueformoneLabel);
            this.groupBoxForm.Controls.Add(this.txtAddress);
            this.groupBoxForm.Controls.Add(this.restaurantAmbianeLabel);
            this.groupBoxForm.Controls.Add(this.comboBoxFood);
            this.groupBoxForm.Controls.Add(this.orderAccuracLabel);
            this.groupBoxForm.Controls.Add(this.comboboxdateTimePicker);
            this.groupBoxForm.Controls.Add(this.cleanlinessLabel);
            this.groupBoxForm.Controls.Add(this.comboBoxFriendliness);
            this.groupBoxForm.Controls.Add(this.staffFriendlinessLabel);
            this.groupBoxForm.Controls.Add(this.cleanlinessBox);
            this.groupBoxForm.Controls.Add(this.label5);
            this.groupBoxForm.Controls.Add(this.orderAccuracyBox);
            this.groupBoxForm.Controls.Add(this.addressLabel);
            this.groupBoxForm.Controls.Add(this.restaurantComboBox);
            this.groupBoxForm.Controls.Add(this.nameLabel);
            this.groupBoxForm.Controls.Add(this.valueformoneyBox);
            this.groupBoxForm.Controls.Add(this.phoneNoLabel);
            this.groupBoxForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxForm.Location = new System.Drawing.Point(124, 87);
            this.groupBoxForm.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxForm.Size = new System.Drawing.Size(1433, 666);
            this.groupBoxForm.TabIndex = 25;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Tag = "";
            this.groupBoxForm.Text = "Entry Fields";
            this.groupBoxForm.Enter += new System.EventHandler(this.enter_GroupBox);
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonSubmit);
            this.groupBoxButton.Controls.Add(this.buttonClose);
            this.groupBoxButton.Location = new System.Drawing.Point(531, 516);
            this.groupBoxButton.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxButton.Size = new System.Drawing.Size(463, 123);
            this.groupBoxButton.TabIndex = 25;
            this.groupBoxButton.TabStop = false;
            this.groupBoxButton.Enter += new System.EventHandler(this.entergroup_Box);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(692, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rate Our Services";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ratingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1687, 780);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ratingForm";
            this.Text = "Rating Management System";
            this.Load += new System.EventHandler(this.Rating_Form);
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.groupBoxButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.DateTimePicker comboboxdateTimePicker;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxFriendliness;
        private System.Windows.Forms.ComboBox cleanlinessBox;
        private System.Windows.Forms.ComboBox orderAccuracyBox;
        private System.Windows.Forms.ComboBox restaurantComboBox;
        private System.Windows.Forms.ComboBox valueformoneyBox;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label staffFriendlinessLabel;
        private System.Windows.Forms.Label cleanlinessLabel;
        private System.Windows.Forms.Label orderAccuracLabel;
        private System.Windows.Forms.Label restaurantAmbianeLabel;
        private System.Windows.Forms.Label valueformoneLabel;
        private System.Windows.Forms.Label ratingdateLabel;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxButton;
    }
}