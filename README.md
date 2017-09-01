# SamRuleFinalProject

This is the app to go along with my final apprenticeship project. I will be using as much as my own code as possible but I will be using some packages as documented below here.
<br />
The app is written using Xamarin.Forms which is a cross platform development tool that uses the .NET framework and C#. I have chosen to use this as it allows me to build one app with a shared codebase that can be deployed across iOS and Android. For the purposes of this project I will not be creating an app for windows phones.  

## Packages

* [Newtonsoft.Json](https://www.newtonsoft.com/json) - Allows me to easily serialize and de-serialize JSON in my application.
* [Fody](https://github.com/Fody/Fody)
* [ProperyChanged.Fody](https://github.com/Fody/PropertyChanged) - Helps me to implement the INotifyPropertyChanged interface through the use of an attribute on my base class. This is used for updating the UI when a value such as a string is changed in the background.
* [Xam.Plugins.Settings](https://github.com/jamesmontemagno/SettingsPlugin)- Allows me to secure constant variables (Such as username) to the secure storage on an Android or iOS device. These can then be updated and retrieved at any stage in the app and persist through sessions. (Are removed if cache is cleared)
