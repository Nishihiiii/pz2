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
	public partial class Task3 : Page
	{
		public Task3()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				string[] inputParts = txtArrayInput.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (inputParts.Length < 3)
				{
					MessageBox.Show("Ошибка: введите как минимум 3 числа!", "Некорректный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
					return;
				}

				int[] numbers = new int[inputParts.Length];
				for (int i = 0; i < inputParts.Length; i++)
				{
					if (!int.TryParse(inputParts[i], out numbers[i]))
					{
						MessageBox.Show($"Ошибка: '{inputParts[i]}' не является целым числом!", "Некорректный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
						return;
					}
				}

				Array.Sort(numbers);
				int n = numbers.Length;

				int product1 = numbers[n - 1] * numbers[n - 2] * numbers[n - 3];
				int product2 = numbers[0] * numbers[1] * numbers[n - 1];

				if (product1 > product2)
				{
					txtResult.Text = $"Числа: {numbers[n - 3]}, {numbers[n - 2]}, {numbers[n - 1]}\nМаксимальное произведение: {product1}";
				}
				else
				{
					txtResult.Text = $"Числа: {numbers[0]}, {numbers[1]}, {numbers[n - 1]}\nМаксимальное произведение: {product2}";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
