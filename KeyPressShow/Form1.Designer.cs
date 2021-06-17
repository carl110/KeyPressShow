
namespace KeyPressShow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxUp = new System.Windows.Forms.PictureBox();
            this.pbxDown = new System.Windows.Forms.PictureBox();
            this.pbxLeft = new System.Windows.Forms.PictureBox();
            this.pbxRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxUp
            // 
            this.pbxUp.Location = new System.Drawing.Point(286, 59);
            this.pbxUp.Name = "pbxUp";
            this.pbxUp.Size = new System.Drawing.Size(120, 120);
            this.pbxUp.TabIndex = 0;
            this.pbxUp.TabStop = false;
            // 
            // pbxDown
            // 
            this.pbxDown.Location = new System.Drawing.Point(286, 185);
            this.pbxDown.Name = "pbxDown";
            this.pbxDown.Size = new System.Drawing.Size(120, 120);
            this.pbxDown.TabIndex = 1;
            this.pbxDown.TabStop = false;
            // 
            // pbxLeft
            // 
            this.pbxLeft.Location = new System.Drawing.Point(160, 185);
            this.pbxLeft.Name = "pbxLeft";
            this.pbxLeft.Size = new System.Drawing.Size(120, 120);
            this.pbxLeft.TabIndex = 2;
            this.pbxLeft.TabStop = false;
            // 
            // pbxRight
            // 
            this.pbxRight.Location = new System.Drawing.Point(412, 185);
            this.pbxRight.Name = "pbxRight";
            this.pbxRight.Size = new System.Drawing.Size(120, 120);
            this.pbxRight.TabIndex = 3;
            this.pbxRight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxRight);
            this.Controls.Add(this.pbxLeft);
            this.Controls.Add(this.pbxDown);
            this.Controls.Add(this.pbxUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUp;
        private System.Windows.Forms.PictureBox pbxDown;
        private System.Windows.Forms.PictureBox pbxLeft;
        private System.Windows.Forms.PictureBox pbxRight;
    }
}

