using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests
{
    [Binding]
    public class CertificationSteps
    {
              

      

       

        [Given(@"Certification Details")]
        public void GivenCertificationDetails()
        {
            //Read data from excel spreadsheet
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\Data.xlsx", "Certifications");
           
            //Assertion to varify sucessful Login
            
            Certification.AddCertification();

        }

        [When(@"Click AddCertificate Button")]
        public void WhenClickAddCertificateButton()
        {
           
        }

        [Then(@"Verify the added Certificate")]
        public void ThenVerifyTheAddedCertificate()
        {
            Certification.AddCertificate_Verify();
        }


        [Given(@"Modified Certification details")]
        public void GivenModifiedCertificationDetails()
        {
            //Read data from excel spreadsheet
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\Data.xlsx", "EditCertifications");
            Certification.EditCertfications();

        }

        [Given(@"Delete Certification")]
        public void GivenDeleteCertification()
        {
            Certification.DeleteCertification();
        }


    }
}
