namespace WhiskerPrint.PresentationLayer
{
    partial class OptionsDialog
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
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.matchingTab = new System.Windows.Forms.TabPage();
            this.stepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.offsetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.useShifterCheckBox = new System.Windows.Forms.CheckBox();
            this.skipsLabel = new System.Windows.Forms.Label();
            this.skipsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.qualityCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.qualityCountLabel = new System.Windows.Forms.Label();
            this.scoreThresholdTextBox = new System.Windows.Forms.TextBox();
            this.scoreThresholdLabel = new System.Windows.Forms.Label();
            this.useCascaderCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.optionsTabControl.SuspendLayout();
            this.matchingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTabControl.Controls.Add(this.matchingTab);
            this.optionsTabControl.Location = new System.Drawing.Point(8, 8);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(443, 285);
            this.optionsTabControl.TabIndex = 0;
            // 
            // matchingTab
            // 
            this.matchingTab.Controls.Add(this.stepsNumericUpDown);
            this.matchingTab.Controls.Add(this.stepsLabel);
            this.matchingTab.Controls.Add(this.offsetNumericUpDown);
            this.matchingTab.Controls.Add(this.offsetLabel);
            this.matchingTab.Controls.Add(this.useShifterCheckBox);
            this.matchingTab.Controls.Add(this.skipsLabel);
            this.matchingTab.Controls.Add(this.skipsNumericUpDown);
            this.matchingTab.Controls.Add(this.qualityCountNumericUpDown);
            this.matchingTab.Controls.Add(this.qualityCountLabel);
            this.matchingTab.Controls.Add(this.scoreThresholdTextBox);
            this.matchingTab.Controls.Add(this.scoreThresholdLabel);
            this.matchingTab.Controls.Add(this.useCascaderCheckBox);
            this.matchingTab.Location = new System.Drawing.Point(4, 24);
            this.matchingTab.Name = "matchingTab";
            this.matchingTab.Padding = new System.Windows.Forms.Padding(3);
            this.matchingTab.Size = new System.Drawing.Size(435, 257);
            this.matchingTab.TabIndex = 0;
            this.matchingTab.Text = "Matching";
            this.matchingTab.UseVisualStyleBackColor = true;
            // 
            // stepsNumericUpDown
            // 
            this.stepsNumericUpDown.Location = new System.Drawing.Point(147, 208);
            this.stepsNumericUpDown.Name = "stepsNumericUpDown";
            this.stepsNumericUpDown.Size = new System.Drawing.Size(42, 23);
            this.stepsNumericUpDown.TabIndex = 11;
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Location = new System.Drawing.Point(44, 210);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(55, 15);
            this.stepsLabel.TabIndex = 10;
            this.stepsLabel.Text = "Step size:";
            // 
            // offsetNumericUpDown
            // 
            this.offsetNumericUpDown.Location = new System.Drawing.Point(147, 179);
            this.offsetNumericUpDown.Name = "offsetNumericUpDown";
            this.offsetNumericUpDown.Size = new System.Drawing.Size(42, 23);
            this.offsetNumericUpDown.TabIndex = 9;
            // 
            // offsetLabel
            // 
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(44, 181);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(97, 15);
            this.offsetLabel.TabIndex = 8;
            this.offsetLabel.Text = "Maximum offset:";
            // 
            // useShifterCheckBox
            // 
            this.useShifterCheckBox.AutoSize = true;
            this.useShifterCheckBox.Checked = true;
            this.useShifterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useShifterCheckBox.Location = new System.Drawing.Point(17, 150);
            this.useShifterCheckBox.Name = "useShifterCheckBox";
            this.useShifterCheckBox.Size = new System.Drawing.Size(88, 19);
            this.useShifterCheckBox.TabIndex = 7;
            this.useShifterCheckBox.Text = "Use shifting";
            this.useShifterCheckBox.UseVisualStyleBackColor = true;
            this.useShifterCheckBox.CheckedChanged += new System.EventHandler(this.useShifterCheckBox_CheckedChanged);
            // 
            // skipsLabel
            // 
            this.skipsLabel.AutoSize = true;
            this.skipsLabel.Location = new System.Drawing.Point(44, 107);
            this.skipsLabel.Name = "skipsLabel";
            this.skipsLabel.Size = new System.Drawing.Size(123, 15);
            this.skipsLabel.TabIndex = 6;
            this.skipsLabel.Text = "Skips per quality level:";
            // 
            // skipsNumericUpDown
            // 
            this.skipsNumericUpDown.Location = new System.Drawing.Point(189, 105);
            this.skipsNumericUpDown.Name = "skipsNumericUpDown";
            this.skipsNumericUpDown.Size = new System.Drawing.Size(42, 23);
            this.skipsNumericUpDown.TabIndex = 5;
            // 
            // qualityCountNumericUpDown
            // 
            this.qualityCountNumericUpDown.Location = new System.Drawing.Point(189, 76);
            this.qualityCountNumericUpDown.Name = "qualityCountNumericUpDown";
            this.qualityCountNumericUpDown.Size = new System.Drawing.Size(42, 23);
            this.qualityCountNumericUpDown.TabIndex = 4;
            // 
            // qualityCountLabel
            // 
            this.qualityCountLabel.AutoSize = true;
            this.qualityCountLabel.Location = new System.Drawing.Point(44, 78);
            this.qualityCountLabel.Name = "qualityCountLabel";
            this.qualityCountLabel.Size = new System.Drawing.Size(139, 15);
            this.qualityCountLabel.TabIndex = 3;
            this.qualityCountLabel.Text = "Number of quality levels:";
            // 
            // scoreThresholdTextBox
            // 
            this.scoreThresholdTextBox.Location = new System.Drawing.Point(189, 47);
            this.scoreThresholdTextBox.Name = "scoreThresholdTextBox";
            this.scoreThresholdTextBox.Size = new System.Drawing.Size(42, 23);
            this.scoreThresholdTextBox.TabIndex = 2;
            this.scoreThresholdTextBox.Text = "0.0";
            this.scoreThresholdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.scoreThresholdTextBox_Validating);
            // 
            // scoreThresholdLabel
            // 
            this.scoreThresholdLabel.AutoSize = true;
            this.scoreThresholdLabel.Location = new System.Drawing.Point(44, 50);
            this.scoreThresholdLabel.Name = "scoreThresholdLabel";
            this.scoreThresholdLabel.Size = new System.Drawing.Size(92, 15);
            this.scoreThresholdLabel.TabIndex = 1;
            this.scoreThresholdLabel.Text = "Score threshold:";
            // 
            // useCascaderCheckBox
            // 
            this.useCascaderCheckBox.AutoSize = true;
            this.useCascaderCheckBox.Checked = true;
            this.useCascaderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCascaderCheckBox.Location = new System.Drawing.Point(17, 19);
            this.useCascaderCheckBox.Name = "useCascaderCheckBox";
            this.useCascaderCheckBox.Size = new System.Drawing.Size(101, 19);
            this.useCascaderCheckBox.TabIndex = 0;
            this.useCascaderCheckBox.Text = "Use cascading";
            this.useCascaderCheckBox.UseVisualStyleBackColor = true;
            this.useCascaderCheckBox.CheckedChanged += new System.EventHandler(this.useCascaderCheckBox_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(376, 299);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(295, 299);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(458, 330);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.optionsTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsDialog_FormClosing);
            this.optionsTabControl.ResumeLayout(false);
            this.matchingTab.ResumeLayout(false);
            this.matchingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl optionsTabControl;
        private System.Windows.Forms.TabPage matchingTab;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label qualityCountLabel;
        private System.Windows.Forms.TextBox scoreThresholdTextBox;
        private System.Windows.Forms.Label scoreThresholdLabel;
        private System.Windows.Forms.CheckBox useCascaderCheckBox;
        private System.Windows.Forms.NumericUpDown qualityCountNumericUpDown;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.CheckBox useShifterCheckBox;
        private System.Windows.Forms.Label skipsLabel;
        private System.Windows.Forms.NumericUpDown skipsNumericUpDown;
        private System.Windows.Forms.NumericUpDown stepsNumericUpDown;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.NumericUpDown offsetNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}