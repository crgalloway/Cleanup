using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cleanup.Models
{
    public class User : BaseEntity
    {
        public int UserId {get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string UserName{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public int UserLevel{get;set;}
        public string ProfilePic{get;set;}
        public int Score{get;set;}
        public int Token{get;set;}
        [ForeignKey("CleanupEvent")]
        public int? CleanupEventId{get;set;}
        public CleanupEvent CleanupEvent{get;set;}
        [InverseProperty("User")]
        public List<CleanupEvent> CreatedCleanups{get;set;}
        [InverseProperty("Sender")]
        public List<Message> Sent{get;set;}
        [InverseProperty("Recipient")]
        public List<Message> Received{get;set;}
        public User()
        {
            CreatedCleanups = new List<CleanupEvent>();
            Sent = new List<Message>();
            Received = new List<Message>();
        }
    }
}