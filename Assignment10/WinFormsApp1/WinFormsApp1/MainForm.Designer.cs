namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_button2 = new System.Windows.Forms.Button();
            this.wrongurl_dataGridView = new System.Windows.Forms.DataGridView();
            this.righturl_dataGridView = new System.Windows.Forms.DataGridView();
            this.start_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seturl_text = new System.Windows.Forms.TextBox();
            this.starturl_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.righturl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongurl_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.righturl_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用爬虫程序！";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.start_button2);
            this.panel1.Controls.Add(this.wrongurl_dataGridView);
            this.panel1.Controls.Add(this.righturl_dataGridView);
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 692);
            this.panel1.TabIndex = 1;
            // 
            // start_button2
            // 
            this.start_button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_button2.Location = new System.Drawing.Point(532, 271);
            this.start_button2.Name = "start_button2";
            this.start_button2.Size = new System.Drawing.Size(200, 40);
            this.start_button2.TabIndex = 5;
            this.start_button2.Text = "启动爬虫（指定网站）";
            this.start_button2.UseVisualStyleBackColor = true;
            this.start_button2.Click += new System.EventHandler(this.start_button2_Click);
            // 
            // wrongurl_dataGridView
            // 
            this.wrongurl_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongurl_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wrongurl_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Text});
            this.wrongurl_dataGridView.Location = new System.Drawing.Point(437, 332);
            this.wrongurl_dataGridView.Name = "wrongurl_dataGridView";
            this.wrongurl_dataGridView.RowHeadersWidth = 51;
            this.wrongurl_dataGridView.RowTemplate.Height = 29;
            this.wrongurl_dataGridView.Size = new System.Drawing.Size(402, 357);
            this.wrongurl_dataGridView.TabIndex = 4;
            // 
            // righturl_dataGridView
            // 
            this.righturl_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.righturl_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.righturl_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.righturl});
            this.righturl_dataGridView.Location = new System.Drawing.Point(3, 332);
            this.righturl_dataGridView.Name = "righturl_dataGridView";
            this.righturl_dataGridView.RowHeadersWidth = 51;
            this.righturl_dataGridView.RowTemplate.Height = 29;
            this.righturl_dataGridView.Size = new System.Drawing.Size(428, 357);
            this.righturl_dataGridView.TabIndex = 3;
            // 
            // start_button
            // 
            this.start_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_button.Location = new System.Drawing.Point(119, 271);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(200, 40);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "启动爬虫（无指定网站）";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.seturl_text);
            this.groupBox1.Controls.Add(this.starturl_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网站信息";
            // 
            // seturl_text
            // 
            this.seturl_text.Location = new System.Drawing.Point(327, 102);
            this.seturl_text.Name = "seturl_text";
            this.seturl_text.Size = new System.Drawing.Size(437, 27);
            this.seturl_text.TabIndex = 3;
            // 
            // starturl_text
            // 
            this.starturl_text.Location = new System.Drawing.Point(327, 58);
            this.starturl_text.Name = "starturl_text";
            this.starturl_text.Size = new System.Drawing.Size(437, 27);
            this.starturl_text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "请输入指定爬虫网站（可为空）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入初始爬虫网站：";
            // 
            // righturl
            // 
            this.righturl.DataPropertyName = "url_text";
            this.righturl.HeaderText = "已经爬取的URL";
            this.righturl.MinimumWidth = 6;
            this.righturl.Name = "righturl";
            this.righturl.Width = 300;
            // 
            // Text
            // 
            this.Text.DataPropertyName = "url_text";
            this.Text.HeaderText = "错误的URL";
            this.Text.MinimumWidth = 6;
            this.Text.Name = "Text";
            this.Text.Width = 300;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 716);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrongurl_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.righturl_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView wrongurl_dataGridView;
        private DataGridView righturl_dataGridView;
        private Button start_button;
        private GroupBox groupBox1;
        private TextBox seturl_text;
        private TextBox starturl_text;
        private Label label3;
        private Label label2;
        private Button start_button2;
        private DataGridViewTextBoxColumn Text;
        private DataGridViewTextBoxColumn righturl;
    }
}