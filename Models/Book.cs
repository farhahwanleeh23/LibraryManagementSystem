using System;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public Guid BookId { get; private set; } 
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public string Category { get; set; }
        public string AvailabilityStatus { get; private set; } //Loan availability - Available, Checked Out, Reserved, Lost

        public Book(string isbn, string title, string author, string publisher, int year, string category)
        {
            BookId = Guid.NewGuid();
            ISBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            PublicationYear = year;
            Category = category;
            AvailabilityStatus = "Available";
        }

        public void UpdateAvailabilityStatus(string status)
        {
            AvailabilityStatus = status;
        }

    }
}

