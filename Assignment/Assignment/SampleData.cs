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
            var UniqueStates = CsvRows.Select(row => row.Split(',')[6]).Distinct().OrderBy(state => state);

            return UniqueStates;
        }
            
        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();

        // 4.
        public IEnumerable<IPerson> People => throw new NotImplementedException();

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}
