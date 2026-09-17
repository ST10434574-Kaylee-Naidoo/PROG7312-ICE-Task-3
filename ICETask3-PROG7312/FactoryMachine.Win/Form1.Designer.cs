namespace FactoryMachine.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvgReadings = new DataGridView();
            dgvAnomalies = new DataGridView();
            lblTotalAnomalies = new Label();
            lblHottestMachine = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgReadings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnomalies).BeginInit();
            SuspendLayout();
            // 
            // dvgReadings
            // 
            dvgReadings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgReadings.Location = new Point(29, 12);
            dvgReadings.Name = "dvgReadings";
            dvgReadings.RowHeadersWidth = 51;
            dvgReadings.Size = new Size(396, 135);
            dvgReadings.TabIndex = 0;
            
            // 
            // dgvAnomalies
            // 
            dgvAnomalies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnomalies.Location = new Point(29, 169);
            dgvAnomalies.Name = "dgvAnomalies";
            dgvAnomalies.RowHeadersWidth = 51;
            dgvAnomalies.Size = new Size(396, 135);
            dgvAnomalies.TabIndex = 1;
            // 
            // lblTotalAnomalies
            // 
            lblTotalAnomalies.AutoSize = true;
            lblTotalAnomalies.Location = new Point(53, 331);
            lblTotalAnomalies.Name = "lblTotalAnomalies";
            lblTotalAnomalies.Size = new Size(135, 20);
            lblTotalAnomalies.TabIndex = 2;
            lblTotalAnomalies.Text = "Total Anomalies : 0";
           
            // 
            // lblHottestMachine
            // 
            lblHottestMachine.AutoSize = true;
            lblHottestMachine.Location = new Point(53, 374);
            lblHottestMachine.Name = "lblHottestMachine";
            lblHottestMachine.Size = new Size(131, 20);
            lblHottestMachine.TabIndex = 5;
            lblHottestMachine.Text = "Hottest Machine: -";
       
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(270, 414);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh Readings";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(lblHottestMachine);
            Controls.Add(lblTotalAnomalies);
            Controls.Add(dgvAnomalies);
            Controls.Add(dvgReadings);
            Name = "Form1";
            Text = "Form1";
     
            ((System.ComponentModel.ISupportInitialize)dvgReadings).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnomalies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgReadings;
        private DataGridView dgvAnomalies;
        private Label lblTotalAnomalies;

        private Label lblHottestMachine;
        private Button btnRefresh;
    }
}
