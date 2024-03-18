namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Data;

    public class DataReader
    {
        IEnumerable<ImportedObject> ImportedObjects;

        public void ImportAndPrintData(string fileToImport, bool printData = true)
        {
            ImportedObjects = File.ReadLines(fileToImport).Select(data => new ImportedObject
            {
                Type = data.Split(';')[0],
                Name = data.Split(';')[1],
                Schema = data.Split(';')[2],
                ParentType = data.Split(';')[3],
                ParentName = data.Split(';')[4],
                IsNullable = data.Split(';')[5],
                DataType= data.Split(';')[6]

            }).ToList();



            // clear and correct imported data
            ImportedObjects.ToList().ForEach(importedObject =>
             {
                 importedObject.Type = importedObject.Type.Trim().Replace(" ", "").Replace(Environment.NewLine, "").ToUpper();
                 importedObject.Name = importedObject.Name.Trim().Replace(" ", "").Replace(Environment.NewLine, "");
                 importedObject.Schema = importedObject.Schema.Trim().Replace(" ", "").Replace(Environment.NewLine, "");
                 importedObject.ParentName = importedObject.ParentName.Trim().Replace(" ", "").Replace(Environment.NewLine, "");
                 importedObject.ParentType = importedObject.ParentType.Trim().Replace(" ", "").Replace(Environment.NewLine, "");
             });

            // assign number of children
            ImportedObjects.ToList().ForEach(importedObject =>
              {
                  importedObject.NumberOfChildren = ImportedObjects.Count(importObj =>
                  importObj.ParentType == importedObject.Type &&
                  importObj.Name == importedObject.Name);
              });


            ImportedObjects.Where(database => database.Type == "DATABASE")
                .ToList()
                .ForEach(database =>
                {
                    Console.WriteLine($"Database '{database.Name}' ({database.NumberOfChildren} tables)");



                    // print all database's tables
                    ImportedObjects
                .Where(table => table.ParentType.ToUpper() == database.Type && table.ParentName == database.Name)
                .ToList()
                .ForEach(table =>
                {
                    Console.WriteLine($"\tTable '{table.Schema}.{table.Name}' ({table.NumberOfChildren} columns)");

                    //print all table's columns

                    ImportedObjects.Where(column => column.ParentType.ToUpper() == table.Type && column.ParentName == table.Name)
                    .ToList()
                    .ForEach(column =>
                    {

                        Console.WriteLine($"\t\tColumn '{column.Name}' with {column.DataType} data type {(column.IsNullable == "1" ? "accepts nulls" : "with no nulls")}");
                    });
                });
                });


            Console.ReadLine();
        }
    }

    class ImportedObject : ImportedObjectBaseClass
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Schema;

        public string ParentName;

        private string _parentType;
        public string ParentType
        {
            get { return _parentType; }
            set { _parentType = value; }
        }
        private string _dataType;
        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }
       
            
        public string IsNullable { get; set; }

        public double NumberOfChildren;
    }

    class ImportedObjectBaseClass
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
