using AutoMapper;
using BlogProjectApp.Entity.Entities;
using BlogProjectApp.Entity.Services;
using BlogProjectApp.Entity.UnitOfWorks;
using BlogProjectApp.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Service.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CommentService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task Add(CommentViewModel model)
        {
            Comment comment = new Comment();
            comment = _mapper.Map<Comment>(model);
            await _uow.GetRepository<Comment>().Add(comment);
            await _uow.CommitAsync();
        }

        public async Task<List<CommentViewModel>> GetAllByArticleId(int id)
        {
            var list = await _uow.GetRepository<Comment>().GetAll(c => c.ArticleId == id);
            return _mapper.Map<List<CommentViewModel>>(list);
        }
    }
}
