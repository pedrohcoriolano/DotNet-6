using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Project.Models
{
    [Table("Lanches")]   
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O tamanho máximo deste campo é 80 caracteres")]
        [Required(ErrorMessage = "Digite o nome do lanche")]
        [Display(Name = "Nome")]
        public string NomeLanche { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho máximo deste campo é 200 caracteres")]
        [Required(ErrorMessage = "Digite a descriçao curta do lanche")]
        [Display(Name = "Descrição Curta")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho máximo deste campo é 200 caracteres")]
        [Required(ErrorMessage = "Digite a Descriçao Detalhada do lanche")]
        [Display(Name = "Descriçao Detalhada")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Digite o preço")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999.99 Reais")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho máximo deste campo é 200 caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Thumbnail")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho máximo deste campo é 200 caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido ?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
