namespace BepuUtilities.ECS.Components.InterfacesAbstractFactories
{
    using BepuUtilities.ECS.Components.InterfacesFactories.Memory;

    public interface IAbstractFactory
    {
        IBufferPoolComponentFactory CreateBufferPoolComponentFactory();
    }
}