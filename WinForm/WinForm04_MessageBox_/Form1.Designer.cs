namespace WinForm04_MessageBox_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Type = new System.Windows.Forms.GroupBox();
            this.RBOK = new System.Windows.Forms.RadioButton();
            this.RBCANCEL = new System.Windows.Forms.RadioButton();
            this.RBYESNO = new System.Windows.Forms.RadioButton();
            this.Icon = new System.Windows.Forms.GroupBox();
            this.RBQUES = new System.Windows.Forms.RadioButton();
            this.RBINFO = new System.Windows.Forms.RadioButton();
            this.RBERROR = new System.Windows.Forms.RadioButton();
            this.BTNSHOW = new System.Windows.Forms.Button();
            this.Type.SuspendLayout();
            this.Icon.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.Controls.Add(this.RBYESNO);
            this.Type.Controls.Add(this.RBCANCEL);
            this.Type.Controls.Add(this.RBOK);
            this.Type.Location = new System.Drawing.Point(22, 39);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(179, 100);
            this.Type.TabIndex = 0;
            this.Type.TabStop = false;
            this.Type.Text = "Type";
            // 
            // RBOK
            // 
            this.RBOK.AutoSize = true;
            this.RBOK.Location = new System.Drawing.Point(47, 21);
            this.RBOK.Name = "RBOK";
            this.RBOK.Size = new System.Drawing.Size(38, 16);
            this.RBOK.TabIndex = 0;
            this.RBOK.TabStop = true;
            this.RBOK.Text = "Ok";
            this.RBOK.UseVisualStyleBackColor = true;
            // 
            // RBCANCEL
            // 
            this.RBCANCEL.AutoSize = true;
            this.RBCANCEL.Location = new System.Drawing.Point(47, 43);
            this.RBCANCEL.Name = "RBCANCEL";
            this.RBCANCEL.Size = new System.Drawing.Size(82, 16);
            this.RBCANCEL.TabIndex = 1;
            this.RBCANCEL.TabStop = true;
            this.RBCANCEL.Text = "Ok Cancel";
            this.RBCANCEL.UseVisualStyleBackColor = true;
            // 
            // RBYESNO
            // 
            this.RBYESNO.AutoSize = true;
            this.RBYESNO.Location = new System.Drawing.Point(47, 64);
            this.RBYESNO.Name = "RBYESNO";
            this.RBYESNO.Size = new System.Drawing.Size(71, 16);
            this.RBYESNO.TabIndex = 2;
            this.RBYESNO.TabStop = true;
            this.RBYESNO.Text = "YES/NO";
            this.RBYESNO.UseVisualStyleBackColor = true;
            // 
            // Icon
            // 
            this.Icon.Controls.Add(this.RBQUES);
            this.Icon.Controls.Add(this.RBINFO);
            this.Icon.Controls.Add(this.RBERROR);
            this.Icon.Location = new System.Drawing.Point(280, 39);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(179, 100);
            this.Icon.TabIndex = 3;
            this.Icon.TabStop = false;
            this.Icon.Text = "Icon";
            // 
            // RBQUES
            // 
            this.RBQUES.AutoSize = true;
            this.RBQUES.Location = new System.Drawing.Point(47, 64);
            this.RBQUES.Name = "RBQUES";
            this.RBQUES.Size = new System.Drawing.Size(73, 16);
            this.RBQUES.TabIndex = 2;
            this.RBQUES.TabStop = true;
            this.RBQUES.Text = "Question";
            this.RBQUES.UseVisualStyleBackColor = true;
            // 
            // RBINFO
            // 
            this.RBINFO.AutoSize = true;
            this.RBINFO.Location = new System.Drawing.Point(47, 43);
            this.RBINFO.Name = "RBINFO";
            this.RBINFO.Size = new System.Drawing.Size(81, 16);
            this.RBINFO.TabIndex = 1;
            this.RBINFO.TabStop = true;
            this.RBINFO.Text = "Infomation";
            this.RBINFO.UseVisualStyleBackColor = true;
            // 
            // RBERROR
            // 
            this.RBERROR.AutoSize = true;
            this.RBERROR.Location = new System.Drawing.Point(47, 21);
            this.RBERROR.Name = "RBERROR";
            this.RBERROR.Size = new System.Drawing.Size(64, 16);
            this.RBERROR.TabIndex = 0;
            this.RBERROR.TabStop = true;
            this.RBERROR.Text = "ERROR";
            this.RBERROR.UseVisualStyleBackColor = true;
            // 
            // BTNSHOW
            // 
            this.BTNSHOW.Location = new System.Drawing.Point(404, 173);
            this.BTNSHOW.Name = "BTNSHOW";
            this.BTNSHOW.Size = new System.Drawing.Size(75, 23);
            this.BTNSHOW.TabIndex = 4;
            this.BTNSHOW.Text = "SHOW";
            this.BTNSHOW.UseVisualStyleBackColor = true;
            this.BTNSHOW.Click += new System.EventHandler(this.BTNSHOW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 214);
            this.Controls.Add(this.BTNSHOW);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.Type);
            this.Name = "Form1";
            this.Text = "MessageBox";
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.Icon.ResumeLayout(false);
            this.Icon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Type;
        private System.Windows.Forms.RadioButton RBYESNO;
        private System.Windows.Forms.RadioButton RBCANCEL;
        private System.Windows.Forms.RadioButton RBOK;
        private System.Windows.Forms.GroupBox Icon;
        private System.Windows.Forms.RadioButton RBQUES;
        private System.Windows.Forms.RadioButton RBINFO;
        private System.Windows.Forms.RadioButton RBERROR;
        private System.Windows.Forms.Button BTNSHOW;
    }
}

