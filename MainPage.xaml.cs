using Plugin.LocalNotification;

namespace NotificationApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnLeftSwipe(object sender, EventArgs e)
        {
			/*
            // Trigger a local notification for "Favorite" swipe action
            var notification = new NotificationRequest
            {
                NotificationId = 101,
                Title = "Marked as Favorite",
                Description = "You swiped to mark this item as favorite.",
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(1) // Schedule notification after 1 second
                }
            };

            LocalNotificationCenter.Current.Show(notification);
			*/
			 Shell.Current.DisplayAlert("Favorite","Favorite","OK");
        }

        private async void OnRightSwipe(object sender, EventArgs e)
        {
			/*
            // Trigger a local notification for "Delete" swipe action
            var notification = new NotificationRequest
            {
                NotificationId = 102,
                Title = "Item Deleted",
                Description = "You swiped to delete this item.",
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(1) // Schedule notification after 1 second
                }
            };

            LocalNotificationCenter.Current.Show(notification);
			*/
			await Shell.Current.DisplayAlert("Deleted","Deleted","OK");
        }

	
}

