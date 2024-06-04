namespace lab02
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.labelSalary = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.radioButtonContract1 = new System.Windows.Forms.RadioButton();
            this.radioButtonContract2 = new System.Windows.Forms.RadioButton();
            this.radioButtonContract3 = new System.Windows.Forms.RadioButton();
            this.labelContract = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Imię";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(408, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 40);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(65, 16);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Nazwisko";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(116, 36);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(264, 22);
            this.textBoxLastName.TabIndex = 9;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(116, 64);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerBirthday.TabIndex = 10;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(12, 70);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(98, 16);
            this.labelBirthday.TabIndex = 11;
            this.labelBirthday.Text = "Data urodzenia";
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Location = new System.Drawing.Point(116, 93);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(264, 22);
            this.numericUpDownSalary.TabIndex = 12;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(12, 96);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(49, 16);
            this.labelSalary.TabIndex = 13;
            this.labelSalary.Text = "Pensja";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy programista",
            "Starszy programista"});
            this.comboBoxPosition.Location = new System.Drawing.Point(116, 122);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(264, 24);
            this.comboBoxPosition.TabIndex = 14;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(12, 126);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPosition.Size = new System.Drawing.Size(76, 16);
            this.labelPosition.TabIndex = 15;
            this.labelPosition.Text = "Stanowisko";
            // 
            // radioButtonContract1
            // 
            this.radioButtonContract1.AutoSize = true;
            this.radioButtonContract1.Location = new System.Drawing.Point(116, 152);
            this.radioButtonContract1.Name = "radioButtonContract1";
            this.radioButtonContract1.Size = new System.Drawing.Size(200, 20);
            this.radioButtonContract1.TabIndex = 16;
            this.radioButtonContract1.TabStop = true;
            this.radioButtonContract1.Text = "umowa na czas nieokreślony";
            this.radioButtonContract1.UseVisualStyleBackColor = true;
            // 
            // radioButtonContract2
            // 
            this.radioButtonContract2.AutoSize = true;
            this.radioButtonContract2.Location = new System.Drawing.Point(116, 178);
            this.radioButtonContract2.Name = "radioButtonContract2";
            this.radioButtonContract2.Size = new System.Drawing.Size(182, 20);
            this.radioButtonContract2.TabIndex = 17;
            this.radioButtonContract2.TabStop = true;
            this.radioButtonContract2.Text = "umowa na czas określony";
            this.radioButtonContract2.UseVisualStyleBackColor = true;
            // 
            // radioButtonContract3
            // 
            this.radioButtonContract3.AutoSize = true;
            this.radioButtonContract3.Location = new System.Drawing.Point(116, 204);
            this.radioButtonContract3.Name = "radioButtonContract3";
            this.radioButtonContract3.Size = new System.Drawing.Size(124, 20);
            this.radioButtonContract3.TabIndex = 18;
            this.radioButtonContract3.TabStop = true;
            this.radioButtonContract3.Text = "umowa zlecenie";
            this.radioButtonContract3.UseVisualStyleBackColor = true;
            // 
            // labelContract
            // 
            this.labelContract.AutoSize = true;
            this.labelContract.Location = new System.Drawing.Point(12, 155);
            this.labelContract.Name = "labelContract";
            this.labelContract.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelContract.Size = new System.Drawing.Size(53, 16);
            this.labelContract.TabIndex = 19;
            this.labelContract.Text = "Umowa";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(203, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(221, 415);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(199, 23);
            this.buttonLoad.TabIndex = 21;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.HorizontalScrollbar = true;
            this.listBoxWorkers.ItemHeight = 16;
            this.listBoxWorkers.Location = new System.Drawing.Point(426, 8);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(366, 436);
            this.listBoxWorkers.TabIndex = 22;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxWorkers);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelContract);
            this.Controls.Add(this.radioButtonContract3);
            this.Controls.Add(this.radioButtonContract2);
            this.Controls.Add(this.radioButtonContract1);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.Label labelContract;
        private System.Windows.Forms.RadioButton radioButtonContract3;
        private System.Windows.Forms.RadioButton radioButtonContract2;
        private System.Windows.Forms.RadioButton radioButtonContract1;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxWorkers;
    }
}

