using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersWeb.Model
{
    public interface IDbObject
    {
        int Id { get; set; }
        string ToString();
    }
}
