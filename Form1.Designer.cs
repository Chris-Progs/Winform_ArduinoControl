namespace Scripting2._1
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
            this.RedLEDButton = new System.Windows.Forms.Button();
            this.OutsideTempBox = new System.Windows.Forms.TextBox();
            this.InsideTempBox = new System.Windows.Forms.TextBox();
            this.InsideHumidityBox = new System.Windows.Forms.TextBox();
            this.OutsideTempLabel = new System.Windows.Forms.Label();
            this.InsideTempLabel = new System.Windows.Forms.Label();
            this.InsideHumidityLabel = new System.Windows.Forms.Label();
            this.TempComboBox = new System.Windows.Forms.ComboBox();
            this.TempMaxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedLEDButton
            // 
            this.RedLEDButton.BackColor = System.Drawing.Color.Red;
            this.RedLEDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLEDButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RedLEDButton.Location = new System.Drawing.Point(27, 270);
            this.RedLEDButton.Name = "RedLEDButton";
            this.RedLEDButton.Size = new System.Drawing.Size(308, 54);
            this.RedLEDButton.TabIndex = 2;
            this.RedLEDButton.Text = "Red LED Toggle";
            this.RedLEDButton.UseVisualStyleBackColor = false;
            this.RedLEDButton.Click += new System.EventHandler(this.RedLEDButton_Click);
            // 
            // OutsideTempBox
            // 
            this.OutsideTempBox.Location = new System.Drawing.Point(152, 51);
            this.OutsideTempBox.Name = "OutsideTempBox";
            this.OutsideTempBox.Size = new System.Drawing.Size(122, 20);
            this.OutsideTempBox.TabIndex = 3;
            // 
            // InsideTempBox
            // 
            this.InsideTempBox.Location = new System.Drawing.Point(152, 80);
            this.InsideTempBox.Name = "InsideTempBox";
            this.InsideTempBox.Size = new System.Drawing.Size(122, 20);
            this.InsideTempBox.TabIndex = 4;
            // 
            // InsideHumidityBox
            // 
            this.InsideHumidityBox.Location = new System.Drawing.Point(152, 113);
            this.InsideHumidityBox.Name = "InsideHumidityBox";
            this.InsideHumidityBox.Size = new System.Drawing.Size(122, 20);
            this.InsideHumidityBox.TabIndex = 5;
            // 
            // OutsideTempLabel
            // 
            this.OutsideTempLabel.AutoSize = true;
            this.OutsideTempLabel.Location = new System.Drawing.Point(24, 54);
            this.OutsideTempLabel.Name = "OutsideTempLabel";
            this.OutsideTempLabel.Size = new System.Drawing.Size(109, 13);
            this.OutsideTempLabel.TabIndex = 6;
            this.OutsideTempLabel.Text = "Outside Temp (LM35)";
            // 
            // InsideTempLabel
            // 
            this.InsideTempLabel.AutoSize = true;
            this.InsideTempLabel.Location = new System.Drawing.Point(24, 83);
            this.InsideTempLabel.Name = "InsideTempLabel";
            this.InsideTempLabel.Size = new System.Drawing.Size(109, 13);
            this.InsideTempLabel.TabIndex = 7;
            this.InsideTempLabel.Text = "Inside Temp (DHT11)";
            // 
            // InsideHumidityLabel
            // 
            this.InsideHumidityLabel.AutoSize = true;
            this.InsideHumidityLabel.Location = new System.Drawing.Point(24, 116);
            this.InsideHumidityLabel.Name = "InsideHumidityLabel";
            this.InsideHumidityLabel.Size = new System.Drawing.Size(122, 13);
            this.InsideHumidityLabel.TabIndex = 8;
            this.InsideHumidityLabel.Text = "Inside Humidity (DHT11)";
            // 
            // TempComboBox
            // 
            this.TempComboBox.FormattingEnabled = true;
            this.TempComboBox.Items.AddRange(new object[] {
            "32",
            "33",
            "34"});
            this.TempComboBox.Location = new System.Drawing.Point(160, 164);
            this.TempComboBox.Name = "TempComboBox";
            this.TempComboBox.Size = new System.Drawing.Size(148, 21);
            this.TempComboBox.TabIndex = 9;
            // 
            // TempMaxButton
            // 
            this.TempMaxButton.Location = new System.Drawing.Point(27, 164);
            this.TempMaxButton.Name = "TempMaxButton";
            this.TempMaxButton.Size = new System.Drawing.Size(127, 21);
            this.TempMaxButton.TabIndex = 10;
            this.TempMaxButton.Text = "Temp Max";
            this.TempMaxButton.UseVisualStyleBackColor = true;
            this.TempMaxButton.Click += new System.EventHandler(this.TempMaxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Turn Rotation AO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempMaxButton);
            this.Controls.Add(this.TempComboBox);
            this.Controls.Add(this.InsideHumidityLabel);
            this.Controls.Add(this.InsideTempLabel);
            this.Controls.Add(this.OutsideTempLabel);
            this.Controls.Add(this.InsideHumidityBox);
            this.Controls.Add(this.InsideTempBox);
            this.Controls.Add(this.OutsideTempBox);
            this.Controls.Add(this.RedLEDButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RedLEDButton;
        private System.Windows.Forms.TextBox OutsideTempBox;
        private System.Windows.Forms.TextBox InsideTempBox;
        private System.Windows.Forms.TextBox InsideHumidityBox;
        private System.Windows.Forms.Label OutsideTempLabel;
        private System.Windows.Forms.Label InsideTempLabel;
        private System.Windows.Forms.Label InsideHumidityLabel;
        private System.Windows.Forms.ComboBox TempComboBox;
        private System.Windows.Forms.Button TempMaxButton;
        private System.Windows.Forms.Label label1;
    }
}

