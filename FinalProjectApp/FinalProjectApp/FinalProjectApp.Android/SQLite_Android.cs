using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FinalProjectApp.Droid;
using Xamarin.Forms;
using FinalProjectApp.ServiceInterfaces;
using System.IO;
using SQLite;

[assembly: Dependency(typeof(SQLite_Android))]
namespace FinalProjectApp.Droid
{
	public class SQLite_Android : ISQLiteService
	{
		string GetPath(string databaseName)
		{
			if (string.IsNullOrWhiteSpace(databaseName))
			{
				throw new ArgumentException("Invalid database name", nameof(databaseName));
			}
			var sqliteFilename = $"{databaseName}.db3";
			var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentsPath, sqliteFilename);
			return path;
		}

		public SQLiteConnection GetConnection(string databaseName)
		{
			return new SQLiteConnection(GetPath(databaseName));
		}

		public long GetSize(string databaseName)
		{
			var fileInfo = new FileInfo(GetPath(databaseName));
			return fileInfo != null ? fileInfo.Length : 0;
		}
	}
}