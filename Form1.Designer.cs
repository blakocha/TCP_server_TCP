namespace TCP_server_TCP
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(57, 17);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(272, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(427, 16);
            this.PortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(272, 20);
            this.PortNumber.TabIndex = 1;
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(57, 62);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(642, 186);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(176, 263);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(147, 43);
            this.Button_Start.TabIndex = 3;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(417, 261);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(157, 45);
            this.Button_Stop.TabIndex = 4;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 339);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown PortNumber;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Stop;
    }
}

