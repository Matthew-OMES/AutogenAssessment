using AssessmentAutogen.Model;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;

namespace AssessmentAutogen.Library
{
    public static class Parser
    {

        public static AutogenSuccess GenerateModel(string filePath, string name, string text, List<string> fileLines)
        {
            try
            {
                var success = new AutogenSuccess
                {
                    Success = false,
                    Assessment = new AssessmentModel
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Text = text
                    }
                };

                fileLines.RemoveAll(x => string.IsNullOrWhiteSpace(x));

                var sectionEnd = 0;

                for (int sectionStart = 0; sectionStart < fileLines.Count; sectionStart = sectionEnd)
                {
                    var section = new SectionModel();
                    sectionEnd = fileLines.FindIndex(sectionStart + 1, x => x.StartsWith("SECTION"));

                    if(sectionEnd == -1) { sectionEnd = fileLines.Count; }

                    var sectionInfo = fileLines[sectionStart].Split("***");

                    section.Id = Guid.NewGuid();
                    section.Index = sectionInfo[1].Trim();
                    section.Description = sectionInfo[2];

                    var questionCount = 1;

                    var questionEnd = 0;

                    for (int questionStart = sectionStart + 1; questionStart < sectionEnd; questionStart = questionEnd)
                    {
                        try
                        {
                            if(questionCount == 12)
                            {

                            }
                            questionEnd = fileLines.FindIndex(
                                questionStart + 1,
                                x => x.StartsWith((questionCount + 1).ToString() + "."));

                            if (questionEnd == -1 || questionEnd >= sectionEnd) { questionEnd = sectionEnd; }

                            section.Questions.Add(ParseToQuestionModel(
                                fileLines.GetRange(questionStart, questionEnd - questionStart),
                                section.Index));

                            questionCount++;
                        }
                        catch(Exception e)
                        {
                            throw;
                        }
                    }

                    success.Assessment.Sections.Add(section);
                }

                success.Success = true;

                return success;
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public static QuestionModel ParseToQuestionModel(List<string> fileLines, string precedingIndex)
        {
            try
            {
                var questionLine = fileLines[0].Split("***");

                var questionIndex = questionLine[0].Trim().TrimEnd('.');

                if (questionLine.Length < 3)
                {
                    throw new Exception($"Question parsed incorrectly: {precedingIndex} + {questionIndex}");
                }

                var questionText = questionLine[2].Split("^^^");

                var question = new QuestionModel
                {
                    Id = Guid.NewGuid(),
                    Index = questionIndex,
                    Name = questionText[0].CleanseName() + "_" + precedingIndex + questionIndex,
                    Text = questionText[0],
                    SubText = questionText.Length >= 2 ? questionText[1] : ""
                };

                switch (questionLine[1])
                {
                    case "T":
                        question.QuestionType = Constants.QuestionType.Text;
                        break;
                    case "Date":
                        question.QuestionType = Constants.QuestionType.Date;
                        break;
                    case "DD":
                        question.QuestionType = Constants.QuestionType.DropdownList;
                        for (int i = 1; i < fileLines.Count; i++)
                        {
                            var choiceLine = fileLines[i].Split("&&&");

                            if (choiceLine.Length < 2)
                            {
                                throw new Exception($"Answer choice parsed incorrectly: {precedingIndex} + {questionIndex}");
                            }

                            question.Choices.Add(new ResponseModel
                            {
                                Id = Guid.NewGuid(),
                                QuestionId = question.Id,
                                Value = choiceLine[0].Trim(),
                                Text = choiceLine[1].Trim()
                            });
                        }
                        break;
                    case "QB":
                        question.QuestionType = Constants.QuestionType.QuestionBreakdown;

                        var questionCount = 'a';

                        var questionEnd = 0;

                        for (int questionStart = 1; questionStart < fileLines.Count; questionStart = questionEnd)
                        {
                            var nextChar = (char)(Convert.ToUInt16(questionCount) + 1);
                            questionEnd = fileLines.FindIndex(
                                questionStart,
                                x => x.Trim().StartsWith(nextChar + "."));

                            if (questionEnd == -1) { questionEnd = fileLines.Count; }

                            var questionLines = fileLines.GetRange(questionStart, questionEnd - questionStart);

                            question.SubQuestions.Add(ParseToQuestionModel(
                                questionLines,
                                precedingIndex + question.Index));

                            questionCount = nextChar;
                        }
                        break;
                }

                Console.WriteLine($"Question completed: {question.Name}");

                return question;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static string CleanseName(this string name)
        {
            var parts = name.Split(new string[] { " ", "\t", ".", ",", "/", "-" , "(", ")", "\'", "\"" }, StringSplitOptions.None);
            var ti = new CultureInfo("en-US", false).TextInfo;

            var nameText = ti.ToTitleCase(string.Join(' ', parts).ToLower()).Replace(" ", "");

            var rgx = new Regex("[^a-zA-Z0-9]_");

            return rgx.Replace(nameText, "");
        }

        /*
        public static List<string> GetValidInputs(string inputs)
        {
            var validInputs = new List<string>();

            var split = inputs.Split(',');

            foreach (var input in split)
            {
                if (input.Contains("-"))
                {
                    var range = input.Split("-");
                    int.TryParse(range[0], out var start);
                    int.TryParse(range[1], out var end);

                    for (int i = start; i <= end; i++)
                    {
                        validInputs.Add(i.ToString());
                    }
                }
                else
                {
                    validInputs.Add(input);
                }
            }

            return validInputs;
        }

        public static int GetMin(this int num1, int num2)
        {
            return num1 < num2 ? num1 : num2;
        }
        */
    }
}
