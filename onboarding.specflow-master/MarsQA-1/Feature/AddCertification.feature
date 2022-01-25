Feature: AddCertification
Seller wants to add, edit and delete Certification details to his profile
On adding them it should be reflected on his dashboard


Scenario: Add Certification 
	Given Certification Details
	When Click AddCertificate Button
	Then Verify the added Certificate

Scenario: Edit Certification
	Given  Modified Certification details

Scenario: Delete Certification
	Given Delete Certification

 
