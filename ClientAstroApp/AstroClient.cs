using System;
using System.Diagnostics;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AstroMath;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace ClientAstroApp
{
    public partial class AstroClient : Form
    {

        // Mauriza Arianne P252069
        // AT2

        private IAstroContract channel;

        public AstroClient()
        {
            InitializeComponent();
            InitializeChannel();
            ApplyDarkModeToControls(this);
        }

        private void InitializeChannel()
        {
            string address = "net.pipe://localhost/astroserver";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);

            channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
        }

        /// <summary>
        /// Develop a Windows Forms Application client so users can send raw data to the server and receive processed information. 
        /// There are four major tasks in this Question.
        //1.	Create the ServiceContract called “IAstroContract.cs” which will need to be identical to the server without a reference to the AstroMath.DLL.
        //2.	Create a form with suitable components for UI,
        //a.Series of textboxes for large numeric data,
        //b.A listview/datagrid for display of processed information from the server,
        //c.Button(s) to initiate an event and send/receive data.
        //3.	Menu/Button option(s) to change the language and layout for the three different countries.
        //4.	Menu option to change the form’s style (colours and visual appearance).
        //5.	Menu/Button option to select a custom background colour from a colour palette(Color Dialogbox)


        #region Methods

        public void AddToListView(int columnNumber, string value)
        {

            bool valueAdded = false;
            // loop through and see if entry is emptry string
            // if it is replace it with value
            foreach (ListViewItem item in lvResults.Items)
            {
                if (string.IsNullOrEmpty(item.SubItems[columnNumber - 1].Text))
                {
                    item.SubItems[columnNumber - 1].Text = value;
                    valueAdded = true;
                    break;
                }
            }

            if (!valueAdded)
            {
                ListViewItem newItem = new ListViewItem(new string[4]);
                newItem.SubItems[columnNumber - 1].Text = value;
                lvResults.Items.Add(newItem);
            }
        }

        #region Clicks
        private void btnCalcStarVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                // check if both are empty
                if (string.IsNullOrWhiteSpace(tbStarVelocity01.Text) || string.IsNullOrWhiteSpace(tbStarVelocity02.Text))
                {
                    MessageBox.Show("Please enter values in both fields.");
                    return;
                }
                // convert to double
                double val1 = Convert.ToDouble(tbStarVelocity01.Text);
                double val2 = Convert.ToDouble(tbStarVelocity02.Text);
                double result = channel.StarVelocity(val1, val2);
                // add to lv
                AddToListView(1, result.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        private void btnCalcStarDistance_Click(object sender, EventArgs e)
        {
            try
            {
                // check empty
                if (string.IsNullOrWhiteSpace(tbStarDistance.Text))
                {
                    MessageBox.Show("Please enter a value.");
                    return;
                }

                double value = Convert.ToDouble(tbStarDistance.Text);
                double result = channel.StarDistance(value);
                // add
                AddToListView(2, result.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void btnCalcTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                // same
                if (string.IsNullOrWhiteSpace(tbTemperature.Text))
                {
                    MessageBox.Show("Please enter a value.");
                    return;
                }

                int value = Convert.ToInt32(tbTemperature.Text);
                double result = channel.TempInKelvin(value);

                AddToListView(3, result.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void btnCalcEventHorizon_Click(object sender, EventArgs e)
        {
            try
            {
                // same
                if (string.IsNullOrWhiteSpace(tbEventHorizon.Text))
                {
                    MessageBox.Show("Please enter a value.");
                    return;
                }

                double value = Convert.ToDouble(tbEventHorizon.Text);
                double result = channel.EventHorizon(value);

                AddToListView(4, result.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }
        #endregion

        #endregion

        #region Colours
        private void btnBackColour_Click(object sender, EventArgs e)
        {
            // use using so it closes correctly
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // add current colour
                colorDialog.Color = this.BackColor;

                DialogResult result = colorDialog.ShowDialog();
                // if ok change to selected colour
                if (result == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }
        private void btnFontColour_Click(object sender, EventArgs e)
        {
            // same basically
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = this.ForeColor;

                DialogResult result = colorDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.ForeColor = colorDialog.Color;
                }
            }
        }

        private void ChangeTheme(object sender, EventArgs e)
        {
            // if checked go to func
            if (rbLightMode.Checked == true)
            {
                ApplyLightModeToControls(this);
            }
            else if (rbDarkMode.Checked == true)
            {
                ApplyDarkModeToControls(this);
            }
        }
        private void ApplyLightModeToControls(Control control)
        {
            // change everything
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ForeColor = Color.FromArgb(41, 128, 185);
            lvResults.BackColor = Color.FromArgb(250, 250, 250);
            lvResults.ForeColor = Color.FromArgb(41, 128, 185);
            grpColours.ForeColor = Color.FromArgb(41, 128, 185);
            grpLanguage.ForeColor = Color.FromArgb(41, 128, 185);

            // loop through all buttons and change colour
            foreach (Control childControl in control.Controls)
            {

                if (childControl is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)childControl;
                    button.BackColor = Color.FromArgb(220, 220, 220);
                    button.ForeColor = Color.FromArgb(41, 128, 185);
                }

                ApplyLightModeToControls(childControl);
            }
        }
        private void ApplyDarkModeToControls(Control control)
        {
            // same
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            lvResults.BackColor = Color.FromArgb(50, 50, 50);
            lvResults.ForeColor = Color.White;
            grpColours.ForeColor = Color.White;
            grpLanguage.ForeColor = Color.White;

            foreach (Control childControl in control.Controls)
            {
                if (childControl is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)childControl;
                    button.BackColor = Color.FromArgb(50, 50, 50);
                    button.ForeColor = Color.White;
                }

                ApplyDarkModeToControls(childControl);
            }
        }

        #endregion

        #region Languages
        private void btnLanguagesFrench_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            Controls.Clear();
            InitializeComponent();
            if (rbLightMode.Checked == true)
            {
                ApplyLightModeToControls(this);
            }
            else if (rbDarkMode.Checked == true)
            {
                ApplyDarkModeToControls(this);
            }
            else
            {
                ApplyDarkModeToControls(this);
            }
        }

        private void btnLanguagesEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
            if (rbLightMode.Checked == true)
            {
                ApplyLightModeToControls(this);
            }
            else if (rbDarkMode.Checked == true)
            {
                ApplyDarkModeToControls(this);
            }
            else
            {
                ApplyDarkModeToControls(this);
            }
        }

        #endregion

        private void btnLanguagesGerman_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            Controls.Clear();
            InitializeComponent();
            if (rbLightMode.Checked == true)
            {
                ApplyLightModeToControls(this);
            }
            else if (rbDarkMode.Checked == true)
            {
                ApplyDarkModeToControls(this);
            }
            else
            {
                ApplyDarkModeToControls(this);
            }
        }
    }

}
