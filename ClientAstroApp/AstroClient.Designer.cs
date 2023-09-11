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
            this.btnGerman = new System.Windows.Forms.Button();
            this.btnFrench = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.colStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCalcEventHorizon = new System.Windows.Forms.Button();
            this.tbEventHorizon = new System.Windows.Forms.TextBox();
            this.btnColours = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStarDistance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbStarDistance = new System.Windows.Forms.TextBox();
            this.tbStarVelocity01 = new System.Windows.Forms.TextBox();
            this.btnCalcTemperature = new System.Windows.Forms.Button();
            this.btnCalcStarDistance = new System.Windows.Forms.Button();
            this.btnCalcStarVelocity = new System.Windows.Forms.Button();
            this.tbStarVelocity02 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerman
            // 
            this.btnGerman.Location = new System.Drawing.Point(144, 12);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(60, 54);
            this.btnGerman.TabIndex = 0;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            // 
            // btnFrench
            // 
            this.btnFrench.Location = new System.Drawing.Point(78, 12);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(60, 54);
            this.btnFrench.TabIndex = 1;
            this.btnFrench.Text = "French";
            this.btnFrench.UseVisualStyleBackColor = true;
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(12, 12);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(60, 54);
            this.btnEnglish.TabIndex = 2;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStarVelocity,
            this.colStarDistance,
            this.colTemperature,
            this.colEventHorizon});
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(12, 208);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(519, 230);
            this.lvResults.TabIndex = 3;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // colStarVelocity
            // 
            this.colStarVelocity.Text = "Star Velocity";
            // 
            // colStarDistance
            // 
            this.colStarDistance.Text = "Star Distance";
            // 
            // colTemperature
            // 
            this.colTemperature.Text = "Temperature in Kelvin";
            // 
            // colEventHorizon
            // 
            this.colEventHorizon.Text = "Event Horizon";
            // 
            // btnCalcEventHorizon
            // 
            this.btnCalcEventHorizon.Location = new System.Drawing.Point(426, 164);
            this.btnCalcEventHorizon.Name = "btnCalcEventHorizon";
            this.btnCalcEventHorizon.Size = new System.Drawing.Size(89, 38);
            this.btnCalcEventHorizon.TabIndex = 12;
            this.btnCalcEventHorizon.Text = "Calculate";
            this.btnCalcEventHorizon.UseVisualStyleBackColor = true;
            this.btnCalcEventHorizon.Click += new System.EventHandler(this.btnCalcEventHorizon_Click);
            // 
            // tbEventHorizon
            // 
            this.tbEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventHorizon.Location = new System.Drawing.Point(408, 127);
            this.tbEventHorizon.Name = "tbEventHorizon";
            this.tbEventHorizon.Size = new System.Drawing.Size(121, 31);
            this.tbEventHorizon.TabIndex = 11;
            this.tbEventHorizon.Text = "8.2e36";
            // 
            // btnColours
            // 
            this.btnColours.Location = new System.Drawing.Point(454, 12);
            this.btnColours.Name = "btnColours";
            this.btnColours.Size = new System.Drawing.Size(75, 63);
            this.btnColours.TabIndex = 13;
            this.btnColours.Text = "Colours";
            this.btnColours.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Star Velocity";
            // 
            // lbStarDistance
            // 
            this.lbStarDistance.AutoSize = true;
            this.lbStarDistance.Location = new System.Drawing.Point(147, 93);
            this.lbStarDistance.Name = "lbStarDistance";
            this.lbStarDistance.Size = new System.Drawing.Size(71, 13);
            this.lbStarDistance.TabIndex = 15;
            this.lbStarDistance.Text = "Star Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperature in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Event Horizon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kelvin";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(279, 127);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(123, 31);
            this.tbTemperature.TabIndex = 19;
            this.tbTemperature.Text = "27";
            // 
            // tbStarDistance
            // 
            this.tbStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarDistance.Location = new System.Drawing.Point(150, 127);
            this.tbStarDistance.Name = "tbStarDistance";
            this.tbStarDistance.Size = new System.Drawing.Size(123, 31);
            this.tbStarDistance.TabIndex = 20;
            this.tbStarDistance.Text = "0.547";
            // 
            // tbStarVelocity01
            // 
            this.tbStarVelocity01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarVelocity01.Location = new System.Drawing.Point(12, 127);
            this.tbStarVelocity01.Name = "tbStarVelocity01";
            this.tbStarVelocity01.Size = new System.Drawing.Size(60, 31);
            this.tbStarVelocity01.TabIndex = 21;
            this.tbStarVelocity01.Text = "500.1";
            // 
            // btnCalcTemperature
            // 
            this.btnCalcTemperature.Location = new System.Drawing.Point(292, 164);
            this.btnCalcTemperature.Name = "btnCalcTemperature";
            this.btnCalcTemperature.Size = new System.Drawing.Size(89, 38);
            this.btnCalcTemperature.TabIndex = 22;
            this.btnCalcTemperature.Text = "Calculate";
            this.btnCalcTemperature.UseVisualStyleBackColor = true;
            this.btnCalcTemperature.Click += new System.EventHandler(this.btnCalcTemperature_Click);
            // 
            // btnCalcStarDistance
            // 
            this.btnCalcStarDistance.Location = new System.Drawing.Point(167, 164);
            this.btnCalcStarDistance.Name = "btnCalcStarDistance";
            this.btnCalcStarDistance.Size = new System.Drawing.Size(89, 38);
            this.btnCalcStarDistance.TabIndex = 23;
            this.btnCalcStarDistance.Text = "Calculate";
            this.btnCalcStarDistance.UseVisualStyleBackColor = true;
            this.btnCalcStarDistance.Click += new System.EventHandler(this.btnCalcStarDistance_Click);
            // 
            // btnCalcStarVelocity
            // 
            this.btnCalcStarVelocity.Location = new System.Drawing.Point(28, 164);
            this.btnCalcStarVelocity.Name = "btnCalcStarVelocity";
            this.btnCalcStarVelocity.Size = new System.Drawing.Size(89, 38);
            this.btnCalcStarVelocity.TabIndex = 24;
            this.btnCalcStarVelocity.Text = "Calculate";
            this.btnCalcStarVelocity.UseVisualStyleBackColor = true;
            this.btnCalcStarVelocity.Click += new System.EventHandler(this.btnCalcStarVelocity_Click);
            // 
            // tbStarVelocity02
            // 
            this.tbStarVelocity02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarVelocity02.Location = new System.Drawing.Point(78, 127);
            this.tbStarVelocity02.Name = "tbStarVelocity02";
            this.tbStarVelocity02.Size = new System.Drawing.Size(60, 31);
            this.tbStarVelocity02.TabIndex = 25;
            this.tbStarVelocity02.Text = "500";
            // 
            // AstroClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.tbStarVelocity02);
            this.Controls.Add(this.btnCalcStarVelocity);
            this.Controls.Add(this.btnCalcStarDistance);
            this.Controls.Add(this.btnCalcTemperature);
            this.Controls.Add(this.tbStarVelocity01);
            this.Controls.Add(this.tbStarDistance);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbStarDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColours);
            this.Controls.Add(this.btnCalcEventHorizon);
            this.Controls.Add(this.tbEventHorizon);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnFrench);
            this.Controls.Add(this.btnGerman);
            this.Name = "AstroClient";
            this.Text = "Astro Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.Button btnFrench;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.Button btnCalcEventHorizon;
        private System.Windows.Forms.TextBox tbEventHorizon;
        private System.Windows.Forms.Button btnColours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStarDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbStarDistance;
        private System.Windows.Forms.TextBox tbStarVelocity01;
        private System.Windows.Forms.Button btnCalcTemperature;
        private System.Windows.Forms.Button btnCalcStarDistance;
        private System.Windows.Forms.Button btnCalcStarVelocity;
        private System.Windows.Forms.TextBox tbStarVelocity02;
        private System.Windows.Forms.ColumnHeader colStarVelocity;
        private System.Windows.Forms.ColumnHeader colStarDistance;
        private System.Windows.Forms.ColumnHeader colTemperature;
        private System.Windows.Forms.ColumnHeader colEventHorizon;
    }
}

