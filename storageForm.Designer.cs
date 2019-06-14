namespace SingleReaderTest
{
    partial class storageForm
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
            this.storageDBView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearStorageDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storageDBView)).BeginInit();
            this.SuspendLayout();
            // 
            // storageDBView
            // 
            this.storageDBView.AllowUserToAddRows = false;
            this.storageDBView.AllowUserToDeleteRows = false;
            this.storageDBView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storageDBView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDBView.Location = new System.Drawing.Point(58, 40);
            this.storageDBView.Name = "storageDBView";
            this.storageDBView.RowTemplate.Height = 23;
            this.storageDBView.Size = new System.Drawing.Size(655, 340);
            this.storageDBView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here are all the storage books";
            // 
            // btnClearStorageDB
            // 
            this.btnClearStorageDB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStorageDB.Location = new System.Drawing.Point(338, 397);
            this.btnClearStorageDB.Name = "btnClearStorageDB";
            this.btnClearStorageDB.Size = new System.Drawing.Size(75, 23);
            this.btnClearStorageDB.TabIndex = 2;
            this.btnClearStorageDB.Text = "clear";
            this.btnClearStorageDB.UseVisualStyleBackColor = true;
            this.btnClearStorageDB.Click += new System.EventHandler(this.BtnClearStorageDB_Click);
            // 
            // storageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearStorageDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storageDBView);
            this.Name = "storageForm";
            this.Text = "storageForm";
            ((System.ComponentModel.ISupportInitialize)(this.storageDBView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView storageDBView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearStorageDB;
    }
}