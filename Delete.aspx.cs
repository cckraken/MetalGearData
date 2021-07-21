using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 MotherBaseID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the record to be deleted from the session object
        MotherBaseID = Convert.ToInt32(Session["MotherBaseID"]);
        //gets the primary key of the record to be deleted and displays it in the conformation box
        txtIDNo.Text = Convert.ToString(Session["MotherBaseID"]);
 
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {

        ///this function handles the click event of the Yes button

        //create an instance of the class clsOverviewCollection called MyOverview
        clsOverviewCollection MyOverview = new clsOverviewCollection();
        //find the record to be deleted
        MyOverview.ThisID.Find(MotherBaseID);
        //call the delete method of the object
        MyOverview.Delete();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }




    protected void btnNo_Click(object sender, EventArgs e)
    {
        //this line of code re-directs back to the main page
        Response.Redirect("Default.aspx");

    }

}
