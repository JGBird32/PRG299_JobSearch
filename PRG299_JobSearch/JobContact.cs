using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearchBLL
{
    class JobContact
    {
        private int jobContactID;
        private int jobID;
        private int contactID;

        public JobContact() { }

        public JobContact(int jobContactID, int jobID, int contactID)
        {
            JobContactID = jobContactID;
            JobID = jobID;
            ContactID = contactID;
        }

        public int JobContactID
        {
            get
            {
                return jobContactID;
            }

            set
            {
                jobContactID = value;
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

        public int ContactID
        {
            get
            {
                return contactID;
            }

            set
            {
                contactID = value;
            }
        }
    }
}
