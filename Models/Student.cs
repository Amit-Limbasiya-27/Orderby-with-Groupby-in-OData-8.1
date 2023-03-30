using System;
using System.Runtime.Serialization;
using System.Threading.Channels;

namespace OData6Demo.Api.Models
{
    [DataContract]
    public class Student
    {
        [DataMember(Name = "Id")]   // it was id initially i have changed to data member name as Id i.e. capitalize the first character
        public int Id { get; set; }
        [DataMember(Name = "subject_name")]
        public string SubjectName { get; set; }
        [DataMember(Name = "Name")]  // it was name initially i have changed to data member name as Name i.e.capitalize the first character
        public string Name { get; set; }
        [DataMember(Name = "score")]
        public int Score { get; set; }
    }
}
