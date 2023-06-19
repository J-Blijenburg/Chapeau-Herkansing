using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ISplittDisplay
    {
        //bool Update() => false;
        void Update(Receipt receipt);
    }
}
