using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsAddress
/// </summary>
public class clsOverviewCollection
{
    //create a connection to the database with class level scope
    clsDataConnection dBConnection;
    //member var for current id
    clsOverview thisID = new clsOverview();


    //pub ThisID property
    public clsOverview ThisID
    {
        get
        {
            return thisID;
        }
        set
        {
            thisID = value;
        }
    }

    public void Delete()
    {
        //this public function provides the functionality for the delete method

        //try to delete the record
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the MotherbaseID parameter passed to this function to the list of parameters to use in the database
            dBConnection.AddParameter("@MotherBaseID", thisID.MotherBaseID);
            //execute the stored procedure in the database
            dBConnection.Execute("sproc_tblOverview_Delete");
        }

    }

    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
            //return the count of records
            return dBConnection.Count;
        }
    }

    public List<clsOverview> OverviewList
    {
        get
        {
            List<clsOverview> overviewList = new List<clsOverview>(); //create an array list of type clsOverview
            Int32 RecordCount; //variable to store the count of records
            Int32 Index = 0; //variable to store the index for the loop, initialised at zero
            RecordCount = dBConnection.Count; //get the count of records

            while (Index < RecordCount) //keep looping untill all records are processed
            {
                clsOverview BlankRecord = new clsOverview(); //create a blank record
                //copy the data from the table to the RAM
                //Uses the database connection to access the datatable, then the row indicated by the current Index count to acquire the fields listed
                //then converted into their appropriate data types and sent to the BlankRecord
                BlankRecord.MotherBaseID = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["MotherBaseID"]);
                BlankRecord.CodeName = Convert.ToString(dBConnection.DataTable.Rows[Index]["CodeName"]);
                BlankRecord.AbilityRank = Convert.ToString(dBConnection.DataTable.Rows[Index]["AbilityRank"]);
                BlankRecord.AssignedTo = Convert.ToString(dBConnection.DataTable.Rows[Index]["AssignedTo"]);
                BlankRecord.Affiliation = Convert.ToString(dBConnection.DataTable.Rows[Index]["Affiliation"]);
                BlankRecord.HairColour = Convert.ToString(dBConnection.DataTable.Rows[Index]["HairColour"]);
                BlankRecord.Ethnicity = Convert.ToString(dBConnection.DataTable.Rows[Index]["Ethnicity"]);
                BlankRecord.DateJoined = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["DateJoined"]);
                BlankRecord.AtMotherBase = Convert.ToString(dBConnection.DataTable.Rows[Index]["AtMotherBase"]);
                BlankRecord.YearsAtBase = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["YearsAtBase"]);

                overviewList.Add(BlankRecord); //add the blank record to the array list
                 Index++; //increase the index
            }
            //return the list as the return value of the function
            return overviewList;


        }

    }

    public Int32 Add()
    //this function will add a new ID to the database
    //it accepts a single parameter, an object of type clsOverview
    //once the record is added the function returns the primary key value of the new record
    {

        //connect to the database
        clsDataConnection NewDBID = new clsDataConnection();
        //add the parameters
        NewDBID.AddParameter("CodeName", thisID.CodeName);
        NewDBID.AddParameter("AbilityRank", thisID.AbilityRank);
        NewDBID.AddParameter("AssignedTo", thisID.AssignedTo);
        NewDBID.AddParameter("Affiliation", thisID.Affiliation);
        NewDBID.AddParameter("HairColour", thisID.HairColour);
        NewDBID.AddParameter("Ethnicity", thisID.Ethnicity);
        NewDBID.AddParameter("DateJoined", thisID.DateJoined);
        NewDBID.AddParameter("AtMotherBase", thisID.AtMotherBase);
        NewDBID.AddParameter("YearsAtBase", thisID.YearsAtBase);
        //execute the stored procedure returning the primary key of the new record
        return NewDBID.Execute("sproc_tblOverview_Insert");

    }


    public void Update()
    {
        //this function will update an existing ID in the database
        //it accepts a single paramter an object of type clsOverview
        //the MotherBaseID property must have a valid value for this to work

        //connect to the database
        clsDataConnection NewRecord = new clsDataConnection();
        //add the parameters
        NewRecord.AddParameter("MotherBaseID", thisID.MotherBaseID);
        NewRecord.AddParameter("CodeName", thisID.CodeName);
        NewRecord.AddParameter("AbilityRank", thisID.AbilityRank);
        NewRecord.AddParameter("AssignedTo", thisID.AssignedTo);
        NewRecord.AddParameter("Affiliation", thisID.Affiliation);
        NewRecord.AddParameter("HairColour", thisID.HairColour);
        NewRecord.AddParameter("Ethnicity", thisID.Ethnicity);
        NewRecord.AddParameter("DateJoined", thisID.DateJoined);
        NewRecord.AddParameter("AtMotherBase", thisID.AtMotherBase);
        NewRecord.AddParameter("YearsAtBase", thisID.YearsAtBase);
        //execute the query
        NewRecord.Execute("sproc_tblOverview_Update");
    }



    //this funtion defines the FilterByAbilityRank method
    public void FilterByAbilityRank(string AbilityRank)
    //it accepts a single parameter AbilityRank and returns no value
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter used by the stored procedure
        dBConnection.AddParameter("@AbilityRank", AbilityRank);
        //execute the stored procedure to the delete the address
        dBConnection.Execute("sproc_tblOverview_FilterByAbilityRank");
    }

}




  

