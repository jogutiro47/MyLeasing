namespace MyLeasing.Web.Data.Entities
{
    public class Manager
    {

        public int Id { get; set; }

        //Hereda los campos de la Tabla User
        public User User { get; set; }

    }
}
