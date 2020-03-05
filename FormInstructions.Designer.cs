namespace Part_6._5
{
    partial class frmInst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInst));
            this.lblIns = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.BackColor = System.Drawing.Color.Transparent;
            this.lblIns.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns.Location = new System.Drawing.Point(12, 9);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(790, 350);
            this.lblIns.TabIndex = 0;
            this.lblIns.Text = resources.GetString("lblIns.Text");
            this.lblIns.Click += new System.EventHandler(this.lblIns_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(828, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 59);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Part_6._5.Properties.Resources.RPS;
            this.ClientSize = new System.Drawing.Size(927, 407);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblIns);
            this.Name = "frmInst";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIns;
        private System.Windows.Forms.Button btnBack;
    }
}