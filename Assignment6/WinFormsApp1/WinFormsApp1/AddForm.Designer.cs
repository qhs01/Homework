namespace WinFormsApp1
{
    partial class AddForm
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
            this.add_button = new System.Windows.Forms.Button();
            this.goodsBox = new System.Windows.Forms.GroupBox();
            this.add_goods_price_textbox = new System.Windows.Forms.TextBox();
            this.add_goods_amount_textbox = new System.Windows.Forms.TextBox();
            this.add_goods_name_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientBox = new System.Windows.Forms.GroupBox();
            this.add_client_number_textbox = new System.Windows.Forms.TextBox();
            this.add_client_location_textbox = new System.Windows.Forms.TextBox();
            this.add_client_name_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.GroupBox();
            this.add_order_name_textbox = new System.Windows.Forms.TextBox();
            this.add_order_id_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.goodsBox.SuspendLayout();
            this.clientBox.SuspendLayout();
            this.orderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.goodsBox);
            this.panel1.Controls.Add(this.clientBox);
            this.panel1.Controls.Add(this.orderBox);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 627);
            this.panel1.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add_button.Location = new System.Drawing.Point(361, 558);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(140, 40);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "确认添加此订单";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // goodsBox
            // 
            this.goodsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodsBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.goodsBox.Controls.Add(this.add_goods_price_textbox);
            this.goodsBox.Controls.Add(this.add_goods_amount_textbox);
            this.goodsBox.Controls.Add(this.add_goods_name_textbox);
            this.goodsBox.Controls.Add(this.label8);
            this.goodsBox.Controls.Add(this.label7);
            this.goodsBox.Controls.Add(this.label6);
            this.goodsBox.Location = new System.Drawing.Point(3, 377);
            this.goodsBox.Name = "goodsBox";
            this.goodsBox.Size = new System.Drawing.Size(850, 158);
            this.goodsBox.TabIndex = 3;
            this.goodsBox.TabStop = false;
            this.goodsBox.Text = "商品信息";
            this.goodsBox.Enter += new System.EventHandler(this.goodsBox_Enter);
            // 
            // add_goods_price_textbox
            // 
            this.add_goods_price_textbox.Location = new System.Drawing.Point(168, 108);
            this.add_goods_price_textbox.Name = "add_goods_price_textbox";
            this.add_goods_price_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_goods_price_textbox.TabIndex = 5;
            // 
            // add_goods_amount_textbox
            // 
            this.add_goods_amount_textbox.Location = new System.Drawing.Point(168, 70);
            this.add_goods_amount_textbox.Name = "add_goods_amount_textbox";
            this.add_goods_amount_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_goods_amount_textbox.TabIndex = 4;
            // 
            // add_goods_name_textbox
            // 
            this.add_goods_name_textbox.Location = new System.Drawing.Point(168, 33);
            this.add_goods_name_textbox.Name = "add_goods_name_textbox";
            this.add_goods_name_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_goods_name_textbox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "请输入商品单价：";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "请输入商品数量：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "请输入商品名称：";
            // 
            // clientBox
            // 
            this.clientBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clientBox.Controls.Add(this.add_client_number_textbox);
            this.clientBox.Controls.Add(this.add_client_location_textbox);
            this.clientBox.Controls.Add(this.add_client_name_textbox);
            this.clientBox.Controls.Add(this.label5);
            this.clientBox.Controls.Add(this.label4);
            this.clientBox.Controls.Add(this.label3);
            this.clientBox.Location = new System.Drawing.Point(3, 205);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(849, 166);
            this.clientBox.TabIndex = 2;
            this.clientBox.TabStop = false;
            this.clientBox.Text = "客户信息";
            // 
            // add_client_number_textbox
            // 
            this.add_client_number_textbox.Location = new System.Drawing.Point(167, 119);
            this.add_client_number_textbox.Name = "add_client_number_textbox";
            this.add_client_number_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_client_number_textbox.TabIndex = 5;
            // 
            // add_client_location_textbox
            // 
            this.add_client_location_textbox.Location = new System.Drawing.Point(167, 79);
            this.add_client_location_textbox.Name = "add_client_location_textbox";
            this.add_client_location_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_client_location_textbox.TabIndex = 4;
            // 
            // add_client_name_textbox
            // 
            this.add_client_name_textbox.Location = new System.Drawing.Point(167, 36);
            this.add_client_name_textbox.Name = "add_client_name_textbox";
            this.add_client_name_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_client_name_textbox.TabIndex = 3;
            this.add_client_name_textbox.TextChanged += new System.EventHandler(this.client_name_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "请输入客户电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "请输入客户地址：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入客户姓名：";
            // 
            // orderBox
            // 
            this.orderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.orderBox.Controls.Add(this.add_order_name_textbox);
            this.orderBox.Controls.Add(this.add_order_id_textbox);
            this.orderBox.Controls.Add(this.label2);
            this.orderBox.Controls.Add(this.label1);
            this.orderBox.Location = new System.Drawing.Point(4, 72);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(849, 127);
            this.orderBox.TabIndex = 1;
            this.orderBox.TabStop = false;
            this.orderBox.Text = "订单信息";
            this.orderBox.Enter += new System.EventHandler(this.orderBox_Enter);
            // 
            // add_order_name_textbox
            // 
            this.add_order_name_textbox.Location = new System.Drawing.Point(167, 78);
            this.add_order_name_textbox.Name = "add_order_name_textbox";
            this.add_order_name_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_order_name_textbox.TabIndex = 3;
            this.add_order_name_textbox.TextChanged += new System.EventHandler(this.order_name_textbox_TextChanged);
            // 
            // add_order_id_textbox
            // 
            this.add_order_id_textbox.Location = new System.Drawing.Point(167, 37);
            this.add_order_id_textbox.Name = "add_order_id_textbox";
            this.add_order_id_textbox.Size = new System.Drawing.Size(228, 27);
            this.add_order_id_textbox.TabIndex = 2;
            this.add_order_id_textbox.TextChanged += new System.EventHandler(this.add_order_id_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入订单名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入订单号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(344, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 20);
            this.title.TabIndex = 0;
            this.title.Text = "欢迎使用添加订单功能！";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Click += new System.EventHandler(this.title_Click_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 646);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "添加订单功能窗口";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.goodsBox.ResumeLayout(false);
            this.goodsBox.PerformLayout();
            this.clientBox.ResumeLayout(false);
            this.clientBox.PerformLayout();
            this.orderBox.ResumeLayout(false);
            this.orderBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label title;
        private GroupBox orderBox;
        private Label label2;
        private Label label1;
        private GroupBox clientBox;
        private TextBox add_order_name_textbox;
        private TextBox add_order_id_textbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox add_client_number_textbox;
        private TextBox add_client_location_textbox;
        private TextBox add_client_name_textbox;
        private GroupBox goodsBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox add_goods_price_textbox;
        private TextBox add_goods_amount_textbox;
        private TextBox add_goods_name_textbox;
        private Button add_button;
    }
}