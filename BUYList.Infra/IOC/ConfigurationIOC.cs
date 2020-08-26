using Autofac;
using BUYList.Application.Interfaces;
using BUYList.Application.Services;
using BUYList.Domain.Core.Interfaces.Repositories;
using BUYList.Domain.Core.Interfaces.Services;
using BUYList.Domain.Entities;
using BUYList.Domain.Services.Services;
using BUYList.Domain.Validators;
using BUYList.Infra.Data.Repositories;
using FluentValidation;

namespace BUYList.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load
        (ContainerBuilder builder)
        {
            builder.RegisterType<ItemApplicationService>().As<IItemApplicationService>();
            builder.RegisterType<UserApplicationService>().As<IUserApplicationService>();

            builder.RegisterType<ItemService>().As<IItemService>();
            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<ItemRepository>().As<IItemRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            builder.RegisterType<ItemValidator>().As<IValidator<Item>>();
            builder.RegisterType<UserValidator>().As<IValidator<User>>();
        }
    }
}
