
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
            this.functionPanel1 = new VSite.CSharp.KvadratnaJednadzba.Gui.FunctionPanel();
            this.resultDisplay = new VSite.CSharp.KvadratnaJednadzba.Gui.ResultDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // functionPanel1
            // 
            this.functionPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.functionPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionPanel1.Location = new System.Drawing.Point(238, 13);
            this.functionPanel1.Name = "functionPanel1";
            this.functionPanel1.Size = new System.Drawing.Size(654, 509);
            this.functionPanel1.TabIndex = 1;
            this.functionPanel1.TabStop = false;
            // 
            // resultDisplay
            // 
            this.resultDisplay.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(219, 286);
            this.resultDisplay.TabIndex = 0;
            this.resultDisplay.CoefficientsChanged += new System.EventHandler(this.resultDisplay_CoefficientsChanged);
            this.resultDisplay.Load += new System.EventHandler(this.resultDisplay_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 534);
            this.Controls.Add(this.functionPanel1);
            this.Controls.Add(this.resultDisplay);
            this.Name = "Form1";
            this.Text = "Quadratic Equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay;
        private FunctionPanel functionPanel1;
    }
}

