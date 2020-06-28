using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Utils;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Loja.Testes.ConsoleApp.DAO
{
    public abstract class BaseDAO
    {
        protected LojaContext Context;
        public BaseDAO(LojaContext context)
        {
            Context = context;
            var serviceProvider = Context.GetInfrastructure<IServiceProvider>();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(SqlLoggerProvider.Create());
        }
    }
}
