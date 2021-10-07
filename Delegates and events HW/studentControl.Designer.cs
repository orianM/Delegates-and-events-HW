
namespace Delegates_and_events_HW
{
    partial class studentControl
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
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbFilters
            // 
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Items.AddRange(new object[] {
            "Filter By Id\t",
            "Filter By First name",
            "Filter By Last name",
            "Filter By Grade"});
            this.cmbFilters.Location = new System.Drawing.Point(264, 94);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(121, 23);
            this.cmbFilters.TabIndex = 0;
            // 
            // studentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFilters);
            this.Name = "studentControl";
            this.Size = new System.Drawing.Size(871, 575);
            this.Load += new System.EventHandler(this.studentControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilters;
    }
}
