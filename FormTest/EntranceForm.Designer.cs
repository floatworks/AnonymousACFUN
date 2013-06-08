namespace FormTest
{
    partial class EntranceForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.tb_Response = new System.Windows.Forms.TextBox();
            this.lb_UrlPre = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(192, 13);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(578, 25);
            this.tb_Url.TabIndex = 0;
            this.tb_Url.Text = "Metadata";
            // 
            // tb_Response
            // 
            this.tb_Response.Location = new System.Drawing.Point(13, 45);
            this.tb_Response.Multiline = true;
            this.tb_Response.Name = "tb_Response";
            this.tb_Response.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Response.Size = new System.Drawing.Size(757, 458);
            this.tb_Response.TabIndex = 1;
            // 
            // lb_UrlPre
            // 
            this.lb_UrlPre.AutoSize = true;
            this.lb_UrlPre.Location = new System.Drawing.Point(12, 16);
            this.lb_UrlPre.Name = "lb_UrlPre";
            this.lb_UrlPre.Size = new System.Drawing.Size(183, 15);
            this.lb_UrlPre.TabIndex = 2;
            this.lb_UrlPre.Text = "http://h.acfun.tv/api/";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(695, 520);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lb_UrlPre);
            this.Controls.Add(this.tb_Response);
            this.Controls.Add(this.tb_Url);
            this.Name = "EntranceForm";
            this.Text = "h.acfun.tv FormTest";
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Url;
        private System.Windows.Forms.TextBox tb_Response;
        private System.Windows.Forms.Label lb_UrlPre;
        private System.Windows.Forms.Button btn_Submit;
    }
}

