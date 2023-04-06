namespace WinFormsApp1
{
    partial class MainForm
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmbeddedPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(310, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 20);
            this.title.TabIndex = 0;
            this.title.Text = "欢迎使用订单管理系统！";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择对订单的操作：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.add_button);
            this.flowLayoutPanel1.Controls.Add(this.delete_button);
            this.flowLayoutPanel1.Controls.Add(this.update_button);
            this.flowLayoutPanel1.Controls.Add(this.select_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(808, 67);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(10, 10);
            this.add_button.Margin = new System.Windows.Forms.Padding(10);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(140, 40);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "添加订单";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(170, 10);
            this.delete_button.Margin = new System.Windows.Forms.Padding(10);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(140, 40);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "删除订单";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(330, 10);
            this.update_button.Margin = new System.Windows.Forms.Padding(10);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(140, 40);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "修改订单";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(490, 10);
            this.select_button.Margin = new System.Windows.Forms.Padding(10);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(140, 40);
            this.select_button.TabIndex = 3;
            this.select_button.Text = "查询订单";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.EmbeddedPanel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 562);
            this.panel1.TabIndex = 3;
            // 
            // EmbeddedPanel
            // 
            this.EmbeddedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbeddedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmbeddedPanel.Location = new System.Drawing.Point(3, 178);
            this.EmbeddedPanel.Name = "EmbeddedPanel";
            this.EmbeddedPanel.Size = new System.Drawing.Size(808, 381);
            this.EmbeddedPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 586);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "订单管理系统主窗口";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label title;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button add_button;
        private Button delete_button;
        private Button update_button;
        private Button select_button;
        private Panel EmbeddedPanel;
    }
}