using System;

public class Class1
{
	public Class1()
	{
	}
	[QueryProperty("Text", "Text")]
	public partial class DatailViewModel : ObservableObject
	{
		[ObservableProperty]
		string text;

		[RelayCommad]

		async Task Goback()
		{
			await Shell.Current.GoToAsync("..");
		}
	}