using System.ComponentModel.DataAnnotations;

namespace SignUpApi.Model
{
    public class Operator
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        public string Description { get; set; }
        [Required]
        public string FatherName { get; set; }

      


    }
}
