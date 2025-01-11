using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BookMaster
{
    public int BookId { get; set; }

    public string? BookCode { get; set; }

    public string? BookTitle { get; set; }

    public string? BookDescription { get; set; }

    public string? BookCallNumber { get; set; }

    public string? BookAccessionNumber { get; set; }

    public int BookTypeId { get; set; }

    public int BookCategoryId { get; set; }

    public int BookAuthorId { get; set; }

    public int BookPublisherId { get; set; }

    public int? BookSupplierId { get; set; }

    public string? BookEdition { get; set; }

    public int? BookNoOfCopies { get; set; }

    public int? BookStockInHand { get; set; }

    public DateTime? BookPublishingDate { get; set; }

    public string? BookIsbnNumber { get; set; }

    public decimal? BookPrice { get; set; }

    public int? BookTotalPages { get; set; }

    public bool BookIsIssuable { get; set; }

    public int BookCmpId { get; set; }

    public int BookSchId { get; set; }

    public string? BookImage { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public virtual AuthorMaster BookAuthor { get; set; } = null!;

    public virtual BookCategoryMaster BookCategory { get; set; } = null!;

    public virtual PublisherMaster BookPublisher { get; set; } = null!;

    public virtual SupplierMaster? BookSupplier { get; set; }

    public virtual ICollection<BookTransactionDetail> BookTransactionDetails { get; set; } = new List<BookTransactionDetail>();

    public virtual BookTypeMaster BookType { get; set; } = null!;
}
