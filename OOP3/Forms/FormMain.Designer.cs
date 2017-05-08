using System;
using System.Windows.Forms;

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

        private void CtrlTSMIFiller_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТюкачDraw ФКН 2017");
        }

        private void CtrlTSMIHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4.	Векторный графический редактор\n" +
"Разработать простейший векторный графический редактор с различными фигурами.\n" +
"   Используемые классы (примерный перечень):\n" +
"•	Интерфейс фигура\n" +
"•	Конкретные фигуры (Линия, Прямоугольник, Овал)\n" +
"•	Векторная картинка\n" +
"•	Подсистема прорисовки\n" +
"•	Контроллер\n" +
"   Используемые паттерны (примерный перечень):\n" +
"•	Абстрактная фабрика для порождения фигур. При порождении фигур в них сохраняется ссылка на подсистему прорисовки.\n" +
"•	Прототип для копирования фигур.\n" +
"•	Компоновщик для объединения нескольких фигур в один объект.\n" +
"•	Декоратор для выделенных фигур (прорисовка с квадратиками по углам, соответствующее поведение при действиях мышью).\n" +
"•	Цепочка обязанностей из фигур (все действия мыши передаются по цепочки фигур в порядке их размещения по шкале Z, если какая-то фигура определяет, что она должна обработать действие, то дальше действие не передается).\n" +
"•	Каждое действие над фигурой сохраняется в виде команды для того, чтобы команды можно было бы потом отменять.\n" +
"•	Итератор для всех фигур и итератор для фигур в составной фигуре (компоновщике).\n" +
"•	Наблюдатель за появлением, удалением и объединением фигур (список фигур отображается в дереве объектов, его перестроение наступает по событию от Векторной картинки).");

        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CtrlTSMain = new System.Windows.Forms.MenuStrip();
            this.CtrlTSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMINew = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIFiller = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlTSMIClose = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMILoadFigures = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlPanelMain = new System.Windows.Forms.Panel();
            this.CtrlGrBTools = new System.Windows.Forms.GroupBox();
            this.CtrlButArea = new System.Windows.Forms.Button();
            this.CtrlButSel = new System.Windows.Forms.Button();
            this.CtrlButRect = new System.Windows.Forms.Button();
            this.CtrlButEll = new System.Windows.Forms.Button();
            this.CtrlButLine = new System.Windows.Forms.Button();
            this.CtrlGrBSpecials = new System.Windows.Forms.GroupBox();
            this.CtrlButUngroup = new System.Windows.Forms.Button();
            this.CtrlButGroup = new System.Windows.Forms.Button();
            this.CtrlTSMain.SuspendLayout();
            this.CtrlGrBTools.SuspendLayout();
            this.CtrlGrBSpecials.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlTSMain
            // 
            this.CtrlTSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlTSMIFile,
            this.CtrlTSMIEdit,
            this.CtrlTSMIHelp,
            this.CtrlTSMILoadFigures});
            this.CtrlTSMain.Location = new System.Drawing.Point(0, 0);
            this.CtrlTSMain.Name = "CtrlTSMain";
            this.CtrlTSMain.Size = new System.Drawing.Size(836, 24);
            this.CtrlTSMain.TabIndex = 1;
            this.CtrlTSMain.Text = "CtrlTSMain";
            // 
            // CtrlTSMIFile
            // 
            this.CtrlTSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlTSMINew,
            this.CtrlTSMIOpen,
            this.CtrlTSMISave,
            this.CtrlTSMIFiller,
            this.CtrlTSMIClose});
            this.CtrlTSMIFile.Name = "CtrlTSMIFile";
            this.CtrlTSMIFile.Size = new System.Drawing.Size(48, 20);
            this.CtrlTSMIFile.Text = "Файл";
            // 
            // CtrlTSMINew
            // 
            this.CtrlTSMINew.Name = "CtrlTSMINew";
            this.CtrlTSMINew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CtrlTSMINew.Size = new System.Drawing.Size(172, 22);
            this.CtrlTSMINew.Text = "Новый";
            this.CtrlTSMINew.Click += new System.EventHandler(this.CtrlTSMINew_Click);
            // 
            // CtrlTSMIOpen
            // 
            this.CtrlTSMIOpen.Name = "CtrlTSMIOpen";
            this.CtrlTSMIOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.CtrlTSMIOpen.Size = new System.Drawing.Size(172, 22);
            this.CtrlTSMIOpen.Text = "Открыть";
            this.CtrlTSMIOpen.Click += new System.EventHandler(this.CtrlTSMIOpen_Click);
            // 
            // CtrlTSMISave
            // 
            this.CtrlTSMISave.Name = "CtrlTSMISave";
            this.CtrlTSMISave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.CtrlTSMISave.Size = new System.Drawing.Size(172, 22);
            this.CtrlTSMISave.Text = "Сохранить";
            this.CtrlTSMISave.Click += new System.EventHandler(this.CtrlTSMISave_Click);
            // 
            // CtrlTSMIFiller
            // 
            this.CtrlTSMIFiller.Name = "CtrlTSMIFiller";
            this.CtrlTSMIFiller.Size = new System.Drawing.Size(169, 6);
            this.CtrlTSMIFiller.Click += new System.EventHandler(this.CtrlTSMIFiller_Click);
            // 
            // CtrlTSMIClose
            // 
            this.CtrlTSMIClose.Name = "CtrlTSMIClose";
            this.CtrlTSMIClose.Size = new System.Drawing.Size(172, 22);
            this.CtrlTSMIClose.Text = "Выход";
            this.CtrlTSMIClose.Click += new System.EventHandler(this.CtrlTSMIClose_Click);
            // 
            // CtrlTSMIEdit
            // 
            this.CtrlTSMIEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlTSMIUndo,
            this.CtrlTSMIRedo});
            this.CtrlTSMIEdit.Name = "CtrlTSMIEdit";
            this.CtrlTSMIEdit.Size = new System.Drawing.Size(59, 20);
            this.CtrlTSMIEdit.Text = "Правка";
            // 
            // CtrlTSMIUndo
            // 
            this.CtrlTSMIUndo.Name = "CtrlTSMIUndo";
            this.CtrlTSMIUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.CtrlTSMIUndo.Size = new System.Drawing.Size(169, 22);
            this.CtrlTSMIUndo.Text = "Отменить";
            // 
            // CtrlTSMIRedo
            // 
            this.CtrlTSMIRedo.Name = "CtrlTSMIRedo";
            this.CtrlTSMIRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.CtrlTSMIRedo.Size = new System.Drawing.Size(169, 22);
            this.CtrlTSMIRedo.Text = "Вернуть";
            // 
            // CtrlTSMIHelp
            // 
            this.CtrlTSMIHelp.Name = "CtrlTSMIHelp";
            this.CtrlTSMIHelp.Size = new System.Drawing.Size(68, 20);
            this.CtrlTSMIHelp.Text = "Помощь";
            this.CtrlTSMIHelp.Click += new System.EventHandler(this.CtrlTSMIHelp_Click);
            // 
            // CtrlTSMILoadFigures
            // 
            this.CtrlTSMILoadFigures.Name = "CtrlTSMILoadFigures";
            this.CtrlTSMILoadFigures.Size = new System.Drawing.Size(119, 20);
            this.CtrlTSMILoadFigures.Text = "Загрузить фигуры";
            this.CtrlTSMILoadFigures.Click += new System.EventHandler(this.CtrlTSMILoadFigures_Click);
            // 
            // CtrlPanelMain
            // 
            this.CtrlPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlPanelMain.BackColor = System.Drawing.Color.White;
            this.CtrlPanelMain.Location = new System.Drawing.Point(129, 27);
            this.CtrlPanelMain.Name = "CtrlPanelMain";
            this.CtrlPanelMain.Size = new System.Drawing.Size(523, 581);
            this.CtrlPanelMain.TabIndex = 2;
            this.CtrlPanelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CtrlPanelMain_MouseDown);
            this.CtrlPanelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CtrlPanelMain_MouseMove);
            this.CtrlPanelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CtrlPanelMain_MouseUp);
            // 
            // CtrlGrBTools
            // 
            this.CtrlGrBTools.Controls.Add(this.CtrlButArea);
            this.CtrlGrBTools.Controls.Add(this.CtrlButSel);
            this.CtrlGrBTools.Controls.Add(this.CtrlButRect);
            this.CtrlGrBTools.Controls.Add(this.CtrlButEll);
            this.CtrlGrBTools.Controls.Add(this.CtrlButLine);
            this.CtrlGrBTools.Location = new System.Drawing.Point(12, 30);
            this.CtrlGrBTools.Name = "CtrlGrBTools";
            this.CtrlGrBTools.Size = new System.Drawing.Size(111, 237);
            this.CtrlGrBTools.TabIndex = 0;
            this.CtrlGrBTools.TabStop = false;
            this.CtrlGrBTools.Text = "Инструменты";
            // 
            // CtrlButArea
            // 
            this.CtrlButArea.BackgroundImage = global::OOP3.Properties.Resources.Selection;
            this.CtrlButArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButArea.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButArea.Location = new System.Drawing.Point(38, 50);
            this.CtrlButArea.Name = "CtrlButArea";
            this.CtrlButArea.Size = new System.Drawing.Size(26, 25);
            this.CtrlButArea.TabIndex = 4;
            this.CtrlButArea.Tag = "-2";
            this.CtrlButArea.UseVisualStyleBackColor = true;
            this.CtrlButArea.Click += new System.EventHandler(this.CtrlButTool_Click);
            // 
            // CtrlButSel
            // 
            this.CtrlButSel.BackgroundImage = global::OOP3.Properties.Resources.Arrow;
            this.CtrlButSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButSel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButSel.Location = new System.Drawing.Point(6, 50);
            this.CtrlButSel.Name = "CtrlButSel";
            this.CtrlButSel.Size = new System.Drawing.Size(26, 25);
            this.CtrlButSel.TabIndex = 3;
            this.CtrlButSel.Tag = "-1";
            this.CtrlButSel.UseVisualStyleBackColor = true;
            this.CtrlButSel.Click += new System.EventHandler(this.CtrlButTool_Click);
            // 
            // CtrlButRect
            // 
            this.CtrlButRect.BackgroundImage = global::OOP3.Properties.Resources.Rectangle;
            this.CtrlButRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButRect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButRect.Location = new System.Drawing.Point(70, 19);
            this.CtrlButRect.Name = "CtrlButRect";
            this.CtrlButRect.Size = new System.Drawing.Size(26, 25);
            this.CtrlButRect.TabIndex = 2;
            this.CtrlButRect.Tag = "2";
            this.CtrlButRect.UseVisualStyleBackColor = true;
            this.CtrlButRect.Click += new System.EventHandler(this.CtrlButTool_Click);
            // 
            // CtrlButEll
            // 
            this.CtrlButEll.BackgroundImage = global::OOP3.Properties.Resources.Ellipse;
            this.CtrlButEll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButEll.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButEll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButEll.Location = new System.Drawing.Point(6, 19);
            this.CtrlButEll.Name = "CtrlButEll";
            this.CtrlButEll.Size = new System.Drawing.Size(26, 25);
            this.CtrlButEll.TabIndex = 1;
            this.CtrlButEll.Tag = "0";
            this.CtrlButEll.UseVisualStyleBackColor = true;
            this.CtrlButEll.Click += new System.EventHandler(this.CtrlButTool_Click);
            // 
            // CtrlButLine
            // 
            this.CtrlButLine.BackgroundImage = global::OOP3.Properties.Resources.Line;
            this.CtrlButLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButLine.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButLine.Location = new System.Drawing.Point(38, 19);
            this.CtrlButLine.Name = "CtrlButLine";
            this.CtrlButLine.Size = new System.Drawing.Size(26, 25);
            this.CtrlButLine.TabIndex = 0;
            this.CtrlButLine.Tag = "1";
            this.CtrlButLine.UseVisualStyleBackColor = true;
            this.CtrlButLine.Click += new System.EventHandler(this.CtrlButTool_Click);
            // 
            // CtrlGrBSpecials
            // 
            this.CtrlGrBSpecials.Controls.Add(this.CtrlButUngroup);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlButGroup);
            this.CtrlGrBSpecials.Location = new System.Drawing.Point(658, 30);
            this.CtrlGrBSpecials.Name = "CtrlGrBSpecials";
            this.CtrlGrBSpecials.Size = new System.Drawing.Size(166, 185);
            this.CtrlGrBSpecials.TabIndex = 3;
            this.CtrlGrBSpecials.TabStop = false;
            this.CtrlGrBSpecials.Text = "Опции";
            // 
            // CtrlButUngroup
            // 
            this.CtrlButUngroup.BackgroundImage = global::OOP3.Properties.Resources.Ungroup;
            this.CtrlButUngroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButUngroup.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButUngroup.Location = new System.Drawing.Point(38, 19);
            this.CtrlButUngroup.Name = "CtrlButUngroup";
            this.CtrlButUngroup.Size = new System.Drawing.Size(26, 25);
            this.CtrlButUngroup.TabIndex = 6;
            this.CtrlButUngroup.Tag = "1";
            this.CtrlButUngroup.UseVisualStyleBackColor = true;
            this.CtrlButUngroup.Click += new System.EventHandler(this.CtrlButSpecial_Click);
            // 
            // CtrlButGroup
            // 
            this.CtrlButGroup.BackgroundImage = global::OOP3.Properties.Resources.Group;
            this.CtrlButGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButGroup.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CtrlButGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButGroup.Location = new System.Drawing.Point(6, 19);
            this.CtrlButGroup.Name = "CtrlButGroup";
            this.CtrlButGroup.Size = new System.Drawing.Size(26, 25);
            this.CtrlButGroup.TabIndex = 5;
            this.CtrlButGroup.Tag = "0";
            this.CtrlButGroup.UseVisualStyleBackColor = true;
            this.CtrlButGroup.Click += new System.EventHandler(this.CtrlButSpecial_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 620);
            this.Controls.Add(this.CtrlGrBSpecials);
            this.Controls.Add(this.CtrlGrBTools);
            this.Controls.Add(this.CtrlPanelMain);
            this.Controls.Add(this.CtrlTSMain);
            this.MainMenuStrip = this.CtrlTSMain;
            this.Name = "MainForm";
            this.Text = "ТюкачDraw";
            this.CtrlTSMain.ResumeLayout(false);
            this.CtrlTSMain.PerformLayout();
            this.CtrlGrBTools.ResumeLayout(false);
            this.CtrlGrBSpecials.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip CtrlTSMain;
        private ToolStripMenuItem CtrlTSMIFile;
        private ToolStripMenuItem CtrlTSMINew;
        private ToolStripMenuItem CtrlTSMIOpen;
        private ToolStripMenuItem CtrlTSMISave;
        private ToolStripSeparator CtrlTSMIFiller;
        private ToolStripMenuItem CtrlTSMIClose;
        private ToolStripMenuItem CtrlTSMIEdit;
        private ToolStripMenuItem CtrlTSMIUndo;
        private ToolStripMenuItem CtrlTSMIRedo;
        private ToolStripMenuItem CtrlTSMIHelp;
        private Panel CtrlPanelMain;
        private ToolStripMenuItem CtrlTSMILoadFigures;
        private GroupBox CtrlGrBTools;
        private Button CtrlButRect;
        private Button CtrlButEll;
        private Button CtrlButLine;
        private Button CtrlButSel;
        private Button CtrlButArea;
        private GroupBox CtrlGrBSpecials;
        private Button CtrlButUngroup;
        private Button CtrlButGroup;
    }
}

