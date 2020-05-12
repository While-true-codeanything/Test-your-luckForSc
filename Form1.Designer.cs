namespace Test_your_luck
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Info1 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Info2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Info3 = new System.Windows.Forms.Label();
            this.Cof = new System.Windows.Forms.TextBox();
            this.CurCol = new System.Windows.Forms.Label();
            this.Info4 = new System.Windows.Forms.Label();
            this.Hidden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info1.Location = new System.Drawing.Point(40, 47);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(182, 48);
            this.Info1.TabIndex = 0;
            this.Info1.Text = "Enter a number \r\nbetween 0 and 10";
            this.Info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(318, 65);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(100, 20);
            this.Data.TabIndex = 1;
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enter.Location = new System.Drawing.Point(112, 143);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(249, 38);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Next try";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Location = new System.Drawing.Point(48, 226);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(40, 13);
            this.Info2.TabIndex = 3;
            this.Info2.Text = "Result:";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(96, 224);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(89, 20);
            this.Result.TabIndex = 4;
            this.Result.Visible = false;
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Location = new System.Drawing.Point(254, 224);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(140, 13);
            this.Info3.TabIndex = 5;
            this.Info3.Text = "The coefficient of bad luck: ";
            this.Info3.Visible = false;
            // 
            // Cof
            // 
            this.Cof.Location = new System.Drawing.Point(400, 221);
            this.Cof.Name = "Cof";
            this.Cof.ReadOnly = true;
            this.Cof.Size = new System.Drawing.Size(49, 20);
            this.Cof.TabIndex = 6;
            this.Cof.Visible = false;
            // 
            // CurCol
            // 
            this.CurCol.AutoSize = true;
            this.CurCol.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurCol.Location = new System.Drawing.Point(191, 279);
            this.CurCol.Name = "CurCol";
            this.CurCol.Size = new System.Drawing.Size(95, 47);
            this.CurCol.TabIndex = 7;
            this.CurCol.Text = "0/10";
            // 
            // Info4
            // 
            this.Info4.AutoSize = true;
            this.Info4.Location = new System.Drawing.Point(48, 258);
            this.Info4.Name = "Info4";
            this.Info4.Size = new System.Drawing.Size(85, 13);
            this.Info4.TabIndex = 8;
            this.Info4.Text = "Hidden number: ";
            // 
            // Hidden
            // 
            this.Hidden.Location = new System.Drawing.Point(148, 255);
            this.Hidden.Name = "Hidden";
            this.Hidden.ReadOnly = true;
            this.Hidden.Size = new System.Drawing.Size(37, 20);
            this.Hidden.TabIndex = 9;
            this.Hidden.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 335);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.Info4);
            this.Controls.Add(this.CurCol);
            this.Controls.Add(this.Cof);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Test your luck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label Info3;
        private System.Windows.Forms.TextBox Cof;
        private System.Windows.Forms.Label CurCol;
        private System.Windows.Forms.Label Info4;
        private System.Windows.Forms.TextBox Hidden;
    }
}

