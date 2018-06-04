namespace TomaszDyskoLab3Zad
{
    partial class FormCloakRoom
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
            this.labelCloakroom = new System.Windows.Forms.Label();
            this.dataGridViewCloakroom = new System.Windows.Forms.DataGridView();
            this.buttonDeleteActiveNumber = new System.Windows.Forms.Button();
            this.buttonAddNumberToActive = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxCloaks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCloakroom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCloakroom
            // 
            this.labelCloakroom.AutoSize = true;
            this.labelCloakroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCloakroom.Location = new System.Drawing.Point(12, 10);
            this.labelCloakroom.Name = "labelCloakroom";
            this.labelCloakroom.Size = new System.Drawing.Size(70, 20);
            this.labelCloakroom.TabIndex = 0;
            this.labelCloakroom.Text = "Szatnia";
            // 
            // dataGridViewCloakroom
            // 
            this.dataGridViewCloakroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCloakroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCloakroom.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewCloakroom.Name = "dataGridViewCloakroom";
            this.dataGridViewCloakroom.Size = new System.Drawing.Size(776, 322);
            this.dataGridViewCloakroom.TabIndex = 1;
            // 
            // buttonDeleteActiveNumber
            // 
            this.buttonDeleteActiveNumber.Location = new System.Drawing.Point(16, 375);
            this.buttonDeleteActiveNumber.Name = "buttonDeleteActiveNumber";
            this.buttonDeleteActiveNumber.Size = new System.Drawing.Size(207, 40);
            this.buttonDeleteActiveNumber.TabIndex = 2;
            this.buttonDeleteActiveNumber.Text = "Usuń powiązanie aktywnemu wierszowi";
            this.buttonDeleteActiveNumber.UseVisualStyleBackColor = true;
            this.buttonDeleteActiveNumber.Click += new System.EventHandler(this.buttonDeleteActiveNumber_Click);
            // 
            // buttonAddNumberToActive
            // 
            this.buttonAddNumberToActive.Location = new System.Drawing.Point(329, 375);
            this.buttonAddNumberToActive.Name = "buttonAddNumberToActive";
            this.buttonAddNumberToActive.Size = new System.Drawing.Size(222, 40);
            this.buttonAddNumberToActive.TabIndex = 3;
            this.buttonAddNumberToActive.Text = "Dodaj numer aktywnemu wierszowi";
            this.buttonAddNumberToActive.UseVisualStyleBackColor = true;
            this.buttonAddNumberToActive.Click += new System.EventHandler(this.buttonAddNumberToActive_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(566, 375);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(222, 40);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxCloaks
            // 
            this.comboBoxCloaks.FormattingEnabled = true;
            this.comboBoxCloaks.Location = new System.Drawing.Point(244, 386);
            this.comboBoxCloaks.Name = "comboBoxCloaks";
            this.comboBoxCloaks.Size = new System.Drawing.Size(79, 21);
            this.comboBoxCloaks.TabIndex = 10;
            // 
            // FormCloakRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.comboBoxCloaks);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddNumberToActive);
            this.Controls.Add(this.buttonDeleteActiveNumber);
            this.Controls.Add(this.dataGridViewCloakroom);
            this.Controls.Add(this.labelCloakroom);
            this.Name = "FormCloakRoom";
            this.Text = "FormCloakRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCloakroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCloakroom;
        private System.Windows.Forms.DataGridView dataGridViewCloakroom;
        private System.Windows.Forms.Button buttonDeleteActiveNumber;
        private System.Windows.Forms.Button buttonAddNumberToActive;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxCloaks;
    }
}