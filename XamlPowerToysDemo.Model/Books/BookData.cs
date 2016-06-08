namespace XamlPowerToysDemo.Model.Books {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookData {

        public BookData() {
        }

        public IList<Book> GetBooks() {
            var list = new List<Book>();

            var book = new Book();
            book.Format = Format.Pdf;
            book.Cost = 0d;
            book.DatePublished = new DateTime(2016, 4, 1);
            book.Description = "Charles Petzold\'s latest book - Creating Mobile Apps with Xamarin.Forms";
            book.Id = 100;
            book.Image = "CreatingMobileAppsWithXamarinForms.jpg";
            book.PurchasedFrom = "Free Download";
            book.Rating = 10;
            book.Title = "Creating Mobile Apps With Xamarin Forms";
            book.Url = "https://developer.xamarin.com/guides/xamarin-forms/creating-mobile-apps-xamarin-forms/";
            list.Add(book);

            book = new Book();
            book.Format = Format.Paperback;
            book.Cost = 25.60;
            book.DatePublished = new DateTime(2012, 11, 8);
            book.Description = "Building Windows 8, Web, RIA andApplications for the .NET 4.5 Framework";
            book.Id = 101;
            book.Image = "CSharp5.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 8;
            book.Title = "C# 5";
            book.Url = "http://www.amazon.com/Programming-5-0-Building-Applications-Framework/dp/1449320414";
            list.Add(book);

            book = new Book();
            book.Format = Format.Kindle;
            book.Cost = 35.99;
            book.DatePublished = new DateTime(1994, 11, 10);
            book.Description = "Design Patterns is a modern classic in the literature of object-oriented development, offering timeless and elegant solutions to common problems in software design.";
            book.Id = 102;
            book.Image = "DesignPatternsGOF.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 10;
            book.Title = "Design Patterns: Elements of Reusable Object-Oriented Software";
            book.Url = "http://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612";
            list.Add(book);

            book = new Book();
            book.Format = Format.Kindle;
            book.Cost = 41.07;
            book.DatePublished = new DateTime(2008, 11, 1);
            book.Description = "Framework Design Guidelines, Second Edition, teaches developers the best practices for designing reusable libraries for the Microsoft .NET Framework. Expanded and updated for .NET 3.5, this new edition focuses on the design issues that directly affect the programmability of a class library, specifically its publicly accessible APIs.";
            book.Id = 103;
            book.Image = "FrameworkDesignGuidelines.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 10;
            book.Title = "Framework Design Guidelines: Conventions, Idioms, and Patterns for Reusable .NET Libraries (2nd Edition)";
            book.Url = "http://www.amazon.com/Framework-Design-Guidelines-Conventions-Libraries/dp/0321545613";
            list.Add(book);

            book = new Book();
            book.Format = Format.Paperback;
            book.Cost = 19.47;
            book.DatePublished = new DateTime(2009, 12, 9);
            book.Description = "Windows Presentation Foundation is Microsoft\'s API for creating Windows applications. It gives the programmer the ability to produce dazzling, graphics–rich programs easily without having to delve into the messy details of the graphics subsystem.";
            book.Id = 104;
            book.Image = "IllustratedWPF.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 8;
            book.Title = "Illustrated WPF";
            book.Url = "http://www.amazon.com/Illustrated-WPF-Experts-Voice-NET/dp/1430219106";
            list.Add(book);

            book = new Book();
            book.Format = Format.Paperback;
            book.Cost = 99.99;
            book.DatePublished = new DateTime(2014, 11, 5);
            book.Description = "Hardcore .NET solutions for advanced, distributed financial applications. Fascinating insight into operation of Equity markets and the challenges this poses for technology solutions – you do not have to be an equity market insider to use this book.";
            book.Id = 105;
            book.Image = "PracticalNETForFinancialMarkets.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 8;
            book.Title = "Practical .NET for Financial Markets";
            book.Url = "http://www.amazon.com/Practical-Financial-Markets-Experts-Voice/dp/1430211768";
            list.Add(book);

            book = new Book();
            book.Format = Format.Kindle;
            book.Cost = 11.82;
            book.DatePublished = new DateTime(2013, 9, 24);
            book.Description = "Pro ASP.NET Web API shows you how to build flexible, extensible web services that run seamlessly on a range of operating systems and devices, from desktops to tablets to smart phones―even the ones we don’t know today.";
            book.Id = 106;
            book.Image = "ProASPNETWebAPI.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 8;
            book.Title = "Pro ASP.NET Web API: HTTP Web Services in ASP.NET";
            book.Url = "http://www.amazon.com/Pro-ASP-NET-Web-API-Services/dp/1430247258";
            list.Add(book);

            book = new Book();
            book.Format = Format.Paperback;
            book.Cost = 25.60;
            book.DatePublished = new DateTime(2014, 8, 4);
            book.Description = "MVC 5 is the newest update to the popular Microsoft technology that enables you to build dynamic, data-driven websites.";
            book.Id = 107;
            book.Image = "ProfessionalASPNETMVC5.jpg";
            book.PurchasedFrom = "Amazon.com";
            book.Rating = 10;
            book.Title = "Professional ASP.Net MVC 5";
            book.Url = "http://www.amazon.com/Professional-ASP-Net-PROFESSIONAL-ASPNET-Paperback/dp/B00QOJ0EV6";
            list.Add(book);

            book = new Book();
            book.Format = Format.Kindle;
            book.Cost = 18.99;
            book.DatePublished = new DateTime(2015, 6, 29);
            book.Description = "Xamarin Mobile Application Development is a hands-on Xamarin.Forms primer and a cross-platform reference for building native Android, iOS, and Windows Phone apps using C# and .NET. This book explains how to use Xamarin.Forms, Xamarin.Android, and Xamarin.iOS to build business apps for your customers and consumer apps for Google Play and the iTunes App Store.";
            book.Id = 108;
            book.Image = "XamarinMobileApplicationDevelopment.jpg";
            book.PurchasedFrom = "Free Download";
            book.Rating = 7;
            book.Title = "Xamarin Mobile Application Development";
            book.Url = "http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155";
            list.Add(book);

            return list.OrderBy(x => x.Title).ToList();
        }

    }
}
