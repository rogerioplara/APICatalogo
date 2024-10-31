using APICatalogo.Models;
using APICatalogo.Pagination;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using X.PagedList;

namespace APICatalogo.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IPagedList<Produto>> GetProdutosAsync(ProdutosParameters produtosParams);
        Task<IPagedList<Produto>> GetProdutosFiltroPrecoAsync(ProdutosFiltroPreco produtosFiltroParams);
        Task<IEnumerable<Produto>> GetProdutosPorCategoriaAsync(int id);
    }
}
