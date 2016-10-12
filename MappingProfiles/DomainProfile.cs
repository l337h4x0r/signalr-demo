﻿namespace SignalRDemo.MappingProfiles
{
    using AutoMapper;
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>();

            CreateMap<CounterModel, Counter>();
            CreateMap<Counter, CounterModel>();
        }
    }
}
