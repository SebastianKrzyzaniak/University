using Autofac;
using System;
using TicTacToe.BusinessLayer.BusinessLayer.Service.ControlsService;
using TicTacToe.BusinessLayer.Repository;
using TicTacToe.BusinessLayer.Repository.Interaces;
using TicTacToe.BusinessLayer.Service.ControlsService.Interfaces;
using TicTacToe.BusinessLayer.Service.GameService;
using TicTacToe.BusinessLayer.Service.GameService.Interfaces;
using TicTacToe.Mapping;
using TicTacToe.Mapping.Interfaces;
using TicTacToe.Popup;
using TicTacToe.Popup.Validate;
using TicTacToe.Popup.Validate.Interfaces;

namespace TicTacToe.Bootstraper
{
    public class DIContainer
    {
        private IContainer _container;

        public DIContainer()
        {
            Initialize();
        }

        private void Initialize()
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterType<ControlsRepository>()
                .As<IControlsRepository>();

            builder
               .RegisterType<ControlsPrepare>()
               .As<IControlsPrepare>();

            builder
               .RegisterType<ValidateTextBoxData>()
               .As<IValidateTextBoxData>();

            builder
              .RegisterType<Judge>()
              .As<IJudge>()
              .SingleInstance();

            builder
                .RegisterType<ControlsMapping>()
                .As<IControlsMapping>()
                .SingleInstance();

            builder
               .RegisterType<TurnLogic>()
               .As<ITurnLogic>()
               .SingleInstance();

            builder
                .RegisterType<GameConnection>()
                .As<IGameConnection>()
                .SingleInstance();

            builder
              .RegisterType<SocketConnection>()
              .As<ISocketConnection>()
              .SingleInstance();


            builder
               .RegisterType<MainBackground>()
               .AsSelf()
               .SingleInstance();

            builder
               .RegisterType<StartPopup>()
               .AsSelf()
               .SingleInstance();

            builder
               .RegisterType<WaitingForConnection>()
               .AsSelf();

            builder
              .RegisterType<MessageForm>()
              .AsSelf();

            _container = builder.Build();
        }

        public TService Resolve<TService>() where TService: class
        {
            TService service;

            return _container.TryResolve(out service) 
                ? service 
                : throw new ArgumentException($"Given argument type [{typeof(TService)}] cannot be resolved");
        }

        public bool TryResolve<TService>(out TService service) where TService : class
        {
            try
            {
                service = Resolve<TService>();

                return true;
            }
            catch (ArgumentException argExc)
            {
                service = default(TService);
                return false;
            }
        }
    }
}
