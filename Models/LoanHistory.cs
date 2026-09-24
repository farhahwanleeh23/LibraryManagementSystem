using System;

namespace LibraryManagementSystem.Models
{
    public class LoanHistory
    {
      public Guid LoanId { get; private set; }
      public Guid BookId { get; private set; }
      public Guid MemberId { get; private set; }
      public DateTime IssueDate { get; private set; }
      public DateTime DueDate { get; private set; }
      public DateTime? ReturnDate { get; private set; }
      public string Status { get; private set; } //Active, Returned, Overdue

      public LoanHistory(Guid bookCopyId, Guid memberId)
      {
        int loanDurationDays = 14;
        LoanId = Guid.NewGuid();
        BookId = bookId;
        MemberId = memberId;
        IssueDate = DateTime.UtcNow;
        DueDate = DateTime.UtcNow.AddDays(loanDurationDays);
        ReturnDate = null;
        Status = "Active";
      }

        //ProcessBookReturn()
        //CheckLoanOverdue()
    }
}

