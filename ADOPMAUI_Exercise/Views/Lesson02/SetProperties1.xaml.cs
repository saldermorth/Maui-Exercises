using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson02;


public partial class SetProperties1 : ContentPage
{
    int _idx = 0;
    int count = 0;
    public List<NamedColor> _colors = NamedColor.All.ToList();

    public SetProperties1()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var pink = _colors.FindIndex(x => x.FriendlyName == "Pink");

        if (count < 1)
        {
            lblColorBox.Color = _colors[pink].Color;
            lblColorBox2.Color = _colors[pink].Color;
            lblColorBox3.Color = _colors[pink].Color;
            lblColorBox4.Color = _colors[pink].Color;
            lblColorBox5.Color = _colors[pink].Color;
            lblColorBox6.Color = _colors[pink].Color;
        }
        else
        {
            Random random = new Random();


            var color = random.Next(0, (_colors.Count - 1));
            lbl.Text = _colors[color].ToString();

            lblColorBox.Color = _colors[random.Next(0, (_colors.Count - 1))].Color;
            lblColorBox2.Color = _colors[random.Next(0, (_colors.Count - 1))].Color;
            lblColorBox3.Color = _colors[random.Next(0, (_colors.Count - 1))].Color;
            lblColorBox4.Color = _colors[random.Next(0, (_colors.Count - 1))].Color;
            lblColorBox5.Color = _colors[random.Next(0, (_colors.Count - 1))].Color;
            lblColorBox6.Color = _colors[random.Next(0, (_colors.Count - 1))].Color;



        }
        count++;

    }
}