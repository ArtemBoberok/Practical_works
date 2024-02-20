namespace Lab10_BobrikovAA
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
            this.labFig = new System.Windows.Forms.Label();
            this.textBoxFig = new System.Windows.Forms.TextBox();
            this.labCen = new System.Windows.Forms.Label();
            this.labSide = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labFig
            // 
            this.labFig.AutoSize = true;
            this.labFig.Location = new System.Drawing.Point(13, 13);
            this.labFig.Name = "labFig";
            this.labFig.Size = new System.Drawing.Size(110, 13);
            this.labFig.TabIndex = 0;
            this.labFig.Text = "Название квадрата:";
            // 
            // textBoxFig
            // 
            this.textBoxFig.Location = new System.Drawing.Point(16, 30);
            this.textBoxFig.Name = "textBoxFig";
            this.textBoxFig.Size = new System.Drawing.Size(305, 20);
            this.textBoxFig.TabIndex = 1;
            // 
            // labCen
            // 
            this.labCen.AutoSize = true;
            this.labCen.Location = new System.Drawing.Point(13, 76);
            this.labCen.Name = "labCen";
            this.labCen.Size = new System.Drawing.Size(91, 13);
            this.labCen.TabIndex = 2;
            this.labCen.Text = "Центр квадрата:";
            // 
            // labSide
            // 
            this.labSide.AutoSize = true;
            this.labSide.Location = new System.Drawing.Point(219, 76);
            this.labSide.Name = "labSide";
            this.labSide.Size = new System.Drawing.Size(102, 13);
            this.labSide.TabIndex = 3;
            this.labSide.Text = "Сторона квадрата:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 5;
            // 
            // butInf
            // 
            this.butInf.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butInf.Location = new System.Drawing.Point(123, 124);
            this.butInf.Name = "butInf";
            this.butInf.Size = new System.Drawing.Size(172, 38);
            this.butInf.TabIndex = 6;
            this.butInf.Text = "Вывод информации о квадрате";
            this.butInf.UseVisualStyleBackColor = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 232);
            this.Controls.Add(this.butInf);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labSide);
            this.Controls.Add(this.labCen);
            this.Controls.Add(this.textBoxFig);
            this.Controls.Add(this.labFig);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Класс \"Квадрат\": центр квадрата и его сторона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFig;
        private System.Windows.Forms.TextBox textBoxFig;
        private System.Windows.Forms.Label labCen;
        private System.Windows.Forms.Label labSide;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butInf;
    }
}

