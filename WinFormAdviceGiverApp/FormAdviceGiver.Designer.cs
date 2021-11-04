
namespace WinFormAdviceGiverApp
{
    partial class FormAdviceGiver
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
            this.numericUpDownAdviceQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelAdviceQuantity = new System.Windows.Forms.Label();
            this.buttonGenerateAdvice = new System.Windows.Forms.Button();
            this.textBoxPiecesOfAdvice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdviceQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAdviceQuantity
            // 
            this.numericUpDownAdviceQuantity.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAdviceQuantity.Location = new System.Drawing.Point(278, 45);
            this.numericUpDownAdviceQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownAdviceQuantity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAdviceQuantity.Name = "numericUpDownAdviceQuantity";
            this.numericUpDownAdviceQuantity.Size = new System.Drawing.Size(126, 31);
            this.numericUpDownAdviceQuantity.TabIndex = 0;
            this.numericUpDownAdviceQuantity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelAdviceQuantity
            // 
            this.labelAdviceQuantity.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdviceQuantity.Location = new System.Drawing.Point(57, 23);
            this.labelAdviceQuantity.Name = "labelAdviceQuantity";
            this.labelAdviceQuantity.Size = new System.Drawing.Size(215, 71);
            this.labelAdviceQuantity.TabIndex = 1;
            this.labelAdviceQuantity.Text = "Number of pieces of advice:";
            // 
            // buttonGenerateAdvice
            // 
            this.buttonGenerateAdvice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenerateAdvice.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateAdvice.Location = new System.Drawing.Point(484, 23);
            this.buttonGenerateAdvice.Name = "buttonGenerateAdvice";
            this.buttonGenerateAdvice.Size = new System.Drawing.Size(255, 71);
            this.buttonGenerateAdvice.TabIndex = 2;
            this.buttonGenerateAdvice.Text = "Generate Advice";
            this.buttonGenerateAdvice.UseVisualStyleBackColor = false;
            this.buttonGenerateAdvice.Click += new System.EventHandler(this.buttonGenerateAdvice_Click);
            // 
            // textBoxPiecesOfAdvice
            // 
            this.textBoxPiecesOfAdvice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPiecesOfAdvice.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPiecesOfAdvice.Location = new System.Drawing.Point(37, 135);
            this.textBoxPiecesOfAdvice.Multiline = true;
            this.textBoxPiecesOfAdvice.Name = "textBoxPiecesOfAdvice";
            this.textBoxPiecesOfAdvice.ReadOnly = true;
            this.textBoxPiecesOfAdvice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPiecesOfAdvice.Size = new System.Drawing.Size(710, 270);
            this.textBoxPiecesOfAdvice.TabIndex = 3;
            // 
            // FormAdviceGiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPiecesOfAdvice);
            this.Controls.Add(this.buttonGenerateAdvice);
            this.Controls.Add(this.labelAdviceQuantity);
            this.Controls.Add(this.numericUpDownAdviceQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdviceGiver";
            this.Text = "Advice Giver";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdviceQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAdviceQuantity;
        private System.Windows.Forms.Label labelAdviceQuantity;
        private System.Windows.Forms.Button buttonGenerateAdvice;
        private System.Windows.Forms.TextBox textBoxPiecesOfAdvice;
    }
}

