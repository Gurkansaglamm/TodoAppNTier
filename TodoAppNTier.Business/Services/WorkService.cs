using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppNTier.Business.İnterfaces;
using TodoAppNTier.DataAccess.UnitofWork;
using TodoAppNTier.Dtos.WorkDtos;
using TodoAppNTier.Entities.Domains;

namespace TodoAppNTier.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;

        public WorkService(IUow uow)
        {
            _uow = uow;
        }

        public async Task<List<WorkListDto>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();

            var worklist = new List<WorkListDto>();

            if (list != null && list.Count > 0)
            {
                foreach(var work in list)
                {
                    worklist.Add(new() { 
                        Definition = work.Definition,
                        Id = work.Id,
                        IsCompleted = work.IsCompleted,


                    });



                }
            }
            return worklist;

        }
    }
}
