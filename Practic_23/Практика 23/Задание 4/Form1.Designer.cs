
namespace Задание_4
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
            this.ButtonCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LabeLetter = new MaterialSkin.Controls.MaterialLabel();
            this.LabeXY = new MaterialSkin.Controls.MaterialLabel();
            this.BoxLetter = new System.Windows.Forms.TextBox();
            this.BoxX = new System.Windows.Forms.TextBox();
            this.BoxY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonCreate.Depth = 0;
            this.ButtonCreate.Location = new System.Drawing.Point(228, 244);
            this.ButtonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Primary = true;
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Создать";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // LabeLetter
            // 
            this.LabeLetter.AutoSize = true;
            this.LabeLetter.Depth = 0;
            this.LabeLetter.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeLetter.Location = new System.Drawing.Point(67, 87);
            this.LabeLetter.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeLetter.Name = "LabeLetter";
            this.LabeLetter.Size = new System.Drawing.Size(50, 19);
            this.LabeLetter.TabIndex = 1;
            this.LabeLetter.Text = "Буква";
            // 
            // LabeXY
            // 
            this.LabeXY.AutoSize = true;
            this.LabeXY.Depth = 0;
            this.LabeXY.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeXY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeXY.Location = new System.Drawing.Point(67, 156);
            this.LabeXY.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeXY.Name = "LabeXY";
            this.LabeXY.Size = new System.Drawing.Size(99, 19);
            this.LabeXY.TabIndex = 2;
            this.LabeXY.Text = "Координаты";
            // 
            // BoxLetter
            // 
            this.BoxLetter.Location = new System.Drawing.Point(67, 119);
            this.BoxLetter.Name = "BoxLetter";
            this.BoxLetter.Size = new System.Drawing.Size(100, 23);
            this.BoxLetter.TabIndex = 3;
            // 
            // BoxX
            // 
            this.BoxX.Location = new System.Drawing.Point(66, 194);
            this.BoxX.Name = "BoxX";
            this.BoxX.Size = new System.Drawing.Size(100, 23);
            this.BoxX.TabIndex = 4;
            // 
            // BoxY
            // 
            this.BoxY.Location = new System.Drawing.Point(66, 244);
            this.BoxY.Name = "BoxY";
            this.BoxY.Size = new System.Drawing.Size(100, 23);
            this.BoxY.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxY);
            this.Controls.Add(this.BoxX);
            this.Controls.Add(this.BoxLetter);
            this.Controls.Add(this.LabeXY);
            this.Controls.Add(this.LabeLetter);
            this.Controls.Add(this.ButtonCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton ButtonCreate;
        private MaterialSkin.Controls.MaterialLabel LabeLetter;
        private MaterialSkin.Controls.MaterialLabel LabeXY;
        private System.Windows.Forms.TextBox BoxLetter;
        private System.Windows.Forms.TextBox BoxX;
        private System.Windows.Forms.TextBox BoxY;
    }
}

