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
  public class HLRResult {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Success
    /// </summary>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public List<long?> Success { get; set; }

    /// <summary>
    /// Gets or Sets Failure
    /// </summary>
    [DataMember(Name="failure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failure")]
    public List<long?> Failure { get; set; }

    /// <summary>
    /// Cost of the response
    /// </summary>
    /// <value>Cost of the response</value>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public float? Cost { get; set; }

    /// <summary>
    /// Callback URL provided
    /// </summary>
    /// <value>Callback URL provided</value>
    [DataMember(Name="callback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback")]
    public string Callback { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HLRResult {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Failure: ").Append(Failure).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Callback: ").Append(Callback).Append("\n");
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
