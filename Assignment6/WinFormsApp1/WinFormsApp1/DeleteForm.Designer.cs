namespace WinFormsApp1
{
    partial class DeleteForm
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
            this.delete_button = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.GroupBox();
            this.delete_order_id_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.deleteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.deleteBox);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 340);
            this.panel1.TabIndex = 0;
            // 
            // delete_button
            // 
            this.delete_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delete_button.Location = new System.Drawing.Point(311, 232);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(140, 40);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "确认删除此订单";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteBox.Controls.Add(this.delete_order_id_textbox);
            this.deleteBox.Controls.Add(this.label1);
            this.deleteBox.Location = new System.Drawing.Point(3, 60);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(750, 117);
            this.deleteBox.TabIndex = 1;
            this.deleteBox.TabStop = false;
            this.deleteBox.Text = "删除订单信息";
            // 
            // delete_order_id_textbox
            // 
            this.delete_order_id_textbox.Location = new System.Drawing.Point(221, 57);
            this.delete_order_id_textbox.Name = "delete_order_id_textbox";
            this.delete_order_id_textbox.Size = new System.Drawing.Size(218, 27);
            this.delete_order_id_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要删除的订单号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(291, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 20);
            this.title.TabIndex = 0;
            this.title.Text = "欢迎使用删除订单功能！";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 359);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteForm";
            this.Text = "删除订单功能界面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.deleteBox.ResumeLayout(false);
            this.deleteBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox deleteBox;
        private Label title;
        private Label label1;
        private TextBox delete_order_id_textbox;
        private Button delete_button;
    }
}