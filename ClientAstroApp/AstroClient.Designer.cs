namespace ClientAstroApp
{
    partial class AstroClient
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
            this.tbStarVelocity01 = new System.Windows.Forms.TextBox();
            this.tbStarVelocity02 = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbStarDistance = new System.Windows.Forms.TextBox();
            this.tbEventHorizon = new System.Windows.Forms.TextBox();
            this.lvResults = new System.Windows.Forms.ListView();
            this.colStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackColour = new System.Windows.Forms.Button();
            this.btnFontColour = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbLightMode = new System.Windows.Forms.RadioButton();
            this.rbDarkMode = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStarVelocity01
            // 
            this.tbStarVelocity01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarVelocity01.Location = new System.Drawing.Point(15, 115);
            this.tbStarVelocity01.Margin = new System.Windows.Forms.Padding(2);
            this.tbStarVelocity01.Name = "tbStarVelocity01";
            this.tbStarVelocity01.Size = new System.Drawing.Size(61, 31);
            this.tbStarVelocity01.TabIndex = 38;
            this.tbStarVelocity01.Text = "500.1";
            // 
            // tbStarVelocity02
            // 
            this.tbStarVelocity02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarVelocity02.Location = new System.Drawing.Point(80, 115);
            this.tbStarVelocity02.Margin = new System.Windows.Forms.Padding(2);
            this.tbStarVelocity02.Name = "tbStarVelocity02";
            this.tbStarVelocity02.Size = new System.Drawing.Size(65, 31);
            this.tbStarVelocity02.TabIndex = 39;
            this.tbStarVelocity02.Text = "500.0";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(281, 115);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(128, 31);
            this.tbTemperature.TabIndex = 36;
            this.tbTemperature.Text = "27";
            // 
            // tbStarDistance
            // 
            this.tbStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarDistance.Location = new System.Drawing.Point(149, 115);
            this.tbStarDistance.Margin = new System.Windows.Forms.Padding(2);
            this.tbStarDistance.Name = "tbStarDistance";
            this.tbStarDistance.Size = new System.Drawing.Size(128, 31);
            this.tbStarDistance.TabIndex = 37;
            this.tbStarDistance.Text = "0.547";
            // 
            // tbEventHorizon
            // 
            this.tbEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventHorizon.Location = new System.Drawing.Point(413, 115);
            this.tbEventHorizon.Margin = new System.Windows.Forms.Padding(2);
            this.tbEventHorizon.Name = "tbEventHorizon";
            this.tbEventHorizon.Size = new System.Drawing.Size(128, 31);
            this.tbEventHorizon.TabIndex = 35;
            this.tbEventHorizon.Text = "8.2e36";
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStarVelocity,
            this.colStarDistance,
            this.colTemperature,
            this.colEventHorizon});
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(15, 213);
            this.lvResults.Margin = new System.Windows.Forms.Padding(2);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(526, 252);
            this.lvResults.TabIndex = 34;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // colStarVelocity
            // 
            this.colStarVelocity.Text = "Star Velocity";
            this.colStarVelocity.Width = 131;
            // 
            // colStarDistance
            // 
            this.colStarDistance.Text = "Star Distance";
            this.colStarDistance.Width = 133;
            // 
            // colTemperature
            // 
            this.colTemperature.Text = "Temperature in Kelvin";
            this.colTemperature.Width = 129;
            // 
            // colEventHorizon
            // 
            this.colEventHorizon.Text = "Event Horizon";
            this.colEventHorizon.Width = 124;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 41;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCalcStarDistance_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 42;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCalcTemperature_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 43;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalcEventHorizon_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 42);
            this.button4.TabIndex = 44;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnCalcStarVelocity_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDarkMode);
            this.groupBox1.Controls.Add(this.rbLightMode);
            this.groupBox1.Controls.Add(this.btnBackColour);
            this.groupBox1.Controls.Add(this.btnFontColour);
            this.groupBox1.Location = new System.Drawing.Point(317, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 76);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colours";
            // 
            // btnBackColour
            // 
            this.btnBackColour.Location = new System.Drawing.Point(6, 19);
            this.btnBackColour.Name = "btnBackColour";
            this.btnBackColour.Size = new System.Drawing.Size(116, 23);
            this.btnBackColour.TabIndex = 3;
            this.btnBackColour.Text = "Background Colour";
            this.btnBackColour.UseVisualStyleBackColor = true;
            this.btnBackColour.Click += new System.EventHandler(this.btnBackColour_Click);
            // 
            // btnFontColour
            // 
            this.btnFontColour.Location = new System.Drawing.Point(6, 47);
            this.btnFontColour.Name = "btnFontColour";
            this.btnFontColour.Size = new System.Drawing.Size(116, 23);
            this.btnFontColour.TabIndex = 2;
            this.btnFontColour.Text = "Font Colour";
            this.btnFontColour.UseVisualStyleBackColor = true;
            this.btnFontColour.Click += new System.EventHandler(this.btnFontColour_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Event Horizon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Star Velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "TODO ADD LANGUAGES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Star Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Temperature";
            // 
            // rbLightMode
            // 
            this.rbLightMode.AutoSize = true;
            this.rbLightMode.Location = new System.Drawing.Point(128, 22);
            this.rbLightMode.Name = "rbLightMode";
            this.rbLightMode.Size = new System.Drawing.Size(78, 17);
            this.rbLightMode.TabIndex = 4;
            this.rbLightMode.TabStop = true;
            this.rbLightMode.Text = "Light Mode";
            this.rbLightMode.UseVisualStyleBackColor = true;
            this.rbLightMode.CheckedChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // rbDarkMode
            // 
            this.rbDarkMode.AutoSize = true;
            this.rbDarkMode.Location = new System.Drawing.Point(129, 49);
            this.rbDarkMode.Name = "rbDarkMode";
            this.rbDarkMode.Size = new System.Drawing.Size(78, 17);
            this.rbDarkMode.TabIndex = 5;
            this.rbDarkMode.TabStop = true;
            this.rbDarkMode.Text = "Dark Mode";
            this.rbDarkMode.UseVisualStyleBackColor = true;
            this.rbDarkMode.CheckedChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // AstroClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 476);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbStarVelocity01);
            this.Controls.Add(this.tbStarVelocity02);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbStarDistance);
            this.Controls.Add(this.tbEventHorizon);
            this.Controls.Add(this.lvResults);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AstroClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astro Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbStarVelocity01;
        private System.Windows.Forms.TextBox tbStarVelocity02;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbStarDistance;
        private System.Windows.Forms.TextBox tbEventHorizon;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader colStarVelocity;
        private System.Windows.Forms.ColumnHeader colStarDistance;
        private System.Windows.Forms.ColumnHeader colTemperature;
        private System.Windows.Forms.ColumnHeader colEventHorizon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFontColour;
        private System.Windows.Forms.Button btnBackColour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDarkMode;
        private System.Windows.Forms.RadioButton rbLightMode;
    }
}

