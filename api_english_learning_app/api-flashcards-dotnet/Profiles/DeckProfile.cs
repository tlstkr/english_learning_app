using System;
using System.Collections.Generic;
using english_learning_app.Dtos;
using english_learning_app.Dtos.Models;
using english_learning_app.Models;
using AutoMapper;

namespace english_learning_app.Profiles
{
    public class DeckProfile:Profile
    {
        public DeckProfile()
        {
            CreateMap<Deck, DeckResponseDto>()
                .ForMember(dest => dest.TotalCards, opt => opt.MapFrom( src => src.Cards.Count));
            CreateMap<List<Deck>, DeckResponse>()
                .ForMember(dest => dest.Decks, opt => opt.MapFrom(src => src));
        }
    }
}
