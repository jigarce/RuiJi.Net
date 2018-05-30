﻿using Newtonsoft.Json;
using RuiJi.Core.Extensions;
using RuiJi.Core.Extracter;
using RuiJi.Core.Extracter.Selector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuiJi.Node.Feed
{
    public enum RuleTypeEnum
    {
        HTML,
        JSON,
        JSONP,
        XML
    }

    public class RuleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(EnumConvert<RuleTypeEnum>))]
        public RuleTypeEnum Type { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("feature")]
        public string Feature { get; set; }

        [JsonProperty("block")]
        public string BlockExpression { get; set; }

        [JsonProperty("rexp")]
        public string RuiJiExpression { get; set; }

    }
}