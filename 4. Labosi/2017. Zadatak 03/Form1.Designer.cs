namespace _2017.Zadatak_03
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
            this.inputA = new System.Windows.Forms.Button();
            this.inputC = new System.Windows.Forms.Button();
            this.inputT = new System.Windows.Forms.Button();
            this.inputG = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(50, 39);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(75, 23);
            this.inputA.TabIndex = 0;
            this.inputA.Text = "A";
            this.inputA.UseVisualStyleBackColor = true;
            this.inputA.Click += new System.EventHandler(this.inputA_Click);
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(131, 39);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(75, 23);
            this.inputC.TabIndex = 1;
            this.inputC.Text = "C";
            this.inputC.UseVisualStyleBackColor = true;
            this.inputC.Click += new System.EventHandler(this.inputC_Click);
            // 
            // inputT
            // 
            this.inputT.Location = new System.Drawing.Point(212, 39);
            this.inputT.Name = "inputT";
            this.inputT.Size = new System.Drawing.Size(75, 23);
            this.inputT.TabIndex = 2;
            this.inputT.Text = "T";
            this.inputT.UseVisualStyleBackColor = true;
            this.inputT.Click += new System.EventHandler(this.inputT_Click);
            // 
            // inputG
            // 
            this.inputG.Location = new System.Drawing.Point(293, 39);
            this.inputG.Name = "inputG";
            this.inputG.Size = new System.Drawing.Size(75, 23);
            this.inputG.TabIndex = 3;
            this.inputG.Text = "G";
            this.inputG.UseVisualStyleBackColor = true;
            this.inputG.Click += new System.EventHandler(this.inputG_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(50, 103);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(318, 222);
            this.output.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ispis:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputG);
            this.Controls.Add(this.inputT);
            this.Controls.Add(this.inputC);
            this.Controls.Add(this.inputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputA;
        private System.Windows.Forms.Button inputC;
        private System.Windows.Forms.Button inputT;
        private System.Windows.Forms.Button inputG;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
    }
}

