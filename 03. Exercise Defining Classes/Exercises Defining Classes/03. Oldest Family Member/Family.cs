namespace _03.Oldest_Family_Member
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public Family(List<Person> familyMembers)
        {
            this.family = familyMembers;
        }

        public void AddMember()
        {
        }

        public Person GetOldestMember()
        {
            return this.family.OrderByDescending(a => a.Age).FirstOrDefault();
        }
    }
}