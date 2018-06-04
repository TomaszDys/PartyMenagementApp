namespace TomaszDyskoLab3Zad
{
    partial class FormOrders
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.groupBoxAddOrder = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDeleteActive = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.groupBoxAddOrder.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(267, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(521, 426);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // groupBoxAddOrder
            // 
            this.groupBoxAddOrder.Controls.Add(this.buttonAdd);
            this.groupBoxAddOrder.Controls.Add(this.labelProduct);
            this.groupBoxAddOrder.Controls.Add(this.comboBoxProducts);
            this.groupBoxAddOrder.Controls.Add(this.textBoxNumber);
            this.groupBoxAddOrder.Controls.Add(this.label1);
            this.groupBoxAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAddOrder.Location = new System.Drawing.Point(13, 13);
            this.groupBoxAddOrder.Name = "groupBoxAddOrder";
            this.groupBoxAddOrder.Size = new System.Drawing.Size(248, 183);
            this.groupBoxAddOrder.TabIndex = 1;
            this.groupBoxAddOrder.TabStop = false;
            this.groupBoxAddOrder.Text = "Dodaj";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(141, 141);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 33);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(7, 79);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(108, 16);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "Wybierz produkt:";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(10, 98);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(220, 24);
            this.comboBoxProducts.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(10, 49);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(108, 22);
            this.textBoxNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer Rachunku";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDeleteActive);
            this.groupBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDelete.Location = new System.Drawing.Point(13, 202);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(248, 83);
            this.groupBoxDelete.TabIndex = 2;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Usuń";
            // 
            // buttonDeleteActive
            // 
            this.buttonDeleteActive.Location = new System.Drawing.Point(10, 22);
            this.buttonDeleteActive.Name = "buttonDeleteActive";
            this.buttonDeleteActive.Size = new System.Drawing.Size(220, 45);
            this.buttonDeleteActive.TabIndex = 0;
            this.buttonDeleteActive.Text = "Usuń aktywny wiersz";
            this.buttonDeleteActive.UseVisualStyleBackColor = true;
            this.buttonDeleteActive.Click += new System.EventHandler(this.buttonDeleteActive_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(76, 354);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 40);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxAddOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.groupBoxAddOrder.ResumeLayout(false);
            this.groupBoxAddOrder.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.GroupBox groupBoxAddOrder;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDeleteActive;
        private System.Windows.Forms.Button buttonBack;
    }
}