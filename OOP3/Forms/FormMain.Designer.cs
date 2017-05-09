using System;
using System.Drawing.Drawing2D;
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
            this.CtrlTSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIFiller = new System.Windows.Forms.ToolStripSeparator();
            this.CtrlTSMIClose = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlTSMIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.CtrlPanelMain = new System.Windows.Forms.Panel();
            this.CtrlGrBTools = new System.Windows.Forms.GroupBox();
            this.CtrlButArea = new System.Windows.Forms.Button();
            this.CtrlButSel = new System.Windows.Forms.Button();
            this.CtrlButRect = new System.Windows.Forms.Button();
            this.CtrlButEll = new System.Windows.Forms.Button();
            this.CtrlButLine = new System.Windows.Forms.Button();
            this.CtrlGrBSpecials = new System.Windows.Forms.GroupBox();
            this.CtrlButColFG = new System.Windows.Forms.Button();
            this.CtrlLblMisc2 = new System.Windows.Forms.Label();
            this.CtrlLblMisc1 = new System.Windows.Forms.Label();
            this.CtrlLBDashStyles = new System.Windows.Forms.ListBox();
            this.CtrlLBFillStyles = new System.Windows.Forms.ListBox();
            this.CtrlNudWidth = new System.Windows.Forms.NumericUpDown();
            this.CtrlButColBG = new System.Windows.Forms.Button();
            this.CtrlButUngroup = new System.Windows.Forms.Button();
            this.CtrlButGroup = new System.Windows.Forms.Button();
            this.CtrlTSMain.SuspendLayout();
            this.CtrlGrBTools.SuspendLayout();
            this.CtrlGrBSpecials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlTSMain
            // 
            this.CtrlTSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlTSMIFile,
            this.CtrlTSMIEdit,
            this.CtrlTSMIHelp});
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
            // CtrlTSMISave
            // 
            this.CtrlTSMISave.Enabled = false;
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
            // CtrlPanelMain
            // 
            this.CtrlPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlPanelMain.BackColor = System.Drawing.Color.White;
            this.CtrlPanelMain.Enabled = false;
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
            this.CtrlGrBSpecials.Controls.Add(this.CtrlButColFG);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlLblMisc2);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlLblMisc1);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlLBDashStyles);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlLBFillStyles);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlNudWidth);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlButColBG);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlButUngroup);
            this.CtrlGrBSpecials.Controls.Add(this.CtrlButGroup);
            this.CtrlGrBSpecials.Location = new System.Drawing.Point(658, 30);
            this.CtrlGrBSpecials.Name = "CtrlGrBSpecials";
            this.CtrlGrBSpecials.Size = new System.Drawing.Size(166, 340);
            this.CtrlGrBSpecials.TabIndex = 3;
            this.CtrlGrBSpecials.TabStop = false;
            this.CtrlGrBSpecials.Text = "Опции";
            // 
            // CtrlButColFG
            // 
            this.CtrlButColFG.BackColor = System.Drawing.Color.Black;
            this.CtrlButColFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButColFG.Location = new System.Drawing.Point(6, 238);
            this.CtrlButColFG.Name = "CtrlButColFG";
            this.CtrlButColFG.Size = new System.Drawing.Size(50, 50);
            this.CtrlButColFG.TabIndex = 1;
            this.CtrlButColFG.Tag = "0";
            this.CtrlButColFG.UseVisualStyleBackColor = false;
            this.CtrlButColFG.Click += new System.EventHandler(this.ColorChange);
            // 
            // CtrlLblMisc2
            // 
            this.CtrlLblMisc2.AutoSize = true;
            this.CtrlLblMisc2.Location = new System.Drawing.Point(6, 147);
            this.CtrlLblMisc2.Name = "CtrlLblMisc2";
            this.CtrlLblMisc2.Size = new System.Drawing.Size(83, 13);
            this.CtrlLblMisc2.TabIndex = 10;
            this.CtrlLblMisc2.Text = "Стиль границы";
            // 
            // CtrlLblMisc1
            // 
            this.CtrlLblMisc1.AutoSize = true;
            this.CtrlLblMisc1.Location = new System.Drawing.Point(6, 56);
            this.CtrlLblMisc1.Name = "CtrlLblMisc1";
            this.CtrlLblMisc1.Size = new System.Drawing.Size(82, 13);
            this.CtrlLblMisc1.TabIndex = 9;
            this.CtrlLblMisc1.Text = "Стиль заливки";
            // 
            // CtrlLBDashStyles
            // 
            this.CtrlLBDashStyles.FormattingEnabled = true;
            this.CtrlLBDashStyles.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.CtrlLBDashStyles.Location = new System.Drawing.Point(6, 163);
            this.CtrlLBDashStyles.Name = "CtrlLBDashStyles";
            this.CtrlLBDashStyles.Size = new System.Drawing.Size(100, 69);
            this.CtrlLBDashStyles.TabIndex = 8;
            this.CtrlLBDashStyles.SelectedIndexChanged += new System.EventHandler(this.ColorChange);
            // 
            // CtrlLBFillStyles
            // 
            this.CtrlLBFillStyles.FormattingEnabled = true;
            this.CtrlLBFillStyles.Items.AddRange(new object[] {
            "Solid",
            "Horizontal",
            "Vertical",
            "ForwardDiagonal",
            "BackwardDiagonal",
            "Cross",
            "Cross 2",
            "LargeGrid",
            "DiagonalCross",
            "Percent05",
            "Percent10",
            "Percent20",
            "Percent25",
            "Percent30",
            "Percent40",
            "Percent50",
            "Percent60",
            "Percent70",
            "Percent75",
            "Percent80",
            "Percent90",
            "LightDownwardDiagonal",
            "LightUpwardDiagonal",
            "DarkDownwardDiagonal",
            "DarkUpwardDiagonal",
            "WideDownwardDiagonal",
            "WideUpwardDiagonal",
            "LightVertical",
            "LightHorizontal",
            "NarrowVertical",
            "NarrowHorizontal",
            "DarkVertical",
            "DarkHorizontal",
            "DashedDownwardDiagonal",
            "DashedUpwardDiagonal",
            "DashedHorizontal",
            "DashedVertical",
            "SmallConfetti",
            "LargeConfetti",
            "ZigZag",
            "Wave",
            "DiagonalBrick",
            "HorizontalBrick",
            "Weave",
            "Plaid",
            "Divot",
            "DottedGrid",
            "DottedDiamond",
            "Shingle",
            "Trellis",
            "Sphere",
            "SmallGrid",
            "SmallCheckerBoard",
            "LargeCheckerBoard",
            "OutlinedDiamond",
            "SolidDiamond"});
            this.CtrlLBFillStyles.Location = new System.Drawing.Point(6, 72);
            this.CtrlLBFillStyles.Name = "CtrlLBFillStyles";
            this.CtrlLBFillStyles.Size = new System.Drawing.Size(100, 69);
            this.CtrlLBFillStyles.TabIndex = 7;
            this.CtrlLBFillStyles.SelectedIndexChanged += new System.EventHandler(this.ColorChange);
            // 
            // CtrlNudWidth
            // 
            this.CtrlNudWidth.Location = new System.Drawing.Point(118, 58);
            this.CtrlNudWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CtrlNudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlNudWidth.Name = "CtrlNudWidth";
            this.CtrlNudWidth.Size = new System.Drawing.Size(42, 20);
            this.CtrlNudWidth.TabIndex = 4;
            this.CtrlNudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlNudWidth.ValueChanged += new System.EventHandler(this.ColorChange);
            // 
            // CtrlButColBG
            // 
            this.CtrlButColBG.BackColor = System.Drawing.Color.White;
            this.CtrlButColBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CtrlButColBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtrlButColBG.Location = new System.Drawing.Point(25, 260);
            this.CtrlButColBG.Name = "CtrlButColBG";
            this.CtrlButColBG.Size = new System.Drawing.Size(50, 50);
            this.CtrlButColBG.TabIndex = 0;
            this.CtrlButColBG.Tag = "1";
            this.CtrlButColBG.UseVisualStyleBackColor = false;
            this.CtrlButColBG.Click += new System.EventHandler(this.ColorChange);
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
            this.CtrlGrBSpecials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip CtrlTSMain;
        private ToolStripMenuItem CtrlTSMIFile;
        private ToolStripMenuItem CtrlTSMINew;
        private ToolStripMenuItem CtrlTSMISave;
        private ToolStripSeparator CtrlTSMIFiller;
        private ToolStripMenuItem CtrlTSMIClose;
        private ToolStripMenuItem CtrlTSMIEdit;
        private ToolStripMenuItem CtrlTSMIUndo;
        private ToolStripMenuItem CtrlTSMIRedo;
        private ToolStripMenuItem CtrlTSMIHelp;
        private Panel CtrlPanelMain;
        private GroupBox CtrlGrBTools;
        private Button CtrlButRect;
        private Button CtrlButEll;
        private Button CtrlButLine;
        private Button CtrlButSel;
        private Button CtrlButArea;
        private GroupBox CtrlGrBSpecials;
        private Button CtrlButUngroup;
        private Button CtrlButGroup;
        private Button CtrlButColBG;
        private Button CtrlButColFG;
        private ListBox CtrlLBFillStyles;
        private NumericUpDown CtrlNudWidth;
        private ListBox CtrlLBDashStyles;
        private Label CtrlLblMisc2;
        private Label CtrlLblMisc1;
    }
}

