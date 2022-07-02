using System;
using System.Collections.Generic;
using TodoRestV2.Model;
using Xamarin.Forms;

namespace TodoRestV2.View
{
    public partial class TodoItemPage : ContentPage
    {

		bool isNewItem;

		public TodoItemPage(bool isNew = false)
		{
			InitializeComponent();
			isNewItem = isNew;
		}

		async void OnSaveButtonClicked(object sender, EventArgs e)
		{
			var todoItem = (TodoItem)BindingContext;
			await App.TodoManager.SaveTaskAsync(todoItem, isNewItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			var todoItem = (TodoItem)BindingContext;
			await App.TodoManager.DeleteTaskAsync(todoItem);
			await Navigation.PopAsync();
		}

		async void OnCancelButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}

