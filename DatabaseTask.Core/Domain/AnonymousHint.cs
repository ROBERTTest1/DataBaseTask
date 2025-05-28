   using System;
   using System.ComponentModel.DataAnnotations.Schema;
   using System.ComponentModel.DataAnnotations;

   namespace DatabaseTask.Core.Domain
   {
       public class AnonymousHint
       {
           [Key]
           public int HintId { get; set; } // PK

           public string HintType { get; set; }
           public DateTime HintDate { get; set; }
           public string Comment { get; set; }

           public int CompanyId { get; set; }
           public Company Company { get; set; }
       }
   }