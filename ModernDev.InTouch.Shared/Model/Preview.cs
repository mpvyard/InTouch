﻿/**
 * This file\code is part of InTouch project.
 *
 * InTouch - is a .NET wrapper for the vk.com API.
 * https://github.com/virtyaluk/InTouch
 *
 * Copyright (c) 2016 Bohdan Shtepan
 * http://modern-dev.com/
 *
 * Licensed under the GPLv3 license.
 */

using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// Document preview info.
    /// </summary>
    [DataContract]
    [DebuggerDisplay("Preview")]
    public class Preview
    {
        /// <summary>
        /// Photo to preview.
        /// </summary>
        [DataMember]
        [JsonProperty("photo")]
        public Photo Photo { get; set; }

        /// <summary>
        /// Video to preview.
        /// </summary>
        [DataMember]
        [JsonProperty("video")]
        public VideoPreview Video { get; set; }

        /// <summary>
        /// Graffiti info.
        /// </summary>
        [DataMember]
        [JsonProperty("graffiti")]
        public GraffitiPreview Graffiti { get; set; }

        /// <summary>
        /// Audio message info.
        /// </summary>
        [DataMember]
        [JsonProperty("audio_msg")]
        public AudioMessage AudioMessage { get; set; }
    }
}