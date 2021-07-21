using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsOverview
/// </summary>
public class clsOverview
{
    private clsDataConnection dBConnection = new clsDataConnection();
    //create a connection to the database


    //CodeName private member variable
    private string codeName;
    //AbilityRank private member variable
    private string abilityRank;
    //AssignedTo private member variable
    private string assignedTo;
    //Affiliation private member variable
    private string affiliation;
    //HairColour private member variable
    private string hairColour;
    //Ethnicity private member variable
    private string ethnicity;
    //DateJoined private member variable
    private DateTime dateJoined;
    //AtMotherBase private member variable
    private String atMotherBase;
    //MotherBaseID private member variable
    private Int32 motherBaseID;
    //YearsAtBase private member variable
    private Int32 yearsAtBase;

    //MotherBaseID public property
    public Int32 MotherBaseID
    {
        get
        {
            return motherBaseID;
        }
        set
        {
            motherBaseID = value;
        }
    }

    //CodeName public property
    public string CodeName
    {
        get
        {
            return codeName;
        }
        set
        {
            codeName = value;
        }
    }

    //AbilityRank public property
    public string AbilityRank
    {
        get
        {
            return abilityRank;
        }
        set
        {
            abilityRank = value;
        }
    }

    //AssignedTo public property
    public string AssignedTo
    {
        get
        {
            return assignedTo;
        }
        set
        {
            assignedTo = value;
        }
    }

    //Affiliation public property
    public string Affiliation
    {
        get
        {
            return affiliation;
        }
        set
        {
            affiliation = value;
        }
    }

    //HairColour public property
    public string HairColour
    {
        get
        {
            return hairColour;
        }
        set
        {
            hairColour = value;
        }
    }

    //Ethnicity public property
    public string Ethnicity
    {
        get
        {
            return ethnicity;
        }
        set
        {
            ethnicity = value;
        }
    }

    //DateJoined public property
    public DateTime DateJoined
    {
        get
        {
            return dateJoined;
        }
        set
        {
            dateJoined = value;
        }
    }

    //AtMotherBase public property
    public string AtMotherBase
    {
        get
        {
            return atMotherBase;
        }
        set
        {
            atMotherBase = value;
        }
    }

    //YearsAtBase public property
    public Int32 YearsAtBase
    {
        get
        {
            return yearsAtBase;
        }
        set
        {
            yearsAtBase = value;
        }
    }

    public string IDValid(string CodeName,
                          string AbilityRank,
                          string AssignedTo,
                          string Affiliation,
                          string HairColour,
                          string Ethnicity,
                          string DateJoined,
                          string AtMotherBase,
                          string YearsAtBase)


    ///this function is used to validate the data in a new ID entry
    ///it accepts 9 parameters and returns a string containing the text of any errors (if any)
    ///if no errors, it returns a blank string
    {
        string ErrorMsg; //var to store any error message
        ErrorMsg = ""; //initialise the var with a blank string

        if (CodeName.Length < 3 | CodeName.Length > 15)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The codename must be between 3 and 15 characters, ";
        }
        if (AbilityRank.Length < 2 | AbilityRank.Length > 3)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The ability rank must be between 2 and 3 characters, ";
        }

        if (Affiliation.Length < 7 | Affiliation.Length > 15)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The affiliation must be between 7 and 15 characters, ";
        }
        if (HairColour.Length < 3 | HairColour.Length > 10)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The hair colour must be between 3 and 10 characters, ";
        }
        if (Ethnicity.Length < 4 | Ethnicity.Length > 10)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The ethnicity must be between 4 and 10 characters, ";
        }

        if (AtMotherBase.Length < 3 | AtMotherBase.Length > 5)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The AtMotherbase field must be 'True' or 'False, ";
        }

        if (DateJoined.Length < 10 | DateJoined.Length > 11)
        {
            //set the error message
            ErrorMsg = ErrorMsg + "The date entered must be in the DD/MM/YYYY format, ";
        }

        try
        {
            //var to store the DateJoined 
            DateTime Temp;
            //assign the date to a temporary var
            Temp = Convert.ToDateTime(DateJoined);
        }
        catch
        {
            //set the error message
            ErrorMsg = ErrorMsg + "Date entered is not a valid date";
        }

        try
        {
            //var to store the YearsAtBase
            Int32 Temp;
            //asign the value to a temporary var
            Temp = Convert.ToInt32(YearsAtBase);

            if (Temp < 1 | Temp > 15)
            {             
                //set the error message
                ErrorMsg = ErrorMsg + "Please enter a number between 1 and 15 in YearsAtBase, ";
                return ErrorMsg;
            }
            else 
            {
                YearsAtBase = Convert.ToString(Temp);
            }

        }
        catch
        {
            //set the error message
            ErrorMsg = ErrorMsg + "Please enter a number between 1 and 15 in YearsAtBase, ";
        }

                if (ErrorMsg == "")
                {

                    //return a blank string
                    return "";
                }

                else
                {
                    //reutn the errors string value
                    return "There were the following errors : " + ErrorMsg;
                }

            }

    //function for the find public method
    public Boolean Find(Int32 MotherBaseID)
    {
        //initialise the DBConnection
        clsDataConnection dBConnection = new clsDataConnection();
        //add the motherbaseid no parameter
        dBConnection.AddParameter("@MotherBaseID", MotherBaseID);
        //execute the query
        dBConnection.Execute("sproc_tblOverview_FilterByIDNo");
        //if the record was found
        if (dBConnection.Count == 1)
        {
            //get the parameters
            motherBaseID = Convert.ToInt32(dBConnection.DataTable.Rows[0]["MotherBaseID"]);
            codeName = Convert.ToString(dBConnection.DataTable.Rows[0]["CodeName"]);
            abilityRank = Convert.ToString(dBConnection.DataTable.Rows[0]["AbilityRank"]);
            assignedTo = Convert.ToString(dBConnection.DataTable.Rows[0]["AssignedTo"]);
            affiliation = Convert.ToString(dBConnection.DataTable.Rows[0]["Affiliation"]);
            hairColour = Convert.ToString(dBConnection.DataTable.Rows[0]["HairColour"]);
            ethnicity = Convert.ToString(dBConnection.DataTable.Rows[0]["Ethnicity"]);
            dateJoined = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateJoined"]);
            atMotherBase = Convert.ToString(dBConnection.DataTable.Rows[0]["AtMotherBase"]);
            yearsAtBase = Convert.ToInt32(dBConnection.DataTable.Rows[0]["YearsAtBase"]);

            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }
    }



        
        }








