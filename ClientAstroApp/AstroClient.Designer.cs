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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroClient));
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
            this.btnCalcStarDistance = new System.Windows.Forms.Button();
            this.btnCalcTemperature = new System.Windows.Forms.Button();
            this.btnCalcEventHorizon = new System.Windows.Forms.Button();
            this.btnCalcStarVelocity = new System.Windows.Forms.Button();
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.rbDarkMode = new System.Windows.Forms.RadioButton();
            this.rbLightMode = new System.Windows.Forms.RadioButton();
            this.btnBackColour = new System.Windows.Forms.Button();
            this.btnFontColour = new System.Windows.Forms.Button();
            this.lblEventHorizon = new System.Windows.Forms.Label();
            this.lblStarVelocity = new System.Windows.Forms.Label();
            this.lblStarDistance = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.btnLanguagesEnglish = new System.Windows.Forms.Button();
            this.btnLanguagesFrench = new System.Windows.Forms.Button();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.btnLanguagesGerman = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpColours.SuspendLayout();
            this.grpLanguage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStarVelocity01
            // 
            resources.ApplyResources(this.tbStarVelocity01, "tbStarVelocity01");
            this.tbStarVelocity01.Name = "tbStarVelocity01";
            // 
            // tbStarVelocity02
            // 
            resources.ApplyResources(this.tbStarVelocity02, "tbStarVelocity02");
            this.tbStarVelocity02.Name = "tbStarVelocity02";
            // 
            // tbTemperature
            // 
            resources.ApplyResources(this.tbTemperature, "tbTemperature");
            this.tbTemperature.Name = "tbTemperature";
            // 
            // tbStarDistance
            // 
            resources.ApplyResources(this.tbStarDistance, "tbStarDistance");
            this.tbStarDistance.Name = "tbStarDistance";
            // 
            // tbEventHorizon
            // 
            resources.ApplyResources(this.tbEventHorizon, "tbEventHorizon");
            this.tbEventHorizon.Name = "tbEventHorizon";
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStarVelocity,
            this.colStarDistance,
            this.colTemperature,
            this.colEventHorizon});
            this.lvResults.HideSelection = false;
            resources.ApplyResources(this.lvResults, "lvResults");
            this.lvResults.Name = "lvResults";
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // colStarVelocity
            // 
            resources.ApplyResources(this.colStarVelocity, "colStarVelocity");
            // 
            // colStarDistance
            // 
            resources.ApplyResources(this.colStarDistance, "colStarDistance");
            // 
            // colTemperature
            // 
            resources.ApplyResources(this.colTemperature, "colTemperature");
            // 
            // colEventHorizon
            // 
            resources.ApplyResources(this.colEventHorizon, "colEventHorizon");
            // 
            // btnCalcStarDistance
            // 
            resources.ApplyResources(this.btnCalcStarDistance, "btnCalcStarDistance");
            this.btnCalcStarDistance.Name = "btnCalcStarDistance";
            this.btnCalcStarDistance.UseVisualStyleBackColor = true;
            this.btnCalcStarDistance.Click += new System.EventHandler(this.btnCalcStarDistance_Click);
            // 
            // btnCalcTemperature
            // 
            resources.ApplyResources(this.btnCalcTemperature, "btnCalcTemperature");
            this.btnCalcTemperature.Name = "btnCalcTemperature";
            this.btnCalcTemperature.UseVisualStyleBackColor = true;
            this.btnCalcTemperature.Click += new System.EventHandler(this.btnCalcTemperature_Click);
            // 
            // btnCalcEventHorizon
            // 
            resources.ApplyResources(this.btnCalcEventHorizon, "btnCalcEventHorizon");
            this.btnCalcEventHorizon.Name = "btnCalcEventHorizon";
            this.btnCalcEventHorizon.UseVisualStyleBackColor = true;
            this.btnCalcEventHorizon.Click += new System.EventHandler(this.btnCalcEventHorizon_Click);
            // 
            // btnCalcStarVelocity
            // 
            resources.ApplyResources(this.btnCalcStarVelocity, "btnCalcStarVelocity");
            this.btnCalcStarVelocity.Name = "btnCalcStarVelocity";
            this.btnCalcStarVelocity.UseVisualStyleBackColor = true;
            this.btnCalcStarVelocity.Click += new System.EventHandler(this.btnCalcStarVelocity_Click);
            // 
            // grpColours
            // 
            this.grpColours.Controls.Add(this.rbDarkMode);
            this.grpColours.Controls.Add(this.rbLightMode);
            this.grpColours.Controls.Add(this.btnBackColour);
            this.grpColours.Controls.Add(this.btnFontColour);
            resources.ApplyResources(this.grpColours, "grpColours");
            this.grpColours.Name = "grpColours";
            this.grpColours.TabStop = false;
            // 
            // rbDarkMode
            // 
            resources.ApplyResources(this.rbDarkMode, "rbDarkMode");
            this.rbDarkMode.Checked = true;
            this.rbDarkMode.Name = "rbDarkMode";
            this.rbDarkMode.TabStop = true;
            this.rbDarkMode.UseVisualStyleBackColor = true;
            this.rbDarkMode.CheckedChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // rbLightMode
            // 
            resources.ApplyResources(this.rbLightMode, "rbLightMode");
            this.rbLightMode.Name = "rbLightMode";
            this.rbLightMode.TabStop = true;
            this.rbLightMode.UseVisualStyleBackColor = true;
            this.rbLightMode.CheckedChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // btnBackColour
            // 
            resources.ApplyResources(this.btnBackColour, "btnBackColour");
            this.btnBackColour.Name = "btnBackColour";
            this.btnBackColour.UseVisualStyleBackColor = true;
            this.btnBackColour.Click += new System.EventHandler(this.btnBackColour_Click);
            // 
            // btnFontColour
            // 
            resources.ApplyResources(this.btnFontColour, "btnFontColour");
            this.btnFontColour.Name = "btnFontColour";
            this.btnFontColour.UseVisualStyleBackColor = true;
            this.btnFontColour.Click += new System.EventHandler(this.btnFontColour_Click);
            // 
            // lblEventHorizon
            // 
            resources.ApplyResources(this.lblEventHorizon, "lblEventHorizon");
            this.lblEventHorizon.Name = "lblEventHorizon";
            // 
            // lblStarVelocity
            // 
            resources.ApplyResources(this.lblStarVelocity, "lblStarVelocity");
            this.lblStarVelocity.Name = "lblStarVelocity";
            // 
            // lblStarDistance
            // 
            resources.ApplyResources(this.lblStarDistance, "lblStarDistance");
            this.lblStarDistance.Name = "lblStarDistance";
            // 
            // lblTemperature
            // 
            resources.ApplyResources(this.lblTemperature, "lblTemperature");
            this.lblTemperature.Name = "lblTemperature";
            // 
            // btnLanguagesEnglish
            // 
            resources.ApplyResources(this.btnLanguagesEnglish, "btnLanguagesEnglish");
            this.btnLanguagesEnglish.Name = "btnLanguagesEnglish";
            this.btnLanguagesEnglish.UseVisualStyleBackColor = true;
            this.btnLanguagesEnglish.Click += new System.EventHandler(this.btnLanguagesEnglish_Click);
            // 
            // btnLanguagesFrench
            // 
            resources.ApplyResources(this.btnLanguagesFrench, "btnLanguagesFrench");
            this.btnLanguagesFrench.Name = "btnLanguagesFrench";
            this.btnLanguagesFrench.UseVisualStyleBackColor = true;
            this.btnLanguagesFrench.Click += new System.EventHandler(this.btnLanguagesFrench_Click);
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.btnLanguagesGerman);
            this.grpLanguage.Controls.Add(this.btnLanguagesEnglish);
            this.grpLanguage.Controls.Add(this.btnLanguagesFrench);
            resources.ApplyResources(this.grpLanguage, "grpLanguage");
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.TabStop = false;
            // 
            // btnLanguagesGerman
            // 
            resources.ApplyResources(this.btnLanguagesGerman, "btnLanguagesGerman");
            this.btnLanguagesGerman.Name = "btnLanguagesGerman";
            this.btnLanguagesGerman.UseVisualStyleBackColor = true;
            this.btnLanguagesGerman.Click += new System.EventHandler(this.btnLanguagesGerman_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.languageToolStripMenuItem,
            this.coloursToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // coloursToolStripMenuItem
            // 
            this.coloursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColourToolStripMenuItem,
            this.fontColourToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
            resources.ApplyResources(this.coloursToolStripMenuItem, "coloursToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundColourToolStripMenuItem
            // 
            this.backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            resources.ApplyResources(this.backgroundColourToolStripMenuItem, "backgroundColourToolStripMenuItem");
            this.backgroundColourToolStripMenuItem.Click += new System.EventHandler(this.backgroundColourToolStripMenuItem_Click);
            // 
            // fontColourToolStripMenuItem
            // 
            this.fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            resources.ApplyResources(this.fontColourToolStripMenuItem, "fontColourToolStripMenuItem");
            this.fontColourToolStripMenuItem.Click += new System.EventHandler(this.fontColourToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            resources.ApplyResources(this.modeToolStripMenuItem, "modeToolStripMenuItem");
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            resources.ApplyResources(this.lightModeToolStripMenuItem, "lightModeToolStripMenuItem");
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            resources.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // AstroClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.lblEventHorizon);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblStarDistance);
            this.Controls.Add(this.lblStarVelocity);
            this.Controls.Add(this.grpColours);
            this.Controls.Add(this.btnCalcStarVelocity);
            this.Controls.Add(this.btnCalcEventHorizon);
            this.Controls.Add(this.btnCalcTemperature);
            this.Controls.Add(this.btnCalcStarDistance);
            this.Controls.Add(this.tbStarVelocity01);
            this.Controls.Add(this.tbStarVelocity02);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbStarDistance);
            this.Controls.Add(this.tbEventHorizon);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AstroClient";
            this.grpColours.ResumeLayout(false);
            this.grpColours.PerformLayout();
            this.grpLanguage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnCalcStarDistance;
        private System.Windows.Forms.Button btnCalcTemperature;
        private System.Windows.Forms.Button btnCalcEventHorizon;
        private System.Windows.Forms.Button btnCalcStarVelocity;
        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.Button btnFontColour;
        private System.Windows.Forms.Button btnBackColour;
        private System.Windows.Forms.Label lblStarVelocity;
        private System.Windows.Forms.Label lblEventHorizon;
        private System.Windows.Forms.Label lblStarDistance;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.RadioButton rbDarkMode;
        private System.Windows.Forms.RadioButton rbLightMode;
        private System.Windows.Forms.Button btnLanguagesEnglish;
        private System.Windows.Forms.Button btnLanguagesFrench;
        private System.Windows.Forms.GroupBox grpLanguage;
        private System.Windows.Forms.Button btnLanguagesGerman;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
    }
}

