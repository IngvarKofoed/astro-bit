using System.Collections.Generic;

namespace AstroBit.Svg
{
    public static class PathBuilderExtensions
    {
        public static PathBuilder ToBuilder(this IEnumerable<IPathCommand> commands) =>
            new PathBuilder(commands);
    }
}
