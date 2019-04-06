namespace WinForms_Calculator
{
    partial class Basic_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic_Calculator));
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalcualationResultText = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Equal_Button = new System.Windows.Forms.Button();
            this.Dot_Button = new System.Windows.Forms.Button();
            this.Button_0 = new System.Windows.Forms.Button();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Divide_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.CE_Button = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Left_Parenthesis_Button = new System.Windows.Forms.Button();
            this.Right_Parenthesis_Button = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UserInputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserInputText.ForeColor = System.Drawing.SystemColors.Window;
            this.UserInputText.Location = new System.Drawing.Point(12, 19);
            this.UserInputText.Margin = new System.Windows.Forms.Padding(10);
            this.UserInputText.MinimumSize = new System.Drawing.Size(100, 60);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(382, 60);
            this.UserInputText.TabIndex = 0;
            // 
            // CalcualationResultText
            // 
            this.CalcualationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcualationResultText.BackColor = System.Drawing.Color.Transparent;
            this.CalcualationResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalcualationResultText.ForeColor = System.Drawing.SystemColors.Window;
            this.CalcualationResultText.Location = new System.Drawing.Point(12, 83);
            this.CalcualationResultText.Margin = new System.Windows.Forms.Padding(3);
            this.CalcualationResultText.MinimumSize = new System.Drawing.Size(200, 130);
            this.CalcualationResultText.Name = "CalcualationResultText";
            this.CalcualationResultText.Size = new System.Drawing.Size(382, 130);
            this.CalcualationResultText.TabIndex = 1;
            this.CalcualationResultText.Text = "0";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.Button_0, 1, 4);
            this.ButtonPanel.Controls.Add(this.Button_3, 2, 3);
            this.ButtonPanel.Controls.Add(this.Button_2, 1, 3);
            this.ButtonPanel.Controls.Add(this.Button_1, 0, 3);
            this.ButtonPanel.Controls.Add(this.Button_6, 2, 2);
            this.ButtonPanel.Controls.Add(this.Button_4, 0, 2);
            this.ButtonPanel.Controls.Add(this.Button_9, 2, 1);
            this.ButtonPanel.Controls.Add(this.Button_8, 1, 1);
            this.ButtonPanel.Controls.Add(this.Button_7, 0, 1);
            this.ButtonPanel.Controls.Add(this.CE_Button, 0, 0);
            this.ButtonPanel.Controls.Add(this.Button_5, 1, 2);
            this.ButtonPanel.Controls.Add(this.Dot_Button, 0, 4);
            this.ButtonPanel.Controls.Add(this.Equal_Button, 2, 4);
            this.ButtonPanel.Controls.Add(this.Plus_Button, 3, 4);
            this.ButtonPanel.Controls.Add(this.Minus_Button, 3, 3);
            this.ButtonPanel.Controls.Add(this.Multiply_Button, 3, 2);
            this.ButtonPanel.Controls.Add(this.Divide_Button, 3, 1);
            this.ButtonPanel.Controls.Add(this.Delete_Button, 3, 0);
            this.ButtonPanel.Controls.Add(this.Left_Parenthesis_Button, 1, 0);
            this.ButtonPanel.Controls.Add(this.Right_Parenthesis_Button, 2, 0);
            this.ButtonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPanel.Location = new System.Drawing.Point(12, 220);
            this.ButtonPanel.MinimumSize = new System.Drawing.Size(200, 250);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 5;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonPanel.Size = new System.Drawing.Size(382, 435);
            this.ButtonPanel.TabIndex = 2;
            // 
            // Equal_Button
            // 
            this.Equal_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Equal_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Equal_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Equal_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equal_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equal_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Equal_Button.Location = new System.Drawing.Point(193, 351);
            this.Equal_Button.Name = "Equal_Button";
            this.Equal_Button.Size = new System.Drawing.Size(89, 81);
            this.Equal_Button.TabIndex = 19;
            this.Equal_Button.Text = "=";
            this.Equal_Button.UseVisualStyleBackColor = false;
            this.Equal_Button.Click += new System.EventHandler(this.Equal_Button_Click);
            // 
            // Dot_Button
            // 
            this.Dot_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Dot_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Dot_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dot_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dot_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Dot_Button.Location = new System.Drawing.Point(3, 351);
            this.Dot_Button.Name = "Dot_Button";
            this.Dot_Button.Size = new System.Drawing.Size(89, 81);
            this.Dot_Button.TabIndex = 18;
            this.Dot_Button.Text = ".";
            this.Dot_Button.UseVisualStyleBackColor = false;
            this.Dot_Button.Click += new System.EventHandler(this.Dot_Button_Click);
            // 
            // Button_0
            // 
            this.Button_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_0.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_0.Location = new System.Drawing.Point(98, 351);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(89, 81);
            this.Button_0.TabIndex = 17;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = false;
            this.Button_0.Click += new System.EventHandler(this.Button_0_Click);
            // 
            // Plus_Button
            // 
            this.Plus_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Plus_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Plus_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plus_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Plus_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Plus_Button.Location = new System.Drawing.Point(288, 351);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(91, 81);
            this.Plus_Button.TabIndex = 15;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = false;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // Button_3
            // 
            this.Button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_3.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_3.Location = new System.Drawing.Point(193, 264);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(89, 81);
            this.Button_3.TabIndex = 14;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = false;
            this.Button_3.Click += new System.EventHandler(this.Button_3_Click);
            // 
            // Button_2
            // 
            this.Button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_2.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_2.Location = new System.Drawing.Point(98, 264);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(89, 81);
            this.Button_2.TabIndex = 13;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = false;
            this.Button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // Button_1
            // 
            this.Button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_1.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_1.Location = new System.Drawing.Point(3, 264);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(89, 81);
            this.Button_1.TabIndex = 12;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = false;
            this.Button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Minus_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minus_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minus_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minus_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minus_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Minus_Button.Location = new System.Drawing.Point(288, 264);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(91, 81);
            this.Minus_Button.TabIndex = 11;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = false;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            // 
            // Button_6
            // 
            this.Button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_6.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_6.Location = new System.Drawing.Point(193, 177);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(89, 81);
            this.Button_6.TabIndex = 10;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = true;
            this.Button_6.Click += new System.EventHandler(this.Button_6_Click);
            // 
            // Button_4
            // 
            this.Button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_4.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_4.Location = new System.Drawing.Point(3, 177);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(89, 81);
            this.Button_4.TabIndex = 8;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = false;
            this.Button_4.Click += new System.EventHandler(this.Button_4_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Multiply_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Multiply_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiply_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiply_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Multiply_Button.Location = new System.Drawing.Point(288, 177);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(91, 81);
            this.Multiply_Button.TabIndex = 7;
            this.Multiply_Button.Text = "x";
            this.Multiply_Button.UseVisualStyleBackColor = false;
            this.Multiply_Button.Click += new System.EventHandler(this.Multiply_Button_Click);
            // 
            // Button_9
            // 
            this.Button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_9.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_9.Location = new System.Drawing.Point(193, 90);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(89, 81);
            this.Button_9.TabIndex = 6;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = false;
            this.Button_9.Click += new System.EventHandler(this.Button_9_Click);
            // 
            // Button_8
            // 
            this.Button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_8.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_8.Location = new System.Drawing.Point(98, 90);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(89, 81);
            this.Button_8.TabIndex = 5;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = false;
            this.Button_8.Click += new System.EventHandler(this.Button_8_Click);
            // 
            // Button_7
            // 
            this.Button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_7.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_7.Location = new System.Drawing.Point(3, 90);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(89, 81);
            this.Button_7.TabIndex = 4;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = false;
            this.Button_7.Click += new System.EventHandler(this.Button_7_Click);
            // 
            // Divide_Button
            // 
            this.Divide_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.Divide_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Divide_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divide_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divide_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Divide_Button.Location = new System.Drawing.Point(288, 90);
            this.Divide_Button.Name = "Divide_Button";
            this.Divide_Button.Size = new System.Drawing.Size(91, 81);
            this.Divide_Button.TabIndex = 3;
            this.Divide_Button.Text = "/";
            this.Divide_Button.UseVisualStyleBackColor = false;
            this.Divide_Button.Click += new System.EventHandler(this.Divide_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Delete_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Delete_Button.Location = new System.Drawing.Point(288, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(91, 81);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "DEL";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // CE_Button
            // 
            this.CE_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CE_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CE_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CE_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CE_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CE_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CE_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.CE_Button.Location = new System.Drawing.Point(3, 3);
            this.CE_Button.Name = "CE_Button";
            this.CE_Button.Size = new System.Drawing.Size(89, 81);
            this.CE_Button.TabIndex = 0;
            this.CE_Button.Text = "CE";
            this.CE_Button.UseVisualStyleBackColor = false;
            this.CE_Button.Click += new System.EventHandler(this.CE_Button_Click);
            // 
            // Button_5
            // 
            this.Button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_5.ForeColor = System.Drawing.SystemColors.Window;
            this.Button_5.Location = new System.Drawing.Point(98, 177);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(89, 81);
            this.Button_5.TabIndex = 20;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = false;
            this.Button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // Left_Parenthesis_Button
            // 
            this.Left_Parenthesis_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Left_Parenthesis_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Left_Parenthesis_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Left_Parenthesis_Button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Left_Parenthesis_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left_Parenthesis_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Left_Parenthesis_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Left_Parenthesis_Button.Location = new System.Drawing.Point(98, 3);
            this.Left_Parenthesis_Button.Name = "Left_Parenthesis_Button";
            this.Left_Parenthesis_Button.Size = new System.Drawing.Size(89, 81);
            this.Left_Parenthesis_Button.TabIndex = 21;
            this.Left_Parenthesis_Button.Text = "(";
            this.Left_Parenthesis_Button.UseVisualStyleBackColor = false;
            this.Left_Parenthesis_Button.Click += new System.EventHandler(this.Left_Parenthesis_Button_Click);
            // 
            // Right_Parenthesis_Button
            // 
            this.Right_Parenthesis_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Right_Parenthesis_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Right_Parenthesis_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Right_Parenthesis_Button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Right_Parenthesis_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right_Parenthesis_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Right_Parenthesis_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Right_Parenthesis_Button.Location = new System.Drawing.Point(193, 3);
            this.Right_Parenthesis_Button.Name = "Right_Parenthesis_Button";
            this.Right_Parenthesis_Button.Size = new System.Drawing.Size(89, 81);
            this.Right_Parenthesis_Button.TabIndex = 22;
            this.Right_Parenthesis_Button.Text = ")";
            this.Right_Parenthesis_Button.UseVisualStyleBackColor = false;
            this.Right_Parenthesis_Button.Click += new System.EventHandler(this.Right_Parenthesis_Button_Click);
            // 
            // Basic_Calculator
            // 
            this.AcceptButton = this.Equal_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.CancelButton = this.CE_Button;
            this.ClientSize = new System.Drawing.Size(406, 667);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CalcualationResultText);
            this.Controls.Add(this.UserInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(275, 520);
            this.Name = "Basic_Calculator";
            this.Opacity = 0.99D;
            this.Text = "My Calculator";
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalcualationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CE_Button;
        private System.Windows.Forms.Button Equal_Button;
        private System.Windows.Forms.Button Dot_Button;
        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_2;
        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Button_9;
        private System.Windows.Forms.Button Button_8;
        private System.Windows.Forms.Button Button_7;
        private System.Windows.Forms.Button Divide_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Button_5;
        private System.Windows.Forms.Button Left_Parenthesis_Button;
        private System.Windows.Forms.Button Right_Parenthesis_Button;
    }
}

