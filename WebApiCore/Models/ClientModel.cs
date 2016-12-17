using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace WebApiCore.Models
{
    public class ClientModel
    {
        [DataContract]
        public partial class ClientModel : IEquatable<ClientModel>
        {
            public ClientModel(string ClientCode = null, string MU = null)
            {
                this.ClientCode = ClientCode;
                this.MU = MU;
            }

            [DataMember(Name = "client_code")]
            public string ClientCode { get; set; }

            [DataMember(Name = "MU")]
            public string MU { get; set; }


            /// <summary>
            /// Returns the string presentation of the object
            /// </summary>
            /// <returns>String presentation of the object</returns>
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("class Client {\n");
                sb.Append("  ClientCode: ").Append(ClientCode).Append("\n");
                sb.Append("  MU: ").Append(MU).Append("\n");
                sb.Append("}\n");
                return sb.ToString();
            }

            /// <summary>
            /// Returns the JSON string presentation of the object
            /// </summary>
            /// <returns>JSON string presentation of the object</returns>
            public string ToJson()
            {
                return JsonConvert.SerializeObject(this, Formatting.Indented);
            }

            /// <summary>
            /// Returns true if objects are equal
            /// </summary>
            /// <param name="obj">Object to be compared</param>
            /// <returns>Boolean</returns>
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != GetType()) return false;
                return Equals((Client)obj);
            }

            /// <summary>
            /// Returns true if Client instances are equal
            /// </summary>
            /// <param name="other">Instance of Client to be compared</param>
            /// <returns>Boolean</returns>
            public bool Equals(Client other)
            {

                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;

                return
                    (
                        this.ClientCode == other.ClientCode ||
                        this.ClientCode != null &&
                        this.ClientCode.Equals(other.ClientCode)
                    ) &&
                    (
                        this.MU == other.MU ||
                        this.MU != null &&
                        this.MU.Equals(other.MU)
                    );
            }

            /// <summary>
            /// Gets the hash code
            /// </summary>
            /// <returns>Hash code</returns>
            public override int GetHashCode()
            {
                // credit: http://stackoverflow.com/a/263416/677735
                unchecked // Overflow is fine, just wrap
                {
                    int hash = 41;
                    // Suitable nullity checks etc, of course :)
                    if (this.ClientCode != null)
                        hash = hash * 59 + this.ClientCode.GetHashCode();
                    if (this.MU != null)
                        hash = hash * 59 + this.MU.GetHashCode();
                    return hash;
                }
            }

            #region Operators

            public static bool operator ==(Client left, Client right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(Client left, Client right)
            {
                return !Equals(left, right);
            }

            #endregion Operators

        }
    }
}