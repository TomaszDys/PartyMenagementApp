namespace TomaszDyskoLab3Zad
{
    partial class FormTabels
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
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddNumberToActive = new System.Windows.Forms.Button();
            this.buttonDeleteActiveNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.Size = new System.Drawing.Size(776, 280);
            this.dataGridViewTables.TabIndex = 16;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(241, 328);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(79, 21);
            this.comboBoxTables.TabIndex = 20;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(563, 317);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(222, 40);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddNumberToActive
            // 
            this.buttonAddNumberToActive.Location = new System.Drawing.Point(326, 317);
            this.buttonAddNumberToActive.Name = "buttonAddNumberToActive";
            this.buttonAddNumberToActive.Size = new System.Drawing.Size(222, 40);
            this.buttonAddNumberToActive.TabIndex = 18;
            this.buttonAddNumberToActive.Text = "Dodaj numer aktywnemu wierszowi";
            this.buttonAddNumberToActive.UseVisualStyleBackColor = true;
            this.buttonAddNumberToActive.Click += new System.EventHandler(this.buttonAddNumberToActive_Click);
            // 
            // buttonDeleteActiveNumber
            // 
            this.buttonDeleteActiveNumber.Location = new System.Drawing.Point(13, 317);
            this.buttonDeleteActiveNumber.Name = "buttonDeleteActiveNumber";
            this.buttonDeleteActiveNumber.Size = new System.Drawing.Size(207, 40);
            this.buttonDeleteActiveNumber.TabIndex = 17;
            this.buttonDeleteActiveNumber.Text = "Usuń powiązanie aktywnemu wierszowi";
            this.buttonDeleteActiveNumber.UseVisualStyleBackColor = true;
            this.buttonDeleteActiveNumber.Click += new System.EventHandler(this.buttonDeleteActiveNumber_Click);
            // 
            // FormTabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddNumberToActive);
            this.Controls.Add(this.buttonDeleteActiveNumber);
            this.Controls.Add(this.dataGridViewTables);
            this.Name = "FormTabels";
            this.Text = "Stoliki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddNumberToActive;
        private System.Windows.Forms.Button buttonDeleteActiveNumber;
    }
}