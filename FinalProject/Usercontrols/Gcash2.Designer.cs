namespace FinalProject.Usercontrols
{
    partial class Gcash2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gcash2));
            this.next2BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next2BTN
            // 
            this.next2BTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.next2BTN.FlatAppearance.BorderSize = 0;
            this.next2BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next2BTN.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.next2BTN.Location = new System.Drawing.Point(188, 370);
            this.next2BTN.Name = "next2BTN";
            this.next2BTN.Size = new System.Drawing.Size(106, 23);
            this.next2BTN.TabIndex = 1;
            this.next2BTN.Text = "Next";
            this.next2BTN.UseVisualStyleBackColor = false;
            // 
            // Gcash2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.next2BTN);
            this.DoubleBuffered = true;
            this.Name = "Gcash2";
            this.Size = new System.Drawing.Size(480, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button next2BTN;
    }
}
