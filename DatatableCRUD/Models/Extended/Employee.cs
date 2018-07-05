using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatatableCRUD.Models
{

    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        
    }

    public class EmployeeMetadata
    {
        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("Nombre:")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("Apellido Paterno:")]
        [StringLength(60)]
        public string Apellido_Paterno { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("Apellido Materno:")]
        [StringLength(60)]
        public string Apellido_Materno { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("CURP:")]
        [RegularExpression("[0-9a-zA-Z]+$", ErrorMessage = "Solo se permiten letras y números")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "Formato incorrecto")]
        public string CURP { get; set; }
    }
}