using AssessmentAutogen.Model;

namespace AssessmentAutogen
{
    public static class AssessmentGeneration
    {
        public static List<AssessmentModel> Assessments = new List<AssessmentModel>
    {
        new AssessmentModel
        {
            Id = new Guid("e74db4bc-f487-4bb7-92a3-73cda3a93e21"),
            Name = "ChildMentalHealthAndDisability",
            Text = "Child and Youth Mental Health and Developmental Disability Community-Based Assessment",
            Sections = new List<SectionModel>
            {
                new SectionModel
                {
                    Id = new Guid("435051aa-2cea-4e90-821a-96bf01347931"),
                    Index = "A",
                    Description = "Identification Information",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("09d6bd94-736b-4b1d-b554-e8bca4e536bf"),
                            Index = "1",
                            Name = "Name_A1",
                            Text = "NAME",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("6f433f83-22f5-432d-a326-c7bcd4086b14"),
                                    Index = "a",
                                    Name = "FirstName_A1a",
                                    Text = "First Name",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("06d79a3c-6c28-491d-94a0-ecd269e8306d"),
                                    Index = "b",
                                    Name = "MiddleInitial_A1b",
                                    Text = "Middle initial",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("eec0aa34-d8d8-4e4f-915e-199e77944d4b"),
                                    Index = "c",
                                    Name = "LastName_A1c",
                                    Text = "Last Name",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("dce2c3b5-954f-4bba-895f-6c88f5795f26"),
                                    Index = "d",
                                    Name = "Suffix_A1d",
                                    Text = "Suffix",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("bed05ac0-68c0-44f0-8a71-770cbcd5e6a0"),
                            Index = "2",
                            Name = "Sex_A2",
                            Text = "SEX",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("afd7d226-4e70-4b96-a213-d00136fd354c"),
                                    QuestionId = new Guid("bed05ac0-68c0-44f0-8a71-770cbcd5e6a0"),
                                    Value = "1",
                                    Text = "Male",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f6361ef8-8c05-432a-896c-7936adbb7460"),
                                    QuestionId = new Guid("bed05ac0-68c0-44f0-8a71-770cbcd5e6a0"),
                                    Value = "2",
                                    Text = "Female",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("00726219-d2ba-4000-8bc9-b215ec59491b"),
                            Index = "3",
                            Name = "Birthdate_A3",
                            Text = "BIRTHDATE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DATE",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("a79105ab-457c-4681-9185-54283ea79058"),
                            Index = "4",
                            Name = "NumericIdentifiers_A4",
                            Text = "NUMERIC IDENTIFIERS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("a75f9d68-4686-4cd2-a3b6-b66a979c5f0e"),
                                    Index = "a",
                                    Name = "HealthCareIdentificationNumber_A4a",
                                    Text = "Health Care Identification Number",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e91b9400-47df-4bfd-9eb9-40d7f89dddcf"),
                                    Index = "b",
                                    Name = "ProvinceOrTerritoryIssuingHealthCareIdentificationNumber_A4b",
                                    Text = "Province or Territory Issuing Health Care Identification Number",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("53d4ce19-9f47-469a-9881-2316ea891afd"),
                                    Index = "c",
                                    Name = "CaseRecordNumber_A4c",
                                    Text = "Case Record Number",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("88dc5c4f-b2c6-4c01-be93-172e15aab5ac"),
                            Index = "5",
                            Name = "AgencyIdentifier_A5",
                            Text = "AGENCY IDENTIFIER",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("77cb6701-a0de-490b-9df1-8b33d6af4570"),
                            Index = "6",
                            Name = "CurrentPaymentSources_A6",
                            Text = "CURRENT PAYMENT SOURCES",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("03ae42dd-f4c4-4bab-94ed-d4e95e2c7b1a"),
                                    Index = "a",
                                    Name = "ProvincialOrTerritorialGovernmentPlan_A6a",
                                    Text = "Provincial or territorial government plan",
                                    SubText = "this province or territory",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1c801615-f968-47b2-8c68-9f4ec35a3303"),
                                    Index = "b",
                                    Name = "ProvincialOrTerritorialGovernmentPlan_A6b",
                                    Text = "Provincial or territorial government plan",
                                    SubText = "other province or territory",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("cc3e6fe9-3912-4ebe-9cce-bcfc130d6531"),
                                    Index = "c",
                                    Name = "FederalGovernment_A6c",
                                    Text = "Federal government",
                                    SubText = "First Nations and Inuit Health Branch (FNIHB)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("711fa2e5-eebb-48fd-aae6-b8ba860ba3df"),
                                    Index = "d",
                                    Name = "CanadianResidentInsurancePay_A6d",
                                    Text = "Canadian resident, insurance pay",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d33435be-d1c9-4ddf-9fb0-a83367f37c92"),
                                    Index = "e",
                                    Name = "CanadianResidentPublicTrusteePay_A6e",
                                    Text = "Canadian resident, public trustee pay",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5870fdf1-d050-4bc1-bf08-1d1bf9849779"),
                                    Index = "f",
                                    Name = "CanadianResidentSelfPay_A6f",
                                    Text = "Canadian resident, self-pay",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("106a3a02-63d4-40d6-996e-50201862e946"),
                                    Index = "g",
                                    Name = "OtherCountryResidentSelfPay_A6g",
                                    Text = "Other country resident, self-pay",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("bd3f1853-8a4f-42f5-92d4-e9947985cdfe"),
                                    Index = "h",
                                    Name = "ResponsibilityForPaymentUnknownOrUnavailable_A6h",
                                    Text = "Responsibility for payment unknown or unavailable",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                            Index = "7",
                            Name = "ReasonForAssessment_A7",
                            Text = "REASON FOR ASSESSMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("5af9092b-68f1-4964-86f3-6d3c4175dac9"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "1",
                                    Text = "First assessment",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("51f6f067-1c41-46d9-92b8-a8f3f70a0ef6"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "2",
                                    Text = "Routine reassessment",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("272099a2-53aa-4c3a-8739-859fef8a68ca"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "3",
                                    Text = "Return assessment",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0ebb95fb-c560-4a72-bdd6-b832bb148229"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "4",
                                    Text = "Significant change in status reassessment",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7d09fb7a-d1f4-4f9a-a251-be77bbd82cea"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "5",
                                    Text = "Discharge assessment covers last 3–7 days of service",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("72568289-4211-43a8-8d3d-13912958b876"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "6",
                                    Text = "Discharge tracking only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7aee0600-8c06-49f4-bf94-335dd8e6a79f"),
                                    QuestionId = new Guid("ef350021-fb9e-4612-9001-2290044e6e1f"),
                                    Value = "7",
                                    Text = "Other — e.g., research",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("e9add971-c354-43ce-ae44-b67feffda571"),
                            Index = "8",
                            Name = "AssessmentReferenceDate_A8",
                            Text = "ASSESSMENT REFERENCE DATE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DATE",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("d0f4927a-824e-414c-95a6-516cfb5b80e9"),
                            Index = "9",
                            Name = "ExpressedGoals_A9",
                            Text = "EXPRESSED GOALS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("85e446f0-d6cb-4988-a800-0ae17a8803b5"),
                                    Index = "a",
                                    Name = "ChildSYouthSGoals_A9a",
                                    Text = "Child’s / youth’s goals",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1f573146-aab2-4423-9ec6-3d8b43cec09f"),
                                    Index = "b",
                                    Name = "ParentSCaregiverSGoals_A9b",
                                    Text = "Parent’s / caregiver’s goals",
                                    SubText = "for child / youth",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                            Index = "10",
                            Name = "LegalGuardianship_A10",
                            Text = "LEGAL GUARDIANSHIP",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("11fe4917-8f3f-495c-a1e8-392fe6d28f81"),
                                    QuestionId = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                                    Value = "1",
                                    Text = "Both parents",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e9fcc959-4fa5-4f05-aebc-7cb3d92142d4"),
                                    QuestionId = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                                    Value = "2",
                                    Text = "Mother only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b2318fd9-d325-4f7b-af60-b13a38ba2ab8"),
                                    QuestionId = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                                    Value = "3",
                                    Text = "Father only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("00a37e48-b3ad-422b-9646-d14832e4ccb6"),
                                    QuestionId = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                                    Value = "4",
                                    Text = "Neither parent but other relative(s) or nonrelative(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f9529fe0-f9af-49fc-a4d1-a63d9bf026d3"),
                                    QuestionId = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                                    Value = "5",
                                    Text = "Child protection agency (e.g., CAS)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bb2a95c0-9514-4f2a-a63d-32fd8758e163"),
                                    QuestionId = new Guid("9a09a23a-e80a-4786-b8a4-25c8469fb616"),
                                    Value = "6",
                                    Text = "Youth responsible for self",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("28a49fc1-3237-4f06-9c21-e35d2b60fc1b"),
                            Index = "11",
                            Name = "CurrentDisputeOverCustodyOrChildYouthAccess_A11",
                            Text = "CURRENT DISPUTE OVER CUSTODY OR CHILD / YOUTH ACCESS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("2f902607-a216-45ed-82c1-8e4f52431883"),
                                    Index = "a",
                                    Name = "ThisChildYouth_A11a",
                                    Text = "This child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("bda05e4f-1d7f-4405-afc1-358b38057d86"),
                                    Index = "b",
                                    Name = "OtherChildRenYouth_A11b",
                                    Text = "Other child(ren) / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("59fddb8a-28b6-470e-9d5b-05bd059838a8"),
                    Index = "B",
                    Description = "Intake and Initial History",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("3ea35ca0-0048-4160-96a4-4919f83f2186"),
                            Index = "1",
                            Name = "ReasonsForAdmission_B1",
                            Text = "REASONS FOR ADMISSION",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("093960ed-ec84-468b-9f17-36d1d4b0155c"),
                                    Index = "a",
                                    Name = "ThreatOrDangerToSelf_B1a",
                                    Text = "Threat or danger to self",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e97fae27-01fa-4083-8483-4bda280d43b6"),
                                    Index = "b",
                                    Name = "ThreatOrDangerToOthers_B1b",
                                    Text = "Threat or danger to others",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("505cea64-e169-4321-b26e-115d370d193a"),
                                    Index = "c",
                                    Name = "ProblemWithAddictionOrDependency_B1c",
                                    Text = "Problem with addiction or dependency",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8b7d0f0c-00f4-44f3-ba3f-5baa152a88c7"),
                                    Index = "d",
                                    Name = "SpecificPsychiatricSymptoms_B1d",
                                    Text = "Specific psychiatric symptoms",
                                    SubText = "e.g., severe behaviour problems, depression, hallucinations",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("420cf29a-3849-407c-aca2-788ed22ebfcd"),
                                    Index = "e",
                                    Name = "InvolvementWithYouthJusticeSystem_B1e",
                                    Text = "Involvement with youth justice system",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("4f287ffe-9890-4012-b0ae-878c428a4a9d"),
                            Index = "2",
                            Name = "DateCaseOpened_B2",
                            Text = "DATE CASE OPENED",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DATE",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("9ce74cc1-2b54-4ee1-8ecf-8e443383e38c"),
                            Index = "3",
                            Name = "AboriginalIdentity_B3",
                            Text = "ABORIGINAL IDENTITY",
                            SubText = "Child / youth identifies self as First Nations, Metis, or Inuit",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("01f1f647-984b-40d8-ab13-94eb7a8d9fdb"),
                                    Index = "a",
                                    Name = "FirstNations_B3a",
                                    Text = "First Nations",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c1edcd88-c6fa-4f8a-814f-bb68890cff37"),
                                    Index = "b",
                                    Name = "Metis_B3b",
                                    Text = "Metis",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("26d3b2cb-20c5-474c-823b-bbdfd289f27d"),
                                    Index = "c",
                                    Name = "Inuit_B3c",
                                    Text = "Inuit",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("2e6a9906-3574-4096-b1b1-a9eeaebda1cb"),
                            Index = "4",
                            Name = "PrimaryLanguage_B4",
                            Text = "PRIMARY LANGUAGE",
                            SubText = "See HCC Language Codes document for additional codes",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("289a89ee-3890-41dd-8090-41c188c5ecc8"),
                                    QuestionId = new Guid("2e6a9906-3574-4096-b1b1-a9eeaebda1cb"),
                                    Value = "eng",
                                    Text = "English",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("1d574d03-8ba6-4875-a6fe-24c3605521d5"),
                                    QuestionId = new Guid("2e6a9906-3574-4096-b1b1-a9eeaebda1cb"),
                                    Value = "fre",
                                    Text = "French",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e2ba284f-841f-4470-8c6d-fe537ebb291a"),
                                    QuestionId = new Guid("2e6a9906-3574-4096-b1b1-a9eeaebda1cb"),
                                    Value = "asl",
                                    Text = "American Sign Language",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("77ad037f-cb4e-4e04-8ce6-b0b0f9cff484"),
                            Index = "5",
                            Name = "InterpreterNeeded_B5",
                            Text = "INTERPRETER NEEDED",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("ed12c74c-cecf-484c-b188-82d12ebc235c"),
                                    Index = "a",
                                    Name = "ChildYouth_B5a",
                                    Text = "Child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b2ff2f76-50b9-49bb-aad0-5638623da75b"),
                                    Index = "b",
                                    Name = "EitherParentPrimaryCaregiver_B5b",
                                    Text = "Either parent / primary caregiver",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                            Index = "6",
                            Name = "BiologicalMotherSAgeAtTimeOfChildSYouthSBirth_B6",
                            Text = "BIOLOGICAL MOTHER’S AGE AT TIME OF CHILD’S / YOUTH’S BIRTH",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("16d1df2f-7f60-4f5f-a8cc-b4f9930ef35e"),
                                    QuestionId = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                                    Value = "1",
                                    Text = "Under 16",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("dfcc9a98-f565-4bba-baac-fcab5735d386"),
                                    QuestionId = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                                    Value = "2",
                                    Text = "16–19",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c99272b2-c26c-4d27-8128-7c91ba76a743"),
                                    QuestionId = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                                    Value = "3",
                                    Text = "20–29",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a2b4f25c-113f-4af4-b507-bc6974f028b1"),
                                    QuestionId = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                                    Value = "4",
                                    Text = "30–39",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("861f68ba-4a4e-4416-990b-041c7816d3fa"),
                                    QuestionId = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                                    Value = "5",
                                    Text = "40+",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("28e4e1d8-0d0b-4782-9511-dd24e27e2b8a"),
                                    QuestionId = new Guid("b783ed17-704d-4195-aeea-4087f40995a6"),
                                    Value = "8",
                                    Text = "Unknown",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                            Index = "7",
                            Name = "MaritalStatusOfParents_B7",
                            Text = "MARITAL STATUS OF PARENTS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("99d4cfa2-2f3b-46f0-b094-4b6b3108c3e9"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "1",
                                    Text = "Never married",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("233d1069-7df7-4554-bc6d-869020e34a79"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "2",
                                    Text = "Married",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0ecba4f1-3cd6-4619-ba00-8d6d41818e7e"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "3",
                                    Text = "Partner / significant other",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0384cf2d-43d6-4903-963e-26921309517f"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "4",
                                    Text = "Widowed",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ddca33f1-f1eb-4aa8-89be-29db0039b8db"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "5",
                                    Text = "Separated",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c8a03906-f680-4b58-9c6d-ce5975479d68"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "6",
                                    Text = "Divorced",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8f4d84cb-fce0-4b89-b27d-e8b779b7af22"),
                                    QuestionId = new Guid("5e2ebe1d-c29f-4235-bf8d-183f56bc86a8"),
                                    Value = "8",
                                    Text = "Marital status unknown",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1abc48fd-498a-4636-861f-7e52ddd7ec55"),
                            Index = "8",
                            Name = "HistoryOfFosterFamilyPlacement_B8",
                            Text = "HISTORY OF FOSTER FAMILY PLACEMENT",
                            SubText = "Include present placement, if applicable; include any kinship care placements",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("8371936b-1fca-48c6-8f72-118686ed952d"),
                                    QuestionId = new Guid("1abc48fd-498a-4636-861f-7e52ddd7ec55"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7a7900c9-7bf4-4e83-b5ce-aa5ffea0d993"),
                                    QuestionId = new Guid("1abc48fd-498a-4636-861f-7e52ddd7ec55"),
                                    Value = "1",
                                    Text = "1 foster family",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("012d3f18-f6b4-463a-82dd-d37c03a3b539"),
                                    QuestionId = new Guid("1abc48fd-498a-4636-861f-7e52ddd7ec55"),
                                    Value = "2",
                                    Text = "Multiple foster families",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("a3ee434f-e669-4374-a7c0-04f89be89662"),
                            Index = "9",
                            Name = "HistoryOfCareIncludesSevereFailureToProvideForBasicNeeds_B9",
                            Text = "HISTORY OF CARE INCLUDES SEVERE FAILURE TO PROVIDE FOR BASIC NEEDS",
                            SubText = "Code for child’s / youth’s age at earliest occurrence",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("36dccab6-dbd3-4480-849e-ac1b6fcb9ed2"),
                                    Index = "a",
                                    Name = "EmotionalNeglect_B9a",
                                    Text = "Emotional neglect",
                                    SubText = "e.g., left in crib for prolonged periods",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("560186aa-ee0a-4cad-b91f-69aae9c4e017"),
                                    Index = "b",
                                    Name = "PhysicalNeeds_B9b",
                                    Text = "Physical needs",
                                    SubText = "e.g., inadequate winter clothing",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4bb76d49-198f-4a0a-b016-483b17501b9e"),
                                    Index = "c",
                                    Name = "SafetyNeeds_B9c",
                                    Text = "Safety needs",
                                    SubText = "e.g., child left in car in summer heat",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("8acf9a62-4696-4828-96b4-50a5a67fa465"),
                            Index = "10",
                            Name = "MaternalSubstanceUseDuringPregnancy_B10",
                            Text = "MATERNAL SUBSTANCE USE DURING PREGNANCY",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("c2982880-77bc-4691-8741-30ba23169688"),
                                    Index = "a",
                                    Name = "AlcoholUse_B10a",
                                    Text = "Alcohol use",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e4ea129c-bcbc-4e08-9555-146178e0f1ad"),
                                    Index = "b",
                                    Name = "DrugUseExcludePrescribedMedicationThatWasTakenAsDirected_B10b",
                                    Text = "Drug use — EXCLUDE PRESCRIBED MEDICATION THAT WAS TAKEN AS DIRECTED",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("e729d5ae-dd16-460b-8eb4-247294738d5b"),
                            Index = "11",
                            Name = "ChildRaisedWithFrequentDisruptionsInCare_B11",
                            Text = "CHILD RAISED WITH FREQUENT DISRUPTIONS IN CARE",
                            SubText = "e.g., institutional care, multiple caregivers [EXCLUDE NANNY]",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("4705752e-29f3-4ee8-9e58-e26abd6846ad"),
                                    QuestionId = new Guid("e729d5ae-dd16-460b-8eb4-247294738d5b"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("1edba9ba-8c9f-4eaa-96c2-315670e2fde5"),
                                    QuestionId = new Guid("e729d5ae-dd16-460b-8eb4-247294738d5b"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("b2ea4405-8c0e-4000-b495-4d0201151141"),
                            Index = "12",
                            Name = "DevelopmentalHistory_B12",
                            Text = "DEVELOPMENTAL HISTORY",
                            SubText = "Child / youth achieved developmental milestones within appropriate time frame",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("fbeeffd8-bbc9-4d0e-87ca-0a765fb425df"),
                                    Index = "a",
                                    Name = "Walking_B12a",
                                    Text = "Walking",
                                    SubText = "By 18 months, walked independently",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("dd8b6180-29e8-4f3d-aff1-5d5c5eb90998"),
                                    Index = "b",
                                    Name = "Talking_B12b",
                                    Text = "Talking",
                                    SubText = "By 24 months, combined 2–4 words into short sentences AND had vocabulary ranging from 50–200 words",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5952c79c-e9f5-47c8-be72-d9687e4c8520"),
                                    Index = "c",
                                    Name = "ToiletTraining_B12c",
                                    Text = "Toilet training",
                                    SubText = "By 4 years, daytime toilet trained",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("afcae177-0976-417f-9ab9-507c2b70f9bc"),
                            Index = "13",
                            Name = "CurrentMembersOfPrimaryHousehold_B13",
                            Text = "CURRENT MEMBERS OF PRIMARY HOUSEHOLD",
                            SubText = "Code only if child’s / youth’s primary household is a private home. For all other usual living arrangements, code “99”",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("54d1078a-a6c7-4700-a41e-fefc2e29355e"),
                                    Index = "a",
                                    Name = "NumberOfAdults_B13a",
                                    Text = "Number of adults",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("27aec4cd-2a4d-46fc-8819-3a9f1800e78b"),
                                    Index = "b",
                                    Name = "NumberOfMinors_B13b",
                                    Text = "Number of minors",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                            Index = "14",
                            Name = "ResidentialLivingStatusAtTimeOfAssessment_B14",
                            Text = "RESIDENTIAL / LIVING STATUS AT TIME OF ASSESSMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("92e53d22-fd1a-4ee5-8156-d14102e3cbae"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "1",
                                    Text = "Private home / apartment / rented room",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e6763865-00e0-4e85-a4c3-b5a1ec0fa052"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "2",
                                    Text = "Board and care",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e49456e5-3ea5-4996-b26c-1f59d7c2a532"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "3",
                                    Text = "Assisted living or semi-independent living",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("de6a625a-7445-4c66-845f-4f09326cd847"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "4",
                                    Text = "Mental health residence — e.g., psychiatric group home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("dda1bfa4-0695-4d51-a602-83369bae9d94"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "5",
                                    Text = "Group home for persons with physical disability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7dd40790-9820-4a7d-bca2-2bf758e59e09"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "6",
                                    Text = "Setting for persons with intellectual disability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2d7cbea9-37a7-4adf-b946-32e7bb094168"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "7",
                                    Text = "Psychiatric hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8ccfacce-ed95-4353-859e-57681b36d9ae"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "8",
                                    Text = "Homeless (with or without shelter)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("300ae0d9-586b-4ed8-b861-8d5bf8e22c7e"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "9",
                                    Text = "Residential care facility — e.g., long-term care home, nursing home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("12911bbb-e525-487a-b28c-558c3249a2db"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "10",
                                    Text = "Rehabilitation hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7422a3f3-d5ac-4f14-bff1-4a14d1b7b0a3"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "11",
                                    Text = "Hospice facility / palliative care unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f1e92ef9-e770-4caf-9235-31dfd171c6aa"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "12",
                                    Text = "Acute care hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("22c600d0-225b-4958-a806-559391efb38e"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "13",
                                    Text = "Continuing care hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7bf51d74-8659-4e4a-b69d-45abfcdff751"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "14",
                                    Text = "Residential treatment facility",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8dfae38c-e798-4476-a1fc-58818041d41d"),
                                    QuestionId = new Guid("b057649b-1d0e-441d-9279-ab85e91df7b3"),
                                    Value = "15",
                                    Text = "Other",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("05384b47-f652-4761-b861-749d2fda22a4"),
                            Index = "15",
                            Name = "PostalCodeOfUsualLivingArrangement_B15",
                            Text = "POSTAL CODE OF USUAL LIVING ARRANGEMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                            Index = "16",
                            Name = "LivingArrangement_B16",
                            Text = "LIVING ARRANGEMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("76d0c332-cbfa-454c-b244-39283ccef4e5"),
                                    QuestionId = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                                    Value = "1",
                                    Text = "Alone",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bbf3c5d7-ac6f-40d5-a9b9-2ad15d42d464"),
                                    QuestionId = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                                    Value = "2",
                                    Text = "With parent(s) or primary caregiver(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9843a3e8-eddb-461e-bdc2-cf62168362bd"),
                                    QuestionId = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                                    Value = "3",
                                    Text = "With sibling(s), no parent(s) / primary caregiver(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("16ca74a1-7fef-4cf5-b969-da43f8010388"),
                                    QuestionId = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                                    Value = "4",
                                    Text = "With other relative(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("dc408025-ea47-4bdd-adf4-41bea4ea5468"),
                                    QuestionId = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                                    Value = "5",
                                    Text = "With foster family",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("cd68f4c8-619c-43cb-974f-e8270561e51c"),
                                    QuestionId = new Guid("7dbc5da4-043b-4d76-ab63-ca4147ed3625"),
                                    Value = "6",
                                    Text = "With nonrelative(s), excluding foster family",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("941fc906-4005-4407-8df1-f3b4bb329e1f"),
                            Index = "17",
                            Name = "ResidentialLivingStatusOverLast2Years_B17",
                            Text = "RESIDENTIAL / LIVING STATUS OVER LAST 2 YEARS",
                            SubText = "Code for any of the following settings child / youth lived in",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0c430989-a045-4935-aad3-69db7219543b"),
                                    Index = "a",
                                    Name = "GroupHome_B17a",
                                    Text = "Group home",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("188a833e-84b2-4f15-abdc-0f10ed4d36aa"),
                                    Index = "b",
                                    Name = "Shelter_B17b",
                                    Text = "Shelter",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d049ef9c-45ab-4f4e-b7fd-ce69eaeda8bd"),
                                    Index = "c",
                                    Name = "FacilityForPersonsWithIntellectualDisability_B17c",
                                    Text = "Facility for persons with intellectual disability",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("67e00bfa-f838-4207-9536-ab5a38855280"),
                            Index = "18",
                            Name = "ResidentialInstabilityOverLast2Years_B18",
                            Text = "RESIDENTIAL INSTABILITY OVER LAST 2 YEARS",
                            SubText = "e.g., 3 or more moves, no permanent address, homeless, living in shelter, “couch surfing”",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("035c13ce-5fa7-4942-be07-a41ee139a995"),
                                    QuestionId = new Guid("67e00bfa-f838-4207-9536-ab5a38855280"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3d5bb066-66fe-4489-b935-f30732cfbead"),
                                    QuestionId = new Guid("67e00bfa-f838-4207-9536-ab5a38855280"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("ce3723ee-45ea-4f63-8ff6-0e81ce0f0a42"),
                            Index = "19",
                            Name = "TimeSinceLastContactWithCommunityMentalHealthAgencyOrProfessionalInPastYear_B19",
                            Text = "TIME SINCE LAST CONTACT WITH COMMUNITY MENTAL HEALTH AGENCY OR PROFESSIONAL IN PAST YEAR",
                            SubText = "e.g., psychiatrist, social worker",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("9e426efd-d6da-47f2-904d-66e0d4dd8a4d"),
                                    QuestionId = new Guid("ce3723ee-45ea-4f63-8ff6-0e81ce0f0a42"),
                                    Value = "0",
                                    Text = "No contact in past year",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0b412636-dec9-4015-a6cd-de263943d9d1"),
                                    QuestionId = new Guid("ce3723ee-45ea-4f63-8ff6-0e81ce0f0a42"),
                                    Value = "1",
                                    Text = "31 days or more",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bb916644-e0d8-447d-bcc5-c0e7fb40a060"),
                                    QuestionId = new Guid("ce3723ee-45ea-4f63-8ff6-0e81ce0f0a42"),
                                    Value = "2",
                                    Text = "30 days or less",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("d37a207a-f595-4e3c-b154-c9453cd5b20c"),
                            Index = "20",
                            Name = "MentalHealthResidentialInPatientHistory_B20",
                            Text = "MENTAL HEALTH RESIDENTIAL / IN-PATIENT HISTORY",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0e0b60af-ff7c-40ea-b003-c7c1c35f7f29"),
                                    Index = "a",
                                    Name = "TimeSinceDischargeFromLastAdmission_B20a",
                                    Text = "Time since discharge from last admission",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("fec5f13a-76b2-4af7-8e1c-5d92c1406031"),
                                    Index = "b",
                                    Name = "NumberOfLifetimeAdmissions_B20b",
                                    Text = "Number of lifetime admissions",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("817baa0b-2e7b-48d0-aedb-e7240203e057"),
                                    Index = "c",
                                    Name = "NumberOfAdmissionsInLast2Years_B20c",
                                    Text = "Number of admissions in LAST 2 YEARS",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("73f07536-85b7-4cbb-b0fa-edc4cf986e39"),
                                    Index = "d",
                                    Name = "AgeInYearsAtFirstOvernightStay_B20d",
                                    Text = "Age in years at first overnight stay",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("e43fc5f3-d7e6-42a4-8288-411d2f1b05c1"),
                            Index = "21",
                            Name = "NumberOfYearsLifetimeSpentInAnInstitutionalSettingForPersonsWithIntellectualDisability_B21",
                            Text = "NUMBER OF YEARS (LIFETIME) SPENT IN AN INSTITUTIONAL SETTING FOR PERSONS WITH INTELLECTUAL DISABILITY",
                            SubText = "Code “00” if child / youth was never in an institutional setting. Code “99” if unknown. If less than 1 year, code as 1 year.",
                            DefaultValue = null,
                            QuestionType = "",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                            Index = "22",
                            Name = "NatureOfIntellectualDisability_B22",
                            Text = "NATURE OF INTELLECTUAL DISABILITY",
                            SubText = "Refer to manual for additional codes",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("aaf6c500-a87e-4ba5-9865-e2e84b7c7888"),
                                    QuestionId = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                                    Value = "1",
                                    Text = "Cause unspecified",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a8f0f991-79fd-49c2-9579-3218dd1382d4"),
                                    QuestionId = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                                    Value = "2",
                                    Text = "Fragile X syndrome",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9d6362d7-025b-4e6f-af7f-bae3087a101c"),
                                    QuestionId = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                                    Value = "3",
                                    Text = "22q deletion syndrome",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("43a4f599-1c90-4ffa-b462-5f64eb05267b"),
                                    QuestionId = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                                    Value = "4",
                                    Text = "Congenital hypothyroidism",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e34d7414-0b65-4b91-8dcd-6bc9e43b432a"),
                                    QuestionId = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                                    Value = "5",
                                    Text = "Autism spectrum disorder",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("760bbdcc-ff16-4302-8e98-babc06e6b4dd"),
                                    QuestionId = new Guid("434ce9ef-3665-4221-95f2-d04719ffaf73"),
                                    Value = "6",
                                    Text = "Down syndrome",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                            Index = "23",
                            Name = "DocumentedSeverityOfIntellectualDisability_B23",
                            Text = "DOCUMENTED SEVERITY OF INTELLECTUAL DISABILITY",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("021580c2-ee1a-4128-a26b-97c6f0c0a094"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7bf43510-0bf6-4383-948b-190476306c25"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "1",
                                    Text = "Borderline",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("530d7cb5-185d-4047-9ad7-ff1982e2ce2b"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "2",
                                    Text = "Mild",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a57984b5-0f14-4483-b366-a5927e494f3c"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "3",
                                    Text = "Moderate",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e9e7d32c-432f-4b64-9362-7bff009d8d0c"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "4",
                                    Text = "Severe",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("873a525b-d2cc-4b6d-97fe-e1a68b22ec71"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "5",
                                    Text = "Profound",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bd977b36-8884-4fcb-9869-8c6aeaf019e8"),
                                    QuestionId = new Guid("1b2b5867-6a20-40fa-8827-f044b6bcfe4d"),
                                    Value = "8",
                                    Text = "Not documented",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("068db248-74c1-425b-8aec-e65051f1c101"),
                    Index = "C",
                    Description = "Mental State Indicators",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("440c556f-95e8-4346-8476-45d531574abd"),
                            Index = "1",
                            Name = "MentalStateIndicatorsDistractionAndHyperactivity_C1",
                            Text = "Mental State Indicators - Distraction and Hyperactivity",
                            SubText = "Code for indicators observed in the last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask child / youth]",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("c491f2d9-4887-4b11-a1bd-75dca2f5ec6d"),
                                    Index = "a",
                                    Name = "Impulsive_C1a",
                                    Text = "Impulsive",
                                    SubText = "e.g., running into traffic; takes risky actions without thinking; difficulty taking turns; interrupts",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0d8bd764-bb50-4763-84be-24c3f9595c9c"),
                                    Index = "b",
                                    Name = "EasilyDistracted_C1b",
                                    Text = "Easily distracted",
                                    SubText = "e.g., episodes of difficulty paying attention; gets sidetracked",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c0e58239-6259-492b-8397-e01adba678d4"),
                                    Index = "c",
                                    Name = "Hyperactivity_C1c",
                                    Text = "Hyperactivity",
                                    SubText = "Excessive level of activity",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f6745df3-bbac-4119-a484-40b9bc062522"),
                                    Index = "d",
                                    Name = "Disorganization_C1d",
                                    Text = "Disorganization",
                                    SubText = "e.g., problems organizing personal belongings; difficulty adhering to schedule",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("fc652d6d-b106-4359-ba25-aa75eb381c5e"),
                            Index = "2",
                            Name = "MentalStateIndicatorsMoodDisturbance_C2",
                            Text = "Mental State Indicators - Mood Disturbance",
                            SubText = "Code for indicators observed in the last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask child / youth]",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("362ddfdd-21de-4d6f-8ffb-717a7be266d4"),
                                    Index = "a",
                                    Name = "SadPainedOrWorriedFacialExpressions_C2a",
                                    Text = "Sad, pained, or worried facial expressions",
                                    SubText = "e.g., furrowed brow, constant frowning",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0d0d1f70-80e5-4434-b070-836239b7af23"),
                                    Index = "b",
                                    Name = "CryingTearfulness_C2b",
                                    Text = "Crying, tearfulness",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d403edb7-eadd-47c4-986c-b2f8a682faa8"),
                                    Index = "c",
                                    Name = "DecreasedEnergy_C2c",
                                    Text = "Decreased energy",
                                    SubText = "Statements of decrease in energy level (e.g., “I just don’t feel like doing anything; I am too tired”)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1734d801-220e-42a3-acd9-50c211ed98c4"),
                                    Index = "d",
                                    Name = "MadeNegativeStatements_C2d",
                                    Text = "Made negative statements",
                                    SubText = "e.g., “Nothing matters; No one likes me; I hate my life”",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1198ad29-a86a-4bfe-bad7-da9475ee7b02"),
                                    Index = "e",
                                    Name = "SelfDeprecation_C2e",
                                    Text = "Self-deprecation",
                                    SubText = "e.g., “I am stupid; I am bad; I can’t do anything right”",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4434151b-e7ed-40ae-a34b-539fef9f4e5f"),
                                    Index = "f",
                                    Name = "ExpressionsOfGuiltOrShame_C2f",
                                    Text = "Expressions of guilt or shame",
                                    SubText = "e.g., “I’ve done something awful; This is all my fault; I am a terrible person”",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4bdf1b40-e678-497e-b8d6-96bf1a15ad5a"),
                                    Index = "g",
                                    Name = "ExpressionsOfHopelessness_C2g",
                                    Text = "Expressions of hopelessness",
                                    SubText = "e.g., “There’s no hope for the future; Nothing’s going to change for the better”",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("46d29797-9627-4eea-8fb2-58f35b1ef288"),
                                    Index = "h",
                                    Name = "InflatedSelfWorth_C2h",
                                    Text = "Inflated self-worth",
                                    SubText = "e.g., exaggerated self-opinion, arrogance, inflated belief about one’s own ability",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0c2cedf3-4c0c-48d6-9446-ac03f1a13f41"),
                                    Index = "i",
                                    Name = "Irritability_C2i",
                                    Text = "Irritability",
                                    SubText = "Marked increase in being short-tempered or easily upset",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3e93cf32-02b5-4d79-b9a0-47fe4a4ecd5c"),
                                    Index = "j",
                                    Name = "PressuredSpeechOrRacingThoughts_C2j",
                                    Text = "Pressured speech or racing thoughts",
                                    SubText = "Rapid speech, rapid transition from topic to topic",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("19d88e17-b013-4973-9195-6fdb313fbdff"),
                                    Index = "k",
                                    Name = "LabileAffect_C2k",
                                    Text = "Labile affect",
                                    SubText = "Affect fluctuates frequently with or without an external explanation",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d6e25b27-e324-4db0-a3ce-b4b792d6a32e"),
                                    Index = "l",
                                    Name = "Hypersexuality_C2l",
                                    Text = "Hypersexuality",
                                    SubText = "Age-inappropriate sexual activity or urges",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3cbf336f-dfb1-486a-9786-88fad9098a21"),
                                    Index = "m",
                                    Name = "FlatOrBluntedAffect_C2m",
                                    Text = "Flat or blunted affect",
                                    SubText = "Indifference, non-responsiveness, hard to get to smile, etc.",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("6aca9326-2c9e-46b0-8665-2bf85af50751"),
                            Index = "3",
                            Name = "MentalStateIndicatorsAnxiety_C3",
                            Text = "Mental State Indicators - Anxiety",
                            SubText = "Code for indicators observed in the last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask child / youth]",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("a56cb39a-1203-4813-9b80-4259fbf094ce"),
                                    Index = "a",
                                    Name = "RepetitiveAnxiousComplaintsConcernsNonHealthRelated_C3a",
                                    Text = "Repetitive anxious complaints / concerns (non-health-related)",
                                    SubText = "e.g., persistently seeks attention / reassurance regarding schedules, school, sports, clothing, relationships",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0d2d6b06-03f0-4024-8438-5c8ee75688d4"),
                                    Index = "b",
                                    Name = "ExpressionsIncludingNonverbalOfWhatAppearToBeUnrealisticFears_C3b",
                                    Text = "Expressions, including nonverbal, of what appear to be unrealistic fears",
                                    SubText = "e.g., fear of being abandoned or left alone; of being with others; intense fear of specific objects or situations",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("06da7bdf-c99c-4e16-a0d1-3254ceb22581"),
                                    Index = "c",
                                    Name = "ObsessiveThoughts_C3c",
                                    Text = "Obsessive thoughts",
                                    SubText = "Unwanted ideas or thoughts that cannot be eliminated",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("791dc545-8c0e-44ab-92aa-e491fb29bf31"),
                                    Index = "d",
                                    Name = "CompulsiveBehaviour_C3d",
                                    Text = "Compulsive behaviour",
                                    SubText = "e.g., hand washing, repetitive checking of room, counting, hoarding",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0b31abb5-1551-49b7-a6df-6fce3f4ac25a"),
                                    Index = "e",
                                    Name = "IntrusiveThoughtsOrFlashbacks_C3e",
                                    Text = "Intrusive thoughts or flashbacks",
                                    SubText = "Disturbing memories or images that intrude into thoughts, unexpected recall of adverse events",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("60b89ed6-0985-487a-b88c-6089ca3a1038"),
                                    Index = "f",
                                    Name = "ReEnactmentThroughPlayOfTraumaticLifeEvents_C3f",
                                    Text = "Re-enactment through play of traumatic life events",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("13a0d496-0d19-49fc-9c73-45a7db5cae44"),
                                    Index = "g",
                                    Name = "EpisodesOfPanic_C3g",
                                    Text = "Episodes of panic",
                                    SubText = "Cascade of symptoms of fear, anxiety, loss of control",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e9298595-91db-4cdb-b8a5-f75e56687aae"),
                                    Index = "h",
                                    Name = "Nightmares_C3h",
                                    Text = "Nightmares",
                                    SubText = "e.g., reports frightening dreams, wakes from sleep with expressions of fear (including nonverbal)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("6f7dddf5-8851-4c77-956a-7dbc7952e26d"),
                                    Index = "i",
                                    Name = "Hypervigilance_C3i",
                                    Text = "Hypervigilance",
                                    SubText = "“Jumpiness” or feeling as though in danger",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e8ec013c-ffb1-4486-835f-1464694ebd28"),
                                    Index = "j",
                                    Name = "ConversesOnlyInSpecificSocialSituations_C3j",
                                    Text = "Converses only in specific social situations",
                                    SubText = "e.g., speaks at home but not at school; includes sign language",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c1fea935-ec30-47b0-9218-6aebb1343d13"),
                            Index = "4",
                            Name = "MentalStateIndicatorsPsychosis_C4",
                            Text = "Mental State Indicators - Psychosis",
                            SubText = "Code for indicators observed in the last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask child / youth]",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("5310684e-d674-495b-8967-0100aba85dc8"),
                                    Index = "a",
                                    Name = "Hallucinations_C4a",
                                    Text = "Hallucinations",
                                    SubText = "False sensory perceptions, of any type, with or without insight, without corresponding stimuli (e.g., auditory, visual, tactile, olfactory, gustatory hallucinations, excluding command hallucinations)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b916f783-4910-4e8b-84f9-f57c5b36c59e"),
                                    Index = "b",
                                    Name = "CommandHallucinations_C4b",
                                    Text = "Command hallucinations",
                                    SubText = "Hallucinations directing the child / youth to do something or to act in a particular manner (e.g., to harm self or others)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("225ebe16-cc03-480c-a3b8-b5e193463775"),
                                    Index = "c",
                                    Name = "Delusions_C4c",
                                    Text = "Delusions",
                                    SubText = "Fixed false beliefs (e.g., grandiose, paranoid, somatic, excluding beliefs specific to child’s / youth’s culture or religion)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9648277e-4c14-4af5-bb18-e4f19bd422d6"),
                                    Index = "d",
                                    Name = "AbnormalThoughtProcess_C4d",
                                    Text = "Abnormal thought process",
                                    SubText = "e.g., loosening of associations, blocking, flight of ideas, tangentiality, circumstantiality",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("18bad498-cc93-4ac9-8890-44d88171577d"),
                            Index = "5",
                            Name = "MentalStateIndicatorsNegativeSymptoms_C5",
                            Text = "Mental State Indicators - Negative Symptoms",
                            SubText = "Code for indicators observed in the last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask child / youth]",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("d7858889-6386-4942-a23d-bbd6fd78da70"),
                                    Index = "a",
                                    Name = "LackOfInterestInSocialInteraction_C5a",
                                    Text = "Lack of interest in social interaction",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("333ce138-6fd3-488d-9d52-03bceacee6c1"),
                                    Index = "b",
                                    Name = "LackOfMotivation_C5b",
                                    Text = "Lack of motivation",
                                    SubText = "Absence of spontaneous goal-directed activity",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7549dc5c-b586-4e98-9cd7-94a61291e49d"),
                                    Index = "c",
                                    Name = "ExpressionsIncludingNonverbalOfALackOfPleasureInLifeAnhedonia_C5c",
                                    Text = "Expressions, including nonverbal, of a lack of pleasure in life (anhedonia)",
                                    SubText = "e.g., “I don’t have fun anymore”; gloomy during favourite activities",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1f49405d-a33f-4185-aea6-35dc6a90160a"),
                                    Index = "d",
                                    Name = "WithdrawalFromActivitiesOfInterest_C5d",
                                    Text = "Withdrawal from activities of interest",
                                    SubText = "e.g., long-standing activities, being with family / friends",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("621a9cde-0086-4bd0-90fa-b3e5b9f40dab"),
                            Index = "6",
                            Name = "MentalStateIndicatorsOther_C6",
                            Text = "Mental State Indicators - Other",
                            SubText = "Code for indicators observed in the last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask child / youth]",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("bf6a9920-49aa-41c8-8182-3a7ab2bf2ca5"),
                                    Index = "a",
                                    Name = "RepetitiveHealthComplaints_C6a",
                                    Text = "Repetitive health complaints",
                                    SubText = "e.g., persistently seeks attention for physical symptoms such as headaches and stomach ache; incessant concern with body functions",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0cf1e13a-d28f-49da-b4cd-877c0611f226"),
                                    Index = "b",
                                    Name = "UnusualOrAbnormalPhysicalMovements_C6b",
                                    Text = "Unusual or abnormal physical movements",
                                    SubText = "Unusual facial expressions or mannerisms, peculiar motor behaviour or body posturing (e.g., stereotypies, motor tics, spasticity)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("29fa49ed-93bb-45fd-8e75-83abcde0517d"),
                                    Index = "c",
                                    Name = "PhonicTicsUnusualAbruptRepetitiveAndInvoluntarySounds_C6c",
                                    Text = "Phonic tics — Unusual, abrupt, repetitive, and involuntary sounds",
                                    SubText = "e.g., clearing of throat, barking, repeating words or phrases",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ef4088c2-a7cb-4a2f-bc5d-ab45d163c944"),
                                    Index = "d",
                                    Name = "Hygiene_C6d",
                                    Text = "Hygiene",
                                    SubText = "Unusually poor hygiene, unkempt, dishevelled",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8443356f-dcfa-4cb9-bf0c-b8389b079c87"),
                                    Index = "e",
                                    Name = "DeniesOrMinimizesHarmDoneToOthers_C6e",
                                    Text = "Denies or minimizes harm done to others",
                                    SubText = "e.g., “They can afford it”; “I didn’t hit the kid that hard”",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("71c7a128-f07a-4fe6-8d48-ce46345f3bf0"),
                                    Index = "f",
                                    Name = "DifficultyFallingAsleepOrStayingAsleep_C6f",
                                    Text = "Difficulty falling asleep or staying asleep",
                                    SubText = "e.g., waking up too early; restlessness, nonrestful sleep",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a6d84ed6-4ebc-49c0-9799-b75d27f8d917"),
                                    Index = "g",
                                    Name = "WakesMultipleTimesAtNight_C6g",
                                    Text = "Wakes multiple times at night",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("482fddf4-d1b6-4beb-9e7b-4583f1047508"),
                                    Index = "h",
                                    Name = "FallsAsleepDuringTheDayExcludeNaptime_C6h",
                                    Text = "Falls asleep during the day (exclude naptime)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1a553368-4eb4-47b9-9e7c-6e0c479a2dec"),
                                    Index = "i",
                                    Name = "ResistsBedtime_C6i",
                                    Text = "Resists bedtime",
                                    SubText = "e.g., getting into / staying in bed; difficulty going to bed without parent / caregiver intervention; reluctant to sleep on appropriate schedule",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8020267d-da2e-4f07-a28e-60e4842849b3"),
                                    Index = "j",
                                    Name = "EpisodesOfDisorganizedSpeech_C6j",
                                    Text = "Episodes of disorganized speech",
                                    SubText = "e.g., speech is nonsensical, irrelevant, or rambling from subject to subject",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e54d2d9a-0c98-4cd4-aee7-b3da4d013ada"),
                                    Index = "k",
                                    Name = "ExpressionsSupportiveOfCriminalActivity_C6k",
                                    Text = "Expressions supportive of criminal activity",
                                    SubText = "e.g., “It’s only a crime if you get caught”",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("dfdd5ff0-3688-4119-8837-3e7c3f7a6120"),
                                    Index = "l",
                                    Name = "DemonstratesExcessiveNaivete_C6l",
                                    Text = "Demonstrates excessive naivete",
                                    SubText = "e.g., financially exploited by peers; tricked into transporting drugs for a gang",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a1230203-df9d-4405-b40a-ed2a350563a2"),
                                    Index = "m",
                                    Name = "UnderestimatesOwnAbilities_C6m",
                                    Text = "Underestimates own abilities",
                                    SubText = "e.g., knows how to swim but claims inability to do so",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                            Index = "7",
                            Name = "SleepProblemsRelatedToHypomaniaOrMania_C7",
                            Text = "SLEEP PROBLEMS RELATED TO HYPOMANIA OR MANIA",
                            SubText = "Child / youth had 24-hour period with less than 2 hours of sleep caused by increased energy level (Code for most recent instance)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("308f64c5-f2cd-492d-a1d5-f6728f8c1252"),
                                    QuestionId = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                                    Value = "0",
                                    Text = "Never",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b06659a5-ef12-4a9a-97a1-fa19b971740c"),
                                    QuestionId = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                                    Value = "1",
                                    Text = "More than 1 year ago",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bbce2ddc-f63f-458f-aa0e-2a9762d8d1fa"),
                                    QuestionId = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                                    Value = "2",
                                    Text = "31 days–1 year ago",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c6b624f1-0255-492c-b9e8-a721c792c215"),
                                    QuestionId = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                                    Value = "3",
                                    Text = "8–30 days ago",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("5441aa4b-8734-4680-baba-754b92b3e723"),
                                    QuestionId = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                                    Value = "4",
                                    Text = "4–7 days ago",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("84966779-29ef-4df9-a123-c27f3be71b54"),
                                    QuestionId = new Guid("659c87ec-dfad-4577-b65d-8246b25f5b10"),
                                    Value = "5",
                                    Text = "In last 3 days",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1bec5ff8-3ed7-43fc-95da-ed2b60987aa4"),
                            Index = "8",
                            Name = "PersistentBehaviourPatternsThatHinderSocialization_C8",
                            Text = "PERSISTENT BEHAVIOUR PATTERNS THAT HINDER SOCIALIZATION",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("079c9e93-5d05-4c5b-b6aa-d093926b1177"),
                                    Index = "a",
                                    Name = "NarrowlyRestrictedRangeOfInterest_C8a",
                                    Text = "Narrowly restricted range of interest",
                                    SubText = "e.g., constantly talks about trains",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9b2581bd-b404-4557-b28f-f1c8ab0bccbe"),
                                    Index = "b",
                                    Name = "ExcessivePreoccupationWithAnActivityOrRoutine_C8b",
                                    Text = "Excessive preoccupation with an activity or routine",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("2a3b9267-748b-4301-bf1a-4e8abe5a8a73"),
                                    Index = "c",
                                    Name = "DemonstratesLackOfSocialAndEmotionalConventionsWhenSocializing_C8c",
                                    Text = "Demonstrates lack of social and emotional conventions when socializing",
                                    SubText = "e.g., lack of eye contact",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ec874311-e7c1-4f9b-a196-3363ecad4b37"),
                                    Index = "d",
                                    Name = "ExtremeShyness_C8d",
                                    Text = "Extreme shyness",
                                    SubText = "e.g., severe inhibition in familiar social situations",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("bf5f7da7-9cf0-4071-b885-1232bb425973"),
                            Index = "9",
                            Name = "ChildYouthLacksBasicAwarenessOfHisHerEnvironment_C9",
                            Text = "CHILD / YOUTH LACKS BASIC AWARENESS OF HIS / HER ENVIRONMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("92cacd2e-148f-4284-96aa-dc080303354a"),
                                    Index = "a",
                                    Name = "LacksAwarenessOfSafetyConcerns_C9a",
                                    Text = "Lacks awareness of safety concerns",
                                    SubText = "e.g., child / youth will walk into busy street; child / youth will trust strangers implicitly",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4f7c44a3-93a1-406b-a509-d6ec5bc201ad"),
                                    Index = "b",
                                    Name = "LacksAwarenessOfNeedToMatchBehaviourToEnvironment_C9b",
                                    Text = "Lacks awareness of need to match behaviour to environment",
                                    SubText = "e.g., child / youth will use “outdoor voice” in a quiet room",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b1a1b91f-bc72-40c1-80d4-c164f6bf0824"),
                                    Index = "c",
                                    Name = "LacksAwarenessOfOthers_C9c",
                                    Text = "Lacks awareness of others",
                                    SubText = "e.g., child / youth will not notice others enter the room",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c4859c21-300d-42f6-83de-6d9968efada8"),
                            Index = "10",
                            Name = "ChangeInSeverityOrFrequencyOfPsychiatricSymptomsComparedTo30DaysAgoOrSinceLastAssessmentIfLessThan30DaysAgo_C10",
                            Text = "CHANGE IN SEVERITY OR FREQUENCY OF PSYCHIATRIC SYMPTOMS COMPARED TO 30 DAYS AGO, OR SINCE LAST ASSESSMENT IF LESS THAN 30 DAYS AGO",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("98e6a506-fc11-4b13-98bd-fef3a59c980d"),
                                    QuestionId = new Guid("c4859c21-300d-42f6-83de-6d9968efada8"),
                                    Value = "1",
                                    Text = "Deterioration",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d4231baf-4a49-46be-bdb6-124ff8351445"),
                                    QuestionId = new Guid("c4859c21-300d-42f6-83de-6d9968efada8"),
                                    Value = "2",
                                    Text = "No change",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a5da6a5e-221b-4c98-8701-a905af648f2b"),
                                    QuestionId = new Guid("c4859c21-300d-42f6-83de-6d9968efada8"),
                                    Value = "3",
                                    Text = "Improvement",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("23667b96-7c5b-449e-85c3-e4c4b4cbc2fd"),
                                    QuestionId = new Guid("c4859c21-300d-42f6-83de-6d9968efada8"),
                                    Value = "4",
                                    Text = "Marked improvement",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("307d8351-d360-485d-8b8b-15c208730d0f"),
                    Index = "D",
                    Description = "Substance Use or Excessive Behaviour",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("aeaf3c51-ceb6-4401-be9e-8fdc4d3156bd"),
                            Index = "1",
                            Name = "SocialEnvironmentEncouragesOrFacilitatesAbuseOfDrugsOrAlcohol_D1",
                            Text = "SOCIAL ENVIRONMENT ENCOURAGES OR FACILITATES ABUSE OF DRUGS OR ALCOHOL",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("75a63cef-2ea7-48bc-8efa-0a76aa501e39"),
                                    QuestionId = new Guid("aeaf3c51-ceb6-4401-be9e-8fdc4d3156bd"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f8b405a0-91bf-4d98-97e5-8016ece728d2"),
                                    QuestionId = new Guid("aeaf3c51-ceb6-4401-be9e-8fdc4d3156bd"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("fd1a49b2-66ef-4c9e-9a0c-3782318d11bb"),
                            Index = "2",
                            Name = "UsesCaffeineOrEnergyDrinks_D2",
                            Text = "USES CAFFEINE OR ENERGY DRINKS",
                            SubText = "Highest number of caffeinated beverages or energy drinks consumed in any single day of the LAST 3 DAYS",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("483e60a6-e3fc-458c-bc40-976faa7ef24e"),
                                    QuestionId = new Guid("fd1a49b2-66ef-4c9e-9a0c-3782318d11bb"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("beefb957-3eaa-4b73-b010-15002dd55e22"),
                                    QuestionId = new Guid("fd1a49b2-66ef-4c9e-9a0c-3782318d11bb"),
                                    Value = "1",
                                    Text = "1–2",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2437fd40-9716-49d9-984b-03d470735976"),
                                    QuestionId = new Guid("fd1a49b2-66ef-4c9e-9a0c-3782318d11bb"),
                                    Value = "2",
                                    Text = "3–5",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("435b9cf8-a4e1-4f6b-a06c-e6b393975ae6"),
                                    QuestionId = new Guid("fd1a49b2-66ef-4c9e-9a0c-3782318d11bb"),
                                    Value = "3",
                                    Text = "6 or more",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("714dfa52-cfab-407f-a4de-90ab0d6cf04b"),
                            Index = "3",
                            Name = "SmokesTobaccoDaily_D3",
                            Text = "SMOKES TOBACCO DAILY",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("bb8dbcdd-f584-4db9-a117-3621395fae23"),
                                    QuestionId = new Guid("714dfa52-cfab-407f-a4de-90ab0d6cf04b"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("728c3c52-9451-4ff1-a252-737a5598f90b"),
                                    QuestionId = new Guid("714dfa52-cfab-407f-a4de-90ab0d6cf04b"),
                                    Value = "1",
                                    Text = "Not in last 3 days, but smokes occasionally",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3ec4e230-2f20-43bf-a435-6b33a5f0ea5d"),
                                    QuestionId = new Guid("714dfa52-cfab-407f-a4de-90ab0d6cf04b"),
                                    Value = "2",
                                    Text = "Not in last 3 days, but is usually a daily smoker",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7961ee5c-464e-4de6-bb42-8d4580742dde"),
                                    QuestionId = new Guid("714dfa52-cfab-407f-a4de-90ab0d6cf04b"),
                                    Value = "3",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("ddaf9b3d-b1c4-4d72-804c-5e545f1b6fed"),
                            Index = "4",
                            Name = "UsesOtherNicotineProductDaily_D4",
                            Text = "USES OTHER NICOTINE PRODUCT DAILY",
                            SubText = "e.g., electronic cigarette, smokeless tobacco",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("51364fce-e2e1-4ccf-a0f3-ddf809839b99"),
                                    QuestionId = new Guid("ddaf9b3d-b1c4-4d72-804c-5e545f1b6fed"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("39eddc72-ec22-4162-bd3e-6a38d494501f"),
                                    QuestionId = new Guid("ddaf9b3d-b1c4-4d72-804c-5e545f1b6fed"),
                                    Value = "1",
                                    Text = "Not in last 3 days, but uses occasionally",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("73799700-d94d-4e05-a173-a909d65004ce"),
                                    QuestionId = new Guid("ddaf9b3d-b1c4-4d72-804c-5e545f1b6fed"),
                                    Value = "2",
                                    Text = "Not in last 3 days, but is usually a daily user",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("17c00a90-bc1c-4a45-baba-fab3d260718f"),
                                    QuestionId = new Guid("ddaf9b3d-b1c4-4d72-804c-5e545f1b6fed"),
                                    Value = "3",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("583a09e2-a93a-49b2-ad90-47f246a6071e"),
                            Index = "5",
                            Name = "ProblemVideoGamingAndInternetUseInLast90DaysCodeForDisruptionCausedByChildSYouthSUsualPatternOfVideoGamingInternetUse_D5",
                            Text = "PROBLEM VIDEO GAMING AND INTERNET USE IN LAST 90 DAYS — Code for disruption caused by child’s / youth’s usual pattern of video gaming / Internet use",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("07c33949-dce6-4e48-bb55-35eed29d3eba"),
                                    Index = "a",
                                    Name = "ProblemVideoGaming_D5a",
                                    Text = "Problem video gaming",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("330df769-4f64-44bd-852e-69bff724a1bc"),
                                    Index = "b",
                                    Name = "ProblemInternetUse_D5b",
                                    Text = "Problem Internet use",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("78b3011c-854b-4bf1-adf2-ad678d64cb58"),
                    Index = "E",
                    Description = "Harm to Self and Others",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("ed1e869e-1f93-4ded-be41-a0b190043082"),
                            Index = "1",
                            Name = "SelfInjuriousIdeationOrAttempt_E1",
                            Text = "SELF-INJURIOUS IDEATION OR ATTEMPT",
                            SubText = "Code for most recent instance",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("b1e4e639-cfed-44ec-8204-0f608686777b"),
                                    Index = "a",
                                    Name = "ConsideredPerformingASelfInjuriousAct_E1a",
                                    Text = "Considered performing a self-injurious act",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ec6a5bb5-1144-4571-ab10-69109343599e"),
                                    Index = "b",
                                    Name = "MostRecentSelfInjuriousAttempt_E1b",
                                    Text = "Most recent self-injurious attempt",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("a2ecb19d-0e88-4462-8d19-2e63beb7ccb1"),
                            Index = "2",
                            Name = "IntentOfAnySelfInjuriousAttemptWasToKillSelf_E2",
                            Text = "INTENT OF ANY SELF-INJURIOUS ATTEMPT WAS TO KILL SELF",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("4fb64535-0c7f-464b-b7ed-8231f645b0af"),
                                    QuestionId = new Guid("a2ecb19d-0e88-4462-8d19-2e63beb7ccb1"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("dfc6ca80-0357-4153-acc2-ecde4198d5dd"),
                                    QuestionId = new Guid("a2ecb19d-0e88-4462-8d19-2e63beb7ccb1"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("94c79ddf-0712-4729-be23-572fa5867e4a"),
                                    QuestionId = new Guid("a2ecb19d-0e88-4462-8d19-2e63beb7ccb1"),
                                    Value = "8",
                                    Text = "No attempt",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("ed4c67a8-8a64-451e-a6e4-c72d109ce845"),
                            Index = "3",
                            Name = "OtherIndicatorsOfSelfInjuriousBehaviour_E3",
                            Text = "OTHER INDICATORS OF SELF-INJURIOUS BEHAVIOUR",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("b6ad0df3-faf5-47b4-8622-4d2e230f0b29"),
                                    Index = "a",
                                    Name = "FamilyCaregiverFriendOrStaffExpressesConcernThatChildYouthIsAtRiskForSelfInjury_E3a",
                                    Text = "Family, caregiver, friend, or staff expresses concern that child / youth is at risk for self-injury",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a19d4c4c-d54a-473b-b011-32b66c8ee29e"),
                                    Index = "b",
                                    Name = "SuicidePlanInLast30DaysFormulatedASchemeToEndOwnLife_E3b",
                                    Text = "Suicide plan — In LAST 30 DAYS, formulated a scheme to end own life",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("756fd383-de59-4fd1-981f-7a80b40fba75"),
                            Index = "4",
                            Name = "Violence_E4",
                            Text = "VIOLENCE",
                            SubText = "Code for most recent instance",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("1e849b34-395d-4a05-8ae8-5e0a5f3b1a5b"),
                                    Index = "a",
                                    Name = "ViolentIdeationEGReportsOfPremeditatedThoughtsStatementsPlansToCommitViolence_E4a",
                                    Text = "Violent ideation — e.g., reports of premeditated thoughts, statements, plans to commit violence",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4e233ddb-2b97-4779-98e1-4cc4a8d9d98d"),
                                    Index = "b",
                                    Name = "IntimidationOfOthersOrThreatenedViolenceIntentionallyMakesThreateningGesturesVerbalizationsOrStanceWithNoPhysicalContact_E4b",
                                    Text = "Intimidation of others or threatened violence — Intentionally makes threatening gestures, verbalizations or stance with no physical contact (e.g., throwing furniture, explicit threats of violence)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c363e95b-3701-4b4e-8ce4-88fb069973e7"),
                                    Index = "c",
                                    Name = "ViolenceToOthersActsWithPurposefulMaliciousOrViciousIntentResultingInPhysicalHarmToAnotherEGStabbingChokingBeating_E4c",
                                    Text = "Violence to others — Acts with purposeful, malicious, or vicious intent, resulting in physical harm to another (e.g., stabbing, choking, beating)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("925ed3e1-a88b-499b-876d-5e0f14d39953"),
                            Index = "5",
                            Name = "ExtremeBehaviourDisturbance_E5",
                            Text = "EXTREME BEHAVIOUR DISTURBANCE",
                            SubText = "History of extreme behaviour(s) that suggests serious risk of harm to self (e.g., severe self-mutilation) or others (e.g., torture, homicide)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("31d9fa2c-8370-4f26-ae1e-3de87791ab87"),
                                    QuestionId = new Guid("925ed3e1-a88b-499b-876d-5e0f14d39953"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("5cdf1975-ecf4-4349-ae12-76bc4920460a"),
                                    QuestionId = new Guid("925ed3e1-a88b-499b-876d-5e0f14d39953"),
                                    Value = "1",
                                    Text = "Yes, but not exhibited in last 7 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("5f7cfebf-4e49-42b8-9700-af9158149ec3"),
                                    QuestionId = new Guid("925ed3e1-a88b-499b-876d-5e0f14d39953"),
                                    Value = "2",
                                    Text = "Yes, exhibited in last 7 days",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c5c52d00-ff2a-41f0-88e5-bbd5200e996a"),
                            Index = "6",
                            Name = "OtherIndicatorsOfViolence_E6",
                            Text = "OTHER INDICATORS OF VIOLENCE",
                            SubText = "Code for most recent instance",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("3afa4e23-cfce-4de8-954f-95ae7774cad9"),
                                    Index = "a",
                                    Name = "FireSettingOrMisuseOfIgnitionMaterialsOrAccelerants_E6a",
                                    Text = "Fire setting or misuse of ignition materials or accelerants",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3fc2d558-15c2-4ea7-a066-b4285ccc6485"),
                                    Index = "b",
                                    Name = "CrueltyToAnimalsDeliberateMistreatmentOrPhysicalInjuryToOrTortureOfAnimalsExcludeBehavioursThatAreConsistentWithCultural_E6b",
                                    Text = "Cruelty to animals — Deliberate mistreatment or physical injury to or torture of animals — EXCLUDE BEHAVIOURS THAT ARE CONSISTENT WITH CULTURAL NORMS",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4a5d7c68-0243-405d-817e-742f5795af4b"),
                                    Index = "c",
                                    Name = "PreoccupationWithViolenceEGDepictionsOfViolenceVerbalizationsAboutViolence_E6c",
                                    Text = "Preoccupation with violence — e.g., depictions of violence, verbalizations about violence",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c678f9a2-78c7-4f4f-a0d9-8032048e1ccc"),
                            Index = "7",
                            Name = "ChildYouthHasBeenKnownToCarryOrUseWeaponSInTheLastYear_E7",
                            Text = "CHILD / YOUTH HAS BEEN KNOWN TO CARRY OR USE WEAPON(S) IN THE LAST YEAR",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("d68352ca-1218-4242-9892-1e5d7f147476"),
                                    QuestionId = new Guid("c678f9a2-78c7-4f4f-a0d9-8032048e1ccc"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("09e6a70a-ffa2-4efd-95fd-b8dbd13351cd"),
                                    QuestionId = new Guid("c678f9a2-78c7-4f4f-a0d9-8032048e1ccc"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("57b776b0-c95d-4c81-937a-5949c5f7e605"),
                    Index = "F",
                    Description = "Behaviour",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("6d47260c-ea70-4b45-87a4-46c7066c190b"),
                            Index = "1",
                            Name = "BehaviourSymptoms_F1",
                            Text = "BEHAVIOUR SYMPTOMS",
                            SubText = "Code for indicators observed, irrespective of the assumed cause",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("2794e2c9-5bec-4ac8-929b-3b3b80cffbb1"),
                                    Index = "a",
                                    Name = "VerbalAbuse_F1a",
                                    Text = "Verbal abuse",
                                    SubText = "e.g., others were threatened, cursed at",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("87a2e2c4-bc19-4245-ae7e-9224931b2f65"),
                                    Index = "b",
                                    Name = "PhysicalAbuse_F1b",
                                    Text = "Physical abuse",
                                    SubText = "e.g., hits schoolmate; punches sibling in face",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a1885532-2922-4c0e-8f8b-4a613a19d6ff"),
                                    Index = "c",
                                    Name = "SociallyInappropriateOrDisruptiveBehaviour_F1c",
                                    Text = "Socially inappropriate or disruptive behaviour",
                                    SubText = "e.g., screamed out during class, smeared or threw food or feces",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("81895384-3fba-4143-84d9-b8b21955bf3a"),
                                    Index = "d",
                                    Name = "ResistsCare_F1d",
                                    Text = "Resists care",
                                    SubText = "e.g., resists taking medications / injections, ADL assistance, eating",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("276eee36-b9bd-4ad9-90d4-c0de6f549767"),
                                    Index = "e",
                                    Name = "DestructiveBehaviourTowardProperty_F1e",
                                    Text = "Destructive behaviour toward property",
                                    SubText = "e.g., throwing or breaking objects, turning over beds or tables, vandalism",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a1166bb9-bec6-4748-a7c6-7e02aab72cd9"),
                                    Index = "f",
                                    Name = "OutburstOfAnger_F1f",
                                    Text = "Outburst of anger",
                                    SubText = "Intense flare-up of anger in reaction to a specific action or event (e.g., tantrums when told “no”)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("6c240b7a-c81e-4b32-8aa5-6089123a7c3e"),
                                    Index = "g",
                                    Name = "DefiantBehaviour_F1g",
                                    Text = "Defiant behaviour",
                                    SubText = "Active, persistent refusal to comply with reasonable requests by others",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5748d34b-361b-4b4e-a5b4-d9c01cf5c2f6"),
                                    Index = "h",
                                    Name = "Argumentativeness_F1h",
                                    Text = "Argumentativeness",
                                    SubText = "Verbally combative, belligerent, quarrelsome, unreasonably and excessively argumentative",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("be3d9b22-f94c-4941-aa5c-482ea57abbab"),
                                    Index = "i",
                                    Name = "ExtremeRiskTaking_F1i",
                                    Text = "Extreme risk-taking",
                                    SubText = "e.g., jumping off high rooftop, playing with firearms",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("60b4104b-62c3-49df-95fe-4581c14d7c56"),
                                    Index = "j",
                                    Name = "RepetitiveLying_F1j",
                                    Text = "Repetitive lying",
                                    SubText = "Misrepresentations for personal gain",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8ade0234-b082-42d5-92d7-dd73654a5f26"),
                                    Index = "k",
                                    Name = "SelfInjuriousBehaviour_F1k",
                                    Text = "Self-injurious behaviour",
                                    SubText = "e.g., bangs head; pinching, biting, scratching, hitting self; pulling own hair",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("567a3df6-b87e-4f6c-b3f9-cf6b935852da"),
                                    Index = "l",
                                    Name = "SelfStimulatingBehaviourThatInterferesWithNormalActivitiesEGFingerFlickingRockingSpinningObjects_F1l",
                                    Text = "Self-stimulating behaviour that interferes with normal activities — e.g., finger flicking, rocking, spinning objects",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("2f4ad427-c540-4733-9b27-9eb66b907b5c"),
                                    Index = "m",
                                    Name = "Pica_F1m",
                                    Text = "Pica",
                                    SubText = "Ingestion of non-food items (e.g., soap, dirt, feces)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("dc7cd93a-3ce4-494a-ac05-0cb90c78a055"),
                                    Index = "n",
                                    Name = "InappropriateEatingBehaviour_F1n",
                                    Text = "Inappropriate eating behaviour",
                                    SubText = "e.g., gorging, rumination, regurgitation (EXCLUDE PICA)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("de298502-d59f-45bc-8f1d-f62b86db7d14"),
                                    Index = "o",
                                    Name = "Wandering_F1o",
                                    Text = "Wandering",
                                    SubText = "Moved with no rational purpose, seemingly oblivious to needs or safety",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("cb47f715-586b-4979-8c98-dee1012799d4"),
                                    Index = "p",
                                    Name = "BoltingFleeing_F1p",
                                    Text = "Bolting / fleeing",
                                    SubText = "Suddenly reacts to external stimuli (e.g., runs away at the sight of a dog)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("09d5e4fd-ebed-4c68-a202-8c94afb31919"),
                                    Index = "q",
                                    Name = "ExcessiveOrUnusualReactionToSensoryStimuli_F1q",
                                    Text = "Excessive or unusual reaction to sensory stimuli",
                                    SubText = "e.g., screams in response to loud noise; recoils from touch",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("95f94076-75b0-4c44-91ed-f39a11b7a34e"),
                                    Index = "r",
                                    Name = "RegressiveBehaviour_F1r",
                                    Text = "Regressive behaviour",
                                    SubText = "Child / youth has behaviours that revert to a previous stage in development (e.g., begins sucking thumb again)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("14cbe4d5-77e1-4966-a38c-8ef1966a74e8"),
                                    Index = "s",
                                    Name = "InappropriatePublicSexualBehaviourOrPublicDisrobing_F1s",
                                    Text = "Inappropriate public sexual behaviour or public disrobing",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("3d472baf-51f5-48eb-bf9d-58ae9b9347a2"),
                            Index = "2",
                            Name = "EvidenceOfHighlyInappropriateSexualKnowledgeOrExcessivePreoccupationWithSexInLast90Days_F2",
                            Text = "EVIDENCE OF HIGHLY INAPPROPRIATE SEXUAL KNOWLEDGE OR EXCESSIVE PREOCCUPATION WITH SEX IN LAST 90 DAYS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("c10a2312-9577-45ed-9b10-3307a68db219"),
                                    QuestionId = new Guid("3d472baf-51f5-48eb-bf9d-58ae9b9347a2"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("27bce6f1-bad0-4286-81c5-efef64250c09"),
                                    QuestionId = new Guid("3d472baf-51f5-48eb-bf9d-58ae9b9347a2"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("a8bc63f9-8478-40db-b430-51d4dab84205"),
                            Index = "3",
                            Name = "FamilyCaregiverFriendOrStaffExpressesConcernAboutHighlyRiskyOrProblematicSexualBehaviour_F3",
                            Text = "FAMILY, CAREGIVER, FRIEND, OR STAFF EXPRESSES CONCERN ABOUT HIGHLY RISKY OR PROBLEMATIC SEXUAL BEHAVIOUR",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("58a0bfde-2c15-417a-ba11-23ee73ec1dda"),
                                    QuestionId = new Guid("a8bc63f9-8478-40db-b430-51d4dab84205"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2a3575b2-74fb-4054-bc2f-faa149c276d3"),
                                    QuestionId = new Guid("a8bc63f9-8478-40db-b430-51d4dab84205"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c32db8be-13d0-49dc-a007-bdc831ff567b"),
                            Index = "4",
                            Name = "ConductProblems_F4",
                            Text = "CONDUCT PROBLEMS",
                            SubText = "Code for most recent time of event",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("2493d996-af0f-4029-a600-fb3e1f2a6e71"),
                                    Index = "a",
                                    Name = "StealingEGTheftFromFamilyShoplifting_F4a",
                                    Text = "Stealing — e.g., theft from family, shoplifting",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9488ea99-5325-4cbd-bda1-df46b72c3ef9"),
                                    Index = "b",
                                    Name = "BullyingPeersPatternOfRepeatedOppressionOrVictimizationOfOthers_F4b",
                                    Text = "Bullying peers — Pattern of repeated oppression or victimization of others",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("41b4011f-e4c6-4b18-abe6-a4e36b8a1ad3"),
                                    Index = "c",
                                    Name = "ElopementAttemptsThreats_F4c",
                                    Text = "Elopement attempts / threats",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("02a86dac-2f5d-4151-abfa-c850080c6ad8"),
                            Index = "5",
                            Name = "ChildYouthReportsThatMostRecentElopementAttemptWasBasedOnFearForPersonalSafety_F5",
                            Text = "CHILD / YOUTH REPORTS THAT MOST RECENT ELOPEMENT ATTEMPT WAS BASED ON FEAR FOR PERSONAL SAFETY",
                            SubText = "Ask child / youth reason for elopement directly",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("f4a10069-b298-407a-9782-841f972db5dd"),
                                    QuestionId = new Guid("02a86dac-2f5d-4151-abfa-c850080c6ad8"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("cdc2a8d6-3760-4f8f-b85e-91aef134c7ef"),
                                    QuestionId = new Guid("02a86dac-2f5d-4151-abfa-c850080c6ad8"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("63158273-31f6-4ea6-b1c0-15b08d97228f"),
                                    QuestionId = new Guid("02a86dac-2f5d-4151-abfa-c850080c6ad8"),
                                    Value = "8",
                                    Text = "No attempt or threat",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("8d1e4a8a-05bc-41a1-9adc-6214dce25932"),
                            Index = "6",
                            Name = "ComparingBehaviourAtHomeAndSchool_F6",
                            Text = "COMPARING BEHAVIOUR AT HOME AND SCHOOL",
                            SubText = "In school, behaviour is:",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("6bd5f854-e2ef-44ac-af72-dcb404cedc3c"),
                                    QuestionId = new Guid("8d1e4a8a-05bc-41a1-9adc-6214dce25932"),
                                    Value = "0",
                                    Text = "Better than home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("16abf1e1-cdad-4f6a-9ea7-3b019c672f92"),
                                    QuestionId = new Guid("8d1e4a8a-05bc-41a1-9adc-6214dce25932"),
                                    Value = "1",
                                    Text = "Same as home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("edbdb8b0-3130-45f5-9608-3bc3cdbccd68"),
                                    QuestionId = new Guid("8d1e4a8a-05bc-41a1-9adc-6214dce25932"),
                                    Value = "2",
                                    Text = "Worse than home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("4baf98f9-f0d7-40f1-8d08-068d96237da8"),
                                    QuestionId = new Guid("8d1e4a8a-05bc-41a1-9adc-6214dce25932"),
                                    Value = "8",
                                    Text = "Don’t know or not applicable",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("3eba6ef6-80a0-4094-9113-56a795ba8a61"),
                            Index = "7",
                            Name = "ChildYouthHasBehaviorProblemsThatRespondToCaregiverIntervention_F7",
                            Text = "CHILD / YOUTH HAS BEHAVIOR PROBLEMS THAT RESPOND TO CAREGIVER INTERVENTION",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("f3500e96-97c2-4cd4-95cb-ee6a91d700ab"),
                                    Index = "a",
                                    Name = "ChildYouthCanBeRedirected_F7a",
                                    Text = "Child / youth can be redirected",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f42cf065-1a14-4945-8e30-ddf6bee5afe2"),
                                    Index = "b",
                                    Name = "ChildYouthRespondsToReinforcementEGPraiseTokens_F7b",
                                    Text = "Child / youth responds to reinforcement — e.g., praise, tokens",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("9cfe7dee-293e-457e-ba09-0ed57fc8883b"),
                    Index = "G",
                    Description = "Strengths and Resilience",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("ca83bea0-f3b9-4b76-bc32-ac53af423fd3"),
                            Index = "1",
                            Name = "Strengths_G1",
                            Text = "STRENGTHS",
                            SubText = "(Note: Whenever possible, ask child / youth)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("178b7690-aed6-4469-9ea3-64728aa972a9"),
                                    Index = "a",
                                    Name = "ReportsHavingAConfidant_G1a",
                                    Text = "Reports having a confidant",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("52a12d84-1a18-4514-a7da-3f835ac326d3"),
                                    Index = "b",
                                    Name = "NotableTalent_G1b",
                                    Text = "Notable talent",
                                    SubText = "e.g., excels in art, sports, or performance",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a6a78acc-12c4-43c2-bb05-ac2ea79d8f83"),
                                    Index = "c",
                                    Name = "GoodSchoolPerformanceInLast6Months_G1c",
                                    Text = "Good school performance in LAST 6 MONTHS",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e93cafa2-5804-4c8d-b475-fa7346dbc527"),
                                    Index = "d",
                                    Name = "SchoolEngagement_G1d",
                                    Text = "School engagement",
                                    SubText = "Actively involved in school-based activities (e.g., sports team, club, student council)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1714d194-90c9-4683-be9a-527457e047c6"),
                                    Index = "e",
                                    Name = "ConsistentPositiveOutlook_G1e",
                                    Text = "Consistent positive outlook",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("bed119a6-322c-4f8f-9089-6145e78674fe"),
                                    Index = "f",
                                    Name = "StrongAndSupportiveRelationshipWithFamily_G1f",
                                    Text = "Strong and supportive relationship with family",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4748f405-cf4f-4a25-b0b5-227b0949dd25"),
                                    Index = "g",
                                    Name = "StrongAndSupportiveRelationshipWithFriendsPeers_G1g",
                                    Text = "Strong and supportive relationship with friends / peers",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("416ae085-1a82-45e8-a1d9-ec6bea2b089a"),
                                    Index = "h",
                                    Name = "HasAtLeastOneFriendWithWhomVisitsPlaysSocializesRegularly_G1h",
                                    Text = "Has at least one friend with whom visits / plays / socializes regularly",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9fc8aa5e-2b38-4730-b218-dae0731bbd8c"),
                                    Index = "i",
                                    Name = "SocialInclusionByPeers_G1i",
                                    Text = "Social inclusion by peers",
                                    SubText = "e.g., playmates at recess",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d1facc92-ef4c-40a8-a292-f537064e6669"),
                                    Index = "j",
                                    Name = "ToleratesFrustrationWell_G1j",
                                    Text = "Tolerates frustration well",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("d2b776fc-2831-406c-b55e-f9c04fb944a0"),
                            Index = "2",
                            Name = "InvolvementInStructuredActivitiesInLast90Days_G2",
                            Text = "INVOLVEMENT IN STRUCTURED ACTIVITIES IN LAST 90 DAYS",
                            SubText = "(Note: Whenever possible, ask child / youth)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("752127a8-ace0-4801-b3a5-3909e66edc48"),
                                    Index = "a",
                                    Name = "ExtracurricularLessonsClasses_G2a",
                                    Text = "Extracurricular lessons / classes",
                                    SubText = "e.g., music, yoga",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3c71b5e2-5388-4042-98c0-7cd83c070ddc"),
                                    Index = "b",
                                    Name = "Volunteers_G2b",
                                    Text = "Volunteers",
                                    SubText = "e.g., for community services",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b025860f-87f2-4479-bfa8-b6aff10f647c"),
                                    Index = "c",
                                    Name = "OrganizedClubOrTeamProgram_G2c",
                                    Text = "Organized club or team program",
                                    SubText = "e.g., soccer, Scouts",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("db622191-4762-4d35-9297-34bb4b13b09d"),
                                    Index = "d",
                                    Name = "DayProgram_G2d",
                                    Text = "Day program",
                                    SubText = "e.g., specialized summer camp program",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("5a32986c-f9e3-4eac-86e5-111108e5e648"),
                    Index = "H",
                    Description = "Cognition and Executive Functioning",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                            Index = "1",
                            Name = "CognitiveSkillsForDailyDecisionMaking_H1",
                            Text = "COGNITIVE SKILLS FOR DAILY DECISION MAKING",
                            SubText = "Making decisions regarding tasks of daily life — e.g., when to get up or have meals, which clothes to wear or activities to do",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("14287355-e8c4-4482-a19c-dd4f88aa6328"),
                                    QuestionId = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                                    Value = "0",
                                    Text = "Independent — Decisions consistent, reasonable, and safe",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6a11f819-9d1f-499e-99f6-9bc456399958"),
                                    QuestionId = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                                    Value = "1",
                                    Text = "Modified independence — Some difficulty in new situations only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ba53c89e-9831-4d9e-b890-b2ae8969ca7c"),
                                    QuestionId = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                                    Value = "2",
                                    Text = "Minimally dependent — In specific recurring situations, cues /supervision necessary",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9184e748-7b61-44d8-98b0-39a17f098f1f"),
                                    QuestionId = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                                    Value = "3",
                                    Text = "Moderately dependent — Cues / supervision required at all times",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b4b4285b-bdd4-4c2d-8a90-36d8c5dc9ec8"),
                                    QuestionId = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                                    Value = "4",
                                    Text = "Severely dependent — Never or rarely makes decisions",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7e5898f4-1af3-41b5-b3c1-337084e5e9d5"),
                                    QuestionId = new Guid("d69e75a3-bfb6-4afb-877e-1f950b70d961"),
                                    Value = "5",
                                    Text = "No discernible consciousness, coma",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("659146d9-0f9c-437d-901a-180d6fd3dcd9"),
                            Index = "2",
                            Name = "MemoryRecallAbility_H2",
                            Text = "MEMORY / RECALL ABILITY",
                            SubText = "Code for recall of what was learned or known",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("8f35026c-8f3d-4089-a72c-a2f46c1fded5"),
                                    Index = "a",
                                    Name = "ShortTermMemoryOkSeemsAppearsToRecallAfter2030Seconds_H2a",
                                    Text = "Short-term memory OK — Seems / appears to recall after 20–30 seconds",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("87b72ec5-62f4-479b-bdca-d051b80c1100"),
                                    Index = "b",
                                    Name = "ProceduralMemoryOkCanPerformAllOrAlmostAllStepsInAMultitaskSequenceWithoutCues_H2b",
                                    Text = "Procedural memory OK — Can perform all or almost all steps in a multitask sequence without cues",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("112a2234-3d29-47d7-9b6e-67f018a88764"),
                            Index = "3",
                            Name = "AdaptabilityToChangeInRoutineOrEnvironment_H3",
                            Text = "ADAPTABILITY TO CHANGE IN ROUTINE OR ENVIRONMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("a8a6a508-a555-480f-ae57-3f44c45b1650"),
                                    QuestionId = new Guid("112a2234-3d29-47d7-9b6e-67f018a88764"),
                                    Value = "0",
                                    Text = "Adapts without difficulty",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("234381dc-028a-4040-86a1-2619083af8d9"),
                                    QuestionId = new Guid("112a2234-3d29-47d7-9b6e-67f018a88764"),
                                    Value = "1",
                                    Text = "Adapts with some difficulty",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("02cbab67-a139-49ca-b3b7-7a2b436e71f4"),
                                    QuestionId = new Guid("112a2234-3d29-47d7-9b6e-67f018a88764"),
                                    Value = "2",
                                    Text = "Has difficulty adapting to even minor change",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c2c3d745-7b27-4bfc-8b53-28de81b40635"),
                            Index = "4",
                            Name = "ExecutiveFunctioning_H4",
                            Text = "EXECUTIVE FUNCTIONING",
                            SubText = "Code for adequacy of child’s / youth’s executive functioning ability compared with typical child / youth of same age",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("c0fc4576-8622-443a-9c99-706199b96ee8"),
                                    Index = "a",
                                    Name = "ProblemSolvingAndReasoningAbility_H4a",
                                    Text = "Problem-solving and reasoning ability",
                                    SubText = "How finds solutions to everyday problems, arrives at inferences and conclusions",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("611a5bd4-5c64-4dc5-b4e0-8a919772ccc1"),
                                    Index = "b",
                                    Name = "TaskInitiation_H4b",
                                    Text = "Task initiation",
                                    SubText = "Ability to initiate a task independently",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("06e0397d-7062-4a51-a5c4-a57a01bbabba"),
                                    Index = "c",
                                    Name = "GoalSettingAndSelfMonitoring_H4c",
                                    Text = "Goal setting and self-monitoring",
                                    SubText = "Ability to set goals, monitor own performance, and evaluate own progress",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("54ed8765-818e-4450-b517-09cf7a42052b"),
                            Index = "5",
                            Name = "ChildYouthAssessedForLearningDisorderInLast3Years_H5",
                            Text = "CHILD / YOUTH ASSESSED FOR LEARNING DISORDER IN LAST 3 YEARS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("789adde8-cdfe-4ef9-bab8-81de7c17b70f"),
                                    QuestionId = new Guid("54ed8765-818e-4450-b517-09cf7a42052b"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bea1fa2f-cc3d-4a9b-9486-27bd4105d3ba"),
                                    QuestionId = new Guid("54ed8765-818e-4450-b517-09cf7a42052b"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("f151fdde-e7c9-4d9c-b51d-ab43ab413a02"),
                    Index = "I",
                    Description = "Independence in Daily Activities",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("c7b28dce-f0dd-4730-a118-8e473ca19014"),
                            Index = "1",
                            Name = "IadlSelfPerformance_I1",
                            Text = "IADL SELF-PERFORMANCE",
                            SubText = "Code for PERFORMANCE in routine activities around the home or in the community during the LAST 7 DAYS",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("d4b06712-637a-4f10-b6e1-c50243431ae5"),
                                    Index = "a",
                                    Name = "OrdinaryHouseworkHowOrdinaryWorkAroundTheHouseIsPerformedEGChoresSuchAsDoingDishesMakingBedTidyingUpToys_I1a",
                                    Text = "Ordinary housework — How ordinary work around the house is performed (e.g., chores such as doing dishes, making bed, tidying up toys)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3e2a4284-40ee-425e-a021-e575de962e4b"),
                                    Index = "b",
                                    Name = "PhoneUseHowTelephoneCallsAreMadeOrReceivedWithAssistiveDevicesAsNeeded_I1b",
                                    Text = "Phone use — How telephone calls are made or received (with assistive devices as needed)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("61edae29-cdc8-4526-8217-17906e0bdd50"),
                                    Index = "c",
                                    Name = "UseOfTechnologyEGHowGetsOnTheInternetUsesTheComputerToPlayGamesAndDoHomework_I1c",
                                    Text = "Use of technology — e.g., how gets on the Internet, uses the computer to play games and do homework",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0eb88655-f810-4e74-96ee-9eeddd7980ba"),
                                    Index = "d",
                                    Name = "SchoolTasksHowOrganizesClassMaterialsIncludingHomeworkAndSchoolSupplies_I1d",
                                    Text = "School tasks — How organizes class materials, including homework and school supplies",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("321ab100-28a1-4cf9-8ec5-1f0823a74ac1"),
                                    Index = "e",
                                    Name = "OrientationInFamiliarIndoorEnvironmentEGHowMovesBetweenClassesAndOrientsSelfWhenAtSchool_I1e",
                                    Text = "Orientation in familiar indoor environment — e.g., how moves between classes and orients self when at school",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8e6ed450-85dd-4b87-b712-64cced66376d"),
                                    Index = "f",
                                    Name = "StairsHowManagesFullFlightOfStairs1214Stairs_I1f",
                                    Text = "Stairs — How manages full flight of stairs (12–14 stairs)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1c82c0be-e098-44fc-94bc-566c3eac086e"),
                            Index = "2",
                            Name = "IadlCapacity_I2",
                            Text = "IADL CAPACITY",
                            SubText = "Code for CAPACITY based on presumed ability to carry out activity as independently as possible. This will require “speculation” by the assessor.",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("7a3a100d-16b3-4dc5-a89b-21481201b826"),
                                    Index = "a",
                                    Name = "OrdinaryHouseworkHowOrdinaryWorkAroundTheHouseIsPerformedEGChoresSuchAsDoingDishesMakingBedTidyingUpToys_I2a",
                                    Text = "Ordinary housework — How ordinary work around the house is performed (e.g., chores such as doing dishes, making bed, tidying up toys)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b8431a3b-82ef-4492-9fce-2e6e40c33c7d"),
                                    Index = "b",
                                    Name = "PhoneUseHowTelephoneCallsAreMadeOrReceivedWithAssistiveDevicesAsNeeded_I2b",
                                    Text = "Phone use — How telephone calls are made or received (with assistive devices as needed)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("64b6dde9-fa38-4c69-a712-6ee5053a814b"),
                                    Index = "c",
                                    Name = "UseOfTechnologyEGHowGetsOnTheInternetUsesTheComputerToPlayGamesAndDoHomework_I2c",
                                    Text = "Use of technology — e.g., how gets on the Internet, uses the computer to play games and do homework",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("20b32fe5-2eca-456a-99e1-4b4c34e8c87b"),
                                    Index = "d",
                                    Name = "SchoolTasksHowOrganizesClassMaterialsIncludingHomeworkAndSchoolSupplies_I2d",
                                    Text = "School tasks — How organizes class materials, including homework and school supplies",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c2b4a263-801c-4dfa-a011-74b4a8e05581"),
                                    Index = "e",
                                    Name = "OrientationInFamiliarIndoorEnvironmentEGHowMovesBetweenClassesAndOrientsSelfWhenAtSchool_I2e",
                                    Text = "Orientation in familiar indoor environment — e.g., how moves between classes and orients self when at school",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9787096a-7755-4842-b1c2-30f9f8eb85e7"),
                                    Index = "f",
                                    Name = "StairsHowManagesFullFlightOfStairs1214Stairs_I2f",
                                    Text = "Stairs — How manages full flight of stairs (12–14 stairs)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("ea5cefc0-1402-45af-9394-066e2cf81821"),
                            Index = "3",
                            Name = "AdlSelfPerformance_I3",
                            Text = "ADL SELF-PERFORMANCE",
                            SubText = "Consider all episodes over 7-day period. If all episodes are performed at the same level, score ADL at that level. If any episodes at level 6, and others less dependent, score ADL as 5. Otherwise, focus on the three most dependent episodes (or all episodes if performed fewer than 3 times). If most dependent episode is 1, score ADL as 1. If not, score ADL as least dependent of those episodes in range 2–5.",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("d3d978e2-59e6-434c-850d-3dd64221b669"),
                                    Index = "a",
                                    Name = "PersonalHygieneHowManagesPersonalHygieneIncludingCombingHairBrushingTeethShavingApplyingMakeupWashingAndDryingFaceAndHan_I3a",
                                    Text = "Personal hygiene — How manages personal hygiene, including combing hair, brushing teeth, shaving, applying makeup, washing and drying face and hands — EXCLUDE BATHS AND SHOWERS",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("afec6184-fb4a-4d8f-b28c-4d0fd0a3c37d"),
                                    Index = "b",
                                    Name = "BathingHowTakesAFullBodyBathShowerIncludesHowTransfersInAndOutOfTubOrShowerAndHowEachPartOfTheBodyIsBathedArmsUpperAndLo_I3b",
                                    Text = "Bathing — How takes a full-body bath / shower. Includes how transfers in and out of tub or shower AND how each part of the body is bathed: arms, upper and lower legs, chest, abdomen and perineal area — EXCLUDE WASHING OF BACK AND HAIR",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7f7b44c2-e2cf-4f50-8d7b-6c9a429bb2a6"),
                                    Index = "c",
                                    Name = "DressingUpperBodyHowDressesAndUndressesStreetClothesUnderwearAboveTheWaistIncludingProsthesesOrthoticsFastenersPullovers_I3c",
                                    Text = "Dressing upper body — How dresses and undresses (street clothes, underwear) above the waist, including prostheses, orthotics, fasteners, pullovers, etc.",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("141a9bef-5a95-4ef5-ae33-5e435f43aceb"),
                                    Index = "d",
                                    Name = "DressingLowerBodyHowDressesAndUndressesStreetClothesUnderwearFromTheWaistDownIncludingProsthesesOrthoticsBeltsPantsSkirt_I3d",
                                    Text = "Dressing lower body — How dresses and undresses (street clothes, underwear) from the waist down, including prostheses, orthotics, belts, pants, skirts, shoes, fasteners, etc.",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f097dca2-18de-43aa-bc8e-82f52e759c47"),
                                    Index = "e",
                                    Name = "LocomotionHowMovesBetweenLocationsOnSameFloorWalkingOrWheelingIfInWheelchairSelfSufficiencyOnceInChair_I3e",
                                    Text = "Locomotion — How moves between locations on same floor (walking or wheeling). If in wheelchair, self-sufficiency once in chair",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ab2968a3-b85c-4317-870f-e05532e24a0b"),
                                    Index = "f",
                                    Name = "ToiletUseHowUsesTheToiletRoomOrCommodeBedpanUrinalCleansesSelfAfterToiletUseOrIncontinentEpisodeSChangesBedPadManagesOst_I3f",
                                    Text = "Toilet use — How uses the toilet room (or commode, bedpan, urinal), cleanses self after toilet use or incontinent episode(s), changes bed pad, manages ostomy or catheter, adjusts clothes — EXCLUDE TRANSFER ON AND OFF TOILET",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("58105910-dea8-4090-b283-5f4a6623790e"),
                                    Index = "g",
                                    Name = "EatingHowEatsAndDrinksRegardlessOfSkillIncludesIntakeOfNourishmentByOtherMeansEGTubeFeeding_I3g",
                                    Text = "Eating — How eats and drinks (regardless of skill). Includes intake of nourishment by other means (e.g., tube feeding)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("422089c3-20c8-46a5-b82b-adbbb0e063da"),
                            Index = "4",
                            Name = "ChangeInAdlStatusAsComparedTo90DaysAgoOrSinceLastAssessmentIfLessThan90DaysAgo_I4",
                            Text = "CHANGE IN ADL STATUS AS COMPARED TO 90 DAYS AGO, OR SINCE LAST ASSESSMENT IF LESS THAN 90 DAYS AGO",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("28850661-b664-4dd3-a36d-dc90fd643d94"),
                                    QuestionId = new Guid("422089c3-20c8-46a5-b82b-adbbb0e063da"),
                                    Value = "0",
                                    Text = "Improved",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c2f6fce0-196e-432a-9435-d0f0376d7ac9"),
                                    QuestionId = new Guid("422089c3-20c8-46a5-b82b-adbbb0e063da"),
                                    Value = "1",
                                    Text = "No change",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d1011417-32a5-4d8b-a256-b7bd240a88ff"),
                                    QuestionId = new Guid("422089c3-20c8-46a5-b82b-adbbb0e063da"),
                                    Value = "2",
                                    Text = "Declined",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2b7b0dbe-8ac1-45e2-a7b9-4c7615a7ae22"),
                                    QuestionId = new Guid("422089c3-20c8-46a5-b82b-adbbb0e063da"),
                                    Value = "8",
                                    Text = "Uncertain",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("8b141c29-c74d-439b-9777-1be648879ed7"),
                            Index = "5",
                            Name = "PrimaryModeOfLocomotion_I5",
                            Text = "PRIMARY MODE OF LOCOMOTION",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("fd76938d-90e4-4d35-a9e6-5b8d82764e79"),
                                    QuestionId = new Guid("8b141c29-c74d-439b-9777-1be648879ed7"),
                                    Value = "0",
                                    Text = "Walking, no assistive device",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("288cf7ad-3299-4ff0-a083-be7ae69335e4"),
                                    QuestionId = new Guid("8b141c29-c74d-439b-9777-1be648879ed7"),
                                    Value = "1",
                                    Text = "Walking, uses assistive device — e.g., cane, walker, crutch",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("fa2b80c7-8283-4a64-958e-f4f9dd946b8b"),
                                    QuestionId = new Guid("8b141c29-c74d-439b-9777-1be648879ed7"),
                                    Value = "2",
                                    Text = "Wheelchair, scooter",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f2dac0eb-a379-43a0-8128-ab2c3c85b2a3"),
                                    QuestionId = new Guid("8b141c29-c74d-439b-9777-1be648879ed7"),
                                    Value = "3",
                                    Text = "Bedbound",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("f9f82f0e-e07e-4a3b-876c-20a36a2d9e44"),
                    Index = "J",
                    Description = "Communication",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("8e3f872e-b3c9-4393-b2be-3b49f63c1449"),
                            Index = "1",
                            Name = "CommunicationMethods_J1",
                            Text = "COMMUNICATION METHODS",
                            SubText = "Code for primary type of expressive communication",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("26b0bb12-5933-4d4c-b87d-e990b9326b61"),
                                    QuestionId = new Guid("8e3f872e-b3c9-4393-b2be-3b49f63c1449"),
                                    Value = "0",
                                    Text = "Verbal — i.e., speech",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2b134b18-a87b-4d81-a32f-96828a08e8b7"),
                                    QuestionId = new Guid("8e3f872e-b3c9-4393-b2be-3b49f63c1449"),
                                    Value = "1",
                                    Text = "Nonverbal — e.g., gestures, sign language, sounds, writing",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("ebbff356-a14c-4490-b571-0478e8727acb"),
                            Index = "2",
                            Name = "CommunicationModesUsedDaily_J2",
                            Text = "COMMUNICATION MODES USED DAILY",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("9476bd2d-5e87-446a-9505-c8e9157e6242"),
                                    Index = "a",
                                    Name = "SpeechIncludingSpeechReadingLipReading_J2a",
                                    Text = "Speech — Including speech reading (lip reading)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("071cbe7b-3a5f-4689-9223-4b9119ff154a"),
                                    Index = "b",
                                    Name = "WrittenOrPrintedText_J2b",
                                    Text = "Written or printed text",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("81c4d8dc-15ec-4d83-bedc-a507e7e6acbe"),
                                    Index = "c",
                                    Name = "AnySignLanguageEGAmericanSignLanguage_J2c",
                                    Text = "Any sign language — e.g., American Sign Language",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8d36acfd-c881-45d1-b051-c1fb9e737fb3"),
                                    Index = "d",
                                    Name = "AnyAdaptedOrManuallyCodedLanguageEGSignedExactEnglish_J2d",
                                    Text = "Any adapted or manually coded language — e.g., Signed Exact English",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("cc4502af-6637-43c4-a7dc-c0bd878ccf40"),
                                    Index = "e",
                                    Name = "CommunicationBoardOrDevice_J2e",
                                    Text = "Communication board or device",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("be7dc9b4-1b63-471b-9795-ba3fc9519e7d"),
                                    Index = "f",
                                    Name = "IdiosyncraticSignsGesturesBehaviours_J2f",
                                    Text = "Idiosyncratic signs, gestures, behaviours",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8685dbfd-725f-46b9-8d5d-5f0389382972"),
                                    Index = "g",
                                    Name = "TangibleSymbolsEG3DObjects2DPictures_J2g",
                                    Text = "Tangible symbols — e.g., 3D objects, 2D pictures",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("83deeceb-5b00-4db5-855d-50d7c1f9e489"),
                            Index = "3",
                            Name = "MakingSelfUnderstoodExpression_J3",
                            Text = "MAKING SELF UNDERSTOOD (Expression)",
                            SubText = "Expressing information content — both verbal and nonverbal",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("2f8046b6-85a9-45e8-9a2e-99a5ab64a140"),
                                    QuestionId = new Guid("83deeceb-5b00-4db5-855d-50d7c1f9e489"),
                                    Value = "0",
                                    Text = "Understood — Expresses ideas without difficulty",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("27ea0646-5516-4e41-96cd-e7d3749ec606"),
                                    QuestionId = new Guid("83deeceb-5b00-4db5-855d-50d7c1f9e489"),
                                    Value = "1",
                                    Text = "Usually understood — Difficulty finding words or finishing thoughts BUT if given time, little or no prompting required",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("eff1e8c4-08c2-4d3d-8dd0-4903e463a21e"),
                                    QuestionId = new Guid("83deeceb-5b00-4db5-855d-50d7c1f9e489"),
                                    Value = "2",
                                    Text = "Often understood — Difficulty finding words or finishing thoughts AND prompting usually required",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("57eb29f1-c82a-4abf-bd5b-98c8bd0ec7b1"),
                                    QuestionId = new Guid("83deeceb-5b00-4db5-855d-50d7c1f9e489"),
                                    Value = "3",
                                    Text = "Sometimes understood — Ability is limited to making concrete requests, e.g., regarding food, drink, toilet",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("1aa96bcf-9be6-430d-8ed8-1d0ee7053ef7"),
                                    QuestionId = new Guid("83deeceb-5b00-4db5-855d-50d7c1f9e489"),
                                    Value = "4",
                                    Text = "Rarely or never understood",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("56bae767-7eda-44e0-9ab0-edf896875b4a"),
                            Index = "4",
                            Name = "OneOrMoreParentSPrimaryCaregiverSAbleToCommunicateWithChildYouthInChildSYouthSPreferredCommunicationMode_J4",
                            Text = "ONE OR MORE PARENT(S) / PRIMARY CAREGIVER(S) ABLE TO COMMUNICATE WITH CHILD / YOUTH IN CHILD’S / YOUTH’S PREFERRED COMMUNICATION MODE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("2a3a02a0-4a65-4b49-bb43-f3ec49063fd6"),
                                    QuestionId = new Guid("56bae767-7eda-44e0-9ab0-edf896875b4a"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e6a897e0-676d-464e-a3b0-d19a89d6a740"),
                                    QuestionId = new Guid("56bae767-7eda-44e0-9ab0-edf896875b4a"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("bd149488-4c18-46bb-8a54-4345bed4e87c"),
                            Index = "5",
                            Name = "AbilityToUnderstandOthersComprehension_J5",
                            Text = "ABILITY TO UNDERSTAND OTHERS (Comprehension)",
                            SubText = "Understanding verbal information content (however able; with hearing appliance normally used)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("5a0eeefc-1bf5-44d0-8c6c-c74ebbc3e181"),
                                    QuestionId = new Guid("bd149488-4c18-46bb-8a54-4345bed4e87c"),
                                    Value = "0",
                                    Text = "Understands — Clear comprehension",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("538a9101-31c3-4177-819d-e6a4ea09fabc"),
                                    QuestionId = new Guid("bd149488-4c18-46bb-8a54-4345bed4e87c"),
                                    Value = "1",
                                    Text = "Usually understands — Misses some part / intent of message BUT comprehends most conversation",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("16736e94-511b-4ef0-abd7-d43015304996"),
                                    QuestionId = new Guid("bd149488-4c18-46bb-8a54-4345bed4e87c"),
                                    Value = "2",
                                    Text = "Often understands — Misses some part / intent of message BUT with repetition or explanation can often comprehend conversation",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("5b47e332-2dff-46d9-9edb-fd2e6ec3d56e"),
                                    QuestionId = new Guid("bd149488-4c18-46bb-8a54-4345bed4e87c"),
                                    Value = "3",
                                    Text = "Sometimes understands — Responds adequately to simple, direct communication only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b5b1bbbf-1faf-432b-a7e5-8b5beea9c06b"),
                                    QuestionId = new Guid("bd149488-4c18-46bb-8a54-4345bed4e87c"),
                                    Value = "4",
                                    Text = "Rarely or never understands",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("e2dbd20b-4d3c-4847-9c5f-4fc3e16d768d"),
                            Index = "6",
                            Name = "SpeechPatterns_J6",
                            Text = "SPEECH PATTERNS",
                            SubText = "Code for most recent episode of unusual speech",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("b44b3d30-5cf3-4edd-95c0-49187a37dae0"),
                                    Index = "a",
                                    Name = "EcholaliaRepeatsTheWordsSpokenByOthers_J6a",
                                    Text = "Echolalia — Repeats the words spoken by others",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9cbf0a27-116d-4393-853e-b5e2ee36b166"),
                                    Index = "b",
                                    Name = "ExcessiveRepetitionOfStereotypedPhrasesOrIdiosyncraticLanguageSaysPreferredPhrasesOutOfContextEGWhatSUpButtercupInTheMid_J6b",
                                    Text = "Excessive repetition of stereotyped phrases or idiosyncratic language — Says preferred phrases out of context (e.g., “what’s up buttercup” in the middle of a conversation about dogs) or uses neologisms (e.g., “go to blue riding” to indicate “go to the park with the blue swings”)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("6fcbbbba-7e04-40b6-ad17-88e3cce47ac4"),
                                    Index = "c",
                                    Name = "OddIntonationThatInterferesWithInteractionsEGSingSongOrRhythmicSpeechFlatOrRoboticSpeech_J6c",
                                    Text = "Odd intonation that interferes with interactions — e.g., “sing-song” or rhythmic speech; flat or “robotic” speech",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("4625f9a0-a4be-4d4e-93c0-46f044c623ab"),
                    Index = "K",
                    Description = "Hearing, Vision, and Motor",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("2557b776-fb29-4bde-8312-5b187ed84f9b"),
                            Index = "1",
                            Name = "Hearing_K1",
                            Text = "HEARING",
                            SubText = "Ability to hear (with hearing appliance normally used)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("7b6b0ab4-ca31-4c01-a9ff-de31dd5f6226"),
                                    QuestionId = new Guid("2557b776-fb29-4bde-8312-5b187ed84f9b"),
                                    Value = "0",
                                    Text = "Adequate — No difficulty in normal conversation, social interaction, listening to TV",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("cb60f457-71be-4e73-976e-97cb7df02377"),
                                    QuestionId = new Guid("2557b776-fb29-4bde-8312-5b187ed84f9b"),
                                    Value = "1",
                                    Text = "Minimal difficulty — Difficulty in some environments (e.g., when person speaks softly or is more than 2 metres [6 feet] away)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d1810465-560a-44ff-864c-221bca61c8e2"),
                                    QuestionId = new Guid("2557b776-fb29-4bde-8312-5b187ed84f9b"),
                                    Value = "2",
                                    Text = "Moderate difficulty — Problem hearing normal conversation, requires quiet setting to hear well",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b101eb10-33ce-4f1d-9ea1-cf649b85a69b"),
                                    QuestionId = new Guid("2557b776-fb29-4bde-8312-5b187ed84f9b"),
                                    Value = "3",
                                    Text = "Severe difficulty — Difficulty in all situations (e.g., speaker has to talk loudly or speak very slowly; or child / youth reports that all speech is mumbled)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("4320e0c0-d9cc-42f9-8fc1-f9cf913f5d32"),
                                    QuestionId = new Guid("2557b776-fb29-4bde-8312-5b187ed84f9b"),
                                    Value = "4",
                                    Text = "No hearing",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("06aa71e8-e551-4816-98af-ed7e9fcf1fa8"),
                            Index = "2",
                            Name = "Vision_K2",
                            Text = "VISION",
                            SubText = "Ability to see in adequate light (with glasses or with other visual appliance normally used)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("f751ca66-be53-4bad-80c9-8c1bbff7e35f"),
                                    QuestionId = new Guid("06aa71e8-e551-4816-98af-ed7e9fcf1fa8"),
                                    Value = "0",
                                    Text = "Adequate — Sees fine detail, including regular print in newspapers / books",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f2273812-49c6-4d76-8662-47dd81a0a45d"),
                                    QuestionId = new Guid("06aa71e8-e551-4816-98af-ed7e9fcf1fa8"),
                                    Value = "1",
                                    Text = "Minimal difficulty — Sees large print, but not regular print in newspapers / books",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ead7a606-0666-4688-b9c5-87bd73233228"),
                                    QuestionId = new Guid("06aa71e8-e551-4816-98af-ed7e9fcf1fa8"),
                                    Value = "2",
                                    Text = "Moderate difficulty — Limited vision; not able to see newspaper headlines, but can identify objects",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8f167751-f25f-4bf5-8e0d-6f1ee3eb495e"),
                                    QuestionId = new Guid("06aa71e8-e551-4816-98af-ed7e9fcf1fa8"),
                                    Value = "3",
                                    Text = "Severe difficulty — Object identification in question, but eyes appear to follow objects; sees only light, colours, shapes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("366e0022-0d36-4ef5-b9fb-a53b50e02811"),
                                    QuestionId = new Guid("06aa71e8-e551-4816-98af-ed7e9fcf1fa8"),
                                    Value = "4",
                                    Text = "No vision",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("10184a64-2380-41ef-bafe-ed4bf8dd43ed"),
                            Index = "3",
                            Name = "DistanceVision_K3",
                            Text = "DISTANCE VISION",
                            SubText = "Ability to see in adequate light (with glasses or with other visual appliance normally used)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("4409666a-3860-4112-9419-e4ad8000af62"),
                                    QuestionId = new Guid("10184a64-2380-41ef-bafe-ed4bf8dd43ed"),
                                    Value = "0",
                                    Text = "Adequate — Sees and can identify faces across the room",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b48a2f21-01f9-4fd3-9308-e90641a7ee6d"),
                                    QuestionId = new Guid("10184a64-2380-41ef-bafe-ed4bf8dd43ed"),
                                    Value = "1",
                                    Text = "Minimal difficulty — Sees and can identify faces at conversation distance, but not across the room",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("1d281cd2-81f9-44d0-abde-07121631596b"),
                                    QuestionId = new Guid("10184a64-2380-41ef-bafe-ed4bf8dd43ed"),
                                    Value = "2",
                                    Text = "Moderate difficulty — Limited vision; can see but not identify faces at conversation distance",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a4fb14c5-0b04-485d-b7cd-c9cee4d1ae72"),
                                    QuestionId = new Guid("10184a64-2380-41ef-bafe-ed4bf8dd43ed"),
                                    Value = "3",
                                    Text = "Severe difficulty — Object identification in question, but eyes appear to follow objects; sees only light, colours, shapes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9bd478ef-edd2-4b15-892a-5955cb6d3a7b"),
                                    QuestionId = new Guid("10184a64-2380-41ef-bafe-ed4bf8dd43ed"),
                                    Value = "4",
                                    Text = "No vision",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("fd2dd4a4-a800-4fcc-9099-c65a4438b227"),
                            Index = "4",
                            Name = "GrossMotorSkills_K4",
                            Text = "GROSS MOTOR SKILLS",
                            SubText = "Ability to perform skills requiring balance and large muscles of the body in coordinated movement (e.g., jumping, kicking a ball, catching a ball)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("38168055-c97f-4096-907b-c9eea4f4f555"),
                                    QuestionId = new Guid("fd2dd4a4-a800-4fcc-9099-c65a4438b227"),
                                    Value = "0",
                                    Text = "Adequate — Performs skills with satisfactory speed and quality of movement both indoors and outdoors (including uneven ground)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("600a7b69-f5c2-44ef-b7c6-972d2f8f559f"),
                                    QuestionId = new Guid("fd2dd4a4-a800-4fcc-9099-c65a4438b227"),
                                    Value = "1",
                                    Text = "Minimal difficulty — Slight difficulty maintaining balance or controlling limb movement (e.g., appears clumsy, slower movements)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f821dbf1-e7ec-4db5-bfd2-86fc77e50b4c"),
                                    QuestionId = new Guid("fd2dd4a4-a800-4fcc-9099-c65a4438b227"),
                                    Value = "2",
                                    Text = "Moderate difficulty — Noticeable deficits in balance and controlling limb movements (e.g., frequently stumbles, drops objects, walks into objects)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("95d665bf-9898-4c27-8e0a-019e68fd5fd6"),
                                    QuestionId = new Guid("fd2dd4a4-a800-4fcc-9099-c65a4438b227"),
                                    Value = "3",
                                    Text = "Severe difficulty — Limitations in trunk, head, and limb control resulting in severe difficulty with coordination of own movements (e.g., unable to reach for a glass of water without knocking it over)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("95b109a2-f055-4b86-b438-43f1da94cb6d"),
                                    QuestionId = new Guid("fd2dd4a4-a800-4fcc-9099-c65a4438b227"),
                                    Value = "4",
                                    Text = "No ability to move body (full paralysis)",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1523eb17-0c3a-423d-abbd-61805e47ca12"),
                            Index = "5",
                            Name = "FineMotorSkills_K5",
                            Text = "FINE MOTOR SKILLS",
                            SubText = "Ability to perform coordinated movements that involve small muscles (e.g., grasping a pencil, managing buttons, using scissors)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("177a5c33-3ed8-441d-a5f8-36aec801fd93"),
                                    QuestionId = new Guid("1523eb17-0c3a-423d-abbd-61805e47ca12"),
                                    Value = "0",
                                    Text = "Adequate — Performs movements within appropriate time frame and with appropriate quality of movement",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bfb77b32-9dc8-4b49-8914-e6811231af64"),
                                    QuestionId = new Guid("1523eb17-0c3a-423d-abbd-61805e47ca12"),
                                    Value = "1",
                                    Text = "Minimal difficulty — Slight difficulty controlling movement (e.g., somewhat slow or easily fatigued)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("5813eadd-862a-4b54-a6c6-da669d6d7dad"),
                                    QuestionId = new Guid("1523eb17-0c3a-423d-abbd-61805e47ca12"),
                                    Value = "2",
                                    Text = "Moderate difficulty — Noticeable deficits in fine motor skill development (e.g., unable to hold pencil properly and produce legible writing)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("01ca026c-e9df-4427-bf04-e9a0f9db3059"),
                                    QuestionId = new Guid("1523eb17-0c3a-423d-abbd-61805e47ca12"),
                                    Value = "3",
                                    Text = "Severe difficulty — Severe limitation in ability to coordinate small muscle movement (e.g., significant struggle to pick up an object using thumb and forefinger)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b9944839-49aa-4095-8d48-a2f86a779c20"),
                                    QuestionId = new Guid("1523eb17-0c3a-423d-abbd-61805e47ca12"),
                                    Value = "4",
                                    Text = "No ability to move body (full paralysis)",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("b9cccc50-1b78-4f5c-bea9-a54e0058424a"),
                    Index = "L",
                    Description = "Health Conditions",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("1759ed25-80ed-4209-95da-796886b1393c"),
                            Index = "1",
                            Name = "ProblemFrequencyBalance_L1",
                            Text = "Problem Frequency - Balance",
                            SubText = "Code for presence in last 3 days",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("01cef74f-996d-4bd4-9310-d43593c3a9af"),
                                    Index = "a",
                                    Name = "Dizziness_L1a",
                                    Text = "Dizziness",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c136f729-af48-4f07-a743-a00081e515b1"),
                                    Index = "b",
                                    Name = "UnsteadyGait_L1b",
                                    Text = "Unsteady gait",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1f826ae6-dc9a-4979-a9de-96789f4474a0"),
                            Index = "2",
                            Name = "ProblemFrequencyGiStatus_L2",
                            Text = "Problem Frequency - GI Status",
                            SubText = "Code for presence in last 3 days",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("37c3fceb-eab1-4e17-b584-fb8304552533"),
                                    Index = "a",
                                    Name = "IncreaseOrDecreaseInNormalAppetite_L2a",
                                    Text = "Increase or decrease in normal appetite",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("989f1f30-16ea-4762-a6c2-53478bd8212e"),
                                    Index = "b",
                                    Name = "Vomiting_L2b",
                                    Text = "Vomiting",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c924bd7a-12ab-4f79-83cc-fe8a83faf3f9"),
                                    Index = "c",
                                    Name = "Nausea_L2c",
                                    Text = "Nausea",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ae1a3c43-251e-450f-b159-75f4e1208c16"),
                                    Index = "d",
                                    Name = "ProblemSwallowing_L2d",
                                    Text = "Problem swallowing",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e63c52dd-04bb-497c-bf18-2065007b493f"),
                                    Index = "e",
                                    Name = "Constipation_L2e",
                                    Text = "Constipation",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("302d752b-73d1-46ff-a481-a5b711277e40"),
                                    Index = "f",
                                    Name = "Diarrhea_L2f",
                                    Text = "Diarrhea",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("5d259b0b-2ae4-4482-a56e-1c77cc1b12ba"),
                            Index = "3",
                            Name = "ProblemFrequencyOther_L3",
                            Text = "Problem Frequency - Other",
                            SubText = "Code for presence in last 3 days",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("a6bbce59-8e2c-4697-b166-3319628ea541"),
                                    Index = "a",
                                    Name = "DaytimeDrowsinessOrSedation_L3a",
                                    Text = "Daytime drowsiness or sedation",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5563c135-1ea2-4631-98fa-0e02bb77029c"),
                                    Index = "b",
                                    Name = "EmergentConditions_L3b",
                                    Text = "Emergent conditions",
                                    SubText = "e.g., itching, fever, rash, bleeding, airway constriction",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1dae93bf-105c-40d9-a0d7-f3a01ffd870e"),
                                    Index = "c",
                                    Name = "Headache_L3c",
                                    Text = "Headache",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("48a7a187-b26c-4788-8fa6-b1d0ea28dc2b"),
                                    Index = "d",
                                    Name = "Seizures_L3d",
                                    Text = "Seizures",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("de030a69-fda3-4c5e-8aeb-8325283c91a1"),
                                    Index = "e",
                                    Name = "Aspiration_L3e",
                                    Text = "Aspiration",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1b471841-f890-4650-a3b9-d45e5b0db94c"),
                                    Index = "f",
                                    Name = "DryMouth_L3f",
                                    Text = "Dry mouth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8cf3c9e9-1f58-43b5-adc0-d0d248e0c316"),
                                    Index = "g",
                                    Name = "HypersalivationOrDrooling_L3g",
                                    Text = "Hypersalivation or drooling",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("b1fa69e2-77b6-4a5a-95bb-7230f71944a0"),
                            Index = "4",
                            Name = "DyspneaShortnessOfBreath_L4",
                            Text = "DYSPNEA (Shortness of breath)",
                            SubText = "e.g. asthma",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("f396c9e6-673d-49c0-9cf2-7ea9c798171b"),
                                    QuestionId = new Guid("b1fa69e2-77b6-4a5a-95bb-7230f71944a0"),
                                    Value = "0",
                                    Text = "Absence of symptom",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f84ef444-6a46-4986-a78d-d47f79566cbc"),
                                    QuestionId = new Guid("b1fa69e2-77b6-4a5a-95bb-7230f71944a0"),
                                    Value = "1",
                                    Text = "Absent at rest, but present when performed moderate activities",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("36c41e61-7d22-4b33-8f83-d7d6966f6ff7"),
                                    QuestionId = new Guid("b1fa69e2-77b6-4a5a-95bb-7230f71944a0"),
                                    Value = "2",
                                    Text = "Absent at rest, but present when performed normal day-to-day activities",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bab6d06a-531c-4f43-abb9-3a5c39b469e8"),
                                    QuestionId = new Guid("b1fa69e2-77b6-4a5a-95bb-7230f71944a0"),
                                    Value = "3",
                                    Text = "Present at rest",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("2d4ea953-30f9-4519-9072-0e59ff87464d"),
                            Index = "5",
                            Name = "Fatigue_L5",
                            Text = "FATIGUE",
                            SubText = "Inability to complete normal daily activities — e.g., ADLs, IADLs",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("cb797d02-eddc-4fc1-8518-3b9b801d13b1"),
                                    QuestionId = new Guid("2d4ea953-30f9-4519-9072-0e59ff87464d"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d858d31e-44e2-4df6-ba16-3f01b3512842"),
                                    QuestionId = new Guid("2d4ea953-30f9-4519-9072-0e59ff87464d"),
                                    Value = "1",
                                    Text = "Minimal — Diminished energy but completes normal day-to-day activities",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("36b0b373-8951-4722-963c-af847285e2e8"),
                                    QuestionId = new Guid("2d4ea953-30f9-4519-9072-0e59ff87464d"),
                                    Value = "2",
                                    Text = "Moderate — Due to diminished energy, UNABLE TO FINISH normal day-to-day activities",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("69aa6e50-04b7-4df4-8ba1-889fa92c90c5"),
                                    QuestionId = new Guid("2d4ea953-30f9-4519-9072-0e59ff87464d"),
                                    Value = "3",
                                    Text = "Severe — Due to diminished energy, UNABLE TO START SOME normal day-to-day activities",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("45ce0c23-92cf-4196-96b4-91a026260126"),
                                    QuestionId = new Guid("2d4ea953-30f9-4519-9072-0e59ff87464d"),
                                    Value = "4",
                                    Text = "Unable to commence any normal day-to-day activities — Due to diminished energy",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("74627911-fdfc-4d58-a76e-4786613e6f3c"),
                            Index = "6",
                            Name = "PainSymptoms_L6",
                            Text = "PAIN SYMPTOMS",
                            SubText = "Note: Always ask the child / youth about pain frequency and intensity. Observe child / youth and ask others who are in contact with the child / youth.",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("f4e3f0d4-ff0c-4a96-a216-10e8a890dc32"),
                                    Index = "a",
                                    Name = "FrequencyWithWhichChildYouthComplainsOrShowsEvidenceOfPainIncludingGrimacingTeethClenchingMoaningWithdrawalWhenTouchedOr_L6a",
                                    Text = "Frequency with which child / youth complains or shows evidence of pain (including grimacing, teeth clenching, moaning, withdrawal when touched, or other nonverbal signs suggesting pain)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8dfe0a77-83e0-473a-9bee-5310d1447664"),
                                    Index = "b",
                                    Name = "IntensityOfHighestLevelOfPainPresent_L6b",
                                    Text = "Intensity of highest level of pain present",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("757fbf88-283f-42ca-9d5d-bcfa3a26516e"),
                            Index = "7",
                            Name = "ExtrapyramidalSymptomsDuringLast3Days_L7",
                            Text = "EXTRAPYRAMIDAL SYMPTOMS DURING LAST 3 DAYS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0f3c9caf-d9c6-4ae8-9265-400601840c41"),
                                    Index = "a",
                                    Name = "AkathisiaSubjectiveFeelingOfRestlessnessOrNeedForMovement_L7a",
                                    Text = "Akathisia — Subjective feeling of restlessness or need for movement",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("a0162c4d-b803-4ba9-b9e4-87127b0fe197"),
                                    Index = "b",
                                    Name = "DyskinesiaInvoluntaryMovementsWithoutApparentPurposeEGChewingPuckeringMovementOfMouthMovementOfLipsRockingWrithingOfTrun_L7b",
                                    Text = "Dyskinesia — Involuntary movements without apparent purpose, e.g., chewing, puckering movement of mouth; movement of lips; rocking /writhing of trunk",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("474dfcb9-e6fa-4f40-8edc-dbedb08d2794"),
                                    Index = "c",
                                    Name = "TremorInvoluntaryRhythmicMovementsOfTheFingersLimbsHeadMouthTongue_L7c",
                                    Text = "Tremor — Involuntary rhythmic movements of the fingers, limbs, head, mouth, tongue",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("be38376e-efd1-42bc-b5a2-d1f1462f0717"),
                                    Index = "d",
                                    Name = "BradykinesiaDecreaseInSpontaneousMovementsEGReducedBodyMovementOrPovertyOfFacialExpressionGesturesSpeech_L7d",
                                    Text = "Bradykinesia — Decrease in spontaneous movements (e.g., reduced body movement, or poverty of facial expression, gestures, speech)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("fc64b350-7725-4b56-a78a-8f5fba634e36"),
                                    Index = "e",
                                    Name = "RigidityResistanceToFlexionAndExtensionOfMuscles_L7e",
                                    Text = "Rigidity — Resistance to flexion and extension of muscles",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7e191313-e92a-455a-82b2-bf46f27a0507"),
                                    Index = "f",
                                    Name = "DystoniaMuscleHypertonicityEGMuscleSpasmsOrStiffnessProtrudingTongueUpwardDeviationOfTheEyes_L7f",
                                    Text = "Dystonia — Muscle hypertonicity (e.g., muscle spasms or stiffness, protruding tongue, upward deviation of the eyes)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5a94e378-74d5-4421-9887-9f8335c43ef0"),
                                    Index = "g",
                                    Name = "SlowShufflingGaitReductionInSpeedAndStrideLengthUsuallyWithADecreaseInPendularArmMovement_L7g",
                                    Text = "Slow shuffling gait — Reduction in speed and stride length, usually with a decrease in pendular arm movement",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                            Index = "8",
                            Name = "BladderContinence_L8",
                            Text = "BLADDER CONTINENCE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("8a446937-4e7d-466b-aeb3-09896bd65bce"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "0",
                                    Text = "Continent — Complete control; DOES NOT USE any type of catheter or other urinary collection device",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("aecf9657-1f77-4374-8109-125ef98530f2"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "1",
                                    Text = "Control with any catheter or ostomy over last 3 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b1e6729a-ad3a-42be-a6de-b593fe3039e5"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "2",
                                    Text = "Infrequently incontinent — Not incontinent over last 3 days, but does have incontinent episodes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8438e679-d59e-4bb9-b677-45cdad41ea97"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "3",
                                    Text = "Occasionally incontinent — Less than daily",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d732ccc3-9eb3-4e5e-bb31-68b2bf94c975"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "4",
                                    Text = "Frequently incontinent — Daily, but some control present",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f53e1997-cd3c-49d1-a709-711650db3e9b"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "5",
                                    Text = "Incontinent — No control present",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("de0a5094-5e39-474b-a5eb-90018218d60d"),
                                    QuestionId = new Guid("01373987-c5c1-492a-a235-333d73b9c755"),
                                    Value = "8",
                                    Text = "Did not occur — No urine output from bladder in last 3 days",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                            Index = "9",
                            Name = "BowelContinence_L9",
                            Text = "BOWEL CONTINENCE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("e13a771f-5b45-4ef9-b56b-94ef40de91b7"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "0",
                                    Text = "Continent — Complete control; DOES NOT USE any type of ostomy device",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("17ce2bae-c7dc-4f24-ab99-c4e558ef1ba4"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "1",
                                    Text = "Control with ostomy — Control with ostomy device over last 3 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("58edf0d3-6c5a-44d3-abe1-e0d761e2cfee"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "2",
                                    Text = "Infrequently incontinent — Not incontinent over last 3 days, but does have incontinent episodes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("85417bd9-5132-4eaa-98f5-3bd4d8f0eb78"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "3",
                                    Text = "Occasionally incontinent — Less than daily",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8897f0ff-ef96-440b-9522-eab42aea89f4"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "4",
                                    Text = "Frequently incontinent — Daily, but some control present",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6d7c56ed-e7f5-457d-b2a3-4d4e437e7595"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "5",
                                    Text = "Incontinent — No control present",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9f9a411e-a68f-48aa-9c05-8d41ab177b7f"),
                                    QuestionId = new Guid("0285d343-7bad-4a4a-aa9a-637b9c56ab4e"),
                                    Value = "8",
                                    Text = "Did not occur — No bowel movement in last 3 days",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("7985a79b-1f3b-4019-9071-e498fe928e70"),
                            Index = "10",
                            Name = "ScheduledToileting_L10",
                            Text = "SCHEDULED TOILETING",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("acccb86f-0e48-4dd5-8679-18ca3b4e2119"),
                                    QuestionId = new Guid("7985a79b-1f3b-4019-9071-e498fe928e70"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c6d5af62-b55c-452f-836f-67da3e0c63cc"),
                                    QuestionId = new Guid("7985a79b-1f3b-4019-9071-e498fe928e70"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("4342211b-0dda-40bb-afe7-8da17b0201a0"),
                            Index = "11",
                            Name = "TotalHoursOfExerciseOrPhysicalActivityInLast3Days_L11",
                            Text = "TOTAL HOURS OF EXERCISE OR PHYSICAL ACTIVITY IN LAST 3 DAYS",
                            SubText = "e.g., walking, dancing, biking, sports",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("f6d51306-9120-420d-b381-c88bda98a6c6"),
                                    QuestionId = new Guid("4342211b-0dda-40bb-afe7-8da17b0201a0"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("66b76c9a-b7d2-49ec-afae-eeaf2c618994"),
                                    QuestionId = new Guid("4342211b-0dda-40bb-afe7-8da17b0201a0"),
                                    Value = "1",
                                    Text = "Less than 1 hour",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d076299e-fd47-4c59-af2d-371880529a06"),
                                    QuestionId = new Guid("4342211b-0dda-40bb-afe7-8da17b0201a0"),
                                    Value = "2",
                                    Text = "1–2 hours",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c9a1bd8d-e304-4def-b00e-ef74f3b30ea4"),
                                    QuestionId = new Guid("4342211b-0dda-40bb-afe7-8da17b0201a0"),
                                    Value = "3",
                                    Text = "3–4 hours",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a8d36a05-9a1c-424a-a243-484984dc1315"),
                                    QuestionId = new Guid("4342211b-0dda-40bb-afe7-8da17b0201a0"),
                                    Value = "4",
                                    Text = "More than 4 hours",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("c84367da-2878-43c8-94e2-2083c5452f72"),
                    Index = "M",
                    Description = "Family and Social Relations",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("97217d73-a782-4440-a69f-a08a1b44a239"),
                            Index = "1",
                            Name = "Parenting_M1",
                            Text = "PARENTING",
                            SubText = "Code for parent / primary caregiver interaction with child / youth. Take into account developmental level of child.",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0ed3fd53-c2e5-4bd0-b303-faa28772825c"),
                                    Index = "a",
                                    Name = "CommunicatesEffectivelyWithChildYouth_M1a",
                                    Text = "Communicates effectively with child / youth",
                                    SubText = "e.g., parent listens, validates appropriate concerns",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("30c82159-af26-4f14-9376-db29c6fcd163"),
                                    Index = "b",
                                    Name = "AssistsChildYouthWithTheRegulationOfEmotions_M1b",
                                    Text = "Assists child / youth with the regulation of emotions",
                                    SubText = "e.g., when overly upset, parent puts things into perspective",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("adf8f2f7-6e48-4041-bd4a-64effbee5b97"),
                                    Index = "c",
                                    Name = "UsesAppropriateDisciplinaryPractices_M1c",
                                    Text = "Uses appropriate disciplinary practices",
                                    SubText = "e.g., calmly addresses misbehaviour, uses discipline that is developmentally appropriate",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e7b4781e-b69a-4cab-9250-be9d0d3f5c2f"),
                                    Index = "d",
                                    Name = "DemonstratesWarmthAndSupport_M1d",
                                    Text = "Demonstrates warmth and support",
                                    SubText = "Responsive to child’s / youth’s needs, shows affection",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("87dc8ebd-dc71-4297-bd7e-6cf9e178612a"),
                                    Index = "e",
                                    Name = "AppropriateSupervisionAndMonitoring_M1e",
                                    Text = "Appropriate supervision and monitoring",
                                    SubText = "e.g., very young child or low-functioning youth is supervised at all times",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("39906c6b-c13f-40c4-9cd9-9a6be51011b3"),
                                    Index = "f",
                                    Name = "AppropriateLimitSettingOrExpectations_M1f",
                                    Text = "Appropriate limit setting or expectations",
                                    SubText = "Clear, reasonable limits are set for child / youth (e.g., 5-year-old is not allowed to cook on stove; 11-year-old is not allowed to stay out all night with friends)",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("5451aa4e-1927-4815-96c9-267f9d7d1bd8"),
                            Index = "2",
                            Name = "ComfortSeekingBehaviour_M2",
                            Text = "COMFORT-SEEKING BEHAVIOUR",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("d416baa5-4a48-44e0-94e6-6347a037e5f6"),
                                    Index = "a",
                                    Name = "SevereReluctanceToAcceptComfortFromParentSPrimaryCaregiverSWhenDistressed_M2a",
                                    Text = "Severe reluctance to accept comfort from parent(s) / primary caregiver(s) when distressed",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("bed4a3ad-1e68-4ce8-aefd-bd7ff24cc471"),
                                    Index = "b",
                                    Name = "WhenSeekingComfortDemonstratesAngerAndAmbivalenceTowardTheParentPrimaryCaregiver_M2b",
                                    Text = "When seeking comfort, demonstrates anger and ambivalence toward the parent / primary caregiver",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5ece5566-18ed-4e3a-adf9-110d2216b163"),
                                    Index = "c",
                                    Name = "SeeksComfortFromAnyAvailableAdult_M2c",
                                    Text = "Seeks comfort from any available adult",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("2d7c6319-f2cf-4492-9f8a-8fc136a80a13"),
                            Index = "3",
                            Name = "FamilyActivities_M3",
                            Text = "FAMILY ACTIVITIES",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("950ca6e1-5d51-4eb4-a29d-a27f3b362d85"),
                                    Index = "a",
                                    Name = "FamilyWentOnOutingsForRecreation_M3a",
                                    Text = "Family went on outings for recreation",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d3a067a2-358d-460a-b78f-cf3cac8b1e0c"),
                                    Index = "b",
                                    Name = "FamilyParticipatedInSitDownMealsTogether_M3b",
                                    Text = "Family participated in sit-down meals together",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("3dadd1a9-c25f-48bf-b588-d7b439ad5b4f"),
                            Index = "4",
                            Name = "UnpaidSupportsCurrentlyAvailableToFamily_M4",
                            Text = "UNPAID SUPPORTS CURRENTLY AVAILABLE TO FAMILY",
                            SubText = "Presence of one or more family members (outside nuclear family) or close friends who are willing and able to provide the following types of support",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("9c2abe8f-c1ee-4206-97f6-b7420c4aea24"),
                                    Index = "a",
                                    Name = "CrisisSituations_M4a",
                                    Text = "Crisis situations",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("87f6d570-1ee1-4cb7-b1d5-5c2f5125b76d"),
                                    Index = "b",
                                    Name = "FinancialProblems_M4b",
                                    Text = "Financial problems",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7ab04954-64bb-49da-9d92-06b064b3dc7b"),
                                    Index = "c",
                                    Name = "Babysitting_M4c",
                                    Text = "Babysitting",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3a21fd4d-4c37-41f4-a951-441bca30e77c"),
                                    Index = "d",
                                    Name = "EmotionalSupport_M4d",
                                    Text = "Emotional support",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c1a4b545-71e4-454d-8d54-421a81ff5e6f"),
                                    Index = "e",
                                    Name = "Respite_M4e",
                                    Text = "Respite",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("aa06edd9-afaa-45ba-aaa8-0f423096f8a0"),
                            Index = "5",
                            Name = "UnsettledRelationships_M5",
                            Text = "UNSETTLED RELATIONSHIPS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("5714c74e-be09-49d5-9ca4-3b0efcc3c7f7"),
                                    Index = "a",
                                    Name = "ConflictWithOrRepeatedCriticismOfFamily_M5a",
                                    Text = "Conflict with or repeated criticism of family",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("89b2eedf-5f52-41ca-bc69-9f6ee3a860e6"),
                                    Index = "b",
                                    Name = "ConflictWithOrRepeatedCriticismOfCloseFriends_M5b",
                                    Text = "Conflict with or repeated criticism of close friends",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("da1c6577-e83b-4cdf-8b59-f4744bc1ca5d"),
                                    Index = "c",
                                    Name = "StaffReportPersistentFrustrationInDealingWithChildYouth_M5c",
                                    Text = "Staff report persistent frustration in dealing with child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("fbc939b2-62f5-420a-a7a9-f8ecb49c7523"),
                                    Index = "d",
                                    Name = "FamilyArePersistentlyHostileOrCriticalOfChildYouth_M5d",
                                    Text = "Family are persistently hostile or critical of child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("99a9ff29-790c-4f5b-9f7a-1c51e4730418"),
                                    Index = "e",
                                    Name = "FriendsArePersistentlyHostileOrCriticalOfChildYouth_M5e",
                                    Text = "Friends are persistently hostile or critical of child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("53f65853-391c-4e3c-b948-f66bbcb38e89"),
                                    Index = "f",
                                    Name = "PervasiveConflictWithPeersExcludeCloseFriends_M5f",
                                    Text = "Pervasive conflict with peers (EXCLUDE CLOSE FRIENDS)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("77beca57-7005-414b-ad61-0aa8728fdcb6"),
                                    Index = "g",
                                    Name = "ConflictOrRepeatedCriticismBetweenParentsPrimaryCaregivers_M5g",
                                    Text = "Conflict or repeated criticism between parents / primary caregivers",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("37f8cc19-ba96-48fe-a773-eca6aa211b7d"),
                                    Index = "h",
                                    Name = "FamilyMembersReportFeelingOverwhelmedByChildSYouthSCondition_M5h",
                                    Text = "Family members report feeling overwhelmed by child’s / youth’s condition",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                            Index = "6",
                            Name = "LengthOfTimeWithoutParentalSupervisionInTypical24HourPeriodInUsualResidence_M6",
                            Text = "LENGTH OF TIME WITHOUT PARENTAL SUPERVISION IN TYPICAL 24-HOUR PERIOD IN USUAL RESIDENCE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("71970366-3a82-4023-aa33-822e58e55042"),
                                    QuestionId = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b44fb756-e3e7-4769-9266-e673e362e2c4"),
                                    QuestionId = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                                    Value = "1",
                                    Text = "More than none but less than 1 hour",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("667fbe9b-2aa8-4ee9-85b7-4daecf442d80"),
                                    QuestionId = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                                    Value = "2",
                                    Text = "1–2 hours",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("988830a9-0df2-46ee-89d3-25ff50fc5ab7"),
                                    QuestionId = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                                    Value = "3",
                                    Text = "More than 2 hours but less than 8 hours",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6598c0d1-20ed-4a4b-8be4-af2864d452c5"),
                                    QuestionId = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                                    Value = "4",
                                    Text = "8 hours or more",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b8dd7c4d-e46d-4899-ab81-5da0c595fb3b"),
                                    QuestionId = new Guid("dcfaa541-256b-4d41-9e97-2703b47aded2"),
                                    Value = "8",
                                    Text = "Does not leave facility-based care",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("5e3e9007-c267-42bf-afed-bd533bf036b4"),
                            Index = "7",
                            Name = "TwoKeyCaregivers_M7",
                            Text = "TWO KEY CAREGIVERS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("7727a02b-4147-402b-9078-1fada99edb2c"),
                                    Index = "a",
                                    Name = "Caregiver1RelationshipToChildYouth_M7a",
                                    Text = "Caregiver 1 - Relationship to child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("118b8147-eced-4ba8-80c7-1837ac3960ed"),
                                    Index = "b",
                                    Name = "Caregiver2RelationshipToChildYouth_M7b",
                                    Text = "Caregiver 2 - Relationship to child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0185ca0c-1db7-4e2d-a77c-ec6a4dac2eb4"),
                                    Index = "c",
                                    Name = "Caregiver1LivesWithChildYouth_M7c",
                                    Text = "Caregiver 1 - Lives with child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("767bb7b8-34d4-4533-b559-5a554d722594"),
                                    Index = "d",
                                    Name = "Caregiver2LivesWithChildYouth_M7d",
                                    Text = "Caregiver 2 - Lives with child / youth",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("29eb4c9e-c9e5-4af1-97a1-593fc41744a9"),
                            Index = "8",
                            Name = "CaregiverStatus_M8",
                            Text = "CAREGIVER STATUS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("50127935-33d6-4cad-808b-f0e3d1305263"),
                                    Index = "a",
                                    Name = "Caregiver1InSchoolOrWorkFullTime_M8a",
                                    Text = "Caregiver 1 - In school or work full-time",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5cdcacb7-8abb-490e-8b5b-5f28f2fe458b"),
                                    Index = "b",
                                    Name = "Caregiver2InSchoolOrWorkFullTime_M8b",
                                    Text = "Caregiver 2 - In school or work full-time",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("debad9d7-5645-45aa-b3c4-192cff0472c1"),
                                    Index = "c",
                                    Name = "Caregiver1InSchoolOrWorkPartTime_M8c",
                                    Text = "Caregiver 1 - In school or work part-time",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9f5cda68-8850-4a80-ae88-0c9a2bfd581d"),
                                    Index = "d",
                                    Name = "Caregiver2InSchoolOrWorkPartTime_M8d",
                                    Text = "Caregiver 2 - In school or work part-time",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("3ee62932-96c6-4141-8ef0-35a5aa26ee75"),
                            Index = "9",
                            Name = "PeerGroupIncludesIndividualsWithPersistentAntisocialBehaviour_M9",
                            Text = "PEER GROUP INCLUDES INDIVIDUALS WITH PERSISTENT ANTISOCIAL BEHAVIOUR",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("9949fb0f-69a5-4590-901c-63811b60deda"),
                                    QuestionId = new Guid("3ee62932-96c6-4141-8ef0-35a5aa26ee75"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9c6df09c-5d3e-4b99-929e-1e12665c8de0"),
                                    QuestionId = new Guid("3ee62932-96c6-4141-8ef0-35a5aa26ee75"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("b5076a28-9fb6-4050-baf7-b044b2c51680"),
                    Index = "N",
                    Description = "Psychosocial Well-Being",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("afcf8156-1097-4559-a8d2-8e5579f326d8"),
                            Index = "1",
                            Name = "NumberOfDaysOfParticipationInPreferredRecreationAndLeisureActivitiesInLast7Days_N1",
                            Text = "NUMBER OF DAYS OF PARTICIPATION IN PREFERRED RECREATION AND LEISURE ACTIVITIES IN LAST 7 DAYS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("82e43282-e9d1-4628-bdf6-2ee8c6061bde"),
                            Index = "2",
                            Name = "ChildSYouthSSenseOfInvolvement_N2",
                            Text = "CHILD’S / YOUTH’S SENSE OF INVOLVEMENT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0a2806dc-be1c-4ef2-ab93-a253e84fa1fa"),
                                    Index = "a",
                                    Name = "AtEaseInteractingWithOthers_N2a",
                                    Text = "At ease interacting with others",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b77e2d91-7328-4d2a-97d6-8dba01a4497f"),
                                    Index = "b",
                                    Name = "AtEaseDoingPlannedOrStructuredActivities_N2b",
                                    Text = "At ease doing planned or structured activities",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e25205e3-f3c1-4d82-a482-0dbb5123542f"),
                                    Index = "c",
                                    Name = "PursuesInvolvementInActivitiesOfSchoolResidentialSettingOrCommunity_N2c",
                                    Text = "Pursues involvement in activities of school, residential setting, or community",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0f9103b8-c6bc-477c-8a95-eb68c9c468d8"),
                                    Index = "d",
                                    Name = "InitiatesInteractionSWithOthers_N2d",
                                    Text = "Initiates interaction(s) with others",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("91b580b2-55ba-4ffb-9c64-7417e9a64691"),
                                    Index = "e",
                                    Name = "ReactsPositivelyToInteractionsInitiatedByOthers_N2e",
                                    Text = "Reacts positively to interactions initiated by others",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("fecac8d7-7921-486c-9ece-2631f9e36b03"),
                            Index = "3",
                            Name = "ChildYouthPrefersChangeWhenAsked_N3",
                            Text = "CHILD / YOUTH PREFERS CHANGE (WHEN ASKED)",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("c3ac538f-6fed-43ad-9145-743442202906"),
                                    Index = "a",
                                    Name = "RecreationalActivities_N3a",
                                    Text = "Recreational activities",
                                    SubText = "e.g., type, number, or what level of participation",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3f63bb8b-a219-4b0d-a0ef-ae21cea32124"),
                                    Index = "b",
                                    Name = "LivingArrangements_N3b",
                                    Text = "Living arrangements",
                                    SubText = "e.g., location, type, who lives with",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e3838f19-ba11-499c-836e-e8182bac5289"),
                                    Index = "c",
                                    Name = "DailyRoutine_N3c",
                                    Text = "Daily routine",
                                    SubText = "e.g., diet, sleep schedule, clothes to wear",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8cce9aa2-d201-4f69-b700-94ab613d14c2"),
                                    Index = "d",
                                    Name = "SupportsAndServices_N3d",
                                    Text = "Supports and services",
                                    SubText = "e.g., programs, staff",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c92d21ae-44c6-4581-8ab0-dc4870c3eaab"),
                                    Index = "e",
                                    Name = "Relationships_N3e",
                                    Text = "Relationships",
                                    SubText = "e.g., establishing friendships, improving existing relationships",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("29595494-e294-4da3-8385-700f7060cbc7"),
                            Index = "4",
                            Name = "ChildYouthDemonstratesLimitedAbilityToEngageInUnstructuredPlayOrLeisure_N4",
                            Text = "CHILD / YOUTH DEMONSTRATES LIMITED ABILITY TO ENGAGE IN UNSTRUCTURED PLAY OR LEISURE",
                            SubText = "e.g., does not interact with play materials, does not spontaneously initiate play",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("b101d5c9-2df4-43e0-992c-f8e4cec58d29"),
                                    QuestionId = new Guid("29595494-e294-4da3-8385-700f7060cbc7"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("5265ff16-8ef6-4ad5-9108-6c29a888cd60"),
                                    QuestionId = new Guid("29595494-e294-4da3-8385-700f7060cbc7"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("31d8f09d-647f-4781-bc49-871f42a64afa"),
                    Index = "O",
                    Description = "Stress and Trauma",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("a13816d7-4a6d-465d-89a4-6665eb26c825"),
                            Index = "1",
                            Name = "LifeEvents_O1",
                            Text = "LIFE EVENTS",
                            SubText = "Code for most recent time of event",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("ff316ab1-39dd-411d-a013-6cc03ea5466c"),
                                    Index = "a",
                                    Name = "SeriousAccidentOrPhysicalImpairment_O1a",
                                    Text = "Serious accident or physical impairment",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8664e918-0980-4892-983d-da9aef3fb1b8"),
                                    Index = "b",
                                    Name = "DeathOrLossOfParentOrPrimaryCaregiver_O1b",
                                    Text = "Death or loss of parent or primary caregiver",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0b7e82a1-5dc8-49d2-96a3-ce1cbd498cfc"),
                                    Index = "c",
                                    Name = "DeathOrLossOfOtherCloseFamilyMember_O1c",
                                    Text = "Death or loss of other close family member",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("419988b0-4043-4e4f-b395-49f1da206cd5"),
                                    Index = "d",
                                    Name = "WitnessedSevereAccidentDisasterTerrorismViolenceOrAbuse_O1d",
                                    Text = "Witnessed severe accident, disaster, terrorism, violence, or abuse",
                                    SubText = "EXCLUDE DOMESTIC VIOLENCE OR ABUSE",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("2f39f5c9-ecb6-4fab-ab9a-83a116bc4373"),
                                    Index = "e",
                                    Name = "VictimOfCrimeExcludeAssault_O1e",
                                    Text = "Victim of crime — EXCLUDE ASSAULT",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7d585cec-05e2-4899-8f37-da3e0b7073aa"),
                                    Index = "f",
                                    Name = "VictimOfSexualAssaultOrAbuse_O1f",
                                    Text = "Victim of sexual assault or abuse",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("6d85d1cb-73cb-40d5-a0a5-962ffc0987fb"),
                                    Index = "g",
                                    Name = "VictimOfPhysicalAssaultOrAbuse_O1g",
                                    Text = "Victim of physical assault or abuse",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0091ebd0-20b0-405f-8a75-8c01ce9318e4"),
                                    Index = "h",
                                    Name = "VictimOfEmotionalAbuse_O1h",
                                    Text = "Victim of emotional abuse",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ae76bcf5-7fd5-44ec-87c4-9731fac28b16"),
                                    Index = "i",
                                    Name = "VictimOfBullying_O1i",
                                    Text = "Victim of bullying",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("36ea467d-8948-4938-86bd-6660f0f294c7"),
                                    Index = "j",
                                    Name = "AbandonedByParentSPrimaryCaregiverS_O1j",
                                    Text = "Abandoned by parent(s) / primary caregiver(s)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("76e3c0de-69a0-4725-a3dc-daaf4c48f57e"),
                                    Index = "k",
                                    Name = "WitnessedDomesticViolence_O1k",
                                    Text = "Witnessed domestic violence",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ed38861d-6746-4476-8020-0f98b12b5e8f"),
                                    Index = "l",
                                    Name = "ParentalAddictionOrSubstanceAbuse_O1l",
                                    Text = "Parental addiction or substance abuse",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3ca880ab-106d-42f1-a87a-4f3a7dd98416"),
                                    Index = "m",
                                    Name = "LivesInNeighbourhoodWithPervasiveViolenceOrCriminalActivity_O1m",
                                    Text = "Lives in neighbourhood with pervasive violence or criminal activity",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("147437ad-60b5-4b5c-91d3-d2fd2d95e40c"),
                            Index = "2",
                            Name = "DescribesOneOrMoreOfTheseLifeEventsO1AsInvokingASenseOfHorrorOrIntenseFear_O2",
                            Text = "DESCRIBES ONE OR MORE OF THESE LIFE EVENTS (O1) AS INVOKING A SENSE OF HORROR OR INTENSE FEAR",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("80394016-01c3-4d2b-87ca-c3ce35eb08d7"),
                                    QuestionId = new Guid("147437ad-60b5-4b5c-91d3-d2fd2d95e40c"),
                                    Value = "0",
                                    Text = "No or not applicable",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a2f7dfce-54b5-49f2-9b97-2bcd8fb35198"),
                                    QuestionId = new Guid("147437ad-60b5-4b5c-91d3-d2fd2d95e40c"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a83e0351-e80b-4e0c-9e98-02eedaea8b36"),
                                    QuestionId = new Guid("147437ad-60b5-4b5c-91d3-d2fd2d95e40c"),
                                    Value = "8",
                                    Text = "Could not (would not) respond",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("99f83e28-95ce-4b09-8629-3aab13a2099d"),
                            Index = "3",
                            Name = "MajorLifeStressorsForParentSPrimaryCaregiverSInLast90Days_O3",
                            Text = "MAJOR LIFE STRESSORS FOR PARENT(S) / PRIMARY CAREGIVER(S) IN LAST 90 DAYS",
                            SubText = "e.g., episode of severe illness, death or severe illness of close family member / friend, loss of home, major loss of income / assets, victim of crime or robbery, persistent unemployment",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("801a92d6-2e2f-46b6-bc21-216db18eb9bd"),
                                    QuestionId = new Guid("99f83e28-95ce-4b09-8629-3aab13a2099d"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("4631c787-d42d-467d-bcf8-0e94ac1c362d"),
                                    QuestionId = new Guid("99f83e28-95ce-4b09-8629-3aab13a2099d"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7ada26de-91af-453f-9168-ba420bb160d4"),
                                    QuestionId = new Guid("99f83e28-95ce-4b09-8629-3aab13a2099d"),
                                    Value = "8",
                                    Text = "Unknown or not applicable",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("f728e064-404a-493e-ad05-20683b44dc0d"),
                            Index = "4",
                            Name = "FamilyMemberSOrOtherPrimaryCaregiverSHasHaveCurrentDevelopmentalOrMentalHealthIssues_O4",
                            Text = "FAMILY MEMBER(S) OR OTHER PRIMARY CAREGIVER(S) HAS (HAVE) CURRENT DEVELOPMENTAL OR MENTAL HEALTH ISSUES",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("184b1894-d2d3-49f9-8855-c4bd2dbd4fd6"),
                                    Index = "a",
                                    Name = "ParentSPrimaryCaregiverS_O4a",
                                    Text = "Parent(s) / primary caregiver(s)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("ad380a81-fd55-4f98-b52b-eb8ddc48a325"),
                                    Index = "b",
                                    Name = "SiblingS_O4b",
                                    Text = "Sibling(s)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("fa1d5bf0-0d69-41b1-b58f-47b22f88b088"),
                            Index = "5",
                            Name = "CaregiverDistress_O5",
                            Text = "CAREGIVER DISTRESS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("4659155b-c0a2-4b0d-a364-6b3ecc1cd3a2"),
                                    Index = "a",
                                    Name = "ParentPrimaryCaregiverIsUnableOrUnwillingToContinueInCaringActivities_O5a",
                                    Text = "Parent / primary caregiver is unable or unwilling to continue in caring activities",
                                    SubText = "e.g., caregiver’s health makes it difficult to continue; lack of desire, competing responsibilities",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b6f42309-b53a-4fe4-b17c-0e9a902c4a74"),
                                    Index = "b",
                                    Name = "ParentPrimaryCaregiverExpressesFeelingsOfDistressAngerOrDepression_O5b",
                                    Text = "Parent / primary caregiver expresses feelings of distress, anger, or depression",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("83489867-f568-4b56-96ae-22b0915addb3"),
                            Index = "6",
                            Name = "Finances_O6",
                            Text = "FINANCES",
                            SubText = "Because of limited funds, during the last 30 days PARENT / PRIMARY CAREGIVER OR YOUTH (if youth is an emancipated minor) made trade-offs among purchasing any of the following: adequate food, shelter, clothing; prescribed medications; sufficient home heat or cooling; necessary care",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("200c8ccd-cdda-41ef-8536-1d1dce76329e"),
                                    QuestionId = new Guid("83489867-f568-4b56-96ae-22b0915addb3"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3e02d39c-b15c-4952-a8e9-e8aaa309f5b2"),
                                    QuestionId = new Guid("83489867-f568-4b56-96ae-22b0915addb3"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c864e25f-a41c-4c40-8725-e7cc33c784ec"),
                            Index = "7",
                            Name = "ChildYouthHasEverBeenRemovedFromHomeByChildProtectionAgencyOrCourt_O7",
                            Text = "CHILD / YOUTH HAS EVER BEEN REMOVED FROM HOME BY CHILD PROTECTION AGENCY OR COURT",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("bbbd1b07-a558-455d-ae73-994c28c34244"),
                                    QuestionId = new Guid("c864e25f-a41c-4c40-8725-e7cc33c784ec"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("14facb39-fb50-4e4b-8666-d2b26daf8097"),
                                    QuestionId = new Guid("c864e25f-a41c-4c40-8725-e7cc33c784ec"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("601c4578-6b20-47a3-88aa-f7d847c87e8f"),
                            Index = "8",
                            Name = "OtherIndicatorsOfAbuseOfChildYouth_O8",
                            Text = "OTHER INDICATORS OF ABUSE OF CHILD / YOUTH",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("2af972ae-52b9-41a5-a1f7-e0388b5a074c"),
                                    Index = "a",
                                    Name = "FearfulOfAFamilyMemberOrCloseAcquaintance_O8a",
                                    Text = "Fearful of a family member or close acquaintance",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e535b091-a160-420e-b410-04cca4108047"),
                                    Index = "b",
                                    Name = "UnexplainedBruisesOrOtherInjuries_O8b",
                                    Text = "Unexplained bruises or other injuries",
                                    SubText = "e.g., burns, cuts",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("4a42d530-b18a-4cc3-9f05-c815fc2f352e"),
                                    Index = "c",
                                    Name = "ChildYouthHasConcernsForHisHerSafety_O8c",
                                    Text = "Child / youth has concerns for his / her safety",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e9480901-fa7f-4122-83ca-ecda0c807ec1"),
                                    Index = "d",
                                    Name = "FamilyCaregiverFriendOrStaffExpressesConcernThatChildYouthIsAtImminentRiskForVictimization_O8d",
                                    Text = "Family, caregiver, friend, or staff expresses concern that child / youth is at imminent risk for victimization",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e973b8f7-369c-4463-956a-5f1ddf422911"),
                                    Index = "e",
                                    Name = "ChildYouthRegularlyMissesMedicationsPrescribedCareRoutinesTherapiesOrPhysicianVisits_O8e",
                                    Text = "Child / youth regularly misses medications, prescribed care routines, therapies, or physician visits",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("5c3a0f1c-f827-4866-b78c-8d05ca7fa388"),
                    Index = "P",
                    Description = "Medications",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("83f964c1-4b09-45bd-91f0-488739a7cc28"),
                            Index = "1",
                            Name = "ListOfAllMedications_P1",
                            Text = "LIST OF ALL MEDICATIONS",
                            SubText = "[Optional] Document medications on last page in space provided",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("6918804a-8c78-488b-abf1-8fb02f41f93c"),
                            Index = "2",
                            Name = "AdherentWithMedicationsPrescribedByPhysician_P2",
                            Text = "ADHERENT WITH MEDICATIONS PRESCRIBED BY PHYSICIAN",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("c91e6d47-7718-4ef5-a833-f775e37825c5"),
                                    QuestionId = new Guid("6918804a-8c78-488b-abf1-8fb02f41f93c"),
                                    Value = "0",
                                    Text = "Always adherent",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2f2061f0-1efc-4509-92db-fc26d700dcf7"),
                                    QuestionId = new Guid("6918804a-8c78-488b-abf1-8fb02f41f93c"),
                                    Value = "1",
                                    Text = "Adherent 80% of time or more",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6f55a76f-9fa9-42a8-8ee6-23a80b0c7899"),
                                    QuestionId = new Guid("6918804a-8c78-488b-abf1-8fb02f41f93c"),
                                    Value = "2",
                                    Text = "Adherent less than 80% of time, including failure to purchase prescribed medications",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f1c3b067-615d-4a1b-9d77-a9b2fb4d7c68"),
                                    QuestionId = new Guid("6918804a-8c78-488b-abf1-8fb02f41f93c"),
                                    Value = "8",
                                    Text = "No medications prescribed",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("6e55f842-ce2a-4e79-981b-92d974b60407"),
                            Index = "3",
                            Name = "ChildYouthStoppedTakingPsychotropicMedicationInLast90DaysBecauseOfSideEffects_P3",
                            Text = "CHILD / YOUTH STOPPED TAKING PSYCHOTROPIC MEDICATION IN LAST 90 DAYS BECAUSE OF SIDE EFFECTS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("a354bb5d-967d-4111-9275-58f038472375"),
                                    QuestionId = new Guid("6e55f842-ce2a-4e79-981b-92d974b60407"),
                                    Value = "0",
                                    Text = "No, or no psychotropic medications",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("130ad834-a2ab-47e4-8a21-eb491b06a8d0"),
                                    QuestionId = new Guid("6e55f842-ce2a-4e79-981b-92d974b60407"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("1319c134-a093-4412-84b0-f7496efca6a2"),
                            Index = "4",
                            Name = "ChildYouthRefusedToTakeSomeOrAllOfPrescribedMedicationInLast3Days_P4",
                            Text = "CHILD / YOUTH REFUSED TO TAKE SOME OR ALL OF PRESCRIBED MEDICATION IN LAST 3 DAYS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("84e1bc3c-81bd-4f64-b542-46c7d226459b"),
                                    QuestionId = new Guid("1319c134-a093-4412-84b0-f7496efca6a2"),
                                    Value = "0",
                                    Text = "No, or no medications",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0f44889f-6f35-403a-923f-8fac177a0129"),
                                    QuestionId = new Guid("1319c134-a093-4412-84b0-f7496efca6a2"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c3ac580b-e7af-42ee-b9e5-908305310d79"),
                            Index = "5",
                            Name = "ParentCaregiverAssistsWithMedicationUse_P5",
                            Text = "PARENT / CAREGIVER ASSISTS WITH MEDICATION USE",
                            SubText = "e.g., provides supervision; administers medications; fills prescriptions",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("6c234d0f-7c0d-4bae-9460-f28bc6c542a5"),
                                    QuestionId = new Guid("c3ac580b-e7af-42ee-b9e5-908305310d79"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("072d2cfa-7456-4ca5-9615-28026441fbaf"),
                                    QuestionId = new Guid("c3ac580b-e7af-42ee-b9e5-908305310d79"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("94213d37-b6be-4c89-a53b-891927b1bf89"),
                                    QuestionId = new Guid("c3ac580b-e7af-42ee-b9e5-908305310d79"),
                                    Value = "8",
                                    Text = "Not needed or no parent / primary caregiver",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("522fe896-eaa0-4303-9e72-dfc84466f94a"),
                            Index = "6",
                            Name = "AllergyToAnyDrug_P6",
                            Text = "ALLERGY TO ANY DRUG",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("66a2ac66-a568-4cc6-b3cb-36b50a86678b"),
                                    QuestionId = new Guid("522fe896-eaa0-4303-9e72-dfc84466f94a"),
                                    Value = "0",
                                    Text = "No known drug allergies",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ef632926-26a7-4e76-b99b-06a41aab3dee"),
                                    QuestionId = new Guid("522fe896-eaa0-4303-9e72-dfc84466f94a"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("85ec97fc-12af-45dc-80e9-68f96984166a"),
                    Index = "Q",
                    Description = "Prevention, Service Utilization, Treatments",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("5cc5c669-e54f-4991-b359-fb4795301c75"),
                            Index = "1",
                            Name = "Prevention_Q1",
                            Text = "PREVENTION",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("b5a84e6b-335d-4683-9000-912d5154a171"),
                                    Index = "a",
                                    Name = "DentalExamInLastYear_Q1a",
                                    Text = "Dental exam in last YEAR",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("cf084a28-b8af-4763-8526-58cc31836d82"),
                                    Index = "b",
                                    Name = "ImmunizationsUpToDate_Q1b",
                                    Text = "Immunizations up-to-date",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5c0aa74e-9ca9-41e5-97e0-1e8cc7e686d3"),
                                    Index = "c",
                                    Name = "EyeExamInLastYear_Q1c",
                                    Text = "Eye exam in last YEAR",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("cf7047b1-89a1-49c9-b8c6-4050781486e1"),
                                    Index = "d",
                                    Name = "HearingExamInLastYear_Q1d",
                                    Text = "Hearing exam in last YEAR",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("38c02fe1-b699-4420-ad72-0a75961dee8f"),
                            Index = "2",
                            Name = "FormalCare_Q2",
                            Text = "FORMAL CARE",
                            SubText = "Contact with formal care provider",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("9fc3f68e-0f74-418c-9667-2d2d4253c3de"),
                                    Index = "a",
                                    Name = "Psychiatrist_Q2a",
                                    Text = "Psychiatrist",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e6281e8e-d89e-4a2a-9b2a-30e134e05dcc"),
                                    Index = "b",
                                    Name = "SocialWorker_Q2b",
                                    Text = "Social worker",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c14907d6-3873-4e52-801c-52bc527cdac5"),
                                    Index = "c",
                                    Name = "PsychologistPsychometristPsychologicalAssociate_Q2c",
                                    Text = "Psychologist, psychometrist, psychological associate",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("32c592fe-2845-41b5-bf06-1e47e4905e8e"),
                                    Index = "d",
                                    Name = "OccupationalTherapistPhysiotherapist_Q2d",
                                    Text = "Occupational therapist, physiotherapist",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f5c073d3-2002-4d6c-96f7-ab149ab55f11"),
                                    Index = "e",
                                    Name = "BehaviourTherapist_Q2e",
                                    Text = "Behaviour therapist",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("977950d6-cafc-4660-8e45-b900c20476a1"),
                                    Index = "f",
                                    Name = "RecreationArtMusicPlayTherapist_Q2f",
                                    Text = "Recreation, art, music, play therapist",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("65132413-6333-487f-a517-525850ff200d"),
                                    Index = "g",
                                    Name = "RegisteredNurse_Q2g",
                                    Text = "Registered nurse",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("19c00f0c-a2be-4fda-96a5-e0e74138b64c"),
                                    Index = "h",
                                    Name = "ChildYouthCounsellor_Q2h",
                                    Text = "Child / youth counsellor",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d1c42b12-6904-4482-85f8-cb3fd838de90"),
                                    Index = "i",
                                    Name = "ChildProtection_Q2i",
                                    Text = "Child protection",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7a48e8bf-8c8c-4d92-8c0b-9f49c9efbb8a"),
                                    Index = "j",
                                    Name = "SpeechLanguagePathologist_Q2j",
                                    Text = "Speech language pathologist",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f5c328f2-e413-4b3e-8dcf-30b8f135324e"),
                                    Index = "k",
                                    Name = "DevelopmentalServicesWorkerOrDirectCareStaff_Q2k",
                                    Text = "Developmental services worker or direct care staff",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("58b86947-19a4-4b1b-953d-f689b786228b"),
                                    Index = "l",
                                    Name = "HealthCareAidePersonalSupportWorker_Q2l",
                                    Text = "Health care aide / personal support worker",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("32b5c125-414d-495a-bc5d-c7f52b7c5b0e"),
                                    Index = "m",
                                    Name = "Dietician_Q2m",
                                    Text = "Dietician",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("e8fc02d7-780f-4a41-ae72-ed3785b4fda8"),
                            Index = "3",
                            Name = "FocusOfInterventions_Q3",
                            Text = "FOCUS OF INTERVENTIONS",
                            SubText = "Code for types of issues that were a major focus of interventions in LAST 30 DAYS (or since admission if LESS THAN 30 DAYS)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("8457577d-6ae6-4fed-ac77-ba761eb51598"),
                                    Index = "a",
                                    Name = "LifeSkillsTraining_Q3a",
                                    Text = "Life skills training",
                                    SubText = "e.g., communication, money management",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("17a7c0bb-dd70-46ab-9c79-66975e860ccd"),
                                    Index = "b",
                                    Name = "SelfCareSkills_Q3b",
                                    Text = "Self-care skills",
                                    SubText = "e.g., dressing, eating, hygiene",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("536d4eb6-c870-4341-b150-eff57ebfeb9b"),
                                    Index = "c",
                                    Name = "SocialSkills_Q3c",
                                    Text = "Social skills",
                                    SubText = "e.g., interpersonal skills, etiquette",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("cf739311-3708-49a8-b6ed-5a254d4b36a1"),
                                    Index = "d",
                                    Name = "FamilyFunctioning_Q3d",
                                    Text = "Family functioning",
                                    SubText = "e.g., positive parenting, family cohesion",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("45ecd60e-d178-4c09-8ce9-42a9004ea779"),
                                    Index = "e",
                                    Name = "CognitiveSkills_Q3e",
                                    Text = "Cognitive skills",
                                    SubText = "e.g., reading, letters, colour recognition",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e9b0b154-8098-4e7b-8d91-e99d3271c591"),
                                    Index = "f",
                                    Name = "BehaviourManagement_Q3f",
                                    Text = "Behaviour management",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("421db84c-12fc-4d01-b310-9b8aca8ef8b4"),
                                    Index = "g",
                                    Name = "CrisisIntervention_Q3g",
                                    Text = "Crisis intervention",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("83b52acf-5595-40ae-8ce7-0baa1590fa88"),
                                    Index = "h",
                                    Name = "FamilyPreservation_Q3h",
                                    Text = "Family preservation",
                                    SubText = "e.g., intensive in-home program",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("98d2f9b2-be9d-4f8e-b1fa-712194fd8a5e"),
                                    Index = "i",
                                    Name = "FamilySupport_Q3i",
                                    Text = "Family support",
                                    SubText = "e.g., Wraparound, Respite Homes",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b38c1c40-845d-4d00-8127-c6b550b1e67c"),
                                    Index = "j",
                                    Name = "SensoryStimulation_Q3j",
                                    Text = "Sensory stimulation",
                                    SubText = "e.g., aromatherapy, sensory room, music therapy",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("2ea42a15-67bc-458e-b893-7bff918c9488"),
                                    Index = "k",
                                    Name = "EducationOnSpecialTopics_Q3k",
                                    Text = "Education on special topics",
                                    SubText = "e.g., sexuality, safety",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b86a1f92-e211-4d7d-98ad-585a7ecec71a"),
                                    Index = "l",
                                    Name = "MedicationManagement_Q3l",
                                    Text = "Medication management",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("e204df33-6ba0-4978-ac2e-bfafec09278c"),
                            Index = "4",
                            Name = "TreatmentModalities_Q4",
                            Text = "TREATMENT MODALITIES",
                            SubText = "Code for treatment modalities used in LAST 30 DAYS (or since admission if LESS THAN 30 DAYS)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0c02a957-44b4-4f9e-97a3-7d8f0dfdc5cc"),
                                    Index = "a",
                                    Name = "Individual_Q4a",
                                    Text = "Individual",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("83248c3e-7b0b-47e8-89f7-5bdd038861c3"),
                                    Index = "b",
                                    Name = "Group_Q4b",
                                    Text = "Group",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("53a6169e-3d4f-462e-b191-aa191e28cae5"),
                                    Index = "c",
                                    Name = "FamilyOrCouple_Q4c",
                                    Text = "Family or couple",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("40ff6600-fb0a-40d2-93bd-45792d969f37"),
                                    Index = "d",
                                    Name = "SelfHelpConsumerGroup_Q4d",
                                    Text = "Self-help / consumer group",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("d8689770-2b6b-436d-93b0-ddbaeeb89239"),
                            Index = "5",
                            Name = "CaseManagement_Q5",
                            Text = "CASE MANAGEMENT",
                            SubText = "Receives formal care coordination services",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("c142421c-fda5-4999-9263-c449357b86ed"),
                                    QuestionId = new Guid("d8689770-2b6b-436d-93b0-ddbaeeb89239"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("4663b55c-3c6b-4d80-8fd8-f4654c031333"),
                                    QuestionId = new Guid("d8689770-2b6b-436d-93b0-ddbaeeb89239"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("f3d9df95-7520-404d-83c3-9dd153ebeaf8"),
                            Index = "6",
                            Name = "HospitalUseEmergencyRoomUsePhysicianVisit_Q6",
                            Text = "HOSPITAL USE, EMERGENCY ROOM USE, PHYSICIAN VISIT",
                            SubText = "Code for number of times during the LAST 90 DAYS (or since last assessment if LESS THAN 90 DAYS AGO)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("470a539f-588f-475a-afa5-a8e400e71be3"),
                                    Index = "a",
                                    Name = "InPatientAcuteHospitalWithOvernightStayNonpsychiatric_Q6a",
                                    Text = "In-patient acute hospital with overnight stay (nonpsychiatric)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("1a72b7e5-a641-4e0b-a482-9e0ccc28a123"),
                                    Index = "b",
                                    Name = "EmergencyRoomVisitNotCountingOvernightStay_Q6b",
                                    Text = "Emergency room visit (not counting overnight stay)",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("9d6608b3-b821-45f9-aa12-a9f1626dca88"),
                                    Index = "c",
                                    Name = "PhysicianVisitOrAuthorizedAssistantOrPractitioner_Q6c",
                                    Text = "Physician visit (or authorized assistant or practitioner)",
                                    SubText = "EXCLUDE PSYCHIATRIST",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("bba57065-d5a4-438f-8bb5-a358044cb318"),
                            Index = "7",
                            Name = "ProtectiveBodyGearUsedInLast7Days_Q7",
                            Text = "PROTECTIVE BODY GEAR USED IN LAST 7 DAYS",
                            SubText = "e.g., helmet, kneepads",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("f934a3ae-f30d-4718-ae86-e3c43c8e5ee8"),
                                    QuestionId = new Guid("bba57065-d5a4-438f-8bb5-a358044cb318"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("bf491bb2-78d0-4564-adb6-a303e5b7a043"),
                                    QuestionId = new Guid("bba57065-d5a4-438f-8bb5-a358044cb318"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("8b7a3b92-4aff-4a04-afa5-66fac4629371"),
                            Index = "8",
                            Name = "FamilyIsAppropriatelyEngagedInOrSupportiveOfTreatmentProcess_Q8",
                            Text = "FAMILY IS APPROPRIATELY ENGAGED IN OR SUPPORTIVE OF TREATMENT PROCESS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("a5f50303-a6a3-4c31-9a91-0839778cb4d2"),
                                    QuestionId = new Guid("8b7a3b92-4aff-4a04-afa5-66fac4629371"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6dc1fe74-aba5-4bb4-b37e-ac0a1aa1116a"),
                                    QuestionId = new Guid("8b7a3b92-4aff-4a04-afa5-66fac4629371"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("97ba13eb-f94e-488f-91ce-133d71638085"),
                                    QuestionId = new Guid("8b7a3b92-4aff-4a04-afa5-66fac4629371"),
                                    Value = "8",
                                    Text = "No family contact",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c9d38025-ff79-42f3-893d-1e7453c2e484"),
                            Index = "9",
                            Name = "TransitionPlanningNeeded_Q9",
                            Text = "TRANSITION PLANNING NEEDED",
                            SubText = "From one setting to another (e.g., educational, vocational, service sector)",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("830bc1ed-8c1b-468b-8790-f7132ef6cebc"),
                                    QuestionId = new Guid("c9d38025-ff79-42f3-893d-1e7453c2e484"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b1aba2b5-3513-4fee-839e-bcfb61262dbc"),
                                    QuestionId = new Guid("c9d38025-ff79-42f3-893d-1e7453c2e484"),
                                    Value = "1",
                                    Text = "Yes",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("cd9c39a4-b149-4ed9-a96b-0420e8cdf481"),
                    Index = "R",
                    Description = "Nutritional Status",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                            Index = "1",
                            Name = "ModeOfNutritionalIntake_R1",
                            Text = "MODE OF NUTRITIONAL INTAKE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("66c4ab68-72f6-46cc-b99e-6d91c6140722"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "0",
                                    Text = "Normal — Swallows all types of foods safely and efficiently",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7810cc75-5e2e-4808-b9ad-dc7c91761658"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "1",
                                    Text = "Modified independent — e.g., liquid is sipped, takes limited solid food, need for modification may be unknown",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a4ad69c5-0cde-43d7-a8cd-81012eec3ecb"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "2",
                                    Text = "Requires diet modification to swallow solid food — e.g., mechanical diet (e.g., puréed, minced) or only able to ingest specific foods",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("66402d66-9a8c-46f9-86e3-93d5e8e2980c"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "3",
                                    Text = "Requires modification to swallow liquids — e.g., thickener",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ba4e41af-5998-486d-a4c6-3bd4ac4172a5"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "4",
                                    Text = "Can swallow only puréed solids AND thickened liquids — Requires BOTH puréed solids and thickened liquids for oral intake",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0d4004f1-d782-4de2-abc8-82af3798cba4"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "5",
                                    Text = "Combined oral and parenteral or tube feeding — Tube feeding via NGT, GT, JT AND some oral intake, OR parenteral feeding AND some oral intake",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("e6cc87dd-29e8-4e32-ab27-83058c1aa832"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "6",
                                    Text = "Nasogastric tube feeding only — Nutritional intake occurs via a tube placed in the person’s stomach via the nasopharynx",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("c37c1de5-5cc4-4225-9a6f-95b019be5a61"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "7",
                                    Text = "Abdominal tube feeding — Nutritional intake occurs only through abdominal tube (e.g., PEG tube); no oral intake",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("68f21aa4-50b4-4622-a860-bc7b7d7ab123"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "8",
                                    Text = "Parenteral feeding only — Includes all types of parenteral feedings, such as total parenteral nutrition (TPN); no oral intake",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("4ac225f3-6fc8-4fb0-b023-bd77f35a29d2"),
                                    QuestionId = new Guid("5ca1c356-2b17-4852-8051-eb693f066445"),
                                    Value = "9",
                                    Text = "Activity did not occur — Did not eat or receive any form of nutritional supplementation during entire period",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("dfbaebbf-1d0e-40b7-93a0-3669a53bd901"),
                            Index = "2",
                            Name = "FamilyCaregiverFriendOrStaffExpressesConcernAboutChildSYouthSWeight_R2",
                            Text = "FAMILY, CAREGIVER, FRIEND, OR STAFF EXPRESSES CONCERN ABOUT CHILD’S / YOUTH’S WEIGHT",
                            SubText = "Code for nutritional status in LAST 90 DAYS",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("f838be47-c438-4ac8-a4e9-5aac5d330539"),
                                    Index = "a",
                                    Name = "WeightGain_R2a",
                                    Text = "Weight gain",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("e87e14e8-faa2-4c76-9373-3cf1625e55d0"),
                                    Index = "b",
                                    Name = "WeightLoss_R2b",
                                    Text = "Weight loss",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("8e605802-9ce8-4e81-a730-9482d34fac97"),
                                    Index = "c",
                                    Name = "FailureToGainWeight_R2c",
                                    Text = "Failure to gain weight",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("281efa3d-cfc7-40d5-ae52-e29b3b58ad83"),
                    Index = "S",
                    Description = "Education",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("8c2a2f80-e56a-4333-a09f-96964536681e"),
                            Index = "1",
                            Name = "EnrolledInFormalEducationProgram_S1",
                            Text = "ENROLLED IN FORMAL EDUCATION PROGRAM",
                            SubText = "If “0”, skip to Section T. If ”1”, skip to Item S6.",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("7039d324-d90c-4de0-8f6f-a5d063870dc9"),
                                    QuestionId = new Guid("8c2a2f80-e56a-4333-a09f-96964536681e"),
                                    Value = "0",
                                    Text = "Never enrolled",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3b6c5620-0b36-4fc5-a290-ea2ef0b5c183"),
                                    QuestionId = new Guid("8c2a2f80-e56a-4333-a09f-96964536681e"),
                                    Value = "1",
                                    Text = "No, but previously enrolled",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6e2445dc-0c35-4403-b6d3-add3ec728f4a"),
                                    QuestionId = new Guid("8c2a2f80-e56a-4333-a09f-96964536681e"),
                                    Value = "2",
                                    Text = "Yes, part-time",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("295e76da-ac44-463d-b3fd-debabf815efa"),
                                    QuestionId = new Guid("8c2a2f80-e56a-4333-a09f-96964536681e"),
                                    Value = "3",
                                    Text = "Yes, full-time",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                            Index = "2",
                            Name = "EducationStatus_S2",
                            Text = "EDUCATION STATUS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("990144f5-57a1-4bd0-84a5-5ab3fca29b63"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "1",
                                    Text = "Preschool",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3b99766a-3f7d-41a4-9b18-302418c4dc00"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "2",
                                    Text = "Home-schooled",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6db02caf-0786-4faf-be6e-57944b50031c"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "3",
                                    Text = "Regular class (no extra support)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("4b25b543-5951-4278-89f3-5a548fafe5c2"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "4",
                                    Text = "Regular with special accommodations",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8a52363c-ac84-46e6-b76b-9bfeb95098de"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "5",
                                    Text = "Regular with extra support (e.g., 1:1 staff)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("05457463-94ff-4516-bac0-40e49062fedc"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "6",
                                    Text = "Special education class(es)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9a50ade6-d111-41a1-8106-b4ef6ede7b86"),
                                    QuestionId = new Guid("bdae5099-eaf3-44ae-9d19-512d753b00fc"),
                                    Value = "7",
                                    Text = "Special school / program (e.g., vocational training)",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("4d80ceca-b927-48e1-8d3c-bf4823e44c22"),
                            Index = "3",
                            Name = "AttendanceInSchool_S3",
                            Text = "ATTENDANCE IN SCHOOL",
                            SubText = "Number of days absent from school in LAST 90 DAYS",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("b72d8c34-8806-4fd6-9f3e-f7525bcdbb1f"),
                            Index = "4",
                            Name = "RiskOfDisruptedEducationInLast90Days_S4",
                            Text = "RISK OF DISRUPTED EDUCATION IN LAST 90 DAYS",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("1f711938-f56c-45d8-be8c-32c05ed6e518"),
                                    Index = "a",
                                    Name = "IncreaseInLatenessOrAbsenteeism_S4a",
                                    Text = "Increase in lateness or absenteeism",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("d3dd5853-d69c-4abb-9961-6f331d192169"),
                                    Index = "b",
                                    Name = "PoorProductivityOrDisruptivenessAtSchool_S4b",
                                    Text = "Poor productivity or disruptiveness at school",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b78109ed-1174-4908-90fb-7e22610d3977"),
                                    Index = "c",
                                    Name = "ExpressesIntentToQuitSchool_S4c",
                                    Text = "Expresses intent to quit school",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("55f2f802-c1dd-4b94-968f-807150e102d8"),
                                    Index = "d",
                                    Name = "ConflictWithSchoolStaffEGPersistentArguingWithTeachersThreateningPrincipal_S4d",
                                    Text = "Conflict with school staff — e.g., persistent arguing with teachers; threatening principal",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("7537c2bf-0b16-42f4-8d43-4d7a3ddc0b3d"),
                            Index = "5",
                            Name = "StrongPersistentDissatisfactionWithSchool_S5",
                            Text = "STRONG, PERSISTENT DISSATISFACTION WITH SCHOOL",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("c10ffece-a255-4f7d-8f4c-f24e18333f68"),
                                    QuestionId = new Guid("7537c2bf-0b16-42f4-8d43-4d7a3ddc0b3d"),
                                    Value = "0",
                                    Text = "No",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7ed1a2db-0cc0-4907-9fe2-df09d6f35f3e"),
                                    QuestionId = new Guid("7537c2bf-0b16-42f4-8d43-4d7a3ddc0b3d"),
                                    Value = "1",
                                    Text = "Child / youth only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("8a0d4fd1-7dd3-4dd6-9266-6f7bb29a8bc9"),
                                    QuestionId = new Guid("7537c2bf-0b16-42f4-8d43-4d7a3ddc0b3d"),
                                    Value = "2",
                                    Text = "Parent / primary caregiver only",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b66a10f7-0e5d-451a-a9ca-e8fe0cd39937"),
                                    QuestionId = new Guid("7537c2bf-0b16-42f4-8d43-4d7a3ddc0b3d"),
                                    Value = "3",
                                    Text = "Both",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("eaf86913-bd4b-4917-b02f-98e316ff2d0f"),
                            Index = "6",
                            Name = "CurrentDisruptedEducation_S6",
                            Text = "CURRENT DISRUPTED EDUCATION",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("a587d8c8-e3a5-4061-990f-c33a3d0498ec"),
                                    Index = "a",
                                    Name = "ChildYouthCurrentlyRefusesToAttendSchool_S6a",
                                    Text = "Child / youth currently refuses to attend school",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("125881bd-8bae-49f7-af63-66d20f100942"),
                                    Index = "b",
                                    Name = "ChildYouthCurrentlyRemovedDueToDisruptiveBehaviour_S6b",
                                    Text = "Child / youth currently removed due to disruptive behaviour",
                                    SubText = "e.g., currently suspended or expelled",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("a7d891eb-e27c-42c7-9cb7-fad3af26d80d"),
                            Index = "7",
                            Name = "LastSchoolGradeCompletedSuccessfully_S7",
                            Text = "LAST SCHOOL GRADE COMPLETED SUCCESSFULLY",
                            SubText = "Code “00” if no formal grade level completed",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("afa9942a-e35a-48ba-a3ab-00e18532527b"),
                            Index = "8",
                            Name = "OverallAcademicAbilityPerformance_S8",
                            Text = "OVERALL ACADEMIC ABILITY - Performance",
                            SubText = "Code for academic PERFORMANCE [P] compared with typical child / youth of same age.",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("5ccfbcb4-1a79-4f36-a287-023c49033f22"),
                                    QuestionId = new Guid("afa9942a-e35a-48ba-a3ab-00e18532527b"),
                                    Value = "0",
                                    Text = "Exceptionally higher ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("84933afb-c37a-4392-9638-a060db942b8c"),
                                    QuestionId = new Guid("afa9942a-e35a-48ba-a3ab-00e18532527b"),
                                    Value = "1",
                                    Text = "Typical ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("a0e8df31-cdd1-42ed-b047-97e87015fbdc"),
                                    QuestionId = new Guid("afa9942a-e35a-48ba-a3ab-00e18532527b"),
                                    Value = "2",
                                    Text = "Exceptionally lower ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("19b71107-8ec5-4a37-97c1-8dc4f90c52e1"),
                                    QuestionId = new Guid("afa9942a-e35a-48ba-a3ab-00e18532527b"),
                                    Value = "3",
                                    Text = "Minimal or no evidence of ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("245df856-c847-4f3c-a762-22d36ae6dcba"),
                                    QuestionId = new Guid("afa9942a-e35a-48ba-a3ab-00e18532527b"),
                                    Value = "8",
                                    Text = "Not applicable (DO NOT USE THIS CODE IN SCORING CAPACITY)",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c758819f-7dfa-445f-9893-fd82c52cde56"),
                            Index = "9",
                            Name = "OverallAcademicAbilityCapacity_S9",
                            Text = "OVERALL ACADEMIC ABILITY - Capacity",
                            SubText = "Code for academic CAPACITY [C] based on presumed academic potential. This will require “speculation” by the assessor.",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("dbd26355-ca8e-4d61-b103-61569edcc8d0"),
                                    QuestionId = new Guid("c758819f-7dfa-445f-9893-fd82c52cde56"),
                                    Value = "0",
                                    Text = "Exceptionally higher ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("56af0439-4fc7-40a2-922f-d9848d849918"),
                                    QuestionId = new Guid("c758819f-7dfa-445f-9893-fd82c52cde56"),
                                    Value = "1",
                                    Text = "Typical ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9a2cc45a-6add-496a-8e7d-9313e51aeeba"),
                                    QuestionId = new Guid("c758819f-7dfa-445f-9893-fd82c52cde56"),
                                    Value = "2",
                                    Text = "Exceptionally lower ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0ec89d77-4f35-46d4-8859-5b8996ab71f4"),
                                    QuestionId = new Guid("c758819f-7dfa-445f-9893-fd82c52cde56"),
                                    Value = "3",
                                    Text = "Minimal or no evidence of ability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("2ec12d04-90cc-4cc0-bd03-f5d94026bafc"),
                                    QuestionId = new Guid("c758819f-7dfa-445f-9893-fd82c52cde56"),
                                    Value = "8",
                                    Text = "Not applicable (DO NOT USE THIS CODE IN SCORING CAPACITY)",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("739164f6-491d-427c-84c7-12a96a0d26f4"),
                    Index = "T",
                    Description = "Environmental Assessment",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("fc7b2a5c-d56a-4aa8-b02e-b2e138d3f73f"),
                            Index = "1",
                            Name = "HomeEnvironment_T1",
                            Text = "HOME ENVIRONMENT",
                            SubText = "Code for any of the following that make home environment hazardous or uninhabitable (if temporarily in institution, base assessment on home visit)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("161ea354-4ec3-47e3-a863-e9a9b6030e95"),
                                    Index = "a",
                                    Name = "DisrepairOfTheHomeEGHazardousClutterInadequateOrNoLightingHolesInFloorLeakingPipes_T1a",
                                    Text = "Disrepair of the home — e.g., hazardous clutter, inadequate or no lighting, holes in floor, leaking pipes",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("eb17c187-8452-49a5-9ff2-a09028cb2bbd"),
                                    Index = "b",
                                    Name = "SqualidConditionEGExtremelyDirtyInfestationByBugs_T1b",
                                    Text = "Squalid condition — e.g., extremely dirty, infestation by bugs",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b239ad42-e1dc-4f77-9a62-de6de6f637b9"),
                                    Index = "c",
                                    Name = "InadequateHeatingOrCoolingEGTooHotInSummerTooColdInWinter_T1c",
                                    Text = "Inadequate heating or cooling — e.g., too hot in summer, too cold in winter",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("92e3603a-fd79-4f39-87f2-e76bef1947ca"),
                                    Index = "d",
                                    Name = "LackOfPersonalSafetyEGFearOfViolenceSafetyProblemInGoingToMailboxOrVisitingNeighbours_T1d",
                                    Text = "Lack of personal safety — e.g., fear of violence; safety problem in going to mailbox or visiting neighbours",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("529a43b5-98d3-4755-b72f-808dc868fee8"),
                                    Index = "e",
                                    Name = "LimitedAccessToHomeOrRoomsInHomeEGDifficultyEnteringOrLeavingHomeUnableToClimbStairs_T1e",
                                    Text = "Limited access to home or rooms in home — e.g., difficulty entering or leaving home; unable to climb stairs",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("da97724f-669c-49d8-a960-04448d72ed8f"),
                    Index = "U",
                    Description = "Diagnostic and Other Health Information",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("421dc7a7-5aa4-4331-aca1-1683ea13f990"),
                            Index = "1",
                            Name = "GlobalAssessmentOfFunctioning_U1",
                            Text = "GLOBAL ASSESSMENT OF FUNCTIONING",
                            SubText = "Record current GAF/CGAS score. Record “888” if unknown.",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("c0896525-ea9a-44c7-800a-256a6afd7280"),
                            Index = "2",
                            Name = "DsmIvProvisionalDiagnosticCategory_U2",
                            Text = "DSM-IV PROVISIONAL DIAGNOSTIC CATEGORY",
                            SubText = "Identify all provisional categories of DSM-IV diagnoses determined by the psychiatrist or attending physician and rank their importance as factors contributing to this admission (if no provisional diagnosis available, code all boxes “8”)",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("0f5fd9ba-5c46-4aff-8b9d-a8cb178322cf"),
                                    Index = "a",
                                    Name = "ReactiveAttachmentDisorder_U2a",
                                    Text = "Reactive attachment disorder",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c7ee13fd-818c-4a3e-bf3d-bbedc5d4a473"),
                                    Index = "b",
                                    Name = "AttentionDeficitHyperactivityDisorder_U2b",
                                    Text = "Attention deficit hyperactivity disorder",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("7e4def19-8921-4d19-ac93-29b5d207c431"),
                                    Index = "c",
                                    Name = "DisruptiveBehaviourDisorder_U2c",
                                    Text = "Disruptive behaviour disorder",
                                    SubText = "e.g., oppositional defiant disorder, conduct disorder",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("3a2c2e82-76ed-4656-aee9-4354472425a3"),
                                    Index = "d",
                                    Name = "LearningOrCommunicationDisorder_U2d",
                                    Text = "Learning or communication disorder",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("92dc14d3-aeb2-4169-b763-b98e46380fde"),
                                    Index = "e",
                                    Name = "AutismSpectrumDisorder_U2e",
                                    Text = "Autism spectrum disorder",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("38a5613c-f57d-4f0e-8278-72f7348f0440"),
                                    Index = "f",
                                    Name = "SubstanceRelatedDisorders_U2f",
                                    Text = "Substance-related disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("bf496ea6-fdda-47be-b76e-7d7de67b58d8"),
                                    Index = "g",
                                    Name = "SchizophreniaAndOtherPsychoticDisorders_U2g",
                                    Text = "Schizophrenia and other psychotic disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("caae3135-d63d-4312-944a-ffd3e38996eb"),
                                    Index = "h",
                                    Name = "MoodDisorders_U2h",
                                    Text = "Mood disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("c2d55eb7-4406-459d-af14-112966fc6273"),
                                    Index = "i",
                                    Name = "AnxietyDisorders_U2i",
                                    Text = "Anxiety disorders",
                                    SubText = "e.g., separation anxiety disorder, obsessive compulsive disorder",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b15b1ea3-1300-4967-910f-9b0ee2f0efc3"),
                                    Index = "j",
                                    Name = "EatingDisorders_U2j",
                                    Text = "Eating disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b7e18ce2-bcbb-410c-afbe-adf8950d3b73"),
                                    Index = "k",
                                    Name = "SleepDisorders_U2k",
                                    Text = "Sleep disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("02579f29-5f23-4218-9069-66d3b236909c"),
                                    Index = "l",
                                    Name = "AdjustmentDisorders_U2l",
                                    Text = "Adjustment disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("81905207-6c15-4dc9-8d8d-131c12377857"),
                            Index = "3",
                            Name = "PsychiatricDiagnoses_U3",
                            Text = "PSYCHIATRIC DIAGNOSES",
                            SubText = "Enter Axis I and Axis II DSM-IV diagnoses, if known. Must be completed on discharge, but also complete with earlier assessments if specific psychiatric diagnosis already determined.",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("7c51bb18-868b-4800-a7ab-5f9a968e6759"),
                                    Index = "a",
                                    Name = "AxisIDsmIvCode1_U3a",
                                    Text = "AXIS I - DSM-IV Code 1",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("69969e1a-ab39-448d-8be8-eeb892b15770"),
                                    Index = "b",
                                    Name = "AxisIDsmIvCode2_U3b",
                                    Text = "AXIS I - DSM-IV Code 2",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("2b2f69c1-1796-4e37-a8d3-2f0fdc2b941b"),
                                    Index = "c",
                                    Name = "AxisIDsmIvCode3_U3c",
                                    Text = "AXIS I - DSM-IV Code 3",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("edaf7dc8-cc13-497e-859d-c4679aefa946"),
                                    Index = "d",
                                    Name = "AxisIiDsmIvCode1_U3d",
                                    Text = "AXIS II - DSM-IV Code 1",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("28f454c0-8c9f-4a30-960e-983ef9fcef12"),
                            Index = "4",
                            Name = "MedicalDiagnoses_U4",
                            Text = "MEDICAL DIAGNOSES",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("06f0f0ce-7505-45e4-9cf5-a25af2c012f0"),
                                    Index = "a",
                                    Name = "Asthma_U4a",
                                    Text = "Asthma",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f7e95f3a-4e52-48da-89dc-9df46254bf1b"),
                                    Index = "b",
                                    Name = "DiabetesMellitus_U4b",
                                    Text = "Diabetes mellitus",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("18c363e4-996f-4f8a-9776-5d89cf121d33"),
                                    Index = "c",
                                    Name = "EpilepsyOrSeizureDisorders_U4c",
                                    Text = "Epilepsy or seizure disorders",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b139e17e-88c4-46f8-bdef-6e5998d941ed"),
                                    Index = "d",
                                    Name = "FetalAlcoholEffectsSyndrome_U4d",
                                    Text = "Fetal alcohol effects / syndrome",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("5f16327c-ebfc-43a6-8e94-6111c47960d3"),
                                    Index = "e",
                                    Name = "Migraine_U4e",
                                    Text = "Migraine",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b5422960-03ba-4795-beb6-063a4e927aeb"),
                                    Index = "f",
                                    Name = "TraumaticBrainInjury_U4f",
                                    Text = "Traumatic brain injury",
                                    SubText = "",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("0b8529aa-00e3-41da-bfde-ba3b5d0726c1"),
                                    Index = "g",
                                    Name = "SevereAnaphylacticAllergy_U4g",
                                    Text = "Severe (anaphylactic) allergy",
                                    SubText = "EXCLUDE MEDICATION ALLERGIES",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("15bd2a27-4540-46aa-b07d-915c24b57aee"),
                                    Index = "h",
                                    Name = "OtherMedicalDiagnosis1_U4h",
                                    Text = "Other Medical Diagnosis 1",
                                    SubText = "e.g. Medication - Disease Code - ICD-10 Code",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("fd51491e-0b9f-4038-be5d-8b3b71033aca"),
                                    Index = "i",
                                    Name = "OtherMedicalDiagnosis2_U4i",
                                    Text = "Other Medical Diagnosis 2",
                                    SubText = "e.g. Medication - Disease Code - ICD-10 Code",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("b050fe5e-974a-49a6-bcd7-2f4ff65a7f39"),
                                    Index = "j",
                                    Name = "OtherMedicalDiagnosis3_U4j",
                                    Text = "Other Medical Diagnosis 3",
                                    SubText = "e.g. Medication - Disease Code - ICD-10 Code",
                                    DefaultValue = null,
                                    QuestionType = "TEXT",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("294443f5-6b21-4fbe-9802-406b2db34ce7"),
                            Index = "5",
                            Name = "HistoryOfConcussionS_U5",
                            Text = "HISTORY OF CONCUSSION(S)",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("56e65e9a-9cb4-474e-a07e-884a883f6c1d"),
                                    QuestionId = new Guid("294443f5-6b21-4fbe-9802-406b2db34ce7"),
                                    Value = "0",
                                    Text = "None",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ec61081a-dd5f-4c96-9884-47c9e73b8483"),
                                    QuestionId = new Guid("294443f5-6b21-4fbe-9802-406b2db34ce7"),
                                    Value = "1",
                                    Text = "One",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("1117973e-2f18-4c3f-9c06-b55f18b706f7"),
                                    QuestionId = new Guid("294443f5-6b21-4fbe-9802-406b2db34ce7"),
                                    Value = "2",
                                    Text = "Two",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f89abf5e-e5aa-45ac-9ed4-0eecc0cc4c3b"),
                                    QuestionId = new Guid("294443f5-6b21-4fbe-9802-406b2db34ce7"),
                                    Value = "3",
                                    Text = "Three or more",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("51731128-7f55-4f08-a762-3477147c8fa3"),
                            Index = "6",
                            Name = "TimeNeededToRecoverFromAnyConcussion_U6",
                            Text = "TIME NEEDED TO RECOVER FROM ANY CONCUSSION",
                            SubText = "Code for the greatest amount of time needed to recover from any current or previous concussion",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("57db1bbf-13b9-42f4-80d6-709d3a34a60f"),
                                    QuestionId = new Guid("51731128-7f55-4f08-a762-3477147c8fa3"),
                                    Value = "0",
                                    Text = "Immediate recovery — Symptoms alleviated within 1 week",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d115326c-d845-459e-ba72-4d89f11a0c64"),
                                    QuestionId = new Guid("51731128-7f55-4f08-a762-3477147c8fa3"),
                                    Value = "1",
                                    Text = "Longer recovery — Symptoms persisted longer than 1 week but less than 3 months",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3788dfbe-aa56-42dc-b8ee-880f51fbe798"),
                                    QuestionId = new Guid("51731128-7f55-4f08-a762-3477147c8fa3"),
                                    Value = "2",
                                    Text = "Post-concussion syndrome — Symptoms persisted or are persisting longer than 3 months",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ef1846ab-9ef5-46ad-9085-d943658d2fe5"),
                                    QuestionId = new Guid("51731128-7f55-4f08-a762-3477147c8fa3"),
                                    Value = "8",
                                    Text = "Unknown or no previous concussions",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("a927cf6b-5658-4c09-8085-eaa4f940e5a3"),
                    Index = "V",
                    Description = "Service Termination",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("2937604d-75ad-4c14-a500-7c949f6b0cfc"),
                            Index = "1",
                            Name = "HowLongChildYouthIsExpectedToReceiveServicesFromThisAgency_V1",
                            Text = "HOW LONG CHILD / YOUTH IS EXPECTED TO RECEIVE SERVICES FROM THIS AGENCY",
                            SubText = "Count from assessment reference date, including that day",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("ef0224e7-ba4a-422a-a2aa-0a4142bc1831"),
                                    QuestionId = new Guid("2937604d-75ad-4c14-a500-7c949f6b0cfc"),
                                    Value = "0",
                                    Text = "1–7 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("3caf10df-007e-41bd-b300-1f82e943fb11"),
                                    QuestionId = new Guid("2937604d-75ad-4c14-a500-7c949f6b0cfc"),
                                    Value = "1",
                                    Text = "8–14 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("41666fa7-3b5e-49e1-87a8-d2d7cbf6b6fe"),
                                    QuestionId = new Guid("2937604d-75ad-4c14-a500-7c949f6b0cfc"),
                                    Value = "2",
                                    Text = "15–30 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("eeccd8d2-d9a6-419e-850c-6e4e89954237"),
                                    QuestionId = new Guid("2937604d-75ad-4c14-a500-7c949f6b0cfc"),
                                    Value = "3",
                                    Text = "31–90 days",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("abc6d72e-95e8-4d12-b981-816c39229237"),
                                    QuestionId = new Guid("2937604d-75ad-4c14-a500-7c949f6b0cfc"),
                                    Value = "4",
                                    Text = "91 or more days",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("d561ff7a-5e8c-41b2-8cde-9f6d611989cd"),
                            Index = "2",
                            Name = "ResourcesKnownToBeAvailableUponDischarge_V2",
                            Text = "RESOURCES KNOWN TO BE AVAILABLE UPON DISCHARGE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "QUESTION_BREAKDOWN",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Id = new Guid("55abd22c-21e3-440e-ba4a-ebb2aef2419b"),
                                    Index = "a",
                                    Name = "FormalMentalHealthTreatment_V2a",
                                    Text = "Formal mental health treatment",
                                    SubText = "e.g., psychiatrist, social worker",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("80fe0e7a-cfd2-4efc-9357-4301757c814e"),
                                    Index = "b",
                                    Name = "FormalCaseCoordinationServices_V2b",
                                    Text = "Formal case coordination services",
                                    SubText = "EXCLUDE SCHOOL",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                                new QuestionModel
                                {
                                    Id = new Guid("f2867666-dae9-4465-b368-c18d6f5d2c5c"),
                                    Index = "c",
                                    Name = "SchoolResources_V2c",
                                    Text = "School resources",
                                    SubText = "e.g., behaviour support plan",
                                    DefaultValue = null,
                                    QuestionType = "DROPDOWN_LIST",
                                    Choices = new List<ResponseModel>
                                    {
                                    },
                                },
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("9749a363-b9f1-4f7b-8514-7aaffc86882d"),
                    Index = "W",
                    Description = "Discharge ^^^ [Note: Complete Section W at discharge only]",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("54b16020-5d2c-4143-88c5-d585b454e82b"),
                            Index = "1",
                            Name = "LastDayOfInvolvementWithProgramOrAgency_W1",
                            Text = "LAST DAY OF INVOLVEMENT WITH PROGRAM OR AGENCY",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DATE",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                            Index = "2",
                            Name = "DischargedTo_W2",
                            Text = "DISCHARGED TO",
                            SubText = "Code for expected initial arrangement at discharge",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("1919b432-f31c-404c-9026-ffcfbdd086a9"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "1",
                                    Text = "Private home / apartment / rented room",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ae8cde3f-01d4-457d-8e40-4aaaab1ede87"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "2",
                                    Text = "Board and care",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("6df30487-4300-44d8-bc3a-8897d47ff634"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "3",
                                    Text = "Assisted living or semi-independent living",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("95d92155-a11c-48b3-bb58-8984c92fa475"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "4",
                                    Text = "Mental health residence — e.g., psychiatric group home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("06d04600-5f4b-4f93-9572-f6a142b833eb"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "5",
                                    Text = "Group home for persons with physical disability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("d3263380-2b7b-4fcf-90ef-f4e14dd6337f"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "6",
                                    Text = "Setting for persons with intellectual disability",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("09140bc8-5a1a-4ac1-b309-8a97fd8b8492"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "7",
                                    Text = "Psychiatric hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("0c1d0e9c-032e-4eaf-a13a-4ff1fe10bdc9"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "8",
                                    Text = "Homeless (with or without shelter)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("9f42b0e4-2e3d-4700-8578-501017496349"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "9",
                                    Text = "Residential care facility — e.g., long-term care home, nursing home",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b34ccee3-721e-473f-9e43-9343c1bcfe36"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "10",
                                    Text = "Rehabilitation hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("cdbb9c21-14a7-40bf-b4a1-b2f6465b291d"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "11",
                                    Text = "Hospice facility / palliative care unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("7fc9a52e-3878-433c-bd60-4ac71e5e3aa9"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "12",
                                    Text = "Acute care hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("b1e2a5c2-d081-46f6-93e4-892ddfb8ed41"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "13",
                                    Text = "Continuing care hospital / unit",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ae6c313d-9f49-43ce-a6f9-2af3568774a8"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "14",
                                    Text = "Residential treatment facility",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("02fde02a-369c-49bf-8062-0970df0a8d8d"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "15",
                                    Text = "Other",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("f0b3c400-8e98-4c99-ab03-580a61ca881b"),
                                    QuestionId = new Guid("72bbb0ae-0f8f-4f05-a144-cdf3fd52dbe5"),
                                    Value = "16",
                                    Text = "Deceased",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                            Index = "3",
                            Name = "LivingArrangementAtDischarge_W3",
                            Text = "LIVING ARRANGEMENT AT DISCHARGE",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DROPDOWN_LIST",
                            Choices = new List<ResponseModel>
                            {
                                new ResponseModel
                                {
                                    Id = new Guid("1870b69e-5b7d-41d3-9068-4abb43003fe0"),
                                    QuestionId = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                                    Value = "1",
                                    Text = "Alone",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("ac290623-de76-4b1a-8dd7-afb0b097e613"),
                                    QuestionId = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                                    Value = "2",
                                    Text = "With parent(s) or primary caregiver(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("1230d588-7072-4427-8034-0fbe1c3e2702"),
                                    QuestionId = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                                    Value = "3",
                                    Text = "With sibling(s), no parent(s ) / primary caregiver(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("94011d3f-c772-46b4-a724-1f3e30c75617"),
                                    QuestionId = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                                    Value = "4",
                                    Text = "With other relative(s)",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("cbdadd52-8641-4810-bd10-edbf1916aa3f"),
                                    QuestionId = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                                    Value = "5",
                                    Text = "With foster family",
                                },
                                new ResponseModel
                                {
                                    Id = new Guid("45032011-1a4f-42a5-821f-e790ae07f28d"),
                                    QuestionId = new Guid("af8ce418-50e2-472b-bdb1-2a4352412cfe"),
                                    Value = "6",
                                    Text = "With nonrelative(s), excluding foster family",
                                },
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
                new SectionModel
                {
                    Id = new Guid("a2fb56d3-7f3b-4c3a-b053-fc2d9f7771d5"),
                    Index = "X",
                    Description = "Assessment Information ^^^ SIGNATURE OF PERSON COORDINATING / COMPLETING THE ASSESSMENT",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Id = new Guid("53620ccf-f118-44d1-8803-26209efa3f73"),
                            Index = "1",
                            Name = "Signature_X1",
                            Text = "Signature",
                            SubText = "(sign on above line)",
                            DefaultValue = null,
                            QuestionType = "TEXT",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                        new QuestionModel
                        {
                            Id = new Guid("a327b82f-3592-400f-ad2c-843c684550a6"),
                            Index = "2",
                            Name = "DateAssessmentSignedAsComplete_X2",
                            Text = "Date assessment signed as complete",
                            SubText = "",
                            DefaultValue = null,
                            QuestionType = "DATE",
                            Choices = new List<ResponseModel>
                            {
                            },
                            SubQuestions = new List<QuestionModel>
                            {
                            },
                        },
                    }
                },
            },
        },
    };
    }
}
