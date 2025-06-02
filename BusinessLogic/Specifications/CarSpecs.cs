using Ardalis.Specification;
using DataAccess.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Specifications
{
    internal static class CarSpecs
    {
        internal class ById : Specification<Car>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Category);
            }
        }
        internal class All : Specification<Car>
        {
            public All()
            {
                Query.Include(x => x.Category);
            }
        }
        internal class ByIds : Specification<Car>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Category);
            }
        }
        internal class FilteredPagedSorted : Specification<Car>
        {
            public FilteredPagedSorted(int page, int pageSize, string? make, string? category, string? sortDirection)
            {
                Query.Include(x => x.Category);

                if (!string.IsNullOrWhiteSpace(make))
                {
                    Query.Where(c => c.Make.ToLower() == make.ToLower());
                }

                if (!string.IsNullOrWhiteSpace(category))
                {
                    Query.Where(c => c.Category.Name.ToLower() == category.ToLower());
                }

                if (!string.IsNullOrWhiteSpace(sortDirection) && sortDirection.ToLower() == "desc")
                {
                    Query.OrderByDescending(c => c.Price);
                }
                else
                {
                    Query.OrderBy(c => c.Price);
                }

                Query.Skip((page - 1) * pageSize).Take(pageSize);
            }
        }
        internal class FilteredCount : Specification<Car>
        {
            public FilteredCount(string? make, string? category)
            {
                if (!string.IsNullOrWhiteSpace(make))
                {
                    Query.Where(c => c.Make.ToLower() == make.ToLower());
                }

                if (!string.IsNullOrWhiteSpace(category))
                {
                    Query.Where(c => c.Category.Name.ToLower() == category.ToLower());
                }
            }
        }



    }
}
