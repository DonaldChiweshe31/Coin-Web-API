using System; 
using System.Collections.Generic; 
using System.Linq;
 using System.Runtime.Serialization; 
 using System.Web; 
 namespace CoinJarAPI.Models 
 { 
 [DataContract] 
 
 public class CoinJarModel
  { 
  [DataMember(Name = "volume")] 
  
  public decimal Volume { get; set; } [DataMember(Name = "amount")] 
  
  public decimal Amount { get; set; }
  
   [DataMember(Name = "getTotalAmount")] public decimal GetTotalAmount { get; set; } 


} 

}

  


