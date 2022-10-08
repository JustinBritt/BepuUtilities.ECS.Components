namespace BepuUtilities.ECS.Components.AbstractFactories
{
    using BepuUtilities.ECS.Components.Factories.Memory;
    using BepuUtilities.ECS.Components.InterfacesAbstractFactories;
    using BepuUtilities.ECS.Components.InterfacesFactories.Memory;

    public sealed class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public static IAbstractFactory Create()
        {
            return new AbstractFactory();
        }

        public IBufferPoolComponentFactory CreateBufferPoolComponentFactory()
        {
            IBufferPoolComponentFactory factory = null;

            try
            {
                factory = new BufferPoolComponentFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}