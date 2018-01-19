using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearchBLL
{
    class JobSkill
    {
        private int jobSkillID;
        private int jobID;
        private int skillID;

        public JobSkill() { }

        public JobSkill(int jobSkillID, int jobID, int skillID)
        {
            JobSkillID = jobSkillID;
            JobID = jobID;
            SkillID = skillID;
        }

        public int JobSkillID
        {
            get
            {
                return jobSkillID;
            }

            set
            {
                jobSkillID = value;
            }
        }

        public int JobID
        {
            get
            {
                return jobID;
            }

            set
            {
                jobID = value;
            }
        }

        public int SkillID
        {
            get
            {
                return skillID;
            }

            set
            {
                skillID = value;
            }
        }

    }
}
