using Lanches.Project.Models;

namespace Lanches.Project.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> lancheList { get; set; }

        public string categoriaAtual { get; set; }
    }
}
