namespace _41016_Ex10
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_id = new System.Windows.Forms.Label();
            this.Tb_id = new System.Windows.Forms.TextBox();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.Lb_name = new System.Windows.Forms.Label();
            this.Tb_Chi = new System.Windows.Forms.TextBox();
            this.Lb_Chi = new System.Windows.Forms.Label();
            this.Tb_Eng = new System.Windows.Forms.TextBox();
            this.Lb_Eng = new System.Windows.Forms.Label();
            this.Tb_Math = new System.Windows.Forms.TextBox();
            this.Lb_Math = new System.Windows.Forms.Label();
            this.Tb_total = new System.Windows.Forms.TextBox();
            this.Lb_total = new System.Windows.Forms.Label();
            this.Tb_show = new System.Windows.Forms.TextBox();
            this.Bt_search = new System.Windows.Forms.Button();
            this.Bt_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_id
            // 
            this.Lb_id.AutoSize = true;
            this.Lb_id.Location = new System.Drawing.Point(12, 15);
            this.Lb_id.Name = "Lb_id";
            this.Lb_id.Size = new System.Drawing.Size(29, 12);
            this.Lb_id.TabIndex = 0;
            this.Lb_id.Text = "學號";
            // 
            // Tb_id
            // 
            this.Tb_id.Location = new System.Drawing.Point(47, 12);
            this.Tb_id.Name = "Tb_id";
            this.Tb_id.Size = new System.Drawing.Size(100, 22);
            this.Tb_id.TabIndex = 1;
            // 
            // Tb_name
            // 
            this.Tb_name.Location = new System.Drawing.Point(47, 40);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.ReadOnly = true;
            this.Tb_name.Size = new System.Drawing.Size(100, 22);
            this.Tb_name.TabIndex = 3;
            // 
            // Lb_name
            // 
            this.Lb_name.AutoSize = true;
            this.Lb_name.Location = new System.Drawing.Point(12, 43);
            this.Lb_name.Name = "Lb_name";
            this.Lb_name.Size = new System.Drawing.Size(29, 12);
            this.Lb_name.TabIndex = 2;
            this.Lb_name.Text = "姓名";
            // 
            // Tb_Chi
            // 
            this.Tb_Chi.Location = new System.Drawing.Point(47, 69);
            this.Tb_Chi.Name = "Tb_Chi";
            this.Tb_Chi.ReadOnly = true;
            this.Tb_Chi.Size = new System.Drawing.Size(100, 22);
            this.Tb_Chi.TabIndex = 5;
            // 
            // Lb_Chi
            // 
            this.Lb_Chi.AutoSize = true;
            this.Lb_Chi.Location = new System.Drawing.Point(12, 72);
            this.Lb_Chi.Name = "Lb_Chi";
            this.Lb_Chi.Size = new System.Drawing.Size(29, 12);
            this.Lb_Chi.TabIndex = 4;
            this.Lb_Chi.Text = "國文";
            // 
            // Tb_Eng
            // 
            this.Tb_Eng.Location = new System.Drawing.Point(47, 97);
            this.Tb_Eng.Name = "Tb_Eng";
            this.Tb_Eng.ReadOnly = true;
            this.Tb_Eng.Size = new System.Drawing.Size(100, 22);
            this.Tb_Eng.TabIndex = 7;
            // 
            // Lb_Eng
            // 
            this.Lb_Eng.AutoSize = true;
            this.Lb_Eng.Location = new System.Drawing.Point(12, 100);
            this.Lb_Eng.Name = "Lb_Eng";
            this.Lb_Eng.Size = new System.Drawing.Size(29, 12);
            this.Lb_Eng.TabIndex = 6;
            this.Lb_Eng.Text = "英文";
            // 
            // Tb_Math
            // 
            this.Tb_Math.Location = new System.Drawing.Point(47, 125);
            this.Tb_Math.Name = "Tb_Math";
            this.Tb_Math.ReadOnly = true;
            this.Tb_Math.Size = new System.Drawing.Size(100, 22);
            this.Tb_Math.TabIndex = 9;
            // 
            // Lb_Math
            // 
            this.Lb_Math.AutoSize = true;
            this.Lb_Math.Location = new System.Drawing.Point(12, 128);
            this.Lb_Math.Name = "Lb_Math";
            this.Lb_Math.Size = new System.Drawing.Size(29, 12);
            this.Lb_Math.TabIndex = 8;
            this.Lb_Math.Text = "數學";
            // 
            // Tb_total
            // 
            this.Tb_total.Location = new System.Drawing.Point(47, 153);
            this.Tb_total.Name = "Tb_total";
            this.Tb_total.ReadOnly = true;
            this.Tb_total.Size = new System.Drawing.Size(100, 22);
            this.Tb_total.TabIndex = 11;
            // 
            // Lb_total
            // 
            this.Lb_total.AutoSize = true;
            this.Lb_total.Location = new System.Drawing.Point(12, 156);
            this.Lb_total.Name = "Lb_total";
            this.Lb_total.Size = new System.Drawing.Size(29, 12);
            this.Lb_total.TabIndex = 10;
            this.Lb_total.Text = "總分";
            // 
            // Tb_show
            // 
            this.Tb_show.Location = new System.Drawing.Point(153, 12);
            this.Tb_show.Multiline = true;
            this.Tb_show.Name = "Tb_show";
            this.Tb_show.Size = new System.Drawing.Size(299, 163);
            this.Tb_show.TabIndex = 12;
            // 
            // Bt_search
            // 
            this.Bt_search.Location = new System.Drawing.Point(76, 181);
            this.Bt_search.Name = "Bt_search";
            this.Bt_search.Size = new System.Drawing.Size(75, 23);
            this.Bt_search.TabIndex = 13;
            this.Bt_search.Text = "查詢";
            this.Bt_search.UseVisualStyleBackColor = true;
            this.Bt_search.Click += new System.EventHandler(this.Bt_search_Click);
            // 
            // Bt_sort
            // 
            this.Bt_sort.Location = new System.Drawing.Point(267, 181);
            this.Bt_sort.Name = "Bt_sort";
            this.Bt_sort.Size = new System.Drawing.Size(75, 23);
            this.Bt_sort.TabIndex = 14;
            this.Bt_sort.Text = "排序";
            this.Bt_sort.UseVisualStyleBackColor = true;
            this.Bt_sort.Click += new System.EventHandler(this.Bt_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 235);
            this.Controls.Add(this.Bt_sort);
            this.Controls.Add(this.Bt_search);
            this.Controls.Add(this.Tb_show);
            this.Controls.Add(this.Tb_total);
            this.Controls.Add(this.Lb_total);
            this.Controls.Add(this.Tb_Math);
            this.Controls.Add(this.Lb_Math);
            this.Controls.Add(this.Tb_Eng);
            this.Controls.Add(this.Lb_Eng);
            this.Controls.Add(this.Tb_Chi);
            this.Controls.Add(this.Lb_Chi);
            this.Controls.Add(this.Tb_name);
            this.Controls.Add(this.Lb_name);
            this.Controls.Add(this.Tb_id);
            this.Controls.Add(this.Lb_id);
            this.Name = "Form1";
            this.Text = "成績查詢";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_id;
        private System.Windows.Forms.TextBox Tb_id;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.Label Lb_name;
        private System.Windows.Forms.TextBox Tb_Chi;
        private System.Windows.Forms.Label Lb_Chi;
        private System.Windows.Forms.TextBox Tb_Eng;
        private System.Windows.Forms.Label Lb_Eng;
        private System.Windows.Forms.TextBox Tb_Math;
        private System.Windows.Forms.Label Lb_Math;
        private System.Windows.Forms.TextBox Tb_total;
        private System.Windows.Forms.Label Lb_total;
        private System.Windows.Forms.TextBox Tb_show;
        private System.Windows.Forms.Button Bt_search;
        private System.Windows.Forms.Button Bt_sort;
    }
}

