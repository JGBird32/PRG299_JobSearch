using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearchBLL
{
    class JobOpening
    {
        private int jobOpeningID;
        private int jobID;
        private DateTime posted;
        private DateTime closing;
        private string method;
        private string status;
        private string notes;
        private int contactID;

        public JobOpening() { }

        public JobOpening(int jobOpeningID, int jobID, DateTime posted, DateTime closing, string method, string status, string notes, int contactID)
        {
            JobOpeningID = jobOpeningID;
            JobID = jobID;
            Posted = posted;
            Closing = closing;
            Method = method;
            Status = status;
            Notes = notes;
            ContactID = contactID;
        }

        public int JobOpeningID
        {
            get
            {
                return jobOpeningID;
            }

            set
            {
                jobOpeningID = value;
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

        public DateTime Posted
        {
            get
            {
                return posted;
            }

            set
            {
                posted = value;
            }
        }

        public DateTime Closing
        {
            get
            {
                return closing;
            }

            set
            {
                closing = value;
            }
        }

        public string Method
        {
            get
            {
                return method;
            }

            set
            {
                method = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
