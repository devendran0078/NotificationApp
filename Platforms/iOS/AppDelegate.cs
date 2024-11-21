using Foundation;
using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using UIKit;

namespace NotificationApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    LocalNotificationCenter.Current.NotificationActionTapped += OnLocalNotificationTapped;
    return base.FinishedLaunching(app, options);
}

    private void OnLocalNotificationTapped(NotificationActionEventArgs e)
    {
        Console.WriteLine($"Notification tapped: {e.Request.Title}");

    }
}
