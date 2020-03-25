namespace Opgave3._8
{
    partial class Form1
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.richTextBoxEquation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(87, 153);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 31);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(291, 153);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 31);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(503, 153);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 31);
            this.textBoxC.TabIndex = 2;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(87, 249);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(516, 50);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(87, 339);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(516, 31);
            this.textBoxResult.TabIndex = 4;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(121, 187);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 25);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(324, 187);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(26, 25);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(540, 187);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(27, 25);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "C";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(82, 408);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 8;
            // 
            // richTextBoxEquation
            // 
            this.richTextBoxEquation.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxEquation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxEquation.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxEquation.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEquation.Location = new System.Drawing.Point(87, 12);
            this.richTextBoxEquation.Name = "richTextBoxEquation";
            this.richTextBoxEquation.ReadOnly = true;
            this.richTextBoxEquation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxEquation.Size = new System.Drawing.Size(516, 120);
            this.richTextBoxEquation.TabIndex = 9;
            this.richTextBoxEquation.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxEquation);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.RichTextBox richTextBoxEquation;
    }
}

