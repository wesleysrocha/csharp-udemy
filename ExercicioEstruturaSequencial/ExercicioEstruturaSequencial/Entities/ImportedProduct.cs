using System.Globalization;

namespace ExercicioEstruturaSequencial.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        //contrutor vazio
        public ImportedProduct()
        {
        }
        //construtor pra nao repitir, usa o base
        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        //ToString muda a exibição no terminal 
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}