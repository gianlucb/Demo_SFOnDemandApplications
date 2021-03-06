// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Como.SDK.Models
{
    using Como.SDK;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CustomEvent
    {
        /// <summary>
        /// Initializes a new instance of the CustomEvent class.
        /// </summary>
        public CustomEvent()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomEvent class.
        /// </summary>
        public CustomEvent(string id = default(string), string name = default(string), string description = default(string), System.DateTime? startDate = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

    }
}
