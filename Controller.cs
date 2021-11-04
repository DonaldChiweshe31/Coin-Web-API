
using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Net;
 using System.Net.Http; 
 using System.Web.Http; 
 using CoinJarAPI.Models; 

 namespace CoinJarAPI.Controllers
  
 { public class CoinJarController : 
 
    ApiController
  { 

 // GET: api/CoinJar 
 
 public IEnumerable<CoinJarModel>
 
  Get() 
  
  { var coinJarList = new
  
   List<CoinJarModel>(); for (int i = 0; i < 42 ; i++) 
   
   { 
   var coinjarModel = new CoinJarModel 
   { // volume, Amount,
   
    GetTotalAmount.
    
     }; 
    
    } return coinJarList; } 
    
    // GET: api/CoinJar/5
    
     public string Get(int id) { return "value"; }
     
    } 
    
    
  }
