using System;

namespace classes_001
{
	// a simple Worker class
	public class Worker
	{
		// class variables 
		private string name;
		private int time_work;

		public Worker (String workerName, int workTime )
		{
			this.name = workerName;
			this.time_work = workTime;
		}

		public void printWorkerInfo()
		{
			Console.WriteLine ("The worker named "+this.name+" is employed for "+this.time_work+" hours.\n");
		}
	}
}

