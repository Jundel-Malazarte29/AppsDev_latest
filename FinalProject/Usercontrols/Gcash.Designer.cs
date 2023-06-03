namespace FinalProject.Usercontrols
{
    partial class Gcash
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gcash));
            this.nextBTN = new System.Windows.Forms.Button();
            this.itemdescription1 = new FinalProject.Usercontrols.Itemdescription();
            this.SuspendLayout();
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.nextBTN.FlatAppearance.BorderSize = 0;
            this.nextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextBTN.Location = new System.Drawing.Point(188, 377);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(106, 23);
            this.nextBTN.TabIndex = 0;
            this.nextBTN.Text = "Next";
            this.nextBTN.UseVisualStyleBackColor = false;
            // 
            // itemdescription1
            // 
            this.itemdescription1.Location = new System.Drawing.Point(369, 371);
            this.itemdescription1.Name = "itemdescription1";
            this.itemdescription1.Size = new System.Drawing.Size(455, 387);
            this.itemdescription1.TabIndex = 1;
            // 
            // Gcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.itemdescription1);
            this.Controls.Add(this.nextBTN);
            this.DoubleBuffered = true;
            this.Name = "Gcash";
            this.Size = new System.Drawing.Size(480, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextBTN;
        private Itemdescription itemdescription1;
    }
}
