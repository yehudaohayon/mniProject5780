using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    /// <summary>
    /// this class represent a host with some hosting unit
    /// </summary>
    public class Host
    {
        public int HostKey;
        public string PrivateName;
        public string FamilyName;
        public int FhoneNumber;
        public string MailAddress;
        public BankAccount BankAccount;
        public bool CollectionClearance;//Certificate of collection from the bank account
        public List<HostingUnit> hostingUnits;
        public override string ToString() { return null; }
        /*Host(int hostKey, string privateName, string familyName, int fhoneNumber, string mailAddress, BankAccount bankAccount, bool collectionClearance)
        {
            HostKey = hostKey;
            PrivateName = privateName;
            FamilyName = familyName;
            FhoneNumber = fhoneNumber;
            MailAddress = mailAddress;
            BankAccount = bankAccount;
            CollectionClearance = collectionClearance;
        }*/
        public int getHostKey() { return HostKey; }
    }
}
