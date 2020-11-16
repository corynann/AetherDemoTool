namespace Aether.DemoTool
{
    partial class form_AetherStartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_AetherStartWindow));
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.lbl_OperationNumber = new System.Windows.Forms.Label();
            this.num_OperationNumber = new System.Windows.Forms.NumericUpDown();
            this.num_PartNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbl_PIPfileName = new System.Windows.Forms.Label();
            this.txt_PIPfileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_PartNumber = new System.Windows.Forms.ComboBox();
            this.txt_OperationNumbers = new System.Windows.Forms.Label();
            this.pic_Preview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_OperationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PartNumber
            // 
            this.lbl_PartNumber.AutoSize = true;
            this.lbl_PartNumber.Location = new System.Drawing.Point(39, 47);
            this.lbl_PartNumber.Name = "lbl_PartNumber";
            this.lbl_PartNumber.Size = new System.Drawing.Size(66, 13);
            this.lbl_PartNumber.TabIndex = 0;
            this.lbl_PartNumber.Text = "Part Number";
            // 
            // lbl_OperationNumber
            // 
            this.lbl_OperationNumber.AutoSize = true;
            this.lbl_OperationNumber.Location = new System.Drawing.Point(12, 72);
            this.lbl_OperationNumber.Name = "lbl_OperationNumber";
            this.lbl_OperationNumber.Size = new System.Drawing.Size(93, 13);
            this.lbl_OperationNumber.TabIndex = 1;
            this.lbl_OperationNumber.Text = "Operation Number";
            // 
            // num_OperationNumber
            // 
            this.num_OperationNumber.Location = new System.Drawing.Point(111, 70);
            this.num_OperationNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_OperationNumber.Name = "num_OperationNumber";
            this.num_OperationNumber.Size = new System.Drawing.Size(80, 20);
            this.num_OperationNumber.TabIndex = 3;
            this.num_OperationNumber.ValueChanged += new System.EventHandler(this.num_OperationNumber_ValueChanged);
            // 
            // num_PartNumber
            // 
            this.num_PartNumber.Location = new System.Drawing.Point(111, 44);
            this.num_PartNumber.Name = "num_PartNumber";
            this.num_PartNumber.Size = new System.Drawing.Size(100, 20);
            this.num_PartNumber.TabIndex = 4;
            // 
            // lbl_PIPfileName
            // 
            this.lbl_PIPfileName.AutoSize = true;
            this.lbl_PIPfileName.Location = new System.Drawing.Point(0, 132);
            this.lbl_PIPfileName.Name = "lbl_PIPfileName";
            this.lbl_PIPfileName.Size = new System.Drawing.Size(77, 13);
            this.lbl_PIPfileName.TabIndex = 5;
            this.lbl_PIPfileName.Text = "PIP File Name:";
            // 
            // txt_PIPfileName
            // 
            this.txt_PIPfileName.AutoSize = true;
            this.txt_PIPfileName.Location = new System.Drawing.Point(80, 132);
            this.txt_PIPfileName.Name = "txt_PIPfileName";
            this.txt_PIPfileName.Size = new System.Drawing.Size(98, 13);
            this.txt_PIPfileName.TabIndex = 6;
            this.txt_PIPfileName.Text = "<<PIP File Name>>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fill out the fields below to have Aether select the correct PIP for your given jo" +
    "b.";
            // 
            // cBox_PartNumber
            // 
            this.cBox_PartNumber.FormattingEnabled = true;
            this.cBox_PartNumber.Location = new System.Drawing.Point(217, 44);
            this.cBox_PartNumber.Name = "cBox_PartNumber";
            this.cBox_PartNumber.Size = new System.Drawing.Size(121, 21);
            this.cBox_PartNumber.TabIndex = 9;
            this.cBox_PartNumber.Text = "Use this to help out";
            this.cBox_PartNumber.SelectedIndexChanged += new System.EventHandler(this.cBox_PartNumber_SelectedIndexChanged);
            // 
            // txt_OperationNumbers
            // 
            this.txt_OperationNumbers.AutoSize = true;
            this.txt_OperationNumbers.Location = new System.Drawing.Point(197, 77);
            this.txt_OperationNumbers.Name = "txt_OperationNumbers";
            this.txt_OperationNumbers.Size = new System.Drawing.Size(68, 13);
            this.txt_OperationNumbers.TabIndex = 10;
            this.txt_OperationNumbers.Text = "<helper info>";
            // 
            // pic_Preview
            // 
            this.pic_Preview.Location = new System.Drawing.Point(15, 161);
            this.pic_Preview.Name = "pic_Preview";
            this.pic_Preview.Size = new System.Drawing.Size(198, 149);
            this.pic_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Preview.TabIndex = 11;
            this.pic_Preview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Picture of part for preview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "<-- This could be auto generated from Aether\r\nor could be overriden if a programm" +
    "er chooses";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // form_AetherStartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_Preview);
            this.Controls.Add(this.txt_OperationNumbers);
            this.Controls.Add(this.cBox_PartNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PIPfileName);
            this.Controls.Add(this.lbl_PIPfileName);
            this.Controls.Add(this.num_PartNumber);
            this.Controls.Add(this.num_OperationNumber);
            this.Controls.Add(this.lbl_OperationNumber);
            this.Controls.Add(this.lbl_PartNumber);
            this.Name = "form_AetherStartWindow";
            this.Text = "Aether Start Window - Operator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_OperationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.Label lbl_OperationNumber;
        private System.Windows.Forms.NumericUpDown num_OperationNumber;
        private System.Windows.Forms.MaskedTextBox num_PartNumber;
        private System.Windows.Forms.Label lbl_PIPfileName;
        private System.Windows.Forms.Label txt_PIPfileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_PartNumber;
        private System.Windows.Forms.Label txt_OperationNumbers;
        private System.Windows.Forms.PictureBox pic_Preview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

