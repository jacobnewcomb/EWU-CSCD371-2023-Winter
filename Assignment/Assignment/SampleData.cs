using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        //public IEnumerable<string> CsvRows => throw new NotImplementedException();
        public virtual IEnumerable<string> CsvRows 
        {
            get
            {
                var CSVFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "People.csv");
                var CSVRows = File.ReadAllLines(CSVFilePath).Skip(1);
                return CSVRows;
            }
        }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            //var StateList = new List<string>();
            var uniqueStates = CsvRows.Select(row => row.Split(',')[6]).Distinct().OrderBy(state => state);

            return uniqueStates;
        }
            
        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
        {
            var uniqueStates = GetUniqueSortedListOfStatesGivenCsvRows().ToArray();

            return string.Join(",", uniqueStates);
        }
            

        // 4.
        public IEnumerable<IPerson> People => throw new NotImplementedException();

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter)
        {
            var matchingPeople = People.Where(email => filter(email.EmailAddress));
            var matchingNames = matchingPeople.Select(x => (x.FirstName, x.LastName));

            return matchingNames;
        }

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}
