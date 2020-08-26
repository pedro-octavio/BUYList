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

            builder.RegisterType<ItemService>().As<IItemService>();

            builder.RegisterType<ItemRepository>().As<IItemRepository>();

            builder.RegisterType<ItemValidator>().As<IValidator<Item>>();
        }
    }
}
