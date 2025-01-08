using System.ComponentModel.DataAnnotations;

namespace VideosAPI.Data.Dtos;

public class CreateVideoDto
{
    [Required(ErrorMessage = "O nome do vídeo é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do vídeo é obrigatória")]
    [MaxLength(100, ErrorMessage = "O tamanho da descrição do vídeo não pode passar de 100 caracteres")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "A URL é obrigatória")]
    [DataType(DataType.Url)]
    public string Url { get; set; }
}
