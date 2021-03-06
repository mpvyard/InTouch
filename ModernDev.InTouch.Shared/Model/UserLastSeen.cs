/**
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

using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using ModernDev.InTouch.Helpers;
using Newtonsoft.Json;

namespace ModernDev.InTouch
{
    /// <summary>
    /// Last visit date.
    /// </summary>
    [DebuggerDisplay("UserLastSeen {Time} {Platform}")]
    [DataContract]
    public class UserLastSeen
    {
        /// <summary>
        /// Last visit date (in Unix time).
        /// </summary>
        [DataMember]
        [JsonProperty("time")]
        [JsonConverter(typeof(JsonNumberDateTimeConverter))]
        public DateTime Time { get; set; }

        /// <summary>
        /// Type of the platform that used for the last authorization.
        /// </summary>
        [DataMember]
        [JsonProperty("platform")]
        public int? Platform { get; set; }
    }
}