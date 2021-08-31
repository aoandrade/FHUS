using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LiveCharts; // biblioteca gráfica https://lvcharts.net/
using LiveCharts.Wpf; // biblioteca gráfica https://lvcharts.net/
using System.Windows.Media;
using System.Runtime.InteropServices;
using System.Media;
using System.Threading;


namespace Exemplo1
{
	/*
	 Prof. Adriano de Oliveira Andrade, PhD
	 adriano@ufu.br
	 Universidade Federal de Uberlândia
	 Curso de Graduação em Engenharia Biomédica
	 Disciplina: Interface Homem-Máquina em Saúde
     * Exemplo de interface homem-máquina baseada em eletromiografia
	 * 12 Jun 2019
	*/


	public partial class Form1 : Form
	{
		private delegate void SafeCallDelegate(Bitmap imagem);


		bool m_isThreadRunning;

		double[] m_ruidoChanX; //ruído do canal X
		double[] m_ruidoChanY; //ruído do canal Y
		double m_fs; // frequência de amostragem em Hz
		double m_thX; // limiar para o canal X
		double m_thY; // limiar para o canal Y
		double m_wndSize; // tamanho da janela para processamento de dados em ms
		Random m_random;
		Thread m_thread;

		private int m_dir_cursor; // direção do cursor (0 = Cursors.PanNorth; 1= Cursors.PanEast;  2 =  Cursors.PanSouth; 3= Cursors.PanWest)


		public Form1()
		{
			InitializeComponent();

		}

		public void WorkThreadFunction()
		{
			m_dir_cursor = 3;
			RotacionaCursor();

			//Simulação
			int [] StateChanX = new int[] { 0, 1, 1, 0, 0, 1 };
			int[] StateChanY = new int[]  { 0, 0, 0, 1, 1, 0 };
			double[] th = new double[] { 400, 400, 400, 300, 400, 300};
			int counter = 0;

			while (button6.Text == "Stop" && m_isThreadRunning == true)
				{
				try
				{
					counter = counter + 1;
					if (counter >= StateChanX.Length) counter = 0;

					// DOWN
					if(m_dir_cursor==0 && StateChanX[counter] ==1 && StateChanY[counter] == 0 & th[counter] >= 400)
					{
						VirtualMouse.Move(0, 10);
					}

					// LEFT
					if (m_dir_cursor == 1 && StateChanX[counter] == 1 && StateChanY[counter] == 0 & th[counter] >= 400)
					{
						VirtualMouse.Move(-10, 0);
					}
					// RIGHT
					if (m_dir_cursor == 3 && StateChanX[counter] == 1 && StateChanY[counter] == 0 & th[counter] >= 400)
					{
						VirtualMouse.Move(10, 0);
					}

					// UP
					if (m_dir_cursor == 2 && StateChanY[counter] == 1 & th[counter] >= 400)
					{
						VirtualMouse.Move(0, 10);
					}

					// SINGLE_CLICK
					if (StateChanX[counter] == 1 && StateChanY[counter] == 0 & th[counter] < 400)
					{
						VirtualMouse.LeftClick();
					}

					// ROTATE
					if (StateChanY[counter] == 1 & th[counter] < 400)
					{
						RotacionaCursor();
						Debug.WriteLine("ROTATE");

					}




					// do any background work

					System.Threading.Thread.Sleep(150);

					//	VirtualMouse.LeftClick();
					//	VirtualMouse.Move(10, 10);

				}
				catch (Exception ex)
				{
					// log errors
					Debug.WriteLine("Exception");
				}



			}
			
			
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			double[] X = new double[20];

			X[0] = 0.25;
			X[1] = -2.28;
			X[2] = 1.11;
			X[3] = 0.42;
			X[4] = -1.46;
			X[5] = 0.19;
			X[6] = -0.75;
			X[7] = -0.29;
			X[8] = 1.71;
			X[9] = -0.78;
			X[10] = -1.30;
			X[11] = -0.11;
			X[12] = -0.76;
			X[13] = 1.46;
			X[14] = 2.44;
			X[15] = 1.83;
			X[16] = 0.33;
			X[17] = 0.60;
			X[18] = -0.74;
			X[19] = -1.70;

			double m = MAV(X);
			double a = AUTOCORRABS(X);
			double c = STDABS(X);

			var sb = new System.Text.StringBuilder();

			sb.AppendLine(m.ToString());
			sb.AppendLine(a.ToString());
			sb.AppendLine(String.Format("{0:0.#####}", c));

			textBox1.Text = sb.ToString();
		}

		private double MAV(double[] s)
		{
			double m;

			int N = s.Count(); // Número de elementos do vetor
			double sum = 0; // somatório

			for (int i = 0; i < N; i++)
			{
				sum = sum + Math.Abs(s[i]);
			}

			m = sum / N;
			return m;
		}

		private double AUTOCORRABS(double[] s)
		{
			int m = 2; // atraso

			int N = s.Count(); // Número de elementos do vetor

			double sum = 0; // somatório

			for (int i = 0; i < N - m; i++)
			{
				sum = sum + Math.Abs(s[i]) * Math.Abs(s[i + m]);
			}

			return sum;
		}

		private double STDABS(double[] s)
		{
			int N = s.Count(); // Número de elementos do vetor

			double meanS = 0;

			foreach (double x in s)
			{
				meanS += x;
			}

			meanS = Math.Abs(meanS / N);

			double sum = 0; // somatório

			for (int i = 0; i < N; i++)
			{
				sum = sum + (Math.Abs(s[i]) - meanS) * (Math.Abs(s[i]) - meanS);
			}

			sum = Math.Sqrt(sum / N);

			return sum;
		}

		private double MEAN(double[] x)
		{
			// Cálculo da média das amostras de um vetor

			int N = x.Count(); //número de elementos de um vetor

			double sum = 0.0;

			for (int i = 0; i < N; i++)
			{
				sum = sum + x[i];
			}
			return sum / N; // média
		}

		private double MAX(double[] x)
		{
			// Calcula o valor máximo das amostras de um vetor
			double maxValue = x[0];

			for (int i = 0; i < x.Length; i++)
			{
				if (x[i] > maxValue)
				{
					maxValue = x[i];
				}
			}
			return maxValue;
		}


		private double EucDist(double[] x, double[] y)
		{
			double d; // distância Euclidiana
			int Nx = x.Count(); // número de amostras do vetor x
			int Ny = y.Count(); // número de amostras do vetor y

			// Deve-se verificar se o número de amostras de x e y é o mesmo, 
			// pois a distância Euclidian assume a igualdade do número de amostras

			double sum = 0.0; // somador

			if (Nx == Ny)
			{
				for (int i = 0; i < Nx; i++)
				{
					sum = sum + (x[i] - y[i]) * (x[i] - y[i]);
				}

				d = Math.Sqrt(sum);

				return d; // distância Euclidiana
			}
			else
			{
				return -1; // retorna um valor de distância negativa, indicando um erro
			}
		}

		private double CalculaLimiar(double[] xn, double w, double fs)
		{
			/*
			 * xn (série temporal discreta que representa uma atividade de ruído); 
			 * w (tamanho da janela de processamento em ms); 
			 * fs (frequência de amostragem de xn em Hz).
			*/

			double th = -1.0; //limiar 

			int nwnd = (int)Math.Floor(w * fs / 1000); // tamanho(nwnd) de cada janela em unidade de tempo discreto

			int numWnd = (int)Math.Floor((double)xn.Count() / nwnd);  //número de janelas (inteiras), sem sobreposição, que podem ser posicionadas sobre xn

			double[,] V = new double[3, numWnd]; // vetor de características V

			double[] auxVex = new double[nwnd]; // vetor que armazena amostras de uma janela

			double[] d = new double[numWnd]; // vetor para armazenamento das distâncias euclidianas

			int i1; //  índice inicial da janela

			double[] vt = new double[3]; // vetor modelo/template
			vt[0] = 0.0; //inicializando o vetor template com zero
			vt[1] = 0.0; //inicializando o vetor template com zero
			vt[2] = 0.0; //inicializando o vetor template com zero

			// Cálculo do vetor de características para cada janela
			for (int j = 0; j < numWnd; j++)
			{
				i1 = j * nwnd; //  índice inicial da janela

				Array.Copy(xn, i1, auxVex, 0, nwnd); // Essa função copia um trecho do vetor xn para o vetor auxiliar auxVec

				/*
				 * Veja o exemplo abaixo (não tem como executa - apenas ilustrativo)
				 data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
				 Array.Copy(data, 2, sub, 0, 3)
				 sub = {2, 3, 4}
				 */

				V[0, j] = MAV(auxVex);
				V[1, j] = AUTOCORRABS(auxVex);
				V[2, j] = STDABS(auxVex);

				// Acumulando o valor no vetor para o cálculo da média
				vt[0] += V[0, j];
				vt[1] += V[1, j];
				vt[2] += V[2, j];
			}

			// Cálculo do vetor template/modelo
			vt[0] = vt[0] / numWnd; // valor médio
			vt[1] = vt[1] / numWnd; // valor médio
			vt[2] = vt[2] / numWnd; // valor médio

			// Cálculo das distâncias entre o vetor modelo e cada vetor de característica 
			for (int j = 0; j < numWnd; j++)
			{
				double[] vcopy = new double[] { V[0, j], V[1, j], V[2, j] }; //cópia do vetor (deve-se extraí-lo da matriz)
				d[j] = EucDist(vt, vcopy);
			}

			// Cálculo do limiar
			th = MAX(d);

			return th;
		}



		private double[] GeraRuido(double t, double fs)
		{
			// Função responsável por gerar uma série temporal que representa uma atividade de ruído
			// t = duração em segundos
			// fs = frequência de amostragem em Hz

			int n = (int)Math.Floor(t * fs); // cálculo do número de amostras do vetor

			double[] ruido = new double[n]; // vetor ruido


			//var seed = (int)DateTime.Now.Ticks;
			//Random random = new Random(seed);


			for (int i = 0; i < n; i++)
			{
				ruido[i] = m_random.NextDouble(); // gera um número aleatório entre 0 e 1

			}

			return ruido; // retorna o ruído

		}


		private double[] GeraSinal(double t, double fs, double k)
		{
			// Função responsável por gerar uma série temporal que representa uma atividade de ruído
			// t = duração em segundos
			// fs = frequência de amostragem em Hz

			int n = (int)Math.Floor(t * fs); // cálculo do número de amostras do vetor

			double[] sinal = new double[n]; // vetor ruido

			for (int i = 0; i < n; i++)
			{
				sinal[i] = k * m_random.NextDouble(); // gera um número aleatório entre 0 e 1

			}
			return sinal; // retorna o sinal
		}


		private void Button2_Click(object sender, EventArgs e)
		{
			double t = 1.0; // segundos
			double fs = 500; // Hz

			double[] ruido2 = GeraRuido(t, fs); // ruído

			double[] sinal = GeraSinal(t, fs, 5.0); // ruído

			cartesianChart1.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Series 1",
					Values = new ChartValues<double>(ruido2),
					PointGeometry = null
				},

				new LineSeries
				{
					Title = "Series 2",
					Values = new ChartValues<double>(sinal),
					PointGeometry = null
				}
			};




		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void RichTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void InitializeTimer()
		{
			// Call this procedure when the application starts.  
			// Set to 1 second.  
			timer1.Interval = 1000;
			
			timer1.Tick += new EventHandler(Timer1_Tick);

			// Enable timer.  
			//timer1.Enabled = true;

			button6.Text = "Stop";
			button6.Click += new EventHandler(Button1_Click);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			double t = 1.0; // segundos
			m_fs = 500; // Hz
			m_wndSize = 100; // tamanho da janela de processamento de dados em ms

			m_random = new Random(); //iniciando o gerador de números aleatórios

			m_dir_cursor = 0;
			RotacionaCursor();
			//AjustaDirecaoCursor(m_dir_cursor);
			button6.Text = "Start";
			//InitializeTimer(); // inicializa timer

			SimulaColetaRuido(t, m_fs);
		}


		private void AjustaDirecaoCursor(int direcao)
		{

			switch (direcao)
			{

				//(0 = Cursors.PanNorth; 1= Cursors.PanEast;  2 =  Cursors.PanSouth; 3= Cursors.PanWest)
				case 0:

					this.Cursor = Cursors.PanNorth;
					
				//	this.Cursor.Cu = Cursors.PanNorth;
					m_dir_cursor = direcao;

					break;
				case 1:
					this.Cursor = Cursors.PanEast;
					//this.Cursor = Cursors.Hand;
					m_dir_cursor = direcao;
					break;

				case 2:
					this.Cursor = Cursors.PanSouth;
					m_dir_cursor = direcao;
					break;

				case 3:
					this.Cursor = Cursors.PanWest;
					m_dir_cursor = direcao;
					break;

			}

		}
			

		private void SimulaColetaRuido(double t, double fs)
		{
			m_ruidoChanX = GeraRuido(t, fs); // simulando a coleta de ruído do canal X
			m_ruidoChanY = GeraRuido(t, fs); // simulando a coleta de ruído do canal Y

			cartesianChart2.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "ruído do canal X",
					Values = new ChartValues<double>(m_ruidoChanX),
					PointGeometry = null
				}

			};


			cartesianChart3.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "ruído do canal Y",
					Values = new ChartValues<double>(m_ruidoChanY),
					PointGeometry = null
				}

			};
		}


		private void Button3_Click(object sender, EventArgs e)
		{
			double t = 1.0; // segundos
			double fs = 500; // Hz
			SimulaColetaRuido(t, fs);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			m_thX = CalculaLimiar(m_ruidoChanX, m_wndSize, m_fs);
			m_thY = CalculaLimiar(m_ruidoChanY, m_wndSize, m_fs);
			
			textBox2.Text = String.Format("{0:0.#####}", m_thX);
			textBox3.Text = String.Format("{0:0.#####}", m_thY);
		}


		private bool[]  getChanState(double[] sigChanX, double[] ruidoChanX, double[] sigChanY, double[] ruidoChanY)
		{

			bool[] state = new bool[2];

			double eucdistX = EucDist(ruidoChanX, sigChanX);
			double eucdistY = EucDist(ruidoChanY, sigChanY);

			if(eucdistX >= m_thX)
			{
				state[0] = true; // estado do canal X
			}
			else
			{
				state[0] = false; // estado do canal X

			}

			if (eucdistY >= m_thX)
			{
				state[1] = true; // estado do canal Y
			}
			else
			{
				state[1] = false; // estado do canal Y

			}

			return state; // vetor de retorno (estado de ambos os canais)

		}


		private void Button5_Click(object sender, EventArgs e)
		{
			//VirtualMouse.Move(10, 100);
			RotacionaCursor();

		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (button6.Text == "Start")
			{
				button6.Text = "Stop";
				//	timer1.Enabled = false;
				m_thread = new Thread(WorkThreadFunction);
				m_thread.Start();
				m_isThreadRunning = true;
			}
			else
			{
				button6.Text = "Start";
				m_isThreadRunning = false;

				if (m_thread != null)
				{
					m_thread.Abort();
				}
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			
		}

		private void WriteImageSafe(Bitmap image)
		{
			if (pictureBox1.InvokeRequired)
			{
				var d = new SafeCallDelegate(WriteImageSafe);
				Invoke(d, new object[] { image });
			}
			else
			{
				pictureBox1.Image = image;
			}
		}
		

		private void RotacionaCursor()
		{
			switch (m_dir_cursor)
			{

				//(0 = Cursors.PanNorth; 1= Cursors.PanEast;  2 =  Cursors.PanSouth; 3= Cursors.PanWest)
				case 0:

					//AjustaDirecaoCursor(1);
					m_dir_cursor = 1;
					Debug.Print("case 0");
					WriteImageSafe(Exemplo1.Properties.Resources.DOWN);
					//pictureBox1.Image = Exemplo1.Properties.Resources.DOWN;
					//	VirtualMouse.Move(1, 1);
					//Debug.Print(m_dir_cursor.ToString());
					break;
				case 1:

					//AjustaDirecaoCursor(2);
					m_dir_cursor = 2;
					Debug.Print("case 1");
					WriteImageSafe(Exemplo1.Properties.Resources.LEFT);
					
					//	VirtualMouse.Move(1, 1);

					//	Debug.Print(m_dir_cursor.ToString());
					break;

				case 2:

				//	AjustaDirecaoCursor(3);
					m_dir_cursor = 3;
					Debug.Print("case 2");
					WriteImageSafe(Exemplo1.Properties.Resources.UP);
					//	Debug.Print(m_dir_cursor.ToString());
					break;

				case 3:

					//AjustaDirecaoCursor(0);
					m_dir_cursor = 0;
					WriteImageSafe(Exemplo1.Properties.Resources.RIGHT);
					
					//	VirtualMouse.Move(1, 1);

					Debug.Print("case 3");
					break;
			}


		}

		private void Form1_CursorChanged(object sender, EventArgs e)
		{
			Debug.WriteLine("OI");
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			SystemSounds.Beep.Play();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			SystemSounds.Beep.Play();
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			SystemSounds.Beep.Play();
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			SystemSounds.Beep.Play();
		}
	}

	// Classe para gerar eventos do mouse
	public static class VirtualMouse
	{
		[DllImport("user32.dll")]
		static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
		private const int MOUSEEVENTF_MOVE = 0x0001;
		private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
		private const int MOUSEEVENTF_LEFTUP = 0x0004;
		private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
		private const int MOUSEEVENTF_RIGHTUP = 0x0010;
		private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
		private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
		private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
		public static void Move(int xDelta, int yDelta)
		{
			mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
		}
		public static void MoveTo(int x, int y)
		{
			mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
		}
		public static void LeftClick()
		{
			mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
			mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
		}

		public static void LeftDown()
		{
			mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
		}

		public static void LeftUp()
		{
			mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
		}

		public static void RightClick()
		{
			mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
			mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
		}

		public static void RightDown()
		{
			mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
		}

		public static void RightUp()
		{
			mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
		}
	}


}
