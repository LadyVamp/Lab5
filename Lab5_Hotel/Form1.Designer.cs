﻿namespace Lab5_Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbOfhotel = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lR5DataSet = new Lab5_Hotel.LR5DataSet();
            this.clientTableAdapter = new Lab5_Hotel.LR5DataSetTableAdapters.ClientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAllHotels = new System.Windows.Forms.Button();
            this.btnAllClients = new System.Windows.Forms.Button();
            this.btnCreateXml = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.btnAddXmlElement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCityAndCount = new System.Windows.Forms.Button();
            this.btnEditXmlElement = new System.Windows.Forms.Button();
            this.btnDelXmlElement = new System.Windows.Forms.Button();
            this.btnClientsOfAttica = new System.Windows.Forms.Button();
            this.btnDop2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lR5DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(460, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 166);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtFio
            // 
            this.txtFio.Location = new System.Drawing.Point(52, 26);
            this.txtFio.Name = "txtFio";
            this.txtFio.Size = new System.Drawing.Size(100, 20);
            this.txtFio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(52, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(65, 20);
            this.txtNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Гражданство";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(238, 55);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Возраст";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(213, 23);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(48, 20);
            this.txtAge.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Отель";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(460, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbOfhotel
            // 
            this.cmbOfhotel.DataSource = this.clientBindingSource;
            this.cmbOfhotel.DisplayMember = "ofhotel";
            this.cmbOfhotel.FormattingEnabled = true;
            this.cmbOfhotel.Location = new System.Drawing.Point(336, 23);
            this.cmbOfhotel.Name = "cmbOfhotel";
            this.cmbOfhotel.Size = new System.Drawing.Size(100, 21);
            this.cmbOfhotel.TabIndex = 16;
            this.cmbOfhotel.ValueMember = "ofhotel";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.lR5DataSet;
            // 
            // lR5DataSet
            // 
            this.lR5DataSet.DataSetName = "LR5DataSet";
            this.lR5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Испанские отели 4 или 5 *";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Клиенты греческих отелей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Отели с двумя и более клиентами";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Клиенты, живущие в отелях, где нет французов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAllHotels
            // 
            this.btnAllHotels.Location = new System.Drawing.Point(238, 15);
            this.btnAllHotels.Name = "btnAllHotels";
            this.btnAllHotels.Size = new System.Drawing.Size(75, 23);
            this.btnAllHotels.TabIndex = 21;
            this.btnAllHotels.Text = "All Hotels";
            this.btnAllHotels.UseVisualStyleBackColor = true;
            this.btnAllHotels.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAllClients
            // 
            this.btnAllClients.Location = new System.Drawing.Point(238, 44);
            this.btnAllClients.Name = "btnAllClients";
            this.btnAllClients.Size = new System.Drawing.Size(75, 23);
            this.btnAllClients.TabIndex = 22;
            this.btnAllClients.Text = "All Clients";
            this.btnAllClients.UseVisualStyleBackColor = true;
            this.btnAllClients.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCreateXml
            // 
            this.btnCreateXml.Location = new System.Drawing.Point(12, 14);
            this.btnCreateXml.Name = "btnCreateXml";
            this.btnCreateXml.Size = new System.Drawing.Size(125, 23);
            this.btnCreateXml.TabIndex = 23;
            this.btnCreateXml.Text = "Сформировать XML";
            this.btnCreateXml.UseVisualStyleBackColor = true;
            this.btnCreateXml.Click += new System.EventHandler(this.btnCreateXml_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(12, 43);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(125, 23);
            this.btnReadXml.TabIndex = 24;
            this.btnReadXml.Text = "Чтение из XML";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // btnAddXmlElement
            // 
            this.btnAddXmlElement.Location = new System.Drawing.Point(12, 82);
            this.btnAddXmlElement.Name = "btnAddXmlElement";
            this.btnAddXmlElement.Size = new System.Drawing.Size(125, 23);
            this.btnAddXmlElement.TabIndex = 25;
            this.btnAddXmlElement.Text = "Добавить клиента";
            this.btnAddXmlElement.UseVisualStyleBackColor = true;
            this.btnAddXmlElement.Click += new System.EventHandler(this.btnAddXmlElement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDop2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAllClients);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAllHotels);
            this.groupBox1.Location = new System.Drawing.Point(13, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 171);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // btnDop
            // 
            this.btnDop.Location = new System.Drawing.Point(12, 142);
            this.btnDop.Name = "btnDop";
            this.btnDop.Size = new System.Drawing.Size(112, 23);
            this.btnDop.TabIndex = 23;
            this.btnDop.Text = "ФИО и кол-во (xml)";
            this.btnDop.UseVisualStyleBackColor = true;
            this.btnDop.Click += new System.EventHandler(this.btnDop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.txtFio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCountry);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbOfhotel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(13, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 84);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRUD";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCityAndCount);
            this.groupBox3.Controls.Add(this.btnDop);
            this.groupBox3.Controls.Add(this.btnEditXmlElement);
            this.groupBox3.Controls.Add(this.btnDelXmlElement);
            this.groupBox3.Controls.Add(this.btnClientsOfAttica);
            this.groupBox3.Controls.Add(this.btnAddXmlElement);
            this.groupBox3.Controls.Add(this.btnReadXml);
            this.groupBox3.Controls.Add(this.btnCreateXml);
            this.groupBox3.Location = new System.Drawing.Point(349, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 171);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // btnCityAndCount
            // 
            this.btnCityAndCount.Location = new System.Drawing.Point(143, 43);
            this.btnCityAndCount.Name = "btnCityAndCount";
            this.btnCityAndCount.Size = new System.Drawing.Size(137, 23);
            this.btnCityAndCount.TabIndex = 29;
            this.btnCityAndCount.Text = "Города и кол-во отелей в каждом";
            this.btnCityAndCount.UseVisualStyleBackColor = true;
            this.btnCityAndCount.Click += new System.EventHandler(this.btnCityAndCount_Click);
            // 
            // btnEditXmlElement
            // 
            this.btnEditXmlElement.Location = new System.Drawing.Point(144, 82);
            this.btnEditXmlElement.Name = "btnEditXmlElement";
            this.btnEditXmlElement.Size = new System.Drawing.Size(150, 23);
            this.btnEditXmlElement.TabIndex = 28;
            this.btnEditXmlElement.Text = "Редактировать клиента";
            this.btnEditXmlElement.UseVisualStyleBackColor = true;
            this.btnEditXmlElement.Click += new System.EventHandler(this.btnEditXmlElement_Click);
            // 
            // btnDelXmlElement
            // 
            this.btnDelXmlElement.Location = new System.Drawing.Point(12, 111);
            this.btnDelXmlElement.Name = "btnDelXmlElement";
            this.btnDelXmlElement.Size = new System.Drawing.Size(125, 23);
            this.btnDelXmlElement.TabIndex = 27;
            this.btnDelXmlElement.Text = "Удалить клиента";
            this.btnDelXmlElement.UseVisualStyleBackColor = true;
            this.btnDelXmlElement.Click += new System.EventHandler(this.btnDelXmlElement_Click);
            // 
            // btnClientsOfAttica
            // 
            this.btnClientsOfAttica.Location = new System.Drawing.Point(143, 14);
            this.btnClientsOfAttica.Name = "btnClientsOfAttica";
            this.btnClientsOfAttica.Size = new System.Drawing.Size(125, 23);
            this.btnClientsOfAttica.TabIndex = 26;
            this.btnClientsOfAttica.Text = "Клиенты отеля Attica";
            this.btnClientsOfAttica.UseVisualStyleBackColor = true;
            this.btnClientsOfAttica.Click += new System.EventHandler(this.btnClientsOfAttica_Click);
            // 
            // btnDop2
            // 
            this.btnDop2.Location = new System.Drawing.Point(11, 138);
            this.btnDop2.Name = "btnDop2";
            this.btnDop2.Size = new System.Drawing.Size(116, 23);
            this.btnDop2.TabIndex = 24;
            this.btnDop2.Text = "ФИО и кол-во (sql)";
            this.btnDop2.UseVisualStyleBackColor = true;
            this.btnDop2.Click += new System.EventHandler(this.btnDop2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lR5DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbOfhotel;
        private LR5DataSet lR5DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private LR5DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAllHotels;
        private System.Windows.Forms.Button btnAllClients;
        private System.Windows.Forms.Button btnCreateXml;
        private System.Windows.Forms.Button btnReadXml;
        private System.Windows.Forms.Button btnAddXmlElement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClientsOfAttica;
        private System.Windows.Forms.Button btnDelXmlElement;
        private System.Windows.Forms.Button btnEditXmlElement;
        private System.Windows.Forms.Button btnCityAndCount;
        private System.Windows.Forms.Button btnDop;
        private System.Windows.Forms.Button btnDop2;
    }
}

