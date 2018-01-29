using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterDemo
{
    public interface IRegister
    {
        void AddItem(double item);
        int GetNItems();
        double GetTotal();
    }
}
