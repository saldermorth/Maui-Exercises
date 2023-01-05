using ADOPMAUI_Exercise.Models;
using ADOPMAUI_Exercise.Views.Lesson05;
using Microsoft.Maui;

namespace ADOPMAUI_Exercise;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Exercise ShellMenu: Adding an item to a Shell Menu in C#
        var NewsPapers = NewsSource.All;

        Tab aTab;
        foreach (var item in NewsPapers)
        {
            //Create a Tab, set its relevant properties
            //Create a ShellContent , set its relevant properties
            //Add the ShellContent into the Tab
            
            //Add the Tab into lesson5news2 flyout item from the Xaml page
            //Your code
        }
    }
}
