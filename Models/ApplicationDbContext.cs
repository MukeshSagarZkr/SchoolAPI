using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SchoolAPI.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssesmentMaster> AssesmentMasters { get; set; }

    public virtual DbSet<AttendanceReasonMaster> AttendanceReasonMasters { get; set; }

    public virtual DbSet<AuthorMaster> AuthorMasters { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<BillMaster> BillMasters { get; set; }

    public virtual DbSet<BloodGroupMaster> BloodGroupMasters { get; set; }

    public virtual DbSet<BookCategoryMaster> BookCategoryMasters { get; set; }

    public virtual DbSet<BookMaster> BookMasters { get; set; }

    public virtual DbSet<BookTransactionDetail> BookTransactionDetails { get; set; }

    public virtual DbSet<BookTypeMaster> BookTypeMasters { get; set; }

    public virtual DbSet<CategoryMaster> CategoryMasters { get; set; }

    public virtual DbSet<CityMaster> CityMasters { get; set; }

    public virtual DbSet<ClassMaster> ClassMasters { get; set; }

    public virtual DbSet<ClassScholasticDetail> ClassScholasticDetails { get; set; }

    public virtual DbSet<ClassScholasticDetailHistory> ClassScholasticDetailHistories { get; set; }

    public virtual DbSet<ClassSectionDetail> ClassSectionDetails { get; set; }

    public virtual DbSet<ClassSmstasksDetail> ClassSmstasksDetails { get; set; }

    public virtual DbSet<ClassSubjectDetail> ClassSubjectDetails { get; set; }

    public virtual DbSet<CleanerMaster> CleanerMasters { get; set; }

    public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }

    public virtual DbSet<DeptDesigDetail> DeptDesigDetails { get; set; }

    public virtual DbSet<DeptMaster> DeptMasters { get; set; }

    public virtual DbSet<DesigGradeDetail> DesigGradeDetails { get; set; }

    public virtual DbSet<DesigMaster> DesigMasters { get; set; }

    public virtual DbSet<DriverMaster> DriverMasters { get; set; }

    public virtual DbSet<EmpAttendanceDetail> EmpAttendanceDetails { get; set; }

    public virtual DbSet<EmpAttendanceDetailsHistory> EmpAttendanceDetailsHistories { get; set; }

    public virtual DbSet<EmpCatLeaveDetail> EmpCatLeaveDetails { get; set; }

    public virtual DbSet<EmpCatLeaveDetailsHistory> EmpCatLeaveDetailsHistories { get; set; }

    public virtual DbSet<EmpCategoryMaster> EmpCategoryMasters { get; set; }

    public virtual DbSet<EmpDocumentDetail> EmpDocumentDetails { get; set; }

    public virtual DbSet<EmpLeaveAvailDetail> EmpLeaveAvailDetails { get; set; }

    public virtual DbSet<EmpLeaveDetail> EmpLeaveDetails { get; set; }

    public virtual DbSet<EmpLeaveDetailsHistory> EmpLeaveDetailsHistories { get; set; }

    public virtual DbSet<EmpMaster> EmpMasters { get; set; }

    public virtual DbSet<EmpProfQualiDetail> EmpProfQualiDetails { get; set; }

    public virtual DbSet<EmpSalaryDetail> EmpSalaryDetails { get; set; }

    public virtual DbSet<EmpSalaryDetailsHistory> EmpSalaryDetailsHistories { get; set; }

    public virtual DbSet<EmpSalaryMaster> EmpSalaryMasters { get; set; }

    public virtual DbSet<EmpSalaryMasterHistory> EmpSalaryMasterHistories { get; set; }

    public virtual DbSet<EmpSalaryStructureDetail> EmpSalaryStructureDetails { get; set; }

    public virtual DbSet<EmpSalaryStructureDetailsHistory> EmpSalaryStructureDetailsHistories { get; set; }

    public virtual DbSet<EmpTypeMaster> EmpTypeMasters { get; set; }

    public virtual DbSet<ExamCategoryMaster> ExamCategoryMasters { get; set; }

    public virtual DbSet<ExamUnitMaster> ExamUnitMasters { get; set; }

    public virtual DbSet<ExpenseCategoryMaster> ExpenseCategoryMasters { get; set; }

    public virtual DbSet<FeeClassDetail> FeeClassDetails { get; set; }

    public virtual DbSet<FeeClassDetailsHistory> FeeClassDetailsHistories { get; set; }

    public virtual DbSet<FeesCategoryMaster> FeesCategoryMasters { get; set; }

    public virtual DbSet<FeesDiscountCategoryMaster> FeesDiscountCategoryMasters { get; set; }

    public virtual DbSet<GradeMaster> GradeMasters { get; set; }

    public virtual DbSet<HolidayClassDetail> HolidayClassDetails { get; set; }

    public virtual DbSet<HolidayDeptDetail> HolidayDeptDetails { get; set; }

    public virtual DbSet<HolidayMaster> HolidayMasters { get; set; }

    public virtual DbSet<HolidayTypeMaster> HolidayTypeMasters { get; set; }

    public virtual DbSet<InventoryMaster> InventoryMasters { get; set; }

    public virtual DbSet<ItemLocationMaster> ItemLocationMasters { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<ItemTypeMaster> ItemTypeMasters { get; set; }

    public virtual DbSet<LeaveStatusMaster> LeaveStatusMasters { get; set; }

    public virtual DbSet<LeaveTypeMaster> LeaveTypeMasters { get; set; }

    public virtual DbSet<LocationMaster> LocationMasters { get; set; }

    public virtual DbSet<MarksGradeMaster> MarksGradeMasters { get; set; }

    public virtual DbSet<NotificationReceiverMaster> NotificationReceiverMasters { get; set; }

    public virtual DbSet<ParentMaster> ParentMasters { get; set; }

    public virtual DbSet<PaymentModeMaster> PaymentModeMasters { get; set; }

    public virtual DbSet<Privilege> Privileges { get; set; }

    public virtual DbSet<ProfessionMaster> ProfessionMasters { get; set; }

    public virtual DbSet<PublisherMaster> PublisherMasters { get; set; }

    public virtual DbSet<QualificationMaster> QualificationMasters { get; set; }

    public virtual DbSet<RegistrationMaster> RegistrationMasters { get; set; }

    public virtual DbSet<ReligionMaster> ReligionMasters { get; set; }

    public virtual DbSet<RoleMaster> RoleMasters { get; set; }

    public virtual DbSet<RolePrivilege> RolePrivileges { get; set; }

    public virtual DbSet<RouteDetail> RouteDetails { get; set; }

    public virtual DbSet<RouteMaster> RouteMasters { get; set; }

    public virtual DbSet<RouteStopDetail> RouteStopDetails { get; set; }

    public virtual DbSet<SalaryDesigGradeDetail> SalaryDesigGradeDetails { get; set; }

    public virtual DbSet<SalaryDesigGradeDetailsHistory> SalaryDesigGradeDetailsHistories { get; set; }

    public virtual DbSet<SalaryHeadMaster> SalaryHeadMasters { get; set; }

    public virtual DbSet<ScholasticMaster> ScholasticMasters { get; set; }

    public virtual DbSet<ScholasticUnitDetail> ScholasticUnitDetails { get; set; }

    public virtual DbSet<SchoolContactMaster> SchoolContactMasters { get; set; }

    public virtual DbSet<SchoolMaster> SchoolMasters { get; set; }

    public virtual DbSet<SectionMaster> SectionMasters { get; set; }

    public virtual DbSet<SessionMaster> SessionMasters { get; set; }

    public virtual DbSet<Smstask> Smstasks { get; set; }

    public virtual DbSet<SmstaskHistory> SmstaskHistories { get; set; }

    public virtual DbSet<SmstaskSchedule> SmstaskSchedules { get; set; }

    public virtual DbSet<SmstaskSmtpDetail> SmstaskSmtpDetails { get; set; }

    public virtual DbSet<SmstaskStatusMaster> SmstaskStatusMasters { get; set; }

    public virtual DbSet<SmtpDetail> SmtpDetails { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<StudentAchievement> StudentAchievements { get; set; }

    public virtual DbSet<StudentAttendanceDetail> StudentAttendanceDetails { get; set; }

    public virtual DbSet<StudentAttendanceDetailsHistory> StudentAttendanceDetailsHistories { get; set; }

    public virtual DbSet<StudentCommentDetail> StudentCommentDetails { get; set; }

    public virtual DbSet<StudentCommentDetailsHistory> StudentCommentDetailsHistories { get; set; }

    public virtual DbSet<StudentFeeDetail> StudentFeeDetails { get; set; }

    public virtual DbSet<StudentFeeDetailsHistory> StudentFeeDetailsHistories { get; set; }

    public virtual DbSet<StudentGradeDetail> StudentGradeDetails { get; set; }

    public virtual DbSet<StudentGradeDetailsHistory> StudentGradeDetailsHistories { get; set; }

    public virtual DbSet<StudentMarksDetail> StudentMarksDetails { get; set; }

    public virtual DbSet<StudentMarksDetailsHistory> StudentMarksDetailsHistories { get; set; }

    public virtual DbSet<StudentMaster> StudentMasters { get; set; }

    public virtual DbSet<StudentMasterHistory> StudentMasterHistories { get; set; }

    public virtual DbSet<StudentReportCardDetail> StudentReportCardDetails { get; set; }

    public virtual DbSet<StudentReportCardDetailsHistory> StudentReportCardDetailsHistories { get; set; }

    public virtual DbSet<StudentReportCardMaster> StudentReportCardMasters { get; set; }

    public virtual DbSet<StudentReportCardMasterHistory> StudentReportCardMasterHistories { get; set; }

    public virtual DbSet<SubjectCategoryDetail> SubjectCategoryDetails { get; set; }

    public virtual DbSet<SubjectMaster> SubjectMasters { get; set; }

    public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }

    public virtual DbSet<SystemParameter> SystemParameters { get; set; }

    public virtual DbSet<TeacherClassDetail> TeacherClassDetails { get; set; }

    public virtual DbSet<TeacherDocumentDetail> TeacherDocumentDetails { get; set; }

    public virtual DbSet<TeacherMaster> TeacherMasters { get; set; }

    public virtual DbSet<TeacherQualificationDetail> TeacherQualificationDetails { get; set; }

    public virtual DbSet<TeacherSectionDetail> TeacherSectionDetails { get; set; }

    public virtual DbSet<TeacherSubjectDetail> TeacherSubjectDetails { get; set; }

    public virtual DbSet<TimeTableClassPeriodDetail> TimeTableClassPeriodDetails { get; set; }

    public virtual DbSet<TimeTableClassPeriodDetailsHistory> TimeTableClassPeriodDetailsHistories { get; set; }

    public virtual DbSet<TimeTableDetailsHistory> TimeTableDetailsHistories { get; set; }

    public virtual DbSet<TimeTablePeriodMaster> TimeTablePeriodMasters { get; set; }

    public virtual DbSet<TimeTablePeriodMasterHistory> TimeTablePeriodMasterHistories { get; set; }

    public virtual DbSet<TimeTableSession> TimeTableSessions { get; set; }

    public virtual DbSet<TimeTableSetupDetail> TimeTableSetupDetails { get; set; }

    public virtual DbSet<TimeTableSetupDetailsHistory> TimeTableSetupDetailsHistories { get; set; }

    public virtual DbSet<TimeTableSubstitutionDetail> TimeTableSubstitutionDetails { get; set; }

    public virtual DbSet<TimeTableSubstitutionDetailsHistory> TimeTableSubstitutionDetailsHistories { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    public virtual DbSet<VehicleExpenseDetail> VehicleExpenseDetails { get; set; }

    public virtual DbSet<VehicleMaster> VehicleMasters { get; set; }

    public virtual DbSet<VendorMaster> VendorMasters { get; set; }

    public virtual DbSet<VisitorMaster> VisitorMasters { get; set; }

    public virtual DbSet<VoucherMaster> VoucherMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=SAGAR;initial catalog=SchoolManagement;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssesmentMaster>(entity =>
        {
            entity.HasKey(e => e.AssesmentId);

            entity.ToTable("AssesmentMaster");

            entity.Property(e => e.AssesmentId).HasColumnName("ASSESMENT_ID");
            entity.Property(e => e.AssesmentCmpId).HasColumnName("ASSESMENT_CMP_ID");
            entity.Property(e => e.AssesmentDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ASSESMENT_DESC");
            entity.Property(e => e.AssesmentFromPeriod)
                .HasColumnType("datetime")
                .HasColumnName("ASSESMENT_FROM_PERIOD");
            entity.Property(e => e.AssesmentName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ASSESMENT_NAME");
            entity.Property(e => e.AssesmentPercentageWeightage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ASSESMENT_PERCENTAGE_WEIGHTAGE");
            entity.Property(e => e.AssesmentSchId).HasColumnName("ASSESMENT_SCH_ID");
            entity.Property(e => e.AssesmentToPeriod)
                .HasColumnType("datetime")
                .HasColumnName("ASSESMENT_TO_PERIOD");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<AttendanceReasonMaster>(entity =>
        {
            entity.HasKey(e => e.AttendReasonId);

            entity.ToTable("AttendanceReasonMaster");

            entity.Property(e => e.AttendReasonId).HasColumnName("ATTEND_REASON_ID");
            entity.Property(e => e.AttendReasonCmpId).HasColumnName("ATTEND_REASON_CMP_ID");
            entity.Property(e => e.AttendReasonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ATTEND_REASON_CODE");
            entity.Property(e => e.AttendReasonDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ATTEND_REASON_DESCRIPTION");
            entity.Property(e => e.AttendReasonName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ATTEND_REASON_NAME");
            entity.Property(e => e.AttendReasonSchId).HasColumnName("ATTEND_REASON_SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<AuthorMaster>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK_AUTHORMaster");

            entity.ToTable("AuthorMaster");

            entity.Property(e => e.AuthorId).HasColumnName("AUTHOR_ID");
            entity.Property(e => e.AuthorAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_ADDRESS");
            entity.Property(e => e.AuthorCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_CITY");
            entity.Property(e => e.AuthorCityId).HasColumnName("AUTHOR_CITY_ID");
            entity.Property(e => e.AuthorCmpId).HasColumnName("AUTHOR_CMP_ID");
            entity.Property(e => e.AuthorCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_COUNTRY");
            entity.Property(e => e.AuthorDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_DESCRIPTION");
            entity.Property(e => e.AuthorEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_EMAIL");
            entity.Property(e => e.AuthorMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_MOBILE");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_NAME");
            entity.Property(e => e.AuthorPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_PHONE");
            entity.Property(e => e.AuthorSchId).HasColumnName("AUTHOR_SCH_ID");
            entity.Property(e => e.AuthorState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_STATE");
            entity.Property(e => e.AuthorStateId).HasColumnName("AUTHOR_STATE_ID");
            entity.Property(e => e.AuthorZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHOR_ZIPCODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<BillDetail>(entity =>
        {
            entity.Property(e => e.BillDetailId).HasColumnName("BILL_DETAIL_ID");
            entity.Property(e => e.BillCmpId).HasColumnName("BILL_CMP_ID");
            entity.Property(e => e.BillDetailAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BILL_DETAIL_AMOUNT");
            entity.Property(e => e.BillDetailBillId).HasColumnName("BILL_DETAIL_BILL_ID");
            entity.Property(e => e.BillDetailDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BILL_DETAIL_DESC");
            entity.Property(e => e.BillDetailExpCatId).HasColumnName("BILL_DETAIL_EXP_CAT_ID");
            entity.Property(e => e.BillDetailQty).HasColumnName("BILL_DETAIL_QTY");
            entity.Property(e => e.BillSchId).HasColumnName("BILL_SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.BillDetailExpCat).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.BillDetailExpCatId)
                .HasConstraintName("FK_BillDetails_ExpenseCategory");
        });

        modelBuilder.Entity<BillMaster>(entity =>
        {
            entity.HasKey(e => e.BillId);

            entity.ToTable("BillMaster");

            entity.Property(e => e.BillId).HasColumnName("BILL_ID");
            entity.Property(e => e.BillAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BILL_AMOUNT");
            entity.Property(e => e.BillCmpId).HasColumnName("BILL_CMP_ID");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DATE");
            entity.Property(e => e.BillDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("BILL_DESC");
            entity.Property(e => e.BillDueDate)
                .HasColumnType("datetime")
                .HasColumnName("BILL_DUE_DATE");
            entity.Property(e => e.BillNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_NUMBER");
            entity.Property(e => e.BillSchId).HasColumnName("BILL_SCH_ID");
            entity.Property(e => e.BillStatus).HasColumnName("BILL_STATUS");
            entity.Property(e => e.BillTaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BILL_TAX_AMOUNT");
            entity.Property(e => e.BillTotalAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BILL_TOTAL_AMOUNT");
            entity.Property(e => e.BillVehicleId).HasColumnName("BILL_VEHICLE_ID");
            entity.Property(e => e.BillVendorId).HasColumnName("BILL_VENDOR_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.BillVehicle).WithMany(p => p.BillMasters)
                .HasForeignKey(d => d.BillVehicleId)
                .HasConstraintName("FK_BillMaster_VehicleMaster");

            entity.HasOne(d => d.BillVendor).WithMany(p => p.BillMasters)
                .HasForeignKey(d => d.BillVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillMaster_VendorMaster");
        });

        modelBuilder.Entity<BloodGroupMaster>(entity =>
        {
            entity.HasKey(e => e.BloodGroupId);

            entity.ToTable("BloodGroupMaster");

            entity.Property(e => e.BloodGroupId).HasColumnName("BLOOD_GROUP_ID");
            entity.Property(e => e.BloodGroupName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BLOOD_GROUP_NAME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<BookCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.BookCatId).HasName("PK_BookCATMaster");

            entity.ToTable("BookCategoryMaster");

            entity.Property(e => e.BookCatId).HasColumnName("BOOK_CAT_ID");
            entity.Property(e => e.BookCatCmpId).HasColumnName("BOOK_CAT_CMP_ID");
            entity.Property(e => e.BookCatDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("BOOK_CAT_DESCRIPTION");
            entity.Property(e => e.BookCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_CAT_NAME");
            entity.Property(e => e.BookCatSchId).HasColumnName("BOOK_CAT_SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<BookMaster>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("BookMaster");

            entity.Property(e => e.BookId).HasColumnName("BOOK_ID");
            entity.Property(e => e.BookAccessionNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_ACCESSION_NUMBER");
            entity.Property(e => e.BookAuthorId).HasColumnName("BOOK_AUTHOR_ID");
            entity.Property(e => e.BookCallNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_CALL_NUMBER");
            entity.Property(e => e.BookCategoryId).HasColumnName("BOOK_CATEGORY_ID");
            entity.Property(e => e.BookCmpId).HasColumnName("BOOK_CMP_ID");
            entity.Property(e => e.BookCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_CODE");
            entity.Property(e => e.BookDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BOOK_DESCRIPTION");
            entity.Property(e => e.BookEdition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_EDITION");
            entity.Property(e => e.BookImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BOOK_IMAGE");
            entity.Property(e => e.BookIsIssuable).HasColumnName("BOOK_IS_ISSUABLE");
            entity.Property(e => e.BookIsbnNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_ISBN_NUMBER");
            entity.Property(e => e.BookNoOfCopies).HasColumnName("BOOK_NO_OF_COPIES");
            entity.Property(e => e.BookPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BOOK_PRICE");
            entity.Property(e => e.BookPublisherId).HasColumnName("BOOK_PUBLISHER_ID");
            entity.Property(e => e.BookPublishingDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOK_PUBLISHING_DATE");
            entity.Property(e => e.BookSchId).HasColumnName("BOOK_SCH_ID");
            entity.Property(e => e.BookStockInHand).HasColumnName("BOOK_STOCK_IN_HAND");
            entity.Property(e => e.BookSupplierId).HasColumnName("BOOK_SUPPLIER_ID");
            entity.Property(e => e.BookTitle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("BOOK_TITLE");
            entity.Property(e => e.BookTotalPages).HasColumnName("BOOK_TOTAL_PAGES");
            entity.Property(e => e.BookTypeId).HasColumnName("BOOK_TYPE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.BookAuthor).WithMany(p => p.BookMasters)
                .HasForeignKey(d => d.BookAuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookMaster_AuthorMaster");

            entity.HasOne(d => d.BookCategory).WithMany(p => p.BookMasters)
                .HasForeignKey(d => d.BookCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookMaster_BookCategoryMaster");

            entity.HasOne(d => d.BookPublisher).WithMany(p => p.BookMasters)
                .HasForeignKey(d => d.BookPublisherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookMaster_PublisherMaster");

            entity.HasOne(d => d.BookSupplier).WithMany(p => p.BookMasters)
                .HasForeignKey(d => d.BookSupplierId)
                .HasConstraintName("FK_BookMaster_SupplierMaster");

            entity.HasOne(d => d.BookType).WithMany(p => p.BookMasters)
                .HasForeignKey(d => d.BookTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookMaster_BookTypeMaster");
        });

        modelBuilder.Entity<BookTransactionDetail>(entity =>
        {
            entity.HasKey(e => e.BookTransId);

            entity.Property(e => e.BookTransId).HasColumnName("BOOK_TRANS_ID");
            entity.Property(e => e.BookTransActualReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOK_TRANS_ACTUAL_RETURN_DATE");
            entity.Property(e => e.BookTransBookId).HasColumnName("BOOK_TRANS_BOOK_ID");
            entity.Property(e => e.BookTransCmId).HasColumnName("BOOK_TRANS_CM_ID");
            entity.Property(e => e.BookTransCmpId).HasColumnName("BOOK_TRANS_CMP_ID");
            entity.Property(e => e.BookTransFineAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BOOK_TRANS_FINE_AMOUNT");
            entity.Property(e => e.BookTransFinePaid).HasColumnName("BOOK_TRANS_FINE_PAID");
            entity.Property(e => e.BookTransFinePerDay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BOOK_TRANS_FINE_PER_DAY");
            entity.Property(e => e.BookTransIsFineApplicable).HasColumnName("BOOK_TRANS_IS_FINE_APPLICABLE");
            entity.Property(e => e.BookTransIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOK_TRANS_ISSUE_DATE");
            entity.Property(e => e.BookTransIssueDays).HasColumnName("BOOK_TRANS_ISSUE_DAYS");
            entity.Property(e => e.BookTransIssuedTo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOOK_TRANS_ISSUED_TO");
            entity.Property(e => e.BookTransLateDays).HasColumnName("BOOK_TRANS_LATE_DAYS");
            entity.Property(e => e.BookTransReturnDueDate)
                .HasColumnType("datetime")
                .HasColumnName("BOOK_TRANS_RETURN_DUE_DATE");
            entity.Property(e => e.BookTransSchId).HasColumnName("BOOK_TRANS_SCH_ID");
            entity.Property(e => e.BookTransSecId).HasColumnName("BOOK_TRANS_SEC_ID");
            entity.Property(e => e.BookTransStuGuid).HasColumnName("BOOK_TRANS_STU_GUID");
            entity.Property(e => e.BookTransTypeId).HasColumnName("BOOK_TRANS_TYPE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.BookTransBook).WithMany(p => p.BookTransactionDetails)
                .HasForeignKey(d => d.BookTransBookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookTransactionDetails_BookMaster");

            entity.HasOne(d => d.BookTransCm).WithMany(p => p.BookTransactionDetails)
                .HasForeignKey(d => d.BookTransCmId)
                .HasConstraintName("FK_BookTransactionDetails_ClassMaster");

            entity.HasOne(d => d.BookTransSec).WithMany(p => p.BookTransactionDetails)
                .HasForeignKey(d => d.BookTransSecId)
                .HasConstraintName("FK_BookTransactionDetails_ClassSectionDetails");

            entity.HasOne(d => d.BookTransStu).WithMany(p => p.BookTransactionDetails)
                .HasForeignKey(d => d.BookTransStuGuid)
                .HasConstraintName("FK_BookTransactionDetails_StudentMaster");
        });

        modelBuilder.Entity<BookTypeMaster>(entity =>
        {
            entity.HasKey(e => e.BookTypeId);

            entity.ToTable("BookTypeMaster");

            entity.Property(e => e.BookTypeId).HasColumnName("BOOK_TYPE_ID");
            entity.Property(e => e.BookTypeCmpId).HasColumnName("BOOK_TYPE_CMP_ID");
            entity.Property(e => e.BookTypeDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("BOOK_TYPE_DESCRIPTION");
            entity.Property(e => e.BookTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOOK_TYPE_NAME");
            entity.Property(e => e.BookTypeSchId).HasColumnName("BOOK_TYPE_SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<CategoryMaster>(entity =>
        {
            entity.HasKey(e => e.CatId);

            entity.ToTable("CategoryMaster");

            entity.Property(e => e.CatId).HasColumnName("CAT_ID");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAT_NAME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<CityMaster>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.ToTable("CityMaster");

            entity.Property(e => e.CityId).HasColumnName("CITY_ID");
            entity.Property(e => e.CityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY_NAME");
            entity.Property(e => e.CityStateId).HasColumnName("CITY_STATE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ClassMaster>(entity =>
        {
            entity.HasKey(e => e.CmId);

            entity.ToTable("ClassMaster");

            entity.Property(e => e.CmId).HasColumnName("CM_ID");
            entity.Property(e => e.CmCmpId).HasColumnName("CM_CMP_ID");
            entity.Property(e => e.CmExamAssesment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CM_EXAM_ASSESMENT");
            entity.Property(e => e.CmIsGradePointApplicable).HasColumnName("CM_IS_GRADE_POINT_APPLICABLE");
            entity.Property(e => e.CmName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CM_NAME");
            entity.Property(e => e.CmOrderBy).HasColumnName("CM_ORDER_BY");
            entity.Property(e => e.CmSchId).HasColumnName("CM_SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ClassScholasticDetail>(entity =>
        {
            entity.HasKey(e => new { e.ClscohCmId, e.ClscohScholasticId });

            entity.ToTable("ClassScholasticDetail");

            entity.Property(e => e.ClscohCmId).HasColumnName("CLSCOH_CM_ID");
            entity.Property(e => e.ClscohScholasticId).HasColumnName("CLSCOH_SCHOLASTIC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.ClscohCm).WithMany(p => p.ClassScholasticDetails)
                .HasForeignKey(d => d.ClscohCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassScholasticDetail_ClassMaster");

            entity.HasOne(d => d.ClscohScholastic).WithMany(p => p.ClassScholasticDetails)
                .HasForeignKey(d => d.ClscohScholasticId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassScholasticDetail_ScholasticMaster");
        });

        modelBuilder.Entity<ClassScholasticDetailHistory>(entity =>
        {
            entity.HasKey(e => e.ClscohHistId);

            entity.ToTable("ClassScholasticDetailHistory");

            entity.Property(e => e.ClscohHistId).HasColumnName("CLSCOH_HIST_ID");
            entity.Property(e => e.ClscohHistCmId).HasColumnName("CLSCOH_HIST_CM_ID");
            entity.Property(e => e.ClscohHistCmpId).HasColumnName("CLSCOH_HIST_CMP_ID");
            entity.Property(e => e.ClscohHistSchId).HasColumnName("CLSCOH_HIST_SCH_ID");
            entity.Property(e => e.ClscohHistScholasticId).HasColumnName("CLSCOH_HIST_SCHOLASTIC_ID");
            entity.Property(e => e.ClscohHistSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLSCOH_HIST_SESSION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ClassSectionDetail>(entity =>
        {
            entity.HasKey(e => e.ClSecId);

            entity.ToTable("ClassSectionDetail");

            entity.Property(e => e.ClSecId).HasColumnName("CL_SEC_ID");
            entity.Property(e => e.ClCmpId).HasColumnName("CL_CMP_ID");
            entity.Property(e => e.ClSchId).HasColumnName("CL_SCH_ID");
            entity.Property(e => e.ClSecCmId).HasColumnName("CL_SEC_CM_ID");
            entity.Property(e => e.ClSecLocationId).HasColumnName("CL_SEC_LOCATION_ID");
            entity.Property(e => e.ClSecSmId).HasColumnName("CL_SEC_SM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ClassSmstasksDetail>(entity =>
        {
            entity.HasKey(e => e.ClstsId);

            entity.ToTable("ClassSMSTasksDetails");

            entity.Property(e => e.ClstsId).HasColumnName("CLSTS_ID");
            entity.Property(e => e.ClstsCmId).HasColumnName("CLSTS_CM_ID");
            entity.Property(e => e.ClstsCmpId).HasColumnName("CLSTS_CMP_ID");
            entity.Property(e => e.ClstsSchId).HasColumnName("CLSTS_SCH_ID");
            entity.Property(e => e.ClstsSecId).HasColumnName("CLSTS_SEC_ID");
            entity.Property(e => e.ClstsTaskId).HasColumnName("CLSTS_TASK_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.ClstsCm).WithMany(p => p.ClassSmstasksDetails)
                .HasForeignKey(d => d.ClstsCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSMSTasksDetails_ClassMaster");

            entity.HasOne(d => d.ClstsSec).WithMany(p => p.ClassSmstasksDetails)
                .HasForeignKey(d => d.ClstsSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSMSTasksDetails_ClassSectionDetails");

            entity.HasOne(d => d.ClstsTask).WithMany(p => p.ClassSmstasksDetails)
                .HasForeignKey(d => d.ClstsTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSMSTasksDetails_SMSTask");
        });

        modelBuilder.Entity<ClassSubjectDetail>(entity =>
        {
            entity.HasKey(e => new { e.ClsubdCmId, e.ClsubdSubId });

            entity.ToTable("ClassSubjectDetail");

            entity.Property(e => e.ClsubdCmId).HasColumnName("CLSUBD_CM_ID");
            entity.Property(e => e.ClsubdSubId).HasColumnName("CLSUBD_SUB_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<CleanerMaster>(entity =>
        {
            entity.HasKey(e => e.CleanerId).HasName("PK_ClearerMaster");

            entity.ToTable("CleanerMaster");

            entity.Property(e => e.CleanerId).HasColumnName("CLEANER_ID");
            entity.Property(e => e.CleanerCmpId).HasColumnName("CLEANER_CMP_ID");
            entity.Property(e => e.CleanerDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CLEANER_DESC");
            entity.Property(e => e.CleanerFatherName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLEANER_FATHER_NAME");
            entity.Property(e => e.CleanerIdImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLEANER_ID_IMAGE");
            entity.Property(e => e.CleanerImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLEANER_IMAGE");
            entity.Property(e => e.CleanerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLEANER_NAME");
            entity.Property(e => e.CleanerSchId).HasColumnName("CLEANER_SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<CompanyMaster>(entity =>
        {
            entity.HasKey(e => e.CmpId);

            entity.ToTable("CompanyMaster");

            entity.Property(e => e.CmpId).HasColumnName("CMP_ID");
            entity.Property(e => e.CmpAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CMP_ADDRESS");
            entity.Property(e => e.CmpCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMP_CITY");
            entity.Property(e => e.CmpCityId).HasColumnName("CMP_CITY_ID");
            entity.Property(e => e.CmpCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMP_COUNTRY");
            entity.Property(e => e.CmpDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CMP_DESCRIPTION");
            entity.Property(e => e.CmpEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMP_EMAIL");
            entity.Property(e => e.CmpEstablishmentYear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMP_ESTABLISHMENT_YEAR");
            entity.Property(e => e.CmpJurisdictionArea)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CMP_JURISDICTION_AREA");
            entity.Property(e => e.CmpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMP_NAME");
            entity.Property(e => e.CmpState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CMP_STATE");
            entity.Property(e => e.CmpStateId).HasColumnName("CMP_STATE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<DeptDesigDetail>(entity =>
        {
            entity.HasKey(e => e.DepdesId);

            entity.Property(e => e.DepdesId).HasColumnName("DEPDES_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.DepdesCmpId).HasColumnName("DEPDES_CMP_ID");
            entity.Property(e => e.DepdesDeptId).HasColumnName("DEPDES_DEPT_ID");
            entity.Property(e => e.DepdesDesigId).HasColumnName("DEPDES_DESIG_ID");
            entity.Property(e => e.DepdesSchId).HasColumnName("DEPDES_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.DepdesDept).WithMany(p => p.DeptDesigDetails)
                .HasForeignKey(d => d.DepdesDeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeptDesigDetails_DeptMaster");

            entity.HasOne(d => d.DepdesDesig).WithMany(p => p.DeptDesigDetails)
                .HasForeignKey(d => d.DepdesDesigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeptDesigDetails_DesigMaster");
        });

        modelBuilder.Entity<DeptMaster>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("DeptMaster");

            entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.DeptCmpId).HasColumnName("DEPT_CMP_ID");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPT_CODE");
            entity.Property(e => e.DeptName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DEPT_NAME");
            entity.Property(e => e.DeptSchId).HasColumnName("DEPT_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<DesigGradeDetail>(entity =>
        {
            entity.HasKey(e => e.DesgradeId);

            entity.Property(e => e.DesgradeId).HasColumnName("DESGRADE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.DesgradeCmpId).HasColumnName("DESGRADE_CMP_ID");
            entity.Property(e => e.DesgradeDesigId).HasColumnName("DESGRADE_DESIG_ID");
            entity.Property(e => e.DesgradeGradeId).HasColumnName("DESGRADE_GRADE_ID");
            entity.Property(e => e.DesgradeSchId).HasColumnName("DESGRADE_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.DesgradeDesig).WithMany(p => p.DesigGradeDetails)
                .HasForeignKey(d => d.DesgradeDesigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DesigGradeDetails_DesigMaster");

            entity.HasOne(d => d.DesgradeGrade).WithMany(p => p.DesigGradeDetails)
                .HasForeignKey(d => d.DesgradeGradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DesigGradeDetails_GradeMaster");
        });

        modelBuilder.Entity<DesigMaster>(entity =>
        {
            entity.HasKey(e => e.DesigId);

            entity.ToTable("DesigMaster");

            entity.Property(e => e.DesigId).HasColumnName("DESIG_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.DesigCmpId).HasColumnName("DESIG_CMP_ID");
            entity.Property(e => e.DesigCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DESIG_CODE");
            entity.Property(e => e.DesigName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESIG_NAME");
            entity.Property(e => e.DesigSchId).HasColumnName("DESIG_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<DriverMaster>(entity =>
        {
            entity.HasKey(e => e.DriverId);

            entity.ToTable("DriverMaster");

            entity.Property(e => e.DriverId).HasColumnName("DRIVER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.DriverAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_ADDRESS");
            entity.Property(e => e.DriverCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_CITY");
            entity.Property(e => e.DriverCityId).HasColumnName("DRIVER_CITY_ID");
            entity.Property(e => e.DriverCmpId).HasColumnName("DRIVER_CMP_ID");
            entity.Property(e => e.DriverDob)
                .HasColumnType("datetime")
                .HasColumnName("DRIVER_DOB");
            entity.Property(e => e.DriverFatherName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DRIVER_FATHER_NAME");
            entity.Property(e => e.DriverFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_FIRST_NAME");
            entity.Property(e => e.DriverImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DRIVER_IMAGE");
            entity.Property(e => e.DriverLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_LAST_NAME");
            entity.Property(e => e.DriverLicenceDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DRIVER_LICENCE_DESCRIPTION");
            entity.Property(e => e.DriverLicenceImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DRIVER_LICENCE_IMAGE");
            entity.Property(e => e.DriverLicenceIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("DRIVER_LICENCE_ISSUE_DATE");
            entity.Property(e => e.DriverLicenceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_LICENCE_NUMBER");
            entity.Property(e => e.DriverLicenceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_LICENCE_TYPE");
            entity.Property(e => e.DriverLicenceValidDate)
                .HasColumnType("datetime")
                .HasColumnName("DRIVER_LICENCE_VALID_DATE");
            entity.Property(e => e.DriverMobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_MOBILE_PHONE");
            entity.Property(e => e.DriverPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_PHONE");
            entity.Property(e => e.DriverQualId).HasColumnName("DRIVER_QUAL_ID");
            entity.Property(e => e.DriverSchId).HasColumnName("DRIVER_SCH_ID");
            entity.Property(e => e.DriverState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_STATE");
            entity.Property(e => e.DriverStateId).HasColumnName("DRIVER_STATE_ID");
            entity.Property(e => e.DriverZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DRIVER_ZIPCODE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<EmpAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.EmpAttendId).HasName("PK_EMPAttendanceDetails");

            entity.Property(e => e.EmpAttendId).HasColumnName("EMP_ATTEND_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpAttendCmpId).HasColumnName("EMP_ATTEND_CMP_ID");
            entity.Property(e => e.EmpAttendDate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ATTEND_DATE");
            entity.Property(e => e.EmpAttendEmpId).HasColumnName("EMP_ATTEND_EMP_ID");
            entity.Property(e => e.EmpAttendIsHalfDay).HasColumnName("EMP_ATTEND_IS_HALF_DAY");
            entity.Property(e => e.EmpAttendLeaveId).HasColumnName("EMP_ATTEND_LEAVE_ID");
            entity.Property(e => e.EmpAttendMonth).HasColumnName("EMP_ATTEND_MONTH");
            entity.Property(e => e.EmpAttendSchId).HasColumnName("EMP_ATTEND_SCH_ID");
            entity.Property(e => e.EmpAttendStatus).HasColumnName("EMP_ATTEND_STATUS");
            entity.Property(e => e.EmpAttendTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_ATTEND_TIME");
            entity.Property(e => e.EmpAttendYear).HasColumnName("EMP_ATTEND_YEAR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EmpAttendEmp).WithMany(p => p.EmpAttendanceDetails)
                .HasForeignKey(d => d.EmpAttendEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpAttendanceDetails_EmpMaster");
        });

        modelBuilder.Entity<EmpAttendanceDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.EmpAttendhId).HasName("PK_EMPAttendanceDetailsHistory");

            entity.ToTable("EmpAttendanceDetailsHistory");

            entity.Property(e => e.EmpAttendhId).HasColumnName("EMP_ATTENDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpAttendhCmpId).HasColumnName("EMP_ATTENDH_CMP_ID");
            entity.Property(e => e.EmpAttendhDate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ATTENDH_DATE");
            entity.Property(e => e.EmpAttendhEmpId).HasColumnName("EMP_ATTENDH_EMP_ID");
            entity.Property(e => e.EmpAttendhIsHalfDay).HasColumnName("EMP_ATTENDH_IS_HALF_DAY");
            entity.Property(e => e.EmpAttendhLeaveId).HasColumnName("EMP_ATTENDH_LEAVE_ID");
            entity.Property(e => e.EmpAttendhMonth).HasColumnName("EMP_ATTENDH_MONTH");
            entity.Property(e => e.EmpAttendhSchId).HasColumnName("EMP_ATTENDH_SCH_ID");
            entity.Property(e => e.EmpAttendhStatus).HasColumnName("EMP_ATTENDH_STATUS");
            entity.Property(e => e.EmpAttendhTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_ATTENDH_TIME");
            entity.Property(e => e.EmpAttendhYear).HasColumnName("EMP_ATTENDH_YEAR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EmpAttendhEmp).WithMany(p => p.EmpAttendanceDetailsHistories)
                .HasForeignKey(d => d.EmpAttendhEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpAttendanceDetailsHistory_EmpMaster");
        });

        modelBuilder.Entity<EmpCatLeaveDetail>(entity =>
        {
            entity.HasKey(e => e.EcatLeaveDetailId);

            entity.Property(e => e.EcatLeaveDetailId).HasColumnName("ECAT_LEAVE_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EcatLeaveCatId).HasColumnName("ECAT_LEAVE_CAT_ID");
            entity.Property(e => e.EcatLeaveCmpId).HasColumnName("ECAT_LEAVE_CMP_ID");
            entity.Property(e => e.EcatLeaveSchId).HasColumnName("ECAT_LEAVE_SCH_ID");
            entity.Property(e => e.EcatLeaveSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ECAT_LEAVE_SESSION");
            entity.Property(e => e.EcatLeaveTotalLeaves)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ECAT_LEAVE_TOTAL_LEAVES");
            entity.Property(e => e.EcatLeaveTypeId).HasColumnName("ECAT_LEAVE_TYPE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EcatLeaveCat).WithMany(p => p.EmpCatLeaveDetails)
                .HasForeignKey(d => d.EcatLeaveCatId)
                .HasConstraintName("FK_EmpCatLeaveDetails_EmpCategoryMaster");

            entity.HasOne(d => d.EcatLeaveType).WithMany(p => p.EmpCatLeaveDetails)
                .HasForeignKey(d => d.EcatLeaveTypeId)
                .HasConstraintName("FK_EmpCatLeaveDetails_LeaveTypeMaster");
        });

        modelBuilder.Entity<EmpCatLeaveDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.EcathLeaveDetailId);

            entity.ToTable("EmpCatLeaveDetailsHistory");

            entity.Property(e => e.EcathLeaveDetailId).HasColumnName("ECATH_LEAVE_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EcathLeaveCatId).HasColumnName("ECATH_LEAVE_CAT_ID");
            entity.Property(e => e.EcathLeaveCmpId).HasColumnName("ECATH_LEAVE_CMP_ID");
            entity.Property(e => e.EcathLeaveSchId).HasColumnName("ECATH_LEAVE_SCH_ID");
            entity.Property(e => e.EcathLeaveSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ECATH_LEAVE_SESSION");
            entity.Property(e => e.EcathLeaveTotalLeaves)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ECATH_LEAVE_TOTAL_LEAVES");
            entity.Property(e => e.EcathLeaveTypeId).HasColumnName("ECATH_LEAVE_TYPE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EcathLeaveCat).WithMany(p => p.EmpCatLeaveDetailsHistories)
                .HasForeignKey(d => d.EcathLeaveCatId)
                .HasConstraintName("FK_EmpCatLeaveDetailsHistory_EmpCategoryMaster");

            entity.HasOne(d => d.EcathLeaveType).WithMany(p => p.EmpCatLeaveDetailsHistories)
                .HasForeignKey(d => d.EcathLeaveTypeId)
                .HasConstraintName("FK_EmpCatLeaveDetailsHistory_LeaveTypeMaster");
        });

        modelBuilder.Entity<EmpCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.EmpCatId);

            entity.ToTable("EmpCategoryMaster");

            entity.Property(e => e.EmpCatId).HasColumnName("EMP_CAT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpCatCmpId).HasColumnName("EMP_CAT_CMP_ID");
            entity.Property(e => e.EmpCatDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMP_CAT_DESC");
            entity.Property(e => e.EmpCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_CAT_NAME");
            entity.Property(e => e.EmpCatSchId).HasColumnName("EMP_CAT_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<EmpDocumentDetail>(entity =>
        {
            entity.HasKey(e => e.EdocId);

            entity.Property(e => e.EdocId).HasColumnName("EDOC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EdocCmpId).HasColumnName("EDOC_CMP_ID");
            entity.Property(e => e.EdocDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EDOC_DESCRIPTION");
            entity.Property(e => e.EdocEmpId).HasColumnName("EDOC_EMP_ID");
            entity.Property(e => e.EdocFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EDOC_FILENAME");
            entity.Property(e => e.EdocName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EDOC_NAME");
            entity.Property(e => e.EdocSchId).HasColumnName("EDOC_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EdocEmp).WithMany(p => p.EmpDocumentDetails)
                .HasForeignKey(d => d.EdocEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpDocumentDetails_EmpMaster");
        });

        modelBuilder.Entity<EmpLeaveAvailDetail>(entity =>
        {
            entity.HasKey(e => e.EmpladId);

            entity.Property(e => e.EmpladId).HasColumnName("EMPLAD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpladAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMPLAD_ADDRESS");
            entity.Property(e => e.EmpladApplyDate)
                .HasColumnType("datetime")
                .HasColumnName("EMPLAD_APPLY_DATE");
            entity.Property(e => e.EmpladCmpId).HasColumnName("EMPLAD_CMP_ID");
            entity.Property(e => e.EmpladContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLAD_CONTACT_NUMBER");
            entity.Property(e => e.EmpladEmpId).HasColumnName("EMPLAD_EMP_ID");
            entity.Property(e => e.EmpladEndDate)
                .HasColumnType("datetime")
                .HasColumnName("EMPLAD_END_DATE");
            entity.Property(e => e.EmpladIsHalfDay).HasColumnName("EMPLAD_IS_HALF_DAY");
            entity.Property(e => e.EmpladLeaveTypeId).HasColumnName("EMPLAD_LEAVE_TYPE_ID");
            entity.Property(e => e.EmpladReason)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMPLAD_REASON");
            entity.Property(e => e.EmpladSchId).HasColumnName("EMPLAD_SCH_ID");
            entity.Property(e => e.EmpladSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLAD_SESSION");
            entity.Property(e => e.EmpladStartDate)
                .HasColumnType("datetime")
                .HasColumnName("EMPLAD_START_DATE");
            entity.Property(e => e.EmpladStatusId).HasColumnName("EMPLAD_STATUS_ID");
            entity.Property(e => e.EmpladTotalDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLAD_TOTAL_DAYS");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EmpladEmp).WithMany(p => p.EmpLeaveAvailDetails)
                .HasForeignKey(d => d.EmpladEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveAvailDetails_EmpMaster");

            entity.HasOne(d => d.EmpladLeaveType).WithMany(p => p.EmpLeaveAvailDetails)
                .HasForeignKey(d => d.EmpladLeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveAvailDetails_LeaveTypeMaster");

            entity.HasOne(d => d.EmpladStatus).WithMany(p => p.EmpLeaveAvailDetails)
                .HasForeignKey(d => d.EmpladStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveAvailDetails_LeaveStatusMaster");
        });

        modelBuilder.Entity<EmpLeaveDetail>(entity =>
        {
            entity.HasKey(e => e.EmpldId);

            entity.Property(e => e.EmpldId).HasColumnName("EMPLD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpldCatId).HasColumnName("EMPLD_CAT_ID");
            entity.Property(e => e.EmpldCmpId).HasColumnName("EMPLD_CMP_ID");
            entity.Property(e => e.EmpldCurrentBalance)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLD_CURRENT_BALANCE");
            entity.Property(e => e.EmpldEmpId).HasColumnName("EMPLD_EMP_ID");
            entity.Property(e => e.EmpldLeaveTypeId).HasColumnName("EMPLD_LEAVE_TYPE_ID");
            entity.Property(e => e.EmpldPrevYearBalance)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLD_PREV_YEAR_BALANCE");
            entity.Property(e => e.EmpldSchId).HasColumnName("EMPLD_SCH_ID");
            entity.Property(e => e.EmpldSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLD_SESSION");
            entity.Property(e => e.EmpldTotalLeaves)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLD_TOTAL_LEAVES");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EmpldCat).WithMany(p => p.EmpLeaveDetails)
                .HasForeignKey(d => d.EmpldCatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveDetails_EmpCategoryMaster");

            entity.HasOne(d => d.EmpldEmp).WithMany(p => p.EmpLeaveDetails)
                .HasForeignKey(d => d.EmpldEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveDetails_EmpMaster");

            entity.HasOne(d => d.EmpldLeaveType).WithMany(p => p.EmpLeaveDetails)
                .HasForeignKey(d => d.EmpldLeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveDetails_LeaveTypesMaster");
        });

        modelBuilder.Entity<EmpLeaveDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.EmpldhId);

            entity.ToTable("EmpLeaveDetailsHistory");

            entity.Property(e => e.EmpldhId).HasColumnName("EMPLDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpldhCatId).HasColumnName("EMPLDH_CAT_ID");
            entity.Property(e => e.EmpldhCmpId).HasColumnName("EMPLDH_CMP_ID");
            entity.Property(e => e.EmpldhCurrentBalance)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLDH_CURRENT_BALANCE");
            entity.Property(e => e.EmpldhEmpId).HasColumnName("EMPLDH_EMP_ID");
            entity.Property(e => e.EmpldhLeaveTypeId).HasColumnName("EMPLDH_LEAVE_TYPE_ID");
            entity.Property(e => e.EmpldhPrevYearBalance)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLDH_PREV_YEAR_BALANCE");
            entity.Property(e => e.EmpldhSchId).HasColumnName("EMPLDH_SCH_ID");
            entity.Property(e => e.EmpldhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLDH_SESSION");
            entity.Property(e => e.EmpldhTotalLeaves)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EMPLDH_TOTAL_LEAVES");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EmpldhCat).WithMany(p => p.EmpLeaveDetailsHistories)
                .HasForeignKey(d => d.EmpldhCatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveDetailsHistory_EmpCategoryMaster");

            entity.HasOne(d => d.EmpldhEmp).WithMany(p => p.EmpLeaveDetailsHistories)
                .HasForeignKey(d => d.EmpldhEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveDetailsHistory_EmpMaster");

            entity.HasOne(d => d.EmpldhLeaveType).WithMany(p => p.EmpLeaveDetailsHistories)
                .HasForeignKey(d => d.EmpldhLeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpLeaveDetailsHistory_LeaveTypesMaster");
        });

        modelBuilder.Entity<EmpMaster>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EmpMaster");

            entity.Property(e => e.EmpId).HasColumnName("EMP_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpAadharNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_AADHAR_NUMBER");
            entity.Property(e => e.EmpBankAccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_BANK_ACCOUNT_NUMBER");
            entity.Property(e => e.EmpBankName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_BANK_NAME");
            entity.Property(e => e.EmpBloodGroupId).HasColumnName("EMP_BLOOD_GROUP_ID");
            entity.Property(e => e.EmpCatId).HasColumnName("EMP_CAT_ID");
            entity.Property(e => e.EmpCategoryId).HasColumnName("EMP_CATEGORY_ID");
            entity.Property(e => e.EmpCmpId).HasColumnName("EMP_CMP_ID");
            entity.Property(e => e.EmpConfirmationDate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_CONFIRMATION_DATE");
            entity.Property(e => e.EmpCurrentAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMP_CURRENT_ADDRESS");
            entity.Property(e => e.EmpCurrentCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_CURRENT_CITY");
            entity.Property(e => e.EmpCurrentCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_CURRENT_COUNTRY");
            entity.Property(e => e.EmpCurrentState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_CURRENT_STATE");
            entity.Property(e => e.EmpCurrentZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMP_CURRENT_ZIPCODE");
            entity.Property(e => e.EmpDateOfLeaving)
                .HasColumnType("datetime")
                .HasColumnName("EMP_DATE_OF_LEAVING");
            entity.Property(e => e.EmpDeptId).HasColumnName("EMP_DEPT_ID");
            entity.Property(e => e.EmpDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_DESCRIPTION");
            entity.Property(e => e.EmpDesigId).HasColumnName("EMP_DESIG_ID");
            entity.Property(e => e.EmpDob)
                .HasColumnType("datetime")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpDoj)
                .HasColumnType("datetime")
                .HasColumnName("EMP_DOJ");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnglishUptoClass).HasColumnName("EMP_ENGLISH_UPTO_CLASS");
            entity.Property(e => e.EmpEsicNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_ESIC_NUMBER");
            entity.Property(e => e.EmpFathersName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_FATHERS_NAME");
            entity.Property(e => e.EmpFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_FIRST_NAME");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGradeId).HasColumnName("EMP_GRADE_ID");
            entity.Property(e => e.EmpImage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMP_IMAGE");
            entity.Property(e => e.EmpLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_LAST_NAME");
            entity.Property(e => e.EmpLicenceDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMP_LICENCE_DESCRIPTION");
            entity.Property(e => e.EmpLicenceImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMP_LICENCE_IMAGE");
            entity.Property(e => e.EmpLicenceIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_LICENCE_ISSUE_DATE");
            entity.Property(e => e.EmpLicenceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_LICENCE_NUMBER");
            entity.Property(e => e.EmpLicenceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_LICENCE_TYPE");
            entity.Property(e => e.EmpLicenceValidDate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_LICENCE_VALID_DATE");
            entity.Property(e => e.EmpMartialStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMP_MARTIAL_STATUS");
            entity.Property(e => e.EmpMathsUptoClass).HasColumnName("EMP_MATHS_UPTO_CLASS");
            entity.Property(e => e.EmpMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_MOBILE");
            entity.Property(e => e.EmpOldId).HasColumnName("EMP_OLD_ID");
            entity.Property(e => e.EmpPanNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_PAN_NUMBER");
            entity.Property(e => e.EmpPaymentModeId).HasColumnName("EMP_PAYMENT_MODE_ID");
            entity.Property(e => e.EmpPermanentAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMP_PERMANENT_ADDRESS");
            entity.Property(e => e.EmpPermanentCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_PERMANENT_CITY");
            entity.Property(e => e.EmpPermanentCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_PERMANENT_COUNTRY");
            entity.Property(e => e.EmpPermanentState)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("EMP_PERMANENT_STATE");
            entity.Property(e => e.EmpPermanentZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMP_PERMANENT_ZIPCODE");
            entity.Property(e => e.EmpPfNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_PF_NUMBER");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPreviousSchoolCompany)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMP_PREVIOUS_SCHOOL_COMPANY");
            entity.Property(e => e.EmpProbationPeriod).HasColumnName("EMP_PROBATION_PERIOD");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSchId).HasColumnName("EMP_SCH_ID");
            entity.Property(e => e.EmpSstUptoClass).HasColumnName("EMP_SST_UPTO_CLASS");
            entity.Property(e => e.EmpTypeId).HasColumnName("EMP_TYPE_ID");
            entity.Property(e => e.EmpYearsOfExperiecne)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_YEARS_OF_EXPERIECNE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EmpCat).WithMany(p => p.EmpMasters)
                .HasForeignKey(d => d.EmpCatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpMaster_EmpCategoryMaster");

            entity.HasOne(d => d.EmpDept).WithMany(p => p.EmpMasters)
                .HasForeignKey(d => d.EmpDeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpMaster_EmpDeptMaster");

            entity.HasOne(d => d.EmpDesig).WithMany(p => p.EmpMasters)
                .HasForeignKey(d => d.EmpDesigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpMaster_EmpDeptDesigDetails");

            entity.HasOne(d => d.EmpPaymentMode).WithMany(p => p.EmpMasters)
                .HasForeignKey(d => d.EmpPaymentModeId)
                .HasConstraintName("FK_EmpMaster_PayModeMaster");

            entity.HasOne(d => d.EmpType).WithMany(p => p.EmpMasters)
                .HasForeignKey(d => d.EmpTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpMaster_EmpTypes");
        });

        modelBuilder.Entity<EmpProfQualiDetail>(entity =>
        {
            entity.HasKey(e => new { e.EpqualdEmpId, e.EpqualdQualId });

            entity.Property(e => e.EpqualdEmpId).HasColumnName("EPQUALD_EMP_ID");
            entity.Property(e => e.EpqualdQualId).HasColumnName("EPQUALD_QUAL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EpqualdEmp).WithMany(p => p.EmpProfQualiDetails)
                .HasForeignKey(d => d.EpqualdEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpProfQualiDetails_EmpMaster");

            entity.HasOne(d => d.EpqualdQual).WithMany(p => p.EmpProfQualiDetails)
                .HasForeignKey(d => d.EpqualdQualId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpProfQualiDetails_QualificationMaster");
        });

        modelBuilder.Entity<EmpSalaryDetail>(entity =>
        {
            entity.HasKey(e => e.EsaldId);

            entity.Property(e => e.EsaldId).HasColumnName("ESALD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EsaldAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALD_AMOUNT");
            entity.Property(e => e.EsaldCmpId).HasColumnName("ESALD_CMP_ID");
            entity.Property(e => e.EsaldDesgradeId).HasColumnName("ESALD_DESGRADE_ID");
            entity.Property(e => e.EsaldEsalmId).HasColumnName("ESALD_ESALM_ID");
            entity.Property(e => e.EsaldIsDeduction).HasColumnName("ESALD_IS_DEDUCTION");
            entity.Property(e => e.EsaldIsSalaryHead)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESALD_IS_SALARY_HEAD");
            entity.Property(e => e.EsaldSalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESALD_SAL_CODE");
            entity.Property(e => e.EsaldSalDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESALD_SAL_DESCRIPTION");
            entity.Property(e => e.EsaldSalaryType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESALD_SALARY_TYPE");
            entity.Property(e => e.EsaldSalhmId).HasColumnName("ESALD_SALHM_ID");
            entity.Property(e => e.EsaldSchId).HasColumnName("ESALD_SCH_ID");
            entity.Property(e => e.EsaldValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALD_VALUE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<EmpSalaryDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.EsaldhId);

            entity.ToTable("EmpSalaryDetailsHistory");

            entity.Property(e => e.EsaldhId).HasColumnName("ESALDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EsaldhAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALDH_AMOUNT");
            entity.Property(e => e.EsaldhCmpId).HasColumnName("ESALDH_CMP_ID");
            entity.Property(e => e.EsaldhDesgradeId).HasColumnName("ESALDH_DESGRADE_ID");
            entity.Property(e => e.EsaldhEsalmId).HasColumnName("ESALDH_ESALM_ID");
            entity.Property(e => e.EsaldhIsDeduction).HasColumnName("ESALDH_IS_DEDUCTION");
            entity.Property(e => e.EsaldhIsSalaryHead)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESALDH_IS_SALARY_HEAD");
            entity.Property(e => e.EsaldhSalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESALDH_SAL_CODE");
            entity.Property(e => e.EsaldhSalDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESALDH_SAL_DESCRIPTION");
            entity.Property(e => e.EsaldhSalaryType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESALDH_SALARY_TYPE");
            entity.Property(e => e.EsaldhSalhmId).HasColumnName("ESALDH_SALHM_ID");
            entity.Property(e => e.EsaldhSchId).HasColumnName("ESALDH_SCH_ID");
            entity.Property(e => e.EsaldhValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALDH_VALUE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<EmpSalaryMaster>(entity =>
        {
            entity.HasKey(e => e.EsalmId);

            entity.ToTable("EmpSalaryMaster");

            entity.Property(e => e.EsalmId).HasColumnName("ESALM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EsalmAbsentDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESALM_ABSENT_DAYS");
            entity.Property(e => e.EsalmAllowances)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALM_ALLOWANCES");
            entity.Property(e => e.EsalmBasicSalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALM_BASIC_SALARY");
            entity.Property(e => e.EsalmBatchprintDate)
                .HasColumnType("datetime")
                .HasColumnName("ESALM_BATCHPRINT_DATE");
            entity.Property(e => e.EsalmCmpId).HasColumnName("ESALM_CMP_ID");
            entity.Property(e => e.EsalmDeductions)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALM_DEDUCTIONS");
            entity.Property(e => e.EsalmDeptId).HasColumnName("ESALM_DEPT_ID");
            entity.Property(e => e.EsalmDesigId).HasColumnName("ESALM_DESIG_ID");
            entity.Property(e => e.EsalmEmpId).HasColumnName("ESALM_EMP_ID");
            entity.Property(e => e.EsalmGradeId).HasColumnName("ESALM_GRADE_ID");
            entity.Property(e => e.EsalmLeaveBalanceDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ESALM_LEAVE_BALANCE_DESC");
            entity.Property(e => e.EsalmLeaveDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESALM_LEAVE_DAYS");
            entity.Property(e => e.EsalmLeaveDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ESALM_LEAVE_DESC");
            entity.Property(e => e.EsalmMonth).HasColumnName("ESALM_MONTH");
            entity.Property(e => e.EsalmNetSalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALM_NET_SALARY");
            entity.Property(e => e.EsalmPerDaySalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALM_PER_DAY_SALARY");
            entity.Property(e => e.EsalmPresentDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESALM_PRESENT_DAYS");
            entity.Property(e => e.EsalmSchId).HasColumnName("ESALM_SCH_ID");
            entity.Property(e => e.EsalmSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESALM_SESSION");
            entity.Property(e => e.EsalmTotalDays).HasColumnName("ESALM_TOTAL_DAYS");
            entity.Property(e => e.EsalmYear).HasColumnName("ESALM_YEAR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<EmpSalaryMasterHistory>(entity =>
        {
            entity.HasKey(e => e.EsalmhId);

            entity.ToTable("EmpSalaryMasterHistory");

            entity.Property(e => e.EsalmhId).HasColumnName("ESALMH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EsalmhAbsentDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESALMH_ABSENT_DAYS");
            entity.Property(e => e.EsalmhAllowances)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALMH_ALLOWANCES");
            entity.Property(e => e.EsalmhBasicSalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALMH_BASIC_SALARY");
            entity.Property(e => e.EsalmhBatchprintDate)
                .HasColumnType("datetime")
                .HasColumnName("ESALMH_BATCHPRINT_DATE");
            entity.Property(e => e.EsalmhCmpId).HasColumnName("ESALMH_CMP_ID");
            entity.Property(e => e.EsalmhDeductions)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALMH_DEDUCTIONS");
            entity.Property(e => e.EsalmhDeptId).HasColumnName("ESALMH_DEPT_ID");
            entity.Property(e => e.EsalmhDesigId).HasColumnName("ESALMH_DESIG_ID");
            entity.Property(e => e.EsalmhEmpId).HasColumnName("ESALMH_EMP_ID");
            entity.Property(e => e.EsalmhEsalmId).HasColumnName("ESALMH_ESALM_ID");
            entity.Property(e => e.EsalmhGradeId).HasColumnName("ESALMH_GRADE_ID");
            entity.Property(e => e.EsalmhLeaveBalanceDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ESALMH_LEAVE_BALANCE_DESC");
            entity.Property(e => e.EsalmhLeaveDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESALMH_LEAVE_DAYS");
            entity.Property(e => e.EsalmhLeaveDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ESALMH_LEAVE_DESC");
            entity.Property(e => e.EsalmhMonth).HasColumnName("ESALMH_MONTH");
            entity.Property(e => e.EsalmhNetSalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALMH_NET_SALARY");
            entity.Property(e => e.EsalmhPerDaySalary)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESALMH_PER_DAY_SALARY");
            entity.Property(e => e.EsalmhPresentDays)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESALMH_PRESENT_DAYS");
            entity.Property(e => e.EsalmhSchId).HasColumnName("ESALMH_SCH_ID");
            entity.Property(e => e.EsalmhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESALMH_SESSION");
            entity.Property(e => e.EsalmhTotalDays).HasColumnName("ESALMH_TOTAL_DAYS");
            entity.Property(e => e.EsalmhYear).HasColumnName("ESALMH_YEAR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<EmpSalaryStructureDetail>(entity =>
        {
            entity.HasKey(e => e.EssdId);

            entity.Property(e => e.EssdId).HasColumnName("ESSD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EsddCmpId).HasColumnName("ESDD_CMP_ID");
            entity.Property(e => e.EsddSalhDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESDD_SALH_DESCRIPTION");
            entity.Property(e => e.EsddSalhIsReadonly).HasColumnName("ESDD_SALH_IS_READONLY");
            entity.Property(e => e.EsddSchId).HasColumnName("ESDD_SCH_ID");
            entity.Property(e => e.EssdDesgradeId).HasColumnName("ESSD_DESGRADE_ID");
            entity.Property(e => e.EssdEmpId).HasColumnName("ESSD_EMP_ID");
            entity.Property(e => e.EssdIsDeductance).HasColumnName("ESSD_IS_DEDUCTANCE");
            entity.Property(e => e.EssdSalaryType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESSD_SALARY_TYPE");
            entity.Property(e => e.EssdSalhCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESSD_SALH_CODE");
            entity.Property(e => e.EssdSalhmId).HasColumnName("ESSD_SALHM_ID");
            entity.Property(e => e.EssdSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESSD_SESSION");
            entity.Property(e => e.EssdValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESSD_VALUE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EssdDesgrade).WithMany(p => p.EmpSalaryStructureDetails)
                .HasForeignKey(d => d.EssdDesgradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpSalaryStructureDetails_DesigGradeDetails");

            entity.HasOne(d => d.EssdEmp).WithMany(p => p.EmpSalaryStructureDetails)
                .HasForeignKey(d => d.EssdEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpSalaryStructureDetails_EmpMaster");
        });

        modelBuilder.Entity<EmpSalaryStructureDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.EssdhId);

            entity.ToTable("EmpSalaryStructureDetailsHistory");

            entity.Property(e => e.EssdhId).HasColumnName("ESSDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EsddhCmpId).HasColumnName("ESDDH_CMP_ID");
            entity.Property(e => e.EsddhSalhDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESDDH_SALH_DESCRIPTION");
            entity.Property(e => e.EsddhSalhIsReadonly).HasColumnName("ESDDH_SALH_IS_READONLY");
            entity.Property(e => e.EsddhSchId).HasColumnName("ESDDH_SCH_ID");
            entity.Property(e => e.EssdhDesgradeId).HasColumnName("ESSDH_DESGRADE_ID");
            entity.Property(e => e.EssdhEmpId).HasColumnName("ESSDH_EMP_ID");
            entity.Property(e => e.EssdhIsActive).HasColumnName("ESSDH_IS_ACTIVE");
            entity.Property(e => e.EssdhIsDeductance).HasColumnName("ESSDH_IS_DEDUCTANCE");
            entity.Property(e => e.EssdhSalaryType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESSDH_SALARY_TYPE");
            entity.Property(e => e.EssdhSalhCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ESSDH_SALH_CODE");
            entity.Property(e => e.EssdhSalhmId).HasColumnName("ESSDH_SALHM_ID");
            entity.Property(e => e.EssdhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESSDH_SESSION");
            entity.Property(e => e.EssdhValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESSDH_VALUE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.EssdhDesgrade).WithMany(p => p.EmpSalaryStructureDetailsHistories)
                .HasForeignKey(d => d.EssdhDesgradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpSalaryStructureDetailsHistory_DesigGradeDetails");

            entity.HasOne(d => d.EssdhEmp).WithMany(p => p.EmpSalaryStructureDetailsHistories)
                .HasForeignKey(d => d.EssdhEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpSalaryStructureDetailsHistory_EmpMaster");
        });

        modelBuilder.Entity<EmpTypeMaster>(entity =>
        {
            entity.HasKey(e => e.EmpTypeId);

            entity.ToTable("EmpTypeMaster");

            entity.Property(e => e.EmpTypeId).HasColumnName("EMP_TYPE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.EmpTypeCmpId).HasColumnName("EMP_TYPE_CMP_ID");
            entity.Property(e => e.EmpTypeDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMP_TYPE_DESC");
            entity.Property(e => e.EmpTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMP_TYPE_NAME");
            entity.Property(e => e.EmpTypeSchId).HasColumnName("EMP_TYPE_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ExamCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.ExamCatId);

            entity.ToTable("ExamCategoryMaster");

            entity.Property(e => e.ExamCatId).HasColumnName("EXAM_CAT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.ExamCatCmpId).HasColumnName("EXAM_CAT_CMP_ID");
            entity.Property(e => e.ExamCatDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXAM_CAT_DESC");
            entity.Property(e => e.ExamCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXAM_CAT_NAME");
            entity.Property(e => e.ExamCatSchId).HasColumnName("EXAM_CAT_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ExamUnitMaster>(entity =>
        {
            entity.HasKey(e => e.ExamUnitId).HasName("PK_ExamUnitMaster_1");

            entity.ToTable("ExamUnitMaster");

            entity.Property(e => e.ExamUnitId).HasColumnName("EXAM_UNIT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.ExamUnitName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXAM_UNIT_NAME");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ExpenseCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.ExpCatId);

            entity.ToTable("ExpenseCategoryMaster");

            entity.Property(e => e.ExpCatId).HasColumnName("EXP_CAT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.ExpCatCmpId).HasColumnName("EXP_CAT_CMP_ID");
            entity.Property(e => e.ExpCatDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EXP_CAT_DESC");
            entity.Property(e => e.ExpCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXP_CAT_NAME");
            entity.Property(e => e.ExpCatSchId).HasColumnName("EXP_CAT_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<FeeClassDetail>(entity =>
        {
            entity.HasKey(e => e.FcdId).HasName("PK_FeesMaster");

            entity.Property(e => e.FcdId).HasColumnName("FCD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.FcdAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FCD_AMOUNT");
            entity.Property(e => e.FcdCmId).HasColumnName("FCD_CM_ID");
            entity.Property(e => e.FcdCmpId).HasColumnName("FCD_CMP_ID");
            entity.Property(e => e.FcdFeeCatId).HasColumnName("FCD_FEE_CAT_ID");
            entity.Property(e => e.FcdFromDate)
                .HasColumnType("datetime")
                .HasColumnName("FCD_FROM_DATE");
            entity.Property(e => e.FcdSchId).HasColumnName("FCD_SCH_ID");
            entity.Property(e => e.FcdSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCD_SESSION");
            entity.Property(e => e.FcdToDate)
                .HasColumnType("datetime")
                .HasColumnName("FCD_TO_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<FeeClassDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.FcdhId);

            entity.ToTable("FeeClassDetailsHistory");

            entity.Property(e => e.FcdhId).HasColumnName("FCDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.FcdhAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FCDH_AMOUNT");
            entity.Property(e => e.FcdhCmId).HasColumnName("FCDH_CM_ID");
            entity.Property(e => e.FcdhCmpId).HasColumnName("FCDH_CMP_ID");
            entity.Property(e => e.FcdhFeeCatId).HasColumnName("FCDH_FEE_CAT_ID");
            entity.Property(e => e.FcdhFromDate)
                .HasColumnType("datetime")
                .HasColumnName("FCDH_FROM_DATE");
            entity.Property(e => e.FcdhSchId).HasColumnName("FCDH_SCH_ID");
            entity.Property(e => e.FcdhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCDH_SESSION");
            entity.Property(e => e.FcdhToDate)
                .HasColumnType("datetime")
                .HasColumnName("FCDH_TO_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.FcdhCm).WithMany(p => p.FeeClassDetailsHistories)
                .HasForeignKey(d => d.FcdhCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeeClassDetailsHistory_ClassMaster");

            entity.HasOne(d => d.FcdhFeeCat).WithMany(p => p.FeeClassDetailsHistories)
                .HasForeignKey(d => d.FcdhFeeCatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeeClassDetailsHistory_FeeCategoryMaster");
        });

        modelBuilder.Entity<FeesCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.FcmId);

            entity.ToTable("FeesCategoryMaster");

            entity.Property(e => e.FcmId).HasColumnName("FCM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.FcmCatCmpId).HasColumnName("FCM_CAT_CMP_ID");
            entity.Property(e => e.FcmCatDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FCM_CAT_DESCRIPTION");
            entity.Property(e => e.FcmCatName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCM_CAT_NAME");
            entity.Property(e => e.FcmCatSchId).HasColumnName("FCM_CAT_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<FeesDiscountCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.FdcmId);

            entity.ToTable("FeesDiscountCategoryMaster");

            entity.Property(e => e.FdcmId).HasColumnName("FDCM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.FdcmAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FDCM_AMOUNT");
            entity.Property(e => e.FdcmCmpId).HasColumnName("FDCM_CMP_ID");
            entity.Property(e => e.FdcmDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FDCM_DESCRIPTION");
            entity.Property(e => e.FdcmFeeCatId).HasColumnName("FDCM_FEE_CAT_ID");
            entity.Property(e => e.FdcmIsPercentage).HasColumnName("FDCM_IS_PERCENTAGE");
            entity.Property(e => e.FdcmName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FDCM_NAME");
            entity.Property(e => e.FdcmSchId).HasColumnName("FDCM_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<GradeMaster>(entity =>
        {
            entity.HasKey(e => e.GradeId);

            entity.ToTable("GradeMaster");

            entity.Property(e => e.GradeId).HasColumnName("GRADE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.GradeCmpId).HasColumnName("GRADE_CMP_ID");
            entity.Property(e => e.GradeDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("GRADE_DESC");
            entity.Property(e => e.GradeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRADE_NAME");
            entity.Property(e => e.GradeSchId).HasColumnName("GRADE_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<HolidayClassDetail>(entity =>
        {
            entity.HasKey(e => new { e.HcldHolidayId, e.HcldCmId, e.HcldSecId }).HasName("PK_HolidayClassDetails_1");

            entity.Property(e => e.HcldHolidayId).HasColumnName("HCLD_HOLIDAY_ID");
            entity.Property(e => e.HcldCmId).HasColumnName("HCLD_CM_ID");
            entity.Property(e => e.HcldSecId).HasColumnName("HCLD_SEC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.HcldCmpId).HasColumnName("HCLD_CMP_ID");
            entity.Property(e => e.HcldSchId).HasColumnName("HCLD_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.HcldCm).WithMany(p => p.HolidayClassDetails)
                .HasForeignKey(d => d.HcldCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayClassDetails_HolidayClassMaster");

            entity.HasOne(d => d.HcldHoliday).WithMany(p => p.HolidayClassDetails)
                .HasForeignKey(d => d.HcldHolidayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayClassDetails_HolidayMaster");

            entity.HasOne(d => d.HcldSec).WithMany(p => p.HolidayClassDetails)
                .HasForeignKey(d => d.HcldSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayClassDetails_HolidayClassSectionDetails");
        });

        modelBuilder.Entity<HolidayDeptDetail>(entity =>
        {
            entity.HasKey(e => new { e.HdeptHolidayId, e.HdeptDeptId });

            entity.Property(e => e.HdeptHolidayId).HasColumnName("HDEPT_HOLIDAY_ID");
            entity.Property(e => e.HdeptDeptId).HasColumnName("HDEPT_DEPT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.HdeptCmpId).HasColumnName("HDEPT_CMP_ID");
            entity.Property(e => e.HdeptSchId).HasColumnName("HDEPT_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.HdeptDept).WithMany(p => p.HolidayDeptDetails)
                .HasForeignKey(d => d.HdeptDeptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayDeptDetails_DeptMaster");

            entity.HasOne(d => d.HdeptHoliday).WithMany(p => p.HolidayDeptDetails)
                .HasForeignKey(d => d.HdeptHolidayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HolidayDeptDetails_HolidayMaster");
        });

        modelBuilder.Entity<HolidayMaster>(entity =>
        {
            entity.HasKey(e => e.HolidayId);

            entity.ToTable("HolidayMaster");

            entity.Property(e => e.HolidayId).HasColumnName("HOLIDAY_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.HolidayCmpId).HasColumnName("HOLIDAY_CMP_ID");
            entity.Property(e => e.HolidayDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("HOLIDAY_DESCRIPTION");
            entity.Property(e => e.HolidayFromDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLIDAY_FROM_DATE");
            entity.Property(e => e.HolidayIsStaffApplicable).HasColumnName("HOLIDAY_IS_STAFF_APPLICABLE");
            entity.Property(e => e.HolidayName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOLIDAY_NAME");
            entity.Property(e => e.HolidaySchId).HasColumnName("HOLIDAY_SCH_ID");
            entity.Property(e => e.HolidaySession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOLIDAY_SESSION");
            entity.Property(e => e.HolidayToDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLIDAY_TO_DATE");
            entity.Property(e => e.HolidayTypeId).HasColumnName("HOLIDAY_TYPE_ID");
            entity.Property(e => e.HolidayYear).HasColumnName("HOLIDAY_YEAR");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.HolidayType).WithMany(p => p.HolidayMasters)
                .HasForeignKey(d => d.HolidayTypeId)
                .HasConstraintName("FK_HolidayMaster_HolidayTypeMaster");
        });

        modelBuilder.Entity<HolidayTypeMaster>(entity =>
        {
            entity.HasKey(e => e.HolidayTypeId);

            entity.ToTable("HolidayTypeMaster");

            entity.Property(e => e.HolidayTypeId).HasColumnName("HOLIDAY_TYPE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.HolidayTypeCmpId).HasColumnName("HOLIDAY_TYPE_CMP_ID");
            entity.Property(e => e.HolidayTypeDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("HOLIDAY_TYPE_DESCRIPTION");
            entity.Property(e => e.HolidayTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOLIDAY_TYPE_NAME");
            entity.Property(e => e.HolidayTypeSchId).HasColumnName("HOLIDAY_TYPE_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<InventoryMaster>(entity =>
        {
            entity.HasKey(e => e.InvId);

            entity.ToTable("InventoryMaster");

            entity.Property(e => e.InvId).HasColumnName("INV_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.InvCmpId).HasColumnName("INV_CMP_ID");
            entity.Property(e => e.InvCostPerItem)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INV_COST_PER_ITEM");
            entity.Property(e => e.InvItemId).HasColumnName("INV_ITEM_ID");
            entity.Property(e => e.InvItemLocationId).HasColumnName("INV_ITEM_LOCATION_ID");
            entity.Property(e => e.InvName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INV_NAME");
            entity.Property(e => e.InvQuantity).HasColumnName("INV_QUANTITY");
            entity.Property(e => e.InvSchId).HasColumnName("INV_SCH_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.InvItem).WithMany(p => p.InventoryMasters)
                .HasForeignKey(d => d.InvItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryMaster_ItemMaster");

            entity.HasOne(d => d.InvItemLocation).WithMany(p => p.InventoryMasters)
                .HasForeignKey(d => d.InvItemLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryMaster_ItemLocationMaster");
        });

        modelBuilder.Entity<ItemLocationMaster>(entity =>
        {
            entity.HasKey(e => e.ItemLocationId);

            entity.ToTable("ItemLocationMaster");

            entity.Property(e => e.ItemLocationId).HasColumnName("ITEM_LOCATION_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ItemLocationBuilding)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_LOCATION_BUILDING");
            entity.Property(e => e.ItemLocationCapacity).HasColumnName("ITEM_LOCATION_CAPACITY");
            entity.Property(e => e.ItemLocationCmpId).HasColumnName("ITEM_LOCATION_CMP_ID");
            entity.Property(e => e.ItemLocationDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ITEM_LOCATION_DESCRIPTION");
            entity.Property(e => e.ItemLocationFloor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM_LOCATION_FLOOR");
            entity.Property(e => e.ItemLocationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_LOCATION_NAME");
            entity.Property(e => e.ItemLocationNumber).HasColumnName("ITEM_LOCATION_NUMBER");
            entity.Property(e => e.ItemLocationSchId).HasColumnName("ITEM_LOCATION_SCH_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<ItemMaster>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("ItemMaster");

            entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ItemCmpId).HasColumnName("ITEM_CMP_ID");
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ITEM_DESCRIPTION");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_NAME");
            entity.Property(e => e.ItemSchId).HasColumnName("ITEM_SCH_ID");
            entity.Property(e => e.ItemTypeMasterId).HasColumnName("ITEM_TYPE_MASTER_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.ItemTypeMaster).WithMany(p => p.ItemMasters)
                .HasForeignKey(d => d.ItemTypeMasterId)
                .HasConstraintName("FK_ItemMaster_ItemTypeMaster");
        });

        modelBuilder.Entity<ItemTypeMaster>(entity =>
        {
            entity.HasKey(e => e.ItemTypeId);

            entity.ToTable("ItemTypeMaster");

            entity.Property(e => e.ItemTypeId).HasColumnName("ITEM_TYPE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ItemTypeCmpId).HasColumnName("ITEM_TYPE_CMP_ID");
            entity.Property(e => e.ItemTypeDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ITEM_TYPE_DESCRIPTION");
            entity.Property(e => e.ItemTypeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ITEM_TYPE_NAME");
            entity.Property(e => e.ItemTypeSchId).HasColumnName("ITEM_TYPE_SCH_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<LeaveStatusMaster>(entity =>
        {
            entity.HasKey(e => e.LeaveStatusId);

            entity.ToTable("LeaveStatusMaster");

            entity.Property(e => e.LeaveStatusId).HasColumnName("LEAVE_STATUS_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LeaveStatusCmpId).HasColumnName("LEAVE_STATUS_CMP_ID");
            entity.Property(e => e.LeaveStatusDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LEAVE_STATUS_DESCRIPTION");
            entity.Property(e => e.LeaveStatusName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEAVE_STATUS_NAME");
            entity.Property(e => e.LeaveStatusSchId).HasColumnName("LEAVE_STATUS_SCH_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<LeaveTypeMaster>(entity =>
        {
            entity.HasKey(e => e.LeaveTypeId);

            entity.ToTable("LeaveTypeMaster");

            entity.Property(e => e.LeaveTypeId).HasColumnName("LEAVE_TYPE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LeaveTypeApplicableGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEAVE_TYPE_APPLICABLE_GENDER");
            entity.Property(e => e.LeaveTypeCmpId).HasColumnName("LEAVE_TYPE_CMP_ID");
            entity.Property(e => e.LeaveTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEAVE_TYPE_CODE");
            entity.Property(e => e.LeaveTypeDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LEAVE_TYPE_DESCRIPTION");
            entity.Property(e => e.LeaveTypeIsCarryForward).HasColumnName("LEAVE_TYPE_IS_CARRY_FORWARD");
            entity.Property(e => e.LeaveTypeIsEncashable).HasColumnName("LEAVE_TYPE_IS_ENCASHABLE");
            entity.Property(e => e.LeaveTypeIsSpecialLeave).HasColumnName("LEAVE_TYPE_IS_SPECIAL_LEAVE");
            entity.Property(e => e.LeaveTypeSchId).HasColumnName("LEAVE_TYPE_SCH_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<LocationMaster>(entity =>
        {
            entity.HasKey(e => e.LocId);

            entity.ToTable("LocationMaster");

            entity.Property(e => e.LocId).HasColumnName("LOC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LocCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOC_CITY");
            entity.Property(e => e.LocCmpId).HasColumnName("LOC_CMP_ID");
            entity.Property(e => e.LocCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOC_CODE");
            entity.Property(e => e.LocName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOC_NAME");
            entity.Property(e => e.LocSchId).HasColumnName("LOC_SCH_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<MarksGradeMaster>(entity =>
        {
            entity.HasKey(e => e.MarksGradeId);

            entity.ToTable("MarksGradeMaster");

            entity.Property(e => e.MarksGradeId).HasColumnName("MARKS_GRADE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.MarksGradeClassId).HasColumnName("MARKS_GRADE_CLASS_ID");
            entity.Property(e => e.MarksGradeCmpId).HasColumnName("MARKS_GRADE_CMP_ID");
            entity.Property(e => e.MarksGradeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MARKS_GRADE_CODE");
            entity.Property(e => e.MarksGradeMaxRange).HasColumnName("MARKS_GRADE_MAX_RANGE");
            entity.Property(e => e.MarksGradeMinRange).HasColumnName("MARKS_GRADE_MIN_RANGE");
            entity.Property(e => e.MarksGradePoint)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MARKS_GRADE_POINT");
            entity.Property(e => e.MarksGradeSchId).HasColumnName("MARKS_GRADE_SCH_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
        });

        modelBuilder.Entity<NotificationReceiverMaster>(entity =>
        {
            entity.HasKey(e => e.NotificationReceiverId);

            entity.ToTable("NotificationReceiverMaster");

            entity.Property(e => e.NotificationReceiverId).HasColumnName("NOTIFICATION_RECEIVER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.NotificationReceiverCmpId).HasColumnName("NOTIFICATION_RECEIVER_CMP_ID");
            entity.Property(e => e.NotificationReceiverDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTIFICATION_RECEIVER_DESC");
            entity.Property(e => e.NotificationReceiverName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOTIFICATION_RECEIVER_NAME");
            entity.Property(e => e.NotificationReceiverSchId).HasColumnName("NOTIFICATION_RECEIVER_SCH_ID");
        });

        modelBuilder.Entity<ParentMaster>(entity =>
        {
            entity.HasKey(e => e.PmId).HasName("PK_ParentDetails");

            entity.ToTable("ParentMaster");

            entity.Property(e => e.PmId).HasColumnName("PM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.PmAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PM_ADDRESS");
            entity.Property(e => e.PmCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_CITY");
            entity.Property(e => e.PmCityId).HasColumnName("PM_CITY_ID");
            entity.Property(e => e.PmCmpId).HasColumnName("PM_CMP_ID");
            entity.Property(e => e.PmDesignation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_DESIGNATION");
            entity.Property(e => e.PmDob)
                .HasColumnType("datetime")
                .HasColumnName("PM_DOB");
            entity.Property(e => e.PmEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_EMAIL");
            entity.Property(e => e.PmFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_FIRST_NAME");
            entity.Property(e => e.PmImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PM_IMAGE");
            entity.Property(e => e.PmIncome)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PM_INCOME");
            entity.Property(e => e.PmLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_LAST_NAME");
            entity.Property(e => e.PmMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_MOBILE");
            entity.Property(e => e.PmOccupation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_OCCUPATION");
            entity.Property(e => e.PmOfficeAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PM_OFFICE_ADDRESS");
            entity.Property(e => e.PmOfficeCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_OFFICE_CITY");
            entity.Property(e => e.PmOfficeCityId).HasColumnName("PM_OFFICE_CITY_ID");
            entity.Property(e => e.PmOfficePhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_OFFICE_PHONE");
            entity.Property(e => e.PmOfficeState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_OFFICE_STATE");
            entity.Property(e => e.PmOfficeStateId).HasColumnName("PM_OFFICE_STATE_ID");
            entity.Property(e => e.PmOfficeZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_OFFICE_ZIPCODE");
            entity.Property(e => e.PmPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_PHONE");
            entity.Property(e => e.PmQualId).HasColumnName("PM_QUAL_ID");
            entity.Property(e => e.PmRelationType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PM_RELATION_TYPE");
            entity.Property(e => e.PmSchId).HasColumnName("PM_SCH_ID");
            entity.Property(e => e.PmState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_STATE");
            entity.Property(e => e.PmStateId).HasColumnName("PM_STATE_ID");
            entity.Property(e => e.PmStuGuid).HasColumnName("PM_STU_GUID");
            entity.Property(e => e.PmZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PM_ZIPCODE");
        });

        modelBuilder.Entity<PaymentModeMaster>(entity =>
        {
            entity.HasKey(e => e.PaymentModeId);

            entity.ToTable("PaymentModeMaster");

            entity.Property(e => e.PaymentModeId).HasColumnName("PAYMENT_MODE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.PaymentModeCmpId).HasColumnName("PAYMENT_MODE_CMP_ID");
            entity.Property(e => e.PaymentModeDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE_DESC");
            entity.Property(e => e.PaymentModeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MODE_NAME");
            entity.Property(e => e.PaymentModeSchId).HasColumnName("PAYMENT_MODE_SCH_ID");
        });

        modelBuilder.Entity<Privilege>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Privileg__3214EC075161B45C");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Privilege1)
                .HasMaxLength(100)
                .HasColumnName("Privilege");
        });

        modelBuilder.Entity<ProfessionMaster>(entity =>
        {
            entity.HasKey(e => e.ProfId);

            entity.ToTable("ProfessionMaster");

            entity.Property(e => e.ProfId).HasColumnName("PROF_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.ProfName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROF_NAME");
        });

        modelBuilder.Entity<PublisherMaster>(entity =>
        {
            entity.HasKey(e => e.PublisherId);

            entity.ToTable("PublisherMaster");

            entity.Property(e => e.PublisherId).HasColumnName("PUBLISHER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.PublisherAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_ADDRESS");
            entity.Property(e => e.PublisherCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_CITY");
            entity.Property(e => e.PublisherCityId).HasColumnName("PUBLISHER_CITY_ID");
            entity.Property(e => e.PublisherCmpId).HasColumnName("PUBLISHER_CMP_ID");
            entity.Property(e => e.PublisherCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_COUNTRY");
            entity.Property(e => e.PublisherDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_DESCRIPTION");
            entity.Property(e => e.PublisherEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_EMAIL");
            entity.Property(e => e.PublisherIsActive).HasColumnName("PUBLISHER_IS_ACTIVE");
            entity.Property(e => e.PublisherMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_MOBILE");
            entity.Property(e => e.PublisherName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_NAME");
            entity.Property(e => e.PublisherPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_PHONE");
            entity.Property(e => e.PublisherSchId).HasColumnName("PUBLISHER_SCH_ID");
            entity.Property(e => e.PublisherState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_STATE");
            entity.Property(e => e.PublisherStateId).HasColumnName("PUBLISHER_STATE_ID");
            entity.Property(e => e.PublisherZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHER_ZIPCODE");
        });

        modelBuilder.Entity<QualificationMaster>(entity =>
        {
            entity.HasKey(e => e.QualId);

            entity.ToTable("QualificationMaster");

            entity.Property(e => e.QualId).HasColumnName("QUAL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.QualName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("QUAL_NAME");
        });

        modelBuilder.Entity<RegistrationMaster>(entity =>
        {
            entity.HasKey(e => e.RegId);

            entity.ToTable("RegistrationMaster");

            entity.Property(e => e.RegId).HasColumnName("REG_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RegAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("REG_ADDRESS");
            entity.Property(e => e.RegAge)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REG_AGE");
            entity.Property(e => e.RegAgeInWords)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_AGE_IN_WORDS");
            entity.Property(e => e.RegBirthCertificate).HasColumnName("REG_BIRTH_CERTIFICATE");
            entity.Property(e => e.RegBloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_BLOOD_GROUP");
            entity.Property(e => e.RegBloodGroupId).HasColumnName("REG_BLOOD_GROUP_ID");
            entity.Property(e => e.RegCatId).HasColumnName("REG_CAT_ID");
            entity.Property(e => e.RegCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_CITY");
            entity.Property(e => e.RegCityId).HasColumnName("REG_CITY_ID");
            entity.Property(e => e.RegCmId).HasColumnName("REG_CM_ID");
            entity.Property(e => e.RegCmpId).HasColumnName("REG_CMP_ID");
            entity.Property(e => e.RegContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_CONTACT_NUMBER");
            entity.Property(e => e.RegDate)
                .HasColumnType("datetime")
                .HasColumnName("REG_DATE");
            entity.Property(e => e.RegDob)
                .HasColumnType("datetime")
                .HasColumnName("REG_DOB");
            entity.Property(e => e.RegEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REG_EMAIL");
            entity.Property(e => e.RegFatherDesignation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_FATHER_DESIGNATION");
            entity.Property(e => e.RegFatherDob)
                .HasColumnType("datetime")
                .HasColumnName("REG_FATHER_DOB");
            entity.Property(e => e.RegFatherFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_FATHER_FIRST_NAME");
            entity.Property(e => e.RegFatherIncome)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REG_FATHER_INCOME");
            entity.Property(e => e.RegFatherLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_FATHER_LAST_NAME");
            entity.Property(e => e.RegFatherOccupation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_FATHER_OCCUPATION");
            entity.Property(e => e.RegFatherQualiId).HasColumnName("REG_FATHER_QUALI_ID");
            entity.Property(e => e.RegFees)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REG_FEES");
            entity.Property(e => e.RegFeesPaid).HasColumnName("REG_FEES_PAID");
            entity.Property(e => e.RegFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_FIRST_NAME");
            entity.Property(e => e.RegGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REG_GENDER");
            entity.Property(e => e.RegIsActive).HasColumnName("REG_IS_ACTIVE");
            entity.Property(e => e.RegIsAdmConfirmed).HasColumnName("REG_IS_ADM_CONFIRMED");
            entity.Property(e => e.RegLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_LAST_NAME");
            entity.Property(e => e.RegMotherDesignation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_MOTHER_DESIGNATION");
            entity.Property(e => e.RegMotherDob)
                .HasColumnType("datetime")
                .HasColumnName("REG_MOTHER_DOB");
            entity.Property(e => e.RegMotherFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_MOTHER_FIRST_NAME");
            entity.Property(e => e.RegMotherIncome)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REG_MOTHER_INCOME");
            entity.Property(e => e.RegMotherLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_MOTHER_LAST_NAME");
            entity.Property(e => e.RegMotherOccupation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_MOTHER_OCCUPATION");
            entity.Property(e => e.RegMotherQualiId).HasColumnName("REG_MOTHER_QUALI_ID");
            entity.Property(e => e.RegNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_NUMBER");
            entity.Property(e => e.RegOtherCertificate).HasColumnName("REG_OTHER_CERTIFICATE");
            entity.Property(e => e.RegOtherDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REG_OTHER_DESCRIPTION");
            entity.Property(e => e.RegPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_PHONE");
            entity.Property(e => e.RegReligion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_RELIGION");
            entity.Property(e => e.RegReligionId).HasColumnName("REG_RELIGION_ID");
            entity.Property(e => e.RegReportCard).HasColumnName("REG_REPORT_CARD");
            entity.Property(e => e.RegSchId).HasColumnName("REG_SCH_ID");
            entity.Property(e => e.RegSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_SESSION");
            entity.Property(e => e.RegSiblingCmId).HasColumnName("REG_SIBLING_CM_ID");
            entity.Property(e => e.RegSiblingIfAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_SIBLING_IF_ANY");
            entity.Property(e => e.RegState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG_STATE");
            entity.Property(e => e.RegStateId).HasColumnName("REG_STATE_ID");
            entity.Property(e => e.RegStuGuid).HasColumnName("REG_STU_GUID");
            entity.Property(e => e.RegTransferCertificate).HasColumnName("REG_TRANSFER_CERTIFICATE");

            entity.HasOne(d => d.RegCat).WithMany(p => p.RegistrationMasters)
                .HasForeignKey(d => d.RegCatId)
                .HasConstraintName("FK_RegistrationMaster_CategoryMaster");

            entity.HasOne(d => d.RegCm).WithMany(p => p.RegistrationMasters)
                .HasForeignKey(d => d.RegCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistrationMaster_ClassMaster");
        });

        modelBuilder.Entity<ReligionMaster>(entity =>
        {
            entity.HasKey(e => e.ReligionId);

            entity.ToTable("ReligionMaster");

            entity.Property(e => e.ReligionId).HasColumnName("RELIGION_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RegCmpId).HasColumnName("REG_CMP_ID");
            entity.Property(e => e.RegSchId).HasColumnName("REG_SCH_ID");
            entity.Property(e => e.ReligionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RELIGION_NAME");
        });

        modelBuilder.Entity<RoleMaster>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("RoleMaster");

            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RoleCmpId).HasColumnName("ROLE_CMP_ID");
            entity.Property(e => e.RoleDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ROLE_DESCRIPTION");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ROLE_NAME");
            entity.Property(e => e.RoleSchId).HasColumnName("ROLE_SCH_ID");
        });

        modelBuilder.Entity<RolePrivilege>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolePriv__3214EC07A4507807");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.Privilege).WithMany(p => p.RolePrivileges)
                .HasForeignKey(d => d.PrivilegeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolePrivi__Privi__7073AF84");

            entity.HasOne(d => d.Role).WithMany(p => p.RolePrivileges)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePrivileges_RoleMaster");
        });

        modelBuilder.Entity<RouteDetail>(entity =>
        {
            entity.Property(e => e.RouteDetailId).HasColumnName("ROUTE_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RouteDetailCleanerId).HasColumnName("ROUTE_DETAIL_CLEANER_ID");
            entity.Property(e => e.RouteDetailDriverId).HasColumnName("ROUTE_DETAIL_DRIVER_ID");
            entity.Property(e => e.RouteDetailRouteId).HasColumnName("ROUTE_DETAIL_ROUTE_ID");
            entity.Property(e => e.RouteDetailVehicleId).HasColumnName("ROUTE_DETAIL_VEHICLE_ID");
            entity.Property(e => e.RouteDetailsCmpId).HasColumnName("ROUTE_DETAILS_CMP_ID");
            entity.Property(e => e.RouteDetailsSchId).HasColumnName("ROUTE_DETAILS_SCH_ID");

            entity.HasOne(d => d.RouteDetailCleaner).WithMany(p => p.RouteDetails)
                .HasForeignKey(d => d.RouteDetailCleanerId)
                .HasConstraintName("FK_RouteDetails_CleanerMaster");

            entity.HasOne(d => d.RouteDetailRoute).WithMany(p => p.RouteDetails)
                .HasForeignKey(d => d.RouteDetailRouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteDetails_RouteMaster");

            entity.HasOne(d => d.RouteDetailVehicle).WithMany(p => p.RouteDetails)
                .HasForeignKey(d => d.RouteDetailVehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteDetails_VehicleDetails");
        });

        modelBuilder.Entity<RouteMaster>(entity =>
        {
            entity.HasKey(e => e.RouteId);

            entity.ToTable("RouteMaster");

            entity.Property(e => e.RouteId).HasColumnName("ROUTE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RouteApplicableClasses)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ROUTE_APPLICABLE_CLASSES");
            entity.Property(e => e.RouteCmpId).HasColumnName("ROUTE_CMP_ID");
            entity.Property(e => e.RouteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROUTE_CODE");
            entity.Property(e => e.RouteEndLocationId).HasColumnName("ROUTE_END_LOCATION_ID");
            entity.Property(e => e.RouteName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ROUTE_NAME");
            entity.Property(e => e.RouteSchId).HasColumnName("ROUTE_SCH_ID");
            entity.Property(e => e.RouteSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROUTE_SESSION");
            entity.Property(e => e.RouteStartLocationId).HasColumnName("ROUTE_START_LOCATION_ID");

            entity.HasOne(d => d.RouteEndLocation).WithMany(p => p.RouteMasterRouteEndLocations)
                .HasForeignKey(d => d.RouteEndLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteMaster_RouteEndLocation");

            entity.HasOne(d => d.RouteStartLocation).WithMany(p => p.RouteMasterRouteStartLocations)
                .HasForeignKey(d => d.RouteStartLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteMaster_RouteStartLoation");
        });

        modelBuilder.Entity<RouteStopDetail>(entity =>
        {
            entity.HasKey(e => e.RouteStopId);

            entity.Property(e => e.RouteStopId).HasColumnName("ROUTE_STOP_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RouteStopCmpId).HasColumnName("ROUTE_STOP_CMP_ID");
            entity.Property(e => e.RouteStopDropTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROUTE_STOP_DROP_TIME");
            entity.Property(e => e.RouteStopLocationId).HasColumnName("ROUTE_STOP_LOCATION_ID");
            entity.Property(e => e.RouteStopNumber).HasColumnName("ROUTE_STOP_NUMBER");
            entity.Property(e => e.RouteStopOneWayMonthlyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ROUTE_STOP_ONE_WAY_MONTHLY_FEE");
            entity.Property(e => e.RouteStopPickupTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROUTE_STOP_PICKUP_TIME");
            entity.Property(e => e.RouteStopRouteDetailId).HasColumnName("ROUTE_STOP_ROUTE_DETAIL_ID");
            entity.Property(e => e.RouteStopRouteId).HasColumnName("ROUTE_STOP_ROUTE_ID");
            entity.Property(e => e.RouteStopSchId).HasColumnName("ROUTE_STOP_SCH_ID");
            entity.Property(e => e.RouteStopTwoWayMonthlyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ROUTE_STOP_TWO_WAY_MONTHLY_FEE");

            entity.HasOne(d => d.RouteStopLocation).WithMany(p => p.RouteStopDetails)
                .HasForeignKey(d => d.RouteStopLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteStopDetails_RouteStopLoation");

            entity.HasOne(d => d.RouteStopRouteDetail).WithMany(p => p.RouteStopDetails)
                .HasForeignKey(d => d.RouteStopRouteDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteStopDetails_RouteDetails");

            entity.HasOne(d => d.RouteStopRoute).WithMany(p => p.RouteStopDetails)
                .HasForeignKey(d => d.RouteStopRouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RouteStopDetails_RouteMaster");
        });

        modelBuilder.Entity<SalaryDesigGradeDetail>(entity =>
        {
            entity.HasKey(e => e.SaldgdId);

            entity.Property(e => e.SaldgdId).HasColumnName("SALDGD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SaldgdCmpId).HasColumnName("SALDGD_CMP_ID");
            entity.Property(e => e.SaldgdDesgradeId).HasColumnName("SALDGD_DESGRADE_ID");
            entity.Property(e => e.SaldgdIsActive).HasColumnName("SALDGD_IS_ACTIVE");
            entity.Property(e => e.SaldgdSalhmId).HasColumnName("SALDGD_SALHM_ID");
            entity.Property(e => e.SaldgdSchId).HasColumnName("SALDGD_SCH_ID");
            entity.Property(e => e.SaldgdSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SALDGD_SESSION");
            entity.Property(e => e.SaldgdValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALDGD_VALUE");

            entity.HasOne(d => d.SaldgdDesgrade).WithMany(p => p.SalaryDesigGradeDetails)
                .HasForeignKey(d => d.SaldgdDesgradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryDesigGradeDetails_DesigGradeDetails");

            entity.HasOne(d => d.SaldgdSalhm).WithMany(p => p.SalaryDesigGradeDetails)
                .HasForeignKey(d => d.SaldgdSalhmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryDesigGradeDetails_SalaryHeadMaster");
        });

        modelBuilder.Entity<SalaryDesigGradeDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.SaldgdhId);

            entity.ToTable("SalaryDesigGradeDetailsHistory");

            entity.Property(e => e.SaldgdhId).HasColumnName("SALDGDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SaldgdhCmpId).HasColumnName("SALDGDH_CMP_ID");
            entity.Property(e => e.SaldgdhDesgradeId).HasColumnName("SALDGDH_DESGRADE_ID");
            entity.Property(e => e.SaldgdhSalhmId).HasColumnName("SALDGDH_SALHM_ID");
            entity.Property(e => e.SaldgdhSchId).HasColumnName("SALDGDH_SCH_ID");
            entity.Property(e => e.SaldgdhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SALDGDH_SESSION");
            entity.Property(e => e.SaldgdhValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALDGDH_VALUE");

            entity.HasOne(d => d.SaldgdhDesgrade).WithMany(p => p.SalaryDesigGradeDetailsHistories)
                .HasForeignKey(d => d.SaldgdhDesgradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryDesigGradeDetailsHistory_DesigGradeDetails");

            entity.HasOne(d => d.SaldgdhSalhm).WithMany(p => p.SalaryDesigGradeDetailsHistories)
                .HasForeignKey(d => d.SaldgdhSalhmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryDesigGradeDetailsHistory_SalaryHeadMaster");
        });

        modelBuilder.Entity<SalaryHeadMaster>(entity =>
        {
            entity.HasKey(e => e.SalhmId);

            entity.ToTable("SalaryHeadMaster");

            entity.Property(e => e.SalhmId).HasColumnName("SALHM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SalhmCmpId).HasColumnName("SALHM_CMP_ID");
            entity.Property(e => e.SalhmCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SALHM_CODE");
            entity.Property(e => e.SalhmDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SALHM_DESCRIPTION");
            entity.Property(e => e.SalhmIsDeduction).HasColumnName("SALHM_IS_DEDUCTION");
            entity.Property(e => e.SalhmIsReadonly).HasColumnName("SALHM_IS_READONLY");
            entity.Property(e => e.SalhmSchId).HasColumnName("SALHM_SCH_ID");
            entity.Property(e => e.SalhmType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SALHM_TYPE");
        });

        modelBuilder.Entity<ScholasticMaster>(entity =>
        {
            entity.HasKey(e => e.ScholasticId);

            entity.ToTable("ScholasticMaster");

            entity.Property(e => e.ScholasticId).HasColumnName("SCHOLASTIC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.ScholasticCmpId).HasColumnName("SCHOLASTIC_CMP_ID");
            entity.Property(e => e.ScholasticDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SCHOLASTIC_DESC");
            entity.Property(e => e.ScholasticName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SCHOLASTIC_NAME");
            entity.Property(e => e.ScholasticParentId).HasColumnName("SCHOLASTIC_PARENT_ID");
            entity.Property(e => e.ScholasticSchId).HasColumnName("SCHOLASTIC_SCH_ID");
            entity.Property(e => e.ScholasticSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCHOLASTIC_SESSION");
            entity.Property(e => e.ScholasticSubjectId).HasColumnName("SCHOLASTIC_SUBJECT_ID");
        });

        modelBuilder.Entity<ScholasticUnitDetail>(entity =>
        {
            entity.HasKey(e => new { e.ScohudScholasticId, e.ScohudUnitId });

            entity.ToTable("ScholasticUnitDetail");

            entity.Property(e => e.ScohudScholasticId).HasColumnName("SCOHUD_SCHOLASTIC_ID");
            entity.Property(e => e.ScohudUnitId).HasColumnName("SCOHUD_UNIT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.ScohudScholastic).WithMany(p => p.ScholasticUnitDetails)
                .HasForeignKey(d => d.ScohudScholasticId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScholasticUnitDetail_ScholasticMaster");

            entity.HasOne(d => d.ScohudUnit).WithMany(p => p.ScholasticUnitDetails)
                .HasForeignKey(d => d.ScohudUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScholasticUnitDetail_ExamUnitMaster");
        });

        modelBuilder.Entity<SchoolContactMaster>(entity =>
        {
            entity.HasKey(e => e.SconmId);

            entity.ToTable("SchoolContactMaster");

            entity.Property(e => e.SconmId).HasColumnName("SCONM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SconmAddressLine1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_ADDRESS_LINE1");
            entity.Property(e => e.SconmAddressLine2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_ADDRESS_LINE2");
            entity.Property(e => e.SconmCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_CITY");
            entity.Property(e => e.SconmCityId).HasColumnName("SCONM_CITY_ID");
            entity.Property(e => e.SconmCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_COUNTRY");
            entity.Property(e => e.SconmEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_EMAIL");
            entity.Property(e => e.SconmFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_FIRST_NAME");
            entity.Property(e => e.SconmLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_LAST_NAME");
            entity.Property(e => e.SconmMobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_MOBILE_PHONE");
            entity.Property(e => e.SconmPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_PHONE");
            entity.Property(e => e.SconmSchId).HasColumnName("SCONM_SCH_ID");
            entity.Property(e => e.SconmState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCONM_STATE");
            entity.Property(e => e.SconmStateId).HasColumnName("SCONM_STATE_ID");
        });

        modelBuilder.Entity<SchoolMaster>(entity =>
        {
            entity.HasKey(e => e.SchId);

            entity.ToTable("SchoolMaster");

            entity.Property(e => e.SchId).HasColumnName("SCH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SchAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SCH_ADDRESS");
            entity.Property(e => e.SchBankAccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SCH_BANK_ACCOUNT_NUMBER");
            entity.Property(e => e.SchBankAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SCH_BANK_ADDRESS");
            entity.Property(e => e.SchCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_CITY");
            entity.Property(e => e.SchCityId).HasColumnName("SCH_CITY_ID");
            entity.Property(e => e.SchCmpId).HasColumnName("SCH_CMP_ID");
            entity.Property(e => e.SchCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_COUNTRY");
            entity.Property(e => e.SchDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SCH_DESCRIPTION");
            entity.Property(e => e.SchEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_EMAIL");
            entity.Property(e => e.SchEstablishmentYear)
                .HasColumnType("datetime")
                .HasColumnName("SCH_ESTABLISHMENT_YEAR");
            entity.Property(e => e.SchJurisdictionArea)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SCH_JURISDICTION_AREA");
            entity.Property(e => e.SchMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_MOBILE");
            entity.Property(e => e.SchName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_NAME");
            entity.Property(e => e.SchPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_PHONE");
            entity.Property(e => e.SchState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_STATE");
            entity.Property(e => e.SchStateId).HasColumnName("SCH_STATE_ID");
            entity.Property(e => e.SchZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCH_ZIPCODE");
        });

        modelBuilder.Entity<SectionMaster>(entity =>
        {
            entity.HasKey(e => e.SmId);

            entity.ToTable("SectionMaster");

            entity.Property(e => e.SmId).HasColumnName("SM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SmCmpId).HasColumnName("SM_CMP_ID");
            entity.Property(e => e.SmName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SM_NAME");
            entity.Property(e => e.SmSchId).HasColumnName("SM_SCH_ID");
        });

        modelBuilder.Entity<SessionMaster>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.ToTable("SessionMaster");

            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SessionCmpId).HasColumnName("SESSION_CMP_ID");
            entity.Property(e => e.SessionDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SESSION_DESCRIPTION");
            entity.Property(e => e.SessionSchId).HasColumnName("SESSION_SCH_ID");
            entity.Property(e => e.SessionValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SESSION_VALUE");
        });

        modelBuilder.Entity<Smstask>(entity =>
        {
            entity.HasKey(e => e.StsId);

            entity.ToTable("SMSTask");

            entity.Property(e => e.StsId).HasColumnName("STS_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StsCmpId).HasColumnName("STS_CMP_ID");
            entity.Property(e => e.StsDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STS_DESCRIPTION");
            entity.Property(e => e.StsIsReadonly).HasColumnName("STS_IS_READONLY");
            entity.Property(e => e.StsLastRunDate)
                .HasColumnType("datetime")
                .HasColumnName("STS_LAST_RUN_DATE");
            entity.Property(e => e.StsLastRunStatusId).HasColumnName("STS_LAST_RUN_STATUS_ID");
            entity.Property(e => e.StsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STS_NAME");
            entity.Property(e => e.StsNotificationReceieverId).HasColumnName("STS_NOTIFICATION_RECEIEVER_ID");
            entity.Property(e => e.StsNotificationSendEmail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STS_NOTIFICATION_SEND_EMAIL");
            entity.Property(e => e.StsNotificationSendSms)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STS_NOTIFICATION_SEND_SMS");
            entity.Property(e => e.StsRepeatSchedule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STS_REPEAT_SCHEDULE");
            entity.Property(e => e.StsSchId).HasColumnName("STS_SCH_ID");
            entity.Property(e => e.StsStatusId).HasColumnName("STS_STATUS_ID");

            entity.HasOne(d => d.StsNotificationReceiever).WithMany(p => p.Smstasks)
                .HasForeignKey(d => d.StsNotificationReceieverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSTask_NotificationReceiver");
        });

        modelBuilder.Entity<SmstaskHistory>(entity =>
        {
            entity.HasKey(e => e.StshId);

            entity.ToTable("SMSTaskHistory");

            entity.Property(e => e.StshId).HasColumnName("STSH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StshCmpId).HasColumnName("STSH_CMP_ID");
            entity.Property(e => e.StshDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STSH_DESCRIPTION");
            entity.Property(e => e.StshEmail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STSH_EMAIL");
            entity.Property(e => e.StshNotificationReceiver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STSH_NOTIFICATION_RECEIVER");
            entity.Property(e => e.StshNotificationReceiverId).HasColumnName("STSH_NOTIFICATION_RECEIVER_ID");
            entity.Property(e => e.StshParentId).HasColumnName("STSH_PARENT_ID");
            entity.Property(e => e.StshPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STSH_PHONE");
            entity.Property(e => e.StshSchId).HasColumnName("STSH_SCH_ID");
            entity.Property(e => e.StshSendType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STSH_SEND_TYPE");
            entity.Property(e => e.StshSentDate)
                .HasColumnType("datetime")
                .HasColumnName("STSH_SENT_DATE");
            entity.Property(e => e.StshStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STSH_STATUS");
            entity.Property(e => e.StshStuGuid).HasColumnName("STSH_STU_GUID");
            entity.Property(e => e.StshTaskId).HasColumnName("STSH_TASK_ID");
            entity.Property(e => e.StshTeacherId).HasColumnName("STSH_TEACHER_ID");
        });

        modelBuilder.Entity<SmstaskSchedule>(entity =>
        {
            entity.HasKey(e => e.StsScheduleId);

            entity.ToTable("SMSTaskSchedule");

            entity.Property(e => e.StsScheduleId).HasColumnName("STS_SCHEDULE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StsCmpId).HasColumnName("STS_CMP_ID");
            entity.Property(e => e.StsSchId).HasColumnName("STS_SCH_ID");
            entity.Property(e => e.StsScheduleFriday).HasColumnName("STS_SCHEDULE_FRIDAY");
            entity.Property(e => e.StsScheduleMonday).HasColumnName("STS_SCHEDULE_MONDAY");
            entity.Property(e => e.StsScheduleSaturday).HasColumnName("STS_SCHEDULE_SATURDAY");
            entity.Property(e => e.StsScheduleStarttime)
                .HasColumnType("datetime")
                .HasColumnName("STS_SCHEDULE_STARTTIME");
            entity.Property(e => e.StsScheduleSunday).HasColumnName("STS_SCHEDULE_SUNDAY");
            entity.Property(e => e.StsScheduleTaskId).HasColumnName("STS_SCHEDULE_TASK_ID");
            entity.Property(e => e.StsScheduleThrusday).HasColumnName("STS_SCHEDULE_THRUSDAY");
            entity.Property(e => e.StsScheduleTuesday).HasColumnName("STS_SCHEDULE_TUESDAY");
            entity.Property(e => e.StsScheduleWednesday).HasColumnName("STS_SCHEDULE_WEDNESDAY");

            entity.HasOne(d => d.StsScheduleTask).WithMany(p => p.SmstaskSchedules)
                .HasForeignKey(d => d.StsScheduleTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSTaskSchedule_SMSTasks");
        });

        modelBuilder.Entity<SmstaskSmtpDetail>(entity =>
        {
            entity.HasKey(e => e.StssmtpDetailId);

            entity.ToTable("SMSTaskSmtpDetails");

            entity.Property(e => e.StssmtpDetailId).HasColumnName("STSSMTP_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StssmtpDetailBodyText)
                .HasMaxLength(6000)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_BODY_TEXT");
            entity.Property(e => e.StssmtpDetailCmpId).HasColumnName("STSSMTP_DETAIL_CMP_ID");
            entity.Property(e => e.StssmtpDetailFromAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_FROM_ADDRESS");
            entity.Property(e => e.StssmtpDetailGateway)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_GATEWAY");
            entity.Property(e => e.StssmtpDetailMessageBody)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_MESSAGE_BODY");
            entity.Property(e => e.StssmtpDetailMessageSubject)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_MESSAGE_SUBJECT");
            entity.Property(e => e.StssmtpDetailPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_PASSWORD");
            entity.Property(e => e.StssmtpDetailSchId).HasColumnName("STSSMTP_DETAIL_SCH_ID");
            entity.Property(e => e.StssmtpDetailSubject)
                .HasMaxLength(6000)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_SUBJECT");
            entity.Property(e => e.StssmtpDetailUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STSSMTP_DETAIL_USERNAME");
            entity.Property(e => e.StssmtpTaskId).HasColumnName("STSSMTP_TASK_ID");

            entity.HasOne(d => d.StssmtpTask).WithMany(p => p.SmstaskSmtpDetails)
                .HasForeignKey(d => d.StssmtpTaskId)
                .HasConstraintName("FK_SMSTaskSmtpDetails_SMSTask");
        });

        modelBuilder.Entity<SmstaskStatusMaster>(entity =>
        {
            entity.HasKey(e => e.StssmId);

            entity.ToTable("SMSTaskStatusMaster");

            entity.Property(e => e.StssmId).HasColumnName("STSSM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StssmCmpId).HasColumnName("STSSM_CMP_ID");
            entity.Property(e => e.StssmIsActive).HasColumnName("STSSM_IS_ACTIVE");
            entity.Property(e => e.StssmName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STSSM_NAME");
            entity.Property(e => e.StssmSchId).HasColumnName("STSSM_SCH_ID");
        });

        modelBuilder.Entity<SmtpDetail>(entity =>
        {
            entity.Property(e => e.SmtpDetailId).HasColumnName("SMTP_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SmtpDetailBodyText)
                .HasMaxLength(6000)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_BODY_TEXT");
            entity.Property(e => e.SmtpDetailCmpId).HasColumnName("SMTP_DETAIL_CMP_ID");
            entity.Property(e => e.SmtpDetailEmailType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_EMAIL_TYPE");
            entity.Property(e => e.SmtpDetailFromAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_FROM_ADDRESS");
            entity.Property(e => e.SmtpDetailGateway)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_GATEWAY");
            entity.Property(e => e.SmtpDetailPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_PASSWORD");
            entity.Property(e => e.SmtpDetailSchId).HasColumnName("SMTP_DETAIL_SCH_ID");
            entity.Property(e => e.SmtpDetailSubject)
                .HasMaxLength(6000)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_SUBJECT");
            entity.Property(e => e.SmtpDetailUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTP_DETAIL_USERNAME");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("StateMaster");

            entity.Property(e => e.StateId).HasColumnName("STATE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StateName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATE_NAME");
        });

        modelBuilder.Entity<StudentAchievement>(entity =>
        {
            entity.HasKey(e => e.StudAchId);

            entity.Property(e => e.StudAchId).HasColumnName("STUD_ACH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StudAchDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STUD_ACH_DESCRIPTION");
            entity.Property(e => e.StudAchSchool)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUD_ACH_SCHOOL");
            entity.Property(e => e.StudAchSession)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STUD_ACH_SESSION");
            entity.Property(e => e.StudCmpId).HasColumnName("STUD_CMP_ID");
            entity.Property(e => e.StudSchId).HasColumnName("STUD_SCH_ID");
            entity.Property(e => e.StudStuGuid).HasColumnName("STUD_STU_GUID");
        });

        modelBuilder.Entity<StudentAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.StuAttendId);

            entity.Property(e => e.StuAttendId).HasColumnName("STU_ATTEND_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StuAttendCmId).HasColumnName("STU_ATTEND_CM_ID");
            entity.Property(e => e.StuAttendCmpId).HasColumnName("STU_ATTEND_CMP_ID");
            entity.Property(e => e.StuAttendDate)
                .HasColumnType("datetime")
                .HasColumnName("STU_ATTEND_DATE");
            entity.Property(e => e.StuAttendGuid).HasColumnName("STU_ATTEND_GUID");
            entity.Property(e => e.StuAttendMonth).HasColumnName("STU_ATTEND_MONTH");
            entity.Property(e => e.StuAttendReasonId).HasColumnName("STU_ATTEND_REASON_ID");
            entity.Property(e => e.StuAttendSchId).HasColumnName("STU_ATTEND_SCH_ID");
            entity.Property(e => e.StuAttendSecId).HasColumnName("STU_ATTEND_SEC_ID");
            entity.Property(e => e.StuAttendStatus).HasColumnName("STU_ATTEND_STATUS");
            entity.Property(e => e.StuAttendTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_ATTEND_TIME");
            entity.Property(e => e.StuAttendYear).HasColumnName("STU_ATTEND_YEAR");

            entity.HasOne(d => d.StuAttendCm).WithMany(p => p.StudentAttendanceDetails)
                .HasForeignKey(d => d.StuAttendCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendanceDetails_ClassMaster");

            entity.HasOne(d => d.StuAttend).WithMany(p => p.StudentAttendanceDetails)
                .HasForeignKey(d => d.StuAttendGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendanceDetails_StudentMaster");

            entity.HasOne(d => d.StuAttendReason).WithMany(p => p.StudentAttendanceDetails)
                .HasForeignKey(d => d.StuAttendReasonId)
                .HasConstraintName("FK_StudentAttendanceDetails_ReasonMaster");
        });

        modelBuilder.Entity<StudentAttendanceDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.StuAttendhId);

            entity.ToTable("StudentAttendanceDetailsHistory");

            entity.Property(e => e.StuAttendhId).HasColumnName("STU_ATTENDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StuAttendhCmId).HasColumnName("STU_ATTENDH_CM_ID");
            entity.Property(e => e.StuAttendhCmpId).HasColumnName("STU_ATTENDH_CMP_ID");
            entity.Property(e => e.StuAttendhDate)
                .HasColumnType("datetime")
                .HasColumnName("STU_ATTENDH_DATE");
            entity.Property(e => e.StuAttendhGuid).HasColumnName("STU_ATTENDH_GUID");
            entity.Property(e => e.StuAttendhMonth).HasColumnName("STU_ATTENDH_MONTH");
            entity.Property(e => e.StuAttendhReasonId).HasColumnName("STU_ATTENDH_REASON_ID");
            entity.Property(e => e.StuAttendhSchId).HasColumnName("STU_ATTENDH_SCH_ID");
            entity.Property(e => e.StuAttendhSecId).HasColumnName("STU_ATTENDH_SEC_ID");
            entity.Property(e => e.StuAttendhStatus).HasColumnName("STU_ATTENDH_STATUS");
            entity.Property(e => e.StuAttendhTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_ATTENDH_TIME");
            entity.Property(e => e.StuAttendhYear).HasColumnName("STU_ATTENDH_YEAR");

            entity.HasOne(d => d.StuAttendhCm).WithMany(p => p.StudentAttendanceDetailsHistories)
                .HasForeignKey(d => d.StuAttendhCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendanceDetailsHistory_ClassMaster");

            entity.HasOne(d => d.StuAttendh).WithMany(p => p.StudentAttendanceDetailsHistories)
                .HasForeignKey(d => d.StuAttendhGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendanceDetailsHistory_StudentMaster");

            entity.HasOne(d => d.StuAttendhReason).WithMany(p => p.StudentAttendanceDetailsHistories)
                .HasForeignKey(d => d.StuAttendhReasonId)
                .HasConstraintName("FK_StudentAttendanceDetailsHistory_ReasonMaster");
        });

        modelBuilder.Entity<StudentCommentDetail>(entity =>
        {
            entity.HasKey(e => e.StucommentId);

            entity.Property(e => e.StucommentId).HasColumnName("STUCOMMENT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StucommentCmId).HasColumnName("STUCOMMENT_CM_ID");
            entity.Property(e => e.StucommentCmpId).HasColumnName("STUCOMMENT_CMP_ID");
            entity.Property(e => e.StucommentFinalDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_FINAL_DESC");
            entity.Property(e => e.StucommentQ1Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_Q1_DESC");
            entity.Property(e => e.StucommentQ2Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_Q2_DESC");
            entity.Property(e => e.StucommentQ3Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_Q3_DESC");
            entity.Property(e => e.StucommentSa1Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_SA1_DESC");
            entity.Property(e => e.StucommentSa2Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_SA2_DESC");
            entity.Property(e => e.StucommentSchId).HasColumnName("STUCOMMENT_SCH_ID");
            entity.Property(e => e.StucommentSecId).HasColumnName("STUCOMMENT_SEC_ID");
            entity.Property(e => e.StucommentSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENT_SESSION");
            entity.Property(e => e.StucommentStuGuid).HasColumnName("STUCOMMENT_STU_GUID");
        });

        modelBuilder.Entity<StudentCommentDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.StucommenthId);

            entity.ToTable("StudentCommentDetailsHistory");

            entity.Property(e => e.StucommenthId).HasColumnName("STUCOMMENTH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StucommenthCmId).HasColumnName("STUCOMMENTH_CM_ID");
            entity.Property(e => e.StucommenthCmpId).HasColumnName("STUCOMMENTH_CMP_ID");
            entity.Property(e => e.StucommenthFinalDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_FINAL_DESC");
            entity.Property(e => e.StucommenthQ1Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_Q1_DESC");
            entity.Property(e => e.StucommenthQ2Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_Q2_DESC");
            entity.Property(e => e.StucommenthQ3Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_Q3_DESC");
            entity.Property(e => e.StucommenthSa1Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_SA1_DESC");
            entity.Property(e => e.StucommenthSa2Desc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_SA2_DESC");
            entity.Property(e => e.StucommenthSchId).HasColumnName("STUCOMMENTH_SCH_ID");
            entity.Property(e => e.StucommenthSecId).HasColumnName("STUCOMMENTH_SEC_ID");
            entity.Property(e => e.StucommenthSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUCOMMENTH_SESSION");
            entity.Property(e => e.StucommenthStuGuid).HasColumnName("STUCOMMENTH_STU_GUID");
            entity.Property(e => e.StucommenthStucommentId).HasColumnName("STUCOMMENTH_STUCOMMENT_ID");
        });

        modelBuilder.Entity<StudentFeeDetail>(entity =>
        {
            entity.HasKey(e => e.StudFeeId).HasName("PK_StudentFees");

            entity.Property(e => e.StudFeeId).HasColumnName("STUD_FEE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StudFeeAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUD_FEE_AMOUNT");
            entity.Property(e => e.StudFeeCatId).HasColumnName("STUD_FEE_CAT_ID");
            entity.Property(e => e.StudFeeCmId).HasColumnName("STUD_FEE_CM_ID");
            entity.Property(e => e.StudFeeCmpId).HasColumnName("STUD_FEE_CMP_ID");
            entity.Property(e => e.StudFeeDate)
                .HasColumnType("datetime")
                .HasColumnName("STUD_FEE_DATE");
            entity.Property(e => e.StudFeeDueDate)
                .HasColumnType("datetime")
                .HasColumnName("STUD_FEE_DUE_DATE");
            entity.Property(e => e.StudFeeIsActive).HasColumnName("STUD_FEE_IS_ACTIVE");
            entity.Property(e => e.StudFeeMonth).HasColumnName("STUD_FEE_MONTH");
            entity.Property(e => e.StudFeePaid).HasColumnName("STUD_FEE_PAID");
            entity.Property(e => e.StudFeeReceiptNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUD_FEE_RECEIPT_NUMBER");
            entity.Property(e => e.StudFeeSchId).HasColumnName("STUD_FEE_SCH_ID");
            entity.Property(e => e.StudFeeSecId).HasColumnName("STUD_FEE_SEC_ID");
            entity.Property(e => e.StudFeeStuGuid).HasColumnName("STUD_FEE_STU_GUID");
            entity.Property(e => e.StudFeeTotalAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUD_FEE_TOTAL_AMOUNT");
            entity.Property(e => e.StudFeeYear).HasColumnName("STUD_FEE_YEAR");
            entity.Property(e => e.StudLateFeeAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUD_LATE_FEE_AMOUNT");
        });

        modelBuilder.Entity<StudentFeeDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.StudFeehId).HasName("PK_StudentFeesDetailHistory");

            entity.ToTable("StudentFeeDetailsHistory");

            entity.Property(e => e.StudFeehId).HasColumnName("STUD_FEEH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StudCmpId).HasColumnName("STUD_CMP_ID");
            entity.Property(e => e.StudFeehAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUD_FEEH_AMOUNT");
            entity.Property(e => e.StudFeehCatId).HasColumnName("STUD_FEEH_CAT_ID");
            entity.Property(e => e.StudFeehCmId).HasColumnName("STUD_FEEH_CM_ID");
            entity.Property(e => e.StudFeehDate)
                .HasColumnType("datetime")
                .HasColumnName("STUD_FEEH_DATE");
            entity.Property(e => e.StudFeehDueDate)
                .HasColumnType("datetime")
                .HasColumnName("STUD_FEEH_DUE_DATE");
            entity.Property(e => e.StudFeehIsActive).HasColumnName("STUD_FEEH_IS_ACTIVE");
            entity.Property(e => e.StudFeehMonth).HasColumnName("STUD_FEEH_MONTH");
            entity.Property(e => e.StudFeehReceiptNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUD_FEEH_RECEIPT_NUMBER");
            entity.Property(e => e.StudFeehStuGuid).HasColumnName("STUD_FEEH_STU_GUID");
            entity.Property(e => e.StudFeehTotalAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUD_FEEH_TOTAL_AMOUNT");
            entity.Property(e => e.StudFeehYear).HasColumnName("STUD_FEEH_YEAR");
            entity.Property(e => e.StudFeeshPaid).HasColumnName("STUD_FEESH_PAID");
            entity.Property(e => e.StudLateFeehAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUD_LATE_FEEH_AMOUNT");
            entity.Property(e => e.StudSchId).HasColumnName("STUD_SCH_ID");
            entity.Property(e => e.StudfeehSecId).HasColumnName("STUDFEEH_SEC_ID");
        });

        modelBuilder.Entity<StudentGradeDetail>(entity =>
        {
            entity.HasKey(e => e.StugradeId);

            entity.Property(e => e.StugradeId).HasColumnName("STUGRADE_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StugradeCmId).HasColumnName("STUGRADE_CM_ID");
            entity.Property(e => e.StugradeCmpId).HasColumnName("STUGRADE_CMP_ID");
            entity.Property(e => e.StugradeFa1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_FA1_GRADE");
            entity.Property(e => e.StugradeFa2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_FA2_GRADE");
            entity.Property(e => e.StugradeFa3Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_FA3_GRADE");
            entity.Property(e => e.StugradeFa4Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_FA4_GRADE");
            entity.Property(e => e.StugradeQ1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_Q1_GRADE");
            entity.Property(e => e.StugradeQ2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_Q2_GRADE");
            entity.Property(e => e.StugradeQ3Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_Q3_GRADE");
            entity.Property(e => e.StugradeSa1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_SA1_GRADE");
            entity.Property(e => e.StugradeSa2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_SA2_GRADE");
            entity.Property(e => e.StugradeSchId).HasColumnName("STUGRADE_SCH_ID");
            entity.Property(e => e.StugradeScholasticCatId).HasColumnName("STUGRADE_SCHOLASTIC_CAT_ID");
            entity.Property(e => e.StugradeSecId).HasColumnName("STUGRADE_SEC_ID");
            entity.Property(e => e.StugradeSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUGRADE_SESSION");
            entity.Property(e => e.StugradeStuGuid).HasColumnName("STUGRADE_STU_GUID");
        });

        modelBuilder.Entity<StudentGradeDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.StugradehId);

            entity.ToTable("StudentGradeDetailsHistory");

            entity.Property(e => e.StugradehId).HasColumnName("STUGRADEH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StugradehCmId).HasColumnName("STUGRADEH_CM_ID");
            entity.Property(e => e.StugradehCmpId).HasColumnName("STUGRADEH_CMP_ID");
            entity.Property(e => e.StugradehFa1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_FA1_GRADE");
            entity.Property(e => e.StugradehFa2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_FA2_GRADE");
            entity.Property(e => e.StugradehFa3Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_FA3_GRADE");
            entity.Property(e => e.StugradehFa4Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_FA4_GRADE");
            entity.Property(e => e.StugradehQ1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_Q1_GRADE");
            entity.Property(e => e.StugradehQ2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_Q2_GRADE");
            entity.Property(e => e.StugradehQ3Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_Q3_GRADE");
            entity.Property(e => e.StugradehSa1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_SA1_GRADE");
            entity.Property(e => e.StugradehSa2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_SA2_GRADE");
            entity.Property(e => e.StugradehSchId).HasColumnName("STUGRADEH_SCH_ID");
            entity.Property(e => e.StugradehScholasticCatId).HasColumnName("STUGRADEH_SCHOLASTIC_CAT_ID");
            entity.Property(e => e.StugradehSecId).HasColumnName("STUGRADEH_SEC_ID");
            entity.Property(e => e.StugradehSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUGRADEH_SESSION");
            entity.Property(e => e.StugradehStuGuid).HasColumnName("STUGRADEH_STU_GUID");
            entity.Property(e => e.StugradehStugradeId).HasColumnName("STUGRADEH_STUGRADE_ID");
        });

        modelBuilder.Entity<StudentMarksDetail>(entity =>
        {
            entity.HasKey(e => e.StumarksId);

            entity.Property(e => e.StumarksId).HasColumnName("STUMARKS_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StumarksCmId).HasColumnName("STUMARKS_CM_ID");
            entity.Property(e => e.StumarksCmpId).HasColumnName("STUMARKS_CMP_ID");
            entity.Property(e => e.StumarksFa1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_FA1");
            entity.Property(e => e.StumarksFa2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_FA2");
            entity.Property(e => e.StumarksFa3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_FA3");
            entity.Property(e => e.StumarksFa4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_FA4");
            entity.Property(e => e.StumarksQ1Marks1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_Q1_MARKS1");
            entity.Property(e => e.StumarksQ1Marks2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_Q1_MARKS2");
            entity.Property(e => e.StumarksQ2Marks1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_Q2_MARKS1");
            entity.Property(e => e.StumarksQ2Marks2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_Q2_MARKS2");
            entity.Property(e => e.StumarksQ3Marks1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_Q3_MARKS1");
            entity.Property(e => e.StumarksQ3Marks2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_Q3_MARKS2");
            entity.Property(e => e.StumarksSa1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_SA1");
            entity.Property(e => e.StumarksSa2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKS_SA2");
            entity.Property(e => e.StumarksSchId).HasColumnName("STUMARKS_SCH_ID");
            entity.Property(e => e.StumarksSecId).HasColumnName("STUMARKS_SEC_ID");
            entity.Property(e => e.StumarksSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUMARKS_SESSION");
            entity.Property(e => e.StumarksStuGuid).HasColumnName("STUMARKS_STU_GUID");
            entity.Property(e => e.StumarksSubCatId).HasColumnName("STUMARKS_SUB_CAT_ID");
        });

        modelBuilder.Entity<StudentMarksDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.StumarkshId);

            entity.ToTable("StudentMarksDetailsHistory");

            entity.Property(e => e.StumarkshId).HasColumnName("STUMARKSH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StumarkshCmId).HasColumnName("STUMARKSH_CM_ID");
            entity.Property(e => e.StumarkshCmpId).HasColumnName("STUMARKSH_CMP_ID");
            entity.Property(e => e.StumarkshFa1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_FA1");
            entity.Property(e => e.StumarkshFa2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_FA2");
            entity.Property(e => e.StumarkshFa3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_FA3");
            entity.Property(e => e.StumarkshFa4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_FA4");
            entity.Property(e => e.StumarkshQ1Marks1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_Q1_MARKS1");
            entity.Property(e => e.StumarkshQ1Marks2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_Q1_MARKS2");
            entity.Property(e => e.StumarkshQ2Marks1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_Q2_MARKS1");
            entity.Property(e => e.StumarkshQ2Marks2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_Q2_MARKS2");
            entity.Property(e => e.StumarkshQ3Marks1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_Q3_MARKS1");
            entity.Property(e => e.StumarkshQ3Marks2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_Q3_MARKS2");
            entity.Property(e => e.StumarkshSa1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_SA1");
            entity.Property(e => e.StumarkshSa2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUMARKSH_SA2");
            entity.Property(e => e.StumarkshSchId).HasColumnName("STUMARKSH_SCH_ID");
            entity.Property(e => e.StumarkshSecId).HasColumnName("STUMARKSH_SEC_ID");
            entity.Property(e => e.StumarkshSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUMARKSH_SESSION");
            entity.Property(e => e.StumarkshStuGuid).HasColumnName("STUMARKSH_STU_GUID");
            entity.Property(e => e.StumarkshStumarksId).HasColumnName("STUMARKSH_STUMARKS_ID");
            entity.Property(e => e.StumarkshSubCatId).HasColumnName("STUMARKSH_SUB_CAT_ID");
        });

        modelBuilder.Entity<StudentMaster>(entity =>
        {
            entity.HasKey(e => e.StuGuid);

            entity.ToTable("StudentMaster");

            entity.Property(e => e.StuGuid)
                .ValueGeneratedNever()
                .HasColumnName("STU_GUID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StuAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STU_ADDRESS");
            entity.Property(e => e.StuAnnualFfes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STU_ANNUAL_FFES");
            entity.Property(e => e.StuBirthCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_BIRTH_COUNTRY");
            entity.Property(e => e.StuBirthPlace)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_BIRTH_PLACE");
            entity.Property(e => e.StuBloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_BLOOD_GROUP");
            entity.Property(e => e.StuBloodGroupId).HasColumnName("STU_BLOOD_GROUP_ID");
            entity.Property(e => e.StuCatId).HasColumnName("STU_CAT_ID");
            entity.Property(e => e.StuCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_CITY");
            entity.Property(e => e.StuCityId).HasColumnName("STU_CITY_ID");
            entity.Property(e => e.StuClassTeacherId).HasColumnName("STU_CLASS_TEACHER_ID");
            entity.Property(e => e.StuCmId).HasColumnName("STU_CM_ID");
            entity.Property(e => e.StuCmpId).HasColumnName("STU_CMP_ID");
            entity.Property(e => e.StuContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_CONTACT_NUMBER");
            entity.Property(e => e.StuCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_COUNTRY");
            entity.Property(e => e.StuDisabilityAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_DISABILITY_ANY");
            entity.Property(e => e.StuDob)
                .HasColumnType("datetime")
                .HasColumnName("STU_DOB");
            entity.Property(e => e.StuDoj)
                .HasColumnType("datetime")
                .HasColumnName("STU_DOJ");
            entity.Property(e => e.StuEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_EMAIL");
            entity.Property(e => e.StuEmergencyContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_EMERGENCY_CONTACT_NUMBER");
            entity.Property(e => e.StuFdcmId).HasColumnName("STU_FDCM_ID");
            entity.Property(e => e.StuFirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STU_FIRST_NAME");
            entity.Property(e => e.StuGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STU_GENDER");
            entity.Property(e => e.StuHobbies)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STU_HOBBIES");
            entity.Property(e => e.StuHouseAllotted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_HOUSE_ALLOTTED");
            entity.Property(e => e.StuImage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STU_IMAGE");
            entity.Property(e => e.StuIsActive).HasColumnName("STU_IS_ACTIVE");
            entity.Property(e => e.StuLastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STU_LAST_NAME");
            entity.Property(e => e.StuMedicalAlergiesAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_MEDICAL_ALERGIES_ANY");
            entity.Property(e => e.StuNationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_NATIONALITY");
            entity.Property(e => e.StuPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_PHONE");
            entity.Property(e => e.StuPreviousSchoolAttended)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STU_PREVIOUS_SCHOOL_ATTENDED");
            entity.Property(e => e.StuPreviousSchoolBoardId).HasColumnName("STU_PREVIOUS_SCHOOL_BOARD_ID");
            entity.Property(e => e.StuPreviousSchoolClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_PREVIOUS_SCHOOL_CLASS");
            entity.Property(e => e.StuPreviousSchoolFromDate)
                .HasColumnType("datetime")
                .HasColumnName("STU_PREVIOUS_SCHOOL_FROM_DATE");
            entity.Property(e => e.StuPreviousSchoolPercentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STU_PREVIOUS_SCHOOL_PERCENTAGE");
            entity.Property(e => e.StuPreviousSchoolRank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_PREVIOUS_SCHOOL_RANK");
            entity.Property(e => e.StuPreviousSchoolToDate)
                .HasColumnType("datetime")
                .HasColumnName("STU_PREVIOUS_SCHOOL_TO_DATE");
            entity.Property(e => e.StuRegstrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_REGSTRATION_NUMBER");
            entity.Property(e => e.StuReligion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_RELIGION");
            entity.Property(e => e.StuReligionId).HasColumnName("STU_RELIGION_ID");
            entity.Property(e => e.StuRollNumber).HasColumnName("STU_ROLL_NUMBER");
            entity.Property(e => e.StuRouteId).HasColumnName("STU_ROUTE_ID");
            entity.Property(e => e.StuRoutePickAndDrop).HasColumnName("STU_ROUTE_PICK_AND_DROP");
            entity.Property(e => e.StuRouteStopId).HasColumnName("STU_ROUTE_STOP_ID");
            entity.Property(e => e.StuSchId).HasColumnName("STU_SCH_ID");
            entity.Property(e => e.StuSecId).HasColumnName("STU_SEC_ID");
            entity.Property(e => e.StuSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_SESSION");
            entity.Property(e => e.StuSiblingCmId).HasColumnName("STU_SIBLING_CM_ID");
            entity.Property(e => e.StuSiblingIfAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_SIBLING_IF_ANY");
            entity.Property(e => e.StuState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_STATE");
            entity.Property(e => e.StuStateId).HasColumnName("STU_STATE_ID");
            entity.Property(e => e.StuTransport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_TRANSPORT");
            entity.Property(e => e.StuTransportAvailingDate)
                .HasColumnType("datetime")
                .HasColumnName("STU_TRANSPORT_AVAILING_DATE");
            entity.Property(e => e.StuTransportFees)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STU_TRANSPORT_FEES");
            entity.Property(e => e.StuTutionFees)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STU_TUTION_FEES");
            entity.Property(e => e.StuUseTransportFees).HasColumnName("STU_USE_TRANSPORT_FEES");
            entity.Property(e => e.StuWithdrawnDate)
                .HasColumnType("datetime")
                .HasColumnName("STU_WITHDRAWN_DATE");
            entity.Property(e => e.StuWithdrawnReason)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STU_WITHDRAWN_REASON");
            entity.Property(e => e.StuZipCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STU_ZIP_CODE");
        });

        modelBuilder.Entity<StudentMasterHistory>(entity =>
        {
            entity.HasKey(e => new { e.StuhGuid, e.StuhSession });

            entity.ToTable("StudentMasterHistory");

            entity.Property(e => e.StuhGuid).HasColumnName("STUH_GUID");
            entity.Property(e => e.StuhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_SESSION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.StuhAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STUH_ADDRESS");
            entity.Property(e => e.StuhAnnualFfes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUH_ANNUAL_FFES");
            entity.Property(e => e.StuhBirthCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_BIRTH_COUNTRY");
            entity.Property(e => e.StuhBirthPlace)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_BIRTH_PLACE");
            entity.Property(e => e.StuhBloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_BLOOD_GROUP");
            entity.Property(e => e.StuhBloodGroupId).HasColumnName("STUH_BLOOD_GROUP_ID");
            entity.Property(e => e.StuhCatId).HasColumnName("STUH_CAT_ID");
            entity.Property(e => e.StuhCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_CITY");
            entity.Property(e => e.StuhCityId).HasColumnName("STUH_CITY_ID");
            entity.Property(e => e.StuhClassTeacherId).HasColumnName("STUH_CLASS_TEACHER_ID");
            entity.Property(e => e.StuhCmId).HasColumnName("STUH_CM_ID");
            entity.Property(e => e.StuhCmpId).HasColumnName("STUH_CMP_ID");
            entity.Property(e => e.StuhContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_CONTACT_NUMBER");
            entity.Property(e => e.StuhCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_COUNTRY");
            entity.Property(e => e.StuhDisabilityAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_DISABILITY_ANY");
            entity.Property(e => e.StuhDob)
                .HasColumnType("datetime")
                .HasColumnName("STUH_DOB");
            entity.Property(e => e.StuhDoj)
                .HasColumnType("datetime")
                .HasColumnName("STUH_DOJ");
            entity.Property(e => e.StuhEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_EMAIL");
            entity.Property(e => e.StuhEmergencyContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_EMERGENCY_CONTACT_NUMBER");
            entity.Property(e => e.StuhFdcmId).HasColumnName("STUH_FDCM_ID");
            entity.Property(e => e.StuhFirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STUH_FIRST_NAME");
            entity.Property(e => e.StuhGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STUH_GENDER");
            entity.Property(e => e.StuhHobbies)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STUH_HOBBIES");
            entity.Property(e => e.StuhHouseAllotted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_HOUSE_ALLOTTED");
            entity.Property(e => e.StuhImage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STUH_IMAGE");
            entity.Property(e => e.StuhIsActive).HasColumnName("STUH_IS_ACTIVE");
            entity.Property(e => e.StuhLastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STUH_LAST_NAME");
            entity.Property(e => e.StuhMedicalAlergiesAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_MEDICAL_ALERGIES_ANY");
            entity.Property(e => e.StuhNationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_NATIONALITY");
            entity.Property(e => e.StuhPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_PHONE");
            entity.Property(e => e.StuhPreviousSchoolAttended)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STUH_PREVIOUS_SCHOOL_ATTENDED");
            entity.Property(e => e.StuhPreviousSchoolBoardId).HasColumnName("STUH_PREVIOUS_SCHOOL_BOARD_ID");
            entity.Property(e => e.StuhPreviousSchoolClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_PREVIOUS_SCHOOL_CLASS");
            entity.Property(e => e.StuhPreviousSchoolFromDate)
                .HasColumnType("datetime")
                .HasColumnName("STUH_PREVIOUS_SCHOOL_FROM_DATE");
            entity.Property(e => e.StuhPreviousSchoolPercentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUH_PREVIOUS_SCHOOL_PERCENTAGE");
            entity.Property(e => e.StuhPreviousSchoolRank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_PREVIOUS_SCHOOL_RANK");
            entity.Property(e => e.StuhPreviousSchoolToDate)
                .HasColumnType("datetime")
                .HasColumnName("STUH_PREVIOUS_SCHOOL_TO_DATE");
            entity.Property(e => e.StuhRegstrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_REGSTRATION_NUMBER");
            entity.Property(e => e.StuhReligion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_RELIGION");
            entity.Property(e => e.StuhReligionId).HasColumnName("STUH_RELIGION_ID");
            entity.Property(e => e.StuhRollNumber).HasColumnName("STUH_ROLL_NUMBER");
            entity.Property(e => e.StuhRouteId).HasColumnName("STUH_ROUTE_ID");
            entity.Property(e => e.StuhRoutePickAndDrop).HasColumnName("STUH_ROUTE_PICK_AND_DROP");
            entity.Property(e => e.StuhRouteStopId).HasColumnName("STUH_ROUTE_STOP_ID");
            entity.Property(e => e.StuhSchId).HasColumnName("STUH_SCH_ID");
            entity.Property(e => e.StuhSecId).HasColumnName("STUH_SEC_ID");
            entity.Property(e => e.StuhSiblingCmId).HasColumnName("STUH_SIBLING_CM_ID");
            entity.Property(e => e.StuhSiblingIfAny)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_SIBLING_IF_ANY");
            entity.Property(e => e.StuhState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_STATE");
            entity.Property(e => e.StuhStateId).HasColumnName("STUH_STATE_ID");
            entity.Property(e => e.StuhTransport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_TRANSPORT");
            entity.Property(e => e.StuhTransportFees)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUH_TRANSPORT_FEES");
            entity.Property(e => e.StuhTutionFees)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STUH_TUTION_FEES");
            entity.Property(e => e.StuhUseTransportFees).HasColumnName("STUH_USE_TRANSPORT_FEES");
            entity.Property(e => e.StuhWithdrawnDate)
                .HasColumnType("datetime")
                .HasColumnName("STUH_WITHDRAWN_DATE");
            entity.Property(e => e.StuhWithdrawnReason)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STUH_WITHDRAWN_REASON");
            entity.Property(e => e.StuhZipCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STUH_ZIP_CODE");

            entity.HasOne(d => d.StuhCm).WithMany(p => p.StudentMasterHistories)
                .HasForeignKey(d => d.StuhCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentMasterHistory_ClassMaster");
        });

        modelBuilder.Entity<StudentReportCardDetail>(entity =>
        {
            entity.HasKey(e => e.RepcardDetailId);

            entity.Property(e => e.RepcardDetailId).HasColumnName("REPCARD_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RepcardDetailCmpId).HasColumnName("REPCARD_DETAIL_CMP_ID");
            entity.Property(e => e.RepcardDetailFa1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARD_DETAIL_FA1_GRADE");
            entity.Property(e => e.RepcardDetailFa1Marks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_FA1_MARKS");
            entity.Property(e => e.RepcardDetailFa2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARD_DETAIL_FA2_GRADE");
            entity.Property(e => e.RepcardDetailFa2Marks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_FA2_MARKS");
            entity.Property(e => e.RepcardDetailGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARD_DETAIL_GRADE");
            entity.Property(e => e.RepcardDetailQuarterMarks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_QUARTER_MARKS");
            entity.Property(e => e.RepcardDetailRepcardId).HasColumnName("REPCARD_DETAIL_REPCARD_ID");
            entity.Property(e => e.RepcardDetailSaGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARD_DETAIL_SA_GRADE");
            entity.Property(e => e.RepcardDetailSaMarks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_SA_MARKS");
            entity.Property(e => e.RepcardDetailSchId).HasColumnName("REPCARD_DETAIL_SCH_ID");
            entity.Property(e => e.RepcardDetailSubjectId).HasColumnName("REPCARD_DETAIL_SUBJECT_ID");
            entity.Property(e => e.RepcardDetailSubjectType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARD_DETAIL_SUBJECT_TYPE");
            entity.Property(e => e.RepcardDetailTotalGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARD_DETAIL_TOTAL_GRADE");
            entity.Property(e => e.RepcardDetailTotalMarks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_TOTAL_MARKS");
            entity.Property(e => e.RepcardDetailTotalMarksFa1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_TOTAL_MARKS_FA1");
            entity.Property(e => e.RepcardDetailTotalMarksFa2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_TOTAL_MARKS_FA2");
            entity.Property(e => e.RepcardDetailTotalMarksFinal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_TOTAL_MARKS_FINAL");
            entity.Property(e => e.RepcardDetailTotalMarksQuarter)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_TOTAL_MARKS_QUARTER");
            entity.Property(e => e.RepcardDetailTotalMarksSa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARD_DETAIL_TOTAL_MARKS_SA");
        });

        modelBuilder.Entity<StudentReportCardDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.RepcardhDetailId);

            entity.ToTable("StudentReportCardDetailsHistory");

            entity.Property(e => e.RepcardhDetailId).HasColumnName("REPCARDH_DETAIL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RepcardhDetailCmpId).HasColumnName("REPCARDH_DETAIL_CMP_ID");
            entity.Property(e => e.RepcardhDetailFa1Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_DETAIL_FA1_GRADE");
            entity.Property(e => e.RepcardhDetailFa1Marks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_FA1_MARKS");
            entity.Property(e => e.RepcardhDetailFa2Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_DETAIL_FA2_GRADE");
            entity.Property(e => e.RepcardhDetailFa2Marks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_FA2_MARKS");
            entity.Property(e => e.RepcardhDetailGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_DETAIL_GRADE");
            entity.Property(e => e.RepcardhDetailQuarterMarks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_QUARTER_MARKS");
            entity.Property(e => e.RepcardhDetailRepcardId).HasColumnName("REPCARDH_DETAIL_REPCARD_ID");
            entity.Property(e => e.RepcardhDetailSaGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_DETAIL_SA_GRADE");
            entity.Property(e => e.RepcardhDetailSaMarks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_SA_MARKS");
            entity.Property(e => e.RepcardhDetailSchId).HasColumnName("REPCARDH_DETAIL_SCH_ID");
            entity.Property(e => e.RepcardhDetailSubjectId).HasColumnName("REPCARDH_DETAIL_SUBJECT_ID");
            entity.Property(e => e.RepcardhDetailSubjectType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_DETAIL_SUBJECT_TYPE");
            entity.Property(e => e.RepcardhDetailTotalGrade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_DETAIL_TOTAL_GRADE");
            entity.Property(e => e.RepcardhDetailTotalMarks)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_TOTAL_MARKS");
            entity.Property(e => e.RepcardhDetailTotalMarksFa1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_TOTAL_MARKS_FA1");
            entity.Property(e => e.RepcardhDetailTotalMarksFa2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_TOTAL_MARKS_FA2");
            entity.Property(e => e.RepcardhDetailTotalMarksFinal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_TOTAL_MARKS_FINAL");
            entity.Property(e => e.RepcardhDetailTotalMarksQuarter)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_TOTAL_MARKS_QUARTER");
            entity.Property(e => e.RepcardhDetailTotalMarksSa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("REPCARDH_DETAIL_TOTAL_MARKS_SA");
        });

        modelBuilder.Entity<StudentReportCardMaster>(entity =>
        {
            entity.HasKey(e => e.RepcardId).HasName("PK_StudentReportCardMaster_1");

            entity.ToTable("StudentReportCardMaster");

            entity.Property(e => e.RepcardId).HasColumnName("REPCARD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RepcardCmId).HasColumnName("REPCARD_CM_ID");
            entity.Property(e => e.RepcardCmpId).HasColumnName("REPCARD_CMP_ID");
            entity.Property(e => e.RepcardPeriod)
                .HasColumnType("datetime")
                .HasColumnName("REPCARD_PERIOD");
            entity.Property(e => e.RepcardSchId).HasColumnName("REPCARD_SCH_ID");
            entity.Property(e => e.RepcardSecId).HasColumnName("REPCARD_SEC_ID");
            entity.Property(e => e.RepcardSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARD_SESSION");
            entity.Property(e => e.RepcardStuGuid).HasColumnName("REPCARD_STU_GUID");
            entity.Property(e => e.RepcardType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARD_TYPE");
            entity.Property(e => e.RepcardTypeValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARD_TYPE_VALUE");
        });

        modelBuilder.Entity<StudentReportCardMasterHistory>(entity =>
        {
            entity.HasKey(e => e.RepcardhId);

            entity.ToTable("StudentReportCardMasterHistory");

            entity.Property(e => e.RepcardhId).HasColumnName("REPCARDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.RepcardhCmId).HasColumnName("REPCARDH_CM_ID");
            entity.Property(e => e.RepcardhCmpId).HasColumnName("REPCARDH_CMP_ID");
            entity.Property(e => e.RepcardhPeriod)
                .HasColumnType("datetime")
                .HasColumnName("REPCARDH_PERIOD");
            entity.Property(e => e.RepcardhRepcardId).HasColumnName("REPCARDH_REPCARD_ID");
            entity.Property(e => e.RepcardhSchId).HasColumnName("REPCARDH_SCH_ID");
            entity.Property(e => e.RepcardhSecId).HasColumnName("REPCARDH_SEC_ID");
            entity.Property(e => e.RepcardhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_SESSION");
            entity.Property(e => e.RepcardhStuGuid).HasColumnName("REPCARDH_STU_GUID");
            entity.Property(e => e.RepcardhType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_TYPE");
            entity.Property(e => e.RepcardhTypeValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPCARDH_TYPE_VALUE");
        });

        modelBuilder.Entity<SubjectCategoryDetail>(entity =>
        {
            entity.HasKey(e => e.SubcatId);

            entity.Property(e => e.SubcatId).HasColumnName("SUBCAT_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SubcatCmpId).HasColumnName("SUBCAT_CMP_ID");
            entity.Property(e => e.SubcatDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SUBCAT_DESC");
            entity.Property(e => e.SubcatName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUBCAT_NAME");
            entity.Property(e => e.SubcatParentId).HasColumnName("SUBCAT_PARENT_ID");
            entity.Property(e => e.SubcatSchId).HasColumnName("SUBCAT_SCH_ID");
            entity.Property(e => e.SubcatSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBCAT_SESSION");
            entity.Property(e => e.SubcatSubjectId).HasColumnName("SUBCAT_SUBJECT_ID");
        });

        modelBuilder.Entity<SubjectMaster>(entity =>
        {
            entity.HasKey(e => e.SubId);

            entity.ToTable("SubjectMaster");

            entity.Property(e => e.SubId).HasColumnName("SUB_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(256)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(256)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SubCmpId).HasColumnName("SUB_CMP_ID");
            entity.Property(e => e.SubIsActive).HasColumnName("SUB_IS_ACTIVE");
            entity.Property(e => e.SubIsScholastic).HasColumnName("SUB_IS_SCHOLASTIC");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_NAME");
            entity.Property(e => e.SubSchId).HasColumnName("SUB_SCH_ID");
        });

        modelBuilder.Entity<SupplierMaster>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK_SUPPLIERMaster");

            entity.ToTable("SupplierMaster");

            entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SupplierAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_ADDRESS");
            entity.Property(e => e.SupplierCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_CITY");
            entity.Property(e => e.SupplierCityId).HasColumnName("SUPPLIER_CITY_ID");
            entity.Property(e => e.SupplierCmpId).HasColumnName("SUPPLIER_CMP_ID");
            entity.Property(e => e.SupplierCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_COUNTRY");
            entity.Property(e => e.SupplierDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_DESCRIPTION");
            entity.Property(e => e.SupplierEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_EMAIL");
            entity.Property(e => e.SupplierMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_MOBILE");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_NAME");
            entity.Property(e => e.SupplierPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_PHONE");
            entity.Property(e => e.SupplierSchId).HasColumnName("SUPPLIER_SCH_ID");
            entity.Property(e => e.SupplierState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_STATE");
            entity.Property(e => e.SupplierStateId).HasColumnName("SUPPLIER_STATE_ID");
            entity.Property(e => e.SupplierZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUPPLIER_ZIPCODE");
        });

        modelBuilder.Entity<SystemParameter>(entity =>
        {
            entity.HasKey(e => e.SysParameterId);

            entity.Property(e => e.SysParameterId).HasColumnName("SYS_PARAMETER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.SyspCmpId).HasColumnName("SYSP_CMP_ID");
            entity.Property(e => e.SyspParameterDescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SYSP_PARAMETER_DESCRIPTION");
            entity.Property(e => e.SyspParameterName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SYSP_PARAMETER_NAME");
            entity.Property(e => e.SyspParameterValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SYSP_PARAMETER_VALUE");
            entity.Property(e => e.SyspSchId).HasColumnName("SYSP_SCH_ID");
        });

        modelBuilder.Entity<TeacherClassDetail>(entity =>
        {
            entity.HasKey(e => e.TcdId).HasName("PK_TeacherClassDetails_1");

            entity.Property(e => e.TcdId).HasColumnName("TCD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TcdClassId).HasColumnName("TCD_CLASS_ID");
            entity.Property(e => e.TcdCmpId).HasColumnName("TCD_CMP_ID");
            entity.Property(e => e.TcdSchId).HasColumnName("TCD_SCH_ID");
            entity.Property(e => e.TcdSectionId).HasColumnName("TCD_SECTION_ID");
            entity.Property(e => e.TcdSubjectId).HasColumnName("TCD_SUBJECT_ID");
            entity.Property(e => e.TcdTeacherId).HasColumnName("TCD_TEACHER_ID");

            entity.HasOne(d => d.TcdClass).WithMany(p => p.TeacherClassDetails)
                .HasForeignKey(d => d.TcdClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherClassDetails_ClassMaster");

            entity.HasOne(d => d.TcdSection).WithMany(p => p.TeacherClassDetails)
                .HasForeignKey(d => d.TcdSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherClassDetails_SectionMaster");

            entity.HasOne(d => d.TcdSubject).WithMany(p => p.TeacherClassDetails)
                .HasForeignKey(d => d.TcdSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherClassDetails_SubjectMaster");

            entity.HasOne(d => d.TcdTeacher).WithMany(p => p.TeacherClassDetails)
                .HasForeignKey(d => d.TcdTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherClassDetails_TeacherMaster");
        });

        modelBuilder.Entity<TeacherDocumentDetail>(entity =>
        {
            entity.HasKey(e => e.TdocId);

            entity.Property(e => e.TdocId).HasColumnName("TDOC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TdocCmpId).HasColumnName("TDOC_CMP_ID");
            entity.Property(e => e.TdocDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TDOC_DESCRIPTION");
            entity.Property(e => e.TdocFilename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TDOC_FILENAME");
            entity.Property(e => e.TdocName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TDOC_NAME");
            entity.Property(e => e.TdocSchId).HasColumnName("TDOC_SCH_ID");
            entity.Property(e => e.TdocTeacherId).HasColumnName("TDOC_TEACHER_ID");

            entity.HasOne(d => d.TdocTeacher).WithMany(p => p.TeacherDocumentDetails)
                .HasForeignKey(d => d.TdocTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherDocumentDetails_TeacherMaster");
        });

        modelBuilder.Entity<TeacherMaster>(entity =>
        {
            entity.HasKey(e => e.TeacherId);

            entity.ToTable("TeacherMaster");

            entity.Property(e => e.TeacherId).HasColumnName("TEACHER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TeacherAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEACHER_ADDRESS");
            entity.Property(e => e.TeacherCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_CITY");
            entity.Property(e => e.TeacherCityId).HasColumnName("TEACHER_CITY_ID");
            entity.Property(e => e.TeacherCmpId).HasColumnName("TEACHER_CMP_ID");
            entity.Property(e => e.TeacherDateOfLeaving)
                .HasColumnType("datetime")
                .HasColumnName("TEACHER_DATE_OF_LEAVING");
            entity.Property(e => e.TeacherDob)
                .HasColumnType("datetime")
                .HasColumnName("TEACHER_DOB");
            entity.Property(e => e.TeacherDoj)
                .HasColumnType("datetime")
                .HasColumnName("TEACHER_DOJ");
            entity.Property(e => e.TeacherEmail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TEACHER_EMAIL");
            entity.Property(e => e.TeacherFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_FIRST_NAME");
            entity.Property(e => e.TeacherGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TEACHER_GENDER");
            entity.Property(e => e.TeacherImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEACHER_IMAGE");
            entity.Property(e => e.TeacherLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_LAST_NAME");
            entity.Property(e => e.TeacherMartialStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TEACHER_MARTIAL_STATUS");
            entity.Property(e => e.TeacherMobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_MOBILE_PHONE");
            entity.Property(e => e.TeacherPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_PHONE");
            entity.Property(e => e.TeacherPreviousSchool)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TEACHER_PREVIOUS_SCHOOL");
            entity.Property(e => e.TeacherSalutation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TEACHER_SALUTATION");
            entity.Property(e => e.TeacherSchId).HasColumnName("TEACHER_SCH_ID");
            entity.Property(e => e.TeacherState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_STATE");
            entity.Property(e => e.TeacherStateId).HasColumnName("TEACHER_STATE_ID");
            entity.Property(e => e.TeacherYearsOfExperience)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_YEARS_OF_EXPERIENCE");
            entity.Property(e => e.TeacherZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEACHER_ZIPCODE");
        });

        modelBuilder.Entity<TeacherQualificationDetail>(entity =>
        {
            entity.HasKey(e => new { e.TqualdTeacherId, e.TqualdQualId });

            entity.Property(e => e.TqualdTeacherId).HasColumnName("TQUALD_TEACHER_ID");
            entity.Property(e => e.TqualdQualId).HasColumnName("TQUALD_QUAL_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");

            entity.HasOne(d => d.TqualdQual).WithMany(p => p.TeacherQualificationDetails)
                .HasForeignKey(d => d.TqualdQualId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherQualificationDetails_QualificationMaster");

            entity.HasOne(d => d.TqualdTeacher).WithMany(p => p.TeacherQualificationDetails)
                .HasForeignKey(d => d.TqualdTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherQualificationDetails_TeacherMaster");
        });

        modelBuilder.Entity<TeacherSectionDetail>(entity =>
        {
            entity.HasKey(e => e.TsecId);

            entity.Property(e => e.TsecId).HasColumnName("TSEC_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TsecCmId).HasColumnName("TSEC_CM_ID");
            entity.Property(e => e.TsecCmpId).HasColumnName("TSEC_CMP_ID");
            entity.Property(e => e.TsecIsClassTeacher).HasColumnName("TSEC_IS_CLASS_TEACHER");
            entity.Property(e => e.TsecSchId).HasColumnName("TSEC_SCH_ID");
            entity.Property(e => e.TsecSecId).HasColumnName("TSEC_SEC_ID");
            entity.Property(e => e.TsecSubId).HasColumnName("TSEC_SUB_ID");
            entity.Property(e => e.TsecTeacherId).HasColumnName("TSEC_TEACHER_ID");

            entity.HasOne(d => d.TsecCm).WithMany(p => p.TeacherSectionDetails)
                .HasForeignKey(d => d.TsecCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherSectionDetails_ClassMaster");

            entity.HasOne(d => d.TsecSec).WithMany(p => p.TeacherSectionDetails)
                .HasForeignKey(d => d.TsecSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherSectionDetails_ClassSectionDetail");

            entity.HasOne(d => d.TsecSub).WithMany(p => p.TeacherSectionDetails)
                .HasForeignKey(d => d.TsecSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherSectionDetails_SubjectMaster");

            entity.HasOne(d => d.TsecTeacher).WithMany(p => p.TeacherSectionDetails)
                .HasForeignKey(d => d.TsecTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherSectionDetails_TeacherMaster");
        });

        modelBuilder.Entity<TeacherSubjectDetail>(entity =>
        {
            entity.HasKey(e => new { e.TsubdTeacherId, e.TsubdSubId, e.TsubdCmId });

            entity.Property(e => e.TsubdTeacherId).HasColumnName("TSUBD_TEACHER_ID");
            entity.Property(e => e.TsubdSubId).HasColumnName("TSUBD_SUB_ID");
            entity.Property(e => e.TsubdCmId).HasColumnName("TSUBD_CM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TsubdCmpId).HasColumnName("TSUBD_CMP_ID");
            entity.Property(e => e.TsubdSchId).HasColumnName("TSUBD_SCH_ID");

            entity.HasOne(d => d.TsubdSub).WithMany(p => p.TeacherSubjectDetails)
                .HasForeignKey(d => d.TsubdSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherSubjectDetails_SubjectMaster");

            entity.HasOne(d => d.TsubdTeacher).WithMany(p => p.TeacherSubjectDetails)
                .HasForeignKey(d => d.TsubdTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeacherSubjectDetails_TeacherMaster");
        });

        modelBuilder.Entity<TimeTableClassPeriodDetail>(entity =>
        {
            entity.HasKey(e => e.TtclpdId);

            entity.Property(e => e.TtclpdId).HasColumnName("TTCLPD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtclpdCmId).HasColumnName("TTCLPD_CM_ID");
            entity.Property(e => e.TtclpdCmpId).HasColumnName("TTCLPD_CMP_ID");
            entity.Property(e => e.TtclpdDayOfWeek).HasColumnName("TTCLPD_DAY_OF_WEEK");
            entity.Property(e => e.TtclpdPeriodId).HasColumnName("TTCLPD_PERIOD_ID");
            entity.Property(e => e.TtclpdSchId).HasColumnName("TTCLPD_SCH_ID");
            entity.Property(e => e.TtclpdSecId).HasColumnName("TTCLPD_SEC_ID");
            entity.Property(e => e.TtclpdSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTCLPD_SESSION");
            entity.Property(e => e.TtclpdSessionId).HasColumnName("TTCLPD_SESSION_ID");
            entity.Property(e => e.TtclpdSubId).HasColumnName("TTCLPD_SUB_ID");

            entity.HasOne(d => d.TtclpdCm).WithMany(p => p.TimeTableClassPeriodDetails)
                .HasForeignKey(d => d.TtclpdCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetails_ClassMaster");

            entity.HasOne(d => d.TtclpdPeriod).WithMany(p => p.TimeTableClassPeriodDetails)
                .HasForeignKey(d => d.TtclpdPeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetails_PeriodMaster");

            entity.HasOne(d => d.TtclpdSec).WithMany(p => p.TimeTableClassPeriodDetails)
                .HasForeignKey(d => d.TtclpdSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetails_ClassSectionDetails");

            entity.HasOne(d => d.TtclpdSessionNavigation).WithMany(p => p.TimeTableClassPeriodDetails)
                .HasForeignKey(d => d.TtclpdSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetails_SessionMaster");

            entity.HasOne(d => d.TtclpdSub).WithMany(p => p.TimeTableClassPeriodDetails)
                .HasForeignKey(d => d.TtclpdSubId)
                .HasConstraintName("FK_TimeTableClassPeriodDetails_SubjectMaster");
        });

        modelBuilder.Entity<TimeTableClassPeriodDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.TtclpdhId);

            entity.ToTable("TimeTableClassPeriodDetailsHistory");

            entity.Property(e => e.TtclpdhId).HasColumnName("TTCLPDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtclpdhCmId).HasColumnName("TTCLPDH_CM_ID");
            entity.Property(e => e.TtclpdhCmpId).HasColumnName("TTCLPDH_CMP_ID");
            entity.Property(e => e.TtclpdhDayOfWeek).HasColumnName("TTCLPDH_DAY_OF_WEEK");
            entity.Property(e => e.TtclpdhPeriodId).HasColumnName("TTCLPDH_PERIOD_ID");
            entity.Property(e => e.TtclpdhSchId).HasColumnName("TTCLPDH_SCH_ID");
            entity.Property(e => e.TtclpdhSecId).HasColumnName("TTCLPDH_SEC_ID");
            entity.Property(e => e.TtclpdhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTCLPDH_SESSION");
            entity.Property(e => e.TtclpdhSessionId).HasColumnName("TTCLPDH_SESSION_ID");
            entity.Property(e => e.TtclpdhSubId).HasColumnName("TTCLPDH_SUB_ID");

            entity.HasOne(d => d.TtclpdhCm).WithMany(p => p.TimeTableClassPeriodDetailsHistories)
                .HasForeignKey(d => d.TtclpdhCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetailsHistory_ClassMaster");

            entity.HasOne(d => d.TtclpdhSec).WithMany(p => p.TimeTableClassPeriodDetailsHistories)
                .HasForeignKey(d => d.TtclpdhSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetailsHistory_ClassSectionDetails");

            entity.HasOne(d => d.TtclpdhSessionNavigation).WithMany(p => p.TimeTableClassPeriodDetailsHistories)
                .HasForeignKey(d => d.TtclpdhSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableClassPeriodDetailsHistory_SessionMaster");

            entity.HasOne(d => d.TtclpdhSub).WithMany(p => p.TimeTableClassPeriodDetailsHistories)
                .HasForeignKey(d => d.TtclpdhSubId)
                .HasConstraintName("FK_TimeTableClassPeriodDetailsHistory_SubjectMaster");
        });

        modelBuilder.Entity<TimeTableDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.TtdetailhId);

            entity.ToTable("TimeTableDetailsHistory");

            entity.Property(e => e.TtdetailhId).HasColumnName("TTDETAILH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtdetailhCmId).HasColumnName("TTDETAILH_CM_ID");
            entity.Property(e => e.TtdetailhCmpId).HasColumnName("TTDETAILH_CMP_ID");
            entity.Property(e => e.TtdetailhDayOfWeek).HasColumnName("TTDETAILH_DAY_OF_WEEK");
            entity.Property(e => e.TtdetailhPeriodId).HasColumnName("TTDETAILH_PERIOD_ID");
            entity.Property(e => e.TtdetailhSchId).HasColumnName("TTDETAILH_SCH_ID");
            entity.Property(e => e.TtdetailhSecId).HasColumnName("TTDETAILH_SEC_ID");
            entity.Property(e => e.TtdetailhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTDETAILH_SESSION");
            entity.Property(e => e.TtdetailhSessionId).HasColumnName("TTDETAILH_SESSION_ID");
            entity.Property(e => e.TtdetailhSubId).HasColumnName("TTDETAILH_SUB_ID");
            entity.Property(e => e.TtdetailhTeacherId).HasColumnName("TTDETAILH_TEACHER_ID");

            entity.HasOne(d => d.TtdetailhCm).WithMany(p => p.TimeTableDetailsHistories)
                .HasForeignKey(d => d.TtdetailhCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableDetailsHistory_ClassMaster");

            entity.HasOne(d => d.TtdetailhSec).WithMany(p => p.TimeTableDetailsHistories)
                .HasForeignKey(d => d.TtdetailhSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableDetailsHistory_ClassSectionDetail");

            entity.HasOne(d => d.TtdetailhSessionNavigation).WithMany(p => p.TimeTableDetailsHistories)
                .HasForeignKey(d => d.TtdetailhSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableDetailsHistory_TimeTableSessions");

            entity.HasOne(d => d.TtdetailhSub).WithMany(p => p.TimeTableDetailsHistories)
                .HasForeignKey(d => d.TtdetailhSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableDetailsHistory_SubjectMaster");

            entity.HasOne(d => d.TtdetailhTeacher).WithMany(p => p.TimeTableDetailsHistories)
                .HasForeignKey(d => d.TtdetailhTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableDetailsHistory_TeacherMaster");
        });

        modelBuilder.Entity<TimeTablePeriodMaster>(entity =>
        {
            entity.HasKey(e => e.TtperiodId);

            entity.ToTable("TimeTablePeriodMaster");

            entity.Property(e => e.TtperiodId).HasColumnName("TTPERIOD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtperiodCmpId).HasColumnName("TTPERIOD_CMP_ID");
            entity.Property(e => e.TtperiodDesctiption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTPERIOD_DESCTIPTION");
            entity.Property(e => e.TtperiodEndTime)
                .HasPrecision(0)
                .HasColumnName("TTPERIOD_END_TIME");
            entity.Property(e => e.TtperiodNumber).HasColumnName("TTPERIOD_NUMBER");
            entity.Property(e => e.TtperiodSchId).HasColumnName("TTPERIOD_SCH_ID");
            entity.Property(e => e.TtperiodSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTPERIOD_SESSION");
            entity.Property(e => e.TtperiodStartTime)
                .HasPrecision(0)
                .HasColumnName("TTPERIOD_START_TIME");
            entity.Property(e => e.TtperiodTtsessionId).HasColumnName("TTPERIOD_TTSESSION_ID");

            entity.HasOne(d => d.TtperiodTtsession).WithMany(p => p.TimeTablePeriodMasters)
                .HasForeignKey(d => d.TtperiodTtsessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTablePeriodMaster_TimeTableSession");
        });

        modelBuilder.Entity<TimeTablePeriodMasterHistory>(entity =>
        {
            entity.HasKey(e => e.TtperiodhId);

            entity.ToTable("TimeTablePeriodMasterHistory");

            entity.Property(e => e.TtperiodhId).HasColumnName("TTPERIODH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtperiodhCmpId).HasColumnName("TTPERIODH_CMP_ID");
            entity.Property(e => e.TtperiodhDesctiption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTPERIODH_DESCTIPTION");
            entity.Property(e => e.TtperiodhEndTime)
                .HasPrecision(0)
                .HasColumnName("TTPERIODH_END_TIME");
            entity.Property(e => e.TtperiodhNumber).HasColumnName("TTPERIODH_NUMBER");
            entity.Property(e => e.TtperiodhPeriodId).HasColumnName("TTPERIODH_PERIOD_ID");
            entity.Property(e => e.TtperiodhSchId).HasColumnName("TTPERIODH_SCH_ID");
            entity.Property(e => e.TtperiodhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTPERIODH_SESSION");
            entity.Property(e => e.TtperiodhStartTime)
                .HasPrecision(0)
                .HasColumnName("TTPERIODH_START_TIME");
            entity.Property(e => e.TtperiodhTtsessionId).HasColumnName("TTPERIODH_TTSESSION_ID");

            entity.HasOne(d => d.TtperiodhTtsession).WithMany(p => p.TimeTablePeriodMasterHistories)
                .HasForeignKey(d => d.TtperiodhTtsessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTablePeriodMasterHistory_TimeTableSession");
        });

        modelBuilder.Entity<TimeTableSession>(entity =>
        {
            entity.HasKey(e => e.TtsessionId);

            entity.Property(e => e.TtsessionId).HasColumnName("TTSESSION_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtsessionCmpId).HasColumnName("TTSESSION_CMP_ID");
            entity.Property(e => e.TtsessionName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTSESSION_NAME");
            entity.Property(e => e.TtsessionSchId).HasColumnName("TTSESSION_SCH_ID");
            entity.Property(e => e.TtsesstionDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TTSESSTION_DESCRIPTION");
        });

        modelBuilder.Entity<TimeTableSetupDetail>(entity =>
        {
            entity.HasKey(e => e.TtsetupId);

            entity.Property(e => e.TtsetupId).HasColumnName("TTSETUP_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtsetupCmpId).HasColumnName("TTSETUP_CMP_ID");
            entity.Property(e => e.TtsetupFruitReccessAfterPeriod).HasColumnName("TTSETUP_FRUIT_RECCESS_AFTER_PERIOD");
            entity.Property(e => e.TtsetupFruitReccessDuration).HasColumnName("TTSETUP_FRUIT_RECCESS_DURATION");
            entity.Property(e => e.TtsetupPeriodDuration).HasColumnName("TTSETUP_PERIOD_DURATION");
            entity.Property(e => e.TtsetupPeriodStartTime)
                .HasPrecision(0)
                .HasColumnName("TTSETUP_PERIOD_START_TIME");
            entity.Property(e => e.TtsetupReccessAfterPeriod).HasColumnName("TTSETUP_RECCESS_AFTER_PERIOD");
            entity.Property(e => e.TtsetupReccessDuration).HasColumnName("TTSETUP_RECCESS_DURATION");
            entity.Property(e => e.TtsetupSchId).HasColumnName("TTSETUP_SCH_ID");
            entity.Property(e => e.TtsetupSchoolEndTime)
                .HasPrecision(0)
                .HasColumnName("TTSETUP_SCHOOL_END_TIME");
            entity.Property(e => e.TtsetupSchoolStartTime)
                .HasPrecision(0)
                .HasColumnName("TTSETUP_SCHOOL_START_TIME");
            entity.Property(e => e.TtsetupSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTSETUP_SESSION");
            entity.Property(e => e.TtsetupTotalPeriods).HasColumnName("TTSETUP_TOTAL_PERIODS");
            entity.Property(e => e.TtsetupTtsessionId).HasColumnName("TTSETUP_TTSESSION_ID");

            entity.HasOne(d => d.TtsetupTtsession).WithMany(p => p.TimeTableSetupDetails)
                .HasForeignKey(d => d.TtsetupTtsessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSetupDetails_TimeTableSesions");
        });

        modelBuilder.Entity<TimeTableSetupDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.TtsetuphId);

            entity.ToTable("TimeTableSetupDetailsHistory");

            entity.Property(e => e.TtsetuphId).HasColumnName("TTSETUPH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtsetuphCmpId).HasColumnName("TTSETUPH_CMP_ID");
            entity.Property(e => e.TtsetuphFruitReccessAfterPeriod).HasColumnName("TTSETUPH_FRUIT_RECCESS_AFTER_PERIOD");
            entity.Property(e => e.TtsetuphFruitReccessDuration).HasColumnName("TTSETUPH_FRUIT_RECCESS_DURATION");
            entity.Property(e => e.TtsetuphPeriodDuration).HasColumnName("TTSETUPH_PERIOD_DURATION");
            entity.Property(e => e.TtsetuphPeriodStartTime)
                .HasPrecision(0)
                .HasColumnName("TTSETUPH_PERIOD_START_TIME");
            entity.Property(e => e.TtsetuphReccessAfterPeriod).HasColumnName("TTSETUPH_RECCESS_AFTER_PERIOD");
            entity.Property(e => e.TtsetuphReccessDuration).HasColumnName("TTSETUPH_RECCESS_DURATION");
            entity.Property(e => e.TtsetuphSchId).HasColumnName("TTSETUPH_SCH_ID");
            entity.Property(e => e.TtsetuphSchoolEndTime)
                .HasPrecision(0)
                .HasColumnName("TTSETUPH_SCHOOL_END_TIME");
            entity.Property(e => e.TtsetuphSchoolStartTime)
                .HasPrecision(0)
                .HasColumnName("TTSETUPH_SCHOOL_START_TIME");
            entity.Property(e => e.TtsetuphSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTSETUPH_SESSION");
            entity.Property(e => e.TtsetuphTotalPeriods).HasColumnName("TTSETUPH_TOTAL_PERIODS");
            entity.Property(e => e.TtsetuphTtsessionId).HasColumnName("TTSETUPH_TTSESSION_ID");

            entity.HasOne(d => d.TtsetuphTtsession).WithMany(p => p.TimeTableSetupDetailsHistories)
                .HasForeignKey(d => d.TtsetuphTtsessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSetupDetailsHistory_TimeTableSesions");
        });

        modelBuilder.Entity<TimeTableSubstitutionDetail>(entity =>
        {
            entity.HasKey(e => e.TtsubsdId);

            entity.Property(e => e.TtsubsdId).HasColumnName("TTSUBSD_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtsubsdCmId).HasColumnName("TTSUBSD_CM_ID");
            entity.Property(e => e.TtsubsdCmpId).HasColumnName("TTSUBSD_CMP_ID");
            entity.Property(e => e.TtsubsdDayOfWeek).HasColumnName("TTSUBSD_DAY_OF_WEEK");
            entity.Property(e => e.TtsubsdPeriodId).HasColumnName("TTSUBSD_PERIOD_ID");
            entity.Property(e => e.TtsubsdSchId).HasColumnName("TTSUBSD_SCH_ID");
            entity.Property(e => e.TtsubsdSecId).HasColumnName("TTSUBSD_SEC_ID");
            entity.Property(e => e.TtsubsdSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTSUBSD_SESSION");
            entity.Property(e => e.TtsubsdSessionId).HasColumnName("TTSUBSD_SESSION_ID");
            entity.Property(e => e.TtsubsdSubId).HasColumnName("TTSUBSD_SUB_ID");
            entity.Property(e => e.TtsubsdSubstitutionDate)
                .HasColumnType("datetime")
                .HasColumnName("TTSUBSD_SUBSTITUTION_DATE");
            entity.Property(e => e.TtsubsdTeacherId).HasColumnName("TTSUBSD_TEACHER_ID");
            entity.Property(e => e.TtsubsdTeacherIdNew).HasColumnName("TTSUBSD_TEACHER_ID_NEW");

            entity.HasOne(d => d.TtsubsdCm).WithMany(p => p.TimeTableSubstitutionDetails)
                .HasForeignKey(d => d.TtsubsdCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_ClassMaster");

            entity.HasOne(d => d.TtsubsdPeriod).WithMany(p => p.TimeTableSubstitutionDetails)
                .HasForeignKey(d => d.TtsubsdPeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_PeriodMaster");

            entity.HasOne(d => d.TtsubsdSec).WithMany(p => p.TimeTableSubstitutionDetails)
                .HasForeignKey(d => d.TtsubsdSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_ClassSectionDetail");

            entity.HasOne(d => d.TtsubsdSessionNavigation).WithMany(p => p.TimeTableSubstitutionDetails)
                .HasForeignKey(d => d.TtsubsdSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_TimeTableSession");

            entity.HasOne(d => d.TtsubsdSub).WithMany(p => p.TimeTableSubstitutionDetails)
                .HasForeignKey(d => d.TtsubsdSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_SubjectMaster");

            entity.HasOne(d => d.TtsubsdTeacher).WithMany(p => p.TimeTableSubstitutionDetailTtsubsdTeachers)
                .HasForeignKey(d => d.TtsubsdTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_EmpMaster");

            entity.HasOne(d => d.TtsubsdTeacherIdNewNavigation).WithMany(p => p.TimeTableSubstitutionDetailTtsubsdTeacherIdNewNavigations)
                .HasForeignKey(d => d.TtsubsdTeacherIdNew)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstitutionDetails_EmpMasterNewTeacher");
        });

        modelBuilder.Entity<TimeTableSubstitutionDetailsHistory>(entity =>
        {
            entity.HasKey(e => e.TtsubsdhId);

            entity.ToTable("TimeTableSubstitutionDetailsHistory");

            entity.Property(e => e.TtsubsdhId).HasColumnName("TTSUBSDH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.TtsubsdhCmId).HasColumnName("TTSUBSDH_CM_ID");
            entity.Property(e => e.TtsubsdhCmpId).HasColumnName("TTSUBSDH_CMP_ID");
            entity.Property(e => e.TtsubsdhDayOfWeek).HasColumnName("TTSUBSDH_DAY_OF_WEEK");
            entity.Property(e => e.TtsubsdhPeriodId).HasColumnName("TTSUBSDH_PERIOD_ID");
            entity.Property(e => e.TtsubsdhSchId).HasColumnName("TTSUBSDH_SCH_ID");
            entity.Property(e => e.TtsubsdhSecId).HasColumnName("TTSUBSDH_SEC_ID");
            entity.Property(e => e.TtsubsdhSession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTSUBSDH_SESSION");
            entity.Property(e => e.TtsubsdhSessionId).HasColumnName("TTSUBSDH_SESSION_ID");
            entity.Property(e => e.TtsubsdhSubId).HasColumnName("TTSUBSDH_SUB_ID");
            entity.Property(e => e.TtsubsdhSubstitutionDate)
                .HasColumnType("datetime")
                .HasColumnName("TTSUBSDH_SUBSTITUTION_DATE");
            entity.Property(e => e.TtsubsdhTeacherId).HasColumnName("TTSUBSDH_TEACHER_ID");
            entity.Property(e => e.TtsubsdhTeacherIdNew).HasColumnName("TTSUBSDH_TEACHER_ID_NEW");

            entity.HasOne(d => d.TtsubsdhCm).WithMany(p => p.TimeTableSubstitutionDetailsHistories)
                .HasForeignKey(d => d.TtsubsdhCmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstDetailsHistory_ClassMaster");

            entity.HasOne(d => d.TtsubsdhSec).WithMany(p => p.TimeTableSubstitutionDetailsHistories)
                .HasForeignKey(d => d.TtsubsdhSecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstDetailsHistory_ClassSectionDetail");

            entity.HasOne(d => d.TtsubsdhSessionNavigation).WithMany(p => p.TimeTableSubstitutionDetailsHistories)
                .HasForeignKey(d => d.TtsubsdhSessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstDetailsHistory_TimeTableSession");

            entity.HasOne(d => d.TtsubsdhSub).WithMany(p => p.TimeTableSubstitutionDetailsHistories)
                .HasForeignKey(d => d.TtsubsdhSubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstDetailsHistory_SubjectMaster");

            entity.HasOne(d => d.TtsubsdhTeacher).WithMany(p => p.TimeTableSubstitutionDetailsHistoryTtsubsdhTeachers)
                .HasForeignKey(d => d.TtsubsdhTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstDetailsHistory_EmpMaster");

            entity.HasOne(d => d.TtsubsdhTeacherIdNewNavigation).WithMany(p => p.TimeTableSubstitutionDetailsHistoryTtsubsdhTeacherIdNewNavigations)
                .HasForeignKey(d => d.TtsubsdhTeacherIdNew)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeTableSubstDetailsHistory_EmpMasterNewTeacher");
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.UserCmpId).HasColumnName("USER_CMP_ID");
            entity.Property(e => e.UserDesignation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_DESIGNATION");
            entity.Property(e => e.UserEmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_EMAIL_ADDRESS");
            entity.Property(e => e.UserFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_FIRST_NAME");
            entity.Property(e => e.UserIsSuperUser).HasColumnName("USER_IS_SUPER_USER");
            entity.Property(e => e.UserLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_LAST_NAME");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(256)
                .HasColumnName("USER_PASSWORD");
            entity.Property(e => e.UserRoleId).HasColumnName("USER_ROLE_ID");
            entity.Property(e => e.UserSchId).HasColumnName("USER_SCH_ID");
            entity.Property(e => e.UserUsername)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USER_USERNAME");

            entity.HasOne(d => d.UserRole).WithMany(p => p.UserDetails)
                .HasForeignKey(d => d.UserRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserDetails_UserRoles");
        });

        modelBuilder.Entity<VehicleExpenseDetail>(entity =>
        {
            entity.HasKey(e => e.VehexpId);

            entity.Property(e => e.VehexpId).HasColumnName("VEHEXP_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.VehexpAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VEHEXP_AMOUNT");
            entity.Property(e => e.VehexpCmpId).HasColumnName("VEHEXP_CMP_ID");
            entity.Property(e => e.VehexpDate)
                .HasColumnType("datetime")
                .HasColumnName("VEHEXP_DATE");
            entity.Property(e => e.VehexpDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("VEHEXP_DESC");
            entity.Property(e => e.VehexpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEHEXP_NAME");
            entity.Property(e => e.VehexpSchId).HasColumnName("VEHEXP_SCH_ID");
            entity.Property(e => e.VehexpTypeId).HasColumnName("VEHEXP_TYPE_ID");
            entity.Property(e => e.VehexpVehicelId).HasColumnName("VEHEXP_VEHICEL_ID");

            entity.HasOne(d => d.VehexpVehicel).WithMany(p => p.VehicleExpenseDetails)
                .HasForeignKey(d => d.VehexpVehicelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VehicleExpenseDetails_VehicleMaster");
        });

        modelBuilder.Entity<VehicleMaster>(entity =>
        {
            entity.HasKey(e => e.VehId).HasName("PK_Veh");

            entity.ToTable("VehicleMaster");

            entity.Property(e => e.VehId).HasColumnName("VEH_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.VehCmpId).HasColumnName("VEH_CMP_ID");
            entity.Property(e => e.VehInsuranceCompany)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEH_INSURANCE_COMPANY");
            entity.Property(e => e.VehInsurancePremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VEH_INSURANCE_PREMIUM");
            entity.Property(e => e.VehMake)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEH_MAKE");
            entity.Property(e => e.VehModel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEH_MODEL");
            entity.Property(e => e.VehNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEH_NUMBER");
            entity.Property(e => e.VehRegistration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEH_REGISTRATION");
            entity.Property(e => e.VehSchId).HasColumnName("VEH_SCH_ID");
            entity.Property(e => e.VehSeatCapacity).HasColumnName("VEH_SEAT_CAPACITY");
            entity.Property(e => e.VehType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEH_TYPE");
        });

        modelBuilder.Entity<VendorMaster>(entity =>
        {
            entity.HasKey(e => e.VendorId);

            entity.ToTable("VendorMaster");

            entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.VendorAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VENDOR_ADDRESS");
            entity.Property(e => e.VendorCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_CITY");
            entity.Property(e => e.VendorCityId).HasColumnName("VENDOR_CITY_ID");
            entity.Property(e => e.VendorCmpId).HasColumnName("VENDOR_CMP_ID");
            entity.Property(e => e.VendorDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("VENDOR_DESC");
            entity.Property(e => e.VendorEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_EMAIL");
            entity.Property(e => e.VendorMobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_MOBILE_PHONE");
            entity.Property(e => e.VendorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_NAME");
            entity.Property(e => e.VendorPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_PHONE");
            entity.Property(e => e.VendorSchId).HasColumnName("VENDOR_SCH_ID");
            entity.Property(e => e.VendorState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_STATE");
            entity.Property(e => e.VendorStateId).HasColumnName("VENDOR_STATE_ID");
            entity.Property(e => e.VendorZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_ZIPCODE");
        });

        modelBuilder.Entity<VisitorMaster>(entity =>
        {
            entity.HasKey(e => e.VmId).HasName("PK_VisitorMaster\\");

            entity.ToTable("VisitorMaster");

            entity.Property(e => e.VmId).HasColumnName("VM_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.VmAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("VM_ADDRESS");
            entity.Property(e => e.VmCmpId).HasColumnName("VM_CMP_ID");
            entity.Property(e => e.VmContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VM_CONTACT_NUMBER");
            entity.Property(e => e.VmContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VM_CONTACT_PERSON");
            entity.Property(e => e.VmDate)
                .HasColumnType("datetime")
                .HasColumnName("VM_DATE");
            entity.Property(e => e.VmName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VM_NAME");
            entity.Property(e => e.VmNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VM_NUMBER");
            entity.Property(e => e.VmPurpose)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("VM_PURPOSE");
            entity.Property(e => e.VmSchId).HasColumnName("VM_SCH_ID");
            entity.Property(e => e.VmTimeOfArrival)
                .HasPrecision(0)
                .HasColumnName("VM_TIME_OF_ARRIVAL");
            entity.Property(e => e.VmTimeOfExit)
                .HasPrecision(0)
                .HasColumnName("VM_TIME_OF_EXIT");
        });

        modelBuilder.Entity<VoucherMaster>(entity =>
        {
            entity.HasKey(e => e.VoucherId);

            entity.ToTable("VoucherMaster");

            entity.Property(e => e.VoucherId).HasColumnName("VOUCHER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.VoucherAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VOUCHER_AMOUNT");
            entity.Property(e => e.VoucherCmpId).HasColumnName("VOUCHER_CMP_ID");
            entity.Property(e => e.VoucherDate)
                .HasColumnType("datetime")
                .HasColumnName("VOUCHER_DATE");
            entity.Property(e => e.VoucherDescription)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VOUCHER_DESCRIPTION");
            entity.Property(e => e.VoucherExpenseCategoryId).HasColumnName("VOUCHER_EXPENSE_CATEGORY_ID");
            entity.Property(e => e.VoucherName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VOUCHER_NAME");
            entity.Property(e => e.VoucherNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VOUCHER_NUMBER");
            entity.Property(e => e.VoucherSchId).HasColumnName("VOUCHER_SCH_ID");

            entity.HasOne(d => d.VoucherExpenseCategory).WithMany(p => p.VoucherMasters)
                .HasForeignKey(d => d.VoucherExpenseCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherMaster_ExpenseCategoryMaster");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
