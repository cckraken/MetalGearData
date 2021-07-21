using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAssignmentCollection
/// </summary>
public class clsAssignmentCollection
{
    //create a connection to the database with class level scope
    clsDataConnection Assignments = new clsDataConnection();

    //constructor
	public clsAssignmentCollection()
	{
        //execute the select all query
        Assignments.Execute("sproc_tblAssignedTo_SelectAll");
	}

    //this read only function gives us the count property
    public Int32 Count
    {
        get
        {
            //return the count of the data from the database
            return Assignments.Count;
        }
    }

    //this read only function exposes the query results collection
    public List<clsAssignments> AllAssignments
    {
        get
        {
            //create an instance of a list called allAssignments
            List<clsAssignments> allAssignments = new List<clsAssignments>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less than the number of records to process
            while (Index < Assignments.Count)
            {
                //set up the new entry to be added to the list
                clsAssignments NewAssignment = new clsAssignments();
                //get the assignment number from the database
                NewAssignment.AssigmentNo = Convert.ToInt32(Assignments.DataTable.Rows[Index]["AssignmentNo"]);
                //get the assignment name from the database
                NewAssignment.AssignmentName = Convert.ToString(Assignments.DataTable.Rows[Index]["AssignmentName"]);
                //add the new entry to the list
                allAssignments.Add(NewAssignment);
                //increment the index to the next record
                Index++;
            }
            //return the query results from the database
            return allAssignments;
        }
    }
}