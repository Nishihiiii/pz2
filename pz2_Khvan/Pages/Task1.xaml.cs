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

	public partial class Task1 : Page
	{
		public Task1()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, RoutedEventArgs e)
		{

			if (int.TryParse(txtYearInput.Text, out int year) && year > 0)
			{

				int century = (year - 1) / 100 + 1;
				txtResult.Text = $"Номер столетия: {century}";
			}
			else
			{
				MessageBox.Show("Ошибка: введите положительное целое число!", "Некорректный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
				txtResult.Text = string.Empty;
				txtYearInput.Clear();
				txtYearInput.Focus();
			}
		}
	}
}
