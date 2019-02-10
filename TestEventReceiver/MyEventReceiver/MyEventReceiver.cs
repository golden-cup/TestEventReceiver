using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace TestEventReceiver.MyEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class MyEventReceiver : SPItemEventReceiver
    {
        /// <summary>
        /// An item is being added.
        /// </summary>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            //base.ItemAdding(properties);  
            using (SPWeb web = properties.OpenWeb())
            {
                try
                {
                    SPList list = web.Lists["EmployeeDocumentLog"];
                    SPListItem newItem = list.Items.Add();
                    newItem["Title"] = properties.ListItem.Name;
                    newItem["DocumentAction"] = "Document Added";
                    newItem.Update();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// An item is being updated.
        /// </summary>
        public override void ItemUpdating(SPItemEventProperties properties)
        {
            //base.ItemUpdating(properties);
            using (SPWeb web = properties.OpenWeb())
            {
                try
                {
                    SPList list = web.Lists["EmployeeDocumentLog"];
                    SPListItem newItem = list.Items.Add();
                    newItem["Title"] = properties.ListItem.Name;
                    newItem["DocumentAction"] = "Document Updated";
                    newItem.Update();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// An item is being deleted.
        /// </summary>
        public override void ItemDeleting(SPItemEventProperties properties)
        {
            //base.ItemDeleting(properties);  
            using (SPWeb web = properties.OpenWeb())
            {
                try
                {
                    SPList list = web.Lists["EmployeeDocumentLog"];
                    SPListItem newItem = list.Items.Add();
                    newItem["Title"] = properties.ListItem.Name;
                    newItem["DocumentAction"] = "Document Deleted";
                    newItem.Update();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


    }
}