namespace FlowTimer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent() {
            this.TabPageVariableOffset = new System.Windows.Forms.TabPage();
            this.TextBoxFrame = new System.Windows.Forms.TextBox();
            this.LabelFrame = new System.Windows.Forms.Label();
            this.LabelFPS = new System.Windows.Forms.Label();
            this.TextBoxOffset = new System.Windows.Forms.TextBox();
            this.LabelOffset2 = new System.Windows.Forms.Label();
            this.TextBoxInterval = new System.Windows.Forms.TextBox();
            this.LabelInterval2 = new System.Windows.Forms.Label();
            this.TextBoxBeeps = new System.Windows.Forms.TextBox();
            this.LabelBeeps2 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ComboBoxFPS = new System.Windows.Forms.ComboBox();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.TabPageFixedOffset = new System.Windows.Forms.TabPage();
            this.ButtonLoadTimers = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelOffset = new System.Windows.Forms.Label();
            this.ButtonSaveTimers = new System.Windows.Forms.Button();
            this.LabelInterval = new System.Windows.Forms.Label();
            this.LabelBeeps = new System.Windows.Forms.Label();
            this.PictureBoxPin = new System.Windows.Forms.PictureBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TabPageChocobo = new System.Windows.Forms.TabPage();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.GroupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.RadioButtonC = new System.Windows.Forms.RadioButton();
            this.RadioButtonB = new System.Windows.Forms.RadioButton();
            this.RadioButtonA = new System.Windows.Forms.RadioButton();
            this.RadioButtonS = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxChocoOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxSneakAttack = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.TabPageVariableOffset.SuspendLayout();
            this.TabPageFixedOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPin)).BeginInit();
            this.TabPageChocobo.SuspendLayout();
            this.GroupBoxRadioButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageVariableOffset
            // 
            this.TabPageVariableOffset.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageVariableOffset.Controls.Add(this.ButtonUndo);
            this.TabPageVariableOffset.Controls.Add(this.ButtonMinus);
            this.TabPageVariableOffset.Controls.Add(this.ButtonPlus);
            this.TabPageVariableOffset.Controls.Add(this.ComboBoxFPS);
            this.TabPageVariableOffset.Controls.Add(this.ButtonSubmit);
            this.TabPageVariableOffset.Controls.Add(this.LabelBeeps2);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxBeeps);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxInterval);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxOffset);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxFrame);
            this.TabPageVariableOffset.Controls.Add(this.LabelInterval2);
            this.TabPageVariableOffset.Controls.Add(this.LabelOffset2);
            this.TabPageVariableOffset.Controls.Add(this.LabelFPS);
            this.TabPageVariableOffset.Controls.Add(this.LabelFrame);
            this.TabPageVariableOffset.Location = new System.Drawing.Point(4, 22);
            this.TabPageVariableOffset.Name = "TabPageVariableOffset";
            this.TabPageVariableOffset.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageVariableOffset.Size = new System.Drawing.Size(528, 224);
            this.TabPageVariableOffset.TabIndex = 1;
            this.TabPageVariableOffset.Text = "Variable Offset";
            // 
            // TextBoxFrame
            // 
            this.TextBoxFrame.Location = new System.Drawing.Point(240, 13);
            this.TextBoxFrame.Name = "TextBoxFrame";
            this.TextBoxFrame.Size = new System.Drawing.Size(80, 20);
            this.TextBoxFrame.TabIndex = 0;
            this.TextBoxFrame.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelFrame
            // 
            this.LabelFrame.AutoSize = true;
            this.LabelFrame.Location = new System.Drawing.Point(192, 16);
            this.LabelFrame.Name = "LabelFrame";
            this.LabelFrame.Size = new System.Drawing.Size(39, 13);
            this.LabelFrame.TabIndex = 1;
            this.LabelFrame.Text = "Frame:";
            // 
            // LabelFPS
            // 
            this.LabelFPS.AutoSize = true;
            this.LabelFPS.Location = new System.Drawing.Point(192, 42);
            this.LabelFPS.Name = "LabelFPS";
            this.LabelFPS.Size = new System.Drawing.Size(30, 13);
            this.LabelFPS.TabIndex = 3;
            this.LabelFPS.Text = "FPS:";
            // 
            // TextBoxOffset
            // 
            this.TextBoxOffset.Location = new System.Drawing.Point(240, 65);
            this.TextBoxOffset.Name = "TextBoxOffset";
            this.TextBoxOffset.Size = new System.Drawing.Size(80, 20);
            this.TextBoxOffset.TabIndex = 4;
            this.TextBoxOffset.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelOffset2
            // 
            this.LabelOffset2.AutoSize = true;
            this.LabelOffset2.Location = new System.Drawing.Point(192, 68);
            this.LabelOffset2.Name = "LabelOffset2";
            this.LabelOffset2.Size = new System.Drawing.Size(38, 13);
            this.LabelOffset2.TabIndex = 5;
            this.LabelOffset2.Text = "Offset:";
            // 
            // TextBoxInterval
            // 
            this.TextBoxInterval.Location = new System.Drawing.Point(240, 91);
            this.TextBoxInterval.Name = "TextBoxInterval";
            this.TextBoxInterval.Size = new System.Drawing.Size(80, 20);
            this.TextBoxInterval.TabIndex = 6;
            this.TextBoxInterval.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelInterval2
            // 
            this.LabelInterval2.AutoSize = true;
            this.LabelInterval2.Location = new System.Drawing.Point(192, 94);
            this.LabelInterval2.Name = "LabelInterval2";
            this.LabelInterval2.Size = new System.Drawing.Size(45, 13);
            this.LabelInterval2.TabIndex = 7;
            this.LabelInterval2.Text = "Interval:";
            // 
            // TextBoxBeeps
            // 
            this.TextBoxBeeps.Location = new System.Drawing.Point(240, 117);
            this.TextBoxBeeps.Name = "TextBoxBeeps";
            this.TextBoxBeeps.Size = new System.Drawing.Size(80, 20);
            this.TextBoxBeeps.TabIndex = 8;
            this.TextBoxBeeps.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelBeeps2
            // 
            this.LabelBeeps2.AutoSize = true;
            this.LabelBeeps2.Location = new System.Drawing.Point(192, 120);
            this.LabelBeeps2.Name = "LabelBeeps2";
            this.LabelBeeps2.Size = new System.Drawing.Size(40, 13);
            this.LabelBeeps2.TabIndex = 9;
            this.LabelBeeps2.Text = "Beeps:";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(326, 12);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(80, 22);
            this.ButtonSubmit.TabIndex = 10;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ComboBoxFPS
            // 
            this.ComboBoxFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFPS.FormattingEnabled = true;
            this.ComboBoxFPS.Items.AddRange(new object[] {
            "59.7275",
            "59.6555",
            "59.8261",
            "60.0",
            "30.0",
            "25.0",
            "15.0"});
            this.ComboBoxFPS.Location = new System.Drawing.Point(240, 39);
            this.ComboBoxFPS.Name = "ComboBoxFPS";
            this.ComboBoxFPS.Size = new System.Drawing.Size(80, 21);
            this.ComboBoxFPS.TabIndex = 11;
            this.ComboBoxFPS.SelectedIndexChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(437, 12);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(22, 22);
            this.ButtonPlus.TabIndex = 12;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(413, 12);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(22, 22);
            this.ButtonMinus.TabIndex = 13;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.Location = new System.Drawing.Point(326, 38);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(80, 22);
            this.ButtonUndo.TabIndex = 14;
            this.ButtonUndo.Text = "Undo";
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // TabPageFixedOffset
            // 
            this.TabPageFixedOffset.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageFixedOffset.Controls.Add(this.ButtonAdd);
            this.TabPageFixedOffset.Controls.Add(this.PictureBoxPin);
            this.TabPageFixedOffset.Controls.Add(this.LabelBeeps);
            this.TabPageFixedOffset.Controls.Add(this.LabelInterval);
            this.TabPageFixedOffset.Controls.Add(this.ButtonSaveTimers);
            this.TabPageFixedOffset.Controls.Add(this.LabelOffset);
            this.TabPageFixedOffset.Controls.Add(this.LabelName);
            this.TabPageFixedOffset.Controls.Add(this.ButtonLoadTimers);
            this.TabPageFixedOffset.Controls.Add(this.LabelTimer);
            this.TabPageFixedOffset.Controls.Add(this.ButtonStart);
            this.TabPageFixedOffset.Controls.Add(this.ButtonStop);
            this.TabPageFixedOffset.Controls.Add(this.ButtonSettings);
            this.TabPageFixedOffset.Location = new System.Drawing.Point(4, 22);
            this.TabPageFixedOffset.Name = "TabPageFixedOffset";
            this.TabPageFixedOffset.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageFixedOffset.Size = new System.Drawing.Size(528, 224);
            this.TabPageFixedOffset.TabIndex = 0;
            this.TabPageFixedOffset.Text = "Fixed Offset";
            // 
            // ButtonLoadTimers
            // 
            this.ButtonLoadTimers.Location = new System.Drawing.Point(12, 141);
            this.ButtonLoadTimers.Name = "ButtonLoadTimers";
            this.ButtonLoadTimers.Size = new System.Drawing.Size(121, 25);
            this.ButtonLoadTimers.TabIndex = 31;
            this.ButtonLoadTimers.TabStop = false;
            this.ButtonLoadTimers.Text = "Load Timers";
            this.ButtonLoadTimers.UseVisualStyleBackColor = true;
            this.ButtonLoadTimers.Click += new System.EventHandler(this.ButtonLoadTimers_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(161, 14);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Name";
            // 
            // LabelOffset
            // 
            this.LabelOffset.AutoSize = true;
            this.LabelOffset.Location = new System.Drawing.Point(232, 14);
            this.LabelOffset.Name = "LabelOffset";
            this.LabelOffset.Size = new System.Drawing.Size(35, 13);
            this.LabelOffset.TabIndex = 12;
            this.LabelOffset.Text = "Offset";
            // 
            // ButtonSaveTimers
            // 
            this.ButtonSaveTimers.Location = new System.Drawing.Point(12, 169);
            this.ButtonSaveTimers.Name = "ButtonSaveTimers";
            this.ButtonSaveTimers.Size = new System.Drawing.Size(121, 25);
            this.ButtonSaveTimers.TabIndex = 32;
            this.ButtonSaveTimers.TabStop = false;
            this.ButtonSaveTimers.Text = "Save Timers";
            this.ButtonSaveTimers.UseVisualStyleBackColor = true;
            this.ButtonSaveTimers.Click += new System.EventHandler(this.ButtonSaveTimers_Click);
            // 
            // LabelInterval
            // 
            this.LabelInterval.AutoSize = true;
            this.LabelInterval.Location = new System.Drawing.Point(303, 14);
            this.LabelInterval.Name = "LabelInterval";
            this.LabelInterval.Size = new System.Drawing.Size(42, 13);
            this.LabelInterval.TabIndex = 13;
            this.LabelInterval.Text = "Interval";
            // 
            // LabelBeeps
            // 
            this.LabelBeeps.AutoSize = true;
            this.LabelBeeps.Location = new System.Drawing.Point(374, 14);
            this.LabelBeeps.Name = "LabelBeeps";
            this.LabelBeeps.Size = new System.Drawing.Size(37, 13);
            this.LabelBeeps.TabIndex = 16;
            this.LabelBeeps.Text = "Beeps";
            // 
            // PictureBoxPin
            // 
            this.PictureBoxPin.Location = new System.Drawing.Point(478, 4);
            this.PictureBoxPin.Name = "PictureBoxPin";
            this.PictureBoxPin.Size = new System.Drawing.Size(16, 16);
            this.PictureBoxPin.TabIndex = 33;
            this.PictureBoxPin.TabStop = false;
            this.PictureBoxPin.Click += new System.EventHandler(this.PictureBoxPin_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(0, 0);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(67, 23);
            this.ButtonAdd.TabIndex = 28;
            this.ButtonAdd.TabStop = false;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TabPageChocobo
            // 
            this.TabPageChocobo.Controls.Add(this.ButtonReset);
            this.TabPageChocobo.Controls.Add(this.checkBox1);
            this.TabPageChocobo.Controls.Add(this.CheckBoxSneakAttack);
            this.TabPageChocobo.Controls.Add(this.tableLayoutPanel1);
            this.TabPageChocobo.Controls.Add(this.GroupBoxRadioButtons);
            this.TabPageChocobo.Controls.Add(this.LabelStatus);
            this.TabPageChocobo.Location = new System.Drawing.Point(4, 22);
            this.TabPageChocobo.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageChocobo.Name = "TabPageChocobo";
            this.TabPageChocobo.Padding = new System.Windows.Forms.Padding(2);
            this.TabPageChocobo.Size = new System.Drawing.Size(528, 224);
            this.TabPageChocobo.TabIndex = 2;
            this.TabPageChocobo.Text = "Chocobo Timer";
            this.TabPageChocobo.UseVisualStyleBackColor = true;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(192, 2);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(121, 25);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "Status Text";
            this.LabelStatus.Click += new System.EventHandler(this.LabelStatus_Click);
            // 
            // GroupBoxRadioButtons
            // 
            this.GroupBoxRadioButtons.Controls.Add(this.RadioButtonS);
            this.GroupBoxRadioButtons.Controls.Add(this.RadioButtonA);
            this.GroupBoxRadioButtons.Controls.Add(this.RadioButtonB);
            this.GroupBoxRadioButtons.Controls.Add(this.RadioButtonC);
            this.GroupBoxRadioButtons.Location = new System.Drawing.Point(458, 2);
            this.GroupBoxRadioButtons.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBoxRadioButtons.Name = "GroupBoxRadioButtons";
            this.GroupBoxRadioButtons.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxRadioButtons.Size = new System.Drawing.Size(36, 69);
            this.GroupBoxRadioButtons.TabIndex = 1;
            this.GroupBoxRadioButtons.TabStop = false;
            // 
            // RadioButtonC
            // 
            this.RadioButtonC.AutoSize = true;
            this.RadioButtonC.Checked = true;
            this.RadioButtonC.Location = new System.Drawing.Point(0, 0);
            this.RadioButtonC.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonC.Name = "RadioButtonC";
            this.RadioButtonC.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonC.TabIndex = 0;
            this.RadioButtonC.TabStop = true;
            this.RadioButtonC.Text = "C";
            this.RadioButtonC.UseVisualStyleBackColor = true;
            // 
            // RadioButtonB
            // 
            this.RadioButtonB.AutoSize = true;
            this.RadioButtonB.Location = new System.Drawing.Point(0, 16);
            this.RadioButtonB.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RadioButtonB.Name = "RadioButtonB";
            this.RadioButtonB.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonB.TabIndex = 1;
            this.RadioButtonB.TabStop = true;
            this.RadioButtonB.Text = "B";
            this.RadioButtonB.UseVisualStyleBackColor = true;
            // 
            // RadioButtonA
            // 
            this.RadioButtonA.AutoSize = true;
            this.RadioButtonA.Location = new System.Drawing.Point(0, 32);
            this.RadioButtonA.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RadioButtonA.Name = "RadioButtonA";
            this.RadioButtonA.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonA.TabIndex = 2;
            this.RadioButtonA.TabStop = true;
            this.RadioButtonA.Text = "A";
            this.RadioButtonA.UseVisualStyleBackColor = true;
            // 
            // RadioButtonS
            // 
            this.RadioButtonS.AutoSize = true;
            this.RadioButtonS.Location = new System.Drawing.Point(0, 49);
            this.RadioButtonS.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RadioButtonS.Name = "RadioButtonS";
            this.RadioButtonS.Size = new System.Drawing.Size(32, 17);
            this.RadioButtonS.TabIndex = 3;
            this.RadioButtonS.TabStop = true;
            this.RadioButtonS.Text = "S";
            this.RadioButtonS.UseVisualStyleBackColor = true;
            this.RadioButtonS.CheckedChanged += new System.EventHandler(this.RadioButtonS_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxChocoOffset, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(196, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 26);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // TextBoxChocoOffset
            // 
            this.TextBoxChocoOffset.Location = new System.Drawing.Point(78, 3);
            this.TextBoxChocoOffset.Name = "TextBoxChocoOffset";
            this.TextBoxChocoOffset.Size = new System.Drawing.Size(114, 20);
            this.TextBoxChocoOffset.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Offset";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckBoxSneakAttack
            // 
            this.CheckBoxSneakAttack.AutoSize = true;
            this.CheckBoxSneakAttack.Checked = true;
            this.CheckBoxSneakAttack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSneakAttack.Location = new System.Drawing.Point(274, 66);
            this.CheckBoxSneakAttack.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxSneakAttack.Name = "CheckBoxSneakAttack";
            this.CheckBoxSneakAttack.Size = new System.Drawing.Size(91, 17);
            this.CheckBoxSneakAttack.TabIndex = 7;
            this.CheckBoxSneakAttack.Text = "Sneak Attack";
            this.CheckBoxSneakAttack.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(274, 87);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Enemy Away";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageFixedOffset);
            this.TabControl.Controls.Add(this.TabPageVariableOffset);
            this.TabControl.Controls.Add(this.TabPageChocobo);
            this.TabControl.Location = new System.Drawing.Point(-3, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(536, 250);
            this.TabControl.TabIndex = 34;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(12, 113);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(121, 25);
            this.ButtonSettings.TabIndex = 30;
            this.ButtonSettings.TabStop = false;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(12, 85);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(121, 25);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.TabStop = false;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(12, 57);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(121, 25);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.TabStop = false;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimer.Location = new System.Drawing.Point(5, 4);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(117, 42);
            this.LabelTimer.TabIndex = 0;
            this.LabelTimer.Text = "0.000";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(274, 109);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 9;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 228);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "FlowTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabPageVariableOffset.ResumeLayout(false);
            this.TabPageVariableOffset.PerformLayout();
            this.TabPageFixedOffset.ResumeLayout(false);
            this.TabPageFixedOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPin)).EndInit();
            this.TabPageChocobo.ResumeLayout(false);
            this.TabPageChocobo.PerformLayout();
            this.GroupBoxRadioButtons.ResumeLayout(false);
            this.GroupBoxRadioButtons.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage TabPageVariableOffset;
        public System.Windows.Forms.Button ButtonUndo;
        public System.Windows.Forms.Button ButtonMinus;
        public System.Windows.Forms.Button ButtonPlus;
        public System.Windows.Forms.ComboBox ComboBoxFPS;
        public System.Windows.Forms.Button ButtonSubmit;
        public System.Windows.Forms.Label LabelBeeps2;
        public System.Windows.Forms.TextBox TextBoxBeeps;
        public System.Windows.Forms.TextBox TextBoxInterval;
        public System.Windows.Forms.TextBox TextBoxOffset;
        public System.Windows.Forms.TextBox TextBoxFrame;
        public System.Windows.Forms.Label LabelInterval2;
        public System.Windows.Forms.Label LabelOffset2;
        public System.Windows.Forms.Label LabelFPS;
        public System.Windows.Forms.Label LabelFrame;
        public System.Windows.Forms.TabPage TabPageFixedOffset;
        public System.Windows.Forms.Button ButtonAdd;
        public System.Windows.Forms.PictureBox PictureBoxPin;
        public System.Windows.Forms.Label LabelBeeps;
        public System.Windows.Forms.Label LabelInterval;
        public System.Windows.Forms.Button ButtonSaveTimers;
        public System.Windows.Forms.Label LabelOffset;
        public System.Windows.Forms.Label LabelName;
        public System.Windows.Forms.Button ButtonLoadTimers;
        public System.Windows.Forms.TabPage TabPageChocobo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CheckBoxSneakAttack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TextBoxChocoOffset;
        public System.Windows.Forms.GroupBox GroupBoxRadioButtons;
        public System.Windows.Forms.RadioButton RadioButtonS;
        public System.Windows.Forms.RadioButton RadioButtonA;
        public System.Windows.Forms.RadioButton RadioButtonB;
        public System.Windows.Forms.RadioButton RadioButtonC;
        public System.Windows.Forms.Label LabelStatus;
        public System.Windows.Forms.TabControl TabControl;
        public System.Windows.Forms.Label LabelTimer;
        public System.Windows.Forms.Button ButtonStart;
        public System.Windows.Forms.Button ButtonStop;
        public System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonReset;
    }
}
