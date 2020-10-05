namespace Mandelbrot
{
    partial class Mandelbrot
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
            this.plot = new System.Windows.Forms.Button();
            this.middle_xField = new System.Windows.Forms.TextBox();
            this.middle_yField = new System.Windows.Forms.TextBox();
            this.maxField = new System.Windows.Forms.TextBox();
            this.scaleField = new System.Windows.Forms.TextBox();
            this.middle_xLabel = new System.Windows.Forms.Label();
            this.middle_yLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.styleDropdown = new System.Windows.Forms.ComboBox();
            this.styleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusIndicator = new System.Windows.Forms.Label();
            this.locationDropdown = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.Location = new System.Drawing.Point(12, 491);
            this.plot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(168, 61);
            this.plot.TabIndex = 0;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = true;
            this.plot.Click += new System.EventHandler(this.Plot);
            // 
            // middle_xField
            // 
            this.middle_xField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_xField.Location = new System.Drawing.Point(80, 12);
            this.middle_xField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.middle_xField.Name = "middle_xField";
            this.middle_xField.Size = new System.Drawing.Size(100, 24);
            this.middle_xField.TabIndex = 2;
            // 
            // middle_yField
            // 
            this.middle_yField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_yField.Location = new System.Drawing.Point(80, 42);
            this.middle_yField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.middle_yField.Name = "middle_yField";
            this.middle_yField.Size = new System.Drawing.Size(100, 24);
            this.middle_yField.TabIndex = 3;
            // 
            // maxField
            // 
            this.maxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxField.Location = new System.Drawing.Point(80, 72);
            this.maxField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maxField.Name = "maxField";
            this.maxField.Size = new System.Drawing.Size(100, 24);
            this.maxField.TabIndex = 1;
            // 
            // scaleField
            // 
            this.scaleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleField.Location = new System.Drawing.Point(80, 102);
            this.scaleField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.scaleField.Name = "scaleField";
            this.scaleField.Size = new System.Drawing.Size(100, 24);
            this.scaleField.TabIndex = 4;
            // 
            // middle_xLabel
            // 
            this.middle_xLabel.AutoSize = true;
            this.middle_xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_xLabel.Location = new System.Drawing.Point(9, 15);
            this.middle_xLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middle_xLabel.Name = "middle_xLabel";
            this.middle_xLabel.Size = new System.Drawing.Size(62, 18);
            this.middle_xLabel.TabIndex = 5;
            this.middle_xLabel.Text = "Middle x";
            // 
            // middle_yLabel
            // 
            this.middle_yLabel.AutoSize = true;
            this.middle_yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_yLabel.Location = new System.Drawing.Point(9, 45);
            this.middle_yLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middle_yLabel.Name = "middle_yLabel";
            this.middle_yLabel.Size = new System.Drawing.Size(62, 18);
            this.middle_yLabel.TabIndex = 6;
            this.middle_yLabel.Text = "Middle y";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.Location = new System.Drawing.Point(9, 105);
            this.scaleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(45, 18);
            this.scaleLabel.TabIndex = 7;
            this.scaleLabel.Text = "Scale";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(9, 75);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(36, 18);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "Max";
            // 
            // styleDropdown
            // 
            this.styleDropdown.AllowDrop = true;
            this.styleDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleDropdown.FormattingEnabled = true;
            this.styleDropdown.Items.AddRange(new object[] {
            "Glow",
            "Grayscale",
            "Rainbow",
            "Rainbow 2"});
            this.styleDropdown.Location = new System.Drawing.Point(12, 169);
            this.styleDropdown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.styleDropdown.Name = "styleDropdown";
            this.styleDropdown.Size = new System.Drawing.Size(168, 26);
            this.styleDropdown.TabIndex = 9;
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleLabel.Location = new System.Drawing.Point(9, 148);
            this.styleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(95, 18);
            this.styleLabel.TabIndex = 10;
            this.styleLabel.Text = "Preset Styles";
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(204, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(875, 540);
            this.canvas.TabIndex = 11;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.Canvas_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(12, 450);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(168, 35);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(9, 429);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 18);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status:";
            // 
            // statusIndicator
            // 
            this.statusIndicator.AutoSize = true;
            this.statusIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusIndicator.Location = new System.Drawing.Point(63, 429);
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(50, 18);
            this.statusIndicator.TabIndex = 14;
            this.statusIndicator.Text = "Ready";
            // 
            // locationDropdown
            // 
            this.locationDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Items.AddRange(new object[] {
            "User control",
            "Spiral",
            "Fracture",
            "Mini Mandelbrot",
            "Diagonal Mandelbrot"});
            this.locationDropdown.Location = new System.Drawing.Point(12, 235);
            this.locationDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(168, 25);
            this.locationDropdown.TabIndex = 15;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(9, 215);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(120, 18);
            this.locationLabel.TabIndex = 16;
            this.locationLabel.Text = "Preset Locations";
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 564);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationDropdown);
            this.Controls.Add(this.statusIndicator);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.styleDropdown);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.middle_yLabel);
            this.Controls.Add(this.middle_xLabel);
            this.Controls.Add(this.scaleField);
            this.Controls.Add(this.maxField);
            this.Controls.Add(this.middle_yField);
            this.Controls.Add(this.middle_xField);
            this.Controls.Add(this.plot);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Mandelbrot";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.TextBox middle_xField;
        private System.Windows.Forms.TextBox middle_yField;
        private System.Windows.Forms.TextBox maxField;
        private System.Windows.Forms.TextBox scaleField;
        private System.Windows.Forms.Label middle_xLabel;
        private System.Windows.Forms.Label middle_yLabel;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.ComboBox styleDropdown;
        private System.Windows.Forms.Label styleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusIndicator;
        private System.Windows.Forms.ComboBox locationDropdown;
        private System.Windows.Forms.Label locationLabel;
    }
}

