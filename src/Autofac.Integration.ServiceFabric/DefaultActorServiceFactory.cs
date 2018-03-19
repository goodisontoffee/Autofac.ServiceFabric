using System;
using System.Fabric;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;

namespace Autofac.Integration.ServiceFabric
{
    public class DefaultActorServiceFactory : IActorServiceFactory
    {
        public ActorService Create(
            StatefulServiceContext context,
            ActorTypeInformation actorTypeInfo,
            Func<ActorService, ActorId, ActorBase> actorFactory = null,
            Func<ActorBase, IActorStateProvider, IActorStateManager> stateManagerFactory = null,
            IActorStateProvider stateProvider = null,
            ActorServiceSettings settings = null)
        {
            return new ActorService(
                context,
                actorTypeInfo,
                actorFactory,
                stateManagerFactory,
                stateProvider,
                settings);
        }
    }
}