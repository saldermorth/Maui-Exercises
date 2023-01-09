using ADOPMAUI_Exercise.Globals;
using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override void OnStart()
    {
        //Demonstrate State management
        //using Global variables
        Global.Data.Message = "Application Started";
        Global.Data.Time = DateTime.Now;

        Global.Data.myBlueFriends = Friend.Factory.CreateRandom(500).Where(f => f.FavoriteColor.FriendlyName.Contains("Blue")).ToList();

        //Exercise in Global add
        //a.	list of friends who’s favorite color contains the word “Blue”
        //b.	list of cities in Africa
        //c.	list of named colors with a friendly name that contain the word “Red”  
    }
}
