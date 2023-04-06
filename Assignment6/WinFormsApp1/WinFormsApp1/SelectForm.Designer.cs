namespace WinFormsApp1
{
    partial class SelectForm
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
            this.orderdetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectall_button = new System.Windows.Forms.Button();
            this.selectbyclient_button = new System.Windows.Forms.Button();
            this.selectbygoods_button = new System.Windows.Forms.Button();
            this.selectbyid_button = new System.Windows.Forms.Button();
            this.selectbysum_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.orderdetailsDataGridView);
            this.panel1.Controls.Add(this.key_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 627);
            this.panel1.TabIndex = 0;
            // 
            // orderdetailsDataGridView
            // 
            this.orderdetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderdetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderdetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.order_name,
            this.client_name,
            this.client_location,
            this.client_number,
            this.goods_name,
            this.goods_amount,
            this.goods_price,
            this.sumprice});
            this.orderdetailsDataGridView.Location = new System.Drawing.Point(3, 244);
            this.orderdetailsDataGridView.Name = "orderdetailsDataGridView";
            this.orderdetailsDataGridView.RowHeadersWidth = 51;
            this.orderdetailsDataGridView.RowTemplate.Height = 29;
            this.orderdetailsDataGridView.Size = new System.Drawing.Size(867, 378);
            this.orderdetailsDataGridView.TabIndex = 10;
            this.orderdetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "订单号";
            this.order_id.MinimumWidth = 6;
            this.order_id.Name = "order_id";
            this.order_id.Width = 125;
            // 
            // order_name
            // 
            this.order_name.DataPropertyName = "order_name";
            this.order_name.HeaderText = "订单名";
            this.order_name.MinimumWidth = 6;
            this.order_name.Name = "order_name";
            this.order_name.Width = 125;
            // 
            // client_name
            // 
            this.client_name.DataPropertyName = "client_name";
            this.client_name.HeaderText = "客户名";
            this.client_name.MinimumWidth = 6;
            this.client_name.Name = "client_name";
            this.client_name.Width = 125;
            // 
            // client_location
            // 
            this.client_location.DataPropertyName = "client_location";
            this.client_location.HeaderText = "客户地址";
            this.client_location.MinimumWidth = 6;
            this.client_location.Name = "client_location";
            this.client_location.Width = 125;
            // 
            // client_number
            // 
            this.client_number.DataPropertyName = "client_number";
            this.client_number.HeaderText = "客户电话";
            this.client_number.MinimumWidth = 6;
            this.client_number.Name = "client_number";
            this.client_number.Width = 125;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "商品名";
            this.goods_name.MinimumWidth = 6;
            this.goods_name.Name = "goods_name";
            this.goods_name.Width = 125;
            // 
            // goods_amount
            // 
            this.goods_amount.DataPropertyName = "goods_amount";
            this.goods_amount.HeaderText = "商品数量";
            this.goods_amount.MinimumWidth = 6;
            this.goods_amount.Name = "goods_amount";
            this.goods_amount.Width = 125;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            this.goods_price.HeaderText = "商品单价";
            this.goods_price.MinimumWidth = 6;
            this.goods_price.Name = "goods_price";
            this.goods_price.Width = 125;
            // 
            // sumprice
            // 
            this.sumprice.DataPropertyName = "sumprice";
            this.sumprice.HeaderText = "商品总价";
            this.sumprice.MinimumWidth = 6;
            this.sumprice.Name = "sumprice";
            this.sumprice.Width = 125;
            // 
            // key_textbox
            // 
            this.key_textbox.Location = new System.Drawing.Point(14, 110);
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(217, 27);
            this.key_textbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "请输入查询关键字：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择查询方式：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.selectall_button);
            this.flowLayoutPanel1.Controls.Add(this.selectbyclient_button);
            this.flowLayoutPanel1.Controls.Add(this.selectbygoods_button);
            this.flowLayoutPanel1.Controls.Add(this.selectbyid_button);
            this.flowLayoutPanel1.Controls.Add(this.selectbysum_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(867, 59);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // selectall_button
            // 
            this.selectall_button.Location = new System.Drawing.Point(10, 10);
            this.selectall_button.Margin = new System.Windows.Forms.Padding(10);
            this.selectall_button.Name = "selectall_button";
            this.selectall_button.Size = new System.Drawing.Size(140, 40);
            this.selectall_button.TabIndex = 0;
            this.selectall_button.Text = "查询所有订单";
            this.selectall_button.UseVisualStyleBackColor = true;
            this.selectall_button.Click += new System.EventHandler(this.selectall_button_Click);
            // 
            // selectbyclient_button
            // 
            this.selectbyclient_button.Location = new System.Drawing.Point(170, 10);
            this.selectbyclient_button.Margin = new System.Windows.Forms.Padding(10);
            this.selectbyclient_button.Name = "selectbyclient_button";
            this.selectbyclient_button.Size = new System.Drawing.Size(140, 40);
            this.selectbyclient_button.TabIndex = 1;
            this.selectbyclient_button.Text = "根据客户名查询";
            this.selectbyclient_button.UseVisualStyleBackColor = true;
            this.selectbyclient_button.Click += new System.EventHandler(this.selectbyclient_button_Click);
            // 
            // selectbygoods_button
            // 
            this.selectbygoods_button.Location = new System.Drawing.Point(330, 10);
            this.selectbygoods_button.Margin = new System.Windows.Forms.Padding(10);
            this.selectbygoods_button.Name = "selectbygoods_button";
            this.selectbygoods_button.Size = new System.Drawing.Size(140, 40);
            this.selectbygoods_button.TabIndex = 2;
            this.selectbygoods_button.Text = "根据商品名查询";
            this.selectbygoods_button.UseVisualStyleBackColor = true;
            this.selectbygoods_button.Click += new System.EventHandler(this.selectbygoods_button_Click);
            // 
            // selectbyid_button
            // 
            this.selectbyid_button.Location = new System.Drawing.Point(490, 10);
            this.selectbyid_button.Margin = new System.Windows.Forms.Padding(10);
            this.selectbyid_button.Name = "selectbyid_button";
            this.selectbyid_button.Size = new System.Drawing.Size(140, 40);
            this.selectbyid_button.TabIndex = 3;
            this.selectbyid_button.Text = "根据订单号查询";
            this.selectbyid_button.UseVisualStyleBackColor = true;
            this.selectbyid_button.Click += new System.EventHandler(this.selectbyid_button_Click);
            // 
            // selectbysum_button
            // 
            this.selectbysum_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectbysum_button.Location = new System.Drawing.Point(650, 10);
            this.selectbysum_button.Margin = new System.Windows.Forms.Padding(10);
            this.selectbysum_button.Name = "selectbysum_button";
            this.selectbysum_button.Size = new System.Drawing.Size(140, 40);
            this.selectbysum_button.TabIndex = 4;
            this.selectbysum_button.Text = "根据商品总价查询";
            this.selectbysum_button.UseVisualStyleBackColor = true;
            this.selectbysum_button.Click += new System.EventHandler(this.selectbysum_button_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(332, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(174, 20);
            this.title.TabIndex = 0;
            this.title.Text = "欢迎使用订单查询功能！";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 651);
            this.Controls.Add(this.panel1);
            this.Name = "SelectForm";
            this.Text = "查询订单功能界面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button selectbygoods_button;
        private Button selectbyid_button;
        private Button selectbysum_button;
        private Label title;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button selectall_button;
        private Button selectbyclient_button;
        private TextBox key_textbox;
        private DataGridView orderdetailsDataGridView;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn client_name;
        private DataGridViewTextBoxColumn client_location;
        private DataGridViewTextBoxColumn client_number;
        private DataGridViewTextBoxColumn goods_name;
        private DataGridViewTextBoxColumn goods_amount;
        private DataGridViewTextBoxColumn goods_price;
        private DataGridViewTextBoxColumn sumprice;
    }
}