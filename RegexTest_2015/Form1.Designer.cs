namespace RegexTest_2015
    {
    partial class Form1
        {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TEST = new System.Windows.Forms.TabPage();
            this.BTN_English = new System.Windows.Forms.Button();
            this.BTN_Spanish = new System.Windows.Forms.Button();
            this.COINCIDEN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MENSAJES = new System.Windows.Forms.TextBox();
            this.CadenaReemplazada = new System.Windows.Forms.TextBox();
            this.ReemplazarPor = new System.Windows.Forms.TextBox();
            this.LBL_Pattern = new System.Windows.Forms.Label();
            this.LBL_ReplaceBy = new System.Windows.Forms.Label();
            this.LBL_ReplacedString = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_Coincidences = new System.Windows.Forms.Label();
            this.LBL_EvaluationString = new System.Windows.Forms.Label();
            this.LBL_Messages = new System.Windows.Forms.Label();
            this.CADENA = new System.Windows.Forms.TextBox();
            this.SPLIT = new System.Windows.Forms.Button();
            this.Reemplazar = new System.Windows.Forms.Button();
            this.BTN_StringTest = new System.Windows.Forms.Button();
            this.PATRON = new System.Windows.Forms.TextBox();
            this.CODIGO = new System.Windows.Forms.TabPage();
            this.BTN_ResetCode = new System.Windows.Forms.Button();
            this.richTextBoxCODIGO = new System.Windows.Forms.RichTextBox();
            this.ASCII = new System.Windows.Forms.TabPage();
            this.TablaASCII = new System.Windows.Forms.RichTextBox();
            this.UTF8 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.TEST.SuspendLayout();
            this.CODIGO.SuspendLayout();
            this.ASCII.SuspendLayout();
            this.UTF8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TEST);
            this.tabControl1.Controls.Add(this.CODIGO);
            this.tabControl1.Controls.Add(this.ASCII);
            this.tabControl1.Controls.Add(this.UTF8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1812, 866);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // TEST
            // 
            this.TEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TEST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TEST.Controls.Add(this.BTN_English);
            this.TEST.Controls.Add(this.BTN_Spanish);
            this.TEST.Controls.Add(this.COINCIDEN);
            this.TEST.Controls.Add(this.button2);
            this.TEST.Controls.Add(this.listBox1);
            this.TEST.Controls.Add(this.MENSAJES);
            this.TEST.Controls.Add(this.CadenaReemplazada);
            this.TEST.Controls.Add(this.ReemplazarPor);
            this.TEST.Controls.Add(this.LBL_Pattern);
            this.TEST.Controls.Add(this.LBL_ReplaceBy);
            this.TEST.Controls.Add(this.LBL_ReplacedString);
            this.TEST.Controls.Add(this.label4);
            this.TEST.Controls.Add(this.LBL_Coincidences);
            this.TEST.Controls.Add(this.LBL_EvaluationString);
            this.TEST.Controls.Add(this.LBL_Messages);
            this.TEST.Controls.Add(this.CADENA);
            this.TEST.Controls.Add(this.SPLIT);
            this.TEST.Controls.Add(this.Reemplazar);
            this.TEST.Controls.Add(this.BTN_StringTest);
            this.TEST.Controls.Add(this.PATRON);
            this.TEST.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TEST.Location = new System.Drawing.Point(4, 42);
            this.TEST.Name = "TEST";
            this.TEST.Padding = new System.Windows.Forms.Padding(3);
            this.TEST.Size = new System.Drawing.Size(1804, 820);
            this.TEST.TabIndex = 0;
            this.TEST.Text = "Test de Cadenas";
            // 
            // BTN_English
            // 
            this.BTN_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_English.ForeColor = System.Drawing.Color.Black;
            this.BTN_English.Location = new System.Drawing.Point(27, 33);
            this.BTN_English.Name = "BTN_English";
            this.BTN_English.Size = new System.Drawing.Size(145, 64);
            this.BTN_English.TabIndex = 1;
            this.BTN_English.Text = "English";
            this.BTN_English.UseVisualStyleBackColor = true;
            this.BTN_English.Click += new System.EventHandler(this.BTN_English_Click);
            // 
            // BTN_Spanish
            // 
            this.BTN_Spanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Spanish.ForeColor = System.Drawing.Color.Black;
            this.BTN_Spanish.Location = new System.Drawing.Point(207, 33);
            this.BTN_Spanish.Name = "BTN_Spanish";
            this.BTN_Spanish.Size = new System.Drawing.Size(139, 64);
            this.BTN_Spanish.TabIndex = 1;
            this.BTN_Spanish.Text = "Spanish";
            this.BTN_Spanish.UseVisualStyleBackColor = true;
            this.BTN_Spanish.Click += new System.EventHandler(this.BTN_Spanish_Click);
            // 
            // COINCIDEN
            // 
            this.COINCIDEN.BackColor = System.Drawing.Color.Ivory;
            this.COINCIDEN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COINCIDEN.Location = new System.Drawing.Point(1482, 69);
            this.COINCIDEN.Name = "COINCIDEN";
            this.COINCIDEN.Size = new System.Drawing.Size(51, 40);
            this.COINCIDEN.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(1739, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 33);
            this.button2.TabIndex = 26;
            this.toolTip1.SetToolTip(this.button2, "Programado por:\r\nHector Fortun");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Ivory;
            this.listBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(963, 183);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(813, 80);
            this.listBox1.TabIndex = 24;
            // 
            // MENSAJES
            // 
            this.MENSAJES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MENSAJES.Location = new System.Drawing.Point(20, 552);
            this.MENSAJES.Multiline = true;
            this.MENSAJES.Name = "MENSAJES";
            this.MENSAJES.ReadOnly = true;
            this.MENSAJES.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MENSAJES.Size = new System.Drawing.Size(910, 120);
            this.MENSAJES.TabIndex = 25;
            // 
            // CadenaReemplazada
            // 
            this.CadenaReemplazada.BackColor = System.Drawing.Color.Ivory;
            this.CadenaReemplazada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadenaReemplazada.Location = new System.Drawing.Point(963, 549);
            this.CadenaReemplazada.Multiline = true;
            this.CadenaReemplazada.Name = "CadenaReemplazada";
            this.CadenaReemplazada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CadenaReemplazada.Size = new System.Drawing.Size(813, 120);
            this.CadenaReemplazada.TabIndex = 18;
            // 
            // ReemplazarPor
            // 
            this.ReemplazarPor.BackColor = System.Drawing.Color.Ivory;
            this.ReemplazarPor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReemplazarPor.Location = new System.Drawing.Point(963, 367);
            this.ReemplazarPor.Multiline = true;
            this.ReemplazarPor.Name = "ReemplazarPor";
            this.ReemplazarPor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReemplazarPor.Size = new System.Drawing.Size(813, 103);
            this.ReemplazarPor.TabIndex = 19;
            // 
            // LBL_Pattern
            // 
            this.LBL_Pattern.AutoSize = true;
            this.LBL_Pattern.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Pattern.ForeColor = System.Drawing.Color.White;
            this.LBL_Pattern.Location = new System.Drawing.Point(20, 121);
            this.LBL_Pattern.Name = "LBL_Pattern";
            this.LBL_Pattern.Size = new System.Drawing.Size(350, 40);
            this.LBL_Pattern.TabIndex = 32;
            this.LBL_Pattern.Text = "Patrón de Validación";
            // 
            // LBL_ReplaceBy
            // 
            this.LBL_ReplaceBy.AutoSize = true;
            this.LBL_ReplaceBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ReplaceBy.ForeColor = System.Drawing.Color.White;
            this.LBL_ReplaceBy.Location = new System.Drawing.Point(956, 324);
            this.LBL_ReplaceBy.Name = "LBL_ReplaceBy";
            this.LBL_ReplaceBy.Size = new System.Drawing.Size(286, 40);
            this.LBL_ReplaceBy.TabIndex = 31;
            this.LBL_ReplaceBy.Text = "Reemplazar por:";
            // 
            // LBL_ReplacedString
            // 
            this.LBL_ReplacedString.AutoSize = true;
            this.LBL_ReplacedString.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ReplacedString.ForeColor = System.Drawing.Color.White;
            this.LBL_ReplacedString.Location = new System.Drawing.Point(956, 506);
            this.LBL_ReplacedString.Name = "LBL_ReplacedString";
            this.LBL_ReplacedString.Size = new System.Drawing.Size(379, 40);
            this.LBL_ReplacedString.TabIndex = 28;
            this.LBL_ReplacedString.Text = "Cadena Reemplazada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(956, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 40);
            this.label4.TabIndex = 30;
            this.label4.Text = "Matches";
            // 
            // LBL_Coincidences
            // 
            this.LBL_Coincidences.AutoSize = true;
            this.LBL_Coincidences.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Coincidences.ForeColor = System.Drawing.Color.White;
            this.LBL_Coincidences.Location = new System.Drawing.Point(1391, 26);
            this.LBL_Coincidences.Name = "LBL_Coincidences";
            this.LBL_Coincidences.Size = new System.Drawing.Size(246, 40);
            this.LBL_Coincidences.TabIndex = 29;
            this.LBL_Coincidences.Text = "Coincidencias";
            // 
            // LBL_EvaluationString
            // 
            this.LBL_EvaluationString.AutoSize = true;
            this.LBL_EvaluationString.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EvaluationString.ForeColor = System.Drawing.Color.White;
            this.LBL_EvaluationString.Location = new System.Drawing.Point(20, 324);
            this.LBL_EvaluationString.Name = "LBL_EvaluationString";
            this.LBL_EvaluationString.Size = new System.Drawing.Size(309, 40);
            this.LBL_EvaluationString.TabIndex = 33;
            this.LBL_EvaluationString.Text = "Cadena a Evaluar ";
            // 
            // LBL_Messages
            // 
            this.LBL_Messages.AutoSize = true;
            this.LBL_Messages.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Messages.ForeColor = System.Drawing.Color.White;
            this.LBL_Messages.Location = new System.Drawing.Point(20, 506);
            this.LBL_Messages.Name = "LBL_Messages";
            this.LBL_Messages.Size = new System.Drawing.Size(205, 40);
            this.LBL_Messages.TabIndex = 27;
            this.LBL_Messages.Text = "MENSAJES";
            // 
            // CADENA
            // 
            this.CADENA.BackColor = System.Drawing.Color.Ivory;
            this.CADENA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADENA.Location = new System.Drawing.Point(20, 367);
            this.CADENA.Multiline = true;
            this.CADENA.Name = "CADENA";
            this.CADENA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CADENA.Size = new System.Drawing.Size(910, 103);
            this.CADENA.TabIndex = 20;
            // 
            // SPLIT
            // 
            this.SPLIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SPLIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SPLIT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SPLIT.FlatAppearance.BorderSize = 4;
            this.SPLIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SPLIT.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPLIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SPLIT.Location = new System.Drawing.Point(1454, 711);
            this.SPLIT.Name = "SPLIT";
            this.SPLIT.Size = new System.Drawing.Size(174, 69);
            this.SPLIT.TabIndex = 22;
            this.SPLIT.Text = "SPLIT";
            this.SPLIT.UseVisualStyleBackColor = false;
            this.SPLIT.Click += new System.EventHandler(this.SPLIT_Click);
            // 
            // Reemplazar
            // 
            this.Reemplazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reemplazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reemplazar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Reemplazar.FlatAppearance.BorderSize = 4;
            this.Reemplazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reemplazar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reemplazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Reemplazar.Location = new System.Drawing.Point(1119, 711);
            this.Reemplazar.Name = "Reemplazar";
            this.Reemplazar.Size = new System.Drawing.Size(228, 69);
            this.Reemplazar.TabIndex = 21;
            this.Reemplazar.Text = "REPLACE";
            this.Reemplazar.UseVisualStyleBackColor = false;
            this.Reemplazar.Click += new System.EventHandler(this.Reemplazar_Click);
            // 
            // BTN_StringTest
            // 
            this.BTN_StringTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_StringTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_StringTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_StringTest.FlatAppearance.BorderSize = 4;
            this.BTN_StringTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_StringTest.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_StringTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_StringTest.Location = new System.Drawing.Point(220, 711);
            this.BTN_StringTest.Name = "BTN_StringTest";
            this.BTN_StringTest.Size = new System.Drawing.Size(460, 69);
            this.BTN_StringTest.TabIndex = 23;
            this.BTN_StringTest.Text = "TEST";
            this.BTN_StringTest.UseVisualStyleBackColor = false;
            this.BTN_StringTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // PATRON
            // 
            this.PATRON.BackColor = System.Drawing.Color.Ivory;
            this.PATRON.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PATRON.Location = new System.Drawing.Point(20, 173);
            this.PATRON.Multiline = true;
            this.PATRON.Name = "PATRON";
            this.PATRON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PATRON.Size = new System.Drawing.Size(910, 105);
            this.PATRON.TabIndex = 17;
            // 
            // CODIGO
            // 
            this.CODIGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CODIGO.Controls.Add(this.BTN_ResetCode);
            this.CODIGO.Controls.Add(this.richTextBoxCODIGO);
            this.CODIGO.Location = new System.Drawing.Point(4, 42);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Padding = new System.Windows.Forms.Padding(3);
            this.CODIGO.Size = new System.Drawing.Size(1804, 820);
            this.CODIGO.TabIndex = 1;
            this.CODIGO.Text = "Código C# Generado";
            // 
            // BTN_ResetCode
            // 
            this.BTN_ResetCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ResetCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ResetCode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_ResetCode.FlatAppearance.BorderSize = 4;
            this.BTN_ResetCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ResetCode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ResetCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_ResetCode.Location = new System.Drawing.Point(767, 696);
            this.BTN_ResetCode.Name = "BTN_ResetCode";
            this.BTN_ResetCode.Size = new System.Drawing.Size(285, 92);
            this.BTN_ResetCode.TabIndex = 6;
            this.BTN_ResetCode.Text = "RESET CODE";
            this.BTN_ResetCode.UseVisualStyleBackColor = false;
            this.BTN_ResetCode.Click += new System.EventHandler(this.BTN_ResetCode_Click);
            // 
            // richTextBoxCODIGO
            // 
            this.richTextBoxCODIGO.BackColor = System.Drawing.Color.LightYellow;
            this.richTextBoxCODIGO.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCODIGO.Location = new System.Drawing.Point(6, 8);
            this.richTextBoxCODIGO.Name = "richTextBoxCODIGO";
            this.richTextBoxCODIGO.Size = new System.Drawing.Size(1790, 665);
            this.richTextBoxCODIGO.TabIndex = 5;
            this.richTextBoxCODIGO.Text = "";
            // 
            // ASCII
            // 
            this.ASCII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ASCII.Controls.Add(this.TablaASCII);
            this.ASCII.Location = new System.Drawing.Point(4, 42);
            this.ASCII.Name = "ASCII";
            this.ASCII.Padding = new System.Windows.Forms.Padding(3);
            this.ASCII.Size = new System.Drawing.Size(1804, 820);
            this.ASCII.TabIndex = 2;
            this.ASCII.Text = "ASCII";
            // 
            // TablaASCII
            // 
            this.TablaASCII.BackColor = System.Drawing.Color.LightYellow;
            this.TablaASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaASCII.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablaASCII.Location = new System.Drawing.Point(3, 3);
            this.TablaASCII.Name = "TablaASCII";
            this.TablaASCII.ReadOnly = true;
            this.TablaASCII.Size = new System.Drawing.Size(1798, 814);
            this.TablaASCII.TabIndex = 2;
            this.TablaASCII.Text = resources.GetString("TablaASCII.Text");
            // 
            // UTF8
            // 
            this.UTF8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UTF8.Controls.Add(this.richTextBox2);
            this.UTF8.Location = new System.Drawing.Point(4, 42);
            this.UTF8.Name = "UTF8";
            this.UTF8.Padding = new System.Windows.Forms.Padding(3);
            this.UTF8.Size = new System.Drawing.Size(1804, 820);
            this.UTF8.TabIndex = 3;
            this.UTF8.Text = "UTF-8";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(1798, 814);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1812, 866);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegexTestHF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TEST.ResumeLayout(false);
            this.TEST.PerformLayout();
            this.CODIGO.ResumeLayout(false);
            this.ASCII.ResumeLayout(false);
            this.UTF8.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TEST;
        private System.Windows.Forms.TabPage CODIGO;
        private System.Windows.Forms.TabPage ASCII;
        private System.Windows.Forms.TabPage UTF8;
        private System.Windows.Forms.TextBox COINCIDEN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox MENSAJES;
        private System.Windows.Forms.TextBox CadenaReemplazada;
        private System.Windows.Forms.TextBox ReemplazarPor;
        private System.Windows.Forms.Label LBL_Pattern;
        private System.Windows.Forms.Label LBL_ReplaceBy;
        private System.Windows.Forms.Label LBL_ReplacedString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_Coincidences;
        private System.Windows.Forms.Label LBL_EvaluationString;
        private System.Windows.Forms.Label LBL_Messages;
        private System.Windows.Forms.TextBox CADENA;
        private System.Windows.Forms.Button SPLIT;
        private System.Windows.Forms.Button Reemplazar;
        private System.Windows.Forms.Button BTN_StringTest;
        private System.Windows.Forms.TextBox PATRON;
        private System.Windows.Forms.Button BTN_ResetCode;
        private System.Windows.Forms.RichTextBox richTextBoxCODIGO;
        private System.Windows.Forms.RichTextBox TablaASCII;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTN_English;
        private System.Windows.Forms.Button BTN_Spanish;
        }
    }

