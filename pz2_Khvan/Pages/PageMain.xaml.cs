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

	public partial class PageMain : Page
	{
		public PageMain()
		{
			InitializeComponent();
		}

		private void btnTask1_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Task1());
		}

		private void btnTask2_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Task2());
		}

		private void btnTask3_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Task3());
		}

		private void btnTask4_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Task4());
		}

		private void btnTask5_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Task5());
		}
	}
}
