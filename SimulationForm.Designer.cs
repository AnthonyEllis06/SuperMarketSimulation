namespace SuperMarketSimulation
{
    partial class SimulationForm
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
            this.LargeThreePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NumRegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.NumRegisterUpDown = new System.Windows.Forms.NumericUpDown();
            this.HoursOPGroupBox = new System.Windows.Forms.GroupBox();
            this.NumHoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.CustNumGroupBox = new System.Windows.Forms.GroupBox();
            this.NumCustomerUpDown = new System.Windows.Forms.NumericUpDown();
            this.DurationGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckOutDurUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartStopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.RegistersTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LongestQueueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EventsProcLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ArrivalsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeparturesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LargeThreePanel.SuspendLayout();
            this.SettingsTableLayout.SuspendLayout();
            this.NumRegisterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRegisterUpDown)).BeginInit();
            this.HoursOPGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumHoursUpDown)).BeginInit();
            this.CustNumGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerUpDown)).BeginInit();
            this.DurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutDurUpDown)).BeginInit();
            this.StartStopLayout.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LargeThreePanel
            // 
            this.LargeThreePanel.ColumnCount = 1;
            this.LargeThreePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LargeThreePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LargeThreePanel.Controls.Add(this.SettingsTableLayout, 0, 0);
            this.LargeThreePanel.Controls.Add(this.StartStopLayout, 0, 1);
            this.LargeThreePanel.Controls.Add(this.RegistersTextBox, 0, 2);
            this.LargeThreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LargeThreePanel.Location = new System.Drawing.Point(0, 0);
            this.LargeThreePanel.Name = "LargeThreePanel";
            this.LargeThreePanel.RowCount = 3;
            this.LargeThreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.LargeThreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LargeThreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.LargeThreePanel.Size = new System.Drawing.Size(800, 450);
            this.LargeThreePanel.TabIndex = 0;
            // 
            // SettingsTableLayout
            // 
            this.SettingsTableLayout.ColumnCount = 4;
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SettingsTableLayout.Controls.Add(this.NumRegisterGroupBox, 2, 0);
            this.SettingsTableLayout.Controls.Add(this.HoursOPGroupBox, 1, 0);
            this.SettingsTableLayout.Controls.Add(this.CustNumGroupBox, 0, 0);
            this.SettingsTableLayout.Controls.Add(this.DurationGroupBox, 3, 0);
            this.SettingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTableLayout.Location = new System.Drawing.Point(3, 3);
            this.SettingsTableLayout.Name = "SettingsTableLayout";
            this.SettingsTableLayout.RowCount = 1;
            this.SettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.SettingsTableLayout.Size = new System.Drawing.Size(794, 174);
            this.SettingsTableLayout.TabIndex = 0;
            // 
            // NumRegisterGroupBox
            // 
            this.NumRegisterGroupBox.Controls.Add(this.NumRegisterUpDown);
            this.NumRegisterGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumRegisterGroupBox.Location = new System.Drawing.Point(399, 3);
            this.NumRegisterGroupBox.Name = "NumRegisterGroupBox";
            this.NumRegisterGroupBox.Size = new System.Drawing.Size(192, 168);
            this.NumRegisterGroupBox.TabIndex = 3;
            this.NumRegisterGroupBox.TabStop = false;
            this.NumRegisterGroupBox.Text = "Number of Registers";
            // 
            // NumRegisterUpDown
            // 
            this.NumRegisterUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumRegisterUpDown.Location = new System.Drawing.Point(3, 16);
            this.NumRegisterUpDown.Name = "NumRegisterUpDown";
            this.NumRegisterUpDown.Size = new System.Drawing.Size(186, 20);
            this.NumRegisterUpDown.TabIndex = 1;
            // 
            // HoursOPGroupBox
            // 
            this.HoursOPGroupBox.Controls.Add(this.NumHoursUpDown);
            this.HoursOPGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursOPGroupBox.Location = new System.Drawing.Point(201, 3);
            this.HoursOPGroupBox.Name = "HoursOPGroupBox";
            this.HoursOPGroupBox.Size = new System.Drawing.Size(192, 168);
            this.HoursOPGroupBox.TabIndex = 2;
            this.HoursOPGroupBox.TabStop = false;
            this.HoursOPGroupBox.Text = "Number of Hours of Operation";
            // 
            // NumHoursUpDown
            // 
            this.NumHoursUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumHoursUpDown.Location = new System.Drawing.Point(3, 16);
            this.NumHoursUpDown.Name = "NumHoursUpDown";
            this.NumHoursUpDown.Size = new System.Drawing.Size(186, 20);
            this.NumHoursUpDown.TabIndex = 0;
            // 
            // CustNumGroupBox
            // 
            this.CustNumGroupBox.Controls.Add(this.NumCustomerUpDown);
            this.CustNumGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustNumGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustNumGroupBox.Name = "CustNumGroupBox";
            this.CustNumGroupBox.Size = new System.Drawing.Size(192, 168);
            this.CustNumGroupBox.TabIndex = 1;
            this.CustNumGroupBox.TabStop = false;
            this.CustNumGroupBox.Text = "Number of Customers";
            // 
            // NumCustomerUpDown
            // 
            this.NumCustomerUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCustomerUpDown.Location = new System.Drawing.Point(3, 16);
            this.NumCustomerUpDown.Name = "NumCustomerUpDown";
            this.NumCustomerUpDown.Size = new System.Drawing.Size(186, 20);
            this.NumCustomerUpDown.TabIndex = 2;
            // 
            // DurationGroupBox
            // 
            this.DurationGroupBox.Controls.Add(this.CheckOutDurUpDown);
            this.DurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationGroupBox.Location = new System.Drawing.Point(597, 3);
            this.DurationGroupBox.Name = "DurationGroupBox";
            this.DurationGroupBox.Size = new System.Drawing.Size(194, 168);
            this.DurationGroupBox.TabIndex = 0;
            this.DurationGroupBox.TabStop = false;
            this.DurationGroupBox.Text = "Expected Checkout Duration";
            // 
            // CheckOutDurUpDown
            // 
            this.CheckOutDurUpDown.Location = new System.Drawing.Point(3, 16);
            this.CheckOutDurUpDown.Name = "CheckOutDurUpDown";
            this.CheckOutDurUpDown.Size = new System.Drawing.Size(186, 20);
            this.CheckOutDurUpDown.TabIndex = 2;
            // 
            // StartStopLayout
            // 
            this.StartStopLayout.ColumnCount = 2;
            this.StartStopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StartStopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StartStopLayout.Controls.Add(this.StartButton, 0, 0);
            this.StartStopLayout.Controls.Add(this.StopButton, 1, 0);
            this.StartStopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartStopLayout.Location = new System.Drawing.Point(3, 183);
            this.StartStopLayout.Name = "StartStopLayout";
            this.StartStopLayout.RowCount = 1;
            this.StartStopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartStopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.StartStopLayout.Size = new System.Drawing.Size(794, 84);
            this.StartStopLayout.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(391, 78);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Enabled = false;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(400, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(391, 78);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // RegistersTextBox
            // 
            this.RegistersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistersTextBox.Location = new System.Drawing.Point(3, 273);
            this.RegistersTextBox.Multiline = true;
            this.RegistersTextBox.Name = "RegistersTextBox";
            this.RegistersTextBox.ReadOnly = true;
            this.RegistersTextBox.Size = new System.Drawing.Size(794, 174);
            this.RegistersTextBox.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LongestQueueLabel,
            this.EventsProcLabel,
            this.ArrivalsLabel,
            this.DeparturesLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LongestQueueLabel
            // 
            this.LongestQueueLabel.Name = "LongestQueueLabel";
            this.LongestQueueLabel.Size = new System.Drawing.Size(196, 17);
            this.LongestQueueLabel.Spring = true;
            this.LongestQueueLabel.Text = "toolStripStatusLabel1";
            this.LongestQueueLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // EventsProcLabel
            // 
            this.EventsProcLabel.Name = "EventsProcLabel";
            this.EventsProcLabel.Size = new System.Drawing.Size(196, 17);
            this.EventsProcLabel.Spring = true;
            this.EventsProcLabel.Text = "toolStripStatusLabel1";
            // 
            // ArrivalsLabel
            // 
            this.ArrivalsLabel.Name = "ArrivalsLabel";
            this.ArrivalsLabel.Size = new System.Drawing.Size(196, 17);
            this.ArrivalsLabel.Spring = true;
            this.ArrivalsLabel.Text = "toolStripStatusLabel1";
            // 
            // DeparturesLabel
            // 
            this.DeparturesLabel.Name = "DeparturesLabel";
            this.DeparturesLabel.Size = new System.Drawing.Size(196, 17);
            this.DeparturesLabel.Spring = true;
            this.DeparturesLabel.Text = "toolStripStatusLabel1";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LargeThreePanel);
            this.Name = "SimulationForm";
            this.Text = "Super Market Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LargeThreePanel.ResumeLayout(false);
            this.LargeThreePanel.PerformLayout();
            this.SettingsTableLayout.ResumeLayout(false);
            this.NumRegisterGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumRegisterUpDown)).EndInit();
            this.HoursOPGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumHoursUpDown)).EndInit();
            this.CustNumGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerUpDown)).EndInit();
            this.DurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutDurUpDown)).EndInit();
            this.StartStopLayout.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LargeThreePanel;
        private System.Windows.Forms.TableLayoutPanel SettingsTableLayout;
        private System.Windows.Forms.GroupBox NumRegisterGroupBox;
        private System.Windows.Forms.GroupBox HoursOPGroupBox;
        private System.Windows.Forms.GroupBox CustNumGroupBox;
        private System.Windows.Forms.GroupBox DurationGroupBox;
        private System.Windows.Forms.TableLayoutPanel StartStopLayout;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LongestQueueLabel;
        private System.Windows.Forms.ToolStripStatusLabel EventsProcLabel;
        private System.Windows.Forms.ToolStripStatusLabel ArrivalsLabel;
        private System.Windows.Forms.ToolStripStatusLabel DeparturesLabel;
        private System.Windows.Forms.NumericUpDown NumRegisterUpDown;
        private System.Windows.Forms.NumericUpDown NumHoursUpDown;
        private System.Windows.Forms.NumericUpDown NumCustomerUpDown;
        private System.Windows.Forms.NumericUpDown CheckOutDurUpDown;
        private System.Windows.Forms.TextBox RegistersTextBox;
    }
}

