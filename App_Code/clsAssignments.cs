using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAssignments
/// </summary>
public class clsAssignments
{
    //private data members
    private Int32 assignmentNo;
    private string assignmentName;

    public Int32 AssigmentNo  //public property for AssignedTo
    {
        get
        {
            return assignmentNo;
        }
        set
        {
            assignmentNo = value;
        }
    }

    public String AssignmentName  //public property for Assignment
    {
        get
        {
            return assignmentName;
        }
        set
        {
            assignmentName = value;
        }
    }
}