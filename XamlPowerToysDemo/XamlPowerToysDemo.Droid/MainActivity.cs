namespace XamlPowerToysDemo.Droid {
    using Android.App;
    using Android.Content.PM;
    using Android.OS;

    [Activity(Theme = "@android:style/Theme.Holo.Light", Label = "Xaml Power Toys", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

    }
}
