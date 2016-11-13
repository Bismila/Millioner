namespace _02_Миллионер
{
    partial class FormEditQuest
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
            this.labelNumberQuest = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelEnterQuest = new System.Windows.Forms.Label();
            this.textBoxNewQuest = new System.Windows.Forms.TextBox();
            this.labelEditFirstAnsw = new System.Windows.Forms.Label();
            this.textBoxFirstAnsw = new System.Windows.Forms.TextBox();
            this.textBoxSecondAnsw = new System.Windows.Forms.TextBox();
            this.labelEditSecondAnsw = new System.Windows.Forms.Label();
            this.textBoxFourthAnsw = new System.Windows.Forms.TextBox();
            this.labelEditFourthAnsw = new System.Windows.Forms.Label();
            this.textBoxThirdAnsw = new System.Windows.Forms.TextBox();
            this.labelEditThirdAnsw = new System.Windows.Forms.Label();
            this.buttEdit = new System.Windows.Forms.Button();
            this.buttCanselEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumberQuest
            // 
            this.labelNumberQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberQuest.Location = new System.Drawing.Point(9, 9);
            this.labelNumberQuest.Name = "labelNumberQuest";
            this.labelNumberQuest.Size = new System.Drawing.Size(147, 20);
            this.labelNumberQuest.TabIndex = 0;
            this.labelNumberQuest.Text = "Номер вопроса:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Location = new System.Drawing.Point(175, 9);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(94, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelEnterQuest
            // 
            this.labelEnterQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterQuest.Location = new System.Drawing.Point(9, 42);
            this.labelEnterQuest.Name = "labelEnterQuest";
            this.labelEnterQuest.Size = new System.Drawing.Size(298, 20);
            this.labelEnterQuest.TabIndex = 2;
            this.labelEnterQuest.Text = "Введите новый вопрос:";
            // 
            // textBoxNewQuest
            // 
            this.textBoxNewQuest.Location = new System.Drawing.Point(12, 65);
            this.textBoxNewQuest.Multiline = true;
            this.textBoxNewQuest.Name = "textBoxNewQuest";
            this.textBoxNewQuest.Size = new System.Drawing.Size(295, 54);
            this.textBoxNewQuest.TabIndex = 3;
            // 
            // labelEditFirstAnsw
            // 
            this.labelEditFirstAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditFirstAnsw.Location = new System.Drawing.Point(12, 133);
            this.labelEditFirstAnsw.Name = "labelEditFirstAnsw";
            this.labelEditFirstAnsw.Size = new System.Drawing.Size(295, 20);
            this.labelEditFirstAnsw.TabIndex = 4;
            this.labelEditFirstAnsw.Text = "Введите первый вариант ответа (верный):";
            // 
            // textBoxFirstAnsw
            // 
            this.textBoxFirstAnsw.Location = new System.Drawing.Point(12, 156);
            this.textBoxFirstAnsw.Name = "textBoxFirstAnsw";
            this.textBoxFirstAnsw.Size = new System.Drawing.Size(295, 20);
            this.textBoxFirstAnsw.TabIndex = 5;
            // 
            // textBoxSecondAnsw
            // 
            this.textBoxSecondAnsw.Location = new System.Drawing.Point(12, 211);
            this.textBoxSecondAnsw.Name = "textBoxSecondAnsw";
            this.textBoxSecondAnsw.Size = new System.Drawing.Size(295, 20);
            this.textBoxSecondAnsw.TabIndex = 7;
            // 
            // labelEditSecondAnsw
            // 
            this.labelEditSecondAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditSecondAnsw.Location = new System.Drawing.Point(12, 188);
            this.labelEditSecondAnsw.Name = "labelEditSecondAnsw";
            this.labelEditSecondAnsw.Size = new System.Drawing.Size(295, 20);
            this.labelEditSecondAnsw.TabIndex = 6;
            this.labelEditSecondAnsw.Text = "Введите второй вариант ответа:";
            // 
            // textBoxFourthAnsw
            // 
            this.textBoxFourthAnsw.Location = new System.Drawing.Point(12, 320);
            this.textBoxFourthAnsw.Name = "textBoxFourthAnsw";
            this.textBoxFourthAnsw.Size = new System.Drawing.Size(295, 20);
            this.textBoxFourthAnsw.TabIndex = 11;
            // 
            // labelEditFourthAnsw
            // 
            this.labelEditFourthAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditFourthAnsw.Location = new System.Drawing.Point(12, 297);
            this.labelEditFourthAnsw.Name = "labelEditFourthAnsw";
            this.labelEditFourthAnsw.Size = new System.Drawing.Size(295, 20);
            this.labelEditFourthAnsw.TabIndex = 10;
            this.labelEditFourthAnsw.Text = "Введите четвертый вариант ответа:";
            // 
            // textBoxThirdAnsw
            // 
            this.textBoxThirdAnsw.Location = new System.Drawing.Point(12, 265);
            this.textBoxThirdAnsw.Name = "textBoxThirdAnsw";
            this.textBoxThirdAnsw.Size = new System.Drawing.Size(295, 20);
            this.textBoxThirdAnsw.TabIndex = 9;
            // 
            // labelEditThirdAnsw
            // 
            this.labelEditThirdAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditThirdAnsw.Location = new System.Drawing.Point(12, 242);
            this.labelEditThirdAnsw.Name = "labelEditThirdAnsw";
            this.labelEditThirdAnsw.Size = new System.Drawing.Size(295, 20);
            this.labelEditThirdAnsw.TabIndex = 8;
            this.labelEditThirdAnsw.Text = "Введите третий вариант ответа:";
            // 
            // buttEdit
            // 
            this.buttEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttEdit.Location = new System.Drawing.Point(16, 356);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(140, 33);
            this.buttEdit.TabIndex = 12;
            this.buttEdit.Text = "Изменить";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // buttCanselEdit
            // 
            this.buttCanselEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttCanselEdit.Location = new System.Drawing.Point(166, 356);
            this.buttCanselEdit.Name = "buttCanselEdit";
            this.buttCanselEdit.Size = new System.Drawing.Size(140, 33);
            this.buttCanselEdit.TabIndex = 13;
            this.buttCanselEdit.Text = "Отмена";
            this.buttCanselEdit.UseVisualStyleBackColor = true;
            this.buttCanselEdit.Click += new System.EventHandler(this.buttCanselEdit_Click);
            // 
            // FormEditQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 401);
            this.Controls.Add(this.buttCanselEdit);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.textBoxFourthAnsw);
            this.Controls.Add(this.labelEditFourthAnsw);
            this.Controls.Add(this.textBoxThirdAnsw);
            this.Controls.Add(this.labelEditThirdAnsw);
            this.Controls.Add(this.textBoxSecondAnsw);
            this.Controls.Add(this.labelEditSecondAnsw);
            this.Controls.Add(this.textBoxFirstAnsw);
            this.Controls.Add(this.labelEditFirstAnsw);
            this.Controls.Add(this.textBoxNewQuest);
            this.Controls.Add(this.labelEnterQuest);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.labelNumberQuest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditQuest";
            this.Text = "Редактировать вопрос";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberQuest;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelEnterQuest;
        private System.Windows.Forms.TextBox textBoxNewQuest;
        private System.Windows.Forms.Label labelEditFirstAnsw;
        private System.Windows.Forms.TextBox textBoxFirstAnsw;
        private System.Windows.Forms.TextBox textBoxSecondAnsw;
        private System.Windows.Forms.Label labelEditSecondAnsw;
        private System.Windows.Forms.TextBox textBoxFourthAnsw;
        private System.Windows.Forms.Label labelEditFourthAnsw;
        private System.Windows.Forms.TextBox textBoxThirdAnsw;
        private System.Windows.Forms.Label labelEditThirdAnsw;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Button buttCanselEdit;
    }
}