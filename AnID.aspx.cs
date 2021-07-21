using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnID : System.Web.UI.Page
{
    //var to store the MotherBaseID number on a class level scope
    Int32 IDNo;

    protected void Page_Load(object sender, EventArgs e)
    {

        //copy the data from the query string to the text box txtMotherBaseID
        IDNo =Convert.ToInt32(Request.QueryString["MotherBaseID"]);
        //if this is not an instruction to add a new record
        if (IsPostBack != true)
        {
            //update the contents of the drop down list
            DisplayAssignments();

            if (IDNo != -1)
            {
                //display the existing data
                DisplayIDs(IDNo);
            }
        }

    }

    void DisplayIDs(Int32 MotherBaseID)
    {
        //create an instance of the overview class
        clsOverview MyIDs = new clsOverview();
        //find the record we want to display
        MyIDs.Find(MotherBaseID);
        //display the other parameters
        txtCodeName.Text = MyIDs.CodeName;
        txtAbilityRank.Text = MyIDs.AbilityRank;
        ddlAssignedTo.SelectedValue = Convert.ToString(MyIDs.AssignedTo);
        txtAffiliation.Text = MyIDs.Affiliation;
        txtHairColour.Text = MyIDs.HairColour;
        txtEthnicity.Text = MyIDs.Ethnicity;
        txtDateJoined.Text = MyIDs.DateJoined.ToString("dd/MM/yyyy");
        txtAtMotherBase.Text = MyIDs.AtMotherBase;
        txtYearsAtBase.Text = MyIDs.YearsAtBase.ToString("##");


    }


    protected void btnClose_Click(object sender, EventArgs e)
    {
        //closes the form
        Response.Redirect("Default.aspx");
    }




    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the overview class
        clsOverviewCollection Records = new clsOverviewCollection();
        //var to store any error messages
        string ErrorMessage;
        //test the data on the webform via the validation contained in clsOverview
        ErrorMessage = Records.ThisID.IDValid(txtCodeName.Text,
                                      txtAbilityRank.Text,
                                      ddlAssignedTo.Text,
                                      txtAffiliation.Text,
                                      txtHairColour.Text,
                                      txtEthnicity.Text,
                                      txtDateJoined.Text,
                                      txtAtMotherBase.Text,
                                      txtYearsAtBase.Text);

        if (ErrorMessage == "")
            //if the error message contains no characters (i.e all is fine)
        {

            //if the ID number is -1
            if (IDNo == -1)
            {
                //copy the data from the interface to the object
                //also converts the neccassary datatypes
                Records.ThisID.CodeName = txtCodeName.Text;
                Records.ThisID.AbilityRank = txtAbilityRank.Text;
                Records.ThisID.AssignedTo = Convert.ToString(ddlAssignedTo.SelectedValue);
                Records.ThisID.Affiliation = txtAffiliation.Text;
                Records.ThisID.HairColour = txtHairColour.Text;
                Records.ThisID.Ethnicity = txtEthnicity.Text;
                Records.ThisID.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
                Records.ThisID.AtMotherBase = txtAtMotherBase.Text;
                Records.ThisID.YearsAtBase = Convert.ToInt32(txtYearsAtBase.Text);
                    
                //add the new record
                Records.Add();

            }
            else
            {

                //this is an existing record
                //copt the data from the interface to the object
                Records.ThisID.MotherBaseID = Convert.ToInt32(IDNo);
                Records.ThisID.CodeName = txtCodeName.Text;
                Records.ThisID.AbilityRank = txtAbilityRank.Text;
                Records.ThisID.AssignedTo = Convert.ToString(ddlAssignedTo.SelectedValue);
                Records.ThisID.Affiliation = txtAffiliation.Text;
                Records.ThisID.HairColour = txtHairColour.Text;
                Records.ThisID.Ethnicity = txtEthnicity.Text;
                Records.ThisID.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
                Records.ThisID.AtMotherBase = txtAtMotherBase.Text;
                Records.ThisID.YearsAtBase = Convert.ToInt32(txtYearsAtBase.Text);
                //update the existing record
                Records.Update();
            }
            //redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {

            //display the error message
            lblError.Text = ErrorMessage;
        }
    }

    //this function is used to populate the AssignedTo drop down list
    Int32 DisplayAssignments()
    {
        //create an instance of the assignment class
        clsAssignmentCollection Assignments = new clsAssignmentCollection();
        //var the store the assignment number primary key
        string AssignmentNo;
        //var to store the name of the assignment
        string AssignmentName;
        //var to store the index of the loop
        Int32 Index = 0;
        //while the index is less than the number of records to process
        while (Index < Assignments.Count)
        {
            //get the assignment number from the databse
            AssignmentNo = Convert.ToString(Assignments.AllAssignments[Index].AssigmentNo);
            //get the assignment name from the database
            AssignmentName = Assignments.AllAssignments[Index].AssignmentName;
            //set up the new row to be added to the list
            ListItem NewAssignment = new ListItem(AssignmentName, AssignmentNo);
            //add the new row to the list
            ddlAssignedTo.Items.Add(NewAssignment);
            //increment the index to the next record
            Index++;
        }
        //return the number of records found
        return Assignments.Count;
    }

        
}
