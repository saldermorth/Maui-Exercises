using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson02;


public partial class SetProperties1 : ContentPage
{
	int _idx = 0;
	List<NamedColor> _colors = NamedColor.All.ToList();

	public SetProperties1()
	{
		InitializeComponent();
    }
}