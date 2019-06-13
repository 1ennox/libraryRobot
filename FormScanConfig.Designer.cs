namespace SingleReaderTest
{
    partial class FormScanConfig
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
            this.p_Antenna = new System.Windows.Forms.Panel();
            this.a4 = new System.Windows.Forms.CheckBox();
            this.a3 = new System.Windows.Forms.CheckBox();
            this.a2 = new System.Windows.Forms.CheckBox();
            this.a1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbLoop = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbReadMB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numQ = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pa4 = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.pa3 = new System.Windows.Forms.ComboBox();
            this.pa2 = new System.Windows.Forms.ComboBox();
            this.lblpa4 = new System.Windows.Forms.Label();
            this.lblpa3 = new System.Windows.Forms.Label();
            this.lblpa2 = new System.Windows.Forms.Label();
            this.lblpa1 = new System.Windows.Forms.Label();
            this.pa1 = new System.Windows.Forms.ComboBox();
            this.p_Antenna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Antenna
            // 
            this.p_Antenna.Controls.Add(this.a4);
            this.p_Antenna.Controls.Add(this.a3);
            this.p_Antenna.Controls.Add(this.a2);
            this.p_Antenna.Controls.Add(this.a1);
            this.p_Antenna.Location = new System.Drawing.Point(110, 50);
            this.p_Antenna.Name = "p_Antenna";
            this.p_Antenna.Size = new System.Drawing.Size(138, 28);
            this.p_Antenna.TabIndex = 8;
            // 
            // a4
            // 
            this.a4.AutoSize = true;
            this.a4.Location = new System.Drawing.Point(103, 5);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(32, 17);
            this.a4.TabIndex = 9;
            this.a4.Text = "4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Location = new System.Drawing.Point(72, 5);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(32, 17);
            this.a3.TabIndex = 9;
            this.a3.Text = "3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Location = new System.Drawing.Point(37, 5);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(32, 17);
            this.a2.TabIndex = 9;
            this.a2.Text = "2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(6, 5);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(32, 17);
            this.a1.TabIndex = 9;
            this.a1.Text = "1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Antanna:";
            // 
            // rbLoop
            // 
            this.rbLoop.AutoSize = true;
            this.rbLoop.Checked = true;
            this.rbLoop.Location = new System.Drawing.Point(110, 82);
            this.rbLoop.Name = "rbLoop";
            this.rbLoop.Size = new System.Drawing.Size(78, 17);
            this.rbLoop.TabIndex = 6;
            this.rbLoop.TabStop = true;
            this.rbLoop.Text = "Continuous";
            this.rbLoop.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(200, 82);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 17);
            this.rbSingle.TabIndex = 6;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Read type:";
            // 
            // cbReadMB
            // 
            this.cbReadMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReadMB.FormattingEnabled = true;
            this.cbReadMB.Items.AddRange(new object[] {
            "EPC_6C",
            "TID_6C",
            "EPC_TID_UserData_6C",
            "EPC_TID_UserData_6C_2",
            "ID_6B",
            "ID_UserData_6B",
            "EPC_6C_ID_6B",
            "TID_6C_ID_6B",
            "EPC_TID_UserData_6C_ID_UserData_6B",
            "EPC_PC_6C",
            "EPC_TID_UserData_Reserved_6C_ID_UserData_6B"});
            this.cbReadMB.Location = new System.Drawing.Point(110, 22);
            this.cbReadMB.Name = "cbReadMB";
            this.cbReadMB.Size = new System.Drawing.Size(322, 21);
            this.cbReadMB.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Read mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Q code: ";
            // 
            // numQ
            // 
            this.numQ.Location = new System.Drawing.Point(110, 106);
            this.numQ.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numQ.Name = "numQ";
            this.numQ.Size = new System.Drawing.Size(67, 20);
            this.numQ.TabIndex = 31;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(351, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pa4);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.pa3);
            this.groupBox1.Controls.Add(this.pa2);
            this.groupBox1.Controls.Add(this.lblpa4);
            this.groupBox1.Controls.Add(this.lblpa3);
            this.groupBox1.Controls.Add(this.lblpa2);
            this.groupBox1.Controls.Add(this.lblpa1);
            this.groupBox1.Controls.Add(this.pa1);
            this.groupBox1.Location = new System.Drawing.Point(254, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 107);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antanna power: (dBm)";
            // 
            // pa4
            // 
            this.pa4.FormattingEnabled = true;
            this.pa4.Location = new System.Drawing.Point(126, 49);
            this.pa4.Name = "pa4";
            this.pa4.Size = new System.Drawing.Size(44, 21);
            this.pa4.TabIndex = 34;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(16, 77);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 25);
            this.btnQuery.TabIndex = 32;
            this.btnQuery.Text = "Read";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(97, 77);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 25);
            this.btnSet.TabIndex = 32;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pa3
            // 
            this.pa3.FormattingEnabled = true;
            this.pa3.Location = new System.Drawing.Point(126, 21);
            this.pa3.Name = "pa3";
            this.pa3.Size = new System.Drawing.Size(44, 21);
            this.pa3.TabIndex = 34;
            // 
            // pa2
            // 
            this.pa2.FormattingEnabled = true;
            this.pa2.Location = new System.Drawing.Point(41, 49);
            this.pa2.Name = "pa2";
            this.pa2.Size = new System.Drawing.Size(44, 21);
            this.pa2.TabIndex = 34;
            // 
            // lblpa4
            // 
            this.lblpa4.AutoSize = true;
            this.lblpa4.Location = new System.Drawing.Point(90, 53);
            this.lblpa4.Name = "lblpa4";
            this.lblpa4.Size = new System.Drawing.Size(32, 13);
            this.lblpa4.TabIndex = 30;
            this.lblpa4.Text = "4#：";
            // 
            // lblpa3
            // 
            this.lblpa3.AutoSize = true;
            this.lblpa3.Location = new System.Drawing.Point(91, 25);
            this.lblpa3.Name = "lblpa3";
            this.lblpa3.Size = new System.Drawing.Size(32, 13);
            this.lblpa3.TabIndex = 30;
            this.lblpa3.Text = "3#：";
            // 
            // lblpa2
            // 
            this.lblpa2.AutoSize = true;
            this.lblpa2.Location = new System.Drawing.Point(6, 53);
            this.lblpa2.Name = "lblpa2";
            this.lblpa2.Size = new System.Drawing.Size(32, 13);
            this.lblpa2.TabIndex = 30;
            this.lblpa2.Text = "2#：";
            // 
            // lblpa1
            // 
            this.lblpa1.AutoSize = true;
            this.lblpa1.Location = new System.Drawing.Point(6, 25);
            this.lblpa1.Name = "lblpa1";
            this.lblpa1.Size = new System.Drawing.Size(32, 13);
            this.lblpa1.TabIndex = 30;
            this.lblpa1.Text = "1#：";
            // 
            // pa1
            // 
            this.pa1.FormattingEnabled = true;
            this.pa1.Location = new System.Drawing.Point(41, 21);
            this.pa1.Name = "pa1";
            this.pa1.Size = new System.Drawing.Size(44, 21);
            this.pa1.TabIndex = 34;
            // 
            // FormScanConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_Antenna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbLoop);
            this.Controls.Add(this.cbReadMB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbSingle);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScanConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scan Config";
            this.p_Antenna.ResumeLayout(false);
            this.p_Antenna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_Antenna;
        private System.Windows.Forms.CheckBox a4;
        private System.Windows.Forms.CheckBox a3;
        private System.Windows.Forms.CheckBox a2;
        private System.Windows.Forms.CheckBox a1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbLoop;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbReadMB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQ;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox pa4;
        private System.Windows.Forms.ComboBox pa3;
        private System.Windows.Forms.ComboBox pa2;
        private System.Windows.Forms.Label lblpa4;
        private System.Windows.Forms.Label lblpa3;
        private System.Windows.Forms.Label lblpa2;
        private System.Windows.Forms.Label lblpa1;
        private System.Windows.Forms.ComboBox pa1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnQuery;
    }
}