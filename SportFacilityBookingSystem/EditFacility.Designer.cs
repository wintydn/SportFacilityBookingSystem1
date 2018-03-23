namespace SportFacilityBookingSystem
{
    partial class EditFacility
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
            this.btnFCancel = new System.Windows.Forms.Button();
            this.btnaddF = new System.Windows.Forms.Button();
            this.tbaddFN = new System.Windows.Forms.TextBox();
            this.tbaddFC = new System.Windows.Forms.TextBox();
            this.lbFN = new System.Windows.Forms.Label();
            this.lbFC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFCancel
            // 
            this.btnFCancel.Location = new System.Drawing.Point(533, 360);
            this.btnFCancel.Name = "btnFCancel";
            this.btnFCancel.Size = new System.Drawing.Size(119, 68);
            this.btnFCancel.TabIndex = 11;
            this.btnFCancel.Text = "Cancel";
            this.btnFCancel.UseVisualStyleBackColor = true;
            // 
            // btnaddF
            // 
            this.btnaddF.Location = new System.Drawing.Point(302, 361);
            this.btnaddF.Name = "btnaddF";
            this.btnaddF.Size = new System.Drawing.Size(121, 67);
            this.btnaddF.TabIndex = 10;
            this.btnaddF.Text = "Update";
            this.btnaddF.UseVisualStyleBackColor = true;
            // 
            // tbaddFN
            // 
            this.tbaddFN.Location = new System.Drawing.Point(413, 159);
            this.tbaddFN.Multiline = true;
            this.tbaddFN.Name = "tbaddFN";
            this.tbaddFN.Size = new System.Drawing.Size(251, 50);
            this.tbaddFN.TabIndex = 9;
            // 
            // tbaddFC
            // 
            this.tbaddFC.Location = new System.Drawing.Point(413, 73);
            this.tbaddFC.Multiline = true;
            this.tbaddFC.Name = "tbaddFC";
            this.tbaddFC.ReadOnly = true;
            this.tbaddFC.Size = new System.Drawing.Size(251, 45);
            this.tbaddFC.TabIndex = 8;
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Location = new System.Drawing.Point(232, 171);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(159, 29);
            this.lbFN.TabIndex = 7;
            this.lbFN.Text = "Facility Name";
            // 
            // lbFC
            // 
            this.lbFC.AutoSize = true;
            this.lbFC.Location = new System.Drawing.Point(232, 76);
            this.lbFC.Name = "lbFC";
            this.lbFC.Size = new System.Drawing.Size(153, 29);
            this.lbFC.TabIndex = 6;
            this.lbFC.Text = "Facility Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 50);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bad Condition";
            // 
            // EditFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 746);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFCancel);
            this.Controls.Add(this.btnaddF);
            this.Controls.Add(this.tbaddFN);
            this.Controls.Add(this.tbaddFC);
            this.Controls.Add(this.lbFN);
            this.Controls.Add(this.lbFC);
            this.Name = "EditFacility";
            this.Text = "EditFacility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFCancel;
        private System.Windows.Forms.Button btnaddF;
        private System.Windows.Forms.TextBox tbaddFN;
        private System.Windows.Forms.TextBox tbaddFC;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.Label lbFC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}