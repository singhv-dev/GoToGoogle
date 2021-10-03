using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _4._Linked_List_And_List
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Comparer>();
        }   
    }

    [MemoryDiagnoser]
    public class Comparer
    {
        private readonly IRepository repository;
        private readonly IEnumerable<string> usernames;

        public Comparer()
        {
            repository = new FileRepository();
            usernames = repository.GetUserNames();
        }

        [Benchmark]
        public void CreateList()
        {
            List<string> names = new List<string>();
            foreach (string name in usernames)
            {
                names.Add(name);
            }
        }

        [Benchmark]
        public void CreateLinkedList()
        {
            LinkedList<string> names = new LinkedList<string>();
            foreach (string name in usernames)
            {
                names.AddLast(name);
            }
        }
    }

    interface IRepository
    {
        public IEnumerable<string> GetUserNames();
    }

    class FileRepository : IRepository
    {
        public IEnumerable<string> GetUserNames()
        {
            List<string> names = new List<string>();

            string filePath = Path.Combine("D:", "FileInfos", "usernames.txt");
            if (File.Exists(filePath))
            {
                names = File.ReadAllLines(filePath).ToList();
            }

            return names;
        }
    }
}
