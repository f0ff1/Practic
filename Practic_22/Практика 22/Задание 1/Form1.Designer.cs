
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
            this.labeX = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BoxX = new System.Windows.Forms.TextBox();
            this.BoxY = new System.Windows.Forms.TextBox();
            this.BoxZ = new System.Windows.Forms.TextBox();
            this.BoxWrite = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // labeX
            // 
            this.labeX.AutoSize = true;
            this.labeX.Depth = 0;
            this.labeX.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labeX.Location = new System.Drawing.Point(99, 95);
            this.labeX.MouseState = MaterialSkin.MouseState.HOVER;
            this.labeX.Name = "labeX";
            this.labeX.Size = new System.Drawing.Size(156, 19);
            this.labeX.TabIndex = 0;
            this.labeX.Text = "Введите значение Х:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(99, 142);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(156, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Введите значение У:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(99, 186);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(156, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Введите значение Z:";
            // 
            // BoxX
            // 
            this.BoxX.Location = new System.Drawing.Point(286, 95);
            this.BoxX.Name = "BoxX";
            this.BoxX.Size = new System.Drawing.Size(100, 23);
            this.BoxX.TabIndex = 3;
            // 
            // BoxY
            // 
            this.BoxY.Location = new System.Drawing.Point(286, 142);
            this.BoxY.Name = "BoxY";
            this.BoxY.Size = new System.Drawing.Size(100, 23);
            this.BoxY.TabIndex = 4;
            // 
            // BoxZ
            // 
            this.BoxZ.Location = new System.Drawing.Point(286, 186);
            this.BoxZ.Name = "BoxZ";
            this.BoxZ.Size = new System.Drawing.Size(100, 23);
            this.BoxZ.TabIndex = 5;
            // 
            // BoxWrite
            // 
            this.BoxWrite.Location = new System.Drawing.Point(99, 243);
            this.BoxWrite.Multiline = true;
            this.BoxWrite.Name = "BoxWrite";
            this.BoxWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxWrite.Size = new System.Drawing.Size(287, 161);
            this.BoxWrite.TabIndex = 6;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialFlatButton1.Location = new System.Drawing.Point(288, 413);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Выполнить";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 459);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.BoxWrite);
            this.Controls.Add(this.BoxZ);
            this.Controls.Add(this.BoxY);
            this.Controls.Add(this.BoxX);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.labeX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labeX;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox BoxX;
        private System.Windows.Forms.TextBox BoxY;
        private System.Windows.Forms.TextBox BoxZ;
        private System.Windows.Forms.TextBox BoxWrite;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

