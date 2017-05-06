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
  public class SMSResult {
    /// <summary>
    /// Unique ID for response
    /// </summary>
    /// <value>Unique ID for response</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Count of queued SMS
    /// </summary>
    /// <value>Count of queued SMS</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public int? Success { get; set; }

    /// <summary>
    /// Cost of the SMS
    /// </summary>
    /// <value>Cost of the SMS</value>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public float? Cost { get; set; }

    /// <summary>
    /// Total count of SMS queued
    /// </summary>
    /// <value>Total count of SMS queued</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// List of failed numbers
    /// </summary>
    /// <value>List of failed numbers</value>
    [DataMember(Name="failure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failure")]
    public List<string> Failure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SMSResult {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Failure: ").Append(Failure).Append("\n");
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
