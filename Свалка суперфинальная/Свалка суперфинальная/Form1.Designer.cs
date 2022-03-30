
namespace Свалка_суперфинальная
{
    partial class Свалка
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Svalka = new System.Windows.Forms.TabControl();
            this.Xml = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbpWastes = new System.Windows.Forms.TabPage();
            this.WastesDGV = new System.Windows.Forms.DataGridView();
            this.tbpEquipments = new System.Windows.Forms.TabPage();
            this.EquipmentsDGV = new System.Windows.Forms.DataGridView();
            this.tbpWorkers = new System.Windows.Forms.TabPage();
            this.WorkersDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svalka.SuspendLayout();
            this.Xml.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbpWastes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WastesDGV)).BeginInit();
            this.tbpEquipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentsDGV)).BeginInit();
            this.tbpWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Svalka
            // 
            this.Svalka.Controls.Add(this.Xml);
            this.Svalka.Controls.Add(this.tabPage2);
            this.Svalka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Svalka.Location = new System.Drawing.Point(0, 0);
            this.Svalka.Name = "Svalka";
            this.Svalka.SelectedIndex = 0;
            this.Svalka.Size = new System.Drawing.Size(800, 450);
            this.Svalka.TabIndex = 0;
            // 
            // Xml
            // 
            this.Xml.Controls.Add(this.tabControl2);
            this.Xml.Location = new System.Drawing.Point(4, 25);
            this.Xml.Name = "Xml";
            this.Xml.Padding = new System.Windows.Forms.Padding(3);
            this.Xml.Size = new System.Drawing.Size(792, 421);
            this.Xml.TabIndex = 0;
            this.Xml.Text = "Xml";
            this.Xml.ToolTipText = "Xml";
            this.Xml.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbpWastes);
            this.tabControl2.Controls.Add(this.tbpEquipments);
            this.tabControl2.Controls.Add(this.tbpWorkers);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 415);
            this.tabControl2.TabIndex = 0;
            // 
            // tbpWastes
            // 
            this.tbpWastes.Controls.Add(this.WastesDGV);
            this.tbpWastes.Location = new System.Drawing.Point(4, 25);
            this.tbpWastes.Name = "tbpWastes";
            this.tbpWastes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWastes.Size = new System.Drawing.Size(778, 386);
            this.tbpWastes.TabIndex = 0;
            this.tbpWastes.Text = "Отходы";
            this.tbpWastes.UseVisualStyleBackColor = true;
            // 
            // WastesDGV
            // 
            this.WastesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WastesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WastesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Type,
            this.Satate,
            this.Column4});
            this.WastesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WastesDGV.Location = new System.Drawing.Point(3, 3);
            this.WastesDGV.Name = "WastesDGV";
            this.WastesDGV.RowHeadersVisible = false;
            this.WastesDGV.RowHeadersWidth = 51;
            this.WastesDGV.RowTemplate.Height = 24;
            this.WastesDGV.Size = new System.Drawing.Size(772, 380);
            this.WastesDGV.TabIndex = 0;
            // 
            // tbpEquipments
            // 
            this.tbpEquipments.Controls.Add(this.EquipmentsDGV);
            this.tbpEquipments.Location = new System.Drawing.Point(4, 25);
            this.tbpEquipments.Name = "tbpEquipments";
            this.tbpEquipments.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEquipments.Size = new System.Drawing.Size(778, 386);
            this.tbpEquipments.TabIndex = 1;
            this.tbpEquipments.Text = "Техника";
            this.tbpEquipments.UseVisualStyleBackColor = true;
            // 
            // EquipmentsDGV
            // 
            this.EquipmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EquipmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.year,
            this.Column5,
            this.Column6});
            this.EquipmentsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentsDGV.Location = new System.Drawing.Point(3, 3);
            this.EquipmentsDGV.Name = "EquipmentsDGV";
            this.EquipmentsDGV.RowHeadersVisible = false;
            this.EquipmentsDGV.RowHeadersWidth = 51;
            this.EquipmentsDGV.RowTemplate.Height = 24;
            this.EquipmentsDGV.Size = new System.Drawing.Size(772, 380);
            this.EquipmentsDGV.TabIndex = 0;
            // 
            // tbpWorkers
            // 
            this.tbpWorkers.Controls.Add(this.WorkersDGV);
            this.tbpWorkers.Location = new System.Drawing.Point(4, 25);
            this.tbpWorkers.Name = "tbpWorkers";
            this.tbpWorkers.Size = new System.Drawing.Size(778, 386);
            this.tbpWorkers.TabIndex = 2;
            this.tbpWorkers.Text = "Работники";
            this.tbpWorkers.UseVisualStyleBackColor = true;
            // 
            // WorkersDGV
            // 
            this.WorkersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9});
            this.WorkersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkersDGV.Location = new System.Drawing.Point(0, 0);
            this.WorkersDGV.Name = "WorkersDGV";
            this.WorkersDGV.RowHeadersVisible = false;
            this.WorkersDGV.RowHeadersWidth = 51;
            this.WorkersDGV.RowTemplate.Height = 24;
            this.WorkersDGV.Size = new System.Drawing.Size(778, 386);
            this.WorkersDGV.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Json";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 386);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Condition";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Satate
            // 
            this.Satate.HeaderText = "State";
            this.Satate.MinimumWidth = 6;
            this.Satate.Name = "Satate";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "age";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // year
            // 
            this.year.HeaderText = "year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Condition";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Surname";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Post";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Salary";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Свалка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Svalka);
            this.Name = "Свалка";
            this.Text = "Свалка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Svalka.ResumeLayout(false);
            this.Xml.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbpWastes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WastesDGV)).EndInit();
            this.tbpEquipments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentsDGV)).EndInit();
            this.tbpWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkersDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Svalka;
        private System.Windows.Forms.TabPage Xml;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbpWastes;
        private System.Windows.Forms.TabPage tbpEquipments;
        private System.Windows.Forms.DataGridView EquipmentsDGV;
        private System.Windows.Forms.TabPage tbpWorkers;
        private System.Windows.Forms.DataGridView WorkersDGV;
        private System.Windows.Forms.DataGridView WastesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

