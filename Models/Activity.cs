using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace TMmvc.Models
{
    public class Activity : IActivity
    {
        private string title;

        public Activity()
        {
            Title = "N/A";
        }

        public Activity(string title)
        {
            Title = title;
        }

        [Key]
        public int Id { get;set; }

        [Required]
        public int ActivityTypeId { get;set; }

        public ActivityType ActivityType { get;set; }

        public string Title
        {
            get
            {
                return title;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) ) // ! Regex.IsMatch(value, "^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$")
                {
                    throw new ArgumentException("Title is wrong");
                };

                title = value;
            }
        }

        [DataType(DataType.DateTime)]
        public DateTime Start { get;set; } // TODO implementare solo date con preavviso corretto????
        
        [DataType(DataType.DateTime)]
        public DateTime End { get;set; }// TODO implementare set per verifica valore
        
        public ActivityState State { get;set; }
    }

}
