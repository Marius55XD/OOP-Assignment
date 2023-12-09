using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MS_AssignmentNo1
{
   class CustDetails
    {
        // Fields to store customer information

        public string name; // Customer name
        public string add1; // Address line 1
        public string add2; // Address line 2
        public string county; // County or region
        public string email; // Customer email

        // Method to display customer name
        public void Custinfo()
        {
            // Show a message box with the customer's name
            //Shows a butons Yes , No and Cancel  with an icon Exclamation

            MessageBox.Show("Customer Name is " + name, "Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Method to display customer address information
        public void infoCustAdd()
        {
            // Show a message box with the customer's address details
            //Shows a butons OK and Cancel with an icon Exclamation

            MessageBox.Show("Customer Address: " + "\n" + add1 + "\n" + add2 + "\n" + county, "Address Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        // Method to display customer contact details
        public void InfoCusContact()
        {
            // Show a message box with the customer's contact email
            //Shows a butons OK and Cancel with an icon Exclamation

            MessageBox.Show("Customer Contact Details are " + email , "Contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        //This method constructs a string that includes all customer details and then display it in a single message box


        public void DisplayAllInfo()
        {
            // Construct a string containing all customer information
            string allInfo = $"Customer Name is {name}\n\n" + $"Customer Address: In{add1}\n{add2}\n{county}\n\n" + $"Customer Contact details are {email}";

            // Show a message box displaying all customer information
            MessageBox.Show(allInfo, "Customer Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}

