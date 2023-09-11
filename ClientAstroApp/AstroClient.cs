using System;
using System.Diagnostics;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AstroMath;
using MetroSet_UI.Forms;

namespace ClientAstroApp
{
    public partial class AstroClient : MetroSetForm
    {

        // Mauriza Arianne P252069
        // AT2

        private IAstroContract channel; // Declare the channel as a member of the class

        public AstroClient()
        {
            InitializeComponent();
            InitializeChannel(); // Initialize the channel when the form is created
        }

        private void InitializeChannel()
        {
            string address = "net.pipe://localhost/astroserver";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);

            // Create the channel using ChannelFactory and store it in the member variable
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

        public void AddToListView(int columnNumber, string value)
        {

            bool valueAdded = false;

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


        private void btnCalcStarVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbStarVelocity01.Text) || string.IsNullOrWhiteSpace(tbStarVelocity02.Text))
                {
                    MessageBox.Show("Please enter values in both fields.");
                    return;
                }

                double val1 = Convert.ToDouble(tbStarVelocity01.Text);
                double val2 = Convert.ToDouble(tbStarVelocity02.Text);
                double result = channel.StarVelocity(val1, val2);

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
                if (string.IsNullOrWhiteSpace(tbStarDistance.Text))
                {
                    MessageBox.Show("Please enter a value.");
                    return;
                }

                double value = Convert.ToDouble(tbStarDistance.Text);
                double result = channel.StarDistance(value);

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

        private void msBtnColour_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Set the initial color to the current form's background color
                colorDialog.Color = this.BackColor;

                // Show the color dialog and get the result
                DialogResult result = colorDialog.ShowDialog();

                // If the user clicked OK, change the form's background color to the selected color
                if (result == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                    tbStarDistance.Text = this.BackColor.ToString();
                }
            }

        }
    }
}
