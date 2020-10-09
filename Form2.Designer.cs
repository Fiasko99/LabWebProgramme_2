namespace LabWebProgramme_2
{
    partial class Form2
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
            this.textMessage = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SendFile = new System.Windows.Forms.Button();
            this.textMessageLabel = new System.Windows.Forms.Label();
            this.userGetMessage = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.GetFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(12, 137);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(714, 90);
            this.textMessage.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(714, 45);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Впишите логин другого пользователя";
            // 
            // SendFile
            // 
            this.SendFile.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendFile.Location = new System.Drawing.Point(214, 323);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(236, 50);
            this.SendFile.TabIndex = 7;
            this.SendFile.Text = "Отправить";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // textMessageLabel
            // 
            this.textMessageLabel.AutoSize = true;
            this.textMessageLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessageLabel.Location = new System.Drawing.Point(12, 89);
            this.textMessageLabel.Name = "textMessageLabel";
            this.textMessageLabel.Size = new System.Drawing.Size(392, 45);
            this.textMessageLabel.TabIndex = 8;
            this.textMessageLabel.Text = "Сообщение к файлу";
            // 
            // userGetMessage
            // 
            this.userGetMessage.Location = new System.Drawing.Point(20, 58);
            this.userGetMessage.Name = "userGetMessage";
            this.userGetMessage.Size = new System.Drawing.Size(384, 20);
            this.userGetMessage.TabIndex = 9;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(12, 254);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(288, 30);
            this.fileName.TabIndex = 10;
            this.fileName.Text = "Наименование файла";
            // 
            // GetFile
            // 
            this.GetFile.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetFile.Location = new System.Drawing.Point(496, 254);
            this.GetFile.Name = "GetFile";
            this.GetFile.Size = new System.Drawing.Size(218, 30);
            this.GetFile.TabIndex = 11;
            this.GetFile.Text = "Выбрать файл";
            this.GetFile.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.GetFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.userGetMessage);
            this.Controls.Add(this.textMessageLabel);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.textMessage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.Label textMessageLabel;
        private System.Windows.Forms.TextBox userGetMessage;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button GetFile;
    }
}