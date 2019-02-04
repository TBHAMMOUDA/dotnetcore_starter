using AutoMapper;

namespace GMAO.Service.Binding
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
              //  cfg.AddProfile(new InvoiceProfile());
                cfg.ValidateInlineMaps = false;
            });
        }

        public static TDestination ApplyAutoMap<TDestination, TSource>(TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public static TDesination ApplyAutoMap<TSource, TDesination>(TSource source, TDesination destination)
        {
            return Mapper.Map(source, destination);
        }
    }
}
