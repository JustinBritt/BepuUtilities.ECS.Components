namespace BepuUtilities.ECS.Components.Structs.Memory
{
    using BepuUtilities.Memory;

    public struct BufferPoolComponent
    {
        public BufferPoolComponent(
            BufferPool value)
        {
            this.Value = value;
        }

        public BufferPool Value { get; set; }
    }
}