
namespace NetworkGUI.Forms
{
    partial class RemoveIsolatesForm
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
            this.rmvIsolatesT = new System.Windows.Forms.RadioButton();
            this.rmvIsolatesF = new System.Windows.Forms.RadioButton();
            this.minGrpSzPrmpt = new System.Windows.Forms.Label();
            this.minGrpSz = new System.Windows.Forms.NumericUpDown();
            this.doneBt = new System.Windows.Forms.Button();
            this.popupChkBx = new System.Windows.Forms.CheckBox();
            this.popupPrmpt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.minGrpSz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rmvIsolatesT
            // 
            this.rmvIsolatesT.AutoCheck = false;
            this.rmvIsolatesT.AutoSize = true;
            this.rmvIsolatesT.Location = new System.Drawing.Point(8, 25);
            this.rmvIsolatesT.Name = "rmvIsolatesT";
            this.rmvIsolatesT.Size = new System.Drawing.Size(53, 21);
            this.rmvIsolatesT.TabIndex = 2;
            this.rmvIsolatesT.TabStop = true;
            this.rmvIsolatesT.Text = "Yes";
            this.rmvIsolatesT.UseVisualStyleBackColor = true;
            this.rmvIsolatesT.CheckedChanged += new System.EventHandler(this.rmvIsolatesT_CheckedChanged);
            // 
            // rmvIsolatesF
            // 
            this.rmvIsolatesF.AutoCheck = false;
            this.rmvIsolatesF.AutoSize = true;
            this.rmvIsolatesF.Location = new System.Drawing.Point(8, 52);
            this.rmvIsolatesF.Name = "rmvIsolatesF";
            this.rmvIsolatesF.Size = new System.Drawing.Size(47, 21);
            this.rmvIsolatesF.TabIndex = 3;
            this.rmvIsolatesF.TabStop = true;
            this.rmvIsolatesF.Text = "No";
            this.rmvIsolatesF.UseVisualStyleBackColor = true;
            this.rmvIsolatesF.CheckedChanged += new System.EventHandler(this.rmvIsolatesF_CheckedChanged);
            // 
            // minGrpSzPrmpt
            // 
            this.minGrpSzPrmpt.AutoSize = true;
            this.minGrpSzPrmpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.minGrpSzPrmpt.Location = new System.Drawing.Point(12, 120);
            this.minGrpSzPrmpt.Name = "minGrpSzPrmpt";
            this.minGrpSzPrmpt.Size = new System.Drawing.Size(148, 18);
            this.minGrpSzPrmpt.TabIndex = 4;
            this.minGrpSzPrmpt.Text = "Minimum Group Size";
            // 
            // minGrpSz
            // 
            this.minGrpSz.Location = new System.Drawing.Point(187, 119);
            this.minGrpSz.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.minGrpSz.Name = "minGrpSz";
            this.minGrpSz.Size = new System.Drawing.Size(120, 22);
            this.minGrpSz.TabIndex = 5;
            this.minGrpSz.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // doneBt
            // 
            this.doneBt.Enabled = false;
            this.doneBt.Location = new System.Drawing.Point(232, 168);
            this.doneBt.Name = "doneBt";
            this.doneBt.Size = new System.Drawing.Size(75, 23);
            this.doneBt.TabIndex = 0;
            this.doneBt.Text = "Done";
            this.doneBt.UseVisualStyleBackColor = true;
            this.doneBt.Click += new System.EventHandler(this.doneBt_Click);
            // 
            // popupChkBx
            // 
            this.popupChkBx.AutoSize = true;
            this.popupChkBx.Location = new System.Drawing.Point(169, 172);
            this.popupChkBx.Name = "popupChkBx";
            this.popupChkBx.Size = new System.Drawing.Size(18, 17);
            this.popupChkBx.TabIndex = 6;
            this.popupChkBx.UseVisualStyleBackColor = true;
            // 
            // popupPrmpt
            // 
            this.popupPrmpt.AutoSize = true;
            this.popupPrmpt.Location = new System.Drawing.Point(12, 171);
            this.popupPrmpt.Name = "popupPrmpt";
            this.popupPrmpt.Size = new System.Drawing.Size(151, 17);
            this.popupPrmpt.TabIndex = 7;
            this.popupPrmpt.Text = "Remember my choices";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rmvIsolatesF);
            this.groupBox1.Controls.Add(this.rmvIsolatesT);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do you want to remove isolates?";
            // 
            // RemoveIsolatesForm
            // 
            this.AcceptButton = this.doneBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 213);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.popupPrmpt);
            this.Controls.Add(this.popupChkBx);
            this.Controls.Add(this.doneBt);
            this.Controls.Add(this.minGrpSz);
            this.Controls.Add(this.minGrpSzPrmpt);
            this.MaximumSize = new System.Drawing.Size(345, 260);
            this.MinimumSize = new System.Drawing.Size(345, 260);
            this.Name = "RemoveIsolatesForm";
            this.Text = "Remove Isolates";
            ((System.ComponentModel.ISupportInitialize)(this.minGrpSz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rmvIsolatesT;
        private System.Windows.Forms.RadioButton rmvIsolatesF;
        private System.Windows.Forms.Label minGrpSzPrmpt;
        private System.Windows.Forms.NumericUpDown minGrpSz;
        private System.Windows.Forms.Button doneBt;
        private System.Windows.Forms.CheckBox popupChkBx;
        private System.Windows.Forms.Label popupPrmpt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}