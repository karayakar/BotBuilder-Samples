﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook_Events_Bot.FacebookModel
{

    /// <summary>
    /// Definition for Facebook PostBack payload. Present on calls from
    /// messaging_postback webhook event.
    /// </summary>
    /// <remarks>See <see cref="https://developers.facebook.com/docs/messenger-platform/reference/webhook-events/messaging_postbacks/"> Facebook messaging_postback</see> webhook event documentation.</remarks>
    public class FacebookPostback
    {
        /// <summary>
        /// Payload of the PostBack. Could be an object depending on the object sent.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or sets the title of the postback.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}