// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Como.SDK
{
    using Como.Model;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ComoClusterFrontEndAPIs.
    /// </summary>
    public static partial class ComoClusterFrontEndAPIsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventId'>
            /// </param>
            public static Agenda V1AgendaGet(this IComoClusterFrontEndAPIs operations, string eventId = default(string))
            {
                return operations.V1AgendaGetAsync(eventId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='eventId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Agenda> V1AgendaGetAsync(this IComoClusterFrontEndAPIs operations, string eventId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.V1AgendaGetWithHttpMessagesAsync(eventId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='agenda'>
            /// </param>
            public static bool? V1AgendaPut(this IComoClusterFrontEndAPIs operations, Agenda agenda = default(Agenda))
            {
                return operations.V1AgendaPutAsync(agenda).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='agenda'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> V1AgendaPutAsync(this IComoClusterFrontEndAPIs operations, Agenda agenda = default(Agenda), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.V1AgendaPutWithHttpMessagesAsync(agenda, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evt'>
            /// </param>
            public static string V1EventsPut(this IComoClusterFrontEndAPIs operations, CustomEvent evt = default(CustomEvent))
            {
                return operations.V1EventsPutAsync(evt).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='evt'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> V1EventsPutAsync(this IComoClusterFrontEndAPIs operations, CustomEvent evt = default(CustomEvent), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.V1EventsPutWithHttpMessagesAsync(evt, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
