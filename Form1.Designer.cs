/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 03.05.2022
 * Время: 10:58
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Страховая_компания
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button10;
		
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
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Авто";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(105, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Здоровье ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(200, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Имущество ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(293, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Путишествие";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 114);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(70, 36);
			this.button3.TabIndex = 6;
			this.button3.Text = "Зелёная карта";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 36);
			this.button1.TabIndex = 7;
			this.button1.Text = "Каско";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(70, 36);
			this.button2.TabIndex = 8;
			this.button2.Text = "Осаго";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(105, 30);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(70, 36);
			this.button4.TabIndex = 9;
			this.button4.Text = "Школьная пора";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(105, 114);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(70, 36);
			this.button5.TabIndex = 10;
			this.button5.Text = "Антиклещ";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(105, 72);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(70, 36);
			this.button6.TabIndex = 11;
			this.button6.Text = "Антивирус";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(200, 30);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(70, 36);
			this.button7.TabIndex = 12;
			this.button7.Text = "Квартира";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(200, 72);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(70, 36);
			this.button8.TabIndex = 13;
			this.button8.Text = "Дом";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(293, 30);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(70, 36);
			this.button10.TabIndex = 15;
			this.button10.Text = "В отпуск";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 261);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Купить полис";
			this.ResumeLayout(false);

		}
	}
}
