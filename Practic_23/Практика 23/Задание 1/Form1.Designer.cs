
namespace Задание_1
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
            this.LabeZ = new MaterialSkin.Controls.MaterialLabel();
            this.LabeD = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonZ = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonD = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ListZ = new System.Windows.Forms.ListBox();
            this.ListD = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LabeZ
            // 
            this.LabeZ.AutoSize = true;
            this.LabeZ.Depth = 0;
            this.LabeZ.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeZ.Location = new System.Drawing.Point(16, 79);
            this.LabeZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeZ.Name = "LabeZ";
            this.LabeZ.Size = new System.Drawing.Size(77, 19);
            this.LabeZ.TabIndex = 0;
            this.LabeZ.Text = "Массив Z";
            // 
            // LabeD
            // 
            this.LabeD.AutoSize = true;
            this.LabeD.Depth = 0;
            this.LabeD.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeD.Location = new System.Drawing.Point(239, 82);
            this.LabeD.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeD.Name = "LabeD";
            this.LabeD.Size = new System.Drawing.Size(78, 19);
            this.LabeD.TabIndex = 1;
            this.LabeD.Text = "Массив D";
            // 
            // ButtonZ
            // 
            this.ButtonZ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonZ.Depth = 0;
            this.ButtonZ.Location = new System.Drawing.Point(16, 368);
            this.ButtonZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonZ.Name = "ButtonZ";
            this.ButtonZ.Primary = true;
            this.ButtonZ.Size = new System.Drawing.Size(195, 36);
            this.ButtonZ.TabIndex = 2;
            this.ButtonZ.Text = "Fill Array Z";
            this.ButtonZ.UseVisualStyleBackColor = true;
            this.ButtonZ.Click += new System.EventHandler(this.ButtonZ_Click);
            // 
            // ButtonD
            // 
            this.ButtonD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonD.Depth = 0;
            this.ButtonD.Location = new System.Drawing.Point(239, 368);
            this.ButtonD.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Primary = true;
            this.ButtonD.Size = new System.Drawing.Size(196, 36);
            this.ButtonD.TabIndex = 3;
            this.ButtonD.Text = "Fill Array D";
            this.ButtonD.UseVisualStyleBackColor = true;
            this.ButtonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // ListZ
            // 
            this.ListZ.FormattingEnabled = true;
            this.ListZ.ItemHeight = 15;
            this.ListZ.Location = new System.Drawing.Point(16, 118);
            this.ListZ.Name = "ListZ";
            this.ListZ.Size = new System.Drawing.Size(195, 244);
            this.ListZ.TabIndex = 4;
            // 
            // ListD
            // 
            this.ListD.FormattingEnabled = true;
            this.ListD.ItemHeight = 15;
            this.ListD.Location = new System.Drawing.Point(239, 117);
            this.ListD.Name = "ListD";
            this.ListD.Size = new System.Drawing.Size(196, 244);
            this.ListD.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 416);
            this.Controls.Add(this.ListD);
            this.Controls.Add(this.ListZ);
            this.Controls.Add(this.ButtonD);
            this.Controls.Add(this.ButtonZ);
            this.Controls.Add(this.LabeD);
            this.Controls.Add(this.LabeZ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabeZ;
        private MaterialSkin.Controls.MaterialLabel LabeD;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonZ;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonD;
        private System.Windows.Forms.ListBox ListZ;
        private System.Windows.Forms.ListBox ListD;
    }
}

