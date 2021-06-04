using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hw_7
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict_phones = File.ReadAllLines(@"D:\soft\hw_7\hw_7\phones.txt")
                                       .Select(x => x.Split(' '))
                                       .ToDictionary(x => x[0], x => x[1]);

            foreach (var number in dict_phones)
            {
                Console.WriteLine($"name: {number.Key} \tnumber: {number.Value}");
            }

            var onlyPhoneNumbers = dict_phones.Values.ToList();
            var onlyPhoneNames = dict_phones.Keys.ToList();


            List<string> listToChange = new List<string>();
            foreach (var tempKey in dict_phones.Keys)
            {
                if (dict_phones[tempKey].StartsWith("80"))
                {
                    listToChange.Add(tempKey);
                }
            }

            foreach (var item in listToChange)
            {
                dict_phones[item] = "+3" + dict_phones[item];
            }

            using (StreamWriter file = new StreamWriter(@"D:\soft\hw_7\hw_7\Phoness.txt"))
                foreach (var entry in dict_phones)
                {
                    file.WriteLine($"{entry.Key}-{entry.Value}");
                }

            Console.WriteLine("\nFixed list:");
            foreach (var number in dict_phones)
            {
                Console.WriteLine($"name: {number.Key} \tnumber: {number.Value}");
            }

            Console.WriteLine("\nEnter name of the user u wanna to find: ");
            var nameSearch = Console.ReadLine();
            var foundUserPhone = dict_phones.FirstOrDefault(x => x.Key == nameSearch).Value;
            if (foundUserPhone == null)
            {
                Console.WriteLine("No such user!");
            }
            else
            {
                Console.WriteLine($"The number of  {nameSearch} is: {foundUserPhone}");
            }


            string readPath = @"D:\soft\hw_7\hw_7\data.txt";
            string writePath = @"D:\soft\hw_7\hw_7\rez.txt";
            string directory_path = @"D:\soft\hw_7\hw_7\DirectoryC.txt";
            string text = "";

            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }

                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                text = "";

                using (StreamWriter sw = new StreamWriter(directory_path, false, System.Text.Encoding.Default))
                {
                    if (Directory.Exists("C:\\"))
                    {
                        text += "directories: ";
                        string[] dirs = Directory.GetDirectories("C:\\");
                        foreach (string s in dirs)
                        {
                            text += $"\n{s}";
                            text += $"\ntype: {s.GetType()}";

                        }
                        text += "\n\nfiles: ";
                        string[] files1 = Directory.GetFiles("C:\\");
                        foreach (string s in files1)
                        {
                            text += $"\n{s}";
                            text += $"\ntype: {s.GetType()}";
                        }
                    }
                    sw.WriteLine(text);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            text = "Newest text";
            if (File.Exists(writePath))
            {
                File.WriteAllText(writePath, text);



                DirectoryInfo d = new DirectoryInfo(@"D:\");//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                string str = "\n";
                foreach (FileInfo file in Files)
                {
                    string temp_text = File.ReadAllText($"D:\\{file.Name}");
                    str = str + "\nfile name:\n" + file.Name + "\nWhat is in txt:\n" + temp_text + "\n";
                }
                Console.WriteLine(str);
            }
        }
    }
}
