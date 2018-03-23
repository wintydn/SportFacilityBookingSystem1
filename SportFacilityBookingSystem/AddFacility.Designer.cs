namespace SportFacilityBookingSystem
{
    partial class AddFacility
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
            this.lbFC = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.tbaddFC = new System.Windows.Forms.TextBox();
            this.tbaddFN = new System.Windows.Forms.TextBox();
            this.btnaddF = new System.Windows.Forms.Button();
            this.btnFCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFC
            // 
            this.lbFC.AutoSize = true;
            this.lbFC.Location = new System.Drawing.Point(166, 64);
            this.lbFC.Name = "lbFC";
            this.lbFC.Size = new System.Drawing.Size(153, 29);
            this.lbFC.TabIndex = 0;
            this.lbFC.Text = "Facility Code";
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Location = new System.Drawing.Point(166, 159);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(159, 29);
            this.lbFN.TabIndex = 1;
            this.lbFN.Text = "Facility Name";
            // 
            // tbaddFC
            // 
            this.tbaddFC.Location = new System.Drawing.Point(347, 61);
            this.tbaddFC.Multiline = true;
            this.tbaddFC.Name = "tbaddFC";
            this.tbaddFC.Size = new System.Drawing.Size(251, 45);
            this.tbaddFC.TabIndex = 2;
            // 
            // tbaddFN
            // 
            this.tbaddFN.Location = new System.Drawing.Point(347, 147);
            this.tbaddFN.Multiline = true;
            this.tbaddFN.Name = "tbaddFN";
            this.tbaddFN.Size = new System.Drawing.Size(251, 50);
            this.tbaddFN.TabIndex = 3;
            // 
            // btnaddF
            // 
            this.btnaddF.Location = new System.Drawing.Point(247, 273);
            this.btnaddF.Name = "btnaddF";
            this.btnaddF.Size = new System.Drawing.Size(121, 67);
            this.btnaddF.TabIndex = 4;
            this.btnaddF.Text = "Add";
            this.btnaddF.UseVisualStyleBackColor = true;
            // 
            // btnFCancel
            // 
            this.btnFCancel.Location = new System.Drawing.Point(462, 272);
            this.btnFCancel.Name = "btnFCancel";
            this.btnFCancel.Size = new System.Drawing.Size(119, 68);
            this.btnFCancel.TabIndex = 5;
            this.btnFCancel.Text = "Cancel";
            this.btnFCancel.UseVisualStyleBackColor = true;
            // 
            // AddFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 544);
            this.Controls.Add(this.btnFCancel);
            this.Controls.Add(this.btnaddF);
            this.Controls.Add(this.tbaddFN);
            this.Controls.Add(this.tbaddFC);
            this.Controls.Add(this.lbFN);
            this.Controls.Add(this.lbFC);
            this.Name = "AddFacility";
            this.Text = "AddFacility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFC;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.TextBox tbaddFC;
        private System.Windows.Forms.TextBox tbaddFN;
        private System.Windows.Forms.Button btnaddF;
        private System.Windows.Forms.Button btnFCancel;
    }
}