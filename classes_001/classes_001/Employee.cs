using System;

namespace classes_001
{
	// a simple Employee class inheritance based by Worker
	public class Employee:Worker
	{
		// class variables 
		private DateTime date_job_contract;
		private string position_held;

		//public Employee (DateTime date, string position) is not correct
		//  "Parent does not contain a constructor that takes 0 arguments"
		public Employee (String workerName,int workTime, DateTime date, string position): base(workerName, workTime)
		{
			this.date_job_contract = date;
			this.position_held = position;
		}

		public void printEmployeeInfo()
		{
			Console.WriteLine ("The employee with "+this.date_job_contract+" has possition "+this.position_held+".\n");
		}
	}
}

