using System.Collections.ObjectModel;
using AspNetCore;
using SandwichApp.Context;

namespace SandwichApp.Models
{
    public class CarBuy
    {
        private readonly SandwichContext _context;
        public CarBuy(SandwichContext context)
        {
            _context = context;
            CarBuyItems = new Collection<CarBuyItem>();
        }
        public string CarBuyId { get; set; }
        public ICollection<CarBuyItem> CarBuyItems { get; set; }

        public static CarBuy GetCarBuy(IServiceProvider service)
        {
            //Define uma session
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Obtem um servico do tipo do nosso context
            var context = service.GetService<SandwichContext>();

            //Obtem ou gera o Id do carrinho
            string carBuyId = session.GetString("CarBuyId") ?? Guid.NewGuid().ToString();

            //Atribui o id do carrinho na Session
            session.SetString("CarBuyId", carBuyId);

            //Retorna o carrinho com o context e o Id atribuido ou obtido
            return new CarBuy(context) { CarBuyId = carBuyId };
        }
    }
}