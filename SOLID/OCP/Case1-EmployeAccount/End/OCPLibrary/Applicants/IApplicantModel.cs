using System;
using System.Collections.Generic;

namespace OCPLibrary
{
    public interface IApplicantModel
    {
         string FirstName {get;set;}
         string LastName {get;set;}

        IAccounts AccountProcessor {get;set;}
    }
}