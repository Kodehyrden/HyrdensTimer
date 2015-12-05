namespace HyrdensTimer {
    partial class SelectTimeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTimeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedTimeValue = new System.Windows.Forms.NumericUpDown();
            this.buOK = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedTimeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected time:";
            // 
            // SelectedTimeValue
            // 
            this.SelectedTimeValue.Location = new System.Drawing.Point(92, 7);
            this.SelectedTimeValue.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.SelectedTimeValue.Name = "SelectedTimeValue";
            this.SelectedTimeValue.Size = new System.Drawing.Size(74, 20);
            this.SelectedTimeValue.TabIndex = 2;
            // 
            // buOK
            // 
            this.buOK.Location = new System.Drawing.Point(91, 48);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(75, 23);
            this.buOK.TabIndex = 3;
            this.buOK.Text = "OK";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // buCancel
            // 
            this.buCancel.Location = new System.Drawing.Point(12, 48);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 4;
            this.buCancel.Text = "Cancel";
            this.buCancel.UseVisualStyleBackColor = true;
            this.buCancel.Click += new System.EventHandler(this.buCancel_Click);
            // 
            // SelectTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 89);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.SelectedTimeValue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectTimeForm";
            this.Text = "Select the time...";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedTimeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SelectedTimeValue;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Button buCancel;
    }
}