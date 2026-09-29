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

	public partial class Task4 : Page
	{
		public Task4()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				int[] arr = txtArrayInput.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
											  .Select(int.Parse).ToArray();

				if (arr.Length == 0)
				{
					MessageBox.Show("Массив пуст!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
					return;
				}

				List<List<int>> intervals = new List<List<int>>();
				List<int> currentInterval = new List<int> { arr[0] };
				int? currentDirection = null;

				for (int i = 1; i < arr.Length; i++)
				{
					int direction = arr[i].CompareTo(arr[i - 1]);

					if (currentDirection == null && direction != 0)
					{
						currentDirection = direction;
					}

					if (direction == 0 || direction == currentDirection || currentDirection == null)
					{
						currentInterval.Add(arr[i]);
					}
					else
					{
						intervals.Add(currentInterval);
						currentInterval = new List<int> { arr[i] };
						currentDirection = direction;
					}
				}
				intervals.Add(currentInterval);

				int intervalsCount = intervals.Count;
				string resultText = $"Количество промежутков монотонности: {intervalsCount}\n";

				if (intervalsCount >= 2)
				{
					var first = intervals.First();
					var last = intervals.Last();

					intervals[0] = last;
					intervals[intervalsCount - 1] = first;
				}

				List<int> resultList = new List<int>();
				foreach (var interval in intervals)
				{
					resultList.AddRange(interval);
				}

				resultText += $"Новый массив: {string.Join(" ", resultList)}";
				txtResult.Text = resultText;
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка ввода! Убедитесь, что введены только числа через пробел.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
