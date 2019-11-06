using System;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using MicroRabbit.Domain.Core.Events;
using MicroRabbit.Domain.Core.Commands;
namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T comand) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
