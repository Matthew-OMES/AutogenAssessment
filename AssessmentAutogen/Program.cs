using AssessmentAutogen;

Console.WriteLine("Hello, World!");

//// Child
//var assessmentFilePath = @"C:\Users\53108C\Documents\git\Matthew-OMES\AutogenAssessment\FormattedForAutogen_interRAI_ChYMH-DD_Form_Community-based_v9.3.0_2015.txt";
//Autogen.CreateAdultAssessmentFromFile(
//    assessmentFilePath,
//    "ChildMentalHealthAndDisability",
//    "Child and Youth Mental Health and Developmental Disability Community-Based Assessment");

// Adult
var assessmentFilePath = @"C:\Users\53108C\Documents\git\Matthew-OMES\AutogenAssessment\FormattedForAutogen_interRAI_ID_Standard_Form_v9.2.1_2013.txt";
Autogen.CreateAssessmentFromFile(
    assessmentFilePath,
    "AdultMentalHealthAndDisability",
    "Adult Intellectual Disability (ID) Assessment");

Autogen.WriteNamesToFile();

Console.WriteLine("Press any key to end.");
Console.ReadKey();
