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
            this.lvResults = new System.Windows.Forms.ListView();
            this.colStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbEventHorizon = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbStarDistance = new System.Windows.Forms.TextBox();
            this.tbStarVelocity01 = new System.Windows.Forms.TextBox();
            this.tbStarVelocity02 = new System.Windows.Forms.TextBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.msstEnglish = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.msstFrench = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.msstGerman = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.mslStarVelocity = new MetroSet_UI.Controls.MetroSetLabel();
            this.mslStarDistance = new MetroSet_UI.Controls.MetroSetLabel();
            this.mslTemperature = new MetroSet_UI.Controls.MetroSetLabel();
            this.mslEventHorizon = new MetroSet_UI.Controls.MetroSetLabel();
            this.msBtnStarVelocity = new MetroSet_UI.Controls.MetroSetButton();
            this.msBtnStarDistance = new MetroSet_UI.Controls.MetroSetButton();
            this.msBtnTemperature = new MetroSet_UI.Controls.MetroSetButton();
            this.msBtnEventHorizon = new MetroSet_UI.Controls.MetroSetButton();
            this.msBtnColour = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetTabControl1.SuspendLayout();
            this.msstEnglish.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStarVelocity,
            this.colStarDistance,
            this.colTemperature,
            this.colEventHorizon});
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(0, 152);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(514, 191);
            this.lvResults.TabIndex = 3;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // colStarVelocity
            // 
            this.colStarVelocity.Text = "Star Velocity";
            this.colStarVelocity.Width = 128;
            // 
            // colStarDistance
            // 
            this.colStarDistance.Text = "Star Distance";
            this.colStarDistance.Width = 129;
            // 
            // colTemperature
            // 
            this.colTemperature.Text = "Temperature in Kelvin";
            this.colTemperature.Width = 135;
            // 
            // colEventHorizon
            // 
            this.colEventHorizon.Text = "Event Horizon";
            this.colEventHorizon.Width = 117;
            // 
            // tbEventHorizon
            // 
            this.tbEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventHorizon.Location = new System.Drawing.Point(393, 65);
            this.tbEventHorizon.Name = "tbEventHorizon";
            this.tbEventHorizon.Size = new System.Drawing.Size(121, 31);
            this.tbEventHorizon.TabIndex = 11;
            this.tbEventHorizon.Text = "8.2e36";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(264, 65);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(123, 31);
            this.tbTemperature.TabIndex = 19;
            this.tbTemperature.Text = "27";
            // 
            // tbStarDistance
            // 
            this.tbStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarDistance.Location = new System.Drawing.Point(135, 65);
            this.tbStarDistance.Name = "tbStarDistance";
            this.tbStarDistance.Size = new System.Drawing.Size(123, 31);
            this.tbStarDistance.TabIndex = 20;
            this.tbStarDistance.Text = "0.547";
            // 
            // tbStarVelocity01
            // 
            this.tbStarVelocity01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarVelocity01.Location = new System.Drawing.Point(0, 65);
            this.tbStarVelocity01.Name = "tbStarVelocity01";
            this.tbStarVelocity01.Size = new System.Drawing.Size(64, 31);
            this.tbStarVelocity01.TabIndex = 21;
            this.tbStarVelocity01.Text = "500.1";
            // 
            // tbStarVelocity02
            // 
            this.tbStarVelocity02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarVelocity02.Location = new System.Drawing.Point(65, 65);
            this.tbStarVelocity02.Name = "tbStarVelocity02";
            this.tbStarVelocity02.Size = new System.Drawing.Size(64, 31);
            this.tbStarVelocity02.TabIndex = 25;
            this.tbStarVelocity02.Text = "500.0";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(440, 12);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 26;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.msstEnglish);
            this.metroSetTabControl1.Controls.Add(this.msstFrench);
            this.metroSetTabControl1.Controls.Add(this.msstGerman);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(15, 92);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(523, 407);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 27;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // msstEnglish
            // 
            this.msstEnglish.BaseColor = System.Drawing.Color.White;
            this.msstEnglish.Controls.Add(this.msBtnEventHorizon);
            this.msstEnglish.Controls.Add(this.msBtnTemperature);
            this.msstEnglish.Controls.Add(this.msBtnStarDistance);
            this.msstEnglish.Controls.Add(this.msBtnStarVelocity);
            this.msstEnglish.Controls.Add(this.mslEventHorizon);
            this.msstEnglish.Controls.Add(this.mslTemperature);
            this.msstEnglish.Controls.Add(this.mslStarDistance);
            this.msstEnglish.Controls.Add(this.mslStarVelocity);
            this.msstEnglish.Controls.Add(this.tbStarVelocity01);
            this.msstEnglish.Controls.Add(this.tbStarVelocity02);
            this.msstEnglish.Controls.Add(this.tbTemperature);
            this.msstEnglish.Controls.Add(this.tbStarDistance);
            this.msstEnglish.Controls.Add(this.tbEventHorizon);
            this.msstEnglish.Controls.Add(this.lvResults);
            this.msstEnglish.Font = null;
            this.msstEnglish.ImageIndex = 0;
            this.msstEnglish.ImageKey = null;
            this.msstEnglish.IsDerivedStyle = true;
            this.msstEnglish.Location = new System.Drawing.Point(4, 42);
            this.msstEnglish.Name = "msstEnglish";
            this.msstEnglish.Size = new System.Drawing.Size(515, 361);
            this.msstEnglish.Style = MetroSet_UI.Enums.Style.Light;
            this.msstEnglish.StyleManager = null;
            this.msstEnglish.TabIndex = 0;
            this.msstEnglish.Text = "English";
            this.msstEnglish.ThemeAuthor = "Narwin";
            this.msstEnglish.ThemeName = "MetroLite";
            this.msstEnglish.ToolTipText = null;
            // 
            // msstFrench
            // 
            this.msstFrench.BaseColor = System.Drawing.Color.White;
            this.msstFrench.Font = null;
            this.msstFrench.ImageIndex = 0;
            this.msstFrench.ImageKey = null;
            this.msstFrench.IsDerivedStyle = true;
            this.msstFrench.Location = new System.Drawing.Point(4, 42);
            this.msstFrench.Name = "msstFrench";
            this.msstFrench.Size = new System.Drawing.Size(515, 361);
            this.msstFrench.Style = MetroSet_UI.Enums.Style.Light;
            this.msstFrench.StyleManager = null;
            this.msstFrench.TabIndex = 1;
            this.msstFrench.Text = "French";
            this.msstFrench.ThemeAuthor = "Narwin";
            this.msstFrench.ThemeName = "MetroLite";
            this.msstFrench.ToolTipText = null;
            // 
            // msstGerman
            // 
            this.msstGerman.BaseColor = System.Drawing.Color.White;
            this.msstGerman.Font = null;
            this.msstGerman.ImageIndex = 0;
            this.msstGerman.ImageKey = null;
            this.msstGerman.IsDerivedStyle = true;
            this.msstGerman.Location = new System.Drawing.Point(4, 42);
            this.msstGerman.Name = "msstGerman";
            this.msstGerman.Size = new System.Drawing.Size(515, 361);
            this.msstGerman.Style = MetroSet_UI.Enums.Style.Light;
            this.msstGerman.StyleManager = null;
            this.msstGerman.TabIndex = 2;
            this.msstGerman.Text = "German";
            this.msstGerman.ThemeAuthor = "Narwin";
            this.msstGerman.ThemeName = "MetroLite";
            this.msstGerman.ToolTipText = null;
            // 
            // mslStarVelocity
            // 
            this.mslStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mslStarVelocity.IsDerivedStyle = true;
            this.mslStarVelocity.Location = new System.Drawing.Point(-4, 21);
            this.mslStarVelocity.Name = "mslStarVelocity";
            this.mslStarVelocity.Size = new System.Drawing.Size(133, 23);
            this.mslStarVelocity.Style = MetroSet_UI.Enums.Style.Light;
            this.mslStarVelocity.StyleManager = null;
            this.mslStarVelocity.TabIndex = 26;
            this.mslStarVelocity.Text = "Star Velocity";
            this.mslStarVelocity.ThemeAuthor = "Narwin";
            this.mslStarVelocity.ThemeName = "MetroLite";
            // 
            // mslStarDistance
            // 
            this.mslStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mslStarDistance.IsDerivedStyle = true;
            this.mslStarDistance.Location = new System.Drawing.Point(135, 21);
            this.mslStarDistance.Name = "mslStarDistance";
            this.mslStarDistance.Size = new System.Drawing.Size(123, 23);
            this.mslStarDistance.Style = MetroSet_UI.Enums.Style.Light;
            this.mslStarDistance.StyleManager = null;
            this.mslStarDistance.TabIndex = 27;
            this.mslStarDistance.Text = "Star Distance";
            this.mslStarDistance.ThemeAuthor = "Narwin";
            this.mslStarDistance.ThemeName = "MetroLite";
            // 
            // mslTemperature
            // 
            this.mslTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mslTemperature.IsDerivedStyle = true;
            this.mslTemperature.Location = new System.Drawing.Point(264, 21);
            this.mslTemperature.Name = "mslTemperature";
            this.mslTemperature.Size = new System.Drawing.Size(123, 23);
            this.mslTemperature.Style = MetroSet_UI.Enums.Style.Light;
            this.mslTemperature.StyleManager = null;
            this.mslTemperature.TabIndex = 28;
            this.mslTemperature.Text = "Temperature";
            this.mslTemperature.ThemeAuthor = "Narwin";
            this.mslTemperature.ThemeName = "MetroLite";
            // 
            // mslEventHorizon
            // 
            this.mslEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mslEventHorizon.IsDerivedStyle = true;
            this.mslEventHorizon.Location = new System.Drawing.Point(393, 21);
            this.mslEventHorizon.Name = "mslEventHorizon";
            this.mslEventHorizon.Size = new System.Drawing.Size(130, 23);
            this.mslEventHorizon.Style = MetroSet_UI.Enums.Style.Light;
            this.mslEventHorizon.StyleManager = null;
            this.mslEventHorizon.TabIndex = 29;
            this.mslEventHorizon.Text = "Event Horizon";
            this.mslEventHorizon.ThemeAuthor = "Narwin";
            this.mslEventHorizon.ThemeName = "MetroLite";
            // 
            // msBtnStarVelocity
            // 
            this.msBtnStarVelocity.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarVelocity.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarVelocity.DisabledForeColor = System.Drawing.Color.Gray;
            this.msBtnStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msBtnStarVelocity.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnStarVelocity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnStarVelocity.HoverTextColor = System.Drawing.Color.White;
            this.msBtnStarVelocity.IsDerivedStyle = true;
            this.msBtnStarVelocity.Location = new System.Drawing.Point(26, 104);
            this.msBtnStarVelocity.Name = "msBtnStarVelocity";
            this.msBtnStarVelocity.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarVelocity.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarVelocity.NormalTextColor = System.Drawing.Color.White;
            this.msBtnStarVelocity.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnStarVelocity.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnStarVelocity.PressTextColor = System.Drawing.Color.White;
            this.msBtnStarVelocity.Size = new System.Drawing.Size(75, 36);
            this.msBtnStarVelocity.Style = MetroSet_UI.Enums.Style.Light;
            this.msBtnStarVelocity.StyleManager = null;
            this.msBtnStarVelocity.TabIndex = 30;
            this.msBtnStarVelocity.Text = "Calculate";
            this.msBtnStarVelocity.ThemeAuthor = "Narwin";
            this.msBtnStarVelocity.ThemeName = "MetroLite";
            this.msBtnStarVelocity.Click += new System.EventHandler(this.btnCalcStarVelocity_Click);
            // 
            // msBtnStarDistance
            // 
            this.msBtnStarDistance.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarDistance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarDistance.DisabledForeColor = System.Drawing.Color.Gray;
            this.msBtnStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msBtnStarDistance.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnStarDistance.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnStarDistance.HoverTextColor = System.Drawing.Color.White;
            this.msBtnStarDistance.IsDerivedStyle = true;
            this.msBtnStarDistance.Location = new System.Drawing.Point(158, 104);
            this.msBtnStarDistance.Name = "msBtnStarDistance";
            this.msBtnStarDistance.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarDistance.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnStarDistance.NormalTextColor = System.Drawing.Color.White;
            this.msBtnStarDistance.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnStarDistance.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnStarDistance.PressTextColor = System.Drawing.Color.White;
            this.msBtnStarDistance.Size = new System.Drawing.Size(75, 36);
            this.msBtnStarDistance.Style = MetroSet_UI.Enums.Style.Light;
            this.msBtnStarDistance.StyleManager = null;
            this.msBtnStarDistance.TabIndex = 31;
            this.msBtnStarDistance.Text = "Calculate";
            this.msBtnStarDistance.ThemeAuthor = "Narwin";
            this.msBtnStarDistance.ThemeName = "MetroLite";
            this.msBtnStarDistance.Click += new System.EventHandler(this.btnCalcStarDistance_Click);
            // 
            // msBtnTemperature
            // 
            this.msBtnTemperature.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnTemperature.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnTemperature.DisabledForeColor = System.Drawing.Color.Gray;
            this.msBtnTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msBtnTemperature.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnTemperature.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnTemperature.HoverTextColor = System.Drawing.Color.White;
            this.msBtnTemperature.IsDerivedStyle = true;
            this.msBtnTemperature.Location = new System.Drawing.Point(292, 104);
            this.msBtnTemperature.Name = "msBtnTemperature";
            this.msBtnTemperature.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnTemperature.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnTemperature.NormalTextColor = System.Drawing.Color.White;
            this.msBtnTemperature.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnTemperature.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnTemperature.PressTextColor = System.Drawing.Color.White;
            this.msBtnTemperature.Size = new System.Drawing.Size(75, 36);
            this.msBtnTemperature.Style = MetroSet_UI.Enums.Style.Light;
            this.msBtnTemperature.StyleManager = null;
            this.msBtnTemperature.TabIndex = 32;
            this.msBtnTemperature.Text = "Calculate";
            this.msBtnTemperature.ThemeAuthor = "Narwin";
            this.msBtnTemperature.ThemeName = "MetroLite";
            this.msBtnTemperature.Click += new System.EventHandler(this.btnCalcTemperature_Click);
            // 
            // msBtnEventHorizon
            // 
            this.msBtnEventHorizon.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnEventHorizon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnEventHorizon.DisabledForeColor = System.Drawing.Color.Gray;
            this.msBtnEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msBtnEventHorizon.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnEventHorizon.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.msBtnEventHorizon.HoverTextColor = System.Drawing.Color.White;
            this.msBtnEventHorizon.IsDerivedStyle = true;
            this.msBtnEventHorizon.Location = new System.Drawing.Point(418, 104);
            this.msBtnEventHorizon.Name = "msBtnEventHorizon";
            this.msBtnEventHorizon.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnEventHorizon.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msBtnEventHorizon.NormalTextColor = System.Drawing.Color.White;
            this.msBtnEventHorizon.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnEventHorizon.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.msBtnEventHorizon.PressTextColor = System.Drawing.Color.White;
            this.msBtnEventHorizon.Size = new System.Drawing.Size(75, 36);
            this.msBtnEventHorizon.Style = MetroSet_UI.Enums.Style.Light;
            this.msBtnEventHorizon.StyleManager = null;
            this.msBtnEventHorizon.TabIndex = 33;
            this.msBtnEventHorizon.Text = "Calculate";
            this.msBtnEventHorizon.ThemeAuthor = "Narwin";
            this.msBtnEventHorizon.ThemeName = "MetroLite";
            this.msBtnEventHorizon.Click += new System.EventHandler(this.btnCalcEventHorizon_Click);
            // 
            // msBtnColour
            // 
            this.msBtnColour.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msBtnColour.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.msBtnColour.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.msBtnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.msBtnColour.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msBtnColour.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.msBtnColour.HoverTextColor = System.Drawing.Color.White;
            this.msBtnColour.IsDerivedStyle = true;
            this.msBtnColour.Location = new System.Drawing.Point(225, 39);
            this.msBtnColour.Name = "msBtnColour";
            this.msBtnColour.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.msBtnColour.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.msBtnColour.NormalTextColor = System.Drawing.Color.Black;
            this.msBtnColour.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msBtnColour.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.msBtnColour.PressTextColor = System.Drawing.Color.White;
            this.msBtnColour.Size = new System.Drawing.Size(75, 23);
            this.msBtnColour.Style = MetroSet_UI.Enums.Style.Light;
            this.msBtnColour.StyleManager = null;
            this.msBtnColour.TabIndex = 28;
            this.msBtnColour.Text = "Colour";
            this.msBtnColour.ThemeAuthor = "Narwin";
            this.msBtnColour.ThemeName = "MetroLite";
            this.msBtnColour.Click += new System.EventHandler(this.msBtnColour_Click);
            // 
            // AstroClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 508);
            this.Controls.Add(this.msBtnColour);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "AstroClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astro Client";
            this.metroSetTabControl1.ResumeLayout(false);
            this.msstEnglish.ResumeLayout(false);
            this.msstEnglish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.TextBox tbEventHorizon;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbStarDistance;
        private System.Windows.Forms.TextBox tbStarVelocity01;
        private System.Windows.Forms.TextBox tbStarVelocity02;
        private System.Windows.Forms.ColumnHeader colStarVelocity;
        private System.Windows.Forms.ColumnHeader colStarDistance;
        private System.Windows.Forms.ColumnHeader colTemperature;
        private System.Windows.Forms.ColumnHeader colEventHorizon;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage msstEnglish;
        private MetroSet_UI.Child.MetroSetSetTabPage msstFrench;
        private MetroSet_UI.Child.MetroSetSetTabPage msstGerman;
        private MetroSet_UI.Controls.MetroSetLabel mslStarVelocity;
        private MetroSet_UI.Controls.MetroSetLabel mslTemperature;
        private MetroSet_UI.Controls.MetroSetLabel mslStarDistance;
        private MetroSet_UI.Controls.MetroSetButton msBtnEventHorizon;
        private MetroSet_UI.Controls.MetroSetButton msBtnTemperature;
        private MetroSet_UI.Controls.MetroSetButton msBtnStarDistance;
        private MetroSet_UI.Controls.MetroSetButton msBtnStarVelocity;
        private MetroSet_UI.Controls.MetroSetLabel mslEventHorizon;
        private MetroSet_UI.Controls.MetroSetDefaultButton msBtnColour;
    }
}

