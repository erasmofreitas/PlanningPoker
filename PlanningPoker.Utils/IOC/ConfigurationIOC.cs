using Autofac;
using PlanningPoker.Application.Interfaces;
using PlanningPoker.Application.Services;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.CrossCutting.Mappings;
using PlanningPoker.Data.Repositories;
using PlanningPoker.Domain.Interfaces.Repositories;
using PlanningPoker.Domain.Interfaces.Services;
using PlanningPoker.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.IOC
{
   public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCartas>().As<ICartasApplication>();
            builder.RegisterType<ApplicationServiceHistorias>().As<IHistoriasApplication>();
            builder.RegisterType<ApplicationServiceUsuarios>().As<IUsuariosApplication>();
            builder.RegisterType<ApplicationServiceVotos>().As<IVotosApplication>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCartas>().As<IServiceCartas>();
            builder.RegisterType<IServiceHistorias>().As<IServiceHistorias>();
            builder.RegisterType<IServiceUsuarios>().As<IServiceUsuarios>();
            builder.RegisterType<IServiceVotos>().As<IServiceVotos>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCartas>().As<IRepositoryCartas>();
            builder.RegisterType<RepositoryHistorias>().As<IRepositoryHistorias>();
            builder.RegisterType<RepositoryUsuarios>().As<IRepositoryUsuarios>();
            builder.RegisterType<RepositoryVotos>().As<IRepositoryVotos>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCartas>().As<IMapperCartas>();
            builder.RegisterType<MapperHistorias>().As<IMapperHistorias>();
            builder.RegisterType<MapperUsuarios>().As<IMapperUsuarios>();
            builder.RegisterType<MapperVotos>().As<IMapperVotos>();
            #endregion

            #endregion

        }
    }
}
