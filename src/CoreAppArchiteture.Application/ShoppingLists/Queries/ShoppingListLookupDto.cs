using AutoMapper;
using CoreAppArchiteture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text; 

namespace CoreAppArchiteture.Application.ShoppingLists.Queries
{
    public class ShoppingListLookupDto : IMapFrom<ShoppingList>
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; }

        public long Amount { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ShoppingList, ShoppingListLookupDto>();
            //profile.CreateMap<ShoppingList, ShoppingListLookupDto>().ForMember(d => d.ID, opt => opt.MapFrom(s => s.ID));
        }
    }
}
