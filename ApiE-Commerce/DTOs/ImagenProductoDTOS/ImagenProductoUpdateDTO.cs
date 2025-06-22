using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.ImagenProductoDTOS
{
    public class ImagenProductoUpdateDTO
    {
        [Required(ErrorMessage = "La URL de la imagen es obligatoria.")]
        public string ImagenUrl { get; set; }
    }
}
