using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppNTier.Dtos.WorkDtos;

namespace TodoAppNTier.Business.İnterfaces
{
    public interface IWorkService
    {
        Task<List<WorkListDto>> GetAll();

    }
}
