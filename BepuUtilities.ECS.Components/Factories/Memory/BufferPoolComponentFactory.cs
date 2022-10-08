namespace BepuUtilities.ECS.Components.Factories.Memory
{
    using BepuUtilities.ECS.Components.InterfacesFactories.Memory;
    using BepuUtilities.ECS.Components.Structs.Memory;
    using BepuUtilities.Memory;

    internal sealed class BufferPoolComponentFactory : IBufferPoolComponentFactory
    {
        public BufferPoolComponentFactory()
        {
        }

        public BufferPoolComponent Create(
            BufferPool value)
        {
            BufferPoolComponent component = default;

            try
            {
                component = new BufferPoolComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}