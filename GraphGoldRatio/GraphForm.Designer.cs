
namespace GraphGoldRatio
{
    partial class GraphForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkMin = new System.Windows.Forms.CheckBox();
            this.checkMax = new System.Windows.Forms.CheckBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.inputEps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.inputTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFrom = new System.Windows.Forms.TextBox();
            this.textCoord = new System.Windows.Forms.Label();
            this.groupFunctions = new System.Windows.Forms.GroupBox();
            this.textCCoord = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.PictureBox();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.checkBorders = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputYStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputXStep = new System.Windows.Forms.TextBox();
            this.checkSmooting = new System.Windows.Forms.CheckBox();
            this.checkValues = new System.Windows.Forms.CheckBox();
            this.inputOffsetY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputOffsetX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameYAxis = new System.Windows.Forms.TextBox();
            this.nameXAxis = new System.Windows.Forms.TextBox();
            this.checkYAxis = new System.Windows.Forms.CheckBox();
            this.checkXAxis = new System.Windows.Forms.CheckBox();
            this.checkArrows = new System.Windows.Forms.CheckBox();
            this.checkGrid = new System.Windows.Forms.CheckBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(971, 68);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(40, 37);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ChangeScale);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(971, 105);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(40, 37);
            this.buttonMinus.TabIndex = 20;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ChangeScale);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkMin);
            this.groupBox1.Controls.Add(this.checkMax);
            this.groupBox1.Controls.Add(this.buttonHelp);
            this.groupBox1.Controls.Add(this.inputEps);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.inputTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(11, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 289);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Golden ratio";
            // 
            // checkMin
            // 
            this.checkMin.AutoSize = true;
            this.checkMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkMin.Location = new System.Drawing.Point(153, 31);
            this.checkMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMin.Name = "checkMin";
            this.checkMin.Size = new System.Drawing.Size(91, 22);
            this.checkMin.TabIndex = 11;
            this.checkMin.Text = "Minimum";
            this.checkMin.UseVisualStyleBackColor = true;
            this.checkMin.Click += new System.EventHandler(this.ChooseMinMax);
            // 
            // checkMax
            // 
            this.checkMax.AutoSize = true;
            this.checkMax.Checked = true;
            this.checkMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkMax.Location = new System.Drawing.Point(40, 31);
            this.checkMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMax.Name = "checkMax";
            this.checkMax.Size = new System.Drawing.Size(95, 22);
            this.checkMax.TabIndex = 10;
            this.checkMax.Text = "Maximum";
            this.checkMax.UseVisualStyleBackColor = true;
            this.checkMax.Click += new System.EventHandler(this.ChooseMinMax);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp.Location = new System.Drawing.Point(257, 203);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(33, 31);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // inputEps
            // 
            this.inputEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputEps.Location = new System.Drawing.Point(69, 156);
            this.inputEps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputEps.Name = "inputEps";
            this.inputEps.Size = new System.Drawing.Size(212, 24);
            this.inputEps.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eps:";
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFind.Location = new System.Drawing.Point(11, 246);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(280, 31);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(11, 203);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(239, 31);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // inputTo
            // 
            this.inputTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTo.Location = new System.Drawing.Point(69, 113);
            this.inputTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTo.Name = "inputTo";
            this.inputTo.Size = new System.Drawing.Size(212, 24);
            this.inputTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // inputFrom
            // 
            this.inputFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFrom.Location = new System.Drawing.Point(69, 71);
            this.inputFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputFrom.Name = "inputFrom";
            this.inputFrom.Size = new System.Drawing.Size(212, 24);
            this.inputFrom.TabIndex = 0;
            // 
            // textCoord
            // 
            this.textCoord.Location = new System.Drawing.Point(733, 662);
            this.textCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textCoord.Name = "textCoord";
            this.textCoord.Size = new System.Drawing.Size(267, 25);
            this.textCoord.TabIndex = 27;
            this.textCoord.Text = "Cursor position: x = 0; y = 0";
            this.textCoord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupFunctions
            // 
            this.groupFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupFunctions.Location = new System.Drawing.Point(11, 12);
            this.groupFunctions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupFunctions.Name = "groupFunctions";
            this.groupFunctions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupFunctions.Size = new System.Drawing.Size(300, 350);
            this.groupFunctions.TabIndex = 28;
            this.groupFunctions.TabStop = false;
            this.groupFunctions.Text = "Functions:";
            // 
            // textCCoord
            // 
            this.textCCoord.Location = new System.Drawing.Point(400, 662);
            this.textCCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textCCoord.Name = "textCCoord";
            this.textCCoord.Size = new System.Drawing.Size(267, 25);
            this.textCCoord.TabIndex = 29;
            this.textCCoord.Text = "Click position: x = 0; y = 0";
            this.textCCoord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImage = global::GraphGoldRatio.Properties.Resources.Settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(971, 25);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(40, 37);
            this.buttonSettings.TabIndex = 30;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // graph
            // 
            this.graph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graph.Location = new System.Drawing.Point(317, 12);
            this.graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(699, 645);
            this.graph.TabIndex = 5;
            this.graph.TabStop = false;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            this.graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graph_MouseMove);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.checkBorders);
            this.settingsBox.Controls.Add(this.label7);
            this.settingsBox.Controls.Add(this.inputYStep);
            this.settingsBox.Controls.Add(this.label6);
            this.settingsBox.Controls.Add(this.inputXStep);
            this.settingsBox.Controls.Add(this.checkSmooting);
            this.settingsBox.Controls.Add(this.checkValues);
            this.settingsBox.Controls.Add(this.inputOffsetY);
            this.settingsBox.Controls.Add(this.label5);
            this.settingsBox.Controls.Add(this.inputOffsetX);
            this.settingsBox.Controls.Add(this.label4);
            this.settingsBox.Controls.Add(this.nameYAxis);
            this.settingsBox.Controls.Add(this.nameXAxis);
            this.settingsBox.Controls.Add(this.checkYAxis);
            this.settingsBox.Controls.Add(this.checkXAxis);
            this.settingsBox.Controls.Add(this.checkArrows);
            this.settingsBox.Controls.Add(this.checkGrid);
            this.settingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBox.Location = new System.Drawing.Point(696, 25);
            this.settingsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsBox.Size = new System.Drawing.Size(267, 320);
            this.settingsBox.TabIndex = 31;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            this.settingsBox.Visible = false;
            // 
            // checkBorders
            // 
            this.checkBorders.AutoSize = true;
            this.checkBorders.Checked = true;
            this.checkBorders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBorders.Location = new System.Drawing.Point(20, 289);
            this.checkBorders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBorders.Name = "checkBorders";
            this.checkBorders.Size = new System.Drawing.Size(159, 21);
            this.checkBorders.TabIndex = 18;
            this.checkBorders.Text = "Borders golden ratio";
            this.checkBorders.UseVisualStyleBackColor = true;
            this.checkBorders.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(164, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "step";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // inputYStep
            // 
            this.inputYStep.BackColor = System.Drawing.SystemColors.Control;
            this.inputYStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputYStep.Location = new System.Drawing.Point(212, 252);
            this.inputYStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputYStep.Name = "inputYStep";
            this.inputYStep.Size = new System.Drawing.Size(46, 25);
            this.inputYStep.TabIndex = 16;
            this.inputYStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputYStep.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(164, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "step";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // inputXStep
            // 
            this.inputXStep.BackColor = System.Drawing.SystemColors.Control;
            this.inputXStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputXStep.Location = new System.Drawing.Point(212, 187);
            this.inputXStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputXStep.Name = "inputXStep";
            this.inputXStep.Size = new System.Drawing.Size(46, 25);
            this.inputXStep.TabIndex = 14;
            this.inputXStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputXStep.Visible = false;
            // 
            // checkSmooting
            // 
            this.checkSmooting.AutoSize = true;
            this.checkSmooting.Checked = true;
            this.checkSmooting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSmooting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSmooting.Location = new System.Drawing.Point(20, 26);
            this.checkSmooting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSmooting.Name = "checkSmooting";
            this.checkSmooting.Size = new System.Drawing.Size(94, 22);
            this.checkSmooting.TabIndex = 13;
            this.checkSmooting.Text = "Smooting";
            this.checkSmooting.UseVisualStyleBackColor = true;
            this.checkSmooting.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // checkValues
            // 
            this.checkValues.AutoSize = true;
            this.checkValues.Checked = true;
            this.checkValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkValues.Location = new System.Drawing.Point(20, 118);
            this.checkValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkValues.Name = "checkValues";
            this.checkValues.Size = new System.Drawing.Size(150, 21);
            this.checkValues.TabIndex = 12;
            this.checkValues.Text = "Values on the axes";
            this.checkValues.UseVisualStyleBackColor = true;
            this.checkValues.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // inputOffsetY
            // 
            this.inputOffsetY.BackColor = System.Drawing.SystemColors.Control;
            this.inputOffsetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputOffsetY.Location = new System.Drawing.Point(87, 252);
            this.inputOffsetY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputOffsetY.Name = "inputOffsetY";
            this.inputOffsetY.Size = new System.Drawing.Size(39, 25);
            this.inputOffsetY.TabIndex = 11;
            this.inputOffsetY.Text = "0";
            this.inputOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputOffsetY.TextChanged += new System.EventHandler(this.TextChangeOffset);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "offset Y";
            // 
            // inputOffsetX
            // 
            this.inputOffsetX.BackColor = System.Drawing.SystemColors.Control;
            this.inputOffsetX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputOffsetX.Location = new System.Drawing.Point(87, 187);
            this.inputOffsetX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputOffsetX.Name = "inputOffsetX";
            this.inputOffsetX.Size = new System.Drawing.Size(39, 25);
            this.inputOffsetX.TabIndex = 8;
            this.inputOffsetX.Text = "0";
            this.inputOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputOffsetX.TextChanged += new System.EventHandler(this.TextChangeOffset);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "offset X";
            // 
            // nameYAxis
            // 
            this.nameYAxis.BackColor = System.Drawing.SystemColors.Control;
            this.nameYAxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameYAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameYAxis.Location = new System.Drawing.Point(139, 220);
            this.nameYAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameYAxis.MaxLength = 16;
            this.nameYAxis.Name = "nameYAxis";
            this.nameYAxis.Size = new System.Drawing.Size(119, 25);
            this.nameYAxis.TabIndex = 5;
            this.nameYAxis.Text = "Y";
            this.nameYAxis.TextChanged += new System.EventHandler(this.SettingsUpdate);
            // 
            // nameXAxis
            // 
            this.nameXAxis.BackColor = System.Drawing.SystemColors.Control;
            this.nameXAxis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameXAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameXAxis.Location = new System.Drawing.Point(139, 154);
            this.nameXAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameXAxis.MaxLength = 16;
            this.nameXAxis.Name = "nameXAxis";
            this.nameXAxis.Size = new System.Drawing.Size(119, 25);
            this.nameXAxis.TabIndex = 4;
            this.nameXAxis.Text = "X";
            this.nameXAxis.TextChanged += new System.EventHandler(this.SettingsUpdate);
            // 
            // checkYAxis
            // 
            this.checkYAxis.AutoSize = true;
            this.checkYAxis.Checked = true;
            this.checkYAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkYAxis.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkYAxis.Location = new System.Drawing.Point(20, 220);
            this.checkYAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkYAxis.Name = "checkYAxis";
            this.checkYAxis.Size = new System.Drawing.Size(77, 22);
            this.checkYAxis.TabIndex = 3;
            this.checkYAxis.Text = "Axis - y";
            this.checkYAxis.UseVisualStyleBackColor = true;
            this.checkYAxis.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // checkXAxis
            // 
            this.checkXAxis.AutoSize = true;
            this.checkXAxis.Checked = true;
            this.checkXAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkXAxis.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkXAxis.Location = new System.Drawing.Point(20, 153);
            this.checkXAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkXAxis.Name = "checkXAxis";
            this.checkXAxis.Size = new System.Drawing.Size(77, 22);
            this.checkXAxis.TabIndex = 2;
            this.checkXAxis.Text = "Axis - x";
            this.checkXAxis.UseVisualStyleBackColor = true;
            this.checkXAxis.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // checkArrows
            // 
            this.checkArrows.AutoSize = true;
            this.checkArrows.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkArrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkArrows.Location = new System.Drawing.Point(20, 87);
            this.checkArrows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkArrows.Name = "checkArrows";
            this.checkArrows.Size = new System.Drawing.Size(77, 22);
            this.checkArrows.TabIndex = 1;
            this.checkArrows.Text = "Arrows";
            this.checkArrows.UseVisualStyleBackColor = true;
            this.checkArrows.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // checkGrid
            // 
            this.checkGrid.AutoSize = true;
            this.checkGrid.Checked = true;
            this.checkGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkGrid.Location = new System.Drawing.Point(20, 57);
            this.checkGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkGrid.Name = "checkGrid";
            this.checkGrid.Size = new System.Drawing.Size(58, 22);
            this.checkGrid.TabIndex = 0;
            this.checkGrid.Text = "Grid";
            this.checkGrid.UseVisualStyleBackColor = true;
            this.checkGrid.Click += new System.EventHandler(this.SettingsUpdate);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(971, 572);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 37);
            this.buttonRight.TabIndex = 32;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ChangeOffset);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDown.Location = new System.Drawing.Point(931, 609);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 37);
            this.buttonDown.TabIndex = 33;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ChangeOffset);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(891, 572);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 37);
            this.buttonLeft.TabIndex = 34;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ChangeOffset);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.Location = new System.Drawing.Point(931, 535);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 37);
            this.buttonUp.TabIndex = 35;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ChangeOffset);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCenter.Location = new System.Drawing.Point(931, 572);
            this.buttonCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(40, 37);
            this.buttonCenter.TabIndex = 36;
            this.buttonCenter.Text = "+";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.ChangeOffset);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 679);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.textCCoord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupFunctions);
            this.Controls.Add(this.textCoord);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.graph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 726);
            this.MinimumSize = new System.Drawing.Size(1061, 726);
            this.Name = "GraphForm";
            this.Text = "Graph+/Golden Ratio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox inputTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputFrom;
        private System.Windows.Forms.Label textCoord;
        private System.Windows.Forms.GroupBox groupFunctions;
        private System.Windows.Forms.Label textCCoord;
        public System.Windows.Forms.PictureBox graph;
        private System.Windows.Forms.TextBox inputEps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.TextBox inputOffsetY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputOffsetX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameYAxis;
        private System.Windows.Forms.TextBox nameXAxis;
        private System.Windows.Forms.CheckBox checkYAxis;
        private System.Windows.Forms.CheckBox checkXAxis;
        private System.Windows.Forms.CheckBox checkArrows;
        private System.Windows.Forms.CheckBox checkGrid;
        private System.Windows.Forms.CheckBox checkSmooting;
        private System.Windows.Forms.CheckBox checkValues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputYStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputXStep;
        private System.Windows.Forms.CheckBox checkMin;
        private System.Windows.Forms.CheckBox checkMax;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.CheckBox checkBorders;
    }
}

