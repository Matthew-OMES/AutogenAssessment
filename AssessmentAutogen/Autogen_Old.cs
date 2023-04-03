/*
using AssessmentAutogen.Model;
using AssessmentAutogen.Library;

namespace AssessmentAutogen
{
    public static class Autogen_Old
    {
        public const string AssessmentFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\Assessments\Assessments\Adult\";

        public const string ResultFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\AutogenResults\";

        public static List<AutogenSuccess> CreateAssessmentsFromFiles()
        {
            var filesSuccess = new List<AutogenSuccess>();

            var filePaths = Directory.GetFiles(AssessmentFilePath);

            foreach(var filepath in filePaths)
            {
                filesSuccess.Add(CreateAssessmentFromFile(filepath));
            }

            WriteAssessmentsToFile(filesSuccess.Where(x => x.Success).Select(y => y.Assessment).ToList());

            return filesSuccess;
        }

        private static AutogenSuccess CreateAssessmentFromFile(string filePath)
        {
            try
            {
                var fileLines = File.ReadAllLines(filePath).ToList();

                var assessmentSuccess = Parser.GenerateModel(filePath, fileLines);
                foreach(var question in assessmentSuccess.Assessment.Questions)
                {
                    Console.WriteLine($"{assessmentSuccess.Assessment.Name}: {assessmentSuccess.Success}, {question.Text}");
                }

                return assessmentSuccess;
            }
            catch (Exception ex)
            {
                var error = $"Uncaught Exception for file {AssessmentFilePath}: {ex.Message}, {ex.InnerException?.Message ?? "No Inner Exception"}";
                Console.WriteLine(error);
                return new AutogenSuccess { Success = false, Text = error };
            }
        }

        private static void WriteAssessmentsToFile(List<AssessmentModel> models)
        {
            var result = new List<string>
            {
                "using System.Collections.Generic;",
                "using SetNamespaceHere;",
                "",
                "public static class AssessmentGeneration",
                "{",
                "public static List<AssessmentModel> Assessments = new List<AssessmentModel>",
                "{"
            };

            foreach (var model in models)
            {
                result.Add("new AssessmentModel");
                result.Add("{");
                result.Add($"Name = \"{model.Name}\",");
                result.Add("Questions = new List<QuestionModel>");
                result.Add("{");
                foreach(var question in model.Questions)
                {
                    result.Add("new QuestionModel");
                    result.Add("{");
                    result.Add($"Id = new Guid(\"{question.Id}\"),");
                    result.Add($"Index = {question.Index},");
                    result.Add($"Name = \"{question.Name}\",");
                    result.Add($"Text = \"{question.Text}\",");
                    result.Add($"ValidInputs = new List<string>");
                    result.Add("{");
                    result.Add($"\"{string.Join("\",\"",question.ValidInputs)}\"");
                    result.Add("},");
                    result.Add($"QuestionType = \"{question.QuestionType}\",");
                    result.Add("Choices = new List<ResponseModel>");
                    result.Add("{");
                    foreach(var response in question.Choices)
                    {
                        result.Add("new QuestionModel");
                        result.Add("{");
                        result.Add($"Id = new Guid(\"{response.Id}\"),");
                        result.Add($"QuestionId = new Guid(\"{response.QuestionId}\"),");
                        result.Add($"Text = \"{response.Text}\",");
                        result.Add("},");
                    }
                    result.Add("}");
                    result.Add("},");
                }
                result.Add("}");
                result.Add("},");
            }

            result.Add("};");
            result.Add("}");

            var fileName = ResultFilePath + "AssessmentGeneration_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";

            File.WriteAllLines(fileName, result.ToArray());
        }
    }
}
*/