namespace WinFormsApp1
{
    partial class UpdateForm
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
            this.update_button = new System.Windows.Forms.Button();
            this.updateBox3 = new System.Windows.Forms.GroupBox();
            this.update_goods_price_textbox = new System.Windows.Forms.TextBox();
            this.update_goods_amount_textbox = new System.Windows.Forms.TextBox();
            this.update_goods_name_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateBox2 = new System.Windows.Forms.GroupBox();
            this.update_client_number_textbox = new System.Windows.Forms.TextBox();
            this.update_client_location_textbox = new System.Windows.Forms.TextBox();
            this.update_client_name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBox1 = new System.Windows.Forms.GroupBox();
            this.update_order_id_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.updateBox3.SuspendLayout();
            this.updateBox2.SuspendLayout();
            this.updateBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(this.updateBox3);
            this.panel1.Controls.Add(this.updateBox2);
            this.panel1.Controls.Add(this.updateBox1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 634);
            this.panel1.TabIndex = 0;
            // 
            // update_button
            // 
            this.update_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update_button.Location = new System.Drawing.Point(357, 551);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(140, 40);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "确认修改此订单";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // updateBox3
            // 
            this.updateBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateBox3.Controls.Add(this.update_goods_price_textbox);
            this.updateBox3.Controls.Add(this.update_goods_amount_textbox);
            this.updateBox3.Controls.Add(this.update_goods_name_textbox);
            this.updateBox3.Controls.Add(this.label7);
            this.updateBox3.Controls.Add(this.label6);
            this.updateBox3.Controls.Add(this.label5);
            this.updateBox3.Location = new System.Drawing.Point(3, 351);
            this.updateBox3.Margin = new System.Windows.Forms.Padding(10);
            this.updateBox3.Name = "updateBox3";
            this.updateBox3.Size = new System.Drawing.Size(824, 163);
            this.updateBox3.TabIndex = 3;
            this.updateBox3.TabStop = false;
            this.updateBox3.Text = "商品信息";
            // 
            // update_goods_price_textbox
            // 
            this.update_goods_price_textbox.Location = new System.Drawing.Point(252, 113);
            this.update_goods_price_textbox.Name = "update_goods_price_textbox";
            this.update_goods_price_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_goods_price_textbox.TabIndex = 5;
            // 
            // update_goods_amount_textbox
            // 
            this.update_goods_amount_textbox.Location = new System.Drawing.Point(252, 78);
            this.update_goods_amount_textbox.Name = "update_goods_amount_textbox";
            this.update_goods_amount_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_goods_amount_textbox.TabIndex = 4;
            // 
            // update_goods_name_textbox
            // 
            this.update_goods_name_textbox.Location = new System.Drawing.Point(252, 42);
            this.update_goods_name_textbox.Name = "update_goods_name_textbox";
            this.update_goods_name_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_goods_name_textbox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "请输入修改后的商品单价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "请输入修改后的商品数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "请输入修改后的商品名：";
            // 
            // updateBox2
            // 
            this.updateBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateBox2.Controls.Add(this.update_client_number_textbox);
            this.updateBox2.Controls.Add(this.update_client_location_textbox);
            this.updateBox2.Controls.Add(this.update_client_name_textbox);
            this.updateBox2.Controls.Add(this.label4);
            this.updateBox2.Controls.Add(this.label3);
            this.updateBox2.Controls.Add(this.label2);
            this.updateBox2.Location = new System.Drawing.Point(3, 181);
            this.updateBox2.Margin = new System.Windows.Forms.Padding(10);
            this.updateBox2.Name = "updateBox2";
            this.updateBox2.Size = new System.Drawing.Size(827, 164);
            this.updateBox2.TabIndex = 2;
            this.updateBox2.TabStop = false;
            this.updateBox2.Text = "客户信息";
            // 
            // update_client_number_textbox
            // 
            this.update_client_number_textbox.Location = new System.Drawing.Point(252, 120);
            this.update_client_number_textbox.Name = "update_client_number_textbox";
            this.update_client_number_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_client_number_textbox.TabIndex = 5;
            // 
            // update_client_location_textbox
            // 
            this.update_client_location_textbox.Location = new System.Drawing.Point(252, 81);
            this.update_client_location_textbox.Name = "update_client_location_textbox";
            this.update_client_location_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_client_location_textbox.TabIndex = 4;
            // 
            // update_client_name_textbox
            // 
            this.update_client_name_textbox.Location = new System.Drawing.Point(252, 41);
            this.update_client_name_textbox.Name = "update_client_name_textbox";
            this.update_client_name_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_client_name_textbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "请输入修改后的客户电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "请输入修改后的客户地址：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入修改后的客户姓名 ：";
            // 
            // updateBox1
            // 
            this.updateBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateBox1.Controls.Add(this.update_order_id_textbox);
            this.updateBox1.Controls.Add(this.label1);
            this.updateBox1.Location = new System.Drawing.Point(3, 65);
            this.updateBox1.Margin = new System.Windows.Forms.Padding(10);
            this.updateBox1.Name = "updateBox1";
            this.updateBox1.Size = new System.Drawing.Size(827, 110);
            this.updateBox1.TabIndex = 1;
            this.updateBox1.TabStop = false;
            this.updateBox1.Text = "修改订单信息";
            // 
            // update_order_id_textbox
            // 
            this.update_order_id_textbox.Location = new System.Drawing.Point(252, 54);
            this.update_order_id_textbox.Name = "update_order_id_textbox";
            this.update_order_id_textbox.Size = new System.Drawing.Size(207, 27);
            this.update_order_id_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要修改的订单号：";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(323, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 20);
            this.title.TabIndex = 0;
            this.title.Text = "欢迎使用修改订单功能！";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 653);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateForm";
            this.Text = "更新订单功能界面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.updateBox3.ResumeLayout(false);
            this.updateBox3.PerformLayout();
            this.updateBox2.ResumeLayout(false);
            this.updateBox2.PerformLayout();
            this.updateBox1.ResumeLayout(false);
            this.updateBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox updateBox1;
        private Label title;
        private TextBox update_order_id_textbox;
        private Label label1;
        private GroupBox updateBox2;
        private GroupBox updateBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox update_client_number_textbox;
        private TextBox update_client_location_textbox;
        private TextBox update_client_name_textbox;
        private Button update_button;
        private TextBox update_goods_price_textbox;
        private TextBox update_goods_amount_textbox;
        private TextBox update_goods_name_textbox;
    }
}