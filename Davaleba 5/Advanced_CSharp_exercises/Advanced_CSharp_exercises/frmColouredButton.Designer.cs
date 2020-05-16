namespace Advanced_CSharp_exercises
{
    partial class frmColouredButton
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
            this.btnPink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.White;
            this.btnPink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPink.Location = new System.Drawing.Point(25, 24);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(125, 44);
            this.btnPink.TabIndex = 0;
            this.btnPink.Text = "Make pinker";
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // frmColouredButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 92);
            this.Controls.Add(this.btnPink);
            this.Name = "frmColouredButton";
            this.Text = "Pinky!";
            this.Load += new System.EventHandler(this.frmColouredButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPink;
    }
}