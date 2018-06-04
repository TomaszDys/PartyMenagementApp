namespace TomaszDyskoLab3Zad
{
    partial class FormGuestList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGuestList = new System.Windows.Forms.DataGridView();
            this.labelListOfGuests = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.comboBoxCloaks = new System.Windows.Forms.ComboBox();
            this.buttonAddGuest = new System.Windows.Forms.Button();
            this.labelCloakNumber = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDeleteActive = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchSurname = new System.Windows.Forms.Label();
            this.textBoxSearchSurname = new System.Windows.Forms.TextBox();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestList)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGuestList
            // 
            this.dataGridViewGuestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGuestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestList.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewGuestList.Name = "dataGridViewGuestList";
            this.dataGridViewGuestList.Size = new System.Drawing.Size(776, 289);
            this.dataGridViewGuestList.TabIndex = 6;
            // 
            // labelListOfGuests
            // 
            this.labelListOfGuests.AutoSize = true;
            this.labelListOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelListOfGuests.Location = new System.Drawing.Point(14, 8);
            this.labelListOfGuests.Name = "labelListOfGuests";
            this.labelListOfGuests.Size = new System.Drawing.Size(114, 24);
            this.labelListOfGuests.TabIndex = 5;
            this.labelListOfGuests.Text = "Lista gości:";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.comboBoxCloaks);
            this.groupBoxAdd.Controls.Add(this.buttonAddGuest);
            this.groupBoxAdd.Controls.Add(this.labelCloakNumber);
            this.groupBoxAdd.Controls.Add(this.labelSurname);
            this.groupBoxAdd.Controls.Add(this.labelName);
            this.groupBoxAdd.Controls.Add(this.textBoxSurname);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAdd.Location = new System.Drawing.Point(15, 339);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(375, 147);
            this.groupBoxAdd.TabIndex = 7;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Dodaj:";
            // 
            // comboBoxCloaks
            // 
            this.comboBoxCloaks.FormattingEnabled = true;
            this.comboBoxCloaks.Location = new System.Drawing.Point(112, 72);
            this.comboBoxCloaks.Name = "comboBoxCloaks";
            this.comboBoxCloaks.Size = new System.Drawing.Size(79, 24);
            this.comboBoxCloaks.TabIndex = 9;
            // 
            // buttonAddGuest
            // 
            this.buttonAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddGuest.Location = new System.Drawing.Point(265, 107);
            this.buttonAddGuest.Name = "buttonAddGuest";
            this.buttonAddGuest.Size = new System.Drawing.Size(104, 34);
            this.buttonAddGuest.TabIndex = 8;
            this.buttonAddGuest.Text = "Dodaj";
            this.buttonAddGuest.UseVisualStyleBackColor = true;
            this.buttonAddGuest.Click += new System.EventHandler(this.buttonAddGuest_Click);
            // 
            // labelCloakNumber
            // 
            this.labelCloakNumber.AutoSize = true;
            this.labelCloakNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCloakNumber.Location = new System.Drawing.Point(6, 75);
            this.labelCloakNumber.Name = "labelCloakNumber";
            this.labelCloakNumber.Size = new System.Drawing.Size(100, 16);
            this.labelCloakNumber.TabIndex = 7;
            this.labelCloakNumber.Text = "Numer w szatni:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurname.Location = new System.Drawing.Point(197, 22);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 16);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Nazwisko*:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(6, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Imię*:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurname.Location = new System.Drawing.Point(197, 41);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(172, 24);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(6, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 24);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonDeleteActive
            // 
            this.buttonDeleteActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteActive.Location = new System.Drawing.Point(87, 27);
            this.buttonDeleteActive.Name = "buttonDeleteActive";
            this.buttonDeleteActive.Size = new System.Drawing.Size(207, 34);
            this.buttonDeleteActive.TabIndex = 9;
            this.buttonDeleteActive.Text = "Usuń aktywny wiersz";
            this.buttonDeleteActive.UseVisualStyleBackColor = true;
            this.buttonDeleteActive.Click += new System.EventHandler(this.buttonDeleteActive_Click);
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDeleteActive);
            this.groupBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDelete.Location = new System.Drawing.Point(15, 492);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(375, 81);
            this.groupBoxDelete.TabIndex = 10;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Usuń";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(683, 533);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 40);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonReset);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelSearchSurname);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchSurname);
            this.groupBoxSearch.Controls.Add(this.labelSearchName);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchName);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSearch.Location = new System.Drawing.Point(396, 339);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(380, 174);
            this.groupBoxSearch.TabIndex = 11;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Szukaj:";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(168, 128);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 32);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Resetuj";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.Location = new System.Drawing.Point(268, 127);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 32);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchSurname
            // 
            this.labelSearchSurname.AutoSize = true;
            this.labelSearchSurname.Location = new System.Drawing.Point(7, 71);
            this.labelSearchSurname.Name = "labelSearchSurname";
            this.labelSearchSurname.Size = new System.Drawing.Size(85, 16);
            this.labelSearchSurname.TabIndex = 12;
            this.labelSearchSurname.Text = "Po nazwisku:";
            // 
            // textBoxSearchSurname
            // 
            this.textBoxSearchSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchSurname.Location = new System.Drawing.Point(6, 90);
            this.textBoxSearchSurname.Name = "textBoxSearchSurname";
            this.textBoxSearchSurname.Size = new System.Drawing.Size(356, 24);
            this.textBoxSearchSurname.TabIndex = 11;
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(7, 22);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(73, 16);
            this.labelSearchName.TabIndex = 10;
            this.labelSearchName.Text = "Po imieniu:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchName.Location = new System.Drawing.Point(6, 41);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(356, 24);
            this.textBoxSearchName.TabIndex = 9;
            // 
            // FormGuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridViewGuestList);
            this.Controls.Add(this.labelListOfGuests);
            this.Name = "FormGuestList";
            this.Text = "FormGuestList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestList)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGuestList;
        private System.Windows.Forms.Label labelListOfGuests;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddGuest;
        private System.Windows.Forms.Label labelCloakNumber;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDeleteActive;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchSurname;
        private System.Windows.Forms.TextBox textBoxSearchSurname;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.ComboBox comboBoxCloaks;
    }
}