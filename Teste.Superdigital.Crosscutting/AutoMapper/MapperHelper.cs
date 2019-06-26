using AutoMapper;

namespace Teste.Superdigital.Crosscutting.AutoMapper
{
    public abstract class MapperHelper
    {
        public static MapperConfiguration CreateConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
        }
    }
}