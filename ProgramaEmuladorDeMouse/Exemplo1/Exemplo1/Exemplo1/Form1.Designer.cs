namespace Exemplo1
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
			this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button6 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(618, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(234, 71);
			this.button1.TabIndex = 0;
			this.button1.Text = "Calcula característica";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(871, 228);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(231, 71);
			this.textBox1.TabIndex = 1;
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Location = new System.Drawing.Point(632, 381);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(438, 126);
			this.cartesianChart1.TabIndex = 2;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(632, 529);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(438, 61);
			this.button2.TabIndex = 3;
			this.button2.Text = "Exemplo: gera ruído/sinal";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(487, 39);
			this.label1.TabIndex = 4;
			this.label1.Text = "Exemplo: cálculo de limiares ";
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(38, 66);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(524, 113);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "Na prática o sinal de ruído seria coletado com o indivíduo em repouso. Como temos" +
    " dois canais de informações, o X e o Y, o ruído deve ser coletado para cada cana" +
    "l.";
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
			// 
			// cartesianChart2
			// 
			this.cartesianChart2.Location = new System.Drawing.Point(38, 214);
			this.cartesianChart2.Name = "cartesianChart2";
			this.cartesianChart2.Size = new System.Drawing.Size(524, 100);
			this.cartesianChart2.TabIndex = 6;
			this.cartesianChart2.Text = "cartesianChart2";
			// 
			// cartesianChart3
			// 
			this.cartesianChart3.Location = new System.Drawing.Point(38, 343);
			this.cartesianChart3.Name = "cartesianChart3";
			this.cartesianChart3.Size = new System.Drawing.Size(524, 100);
			this.cartesianChart3.TabIndex = 7;
			this.cartesianChart3.Text = "cartesianChart3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Ruído do canal X";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 323);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Ruído do canal Y";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(38, 467);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(524, 40);
			this.button3.TabIndex = 10;
			this.button3.Text = "Simular coleta de ruído";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(38, 538);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(233, 52);
			this.button4.TabIndex = 11;
			this.button4.Text = "Calcular limiares";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(298, 568);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 12;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(422, 568);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(295, 538);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "th (canal X)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(419, 538);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "th (canal Y)";
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(1150, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(335, 75);
			this.button5.TabIndex = 16;
			this.button5.Text = "Rotaciona cursor";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(1150, 156);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(335, 52);
			this.button6.TabIndex = 17;
			this.button6.Text = "Start";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Exemplo1.Properties.Resources.DOWN;
			this.pictureBox1.Location = new System.Drawing.Point(1065, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(79, 74);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(1150, 224);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 66);
			this.button7.TabIndex = 19;
			this.button7.Text = "1";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(1380, 224);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 66);
			this.button8.TabIndex = 20;
			this.button8.Text = "2";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(1380, 377);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 66);
			this.button9.TabIndex = 21;
			this.button9.Text = "3";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9_Click);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(1150, 377);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 66);
			this.button10.TabIndex = 22;
			this.button10.Text = "4";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1155, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(228, 25);
			this.label6.TabIndex = 23;
			this.label6.Text = "Exemplo de simulação";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(613, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 25);
			this.label7.TabIndex = 24;
			this.label7.Text = "Exemplo";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1603, 611);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cartesianChart3);
			this.Controls.Add(this.cartesianChart2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.cartesianChart1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Exemplo de interface homem-máquina (IHMS - Enga Biomédica - Prof. Adriano Andrade" +
    ")";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.CursorChanged += new System.EventHandler(this.Form1_CursorChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private LiveCharts.WinForms.CartesianChart cartesianChart2;
		private LiveCharts.WinForms.CartesianChart cartesianChart3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

