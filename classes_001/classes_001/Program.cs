using System;

namespace classes_001
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// from default project 		
			//Console.WriteLine ("Hello World!"); 

			// create worker_001 from Worker class
			Worker worker_001 = new Worker("Larry Larry", 3);
			worker_001.printWorkerInfo ();
			// create employee_001 from Employee class based by Worker class
			Employee employee_001 = new Employee("Larry Larry", 8,DateTime.Today, "technical support");
			employee_001.printEmployeeInfo ();
		}
	}
}
