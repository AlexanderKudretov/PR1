using System;

public class Class1
{
	public Class1()
	{
		public partial class MainViewModel : Outputter
	Tasks = new ObservableCollection<string>();
		this.connectivity = connectivity; 
		}
[ObservableProperty]
ObservableCollection<string> tasks;

[ObservableProperty]
string taskTitle;

[RelayCommand]

async Task Add()
{
	if (string.IsNullOrWhiteSpace(taskTitle))
		return;
	if (connectivity.NetworkAccess != NetworkAccess.Internet)
	{
		await Shell.Current.DisplayAlert("ПР №1", "нет соединеия с интернетом", "ОК")
return;
	}
	Tasks.Add(TaskTitle);

	TaskTitle = string.Empty
		[RelayCommand]
		Void delete(string s)
	{
		if (Tasks.Contains(s))
		{
			Tasks.Remove(s);
		}
	}
	[RelayCommand]
	async Task Tap(string s)
	{
		await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");





