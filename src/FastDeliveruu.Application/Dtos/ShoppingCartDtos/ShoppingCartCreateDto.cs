using System.ComponentModel.DataAnnotations;

namespace FastDeliveruu.Application.Dtos.ShoppingCartDtos;

public class ShoppingCartCreateDto
{
    [Required]
    public int MenuItemId { get; set; }

    [Required(ErrorMessage = "Vui lòng chọn số lượng.")]
    public int Quantity { get; set; }
}