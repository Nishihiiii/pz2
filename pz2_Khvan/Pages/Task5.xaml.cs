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

	public partial class Task5 : Page
	{
		public Task5()
		{
			InitializeComponent();
		}
		private void btnGenerate_Click(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(txtRows.Text, out int n) || !int.TryParse(txtCols.Text, out int m) || n <= 0 || m <= 0)
			{
				MessageBox.Show("Введите корректные размеры массива (N и M должны быть больше 0).", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
				return;
			}

			int[,] array = new int[n, m];
			int[] flatArray = new int[n * m];
			Random rnd = new Random();

			int min = int.MaxValue;
			int max = int.MinValue;
			int index = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					array[i, j] = rnd.Next(-10, 11);
					flatArray[index++] = array[i, j];

					if (array[i, j] < min) min = array[i, j];
					if (array[i, j] > max) max = array[i, j];
				}
			}

			txtOriginal.Text = FormatMatrix(flatArray, n, m);
			tbMinMax.Text = $"Мин: {min} | Макс: {max}";

			var ascArray = flatArray.OrderBy(x => x).ToArray();
			txtAscending.Text = FormatMatrix(ascArray, n, m);

			var descArray = flatArray.OrderByDescending(x => x).ToArray();
			txtDescending.Text = FormatMatrix(descArray, n, m);
		}

		private string FormatMatrix(int[] flatArr, int rows, int cols)
		{
			string result = "";
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					result += flatArr[i * cols + j].ToString().PadLeft(4);
				}
				result += "\n";
			}
			return result;

			// для коммита ыыыыыы
			//аааааааа
			//еще что то добавляемм
		}
	}
}

