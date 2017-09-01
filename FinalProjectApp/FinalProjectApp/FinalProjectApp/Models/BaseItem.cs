using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectApp.Models
{
    public class BaseItem
    {
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
	}
}
