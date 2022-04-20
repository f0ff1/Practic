
namespace Задание_2
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
            this.LabeX = new MaterialSkin.Controls.MaterialLabel();
            this.LabeY = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.BoxX = new System.Windows.Forms.TextBox();
            this.BoxY = new System.Windows.Forms.TextBox();
            this.BoxWrite = new System.Windows.Forms.TextBox();
            this.RadioSinh = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioXDegree = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioEX = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabeX
            // 
            this.LabeX.AutoSize = true;
            this.LabeX.Depth = 0;
            this.LabeX.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeX.Location = new System.Drawing.Point(8, 128);
            this.LabeX.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeX.Name = "LabeX";
            this.LabeX.Size = new System.Drawing.Size(34, 19);
            this.LabeX.TabIndex = 0;
            this.LabeX.Text = "X = ";
            // 
            // LabeY
            // 
            this.LabeY.AutoSize = true;
            this.LabeY.Depth = 0;
            this.LabeY.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabeY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabeY.Location = new System.Drawing.Point(8, 180);
            this.LabeY.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabeY.Name = "LabeY";
            this.LabeY.Size = new System.Drawing.Size(34, 19);
            this.LabeY.TabIndex = 1;
            this.LabeY.Text = "Y = ";
            // 
            // ButtonStart
            // 
            this.ButtonStart.AutoSize = true;
            this.ButtonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonStart.Depth = 0;
            this.ButtonStart.Location = new System.Drawing.Point(7, 463);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Primary = false;
            this.ButtonStart.Size = new System.Drawing.Size(55, 36);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.AutoSize = true;
            this.ButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClear.Depth = 0;
            this.ButtonClear.Location = new System.Drawing.Point(345, 463);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Primary = false;
            this.ButtonClear.Size = new System.Drawing.Size(54, 36);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // BoxX
            // 
            this.BoxX.Location = new System.Drawing.Point(58, 124);
            this.BoxX.Name = "BoxX";
            this.BoxX.Size = new System.Drawing.Size(190, 23);
            this.BoxX.TabIndex = 5;
            // 
            // BoxY
            // 
            this.BoxY.Location = new System.Drawing.Point(58, 176);
            this.BoxY.Name = "BoxY";
            this.BoxY.Size = new System.Drawing.Size(190, 23);
            this.BoxY.TabIndex = 6;
            // 
            // BoxWrite
            // 
            this.BoxWrite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BoxWrite.Location = new System.Drawing.Point(7, 234);
            this.BoxWrite.Multiline = true;
            this.BoxWrite.Name = "BoxWrite";
            this.BoxWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxWrite.Size = new System.Drawing.Size(392, 210);
            this.BoxWrite.TabIndex = 8;
            // 
            // RadioSinh
            // 
            this.RadioSinh.AutoSize = true;
            this.RadioSinh.Depth = 0;
            this.RadioSinh.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioSinh.Location = new System.Drawing.Point(3, 19);
            this.RadioSinh.Margin = new System.Windows.Forms.Padding(0);
            this.RadioSinh.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioSinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioSinh.Name = "RadioSinh";
            this.RadioSinh.Ripple = true;
            this.RadioSinh.Size = new System.Drawing.Size(54, 30);
            this.RadioSinh.TabIndex = 9;
            this.RadioSinh.TabStop = true;
            this.RadioSinh.Text = "Sh()";
            this.RadioSinh.UseVisualStyleBackColor = true;
            // 
            // RadioXDegree
            // 
            this.RadioXDegree.AutoSize = true;
            this.RadioXDegree.Depth = 0;
            this.RadioXDegree.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioXDegree.Location = new System.Drawing.Point(3, 56);
            this.RadioXDegree.Margin = new System.Windows.Forms.Padding(0);
            this.RadioXDegree.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioXDegree.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioXDegree.Name = "RadioXDegree";
            this.RadioXDegree.Ripple = true;
            this.RadioXDegree.Size = new System.Drawing.Size(51, 30);
            this.RadioXDegree.TabIndex = 10;
            this.RadioXDegree.TabStop = true;
            this.RadioXDegree.Text = "X^2";
            this.RadioXDegree.UseVisualStyleBackColor = true;
            // 
            // RadioEX
            // 
            this.RadioEX.AutoSize = true;
            this.RadioEX.Depth = 0;
            this.RadioEX.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioEX.Location = new System.Drawing.Point(3, 94);
            this.RadioEX.Margin = new System.Windows.Forms.Padding(0);
            this.RadioEX.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioEX.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioEX.Name = "RadioEX";
            this.RadioEX.Ripple = true;
            this.RadioEX.Size = new System.Drawing.Size(49, 30);
            this.RadioEX.TabIndex = 11;
            this.RadioEX.TabStop = true;
            this.RadioEX.Text = "e^x";
            this.RadioEX.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioSinh);
            this.groupBox1.Controls.Add(this.RadioEX);
            this.groupBox1.Controls.Add(this.RadioXDegree);
            this.groupBox1.Location = new System.Drawing.Point(267, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите функцию";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxWrite);
            this.Controls.Add(this.BoxY);
            this.Controls.Add(this.BoxX);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabeY);
            this.Controls.Add(this.LabeX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabeX;
        private MaterialSkin.Controls.MaterialLabel LabeY;
        private MaterialSkin.Controls.MaterialFlatButton ButtonStart;
        private MaterialSkin.Controls.MaterialFlatButton ButtonClear;
        private System.Windows.Forms.TextBox BoxX;
        private System.Windows.Forms.TextBox BoxY;
        private System.Windows.Forms.TextBox BoxWrite;
        private MaterialSkin.Controls.MaterialRadioButton RadioSinh;
        private MaterialSkin.Controls.MaterialRadioButton RadioXDegree;
        private MaterialSkin.Controls.MaterialRadioButton RadioEX;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

