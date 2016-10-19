using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WhiskerPrint.PresentationLayer
{
    public partial class OptionsDialog : Form
    {
        public OptionsDialog(OptionsSettings settings)
        {
            InitializeComponent();

            _settings = settings;

            Binding useCascader = new Binding("Checked", _settings, "UseCascader");
            useCascaderCheckBox.DataBindings.Add(useCascader);

            Binding cascaderThreshold = new Binding("Text", _settings, "CascaderThreshold");
            scoreThresholdTextBox.DataBindings.Add(cascaderThreshold);

            Binding cascaderQualityLevelCount = new Binding("Value", _settings, "CascaderQualityLevelCount");
            qualityCountNumericUpDown.DataBindings.Add(cascaderQualityLevelCount);

            Binding cascaderSkipsPerQualityLevel = new Binding("Value", _settings, "CascaderSkipsPerQualityLevel");
            skipsNumericUpDown.DataBindings.Add(cascaderSkipsPerQualityLevel);

            Binding useShifter = new Binding("Checked", _settings, "UseShifter");
            useShifterCheckBox.DataBindings.Add(useShifter);

            Binding shifterOffset = new Binding("Value", _settings, "ShifterOffset");
            offsetNumericUpDown.DataBindings.Add(shifterOffset);

            Binding shifterSteps = new Binding("Value", _settings, "ShifterSteps");
            stepsNumericUpDown.DataBindings.Add(shifterSteps);
        }

        private void OptionsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadSettings();
        }
        private void useCascaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useCascaderCheckBox.Checked)
            {
                scoreThresholdLabel.Enabled = 
                scoreThresholdTextBox.Enabled = 
                qualityCountLabel.Enabled = 
                qualityCountNumericUpDown.Enabled = 
                skipsLabel.Enabled = 
                skipsNumericUpDown.Enabled = true;
            }
            else
            {
                scoreThresholdLabel.Enabled =
                scoreThresholdTextBox.Enabled =
                qualityCountLabel.Enabled =
                qualityCountNumericUpDown.Enabled =
                skipsLabel.Enabled =
                skipsNumericUpDown.Enabled = false;
            }
        }
        private void useShifterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useShifterCheckBox.Checked)
            {
                offsetLabel.Enabled =
                offsetNumericUpDown.Enabled =
                stepsLabel.Enabled =
                stepsNumericUpDown.Enabled = true;
            }
            else
            {
                offsetLabel.Enabled =
                offsetNumericUpDown.Enabled =
                stepsLabel.Enabled =
                stepsNumericUpDown.Enabled = false;
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
        private void scoreThresholdTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double.Parse(scoreThresholdTextBox.Text);
                errorProvider.SetError(scoreThresholdTextBox, "");
            }
            catch
            {
                errorProvider.SetError(scoreThresholdTextBox, "Value must be a decimal number.");
                e.Cancel = true;
            }
        }
        
        private void SaveSettings()
        {
            _settings.Save();
        }
        private void ReloadSettings()
        {
            _settings.Reload();
        }

        private OptionsSettings _settings;


    }
}