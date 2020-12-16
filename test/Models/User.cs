using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
