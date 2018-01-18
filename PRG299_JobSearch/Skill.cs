using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearch
{
    class Skill
    {
        private int skillID;
        private string category;
        private string title;
        private string description;

        public Skill() { }

        public Skill(int skillID, string category, string title, string description)
        {
            SkillID = skillID;
            Category = category;
            Title = title;
            Description = description;
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

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

    }
}
