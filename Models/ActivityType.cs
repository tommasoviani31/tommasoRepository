using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TMmvc.Models
{
    public class ActivityType
    {
        private string name;

        [Key]
        public int Id { get; set; }

        public ActivityType()
        {
            
        }

        [DisplayName("Activity Type Name")]
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Value is null or only white spaces");
                }
                name = value;
            }
        }
        public bool IsExternal { get; set; }
        // default recovery time
    }

}
