using AutoMapper;
using EfCoreDemo.DTO;
using EfCoreDemo.Models;
namespace EfCoreDemo.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoResponseDTO>();
            CreateMap<ProdutoRequestDTO, Produto>();
        }
    }
}
