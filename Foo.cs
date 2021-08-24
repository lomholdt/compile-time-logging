// namespace Foo
// {
//     internal static partial class Log
//     {
//         [LoggerMessage(17, LogLevel.Debug, "Writing the requested range of bytes to the body.", EventName = "WritingRangeToBody")]
//         public static partial void WritingRangeToBody(ILogger logger);
//     }
// }

namespace Foo;

internal static partial class Log
{
    [LoggerMessage(17, LogLevel.Debug, "Writing the requested range of bytes to the body.", EventName = "WritingRangeToBody")]
    public static partial void WritingRangeToBody(ILogger logger);
}
