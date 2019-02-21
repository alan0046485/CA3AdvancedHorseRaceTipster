namespace CA3AdvancedHorseRaceTipster
{
    partial class Form1
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
            this.lblBet = new System.Windows.Forms.Label();
            this.lblRacecourse = new System.Windows.Forms.Label();
            this.lblHorse = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtRacecourse = new System.Windows.Forms.TextBox();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.SystemColors.Control;
            this.lblBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBet.Location = new System.Drawing.Point(213, 19);
            this.lblBet.Name = "lblBet";
            this.lblBet.Padding = new System.Windows.Forms.Padding(2);
            this.lblBet.Size = new System.Drawing.Size(156, 26);
            this.lblBet.TabIndex = 0;
            this.lblBet.Text = "Please enter a bet:";
            // 
            // lblRacecourse
            // 
            this.lblRacecourse.AutoSize = true;
            this.lblRacecourse.BackColor = System.Drawing.SystemColors.Control;
            this.lblRacecourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRacecourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRacecourse.Location = new System.Drawing.Point(237, 66);
            this.lblRacecourse.Name = "lblRacecourse";
            this.lblRacecourse.Padding = new System.Windows.Forms.Padding(2);
            this.lblRacecourse.Size = new System.Drawing.Size(110, 26);
            this.lblRacecourse.TabIndex = 1;
            this.lblRacecourse.Text = "Racecourse:";
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.BackColor = System.Drawing.SystemColors.Control;
            this.lblHorse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHorse.Location = new System.Drawing.Point(237, 112);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Padding = new System.Windows.Forms.Padding(2);
            this.lblHorse.Size = new System.Drawing.Size(115, 26);
            this.lblHorse.TabIndex = 2;
            this.lblHorse.Text = "Horse Name:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.SystemColors.Control;
            this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDistance.Location = new System.Drawing.Point(237, 199);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Padding = new System.Windows.Forms.Padding(2);
            this.lblDistance.Size = new System.Drawing.Size(87, 26);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "Distance:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Control;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.Location = new System.Drawing.Point(237, 240);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(2);
            this.lblResult.Size = new System.Drawing.Size(68, 26);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBet.Location = new System.Drawing.Point(29, 19);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(160, 46);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "Enter a bet!";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(237, 155);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(2);
            this.lblDate.Size = new System.Drawing.Size(56, 26);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // txtRacecourse
            // 
            this.txtRacecourse.Location = new System.Drawing.Point(390, 69);
            this.txtRacecourse.Name = "txtRacecourse";
            this.txtRacecourse.Size = new System.Drawing.Size(183, 22);
            this.txtRacecourse.TabIndex = 8;
            // 
            // txtHorseName
            // 
            this.txtHorseName.Location = new System.Drawing.Point(390, 116);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(183, 22);
            this.txtHorseName.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(390, 159);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(183, 22);
            this.txtDate.TabIndex = 10;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(390, 203);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(183, 22);
            this.txtDistance.TabIndex = 11;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEnter.Location = new System.Drawing.Point(447, 280);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(126, 35);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Enter bet!";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cmbResult
            // 
            this.cmbResult.AutoCompleteCustomSource.AddRange(new string[] {
            "Won",
            "Lost"});
            this.cmbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Items.AddRange(new object[] {
            "Won",
            "Lost"});
            this.cmbResult.Location = new System.Drawing.Point(390, 242);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(183, 26);
            this.cmbResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtHorseName);
            this.Controls.Add(this.txtRacecourse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblHorse);
            this.Controls.Add(this.lblRacecourse);
            this.Controls.Add(this.lblBet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblRacecourse;
        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtRacecourse;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cmbResult;
    }
}

