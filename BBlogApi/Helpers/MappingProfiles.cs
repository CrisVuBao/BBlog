﻿using AutoMapper;
using BBlogApi.DTOs;
using BBlogApi.Models;

namespace BBlogApi.Helpers
{
	public class MappingProfiles : Profile
	{
        public MappingProfiles()
        {
            CreateMap<Post, PostDto>().ReverseMap(); // ánh xạ từ Post qua PostDto, ReverseMap là ánh xạ 2 chiều
        }
    }
}
