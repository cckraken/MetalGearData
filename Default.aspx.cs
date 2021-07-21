using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the form is loaded, do this:
        if (IsPostBack == false)
        {
            //display all records once the program is launched
            DisplayRecords("");
        }

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 MotherBaseID;
        //if a record has been selected from the list
        if (lstRecords.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            MotherBaseID = Convert.ToInt32(lstRecords.SelectedValue);
            //store the data in the session object
            Session["MotherBaseID"] = MotherBaseID;
            //redirects to the delete page
            Response.Redirect("Delete.aspx?MotherBaseID=" + MotherBaseID);
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
       
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //this line of code directs to the AnID page, to add a member
        Response.Redirect("AnID.aspx?MotherBaseID=-1");
    }
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all records
        DisplayRecords("");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //display only records matching the text in the ability rank text box
        DisplayRecords(txtAbilityRank.Text);
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to the store the primary key value
        Int32 IDNo;
        //check the list has been clicked first
        if (lstRecords.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            IDNo = Convert.ToInt32(lstRecords.SelectedValue);
            //redirect to the editing page
            Response.Redirect("AnID.aspx?MotherBaseID=" + IDNo);
        }
        else
        {
            //display an error
            lblError.Text = "You must select an item off the list first to edit it.";
        }
    }

    


 Int32 DisplayRecords(string AbilityRankFilter)
    {
        Int32 MotherBaseID; //variable to store the primary key
        string CodeName; //variable to store the code name
        string AbilityRank; //variable to store the ability rank
        string AssignedTo; //variable to store the assigned to field
        string Affiliation; //variable to store the affiliation field
        string HairColour; //variable to store the hair colour field
        string Ethnicity; //variable to store the ethnicity field
        DateTime DateJoined; //variable to store the date joined field
        string AtMotherBase; //variable to store the at mother base field
        clsOverviewCollection MyOverview = new clsOverviewCollection();
        MyOverview.FilterByAbilityRank(AbilityRankFilter);
        Int32 RecordCount; //variable to store the count of records
        Int32 Index = 0; //variable to store the index for the loop
        RecordCount = MyOverview.Count; //get the count of records
        lstRecords.Items.Clear(); //clear the list box
        while (Index < RecordCount) //while there are records to process
        {
            MotherBaseID = MyOverview.OverviewList[Index].MotherBaseID; //get the primary key
            CodeName = MyOverview.OverviewList[Index].CodeName; //get the codename
            AbilityRank = MyOverview.OverviewList[Index].AbilityRank; //get the ability rank
            AssignedTo = MyOverview.OverviewList[Index].AssignedTo; //get the assigned to field
            Affiliation = MyOverview.OverviewList[Index].Affiliation; //get the affiliation field
            HairColour = MyOverview.OverviewList[Index].HairColour; //get the hair colour field
            Ethnicity = MyOverview.OverviewList[Index].Ethnicity; //get the ethnicity field
            DateJoined = MyOverview.OverviewList[Index].DateJoined; //get the date joined field
            AtMotherBase = MyOverview.OverviewList[Index].AtMotherBase; //get the at mother base field
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(MotherBaseID + ", " + CodeName, MotherBaseID.ToString()); //create a new entry for the list box using concatenation
            lstRecords.Items.Add(NewEntry); //add the address to the list
            Index++; //move the index to the next record
        }
        return RecordCount; //return the count of records found
}




 protected void lstDetails_SelectedIndexChanged(object sender, EventArgs e)
 {

 }
}
