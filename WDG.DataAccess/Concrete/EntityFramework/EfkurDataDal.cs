using WDG.Core.DataAccess.EntityFramework;
using WDG.DataAccess.Abstract;
using WDG.Entities.Concrete;

namespace WDG.DataAccess.Concrete.EntityFramework
{
    public class EfkurDataDal : EfEntityRepositoryBase<kurData,WDGContext>, IkurDataDal
    {
    }
}
