using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearchBLL
{
    class Job
    {
        private int jobID;
        private string title;
        private int companyID;
        private string description;
        private string notes;

        public Job(int jobID, string title, int companyID, string description, string notes)
        {
            JobID = jobID;
            Title = title;
            CompanyID = companyID;
            Description = description;
            Notes = notes;
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

        public int CompanyID
        {
            get
            {
                return companyID;
            }

            set
            {
                companyID = value;
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

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
    }
}
