using System.Drawing;

namespace RGBcontrol
{
    partial class main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.HexBox = new System.Windows.Forms.TextBox();
            this.CpButton = new System.Windows.Forms.Button();
            this.Btext = new System.Windows.Forms.TextBox();
            this.Bbar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Gtext = new System.Windows.Forms.TextBox();
            this.Gbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Rtext = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Rbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorPreView = new System.Windows.Forms.TextBox();
            this.C1 = new System.Windows.Forms.Button();
            this.C6 = new System.Windows.Forms.Button();
            this.C5 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C7 = new System.Windows.Forms.Button();
            this.C9 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.C8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rbar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.OKbtn);
            this.panel1.Controls.Add(this.HexBox);
            this.panel1.Controls.Add(this.CpButton);
            this.panel1.Controls.Add(this.Btext);
            this.panel1.Controls.Add(this.Bbar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Gtext);
            this.panel1.Controls.Add(this.Gbar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Rtext);
            this.panel1.Controls.Add(this.Apply);
            this.panel1.Controls.Add(this.Rbar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ColorPreView);
            this.panel1.Location = new System.Drawing.Point(5, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 242);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(195, 205);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(36, 23);
            this.OKbtn.TabIndex = 13;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // HexBox
            // 
            this.HexBox.Location = new System.Drawing.Point(89, 207);
            this.HexBox.Name = "HexBox";
            this.HexBox.Size = new System.Drawing.Size(100, 20);
            this.HexBox.TabIndex = 12;
            // 
            // CpButton
            // 
            this.CpButton.Location = new System.Drawing.Point(89, 151);
            this.CpButton.Name = "CpButton";
            this.CpButton.Size = new System.Drawing.Size(75, 50);
            this.CpButton.TabIndex = 11;
            this.CpButton.Text = "Color Picker";
            this.CpButton.UseVisualStyleBackColor = true;
            this.CpButton.Click += new System.EventHandler(this.CpButton_Click);
            // 
            // Btext
            // 
            this.Btext.Location = new System.Drawing.Point(389, 115);
            this.Btext.Name = "Btext";
            this.Btext.Size = new System.Drawing.Size(56, 20);
            this.Btext.TabIndex = 10;
            // 
            // Bbar
            // 
            this.Bbar.Location = new System.Drawing.Point(56, 115);
            this.Bbar.Maximum = 255;
            this.Bbar.Name = "Bbar";
            this.Bbar.Size = new System.Drawing.Size(327, 45);
            this.Bbar.TabIndex = 9;
            this.Bbar.Scroll += new System.EventHandler(this.Bbar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue";
            // 
            // Gtext
            // 
            this.Gtext.Location = new System.Drawing.Point(389, 64);
            this.Gtext.Name = "Gtext";
            this.Gtext.Size = new System.Drawing.Size(56, 20);
            this.Gtext.TabIndex = 7;
            // 
            // Gbar
            // 
            this.Gbar.Location = new System.Drawing.Point(56, 64);
            this.Gbar.Maximum = 255;
            this.Gbar.Name = "Gbar";
            this.Gbar.Size = new System.Drawing.Size(327, 45);
            this.Gbar.TabIndex = 6;
            this.Gbar.Scroll += new System.EventHandler(this.Gbar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // Rtext
            // 
            this.Rtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rtext.Location = new System.Drawing.Point(389, 13);
            this.Rtext.Name = "Rtext";
            this.Rtext.Size = new System.Drawing.Size(56, 20);
            this.Rtext.TabIndex = 4;            
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(372, 202);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 3;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Rbar
            // 
            this.Rbar.Location = new System.Drawing.Point(56, 13);
            this.Rbar.Maximum = 255;
            this.Rbar.Name = "Rbar";
            this.Rbar.Size = new System.Drawing.Size(327, 45);
            this.Rbar.TabIndex = 2;
            this.Rbar.Scroll += new System.EventHandler(this.Rbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // ColorPreView
            // 
            this.ColorPreView.Enabled = false;
            this.ColorPreView.Location = new System.Drawing.Point(3, 160);
            this.ColorPreView.Multiline = true;
            this.ColorPreView.Name = "ColorPreView";
            this.ColorPreView.Size = new System.Drawing.Size(75, 75);
            this.ColorPreView.TabIndex = 0;
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(35)))), ((int)(((byte)(255)))));
            this.C1.Location = new System.Drawing.Point(42, 26);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(119, 69);
            this.C1.TabIndex = 12;
            this.C1.Text = " ";
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // C6
            // 
            this.C6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(104)))));
            this.C6.Location = new System.Drawing.Point(292, 101);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(119, 69);
            this.C6.TabIndex = 13;
            this.C6.Text = " ";
            this.C6.UseVisualStyleBackColor = false;
            this.C6.Click += new System.EventHandler(this.C6_Click);
            // 
            // C5
            // 
            this.C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.C5.Location = new System.Drawing.Point(167, 101);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(119, 69);
            this.C5.TabIndex = 14;
            this.C5.Text = " ";
            this.C5.UseVisualStyleBackColor = false;
            this.C5.Click += new System.EventHandler(this.C5_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.C2.Location = new System.Drawing.Point(167, 26);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(119, 69);
            this.C2.TabIndex = 17;
            this.C2.Text = " ";
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.C3.ForeColor = System.Drawing.Color.Black;
            this.C3.Location = new System.Drawing.Point(292, 26);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(119, 69);
            this.C3.TabIndex = 16;
            this.C3.Text = " ";
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // C7
            // 
            this.C7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.C7.Location = new System.Drawing.Point(42, 176);
            this.C7.Name = "C7";
            this.C7.Size = new System.Drawing.Size(119, 69);
            this.C7.TabIndex = 15;
            this.C7.Text = " ";
            this.C7.UseVisualStyleBackColor = false;
            this.C7.Click += new System.EventHandler(this.C7_Click);
            // 
            // C9
            // 
            this.C9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(5)))));
            this.C9.Location = new System.Drawing.Point(292, 176);
            this.C9.Name = "C9";
            this.C9.Size = new System.Drawing.Size(119, 69);
            this.C9.TabIndex = 20;
            this.C9.Text = " ";
            this.C9.UseVisualStyleBackColor = false;
            this.C9.Click += new System.EventHandler(this.C9_Click);
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(7)))), ((int)(((byte)(242)))));
            this.C4.Location = new System.Drawing.Point(42, 101);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(119, 69);
            this.C4.TabIndex = 19;
            this.C4.Text = " ";
            this.C4.UseVisualStyleBackColor = false;
            this.C4.Click += new System.EventHandler(this.C4_Click);
            // 
            // C8
            // 
            this.C8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(242)))), ((int)(((byte)(129)))));
            this.C8.Location = new System.Drawing.Point(167, 176);
            this.C8.Name = "C8";
            this.C8.Size = new System.Drawing.Size(119, 69);
            this.C8.TabIndex = 18;
            this.C8.Text = " ";
            this.C8.UseVisualStyleBackColor = false;
            this.C8.Click += new System.EventHandler(this.C8_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 515);
            this.Controls.Add(this.C9);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C8);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C7);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.C6);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(480, 554);
            this.MinimumSize = new System.Drawing.Size(480, 554);
            this.Name = "main";
            this.Text = "Rgb";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.TextBox HexBox;
        private System.Windows.Forms.Button CpButton;
        private System.Windows.Forms.TextBox Btext;
        private System.Windows.Forms.TrackBar Bbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Gtext;
        private System.Windows.Forms.TrackBar Gbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rtext;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TrackBar Rbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColorPreView;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C6;
        private System.Windows.Forms.Button C5;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C7;
        private System.Windows.Forms.Button C9;
        private System.Windows.Forms.Button C4;
        private System.Windows.Forms.Button C8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

