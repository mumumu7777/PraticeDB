using System;
using System.Collections.Generic;
using global::demo2.Models.EFModel;
using System.Linq;
using System.Web;

namespace demo2.Models.DTOs
{            
        public partial class ScoreDTO
        {
            public int StudentId { get; set; }
            public string Subject { get; set; }
            public int Score1 { get; set; }
            public string Test { get; set; }

            public virtual Student Student { get; set; }
        }


    public class toDto {

        public ScoreDTO toscoreDto(Score dd) => new ScoreDTO
        {
            Score1 = dd.Score1,
            StudentId =dd.StudentId,
            Subject = dd.Subject,
        };

        

           


        


    }
    
    
}