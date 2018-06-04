namespace TomaszDyskoLab3Zad
{
    partial class FormMusic
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
            this.buttonAddMusic = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDeleteActive = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.dataGridViewMusic = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusic)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddMusic
            // 
            this.buttonAddMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddMusic.Location = new System.Drawing.Point(265, 117);
            this.buttonAddMusic.Name = "buttonAddMusic";
            this.buttonAddMusic.Size = new System.Drawing.Size(104, 34);
            this.buttonAddMusic.TabIndex = 8;
            this.buttonAddMusic.Text = "Dodaj";
            this.buttonAddMusic.UseVisualStyleBackColor = true;
            this.buttonAddMusic.Click += new System.EventHandler(this.buttonAddMusic_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(6, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(6, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(363, 24);
            this.textBoxName.TabIndex = 0;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDeleteActive);
            this.groupBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDelete.Location = new System.Drawing.Point(15, 441);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(375, 81);
            this.groupBoxDelete.TabIndex = 15;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Usuń";
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
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(664, 441);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 40);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.labelLink);
            this.groupBoxAdd.Controls.Add(this.textBoxLink);
            this.groupBoxAdd.Controls.Add(this.buttonAddMusic);
            this.groupBoxAdd.Controls.Add(this.labelName);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAdd.Location = new System.Drawing.Point(15, 274);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(375, 161);
            this.groupBoxAdd.TabIndex = 14;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Dodaj:";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLink.Location = new System.Drawing.Point(6, 68);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(35, 16);
            this.labelLink.TabIndex = 10;
            this.labelLink.Text = "Link:";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLink.Location = new System.Drawing.Point(6, 87);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(363, 24);
            this.textBoxLink.TabIndex = 9;
            // 
            // dataGridViewMusic
            // 
            this.dataGridViewMusic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusic.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewMusic.Name = "dataGridViewMusic";
            this.dataGridViewMusic.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewMusic.TabIndex = 13;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonReset);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelSearchName);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchName);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxSearch.Location = new System.Drawing.Point(396, 286);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(380, 118);
            this.groupBoxSearch.TabIndex = 18;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Szukaj:";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(168, 76);
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
            this.buttonSearch.Location = new System.Drawing.Point(268, 75);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 32);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(7, 22);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(72, 16);
            this.labelSearchName.TabIndex = 10;
            this.labelSearchName.Text = "Po nazwie:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchName.Location = new System.Drawing.Point(6, 41);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(356, 24);
            this.textBoxSearchName.TabIndex = 9;
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridViewMusic);
            this.Name = "FormMusic";
            this.Text = "Music";
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusic)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddMusic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDeleteActive;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.DataGridView dataGridViewMusic;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.TextBox textBoxLink;
    }
}