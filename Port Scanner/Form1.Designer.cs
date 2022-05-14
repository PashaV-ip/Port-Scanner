
namespace Port_Scanner
{
    partial class PortScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortScanner));
            this.iPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startPort = new System.Windows.Forms.NumericUpDown();
            this.endPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.Button();
            this.resultScan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.startPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPort)).BeginInit();
            this.SuspendLayout();
            // 
            // iPAddress
            // 
            this.iPAddress.Location = new System.Drawing.Point(115, 18);
            this.iPAddress.Name = "iPAddress";
            this.iPAddress.Size = new System.Drawing.Size(180, 29);
            this.iPAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Порты с:";
            // 
            // startPort
            // 
            this.startPort.Location = new System.Drawing.Point(403, 19);
            this.startPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.startPort.Name = "startPort";
            this.startPort.Size = new System.Drawing.Size(120, 29);
            this.startPort.TabIndex = 3;
            // 
            // endPort
            // 
            this.endPort.Location = new System.Drawing.Point(569, 18);
            this.endPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.endPort.Name = "endPort";
            this.endPort.Size = new System.Drawing.Size(120, 29);
            this.endPort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "до";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(705, 14);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(167, 37);
            this.scan.TabIndex = 6;
            this.scan.Text = "Сканировать";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // resultScan
            // 
            this.resultScan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.resultScan.HideSelection = false;
            this.resultScan.Location = new System.Drawing.Point(16, 69);
            this.resultScan.Name = "resultScan";
            this.resultScan.Size = new System.Drawing.Size(856, 459);
            this.resultScan.TabIndex = 7;
            this.resultScan.UseCompatibleStateImageBehavior = false;
            this.resultScan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Порты:";
            this.columnHeader1.Width = 398;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Состояние:";
            this.columnHeader2.Width = 154;
            // 
            // PortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.resultScan);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endPort);
            this.Controls.Add(this.startPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iPAddress);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "PortScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сканер портов";
            ((System.ComponentModel.ISupportInitialize)(this.startPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startPort;
        private System.Windows.Forms.NumericUpDown endPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.ListView resultScan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

