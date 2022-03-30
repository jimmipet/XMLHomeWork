
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
            this.tbpEquipments = new System.Windows.Forms.TabPage();
            this.EquipmentsDGV = new System.Windows.Forms.DataGridView();
            this.tbpWorkers = new System.Windows.Forms.TabPage();
            this.WorkersDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WastesDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svalka.SuspendLayout();
            this.Xml.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbpWastes.SuspendLayout();
            this.tbpEquipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentsDGV)).BeginInit();
            this.tbpWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WastesDGV)).BeginInit();
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
            this.EquipmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.EquipmentsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentsDGV.Location = new System.Drawing.Point(3, 3);
            this.EquipmentsDGV.Name = "EquipmentsDGV";
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
            this.WorkersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.WorkersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkersDGV.Location = new System.Drawing.Point(0, 0);
            this.WorkersDGV.Name = "WorkersDGV";
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
            // WastesDGV
            // 
            this.WastesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WastesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.WastesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WastesDGV.Location = new System.Drawing.Point(3, 3);
            this.WastesDGV.Name = "WastesDGV";
            this.WastesDGV.RowHeadersWidth = 51;
            this.WastesDGV.RowTemplate.Height = 24;
            this.WastesDGV.Size = new System.Drawing.Size(772, 380);
            this.WastesDGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
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
            this.tbpEquipments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentsDGV)).EndInit();
            this.tbpWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkersDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WastesDGV)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

