namespace OOP3
{
    partial class FormNew
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
            this.CtrlLblWidth = new System.Windows.Forms.Label();
            this.CtrlLblHeight = new System.Windows.Forms.Label();
            this.CtrlNudWidth = new System.Windows.Forms.NumericUpDown();
            this.CtrlNudHeight = new System.Windows.Forms.NumericUpDown();
            this.CtrlButCreate = new System.Windows.Forms.Button();
            this.CtrlButCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlLblWidth
            // 
            this.CtrlLblWidth.AutoSize = true;
            this.CtrlLblWidth.Location = new System.Drawing.Point(12, 9);
            this.CtrlLblWidth.Name = "CtrlLblWidth";
            this.CtrlLblWidth.Size = new System.Drawing.Size(46, 13);
            this.CtrlLblWidth.TabIndex = 0;
            this.CtrlLblWidth.Text = "Ширина";
            // 
            // CtrlLblHeight
            // 
            this.CtrlLblHeight.AutoSize = true;
            this.CtrlLblHeight.Location = new System.Drawing.Point(12, 36);
            this.CtrlLblHeight.Name = "CtrlLblHeight";
            this.CtrlLblHeight.Size = new System.Drawing.Size(45, 13);
            this.CtrlLblHeight.TabIndex = 1;
            this.CtrlLblHeight.Text = "Высота";
            // 
            // CtrlNudWidth
            // 
            this.CtrlNudWidth.Location = new System.Drawing.Point(102, 7);
            this.CtrlNudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CtrlNudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlNudWidth.Name = "CtrlNudWidth";
            this.CtrlNudWidth.Size = new System.Drawing.Size(66, 20);
            this.CtrlNudWidth.TabIndex = 2;
            this.CtrlNudWidth.Value = new decimal(new int[] {
            523,
            0,
            0,
            0});
            // 
            // CtrlNudHeight
            // 
            this.CtrlNudHeight.Location = new System.Drawing.Point(102, 34);
            this.CtrlNudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CtrlNudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlNudHeight.Name = "CtrlNudHeight";
            this.CtrlNudHeight.Size = new System.Drawing.Size(66, 20);
            this.CtrlNudHeight.TabIndex = 3;
            this.CtrlNudHeight.Value = new decimal(new int[] {
            581,
            0,
            0,
            0});
            // 
            // CtrlButCreate
            // 
            this.CtrlButCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CtrlButCreate.Location = new System.Drawing.Point(12, 70);
            this.CtrlButCreate.Name = "CtrlButCreate";
            this.CtrlButCreate.Size = new System.Drawing.Size(66, 23);
            this.CtrlButCreate.TabIndex = 4;
            this.CtrlButCreate.Text = "Создать";
            this.CtrlButCreate.UseVisualStyleBackColor = true;
            this.CtrlButCreate.Click += new System.EventHandler(this.CtrlButCreate_Click);
            // 
            // CtrlButCancel
            // 
            this.CtrlButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CtrlButCancel.Location = new System.Drawing.Point(102, 70);
            this.CtrlButCancel.Name = "CtrlButCancel";
            this.CtrlButCancel.Size = new System.Drawing.Size(66, 23);
            this.CtrlButCancel.TabIndex = 5;
            this.CtrlButCancel.Text = "Отмена";
            this.CtrlButCancel.UseVisualStyleBackColor = true;
            this.CtrlButCancel.Click += new System.EventHandler(this.CtrlButCancel_Click);
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 99);
            this.Controls.Add(this.CtrlButCancel);
            this.Controls.Add(this.CtrlButCreate);
            this.Controls.Add(this.CtrlNudHeight);
            this.Controls.Add(this.CtrlNudWidth);
            this.Controls.Add(this.CtrlLblHeight);
            this.Controls.Add(this.CtrlLblWidth);
            this.Name = "FormNew";
            this.Text = "Новый ";
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CtrlLblWidth;
        private System.Windows.Forms.Label CtrlLblHeight;
        private System.Windows.Forms.NumericUpDown CtrlNudWidth;
        private System.Windows.Forms.NumericUpDown CtrlNudHeight;
        private System.Windows.Forms.Button CtrlButCreate;
        private System.Windows.Forms.Button CtrlButCancel;
    }
}