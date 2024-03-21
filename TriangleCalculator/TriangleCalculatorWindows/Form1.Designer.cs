namespace TriangleCalculatorWindows
{
    partial class frmTriangle
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(231, 352);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 29);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(52, 48);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(103, 23);
            this.lblSideA.TabIndex = 1;
            this.lblSideA.Text = "Enter Side A";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(52, 122);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(102, 23);
            this.lblSideB.TabIndex = 2;
            this.lblSideB.Text = "Enter Side B";
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.AutoSize = true;
            this.lblHypotenuse.Location = new System.Drawing.Point(52, 190);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(105, 23);
            this.lblHypotenuse.TabIndex = 3;
            this.lblHypotenuse.Text = "Hypotenuse:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(52, 259);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 23);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area:";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(261, 48);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(125, 30);
            this.txtSideA.TabIndex = 5;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(261, 122);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(125, 30);
            this.txtSideB.TabIndex = 6;
            // 
            // frmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 414);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmTriangle";
            this.Text = "Triangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalc;
        private Label lblSideA;
        private Label lblSideB;
        private Label lblHypotenuse;
        private Label lblArea;
        private TextBox txtSideA;
        private TextBox txtSideB;
    }
}