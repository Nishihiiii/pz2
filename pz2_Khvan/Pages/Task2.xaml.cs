using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz2_Khvan.Pages
{

	public partial class Task2 : Page
	{
		public Task2()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, RoutedEventArgs e)
		{
			string input = txtStringInput.Text;

			if (string.IsNullOrEmpty(input))
			{
				MessageBox.Show("Ошибка: строка не может быть пустой!", "Некорректный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}

			int openCount = 0;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '(')
				{
					openCount++;
				}
				else if (input[i] == ')')
				{
					openCount--;

					if (openCount < 0)
					{
						txtResult.Text = (i + 1).ToString();
						return;
					}
				}
			}

			if (openCount > 0)
			{
				txtResult.Text = "-1";
			}
			else
			{
				txtResult.Text = "0";
			}
		}
	}
}
