using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace AddressBook
{
    class CsvOperation
    {
        public static void CSVOperation(Dictionary<string, List<AddressBook>> addressbooknames, int option)
        {
            //Store Csv File path in a string
            string csvFilePath = @"C:\Users\HP\source\repos\AddressBook\AddressBook\CsvData.csv";
            string jsonfilePath = @"C:\Users\HP\source\repos\AddressBook\AddressBook\JsonFile.json";
            File.WriteAllText(csvFilePath, string.Empty);
            //Iterate over Dictionary Values
            foreach (KeyValuePair<string, List<AddressBook>> kvp in addressbooknames)
            {
                //Open file in Append Mode for adding List elements
                using var stream = File.Open(csvFilePath, FileMode.Append);
                using var writer = new StreamWriter(stream);
                using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                //Iterate over each value
                foreach (var value in kvp.Value)
                {
                    //Create List to add Records
                    List<AddressBook> list = new List<AddressBook>();
                    list.Add(value);
                    //Write List to CSV File
                    csvWriter.WriteRecords(list);
                }
                //Print a newline
                csvWriter.NextRecord();
            }

            //Reading a Csv File
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //Get all records from Csv File
                var records = csv.GetRecords<AddressBook>().ToList();
                if (option == 1)
                {
                    foreach (AddressBook member in records)
                    {
                        //To skip Headers in Csv File
                        if (member.firstName == "firstName")
                        {
                            Console.WriteLine("\n");
                            continue;
                        }
                        //Convert each Value to string and Print to Console
                        Console.WriteLine(member.ToString());

                    }
                }
                else
                {
                    //Create object for Json
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    using (StreamWriter stream = new StreamWriter(jsonfilePath))
                    using (JsonWriter jsonWriter = new JsonTextWriter(stream))
                    {
                        //Converting from List to Json Object
                        jsonSerializer.Serialize(jsonWriter, addressbooknames);
                    }

                    //Reading from Json File-> Converting from Json Object to List
                    Dictionary<string, List<AddressBook>> jsonList = JsonConvert.DeserializeObject<Dictionary<string, List<AddressBook>>>(File.ReadAllText(jsonfilePath));
                    foreach (KeyValuePair<string, List<AddressBook>> i in jsonList)
                    {
                        Console.WriteLine("\nAddressBook Name: {0}", i.Key);
                        foreach (var j in i.Value)
                        {
                            Console.WriteLine(j.ToString());
                        }


                    }
                }
            }
        }


    }
}