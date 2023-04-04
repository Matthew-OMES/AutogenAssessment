using AssessmentAutogen.Model;
using AssessmentAutogen.Library;

namespace AssessmentAutogen
{
    public static class Autogen
    {
        //public const string AssessmentFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\FormattedForAutogen_interRAI_ChYMH-DD_Form_Community-based_v9.3.0_2015 (1).txt";
        //public const string AssessmentFilePath = @"C:\Users\53108C\Documents\git\Matthew-OMES\AutogenAssessment\FormattedForAutogen_interRAI_ChYMH-DD_Form_Community-based_v9.3.0_2015 (1).txt";
        public const string AssessmentFilePath = @"C:\Users\53108C\Documents\git\Matthew-OMES\AutogenAssessment\TEST_FormattedForAutogen_interRAI_ChYMH-DD_Form_Community-based_v9.3.0_2015 (1).txt";

        public const string ResultFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\AutogenResults\";

        public static AutogenSuccess CreateAdultAssessmentFromFile()
        {
            var fileSuccess = CreateAssessmentFromFile(AssessmentFilePath);

            WriteAssessmentToFile(fileSuccess.Assessment);

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

        private static void WriteAssessmentToFile(AssessmentModel model)
        {
            var result = new List<string>
            {
                "using System.Collections.Generic;",
                "using AssessmentAutogen.Model;",
                "",
                "public static class AssessmentGeneration",
                "{",
                "\tpublic static List<AssessmentModel> Assessments = new List<AssessmentModel>",
                "\t{",
                "\t\tnew AssessmentModel",
                "\t\t{",
                $"\t\t\tId = new Guid(\"{model.Id}\"),",
                $"\t\t\tName = \"{model.Name}\",",
                $"\t\t\tText = \"{model.Text}\",",
                "\t\t\tSections = new List<SectionModel>",
                "\t\t\t{"
            };

            foreach (var section in model.Sections)
            {

                result.Add("\t\t\t\tnew SectionModel");
                result.Add("\t\t\t\t{");
                result.Add($"\t\t\t\t\tId = new Guid(\"{section.Id}\"),");
                result.Add($"\t\t\t\t\tIndex = \"{section.Index}\",");
                result.Add($"\t\t\t\t\tDescription = \"{section.Description}\",");
                result.Add("\t\t\t\t\tQuestions = new List<QuestionModel>");
                result.Add("\t\t\t\t\t{");
                foreach (var question in section.Questions)
                {
                    result.Add("\t\t\t\t\t\tnew QuestionModel");
                    result.Add("\t\t\t\t\t\t{");
                    result.Add($"\t\t\t\t\t\t\tId = new Guid(\"{question.Id}\"),");
                    result.Add($"\t\t\t\t\t\t\tIndex = \"{question.Index}\",");
                    result.Add($"\t\t\t\t\t\t\tName = \"{question.Name}\",");
                    result.Add($"\t\t\t\t\t\t\tText = \"{question.Text}\",");
                    result.Add($"\t\t\t\t\t\t\tSubText = \"{question.SubText}\",");
                    result.Add($"\t\t\t\t\t\t\tDefaultValue = null,");
                    result.Add($"\t\t\t\t\t\t\tQuestionType = \"{question.QuestionType}\",");
                    result.Add("\t\t\t\t\t\t\tChoices = new List<ResponseModel>");
                    result.Add("\t\t\t\t\t\t\t{");
                    foreach(var response in question.Choices)
                    {
                        result.Add("\t\t\t\t\t\tnew ResponseModel");
                        result.Add("\t\t\t\t\t\t{");
                        result.Add($"\t\t\t\t\t\tId = new Guid(\"{response.Id}\"),");
                        result.Add($"\t\t\t\t\t\tQuestionId = new Guid(\"{response.QuestionId}\"),");
                        result.Add($"\t\t\t\t\t\tValue = \"{response.Value}\",");
                        result.Add($"\t\t\t\t\t\tText = \"{response.Text}\",");
                        result.Add("\t\t\t\t\t\t},");
                    }
                    result.Add("\t\t\t\t\t\t\t},");
                    result.Add("\t\t\t\t\t\t\tSubQuestions = new List<QuestionModel>");
                    result.Add("\t\t\t\t\t\t\t{");
                    foreach (var subQuestion in question.SubQuestions)
                    {
                        result.Add("\t\t\t\t\t\t\t\tnew QuestionModel");
                        result.Add("\t\t\t\t\t\t\t\t{");
                        result.Add($"\t\t\t\t\t\t\t\t\tId = new Guid(\"{subQuestion.Id}\"),");
                        result.Add($"\t\t\t\t\t\t\t\t\tIndex = \"{subQuestion.Index}\",");
                        result.Add($"\t\t\t\t\t\t\t\t\tName = \"{subQuestion.Name}\",");
                        result.Add($"\t\t\t\t\t\t\t\t\tText = \"{subQuestion.Text}\",");
                        result.Add($"\t\t\t\t\t\t\t\t\tSubText = \"{subQuestion.SubText}\",");
                        result.Add($"\t\t\t\t\t\t\t\t\tDefaultValue = null,");
                        result.Add($"\t\t\t\t\t\t\t\t\tQuestionType = \"{subQuestion.QuestionType}\",");
                        result.Add("\t\t\t\t\t\t\t\t\tChoices = new List<ResponseModel>");
                        result.Add("\t\t\t\t\t\t\t\t\t{");
                        foreach (var response in question.Choices)
                        {
                            result.Add("\t\t\t\t\t\tnew ResponseModel");
                            result.Add("\t\t\t\t\t\t{");
                            result.Add($"\t\t\t\t\t\tId = new Guid(\"{response.Id}\"),");
                            result.Add($"\t\t\t\t\t\tQuestionId = new Guid(\"{response.QuestionId}\"),");
                            result.Add($"\t\t\t\t\t\tValue = \"{response.Value}\",");
                            result.Add($"\t\t\t\t\t\tText = \"{response.Text}\",");
                            result.Add("\t\t\t\t\t\t},");
                        }
                        result.Add("\t\t\t\t\t},");
                        result.Add("\t\t\t\t\t},");
                    }
                    result.Add("\t\t\t\t\t\t\t},");
                    result.Add("\t\t\t\t\t\t},");
                }
                result.Add("\t\t\t\t\t}");
                result.Add("\t\t\t\t},");
            }
            result.Add("\t\t\t},");
            result.Add("\t\t},");

            result.Add("\t};");
            result.Add("}");

            var fileName = ResultFilePath + "AssessmentGeneration_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";

            File.WriteAllLines(fileName, result.ToArray());
        }
    }
}
