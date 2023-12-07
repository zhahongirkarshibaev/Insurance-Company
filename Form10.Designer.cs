/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 03.05.2022
 * Время: 14:26
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Страховая_компания
{
	partial class Form10
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(128, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Страхование дома";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(93, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Укажите данные собственника";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(354, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Плоащадь дома";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 74);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(354, 20);
			this.textBox1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(354, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "ФИО Собственника: ";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 116);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(354, 20);
			this.textBox2.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Москва",
			"Московская область ",
			"Санкт-Петербург",
			"Архангельск",
			"Мурманск",
			"Нижний Новгород",
			"Казань ",
			"Оренбург"});
			this.comboBox1.Location = new System.Drawing.Point(13, 145);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(353, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.Text = "Выберите регион";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Срок страховки";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"1 месяц",
			"3 месяца",
			"6 месяцев",
			"12 месяцев ",
			"24 месяца"});
			this.comboBox2.Location = new System.Drawing.Point(125, 176);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(241, 21);
			this.comboBox2.TabIndex = 8;
			this.comboBox2.Text = "12 месяцев";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
			"Полный пакет",
			"Пожар/Взрыв/Потоп/Поджог",
			"Пожар/Взрыв/Поджог/Противоправные действия третьих лиц",
			"Пожар/Взрыв/Теракт/Стихийное бедствие",
			"Пожар/Залив/Кража"});
			this.comboBox3.Location = new System.Drawing.Point(13, 203);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(353, 21);
			this.comboBox3.TabIndex = 9;
			this.comboBox3.Text = "Страховые риски";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(151, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Оформить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form10";
			this.Text = "Дом";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
