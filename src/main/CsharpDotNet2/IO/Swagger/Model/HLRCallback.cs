using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class HLRCallback {
    /// <summary>
    /// Unique ID for response
    /// </summary>
    /// <value>Unique ID for response</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The MSISDN of the number queried
    /// </summary>
    /// <value>The MSISDN of the number queried</value>
    [DataMember(Name="msisdn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "msisdn")]
    public long? Msisdn { get; set; }

    /// <summary>
    /// Short status code of the response
    /// </summary>
    /// <value>Short status code of the response</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// ISO 3166-2 country code
    /// </summary>
    /// <value>ISO 3166-2 country code</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The operator attached to the MSISDN
    /// </summary>
    /// <value>The operator attached to the MSISDN</value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string _Operator { get; set; }

    /// <summary>
    /// MCC and MNC of MSDISDN
    /// </summary>
    /// <value>MCC and MNC of MSDISDN</value>
    [DataMember(Name="mccmnc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mccmnc")]
    public int? Mccmnc { get; set; }

    /// <summary>
    /// If the response code is temporary or permenant
    /// </summary>
    /// <value>If the response code is temporary or permenant</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public string Duration { get; set; }

    /// <summary>
    /// Full status code of the response
    /// </summary>
    /// <value>Full status code of the response</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Extended explanation of the status code
    /// </summary>
    /// <value>Extended explanation of the status code</value>
    [DataMember(Name="extended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extended")]
    public string Extended { get; set; }

    /// <summary>
    /// Cost of the response
    /// </summary>
    /// <value>Cost of the response</value>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public float? Cost { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HLRCallback {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Msisdn: ").Append(Msisdn).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  Mccmnc: ").Append(Mccmnc).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Extended: ").Append(Extended).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
