using System.ComponentModel.DataAnnotations.Schema;

namespace Candidate_Skill_MVC_CORE_MasterDetails.Models
{
    public class Result
    {
        public int Id { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public int Marks { get; set; }

        //nev
        public virtual Candidate Candidate { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
