using System;
using System.ComponentModel.DataAnnotations;

namespace OrdersWeb.Model
{
    public class OrderRow : IDbObject, ICloneable
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        public int NomenclatureId { get; set; }
        public Nomenclature Nomenclature { get; set; }
        [Required]
        public double Quantity { get; set; }

        ///////////////////////////////////////////////////////////////////////
        public object Clone()
        {
            var res = new OrderRow();
            res.Id = Id;
            res.OrderId = OrderId;
            res.Order = Order;
            res.Nomenclature = Nomenclature;
            res.NomenclatureId = NomenclatureId;
            res.Quantity = Quantity;
            return res;
        }
    }
}
