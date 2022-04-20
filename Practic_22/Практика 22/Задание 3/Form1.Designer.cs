
namespace Задание_3
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
            this.LabeX0 = new MaterialSkin.Controls.MaterialLabel();
            this.LabeXk = new MaterialSkin.Controls.MaterialLabel();
            this.LabeDx = new MaterialSkin.Controls.MaterialLabel();
            this.LabeA = new MaterialSkin.Controls.MaterialLabel();
            this.BoxX0 = new System.Windows.Forms.TextBox();
            this.BoxXk = new System.Windows.Forms.TextBox();
            this.BoxDx = new System.Windows.Forms.TextBox();
            this.BoxA = new System.Windows.Forms.TextBox();
            this.BoxWrite = new System.Windows.Forms.TextBox();
            this.ButtonStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LabeX0
            // 
            this.LabeX0.AutoSize = true;
            this.LabeX0.Depth = 0;
            this.LabeX0.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeX0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeX0.Location = new System.Drawing.Point(71, 103);
            this.LabeX0.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeX0.Name = "LabeX0";
            this.LabeX0.Size = new System.Drawing.Size(42, 19);
            this.LabeX0.TabIndex = 0;
            this.LabeX0.Text = "X0 = ";
            // 
            // LabeXk
            // 
            this.LabeXk.AutoSize = true;
            this.LabeXk.Depth = 0;
            this.LabeXk.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeXk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeXk.Location = new System.Drawing.Point(71, 147);
            this.LabeXk.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeXk.Name = "LabeXk";
            this.LabeXk.Size = new System.Drawing.Size(42, 19);
            this.LabeXk.TabIndex = 1;
            this.LabeXk.Text = "Xk = ";
            // 
            // LabeDx
            // 
            this.LabeDx.AutoSize = true;
            this.LabeDx.Depth = 0;
            this.LabeDx.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeDx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeDx.Location = new System.Drawing.Point(71, 187);
            this.LabeDx.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeDx.Name = "LabeDx";
            this.LabeDx.Size = new System.Drawing.Size(42, 19);
            this.LabeDx.TabIndex = 2;
            this.LabeDx.Text = "Dx = ";
            // 
            // LabeA
            // 
            this.LabeA.AutoSize = true;
            this.LabeA.Depth = 0;
            this.LabeA.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeA.Location = new System.Drawing.Point(71, 231);
            this.LabeA.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeA.Name = "LabeA";
            this.LabeA.Size = new System.Drawing.Size(35, 19);
            this.LabeA.TabIndex = 3;
            this.LabeA.Text = "A = ";
            // 
            // BoxX0
            // 
            this.BoxX0.Location = new System.Drawing.Point(174, 98);
            this.BoxX0.Name = "BoxX0";
            this.BoxX0.Size = new System.Drawing.Size(100, 23);
            this.BoxX0.TabIndex = 4;
            // 
            // BoxXk
            // 
            this.BoxXk.Location = new System.Drawing.Point(174, 142);
            this.BoxXk.Name = "BoxXk";
            this.BoxXk.Size = new System.Drawing.Size(100, 23);
            this.BoxXk.TabIndex = 5;
            // 
            // BoxDx
            // 
            this.BoxDx.Location = new System.Drawing.Point(174, 182);
            this.BoxDx.Name = "BoxDx";
            this.BoxDx.Size = new System.Drawing.Size(100, 23);
            this.BoxDx.TabIndex = 6;
            // 
            // BoxA
            // 
            this.BoxA.Location = new System.Drawing.Point(174, 226);
            this.BoxA.Name = "BoxA";
            this.BoxA.Size = new System.Drawing.Size(100, 23);
            this.BoxA.TabIndex = 7;
            // 
            // BoxWrite
            // 
            this.BoxWrite.Location = new System.Drawing.Point(71, 270);
            this.BoxWrite.Multiline = true;
            this.BoxWrite.Name = "BoxWrite";
            this.BoxWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxWrite.Size = new System.Drawing.Size(203, 142);
            this.BoxWrite.TabIndex = 8;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.Depth = 0;
            this.ButtonStart.Location = new System.Drawing.Point(71, 418);
            this.ButtonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Primary = true;
            this.ButtonStart.Size = new System.Drawing.Size(203, 27);
            this.ButtonStart.TabIndex = 9;
            this.ButtonStart.Text = "вычислить";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 487);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.BoxWrite);
            this.Controls.Add(this.BoxA);
            this.Controls.Add(this.BoxDx);
            this.Controls.Add(this.BoxXk);
            this.Controls.Add(this.BoxX0);
            this.Controls.Add(this.LabeA);
            this.Controls.Add(this.LabeDx);
            this.Controls.Add(this.LabeXk);
            this.Controls.Add(this.LabeX0);
            this.Name = "Form1";
            this.Text = "Задание 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabeX0;
        private MaterialSkin.Controls.MaterialLabel LabeXk;
        private MaterialSkin.Controls.MaterialLabel LabeDx;
        private MaterialSkin.Controls.MaterialLabel LabeA;
        private System.Windows.Forms.TextBox BoxX0;
        private System.Windows.Forms.TextBox BoxXk;
        private System.Windows.Forms.TextBox BoxDx;
        private System.Windows.Forms.TextBox BoxA;
        private System.Windows.Forms.TextBox BoxWrite;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonStart;
    }
}

