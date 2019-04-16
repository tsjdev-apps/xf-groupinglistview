using System.Collections.Generic;

namespace GroupingListView.Models
{
    public class PersonGroup : List<Person>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }


        public PersonGroup(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
