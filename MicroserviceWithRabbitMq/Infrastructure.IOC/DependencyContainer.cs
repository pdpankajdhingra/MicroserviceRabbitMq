using Domain.Core.Bus;
using Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.IOC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			services.AddTransient<IEventBus, RabbitMQBus>();
		}
	}
}
