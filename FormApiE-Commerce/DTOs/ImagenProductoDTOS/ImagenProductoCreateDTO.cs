using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.ImagenProductoDTOS
{
    public class ImagenProductoCreateDTO
    {
        [Required(ErrorMessage = "La URL de la imagen es obligatoria.")]
        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "El ID del producto es obligatorio.")]
        public int ProductoId { get; set; }
    }
}
