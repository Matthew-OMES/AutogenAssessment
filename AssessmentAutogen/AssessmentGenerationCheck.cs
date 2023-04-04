using System.Collections.Generic;
using AssessmentAutogen.Model;

public static class AssessmentGeneration
{
    public static List<AssessmentModel> Assessments = new List<AssessmentModel>
    {
        new AssessmentModel
        {
            Id = new Guid("3f94a039-2059-4526-8c4e-f15c44ade046"),
            Name = "ChildMentalHealthAndDisability",
            Text = "Child and Youth Mental Health and Developmental Disability Community-Based Assessment",
            Sections = new List<SectionModel>
            {
                new SectionModel
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000000"),
                    Index = "A",
                    Description = " Identification Information ",
                    Questions = new List<QuestionModel>
                    {
                new QuestionModel
                {
                    Id = new Guid("8191d0c7-97bf-4e2d-bbd1-568f4b529822"),
                    Index = "1",
                    Name = "Name_A1",
                    Text = " NAME",
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
                    Id = new Guid("56344c62-6786-43dd-8f6c-0870002850d5"),
                    Index = "a",
                    Name = "FirstName_A1a",
                    Text = " First Name                       ",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "TEXT",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("2230b3c9-467d-4812-ae56-1f9d40934776"),
                    Index = "b",
                    Name = "MiddleInitial_A1b",
                    Text = " Middle initial",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "TEXT",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("798e6305-ca74-4753-be20-f1ca65b06ab4"),
                    Index = "c",
                    Name = "LastName_A1c",
                    Text = " Last Name                                  ",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "TEXT",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("c1302166-b6d0-4367-bd82-d4812dd1f6f1"),
                    Index = "d",
                    Name = "Suffix_A1d",
                    Text = " Suffix",
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
                    Id = new Guid("40308181-22c0-4831-a5f8-3863061335d6"),
                    Index = "2",
                    Name = "Sex_A2",
                    Text = " SEX",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                        new ResponseModel
                        {
                        Id = new Guid("e7e65e5e-2187-4f5c-b48c-52ad31fb9d60"),
                        QuestionId = new Guid("40308181-22c0-4831-a5f8-3863061335d6"),
                        Value = "1",
                        Text = "Male",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("2524a4ba-207c-4988-95c8-2bec2a589c66"),
                        QuestionId = new Guid("40308181-22c0-4831-a5f8-3863061335d6"),
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
                    Id = new Guid("a8895fab-6d63-43cb-ba33-6fe1212929ac"),
                    Index = "3",
                    Name = "Birthdate_A3",
                    Text = " BIRTHDATE ",
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
                    Id = new Guid("4605985c-8af4-4057-a0ea-64c737ecc91f"),
                    Index = "4",
                    Name = "NumericIdentifiers_A4",
                    Text = " NUMERIC IDENTIFIERS",
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
                    Id = new Guid("a40d1a34-353e-4eff-aee3-f5cd9dc012e0"),
                    Index = "a",
                    Name = "HealthCareIdentificationNumber_A4a",
                    Text = " Health Care Identification Number",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "TEXT",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("a194820e-bd67-4f4f-a258-64283b762c82"),
                    Index = "b",
                    Name = "ProvinceOrTerritoryIssuingHealthCareIdentificationNumber_A4b",
                    Text = " Province or Territory Issuing Health Care Identification Number",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "TEXT",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("3bd7b0da-845d-48c6-a641-c393ce9c3be0"),
                    Index = "c",
                    Name = "CaseRecordNumber_A4c",
                    Text = " Case Record Number     ",
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
                    Id = new Guid("f49bd6ab-33bd-4a3b-a031-9accd656ed0f"),
                    Index = "5",
                    Name = "AgencyIdentifier_A5",
                    Text = " AGENCY IDENTIFIER ",
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
                    Id = new Guid("10795a46-7a0f-45c7-a4b7-3f646d6d8435"),
                    Index = "6",
                    Name = "CurrentPaymentSources_A6",
                    Text = " CURRENT PAYMENT SOURCES",
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
                    Id = new Guid("32f883ab-4dc4-4acf-ace4-3317ab09985c"),
                    Index = "a",
                    Name = "ProvincialOrTerritorialGovernmentPlan_A6a",
                    Text = " Provincial or territorial government plan ",
                    SubText = " this province or territory	",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("269d2685-dc4e-4ffe-bb10-7108010959ff"),
                    Index = "b",
                    Name = "ProvincialOrTerritorialGovernmentPlan_A6b",
                    Text = " Provincial or territorial government plan ",
                    SubText = " other province or territory",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("8796a5aa-b6e3-4ee2-b9e2-b59228eef26f"),
                    Index = "c",
                    Name = "FederalGovernment_A6c",
                    Text = " Federal government ",
                    SubText = " First Nations and Inuit Health Branch (FNIHB)",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("4131afb4-b98b-49b7-85a2-cc4c24cbb18b"),
                    Index = "d",
                    Name = "CanadianResidentInsurancePay_A6d",
                    Text = " Canadian resident, insurance pay",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("30b3eb3d-8ff0-4e6e-adf6-28ed1bc80f1c"),
                    Index = "e",
                    Name = "CanadianResidentPublicTrusteePay_A6e",
                    Text = " Canadian resident, public trustee pay",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("5b6f8c13-aae4-4c6a-8e1d-05d1ed74fe61"),
                    Index = "f",
                    Name = "CanadianResidentSelfPay_A6f",
                    Text = " Canadian resident, self-pay",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("90a67e4f-cdb3-4a02-867d-bad5d89e3954"),
                    Index = "g",
                    Name = "OtherCountryResidentSelfPay_A6g",
                    Text = " Other country resident, self-pay",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("7cd42d71-3747-4332-a15d-7d1afa923284"),
                    Index = "h",
                    Name = "ResponsibilityForPaymentUnknownOrUnavailable_A6h",
                    Text = " Responsibility for payment unknown or unavailable",
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
                    Id = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                    Index = "7",
                    Name = "ReasonForAssessment_A7",
                    Text = " REASON FOR ASSESSMENT		",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                        new ResponseModel
                        {
                        Id = new Guid("8b49d565-70e7-481a-b176-efb47a6ea367"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                        Value = "1",
                        Text = "First assessment",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("f43fc909-53af-402e-a88b-27377e6a7b37"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                        Value = "2",
                        Text = "Routine reassessment",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("dbaf66e4-e379-4f90-840c-a01e3ecd8578"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                        Value = "3",
                        Text = "Return assessment",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("cd5c500e-e754-4f9a-af22-ee44caeb0fb9"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                        Value = "4",
                        Text = "Significant change in status reassessment",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("69972640-21ba-478b-9d2f-14acb4494331"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                        Value = "5",
                        Text = "Discharge assessment covers last 3–7 days of service",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("5167a545-cfb0-416b-b756-62e666d04a77"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
                        Value = "6",
                        Text = "Discharge tracking only",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("d0f90330-c803-49b3-aa7d-3ecfae541ae5"),
                        QuestionId = new Guid("762299d8-fc09-48e0-9bf4-a43bc2a2da0b"),
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
                    Id = new Guid("2dec9149-3915-4652-897e-21d6e8974a43"),
                    Index = "8",
                    Name = "AssessmentReferenceDate_A8",
                    Text = " ASSESSMENT REFERENCE DATE",
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
                    Id = new Guid("5e88095e-ad25-4e23-845a-6feb9b936fc6"),
                    Index = "9",
                    Name = "ExpressedGoals_A9",
                    Text = " EXPRESSED GOALS",
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
                    Id = new Guid("e4707ad2-a678-4df3-bdff-fa25ad97e4f3"),
                    Index = "a",
                    Name = "Child’SYouth’SGoals_A9a",
                    Text = " Child’s / youth’s goals",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "TEXT",
                    Choices = new List<ResponseModel>
                    {
                    },
                    },
                new QuestionModel
                {
                    Id = new Guid("518671b7-8941-4714-8c7a-9dfa2e13ce8a"),
                    Index = "b",
                    Name = "Parent’SCaregiver’SGoals_A9b",
                    Text = " Parent’s / caregiver’s goals ",
                    SubText = " for child / youth",
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
                    Id = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
                    Index = "10",
                    Name = "LegalGuardianship_A10",
                    Text = " LEGAL GUARDIANSHIP 	",
                    SubText = "",
                    DefaultValue = null,
                    QuestionType = "DROPDOWN_LIST",
                    Choices = new List<ResponseModel>
                    {
                        new ResponseModel
                        {
                        Id = new Guid("0818bda5-5f50-4f87-8e28-f9931df48559"),
                        QuestionId = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
                        Value = "1",
                        Text = "Both parents",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("01561a5c-5a01-4fe4-adda-d809b4402ee2"),
                        QuestionId = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
                        Value = "2",
                        Text = "Mother only",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("7484866e-2218-46bf-b4ac-c0b27151c338"),
                        QuestionId = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
                        Value = "3",
                        Text = "Father only",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("83021cb8-2104-4d35-b15c-1ce30586d614"),
                        QuestionId = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
                        Value = "4",
                        Text = "Neither parent but other relative(s) or nonrelative(s)",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("bb0a0ca8-6b48-4106-b20d-eb3db3741548"),
                        QuestionId = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
                        Value = "5",
                        Text = "Child protection agency (e.g., CAS)",
                        },
                        new ResponseModel
                        {
                        Id = new Guid("e418cd51-1402-44c1-a863-fc2adf86e0cf"),
                        QuestionId = new Guid("79b27188-accc-4b61-9220-5cb7d7e9058b"),
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
                    Id = new Guid("a2893a72-adc1-4756-9173-ec7a2780410c"),
                    Index = "11",
                    Name = "CurrentDisputeOverCustodyOrChildYouthAccess_A11",
                    Text = " CURRENT DISPUTE OVER CUSTODY OR CHILD / YOUTH ACCESS",
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
                    Id = new Guid("5d963509-d4ff-4ed4-8fa1-bf98d929211e"),
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
                    Id = new Guid("c4b350c3-4776-4c7b-ba87-ea451cefc2bb"),
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
            },
        },
    };
}
