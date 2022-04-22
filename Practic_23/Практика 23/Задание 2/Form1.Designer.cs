
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BoxXmin = new System.Windows.Forms.TextBox();
            this.BoxXmax = new System.Windows.Forms.TextBox();
            this.BoxStep = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabeMin = new System.Windows.Forms.Label();
            this.LabeMax = new System.Windows.Forms.Label();
            this.LabeStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(482, 81);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(29, 23);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartControl1.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartControl1.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartControl1.Size = new System.Drawing.Size(591, 335);
            this.chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartControl1.Style3D = true;
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartControl1.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // BoxXmin
            // 
            this.BoxXmin.Location = new System.Drawing.Point(97, 393);
            this.BoxXmin.Name = "BoxXmin";
            this.BoxXmin.Size = new System.Drawing.Size(100, 23);
            this.BoxXmin.TabIndex = 1;
            // 
            // BoxXmax
            // 
            this.BoxXmax.Location = new System.Drawing.Point(230, 393);
            this.BoxXmax.Name = "BoxXmax";
            this.BoxXmax.Size = new System.Drawing.Size(100, 23);
            this.BoxXmax.TabIndex = 2;
            // 
            // BoxStep
            // 
            this.BoxStep.Location = new System.Drawing.Point(360, 393);
            this.BoxStep.Name = "BoxStep";
            this.BoxStep.Size = new System.Drawing.Size(100, 23);
            this.BoxStep.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(494, 393);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabeMin
            // 
            this.LabeMin.AutoSize = true;
            this.LabeMin.Location = new System.Drawing.Point(97, 372);
            this.LabeMin.Name = "LabeMin";
            this.LabeMin.Size = new System.Drawing.Size(35, 15);
            this.LabeMin.TabIndex = 5;
            this.LabeMin.Text = "Xmin";
            // 
            // LabeMax
            // 
            this.LabeMax.AutoSize = true;
            this.LabeMax.Location = new System.Drawing.Point(230, 372);
            this.LabeMax.Name = "LabeMax";
            this.LabeMax.Size = new System.Drawing.Size(38, 15);
            this.LabeMax.TabIndex = 6;
            this.LabeMax.Text = "Xman";
            // 
            // LabeStep
            // 
            this.LabeStep.AutoSize = true;
            this.LabeStep.Location = new System.Drawing.Point(360, 372);
            this.LabeStep.Name = "LabeStep";
            this.LabeStep.Size = new System.Drawing.Size(29, 15);
            this.LabeStep.TabIndex = 7;
            this.LabeStep.Text = "Шаг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabeStep);
            this.Controls.Add(this.LabeMax);
            this.Controls.Add(this.LabeMin);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.BoxStep);
            this.Controls.Add(this.BoxXmax);
            this.Controls.Add(this.BoxXmin);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.TextBox BoxXmin;
        private System.Windows.Forms.TextBox BoxXmax;
        private System.Windows.Forms.TextBox BoxStep;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabeMin;
        private System.Windows.Forms.Label LabeMax;
        private System.Windows.Forms.Label LabeStep;
    }
}

