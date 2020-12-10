namespace ToodeDB
{
    partial class Pood
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
            this.Toodetxt = new System.Windows.Forms.TextBox();
            this.Kogustxt = new System.Windows.Forms.TextBox();
            this.Hindtxt = new System.Windows.Forms.TextBox();
            this.Toode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tootetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new ToodeDB.Database1DataSet();
            this.tootetableTableAdapter = new ToodeDB.Database1DataSetTableAdapters.TootetableTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LisaPilt = new System.Windows.Forms.Button();
            this.LisaPilttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tootetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toodetxt
            // 
            this.Toodetxt.Location = new System.Drawing.Point(56, 54);
            this.Toodetxt.Name = "Toodetxt";
            this.Toodetxt.Size = new System.Drawing.Size(100, 20);
            this.Toodetxt.TabIndex = 0;
            // 
            // Kogustxt
            // 
            this.Kogustxt.Location = new System.Drawing.Point(56, 119);
            this.Kogustxt.Name = "Kogustxt";
            this.Kogustxt.Size = new System.Drawing.Size(100, 20);
            this.Kogustxt.TabIndex = 1;
            // 
            // Hindtxt
            // 
            this.Hindtxt.Location = new System.Drawing.Point(56, 166);
            this.Hindtxt.Name = "Hindtxt";
            this.Hindtxt.Size = new System.Drawing.Size(100, 20);
            this.Hindtxt.TabIndex = 2;
            // 
            // Toode
            // 
            this.Toode.AutoSize = true;
            this.Toode.Location = new System.Drawing.Point(12, 57);
            this.Toode.Name = "Toode";
            this.Toode.Size = new System.Drawing.Size(38, 13);
            this.Toode.TabIndex = 3;
            this.Toode.Text = "Toode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hind";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(70, 267);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(96, 30);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "Lias uus";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(70, 327);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 30);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Uuenda";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(70, 386);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 30);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Kustuta";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 215);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tootetableBindingSource
            // 
            this.tootetableBindingSource.DataMember = "Tootetable";
            this.tootetableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tootetableTableAdapter
            // 
            this.tootetableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(572, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 167);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LisaPilt
            // 
            this.btn_LisaPilt.Location = new System.Drawing.Point(440, 346);
            this.btn_LisaPilt.Name = "btn_LisaPilt";
            this.btn_LisaPilt.Size = new System.Drawing.Size(96, 30);
            this.btn_LisaPilt.TabIndex = 11;
            this.btn_LisaPilt.Text = "Lisa Pilt";
            this.btn_LisaPilt.UseVisualStyleBackColor = true;
            this.btn_LisaPilt.Click += new System.EventHandler(this.btn_LisaPilt_Click);
            // 
            // LisaPilttxt
            // 
            this.LisaPilttxt.Location = new System.Drawing.Point(440, 298);
            this.LisaPilttxt.Name = "LisaPilttxt";
            this.LisaPilttxt.Size = new System.Drawing.Size(100, 20);
            this.LisaPilttxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lisa Pilt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kategooria";
            // 
            // Pood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LisaPilttxt);
            this.Controls.Add(this.btn_LisaPilt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Toode);
            this.Controls.Add(this.Hindtxt);
            this.Controls.Add(this.Kogustxt);
            this.Controls.Add(this.Toodetxt);
            this.Name = "Pood";
            this.Text = "Pood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tootetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toodetxt;
        private System.Windows.Forms.TextBox Kogustxt;
        private System.Windows.Forms.TextBox Hindtxt;
        private System.Windows.Forms.Label Toode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tootetableBindingSource;
        private Database1DataSetTableAdapters.TootetableTableAdapter tootetableTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LisaPilt;
        private System.Windows.Forms.TextBox LisaPilttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

