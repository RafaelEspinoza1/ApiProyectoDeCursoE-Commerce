using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.ImagenProductoDTOS
{
    public class ImagenProductoUpdateDTO
    {
        [Required(ErrorMessage = "La URL de la imagen es obligatoria.")]
        public string ImagenUrl { get; set; }
    }
}
