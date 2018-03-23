namespace SportFacilityBookingSystem
{
    partial class Facility_Information
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
            this.btnFacilityAdd = new System.Windows.Forms.Button();
            this.btnFacilityCancel = new System.Windows.Forms.Button();
            this.btnFacilityEdit = new System.Windows.Forms.Button();
            this.btnFacilityDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFacilityAdd
            // 
            this.btnFacilityAdd.Location = new System.Drawing.Point(73, 104);
            this.btnFacilityAdd.Name = "btnFacilityAdd";
            this.btnFacilityAdd.Size = new System.Drawing.Size(136, 64);
            this.btnFacilityAdd.TabIndex = 10;
            this.btnFacilityAdd.Text = "Add";
            this.btnFacilityAdd.UseVisualStyleBackColor = true;
            this.btnFacilityAdd.Click += new System.EventHandler(this.btnFacilityAdd_Click);
            // 
            // btnFacilityCancel
            // 
            this.btnFacilityCancel.Location = new System.Drawing.Point(735, 613);
            this.btnFacilityCancel.Name = "btnFacilityCancel";
            this.btnFacilityCancel.Size = new System.Drawing.Size(121, 74);
            this.btnFacilityCancel.TabIndex = 9;
            this.btnFacilityCancel.Text = "Cancel";
            this.btnFacilityCancel.UseVisualStyleBackColor = true;
            this.btnFacilityCancel.Click += new System.EventHandler(this.btnFacilityCancel_Click);
            // 
            // btnFacilityEdit
            // 
            this.btnFacilityEdit.Location = new System.Drawing.Point(215, 104);
            this.btnFacilityEdit.Name = "btnFacilityEdit";
            this.btnFacilityEdit.Size = new System.Drawing.Size(127, 64);
            this.btnFacilityEdit.TabIndex = 8;
            this.btnFacilityEdit.Text = "Edit";
            this.btnFacilityEdit.UseVisualStyleBackColor = true;
            this.btnFacilityEdit.Click += new System.EventHandler(this.btnFacilityEdit_Click);
            // 
            // btnFacilityDelete
            // 
            this.btnFacilityDelete.Location = new System.Drawing.Point(348, 104);
            this.btnFacilityDelete.Name = "btnFacilityDelete";
            this.btnFacilityDelete.Size = new System.Drawing.Size(121, 64);
            this.btnFacilityDelete.TabIndex = 7;
            this.btnFacilityDelete.Text = "Delete";
            this.btnFacilityDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(783, 394);
            this.dataGridView1.TabIndex = 6;
            // 
            // Facility_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 790);
            this.Controls.Add(this.btnFacilityAdd);
            this.Controls.Add(this.btnFacilityCancel);
            this.Controls.Add(this.btnFacilityEdit);
            this.Controls.Add(this.btnFacilityDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Facility_Information";
            this.Text = "Facility_Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacilityAdd;
        private System.Windows.Forms.Button btnFacilityCancel;
        private System.Windows.Forms.Button btnFacilityEdit;
        private System.Windows.Forms.Button btnFacilityDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}