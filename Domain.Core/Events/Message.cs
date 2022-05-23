using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Events
{
	public abstract class Message : IRequest<bool> //Request is expecting a bool variable back
	{
		public string MessageType { get; protected set; }
		protected Message()
		{
			MessageType = GetType().Name;
		}
	}
}
