
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
            this.position_x = new System.Windows.Forms.Label();
            this.position_y = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMouseButton = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetPos = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnCleanPos = new Guna.UI2.WinForms.Guna2TileButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.nbr_click.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.nbr_click.FocusedState.Parent = this.nbr_click;
            this.nbr_click.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbr_click.ForeColor = System.Drawing.Color.Black;
            this.nbr_click.Location = new System.Drawing.Point(48, 366);
            this.nbr_click.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbr_click.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbr_click.Name = "nbr_click";
            this.nbr_click.ShadowDecoration.Parent = this.nbr_click;
            this.nbr_click.Size = new System.Drawing.Size(93, 36);
            this.nbr_click.TabIndex = 0;
            this.nbr_click.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbr_click.ValueChanged += new System.EventHandler(this.nbr_click_ValueChanged);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Animated = true;
            this.guna2TileButton1.BorderRadius = 8;
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.DisabledState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(119, 491);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(93, 36);
            this.guna2TileButton1.TabIndex = 1;
            this.guna2TileButton1.Text = "Start";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // time_betw
            // 
            this.time_betw.BackColor = System.Drawing.Color.Transparent;
            this.time_betw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.time_betw.BorderRadius = 6;
            this.time_betw.BorderThickness = 0;
            this.time_betw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time_betw.DisabledState.Parent = this.time_betw;
            this.time_betw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.time_betw.FocusedState.Parent = this.time_betw;
            this.time_betw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.time_betw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.time_betw.Location = new System.Drawing.Point(48, 249);
            this.time_betw.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.time_betw.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.time_betw.Name = "time_betw";
            this.time_betw.ShadowDecoration.Parent = this.time_betw;
            this.time_betw.Size = new System.Drawing.Size(93, 36);
            this.time_betw.TabIndex = 0;
            this.time_betw.UseTransparentBackground = true;
            this.time_betw.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.time_betw.ValueChanged += new System.EventHandler(this.time_betw_ValueChanged);
            // 
            // position_x
            // 
            this.position_x.AutoSize = true;
            this.position_x.Location = new System.Drawing.Point(105, 92);
            this.position_x.Name = "position_x";
            this.position_x.Size = new System.Drawing.Size(13, 13);
            this.position_x.TabIndex = 3;
            this.position_x.Text = "0";
            // 
            // position_y
            // 
            this.position_y.AutoSize = true;
            this.position_y.Location = new System.Drawing.Point(247, 91);
            this.position_y.Name = "position_y";
            this.position_y.Size = new System.Drawing.Size(13, 13);
            this.position_y.TabIndex = 3;
            this.position_y.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Axe X : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Axe Y : ";
            // 
            // cbxMouseButton
            // 
            this.cbxMouseButton.BackColor = System.Drawing.Color.Transparent;
            this.cbxMouseButton.BorderRadius = 8;
            this.cbxMouseButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMouseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbxMouseButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMouseButton.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMouseButton.FocusedState.Parent = this.cbxMouseButton;
            this.cbxMouseButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMouseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMouseButton.HoverState.Parent = this.cbxMouseButton;
            this.cbxMouseButton.ItemHeight = 30;
            this.cbxMouseButton.Items.AddRange(new object[] {
            "   Left",
            "   Middle",
            "   Right"});
            this.cbxMouseButton.ItemsAppearance.Parent = this.cbxMouseButton;
            this.cbxMouseButton.Location = new System.Drawing.Point(192, 249);
            this.cbxMouseButton.Name = "cbxMouseButton";
            this.cbxMouseButton.ShadowDecoration.Parent = this.cbxMouseButton;
            this.cbxMouseButton.Size = new System.Drawing.Size(93, 36);
            this.cbxMouseButton.StartIndex = 0;
            this.cbxMouseButton.TabIndex = 5;
            this.cbxMouseButton.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(45, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Position :";
            // 
            // btnGetPos
            // 
            this.btnGetPos.Animated = true;
            this.btnGetPos.BackColor = System.Drawing.Color.Transparent;
            this.btnGetPos.BorderRadius = 8;
            this.btnGetPos.CheckedState.Parent = this.btnGetPos;
            this.btnGetPos.CustomImages.Parent = this.btnGetPos;
            this.btnGetPos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetPos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetPos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetPos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetPos.DisabledState.Parent = this.btnGetPos;
            this.btnGetPos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetPos.ForeColor = System.Drawing.Color.White;
            this.btnGetPos.HoverState.Parent = this.btnGetPos;
            this.btnGetPos.IndicateFocus = true;
            this.btnGetPos.Location = new System.Drawing.Point(48, 127);
            this.btnGetPos.Name = "btnGetPos";
            this.btnGetPos.ShadowDecoration.Parent = this.btnGetPos;
            this.btnGetPos.Size = new System.Drawing.Size(107, 29);
            this.btnGetPos.TabIndex = 7;
            this.btnGetPos.Text = "Get (ALT+X)";
            this.btnGetPos.UseTransparentBackground = true;
            this.btnGetPos.Click += new System.EventHandler(this.btnGetPos_Click);
            // 
            // btnCleanPos
            // 
            this.btnCleanPos.Animated = true;
            this.btnCleanPos.BackColor = System.Drawing.Color.Transparent;
            this.btnCleanPos.BorderRadius = 8;
            this.btnCleanPos.CheckedState.Parent = this.btnCleanPos;
            this.btnCleanPos.CustomImages.Parent = this.btnCleanPos;
            this.btnCleanPos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCleanPos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCleanPos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCleanPos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCleanPos.DisabledState.Parent = this.btnCleanPos;
            this.btnCleanPos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCleanPos.ForeColor = System.Drawing.Color.White;
            this.btnCleanPos.HoverState.Parent = this.btnCleanPos;
            this.btnCleanPos.IndicateFocus = true;
            this.btnCleanPos.Location = new System.Drawing.Point(185, 127);
            this.btnCleanPos.Name = "btnCleanPos";
            this.btnCleanPos.ShadowDecoration.Parent = this.btnCleanPos;
            this.btnCleanPos.Size = new System.Drawing.Size(107, 29);
            this.btnCleanPos.TabIndex = 8;
            this.btnCleanPos.Text = "Clean (ALT+X)";
            this.btnCleanPos.UseTransparentBackground = true;
            this.btnCleanPos.Click += new System.EventHandler(this.btnCleanPos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(45, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interval (ms) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(189, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mouse Button :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(45, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number Repeat : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCleanPos);
            this.Controls.Add(this.btnGetPos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxMouseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.position_y);
            this.Controls.Add(this.position_x);
            this.Controls.Add(this.guna2TileButton1);
            this.Controls.Add(this.time_betw);
            this.Controls.Add(this.nbr_click);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Clicker";
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
        private System.Windows.Forms.Label position_x;
        private System.Windows.Forms.Label position_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMouseButton;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TileButton btnGetPos;
        private Guna.UI2.WinForms.Guna2TileButton btnCleanPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

