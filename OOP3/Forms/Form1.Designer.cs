namespace OOP3
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CtrlLblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CtrlLblHelp
            // 
            this.CtrlLblHelp.AutoSize = true;
            this.CtrlLblHelp.Location = new System.Drawing.Point(478, 9);
            this.CtrlLblHelp.Name = "CtrlLblHelp";
            this.CtrlLblHelp.Size = new System.Drawing.Size(50, 13);
            this.CtrlLblHelp.TabIndex = 0;
            this.CtrlLblHelp.Text = "Помощь";
            this.CtrlLblHelp.Click += new System.EventHandler(this.CtrlLblHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 412);
            this.Controls.Add(this.CtrlLblHelp);
            this.Name = "MainForm";
            this.Text = "TyukachDraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CtrlLblHelp;
    }
}

