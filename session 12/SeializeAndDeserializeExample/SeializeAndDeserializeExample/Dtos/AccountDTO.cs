using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeializeAndDeserializeExample.Dtos
{
    [Serializable]
    public class AccountDTO
    {
        public int AccountNumber { get; set; }

        public string Name { get; set; }

        public double Balance { get; set; }

    }
}
