namespace BepuUtilities.ECS.Components.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BepuUtilities.ECS.Components.Structs.Memory;
    using BepuUtilities.Memory;

    public static class WorldExtensions
    {
        public static ref BufferPoolComponent GetBufferPoolComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<BufferPoolComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<BufferPoolComponent>();
        }

        public static BufferPool GetBufferPoolLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<BufferPoolComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<BufferPoolComponent>().Value)
                .Last();
        }
    }
}