using AutoMapper;
using Demo.Application.Common.Interfaces;
using Demo.Domain.Entities;
using Demo.Infrastructure.Interface;
using Demo.Infrastructure.Shared;
using Demo.Infrastructure.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Services
{
    public class NewsService: INewsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Pagination<NewsVM>> Get(int pageIndex, int pageSize)
        {
             var news = await _unitOfWork.NewsRepository.ToPagination(
                 pageIndex: pageIndex,
                 pageSize: pageSize,
                 orderBy: x => x.Title,
                 ascending: true,
                 selector: x => new NewsVM
                 {
                     Id = x.ID,
                     Title = x.Title,
                 }
             );

            return news;
        }
    }
}
