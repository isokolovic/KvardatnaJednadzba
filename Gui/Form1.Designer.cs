
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
            this.resultDisplay = new VSite.CSharp.KvadratnaJednadzba.Gui.ResultDisplay();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(219, 286);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.Load += new System.EventHandler(this.resultDisplay_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 355);
            this.Controls.Add(this.resultDisplay);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
    }
}

