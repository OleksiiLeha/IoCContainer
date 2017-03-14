using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Lesson2_Flow
{
	class StrMap_IoC
	{
		private static readonly object LockObject = new object();
		private static StrMap_IoC currentApplicationInstance = new StrMap_IoC();

		private readonly IContainer container;

		private StrMap_IoC()
		{
			container = new Container();
			container.Configure(x => x.For<IContainer>().Singleton().Use(container));
		}

		public static bool IsInitialized { get; private set; }

		public static StrMap_IoC Current
		{
			get { return currentApplicationInstance; }
		}

		public IContainer Container
		{
			get { return container; }
		}

		public static StrMap_IoC Initialize(Action<ConfigurationExpression> configurationAction)
		{
			lock (LockObject)
			{
				currentApplicationInstance = new StrMap_IoC();
				Current.Container.Configure(configurationAction);
				IsInitialized = true;
			}
			return Current;
		}
	}
}
