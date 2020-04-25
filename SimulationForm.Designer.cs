﻿namespace SuperMarketSimulation
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
            this.OpenTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenTimeInput = new System.Windows.Forms.TextBox();
            this.NumRegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.NumRegisterUpDown = new System.Windows.Forms.NumericUpDown();
            this.CloseTimeInput = new System.Windows.Forms.GroupBox();
            this.CloseStoreInput = new System.Windows.Forms.TextBox();
            this.CustNumGroupBox = new System.Windows.Forms.GroupBox();
            this.NumCustomerUpDown = new System.Windows.Forms.NumericUpDown();
            this.DurationGroupBox = new System.Windows.Forms.GroupBox();
            this.DurationTimeInput = new System.Windows.Forms.TextBox();
            this.StartStopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.RegistersTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LongestQueueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EventsProcLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ArrivalsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeparturesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LargeThreePanel.SuspendLayout();
            this.SettingsTableLayout.SuspendLayout();
            this.OpenTimeGroupBox.SuspendLayout();
            this.NumRegisterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRegisterUpDown)).BeginInit();
            this.CloseTimeInput.SuspendLayout();
            this.CustNumGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerUpDown)).BeginInit();
            this.DurationGroupBox.SuspendLayout();
            this.StartStopLayout.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LargeThreePanel
            // 
            this.LargeThreePanel.ColumnCount = 1;
            this.LargeThreePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LargeThreePanel.Controls.Add(this.SettingsTableLayout, 0, 0);
            this.LargeThreePanel.Controls.Add(this.StartStopLayout, 0, 1);
            this.LargeThreePanel.Controls.Add(this.RegistersTextBox, 0, 2);
            this.LargeThreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LargeThreePanel.Location = new System.Drawing.Point(0, 0);
            this.LargeThreePanel.Name = "LargeThreePanel";
            this.LargeThreePanel.RowCount = 3;
            this.LargeThreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.LargeThreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LargeThreePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.LargeThreePanel.Size = new System.Drawing.Size(1028, 450);
            this.LargeThreePanel.TabIndex = 0;
            // 
            // SettingsTableLayout
            // 
            this.SettingsTableLayout.ColumnCount = 5;
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SettingsTableLayout.Controls.Add(this.OpenTimeGroupBox, 0, 0);
            this.SettingsTableLayout.Controls.Add(this.NumRegisterGroupBox, 3, 0);
            this.SettingsTableLayout.Controls.Add(this.CloseTimeInput, 1, 0);
            this.SettingsTableLayout.Controls.Add(this.CustNumGroupBox, 0, 0);
            this.SettingsTableLayout.Controls.Add(this.DurationGroupBox, 4, 0);
            this.SettingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTableLayout.Location = new System.Drawing.Point(3, 3);
            this.SettingsTableLayout.Name = "SettingsTableLayout";
            this.SettingsTableLayout.RowCount = 1;
            this.SettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsTableLayout.Size = new System.Drawing.Size(1022, 48);
            this.SettingsTableLayout.TabIndex = 0;
            // 
            // OpenTimeGroupBox
            // 
            this.OpenTimeGroupBox.Controls.Add(this.OpenTimeInput);
            this.OpenTimeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenTimeGroupBox.Location = new System.Drawing.Point(207, 3);
            this.OpenTimeGroupBox.Name = "OpenTimeGroupBox";
            this.OpenTimeGroupBox.Size = new System.Drawing.Size(198, 42);
            this.OpenTimeGroupBox.TabIndex = 5;
            this.OpenTimeGroupBox.TabStop = false;
            this.OpenTimeGroupBox.Text = "Time Store Opens HH:MM";
            // 
            // OpenTimeInput
            // 
            this.OpenTimeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenTimeInput.Location = new System.Drawing.Point(3, 16);
            this.OpenTimeInput.Name = "OpenTimeInput";
            this.OpenTimeInput.Size = new System.Drawing.Size(192, 20);
            this.OpenTimeInput.TabIndex = 1;
            this.OpenTimeInput.Text = "08:00";
            this.OpenTimeInput.TextChanged += new System.EventHandler(this.OpenTimeInput_TextChanged);
            // 
            // NumRegisterGroupBox
            // 
            this.NumRegisterGroupBox.Controls.Add(this.NumRegisterUpDown);
            this.NumRegisterGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumRegisterGroupBox.Location = new System.Drawing.Point(615, 3);
            this.NumRegisterGroupBox.Name = "NumRegisterGroupBox";
            this.NumRegisterGroupBox.Size = new System.Drawing.Size(198, 42);
            this.NumRegisterGroupBox.TabIndex = 3;
            this.NumRegisterGroupBox.TabStop = false;
            this.NumRegisterGroupBox.Text = "Number of Registers";
            // 
            // NumRegisterUpDown
            // 
            this.NumRegisterUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumRegisterUpDown.Location = new System.Drawing.Point(3, 16);
            this.NumRegisterUpDown.Name = "NumRegisterUpDown";
            this.NumRegisterUpDown.Size = new System.Drawing.Size(192, 20);
            this.NumRegisterUpDown.TabIndex = 1;
            this.NumRegisterUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumRegisterUpDown.ValueChanged += new System.EventHandler(this.NumRegisterUpDown_ValueChanged);
            // 
            // CloseTimeInput
            // 
            this.CloseTimeInput.Controls.Add(this.CloseStoreInput);
            this.CloseTimeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseTimeInput.Location = new System.Drawing.Point(411, 3);
            this.CloseTimeInput.Name = "CloseTimeInput";
            this.CloseTimeInput.Size = new System.Drawing.Size(198, 42);
            this.CloseTimeInput.TabIndex = 2;
            this.CloseTimeInput.TabStop = false;
            this.CloseTimeInput.Text = "Time Store Closes HH:MM";
            // 
            // CloseStoreInput
            // 
            this.CloseStoreInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseStoreInput.Location = new System.Drawing.Point(3, 16);
            this.CloseStoreInput.Name = "CloseStoreInput";
            this.CloseStoreInput.Size = new System.Drawing.Size(192, 20);
            this.CloseStoreInput.TabIndex = 1;
            this.CloseStoreInput.Text = "20:00";
            this.CloseStoreInput.TextChanged += new System.EventHandler(this.CloseStoreInput_TextChanged);
            // 
            // CustNumGroupBox
            // 
            this.CustNumGroupBox.Controls.Add(this.NumCustomerUpDown);
            this.CustNumGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustNumGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustNumGroupBox.Name = "CustNumGroupBox";
            this.CustNumGroupBox.Size = new System.Drawing.Size(198, 42);
            this.CustNumGroupBox.TabIndex = 1;
            this.CustNumGroupBox.TabStop = false;
            this.CustNumGroupBox.Text = "Number of Customers";
            // 
            // NumCustomerUpDown
            // 
            this.NumCustomerUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCustomerUpDown.Location = new System.Drawing.Point(3, 16);
            this.NumCustomerUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumCustomerUpDown.Name = "NumCustomerUpDown";
            this.NumCustomerUpDown.Size = new System.Drawing.Size(192, 20);
            this.NumCustomerUpDown.TabIndex = 2;
            this.NumCustomerUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumCustomerUpDown.ValueChanged += new System.EventHandler(this.NumCustomerUpDown_ValueChanged);
            // 
            // DurationGroupBox
            // 
            this.DurationGroupBox.Controls.Add(this.DurationTimeInput);
            this.DurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationGroupBox.Location = new System.Drawing.Point(819, 3);
            this.DurationGroupBox.Name = "DurationGroupBox";
            this.DurationGroupBox.Size = new System.Drawing.Size(200, 42);
            this.DurationGroupBox.TabIndex = 0;
            this.DurationGroupBox.TabStop = false;
            this.DurationGroupBox.Text = "Expected Checkout Time MM:SS";
            // 
            // DurationTimeInput
            // 
            this.DurationTimeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationTimeInput.Location = new System.Drawing.Point(3, 16);
            this.DurationTimeInput.Name = "DurationTimeInput";
            this.DurationTimeInput.Size = new System.Drawing.Size(194, 20);
            this.DurationTimeInput.TabIndex = 0;
            this.DurationTimeInput.Text = "02:30";
            this.DurationTimeInput.TextChanged += new System.EventHandler(this.DurationTimeInput_TextChanged);
            // 
            // StartStopLayout
            // 
            this.StartStopLayout.ColumnCount = 1;
            this.StartStopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartStopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StartStopLayout.Controls.Add(this.StartButton, 0, 0);
            this.StartStopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartStopLayout.Location = new System.Drawing.Point(3, 57);
            this.StartStopLayout.Name = "StartStopLayout";
            this.StartStopLayout.RowCount = 1;
            this.StartStopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartStopLayout.Size = new System.Drawing.Size(1022, 61);
            this.StartStopLayout.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(1016, 55);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RegistersTextBox
            // 
            this.RegistersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistersTextBox.Location = new System.Drawing.Point(3, 124);
            this.RegistersTextBox.Multiline = true;
            this.RegistersTextBox.Name = "RegistersTextBox";
            this.RegistersTextBox.ReadOnly = true;
            this.RegistersTextBox.Size = new System.Drawing.Size(1022, 323);
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
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LongestQueueLabel
            // 
            this.LongestQueueLabel.Name = "LongestQueueLabel";
            this.LongestQueueLabel.Size = new System.Drawing.Size(253, 17);
            this.LongestQueueLabel.Spring = true;
            // 
            // EventsProcLabel
            // 
            this.EventsProcLabel.Name = "EventsProcLabel";
            this.EventsProcLabel.Size = new System.Drawing.Size(253, 17);
            this.EventsProcLabel.Spring = true;
            // 
            // ArrivalsLabel
            // 
            this.ArrivalsLabel.Name = "ArrivalsLabel";
            this.ArrivalsLabel.Size = new System.Drawing.Size(253, 17);
            this.ArrivalsLabel.Spring = true;
            // 
            // DeparturesLabel
            // 
            this.DeparturesLabel.Name = "DeparturesLabel";
            this.DeparturesLabel.Size = new System.Drawing.Size(253, 17);
            this.DeparturesLabel.Spring = true;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LargeThreePanel);
            this.Name = "SimulationForm";
            this.Text = "Super Market Simulation";
            this.LargeThreePanel.ResumeLayout(false);
            this.LargeThreePanel.PerformLayout();
            this.SettingsTableLayout.ResumeLayout(false);
            this.OpenTimeGroupBox.ResumeLayout(false);
            this.OpenTimeGroupBox.PerformLayout();
            this.NumRegisterGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumRegisterUpDown)).EndInit();
            this.CloseTimeInput.ResumeLayout(false);
            this.CloseTimeInput.PerformLayout();
            this.CustNumGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerUpDown)).EndInit();
            this.DurationGroupBox.ResumeLayout(false);
            this.DurationGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox CloseTimeInput;
        private System.Windows.Forms.GroupBox CustNumGroupBox;
        private System.Windows.Forms.TableLayoutPanel StartStopLayout;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LongestQueueLabel;
        private System.Windows.Forms.ToolStripStatusLabel EventsProcLabel;
        private System.Windows.Forms.ToolStripStatusLabel ArrivalsLabel;
        private System.Windows.Forms.ToolStripStatusLabel DeparturesLabel;
        private System.Windows.Forms.NumericUpDown NumRegisterUpDown;
        private System.Windows.Forms.NumericUpDown NumCustomerUpDown;
        private System.Windows.Forms.TextBox RegistersTextBox;
        private System.Windows.Forms.GroupBox DurationGroupBox;
        private System.Windows.Forms.GroupBox OpenTimeGroupBox;
        private System.Windows.Forms.TextBox OpenTimeInput;
        private System.Windows.Forms.TextBox CloseStoreInput;
        private System.Windows.Forms.TextBox DurationTimeInput;
    }
}

