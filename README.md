# XAML Power Toys Demo

This is the solution that I used to record the XAML Power Toys videos.
  
## Purpose

The purpose of this repro is to provide an application for testing the XAML Power Toys Extension.

This is a Xamarin Forms IOS, Android, UWP application that also has a WPF project and a Windows Universal UPW project.

A secondary purpose is to compare the cross-platform rendering of data entry forms.  

I strongly recommend that you leverage this research and run each of the forms in all three Xamarin Forms platforms: IOS, Android, and UWP as well as WPF and Windows Universal.  This will give you an idea of how Xamarin Forms renders and which layout strategy works best for you application requirements.

## Build Configuration
This solution has 5 projects that can be the "**Startup Project**."
- XamlPowerToysDemo.Universal
- XamlPowerToysDemo.WPF
- XamlPowerToysDemo.Droid
- XamlPowerToysDemo.iOS
- XamlPowerToysDemo.UWP

After selecting a Startup Project, please use the Configuration Manager to selected the appropriate projects to build and deploy.

You'll always need to build the XamlPowerToysDemo.Model project.

![Solution Explorer](Art/solution-explorer.png)

## Portable Project

The XamlPowerToysDemo (Portable) Project has most of the code and forms you'll be using.

The below images show the folder structure of the project.

![Portable Project](Art/portable-project.png)

### Books 

The BooksDetailPage.xaml is the file that is used to determine which Books Detail form will be rendered when the application starts.

To change which Books Detail form is used, change the ContentPage.Content to reflect the desired Detail form.

All of the forms will use the BooksDetailPageViewModel.

The green comments lists all of the Detail forms.

The BooksDetailWorkPlace form is an empty form for testing out XAML Power Toys.

![Books Detail](Art/books-detail.png)

### People

The PeopleWorkPlace form is an empty form for testing out XAML Power Toys.

## License
[Apache 2.0](LICENSE)