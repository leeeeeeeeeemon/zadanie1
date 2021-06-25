using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using zadanie1;

namespace zadanie1
{
	public partial class Form1 : Form
	{
		public double fullSum = 0;
		public double pereplata = 0;
		public double srRpocent;

		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void doButton_Click(object sender, EventArgs e)
		{
			bool right = true;
			bool tryConvert = true;
			string[] daysAndProcent;
			do
			{
				try
				{
					int x = Convert.ToInt32(sumZaim.Text);
					int y = Convert.ToInt32(daysZaim.Text);
					break;
				}
				catch (FormatException)
				{
					MessageBox.Show("Неверно веденны данные");
					tryConvert = false;
				}
			} while (tryConvert);

			if (sumZaim.Text == "" || daysZaim.Text == "" ||
				(Convert.ToInt32(sumZaim.Text) > 500000 || Convert.ToInt32(sumZaim.Text) < 1) ||
				(Convert.ToInt32(daysZaim.Text) > 365 || Convert.ToInt32(daysZaim.Text) < 1))
			{
				right = false;
				MessageBox.Show("Неверно веденны данные");
			}

			if (right)
			{ 
				daysAndProcent = dayAndProcentText.Text.Split(' ');
			

				int sumZaima = Convert.ToInt32(sumZaim.Text);
				double[] procentOnDay = new double[Convert.ToInt32(daysZaim.Text)];

				for (int i = 0; i < procentOnDay.Length; i++) //default value procent
				{
					procentOnDay[i] = 0.9;
				}

				if (dayAndProcentText.Text != "")
				{
					for (int i = 0; i < daysAndProcent.Length; i++)
					{
						string[] SplitDateAndProcent = daysAndProcent[i].Split(':');
						procentOnDay[Convert.ToInt32(SplitDateAndProcent[0]) - 1] = Convert.ToDouble(SplitDateAndProcent[1]);
					}
				}
				for(int i = 0; i < procentOnDay.Length; i++)
				{
					pereplata += sumZaima / 100 * procentOnDay[i];
				}

				

				double sumProcent = 0;
				for(int i = 0; i < procentOnDay.Length; i++)
				{
					sumProcent += procentOnDay[i];
				}

				fullSum = sumZaima + pereplata;
				srRpocent = sumProcent / procentOnDay.Length;

				MessageBox.Show("Полная выплачиваемая сумма: " + fullSum + "\n" + "Сумма процентов по долгу (переплата): " + pereplata + "\n" + "Эффективная процентная ставка в день: " + srRpocent);
			}

		}
	}
}
