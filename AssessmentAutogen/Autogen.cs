using System.Collections.Generic;
using System.Linq;
using AssessmentAutogen.Model;
using AssessmentAutogen.Library;

namespace AssessmentAutogen
{
    public static class Autogen
    {
        //public const string AssessmentFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\FormattedForAutogen_interRAI_ChYMH-DD_Form_Community-based_v9.3.0_2015 (1).txt";
        public const string AssessmentFilePath = @"C:\Users\53108C\Documents\git\Matthew-OMES\AutogenAssessment\FormattedForAutogen_interRAI_ChYMH-DD_Form_Community-based_v9.3.0_2015 (1).txt";
        
        public const string ResultFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\AutogenResults\";

        public static AutogenSuccess CreateAdultAssessmentFromFile()
        {
            var fileSuccess = CreateAssessmentFromFile(AssessmentFilePath);

            //WriteAssessmentToFile(fileSuccess.Assessment);

            return fileSuccess;
        }

        private static AutogenSuccess CreateAssessmentFromFile(string filePath)
        {
            try
            {
                var fileLines = File.ReadAllLines(filePath).ToList();

                var assessmentSuccess = Parser.GenerateModel(
                    filePath, 
                    "ChildMentalHealthAndDisability",
                    "Child and Youth Mental Health and Developmental Disability Community-Based Assessment", 
                    fileLines);

                return assessmentSuccess;
            }
            catch (Exception ex)
            {
                var error = $"Uncaught Exception for file {AssessmentFilePath}: {ex.Message}, {ex.InnerException?.Message ?? "No Inner Exception"}";
                Console.WriteLine(error);
                return new AutogenSuccess { Success = false, Text = error };
            }
        }
        /*
        private static void WriteAssessmentToFile(AssessmentModel model)
        {
            var result = new List<string>
            {
                "using System.Collections.Generic;",
                "using SetNamespaceHere;",
                "",
                "public static class AssessmentGeneration",
                "{",
                "\tpublic static List<AssessmentModel> Assessments = new List<AssessmentModel>",
                "\t{",
                "\t\tnew AssessmentModel",
                "\t\t{",
                $"\t\t\tName = \"{model.Name}\",",
                "\t\t\tQuestions = new List<QuestionModel>",
                "\t\t\t{"
            };

            foreach (var question in model.Questions)
                {
                    result.Add("\t\t\t\tnew QuestionModel");
                    result.Add("\t\t\t\t{");
                    result.Add($"\t\t\t\t\tId = new Guid(\"{question.Id}\"),");
                    result.Add($"\t\t\t\t\tIndex = {question.Index},");
                    result.Add($"\t\t\t\t\tName = \"{question.Name}\",");
                    result.Add($"\t\t\t\t\tText = \"{question.Text}\",");
                    result.Add($"\t\t\t\t\tValidInputs = new List<string>");
                    result.Add("\t\t\t\t\t{");
                    result.Add($"\t\t\t\t\t\t\"{string.Join("\",\"",question.ValidInputs)}\"");
                    result.Add("\t\t\t\t\t},");
                    result.Add($"\t\t\t\t\tQuestionType = \"{question.QuestionType}\",");
                    result.Add("\t\t\t\t\tChoices = new List<ResponseModel>");
                    result.Add("\t\t\t\t\t{");
                    foreach(var response in question.Choices)
                    {
                        result.Add("\t\t\t\t\t\tnew QuestionModel");
                        result.Add("\t\t\t\t\t\t{");
                        result.Add($"\t\t\t\t\t\tId = new Guid(\"{response.Id}\"),");
                        result.Add($"\t\t\t\t\t\tQuestionId = new Guid(\"{response.QuestionId}\"),");
                        result.Add($"\t\t\t\t\t\tText = \"{response.Text}\",");
                        result.Add("\t\t\t\t\t\t},");
                    }
                    result.Add("\t\t\t\t\t}");
                    result.Add("\t\t\t\t},");
                }

            result.Add("\t\t\t}");
            result.Add("\t\t},");

            result.Add("\t};");
            result.Add("}");

            var fileName = ResultFilePath + "AssessmentGeneration_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";

            File.WriteAllLines(fileName, result.ToArray());
        }
        */
    }
}
