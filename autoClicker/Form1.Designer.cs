
namespace autoClicker
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
            this.nbr_click = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.time_betw = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.position_x = new System.Windows.Forms.Label();
            this.position_y = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_betw)).BeginInit();
            this.SuspendLayout();
            // 
            // nbr_click
            // 
            this.nbr_click.BackColor = System.Drawing.Color.Transparent;
            this.nbr_click.BorderRadius = 6;
            this.nbr_click.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbr_click.DisabledState.Parent = this.nbr_click;
            this.nbr_click.FocusedState.Parent = this.nbr_click;
            this.nbr_click.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbr_click.ForeColor = System.Drawing.Color.Black;
            this.nbr_click.Location = new System.Drawing.Point(123, 77);
            this.nbr_click.Name = "nbr_click";
            this.nbr_click.ShadowDecoration.Parent = this.nbr_click;
            this.nbr_click.Size = new System.Drawing.Size(100, 36);
            this.nbr_click.TabIndex = 0;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BorderRadius = 6;
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.DisabledState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(123, 171);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(100, 36);
            this.guna2TileButton1.TabIndex = 1;
            this.guna2TileButton1.Text = "Start";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // time_betw
            // 
            this.time_betw.BackColor = System.Drawing.Color.Transparent;
            this.time_betw.BorderRadius = 6;
            this.time_betw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time_betw.DisabledState.Parent = this.time_betw;
            this.time_betw.FocusedState.Parent = this.time_betw;
            this.time_betw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.time_betw.ForeColor = System.Drawing.Color.Black;
            this.time_betw.Location = new System.Drawing.Point(123, 119);
            this.time_betw.Name = "time_betw";
            this.time_betw.ShadowDecoration.Parent = this.time_betw;
            this.time_betw.Size = new System.Drawing.Size(100, 36);
            this.time_betw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(30)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(30)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Between";
            // 
            // position_x
            // 
            this.position_x.AutoSize = true;
            this.position_x.Location = new System.Drawing.Point(12, 20);
            this.position_x.Name = "position_x";
            this.position_x.Size = new System.Drawing.Size(29, 13);
            this.position_x.TabIndex = 3;
            this.position_x.Text = "X : 0";
            // 
            // position_y
            // 
            this.position_y.AutoSize = true;
            this.position_y.Location = new System.Drawing.Point(12, 46);
            this.position_y.Name = "position_y";
            this.position_y.Size = new System.Drawing.Size(29, 13);
            this.position_y.TabIndex = 3;
            this.position_y.Text = "Y : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 269);
            this.Controls.Add(this.position_y);
            this.Controls.Add(this.position_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TileButton1);
            this.Controls.Add(this.time_betw);
            this.Controls.Add(this.nbr_click);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nbr_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_betw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown nbr_click;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2NumericUpDown time_betw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label position_x;
        private System.Windows.Forms.Label position_y;
    }
}

