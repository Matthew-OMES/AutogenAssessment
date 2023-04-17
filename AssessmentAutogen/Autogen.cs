using AssessmentAutogen.Model;
using AssessmentAutogen.Library;

namespace AssessmentAutogen
{
    public static class Autogen
    {
        public const string ResultFilePath = @"C:\Users\53108C\Documents\OMES\Waitlist\AutogenResults\";

        public static void WriteNamesToFile()
        {
            var names = new List<string>();

            // Have to go in order, so the variable names are in order
            foreach(var section in AssessmentGeneration.Assessments[0].Sections)
            { 
                foreach(var question in section.Questions)
                {
                    if(question.SubQuestions.Count == 0)
                    {
                        names.Add(question.Name);
                    }
                    else
                    {
                        names.AddRange(question.SubQuestions.Select(x => x.Name));
                    }
                }
            }

            var fileName = ResultFilePath + "AssessmentVariables" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";

            File.WriteAllLines(fileName, names.ToArray());
        }

        public static AutogenSuccess CreateAssessmentFromFile(string filePath, string modelName, string description)
        {
            var fileSuccess = CreateAssessmentModelFromFile(filePath, modelName, description);

            WriteAssessmentToFile(fileSuccess.Assessment);
            WriteAssessmentToMultipleFiles(fileSuccess.Assessment);

            return fileSuccess;
        }

        private static AutogenSuccess CreateAssessmentModelFromFile(string filePath, string modelName, string description)
        {
            try
            {
                var fileLines = File.ReadAllLines(filePath).ToList();

                var assessmentSuccess = Parser.GenerateModel(filePath, modelName, description, fileLines);

                return assessmentSuccess;
            }
            catch (Exception ex)
            {
                var error = $"Uncaught Exception for file {filePath}: {ex.Message}, {ex.InnerException?.Message ?? "No Inner Exception"}";
                Console.WriteLine(error);
                return new AutogenSuccess { Success = false, Text = error };
            }
        }

        private static void WriteAssessmentToMultipleFiles(AssessmentModel model)
        {
            var directory = Directory.CreateDirectory(ResultFilePath + model.Name + DateTime.Now.ToString("yyyyMMdd_hhmmss"));

            var assessmentResult = new List<string>
            {
                //"using AssessmentAutogen.Model;",
                "namespace Okdhs.Waitlist.Models.Assessment",
                "{",
                "public static class Assessments",
                "{",
                $"\tpublic static AssessmentModel {model.Name}Assessment = new AssessmentModel",
                "\t{",
                $"\t\tId = new Guid(\"{model.Id}\"),",
                $"\t\tName = \"{model.Name}\",",
                $"\t\tText = \"{model.Text}\",",
                "\t\tSections = new List<SectionModel>",
                "\t\t{"
            };

            foreach (var section in model.Sections)
            {
                assessmentResult.Add($"\t\t\tAssessment.{model.Name}Assessment.Section{section.Index},");
            }

            assessmentResult.Add("\t\t}");
            assessmentResult.Add("\t}");
            assessmentResult.Add("}");
            assessmentResult.Add("}");

            File.WriteAllLines(directory.FullName + "\\" +  model.Name + ".cs", assessmentResult.ToArray());

            foreach (var section in model.Sections)
            {
                var sectionResult = new List<string>
                {
                    //"using AssessmentAutogen.Model;",
                    "namespace Okdhs.Waitlist.Models.Assessment",
                    "{",
                    $"public static partial class {model.Name}Assessment",
                    "{",
                    $"\tpublic static SectionModel Section{section.Index} = new SectionModel",
                    "\t{",
                    $"\t\tId = new Guid(\"{section.Id}\"),",
                    $"\t\tIndex = \"{section.Index}\",",
                    $"\t\tDescription = \"{section.Description}\",",
                    "\t\tQuestions = new List<QuestionModel>",
                    "\t\t{"
                };
                foreach (var question in section.Questions)
                {
                    sectionResult.Add("\t\t\tnew QuestionModel");
                    sectionResult.Add("\t\t\t{");
                    sectionResult.Add($"\t\t\t\tId = new Guid(\"{question.Id}\"),");
                    sectionResult.Add($"\t\t\t\tIndex = \"{question.Index}\",");
                    sectionResult.Add($"\t\t\t\tName = \"{question.Name}\",");
                    sectionResult.Add($"\t\t\t\tText = \"{question.Text}\",");
                    sectionResult.Add($"\t\t\t\tSubText = \"{question.SubText}\",");
                    sectionResult.Add($"\t\t\t\tDefaultValue = null,");
                    sectionResult.Add($"\t\t\t\tQuestionType = \"{question.QuestionType}\",");
                    sectionResult.Add("\t\t\t\tChoices = new List<ResponseModel>");
                    sectionResult.Add("\t\t\t\t{");
                    foreach (var response in question.Choices)
                    {
                        sectionResult.Add("\t\t\t\t\tnew ResponseModel");
                        sectionResult.Add("\t\t\t\t\t{");
                        sectionResult.Add($"\t\t\t\t\tId = new Guid(\"{response.Id}\"),");
                        sectionResult.Add($"\t\t\t\t\tQuestionId = new Guid(\"{response.QuestionId}\"),");
                        sectionResult.Add($"\t\t\t\t\tValue = \"{response.Value}\",");
                        sectionResult.Add($"\t\t\t\t\tText = \"{response.Text}\",");
                        sectionResult.Add("\t\t\t\t\t},");
                    }
                    sectionResult.Add("\t\t\t\t},");
                    sectionResult.Add("\t\t\t\tSubQuestions = new List<QuestionModel>");
                    sectionResult.Add("\t\t\t\t{");
                    foreach (var subQuestion in question.SubQuestions)
                    {
                        sectionResult.Add("\t\t\t\t\tnew QuestionModel");
                        sectionResult.Add("\t\t\t\t\t{");
                        sectionResult.Add($"\t\t\t\t\t\tId = new Guid(\"{subQuestion.Id}\"),");
                        sectionResult.Add($"\t\t\t\t\t\tIndex = \"{subQuestion.Index}\",");
                        sectionResult.Add($"\t\t\t\t\t\tName = \"{subQuestion.Name}\",");
                        sectionResult.Add($"\t\t\t\t\t\tText = \"{subQuestion.Text}\",");
                        sectionResult.Add($"\t\t\t\t\t\tSubText = \"{subQuestion.SubText}\",");
                        sectionResult.Add($"\t\t\t\t\t\tDefaultValue = null,");
                        sectionResult.Add($"\t\t\t\t\t\tQuestionType = \"{subQuestion.QuestionType}\",");
                        sectionResult.Add("\t\t\t\t\t\tChoices = new List<ResponseModel>");
                        sectionResult.Add("\t\t\t\t\t\t{");
                        foreach (var response in subQuestion.Choices)
                        {
                            sectionResult.Add("\t\t\t\t\t\tnew ResponseModel");
                            sectionResult.Add("\t\t\t\t\t\t{");
                            sectionResult.Add($"\t\t\t\t\t\tId = new Guid(\"{response.Id}\"),");
                            sectionResult.Add($"\t\t\t\t\t\tQuestionId = new Guid(\"{response.QuestionId}\"),");
                            sectionResult.Add($"\t\t\t\t\t\tValue = \"{response.Value}\",");
                            sectionResult.Add($"\t\t\t\t\t\tText = \"{response.Text}\",");
                            sectionResult.Add("\t\t\t\t\t\t},");
                        }
                        sectionResult.Add("\t\t\t\t\t\t},");
                        sectionResult.Add("\t\t\t\t\t},");
                    }
                    sectionResult.Add("\t\t\t\t},");
                    sectionResult.Add("\t\t\t},");
                }
                sectionResult.Add("\t\t}");

                sectionResult.Add("\t};");
                sectionResult.Add("}");
                sectionResult.Add("}");

                File.WriteAllLines(directory.FullName + "\\" + "Section" + section.Index + ".cs", sectionResult.ToArray());
            }
        }

        private static void WriteAssessmentToFile(AssessmentModel model)
        {
            var result = new List<string>
            {
                //"using AssessmentAutogen.Model;",
                "namespace Okdhs.Waitlist.Models.Assessment",
                "{",
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
                        result.Add("\t\t\t\t\t\t\t\tnew ResponseModel");
                        result.Add("\t\t\t\t\t\t\t\t{");
                        result.Add($"\t\t\t\t\t\t\t\t\tId = new Guid(\"{response.Id}\"),");
                        result.Add($"\t\t\t\t\t\t\t\t\tQuestionId = new Guid(\"{response.QuestionId}\"),");
                        result.Add($"\t\t\t\t\t\t\t\t\tValue = \"{response.Value}\",");
                        result.Add($"\t\t\t\t\t\t\t\t\tText = \"{response.Text}\",");
                        result.Add("\t\t\t\t\t\t\t\t},");
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
                        result.Add("\t\t\t\t\t\t\t\t\t},");
                        result.Add("\t\t\t\t\t\t\t\t},");
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
            result.Add("}");

            var fileName = ResultFilePath + "AssessmentGeneration_" + model.Name + "_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";

            File.WriteAllLines(fileName, result.ToArray());
        }
    }
}
