using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG299_JobSearchBLL
{
    class Contact
    {
        private int contactID;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string notes;

        public Contact() { }

        public Contact(int contactID, string firstName, string lastName, string phone, string email, string notes)
        {
            ContactID = contactID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Notes = notes;
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

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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
