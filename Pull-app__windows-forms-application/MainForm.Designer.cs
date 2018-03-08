namespace Pull_app__windows_forms_application
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label januariLabel;
            System.Windows.Forms.Label februariLabel;
            System.Windows.Forms.Label marsLabel;
            System.Windows.Forms.Label aprilLabel;
            System.Windows.Forms.Label majLabel;
            System.Windows.Forms.Label juniLabel;
            System.Windows.Forms.Label juliLabel;
            System.Windows.Forms.Label augustiLabel;
            System.Windows.Forms.Label septemberLabel;
            System.Windows.Forms.Label oktoberLabel;
            System.Windows.Forms.Label novemberLabel;
            System.Windows.Forms.Label decemberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.minusOne = new System.Windows.Forms.Button();
            this.plusOne = new System.Windows.Forms.Button();
            this.addFreely = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addFreelyNr = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.repsTextBox = new System.Windows.Forms.TextBox();
            this._bndPullappList = new System.Windows.Forms.BindingSource(this.components);
            this._pullappDataSet = new Pull_app__windows_forms_application._Pull_app_DBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.addedToday = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.januariTextBox = new System.Windows.Forms.TextBox();
            this.februariTextBox = new System.Windows.Forms.TextBox();
            this._taPullapp = new Pull_app__windows_forms_application._Pull_app_DBDataSetTableAdapters.RepsTableTableAdapter();
            this._taPullappAdapterManager = new Pull_app__windows_forms_application._Pull_app_DBDataSetTableAdapters.TableAdapterManager();
            this._Pull_app_DBDataSet1 = new Pull_app__windows_forms_application._Pull_app_DBDataSet();
            this.repsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marsTextBox = new System.Windows.Forms.TextBox();
            this.aprilTextBox = new System.Windows.Forms.TextBox();
            this.majTextBox = new System.Windows.Forms.TextBox();
            this.juniTextBox = new System.Windows.Forms.TextBox();
            this.juliTextBox = new System.Windows.Forms.TextBox();
            this.augustiTextBox = new System.Windows.Forms.TextBox();
            this.septemberTextBox = new System.Windows.Forms.TextBox();
            this.oktoberTextBox = new System.Windows.Forms.TextBox();
            this.novemberTextBox = new System.Windows.Forms.TextBox();
            this.decemberTextBox = new System.Windows.Forms.TextBox();
            januariLabel = new System.Windows.Forms.Label();
            februariLabel = new System.Windows.Forms.Label();
            marsLabel = new System.Windows.Forms.Label();
            aprilLabel = new System.Windows.Forms.Label();
            majLabel = new System.Windows.Forms.Label();
            juniLabel = new System.Windows.Forms.Label();
            juliLabel = new System.Windows.Forms.Label();
            augustiLabel = new System.Windows.Forms.Label();
            septemberLabel = new System.Windows.Forms.Label();
            oktoberLabel = new System.Windows.Forms.Label();
            novemberLabel = new System.Windows.Forms.Label();
            decemberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addFreelyNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndPullappList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pullappDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Pull_app_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // januariLabel
            // 
            januariLabel.AutoSize = true;
            januariLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            januariLabel.ForeColor = System.Drawing.Color.Gray;
            januariLabel.Location = new System.Drawing.Point(400, 62);
            januariLabel.Name = "januariLabel";
            januariLabel.Size = new System.Drawing.Size(66, 23);
            januariLabel.TabIndex = 18;
            januariLabel.Text = "januari:";
            // 
            // februariLabel
            // 
            februariLabel.AutoSize = true;
            februariLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            februariLabel.ForeColor = System.Drawing.Color.Gray;
            februariLabel.Location = new System.Drawing.Point(383, 94);
            februariLabel.Name = "februariLabel";
            februariLabel.Size = new System.Drawing.Size(78, 23);
            februariLabel.TabIndex = 19;
            februariLabel.Text = "februari:";
            // 
            // marsLabel
            // 
            marsLabel.AutoSize = true;
            marsLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marsLabel.ForeColor = System.Drawing.Color.Gray;
            marsLabel.Location = new System.Drawing.Point(412, 128);
            marsLabel.Name = "marsLabel";
            marsLabel.Size = new System.Drawing.Size(49, 23);
            marsLabel.TabIndex = 20;
            marsLabel.Text = "mars:";
            // 
            // aprilLabel
            // 
            aprilLabel.AutoSize = true;
            aprilLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aprilLabel.ForeColor = System.Drawing.Color.Gray;
            aprilLabel.Location = new System.Drawing.Point(417, 163);
            aprilLabel.Name = "aprilLabel";
            aprilLabel.Size = new System.Drawing.Size(50, 23);
            aprilLabel.TabIndex = 21;
            aprilLabel.Text = "april:";
            // 
            // majLabel
            // 
            majLabel.AutoSize = true;
            majLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            majLabel.ForeColor = System.Drawing.Color.Gray;
            majLabel.Location = new System.Drawing.Point(424, 201);
            majLabel.Name = "majLabel";
            majLabel.Size = new System.Drawing.Size(40, 23);
            majLabel.TabIndex = 22;
            majLabel.Text = "maj:";
            // 
            // juniLabel
            // 
            juniLabel.AutoSize = true;
            juniLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            juniLabel.ForeColor = System.Drawing.Color.Gray;
            juniLabel.Location = new System.Drawing.Point(422, 234);
            juniLabel.Name = "juniLabel";
            juniLabel.Size = new System.Drawing.Size(42, 23);
            juniLabel.TabIndex = 23;
            juniLabel.Text = "juni:";
            // 
            // juliLabel
            // 
            juliLabel.AutoSize = true;
            juliLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            juliLabel.ForeColor = System.Drawing.Color.Gray;
            juliLabel.Location = new System.Drawing.Point(421, 266);
            juliLabel.Name = "juliLabel";
            juliLabel.Size = new System.Drawing.Size(39, 23);
            juliLabel.TabIndex = 24;
            juliLabel.Text = "juli:";
            // 
            // augustiLabel
            // 
            augustiLabel.AutoSize = true;
            augustiLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            augustiLabel.ForeColor = System.Drawing.Color.Gray;
            augustiLabel.Location = new System.Drawing.Point(395, 301);
            augustiLabel.Name = "augustiLabel";
            augustiLabel.Size = new System.Drawing.Size(66, 23);
            augustiLabel.TabIndex = 26;
            augustiLabel.Text = "augusti:";
            // 
            // septemberLabel
            // 
            septemberLabel.AutoSize = true;
            septemberLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            septemberLabel.ForeColor = System.Drawing.Color.Gray;
            septemberLabel.Location = new System.Drawing.Point(372, 340);
            septemberLabel.Name = "septemberLabel";
            septemberLabel.Size = new System.Drawing.Size(91, 23);
            septemberLabel.TabIndex = 28;
            septemberLabel.Text = "september:";
            // 
            // oktoberLabel
            // 
            oktoberLabel.AutoSize = true;
            oktoberLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            oktoberLabel.ForeColor = System.Drawing.Color.Gray;
            oktoberLabel.Location = new System.Drawing.Point(384, 380);
            oktoberLabel.Name = "oktoberLabel";
            oktoberLabel.Size = new System.Drawing.Size(73, 23);
            oktoberLabel.TabIndex = 30;
            oktoberLabel.Text = "oktober:";
            // 
            // novemberLabel
            // 
            novemberLabel.AutoSize = true;
            novemberLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            novemberLabel.ForeColor = System.Drawing.Color.Gray;
            novemberLabel.Location = new System.Drawing.Point(375, 419);
            novemberLabel.Name = "novemberLabel";
            novemberLabel.Size = new System.Drawing.Size(84, 23);
            novemberLabel.TabIndex = 32;
            novemberLabel.Text = "november:";
            // 
            // decemberLabel
            // 
            decemberLabel.AutoSize = true;
            decemberLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            decemberLabel.ForeColor = System.Drawing.Color.Gray;
            decemberLabel.Location = new System.Drawing.Point(377, 455);
            decemberLabel.Name = "decemberLabel";
            decemberLabel.Size = new System.Drawing.Size(85, 23);
            decemberLabel.TabIndex = 34;
            decemberLabel.Text = "december:";
            // 
            // minusOne
            // 
            this.minusOne.BackColor = System.Drawing.Color.Red;
            this.minusOne.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusOne.ForeColor = System.Drawing.Color.White;
            this.minusOne.Location = new System.Drawing.Point(56, 275);
            this.minusOne.Name = "minusOne";
            this.minusOne.Size = new System.Drawing.Size(123, 102);
            this.minusOne.TabIndex = 3;
            this.minusOne.Text = "-1";
            this.minusOne.UseVisualStyleBackColor = false;
            this.minusOne.Click += new System.EventHandler(this.drawOne);
            this.minusOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            // 
            // plusOne
            // 
            this.plusOne.BackColor = System.Drawing.Color.Lime;
            this.plusOne.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOne.ForeColor = System.Drawing.Color.White;
            this.plusOne.Location = new System.Drawing.Point(212, 275);
            this.plusOne.Name = "plusOne";
            this.plusOne.Size = new System.Drawing.Size(123, 102);
            this.plusOne.TabIndex = 4;
            this.plusOne.Text = "+1";
            this.plusOne.UseVisualStyleBackColor = false;
            this.plusOne.Click += new System.EventHandler(this.addOne);
            this.plusOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            // 
            // addFreely
            // 
            this.addFreely.AutoSize = true;
            this.addFreely.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFreely.Location = new System.Drawing.Point(230, 397);
            this.addFreely.Name = "addFreely";
            this.addFreely.Size = new System.Drawing.Size(56, 42);
            this.addFreely.TabIndex = 7;
            this.addFreely.Text = "Add";
            this.addFreely.UseVisualStyleBackColor = true;
            this.addFreely.Click += new System.EventHandler(this.addFreely_clicked);
            this.addFreely.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add freely:";
            // 
            // addFreelyNr
            // 
            this.addFreelyNr.Location = new System.Drawing.Point(168, 406);
            this.addFreelyNr.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.addFreelyNr.Name = "addFreelyNr";
            this.addFreelyNr.Size = new System.Drawing.Size(56, 26);
            this.addFreelyNr.TabIndex = 10;
            this.addFreelyNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timerTick);
            // 
            // pic1
            // 
            this.pic1.ErrorImage = null;
            this.pic1.Image = global::Pull_app__windows_forms_application.Properties.Resources.nere;
            this.pic1.InitialImage = null;
            this.pic1.Location = new System.Drawing.Point(133, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(132, 97);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.vadarenpullup);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(133, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.saveReps);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            // 
            // repsTextBox
            // 
            this.repsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.repsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "Reps", true));
            this.repsTextBox.Enabled = false;
            this.repsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repsTextBox.Location = new System.Drawing.Point(168, 141);
            this.repsTextBox.Name = "repsTextBox";
            this.repsTextBox.Size = new System.Drawing.Size(197, 82);
            this.repsTextBox.TabIndex = 15;
            this.repsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            // 
            // _bndPullappList
            // 
            this._bndPullappList.DataMember = "RepsTable";
            this._bndPullappList.DataSource = this._pullappDataSet;
            // 
            // _pullappDataSet
            // 
            this._pullappDataSet.DataSetName = "_Pull_app_DBDataSet";
            this._pullappDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "(Ctrl + S)";
            // 
            // addedToday
            // 
            this.addedToday.AutoSize = true;
            this.addedToday.Font = new System.Drawing.Font("AR JULIAN", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedToday.ForeColor = System.Drawing.Color.Purple;
            this.addedToday.Location = new System.Drawing.Point(164, 217);
            this.addedToday.Name = "addedToday";
            this.addedToday.Size = new System.Drawing.Size(18, 19);
            this.addedToday.TabIndex = 17;
            this.addedToday.Text = "0";
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic2.InitialImage")));
            this.pic2.Location = new System.Drawing.Point(239, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(84, 53);
            this.pic2.TabIndex = 18;
            this.pic2.TabStop = false;
            this.pic2.Visible = false;
            // 
            // januariTextBox
            // 
            this.januariTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.januariTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.januariTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "januari", true));
            this.januariTextBox.ForeColor = System.Drawing.Color.Gray;
            this.januariTextBox.Location = new System.Drawing.Point(472, 64);
            this.januariTextBox.Name = "januariTextBox";
            this.januariTextBox.Size = new System.Drawing.Size(100, 19);
            this.januariTextBox.TabIndex = 19;
            // 
            // februariTextBox
            // 
            this.februariTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.februariTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.februariTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "februari", true));
            this.februariTextBox.ForeColor = System.Drawing.Color.Gray;
            this.februariTextBox.Location = new System.Drawing.Point(467, 94);
            this.februariTextBox.Name = "februariTextBox";
            this.februariTextBox.Size = new System.Drawing.Size(100, 19);
            this.februariTextBox.TabIndex = 20;
            // 
            // _taPullapp
            // 
            this._taPullapp.ClearBeforeFill = true;
            // 
            // _taPullappAdapterManager
            // 
            this._taPullappAdapterManager.BackupDataSetBeforeUpdate = false;
            this._taPullappAdapterManager.RepsTableTableAdapter = this._taPullapp;
            this._taPullappAdapterManager.UpdateOrder = Pull_app__windows_forms_application._Pull_app_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _Pull_app_DBDataSet1
            // 
            this._Pull_app_DBDataSet1.DataSetName = "_Pull_app_DBDataSet";
            this._Pull_app_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repsTableBindingSource
            // 
            this.repsTableBindingSource.DataMember = "RepsTable";
            this.repsTableBindingSource.DataSource = this._Pull_app_DBDataSet1;
            // 
            // marsTextBox
            // 
            this.marsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.marsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.marsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "mars", true));
            this.marsTextBox.ForeColor = System.Drawing.Color.Gray;
            this.marsTextBox.Location = new System.Drawing.Point(467, 128);
            this.marsTextBox.Name = "marsTextBox";
            this.marsTextBox.Size = new System.Drawing.Size(100, 19);
            this.marsTextBox.TabIndex = 21;
            // 
            // aprilTextBox
            // 
            this.aprilTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aprilTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aprilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "april", true));
            this.aprilTextBox.ForeColor = System.Drawing.Color.Gray;
            this.aprilTextBox.Location = new System.Drawing.Point(466, 163);
            this.aprilTextBox.Name = "aprilTextBox";
            this.aprilTextBox.Size = new System.Drawing.Size(100, 19);
            this.aprilTextBox.TabIndex = 22;
            // 
            // majTextBox
            // 
            this.majTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.majTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.majTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "maj", true));
            this.majTextBox.ForeColor = System.Drawing.Color.Gray;
            this.majTextBox.Location = new System.Drawing.Point(469, 201);
            this.majTextBox.Name = "majTextBox";
            this.majTextBox.Size = new System.Drawing.Size(100, 19);
            this.majTextBox.TabIndex = 23;
            // 
            // juniTextBox
            // 
            this.juniTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.juniTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.juniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "juni", true));
            this.juniTextBox.ForeColor = System.Drawing.Color.Gray;
            this.juniTextBox.Location = new System.Drawing.Point(466, 234);
            this.juniTextBox.Name = "juniTextBox";
            this.juniTextBox.Size = new System.Drawing.Size(100, 19);
            this.juniTextBox.TabIndex = 24;
            // 
            // juliTextBox
            // 
            this.juliTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.juliTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.juliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "juli", true));
            this.juliTextBox.ForeColor = System.Drawing.Color.Gray;
            this.juliTextBox.Location = new System.Drawing.Point(459, 266);
            this.juliTextBox.Name = "juliTextBox";
            this.juliTextBox.Size = new System.Drawing.Size(100, 19);
            this.juliTextBox.TabIndex = 25;
            // 
            // augustiTextBox
            // 
            this.augustiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.augustiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.augustiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "augusti", true));
            this.augustiTextBox.ForeColor = System.Drawing.Color.Gray;
            this.augustiTextBox.Location = new System.Drawing.Point(467, 301);
            this.augustiTextBox.Name = "augustiTextBox";
            this.augustiTextBox.Size = new System.Drawing.Size(100, 19);
            this.augustiTextBox.TabIndex = 27;
            // 
            // septemberTextBox
            // 
            this.septemberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.septemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.septemberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "september", true));
            this.septemberTextBox.ForeColor = System.Drawing.Color.Gray;
            this.septemberTextBox.Location = new System.Drawing.Point(468, 340);
            this.septemberTextBox.Name = "septemberTextBox";
            this.septemberTextBox.Size = new System.Drawing.Size(100, 19);
            this.septemberTextBox.TabIndex = 29;
            // 
            // oktoberTextBox
            // 
            this.oktoberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.oktoberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oktoberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "oktober", true));
            this.oktoberTextBox.ForeColor = System.Drawing.Color.Gray;
            this.oktoberTextBox.Location = new System.Drawing.Point(458, 380);
            this.oktoberTextBox.Name = "oktoberTextBox";
            this.oktoberTextBox.Size = new System.Drawing.Size(100, 19);
            this.oktoberTextBox.TabIndex = 31;
            // 
            // novemberTextBox
            // 
            this.novemberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.novemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.novemberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "november", true));
            this.novemberTextBox.ForeColor = System.Drawing.Color.Gray;
            this.novemberTextBox.Location = new System.Drawing.Point(465, 419);
            this.novemberTextBox.Name = "novemberTextBox";
            this.novemberTextBox.Size = new System.Drawing.Size(100, 19);
            this.novemberTextBox.TabIndex = 33;
            // 
            // decemberTextBox
            // 
            this.decemberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.decemberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decemberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndPullappList, "december", true));
            this.decemberTextBox.ForeColor = System.Drawing.Color.Gray;
            this.decemberTextBox.Location = new System.Drawing.Point(468, 455);
            this.decemberTextBox.Name = "decemberTextBox";
            this.decemberTextBox.Size = new System.Drawing.Size(100, 19);
            this.decemberTextBox.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(541, 567);
            this.Controls.Add(decemberLabel);
            this.Controls.Add(this.decemberTextBox);
            this.Controls.Add(novemberLabel);
            this.Controls.Add(this.novemberTextBox);
            this.Controls.Add(oktoberLabel);
            this.Controls.Add(this.oktoberTextBox);
            this.Controls.Add(septemberLabel);
            this.Controls.Add(this.septemberTextBox);
            this.Controls.Add(augustiLabel);
            this.Controls.Add(this.augustiTextBox);
            this.Controls.Add(juliLabel);
            this.Controls.Add(this.juliTextBox);
            this.Controls.Add(juniLabel);
            this.Controls.Add(this.juniTextBox);
            this.Controls.Add(majLabel);
            this.Controls.Add(this.majTextBox);
            this.Controls.Add(aprilLabel);
            this.Controls.Add(this.aprilTextBox);
            this.Controls.Add(marsLabel);
            this.Controls.Add(this.marsTextBox);
            this.Controls.Add(februariLabel);
            this.Controls.Add(this.februariTextBox);
            this.Controls.Add(januariLabel);
            this.Controls.Add(this.januariTextBox);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.addedToday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repsTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addFreelyNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFreely);
            this.Controls.Add(this.plusOne);
            this.Controls.Add(this.minusOne);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pull-app";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeySave);
            ((System.ComponentModel.ISupportInitialize)(this.addFreelyNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndPullappList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pullappDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Pull_app_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button minusOne;
        private System.Windows.Forms.Button plusOne;
        private System.Windows.Forms.Button addFreely;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown addFreelyNr;
        private System.Windows.Forms.Timer timer1;
        private _Pull_app_DBDataSet _pullappDataSet;
        private System.Windows.Forms.BindingSource _bndPullappList;
        private _Pull_app_DBDataSetTableAdapters.RepsTableTableAdapter _taPullapp;
        private _Pull_app_DBDataSetTableAdapters.TableAdapterManager _taPullappAdapterManager;
        private System.Windows.Forms.Button button1;
        private _Pull_app_DBDataSet _Pull_app_DBDataSet1;
        private System.Windows.Forms.BindingSource repsTableBindingSource;
        private System.Windows.Forms.TextBox repsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addedToday;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.TextBox januariTextBox;
        private System.Windows.Forms.TextBox februariTextBox;
        private System.Windows.Forms.TextBox marsTextBox;
        private System.Windows.Forms.TextBox aprilTextBox;
        private System.Windows.Forms.TextBox majTextBox;
        private System.Windows.Forms.TextBox juniTextBox;
        private System.Windows.Forms.TextBox juliTextBox;
        private System.Windows.Forms.TextBox augustiTextBox;
        private System.Windows.Forms.TextBox septemberTextBox;
        private System.Windows.Forms.TextBox oktoberTextBox;
        private System.Windows.Forms.TextBox novemberTextBox;
        private System.Windows.Forms.TextBox decemberTextBox;
    }
}

