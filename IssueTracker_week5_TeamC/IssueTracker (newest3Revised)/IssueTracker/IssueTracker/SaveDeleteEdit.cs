//Pos409
//1/12/2016
//Lucas Hauf, Joey Almeida
//this project was made so that a user could enter an issue into the application for review, and to organize and fix the issues


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker
{
    class SaveDeleteEdit
    {
        DateTime DateCreated;
        DateTime LastModified;
        int IssueNumber;
        string ErrorCatagory;
        string Priority;
        string Status;
        string Description;
        string CreatedBy;
        string ModifiedBy;
    
        public SaveDeleteEdit()
        {

        }
       
        
        public void setDateCreated(DateTime pDateCreated)
        {
            this.DateCreated = pDateCreated;
        }
        public DateTime returnDateCreated()
        {
            return DateCreated;
        }
       
       
        public void setLastModified(DateTime pLastModified)
        {
            this.LastModified = pLastModified;
        }
        public DateTime returnLastModified()
        {
            return LastModified;
        }

        
        public void setIssueNumber(int pIssueNumber)
        {
            this.IssueNumber =pIssueNumber ;
        }
        public int returnIssueNumber()
        {
            return IssueNumber;
        }
       
        
        public void setErrorCatagory(string pErrorCatagory)
        {
            this.ErrorCatagory =pErrorCatagory ;
        }
        public string returnErrorCatagory()
        {
            return ErrorCatagory;
        }
        
        
        public void setPriority(string pPriority)
        {
            this.Priority =pPriority ;
        }
        public string returnPriority()
        {
            return  Priority;
        }
        
        
        public void setStatus( string pStatus)
        {
            this.Status = pStatus;
        }
        public string returnStatus()
        {
            return Status ;
        }
        
        
        public void setDescription(string pDescription)
        {
            this.Description =pDescription ;
        }
        public string returnDescription()
        {
            return Description;
        }
        
        
        public void setCreatedBy(string pCreatedBy)
        {
            this.CreatedBy = pCreatedBy;
        }
        public string returnCreatedBy()
        {
            return CreatedBy;
        }
        
        
        public void setModifiedBy(string pModifiedBy)
        {
            this.ModifiedBy = pModifiedBy ;
        }
        public string returnModifiedBy()
        {
            return ModifiedBy;
        }
       
    }

}
