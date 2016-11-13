namespace _02_Миллионер
{
    partial class FormDelQuestionByNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDelQuest = new System.Windows.Forms.TextBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.UpDown1delQuest = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1delQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер вопроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вопрос для удаления:";
            // 
            // textBoxDelQuest
            // 
            this.textBoxDelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelQuest.Location = new System.Drawing.Point(12, 88);
            this.textBoxDelQuest.Name = "textBoxDelQuest";
            this.textBoxDelQuest.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxDelQuest.Size = new System.Drawing.Size(247, 21);
            this.textBoxDelQuest.TabIndex = 3;
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelete.Location = new System.Drawing.Point(18, 124);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(113, 33);
            this.butDelete.TabIndex = 4;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancel.Location = new System.Drawing.Point(146, 124);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(113, 33);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // UpDown1delQuest
            // 
            this.UpDown1delQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDown1delQuest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpDown1delQuest.Location = new System.Drawing.Point(145, 20);
            this.UpDown1delQuest.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.UpDown1delQuest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown1delQuest.Name = "UpDown1delQuest";
            this.UpDown1delQuest.ReadOnly = true;
            this.UpDown1delQuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpDown1delQuest.Size = new System.Drawing.Size(113, 22);
            this.UpDown1delQuest.TabIndex = 6;
            this.UpDown1delQuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDown1delQuest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown1delQuest.ValueChanged += new System.EventHandler(this.UpDown1delQuest_ValueChanged);
            // 
            // FormDelQuestionByNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(276, 175);
            this.Controls.Add(this.UpDown1delQuest);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.textBoxDelQuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDelQuestionByNumber";
            this.Text = "Удаление вопроса";
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1delQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDelQuest;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.NumericUpDown UpDown1delQuest;

    }
}