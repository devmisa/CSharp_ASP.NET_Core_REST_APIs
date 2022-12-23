using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            _ = CreateMap<CreateFilmeDto, Filme>();
            _ = CreateMap<Filme, ReadFilmeDto>();
            _ = CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
