using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace english_learning_app.Services.Models.ErrorHandling
{
    public class Errors
    {
        [JsonProperty("Errors")]
        public ErrorItems ErrorItems { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string TraceId { get; set; }
    }
}
