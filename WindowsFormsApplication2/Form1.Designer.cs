namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BottingConfigButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(21, 57);
            this.StartButton.Margin = new System.Windows.Forms.Padding(1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Padding = new System.Windows.Forms.Padding(3);
            this.StartButton.Size = new System.Drawing.Size(298, 31);
            this.StartButton.TabIndex = 1;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "START";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(21, 87);
            this.StopButton.Margin = new System.Windows.Forms.Padding(1);
            this.StopButton.Name = "StopButton";
            this.StopButton.Padding = new System.Windows.Forms.Padding(3);
            this.StopButton.Size = new System.Drawing.Size(298, 31);
            this.StopButton.TabIndex = 2;
            this.StopButton.TabStop = false;
            this.StopButton.Text = "STOP";
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StopButton.UseMnemonic = false;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestartButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(21, 117);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(1);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Padding = new System.Windows.Forms.Padding(3);
            this.RestartButton.Size = new System.Drawing.Size(298, 31);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.TabStop = false;
            this.RestartButton.Text = "RESTART";
            this.RestartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RestartButton.UseMnemonic = false;
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(298, 31);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "START WITH RESTARTS";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status: Idle";
            // 
            // BottingConfigButton
            // 
            this.BottingConfigButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottingConfigButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BottingConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BottingConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottingConfigButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottingConfigButton.Location = new System.Drawing.Point(169, 177);
            this.BottingConfigButton.Margin = new System.Windows.Forms.Padding(1);
            this.BottingConfigButton.Name = "BottingConfigButton";
            this.BottingConfigButton.Padding = new System.Windows.Forms.Padding(3);
            this.BottingConfigButton.Size = new System.Drawing.Size(150, 31);
            this.BottingConfigButton.TabIndex = 7;
            this.BottingConfigButton.TabStop = false;
            this.BottingConfigButton.Text = "BOTTING CONFIG";
            this.BottingConfigButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BottingConfigButton.UseMnemonic = false;
            this.BottingConfigButton.UseVisualStyleBackColor = false;
            this.BottingConfigButton.Click += new System.EventHandler(this.BottingConfigButton_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(150, 31);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "NORMAL CONFIG";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 245);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BottingConfigButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Mirror of Kalandra Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BottingConfigButton;
        private System.Windows.Forms.Button button2;
    }
}

