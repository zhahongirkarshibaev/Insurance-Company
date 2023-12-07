/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 03.05.2022
 * Время: 18:33
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Страховая_компания
{
	partial class Form15
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(136, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Что делать при отмене поездки";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(430, 44);
			this.label2.TabIndex = 1;
			this.label2.Text = "1. Незамедлительно уведомите туристическую организацию и Страховую Компанию о нев" +
	"озможности совершить поездку с обязательным указанием причины, по которой поездк" +
	"а стала невозможной;";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(430, 45);
			this.label3.TabIndex = 2;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(430, 45);
			this.label4.TabIndex = 3;
			this.label4.Text = "3. Незамедлительно уведомите Сервисную компанию о необходимости досрочного возвра" +
	"щения из поездки с указанием причины возвращения к месту постоянного проживания." +
	"";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(430, 34);
			this.label5.TabIndex = 4;
			this.label5.Text = "4. В течение 35 календарных дней после начала предполагаемой поездки заявите в Ст" +
	"раховую Компанию о случившемся.";
			// 
			// Form15
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 261);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form15";
			this.Text = "Отмеа поездки";
			this.ResumeLayout(false);

		}
	}
}
