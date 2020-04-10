using System;
using System.Collections.Generic;
using english_learning_app.Dtos;
using english_learning_app.Dtos.Models;
using english_learning_app.Models;
using AutoMapper;

namespace english_learning_app.Profiles
{
    public class CardProfile:Profile
    {
        public CardProfile()
        {
            CreateMap<Card, CardResponseDto>();
            CreateMap<List<Card>, CardResponse>()
                .ForMember(dest => dest.Cards, opt => opt.MapFrom(src => src));
            
        }
    }
}
