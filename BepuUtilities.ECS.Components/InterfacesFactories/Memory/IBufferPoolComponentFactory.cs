namespace BepuUtilities.ECS.Components.InterfacesFactories.Memory
{
    using BepuUtilities.ECS.Components.Structs.Memory;
    using BepuUtilities.Memory;

    public interface IBufferPoolComponentFactory
    {
        BufferPoolComponent Create(
            BufferPool value);
    }
}