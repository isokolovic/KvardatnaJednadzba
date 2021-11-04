
namespace VSite.CSharp.KvadratnaJednadzba.Gui
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
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.resultDisplay = new VSite.CSharp.KvadratnaJednadzba.Gui.ResultDisplay();
            this.SuspendLayout();
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(25, 304);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(92, 23);
            this.buttonEvaluate.TabIndex = 1;
            this.buttonEvaluate.Text = "&Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(219, 286);
            this.resultDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 355);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.resultDisplay);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
        private System.Windows.Forms.Button buttonEvaluate;
    }
}

