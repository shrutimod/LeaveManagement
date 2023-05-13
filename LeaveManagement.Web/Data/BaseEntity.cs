namespace LeaveManagement.Web.Data
{
    //It consists of the properties which are needed in multiple classes
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
