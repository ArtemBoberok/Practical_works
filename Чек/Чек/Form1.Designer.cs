
namespace Чек
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxTovar = new System.Windows.Forms.GroupBox();
            this.numericUpDownCol = new System.Windows.Forms.NumericUpDown();
            this.textBoxSkidka = new System.Windows.Forms.TextBox();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSkidka = new System.Windows.Forms.Label();
            this.labelCol = new System.Windows.Forms.Label();
            this.labelPrise = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInf = new System.Windows.Forms.Label();
            this.textBoxInf = new System.Windows.Forms.TextBox();
            this.buttonKorzina = new System.Windows.Forms.Button();
            this.buttonKorzinaDel = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.groupBoxItog = new System.Windows.Forms.GroupBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxKassa = new System.Windows.Forms.TextBox();
            this.labelKassa = new System.Windows.Forms.Label();
            this.textBoxSkid = new System.Windows.Forms.TextBox();
            this.labelSkid = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonChekc = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).BeginInit();
            this.groupBoxItog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTovar
            // 
            this.groupBoxTovar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxTovar.Controls.Add(this.numericUpDownCol);
            this.groupBoxTovar.Controls.Add(this.textBoxSkidka);
            this.groupBoxTovar.Controls.Add(this.textBoxPrise);
            this.groupBoxTovar.Controls.Add(this.textBoxName);
            this.groupBoxTovar.Controls.Add(this.labelSkidka);
            this.groupBoxTovar.Controls.Add(this.labelCol);
            this.groupBoxTovar.Controls.Add(this.labelPrise);
            this.groupBoxTovar.Controls.Add(this.labelName);
            this.groupBoxTovar.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTovar.Name = "groupBoxTovar";
            this.groupBoxTovar.Size = new System.Drawing.Size(229, 137);
            this.groupBoxTovar.TabIndex = 0;
            this.groupBoxTovar.TabStop = false;
            this.groupBoxTovar.Text = "Сведение о товаре";
            this.groupBoxTovar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDownCol
            // 
            this.numericUpDownCol.Location = new System.Drawing.Point(73, 74);
            this.numericUpDownCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCol.Name = "numericUpDownCol";
            this.numericUpDownCol.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCol.TabIndex = 8;
            this.numericUpDownCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSkidka
            // 
            this.textBoxSkidka.Location = new System.Drawing.Point(73, 102);
            this.textBoxSkidka.Name = "textBoxSkidka";
            this.textBoxSkidka.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkidka.TabIndex = 7;
            this.textBoxSkidka.Text = "0";
            this.textBoxSkidka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSkidka_KeyPress);
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Location = new System.Drawing.Point(73, 43);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrise.TabIndex = 6;
            this.textBoxPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrise_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelSkidka
            // 
            this.labelSkidka.AutoSize = true;
            this.labelSkidka.Location = new System.Drawing.Point(7, 102);
            this.labelSkidka.Name = "labelSkidka";
            this.labelSkidka.Size = new System.Drawing.Size(55, 13);
            this.labelSkidka.TabIndex = 3;
            this.labelSkidka.Text = "Скидка %";
            // 
            // labelCol
            // 
            this.labelCol.AutoSize = true;
            this.labelCol.Location = new System.Drawing.Point(7, 74);
            this.labelCol.Name = "labelCol";
            this.labelCol.Size = new System.Drawing.Size(44, 13);
            this.labelCol.TabIndex = 2;
            this.labelCol.Text = "Кол-во:";
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Location = new System.Drawing.Point(7, 46);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(36, 13);
            this.labelPrise.TabIndex = 1;
            this.labelPrise.Text = "Цена:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelInf
            // 
            this.labelInf.AutoSize = true;
            this.labelInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInf.ForeColor = System.Drawing.Color.Red;
            this.labelInf.Location = new System.Drawing.Point(12, 162);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(239, 24);
            this.labelInf.TabIndex = 1;
            this.labelInf.Text = "Информация о товарах";
            // 
            // textBoxInf
            // 
            this.textBoxInf.Location = new System.Drawing.Point(13, 190);
            this.textBoxInf.Multiline = true;
            this.textBoxInf.Name = "textBoxInf";
            this.textBoxInf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInf.Size = new System.Drawing.Size(229, 120);
            this.textBoxInf.TabIndex = 2;
            this.textBoxInf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonKorzina
            // 
            this.buttonKorzina.Location = new System.Drawing.Point(13, 317);
            this.buttonKorzina.Name = "buttonKorzina";
            this.buttonKorzina.Size = new System.Drawing.Size(229, 27);
            this.buttonKorzina.TabIndex = 3;
            this.buttonKorzina.Text = "Добавить товар в корзину";
            this.buttonKorzina.UseVisualStyleBackColor = true;
            this.buttonKorzina.Click += new System.EventHandler(this.buttonKorzina_Click);
            // 
            // buttonKorzinaDel
            // 
            this.buttonKorzinaDel.Location = new System.Drawing.Point(12, 350);
            this.buttonKorzinaDel.Name = "buttonKorzinaDel";
            this.buttonKorzinaDel.Size = new System.Drawing.Size(66, 27);
            this.buttonKorzinaDel.TabIndex = 4;
            this.buttonKorzinaDel.Text = "Очистить корзину";
            this.buttonKorzinaDel.UseVisualStyleBackColor = true;
            this.buttonKorzinaDel.Click += new System.EventHandler(this.buttonKorzinaDel_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(181, 350);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(61, 27);
            this.buttonEnd.TabIndex = 5;
            this.buttonEnd.Text = "Выход";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // groupBoxItog
            // 
            this.groupBoxItog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxItog.Controls.Add(this.labelData);
            this.groupBoxItog.Controls.Add(this.labelTime);
            this.groupBoxItog.Controls.Add(this.textBoxKassa);
            this.groupBoxItog.Controls.Add(this.labelKassa);
            this.groupBoxItog.Controls.Add(this.textBoxSkid);
            this.groupBoxItog.Controls.Add(this.labelSkid);
            this.groupBoxItog.Controls.Add(this.textBoxSum);
            this.groupBoxItog.Controls.Add(this.labelSum);
            this.groupBoxItog.Location = new System.Drawing.Point(13, 389);
            this.groupBoxItog.Name = "groupBoxItog";
            this.groupBoxItog.Size = new System.Drawing.Size(229, 123);
            this.groupBoxItog.TabIndex = 6;
            this.groupBoxItog.TabStop = false;
            this.groupBoxItog.Text = "Итоговые расчеты";
            this.groupBoxItog.Visible = false;
            this.groupBoxItog.Enter += new System.EventHandler(this.groupBoxItog_Enter);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(63, 96);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 7;
            this.labelData.Text = "Дата";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(7, 96);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(49, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "00:00:00";
            // 
            // textBoxKassa
            // 
            this.textBoxKassa.Location = new System.Drawing.Point(102, 71);
            this.textBoxKassa.Name = "textBoxKassa";
            this.textBoxKassa.Size = new System.Drawing.Size(100, 20);
            this.textBoxKassa.TabIndex = 5;
            // 
            // labelKassa
            // 
            this.labelKassa.AutoSize = true;
            this.labelKassa.Location = new System.Drawing.Point(7, 71);
            this.labelKassa.Name = "labelKassa";
            this.labelKassa.Size = new System.Drawing.Size(46, 13);
            this.labelKassa.TabIndex = 4;
            this.labelKassa.Text = "В кассу";
            // 
            // textBoxSkid
            // 
            this.textBoxSkid.Location = new System.Drawing.Point(102, 45);
            this.textBoxSkid.Name = "textBoxSkid";
            this.textBoxSkid.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkid.TabIndex = 3;
            // 
            // labelSkid
            // 
            this.labelSkid.AutoSize = true;
            this.labelSkid.Location = new System.Drawing.Point(7, 45);
            this.labelSkid.Name = "labelSkid";
            this.labelSkid.Size = new System.Drawing.Size(80, 13);
            this.labelSkid.TabIndex = 2;
            this.labelSkid.Text = "Сумма скидки";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(102, 19);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 1;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(7, 19);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(96, 13);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "Сумма за товары";
            // 
            // buttonChekc
            // 
            this.buttonChekc.Location = new System.Drawing.Point(86, 350);
            this.buttonChekc.Name = "buttonChekc";
            this.buttonChekc.Size = new System.Drawing.Size(89, 27);
            this.buttonChekc.TabIndex = 7;
            this.buttonChekc.Text = "Вывести чек";
            this.buttonChekc.UseVisualStyleBackColor = true;
            this.buttonChekc.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 521);
            this.Controls.Add(this.buttonChekc);
            this.Controls.Add(this.groupBoxItog);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonKorzinaDel);
            this.Controls.Add(this.buttonKorzina);
            this.Controls.Add(this.textBoxInf);
            this.Controls.Add(this.labelInf);
            this.Controls.Add(this.groupBoxTovar);
            this.Name = "Form1";
            this.Text = "Чек за товар";
            this.groupBoxTovar.ResumeLayout(false);
            this.groupBoxTovar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).EndInit();
            this.groupBoxItog.ResumeLayout(false);
            this.groupBoxItog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTovar;
        private System.Windows.Forms.TextBox textBoxSkidka;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSkidka;
        private System.Windows.Forms.Label labelCol;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInf;
        private System.Windows.Forms.TextBox textBoxInf;
        private System.Windows.Forms.Button buttonKorzina;
        private System.Windows.Forms.Button buttonKorzinaDel;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.GroupBox groupBoxItog;
        private System.Windows.Forms.TextBox textBoxKassa;
        private System.Windows.Forms.Label labelKassa;
        private System.Windows.Forms.TextBox textBoxSkid;
        private System.Windows.Forms.Label labelSkid;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.NumericUpDown numericUpDownCol;
        private System.Windows.Forms.Button buttonChekc;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
    }
}

