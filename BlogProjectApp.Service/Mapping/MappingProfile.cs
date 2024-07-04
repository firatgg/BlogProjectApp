using AutoMapper;
using BlogProjectApp.DataAccess.Identity;
using BlogProjectApp.Entity.Entities;
using BlogProjectApp.Entity.ViewModels;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Service.Mapping
{
	public class MappingProfile:Profile
	{
        public MappingProfile()
        {
            CreateMap<Article,ArticleViewModel>().ReverseMap();
            CreateMap<Category,CategoryViewModel>().ReverseMap();
			CreateMap<Comment, CommentViewModel>().ReverseMap();
			CreateMap<AppUser, UserViewModel>().ReverseMap();
			CreateMap<AppUser, LoginViewModel>().ReverseMap();




		}
	}
}
