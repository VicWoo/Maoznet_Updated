
namespace NetworkGUI.Forms
{
    partial class LouvainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.precisionVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxIter = new System.Windows.Forms.NumericUpDown();
            this.unlimitedIter = new System.Windows.Forms.CheckBox();
            this.goBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxIter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Precision Value";
            // 
            // precisionVal
            // 
            this.precisionVal.Location = new System.Drawing.Point(189, 21);
            this.precisionVal.Name = "precisionVal";
            this.precisionVal.Size = new System.Drawing.Size(100, 22);
            this.precisionVal.TabIndex = 1;
            this.precisionVal.Text = "0.0";
            this.precisionVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precisionVal.TextChanged += new System.EventHandler(this.precisionVal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Maximum Number of Iterations";
            // 
            // maxIter
            // 
            this.maxIter.Location = new System.Drawing.Point(251, 68);
            this.maxIter.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.maxIter.Name = "maxIter";
            this.maxIter.Size = new System.Drawing.Size(99, 22);
            this.maxIter.TabIndex = 3;
            this.maxIter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxIter.ValueChanged += new System.EventHandler(this.maxIter_ValueChanged);
            // 
            // unlimitedIter
            // 
            this.unlimitedIter.AutoSize = true;
            this.unlimitedIter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unlimitedIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.unlimitedIter.Location = new System.Drawing.Point(12, 96);
            this.unlimitedIter.Name = "unlimitedIter";
            this.unlimitedIter.Size = new System.Drawing.Size(317, 19);
            this.unlimitedIter.TabIndex = 5;
            this.unlimitedIter.Text = "Proceed Until Best Value Achieved (No Max Iteration)";
            this.unlimitedIter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unlimitedIter.UseVisualStyleBackColor = true;
            this.unlimitedIter.CheckedChanged += new System.EventHandler(this.unlimitedIter_CheckedChanged);
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(285, 138);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(75, 23);
            this.goBtn.TabIndex = 6;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // LouvainForm
            // 
            this.AcceptButton = this.goBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 173);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.unlimitedIter);
            this.Controls.Add(this.maxIter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precisionVal);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(390, 220);
            this.Name = "LouvainForm";
            this.Text = "Louvain Form";
            ((System.ComponentModel.ISupportInitialize)(this.maxIter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precisionVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxIter;
        private System.Windows.Forms.CheckBox unlimitedIter;
        private System.Windows.Forms.Button goBtn;
    }
}