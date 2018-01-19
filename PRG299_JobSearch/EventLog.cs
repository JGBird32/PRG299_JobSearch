using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearchBLL
{
    class EventLog
    {
        private int eventLogID;
        private DateTime timeStamp;
        private string type;
        private int contactID;
        private int jobOpeningID;
        private string notes;

        public EventLog() { }

        public EventLog(int eventLogID, DateTime timeStamp, string type, int contactID, int jobOpeningID, string notes)
        {
            EventLogID = eventLogID;
            TimeStamp = timeStamp;
            Type = type;
            ContactID = contactID;
            JobOpeningID = jobOpeningID;
            Notes = notes;
        }

        public int EventLogID
        {
            get
            {
                return eventLogID;
            }

            set
            {
                eventLogID = value;
            }
        }

        public DateTime TimeStamp
        {
            get
            {
                return timeStamp;
            }

            set
            {
                timeStamp = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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
