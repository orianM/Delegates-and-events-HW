
namespace Delegates_and_events_HW
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShalom = new System.Windows.Forms.Button();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.btnShalomName = new System.Windows.Forms.Button();
            this.btnWelcomeName = new System.Windows.Forms.Button();
            this.lblEnterName2 = new System.Windows.Forms.Label();
            this.lblEnterName1 = new System.Windows.Forms.Label();
            this.txtBoxEnterName1 = new System.Windows.Forms.TextBox();
            this.txtBoxEnterName2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.txtSubNum1 = new System.Windows.Forms.TextBox();
            this.txtSubNum2 = new System.Windows.Forms.TextBox();
            this.txtAddNum2 = new System.Windows.Forms.TextBox();
            this.txtAddNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShalom
            // 
            this.btnShalom.Location = new System.Drawing.Point(155, 45);
            this.btnShalom.Name = "btnShalom";
            this.btnShalom.Size = new System.Drawing.Size(75, 64);
            this.btnShalom.TabIndex = 0;
            this.btnShalom.Text = "Shalom";
            this.btnShalom.UseVisualStyleBackColor = true;
            this.btnShalom.Click += new System.EventHandler(this.BtnShalom_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(236, 45);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(75, 64);
            this.btnPrint2.TabIndex = 1;
            this.btnPrint2.Text = "Print2";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.BtnPrint2_Click);
            // 
            // btnShalomName
            // 
            this.btnShalomName.Location = new System.Drawing.Point(317, 45);
            this.btnShalomName.Name = "btnShalomName";
            this.btnShalomName.Size = new System.Drawing.Size(75, 64);
            this.btnShalomName.TabIndex = 2;
            this.btnShalomName.Text = "Shalom Name";
            this.btnShalomName.UseVisualStyleBackColor = true;
            this.btnShalomName.Click += new System.EventHandler(this.BtnShalomName_Click);
            // 
            // btnWelcomeName
            // 
            this.btnWelcomeName.Location = new System.Drawing.Point(398, 45);
            this.btnWelcomeName.Name = "btnWelcomeName";
            this.btnWelcomeName.Size = new System.Drawing.Size(75, 64);
            this.btnWelcomeName.TabIndex = 3;
            this.btnWelcomeName.Text = "Welcome Name";
            this.btnWelcomeName.UseVisualStyleBackColor = true;
            this.btnWelcomeName.Click += new System.EventHandler(this.BtnWelcomeName_Click);
            // 
            // lblEnterName2
            // 
            this.lblEnterName2.AutoSize = true;
            this.lblEnterName2.Location = new System.Drawing.Point(398, 112);
            this.lblEnterName2.Name = "lblEnterName2";
            this.lblEnterName2.Size = new System.Drawing.Size(69, 15);
            this.lblEnterName2.TabIndex = 4;
            this.lblEnterName2.Text = "Enter Name";
            // 
            // lblEnterName1
            // 
            this.lblEnterName1.AutoSize = true;
            this.lblEnterName1.Location = new System.Drawing.Point(317, 112);
            this.lblEnterName1.Name = "lblEnterName1";
            this.lblEnterName1.Size = new System.Drawing.Size(69, 15);
            this.lblEnterName1.TabIndex = 5;
            this.lblEnterName1.Text = "Enter Name";
            // 
            // txtBoxEnterName1
            // 
            this.txtBoxEnterName1.Location = new System.Drawing.Point(317, 131);
            this.txtBoxEnterName1.Name = "txtBoxEnterName1";
            this.txtBoxEnterName1.Size = new System.Drawing.Size(75, 23);
            this.txtBoxEnterName1.TabIndex = 6;
            // 
            // txtBoxEnterName2
            // 
            this.txtBoxEnterName2.Location = new System.Drawing.Point(398, 131);
            this.txtBoxEnterName2.Name = "txtBoxEnterName2";
            this.txtBoxEnterName2.Size = new System.Drawing.Size(75, 23);
            this.txtBoxEnterName2.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 61);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(298, 248);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(119, 61);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // txtSubNum1
            // 
            this.txtSubNum1.Location = new System.Drawing.Point(298, 315);
            this.txtSubNum1.Name = "txtSubNum1";
            this.txtSubNum1.Size = new System.Drawing.Size(49, 23);
            this.txtSubNum1.TabIndex = 16;
            // 
            // txtSubNum2
            // 
            this.txtSubNum2.Location = new System.Drawing.Point(368, 315);
            this.txtSubNum2.Name = "txtSubNum2";
            this.txtSubNum2.Size = new System.Drawing.Size(49, 23);
            this.txtSubNum2.TabIndex = 20;
            // 
            // txtAddNum2
            // 
            this.txtAddNum2.Location = new System.Drawing.Point(225, 315);
            this.txtAddNum2.Name = "txtAddNum2";
            this.txtAddNum2.Size = new System.Drawing.Size(49, 23);
            this.txtAddNum2.TabIndex = 21;
            // 
            // txtAddNum1
            // 
            this.txtAddNum1.Location = new System.Drawing.Point(155, 315);
            this.txtAddNum1.Name = "txtAddNum1";
            this.txtAddNum1.Size = new System.Drawing.Size(49, 23);
            this.txtAddNum1.TabIndex = 22;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAddNum1);
            this.Controls.Add(this.txtAddNum2);
            this.Controls.Add(this.txtSubNum2);
            this.Controls.Add(this.txtSubNum1);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxEnterName2);
            this.Controls.Add(this.txtBoxEnterName1);
            this.Controls.Add(this.lblEnterName1);
            this.Controls.Add(this.lblEnterName2);
            this.Controls.Add(this.btnWelcomeName);
            this.Controls.Add(this.btnShalomName);
            this.Controls.Add(this.btnPrint2);
            this.Controls.Add(this.btnShalom);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(713, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShalom;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.Button btnShalomName;
        private System.Windows.Forms.Button btnWelcomeName;
        private System.Windows.Forms.Label lblEnterName2;
        private System.Windows.Forms.Label lblEnterName1;
        private System.Windows.Forms.TextBox txtBoxEnterName1;
        private System.Windows.Forms.TextBox txtBoxEnterName2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.TextBox txtSubNum1;
        private System.Windows.Forms.TextBox txtSubNum2;
        private System.Windows.Forms.TextBox txtAddNum2;
        private System.Windows.Forms.TextBox txtAddNum1;
    }
}
