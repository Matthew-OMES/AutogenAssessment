using AssessmentAutogen.Model;

namespace AssessmentAutogen;

public static class AssessmentGeneration
{
    public static List<AssessmentModel> Assessments = new List<AssessmentModel>
{
    new AssessmentModel
    {
        Id = new Guid("9fd191de-b837-4b79-8be4-fc4811cddb94"),
        Name = "AdultMentalHealthAndDisability",
        Text = "Adult Intellectual Disability (ID) Assessment",
        Sections = new List<SectionModel>
        {
            new SectionModel
            {
                Id = new Guid("308efe72-98fd-4772-b2b1-baaf9e8af51b"),
                Index = "A",
                Description = "Identification Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("506357c3-2148-4561-8dfb-473d5c0430f4"),
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
                                Id = new Guid("12752d2e-f532-4396-872e-16c6878902a3"),
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
                                Id = new Guid("c596d2a6-a6c1-4721-b875-5d0a194a4c9f"),
                                Index = "b",
                                Name = "MiddleInitial_A1b",
                                Text = "Middle Initial",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("7ded24a6-9cf7-4305-92d8-7c27e4b096f4"),
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
                                Id = new Guid("e742453f-de25-45f8-825c-f1dad13f4819"),
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
                        Id = new Guid("0939666c-e853-4ef7-90d5-83495cc64515"),
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
                                Id = new Guid("0f5f5a7e-a75b-48a8-b2c1-67aa9d883269"),
                                QuestionId = new Guid("0939666c-e853-4ef7-90d5-83495cc64515"),
                                Value = "1",
                                Text = "Male",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6e6cc87c-0fcd-4594-a27f-0cc2a3b19be1"),
                                QuestionId = new Guid("0939666c-e853-4ef7-90d5-83495cc64515"),
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
                        Id = new Guid("63c647f4-67eb-44a4-a791-0a3ed5b6ca5d"),
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
                        Id = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                        Index = "4",
                        Name = "MaritalStatus_A4",
                        Text = "MARITAL STATUS",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("2de6e201-5c4c-4144-b1ef-485d26ee87ec"),
                                QuestionId = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                                Value = "1",
                                Text = "Never married",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e575d2f9-d0e5-4ac3-8eee-38507a0a8183"),
                                QuestionId = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                                Value = "2",
                                Text = "Married",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1659c81b-a59b-4f6c-b854-5b70d7b76cb0"),
                                QuestionId = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                                Value = "3",
                                Text = "Partner / significant other",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f61a2c9c-9fab-4d29-a228-be7e1b3b7a23"),
                                QuestionId = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                                Value = "4",
                                Text = "Widowed",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("13911552-0f23-4f67-bbb8-809ec4d080b2"),
                                QuestionId = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                                Value = "5",
                                Text = "Separated",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8b08a060-5dfe-4f16-a103-e20a8db31e43"),
                                QuestionId = new Guid("b30c5a58-97b6-4c79-b7f5-e0ad7226ce93"),
                                Value = "6",
                                Text = "Divorced",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("76fb6b78-69a7-46a1-888e-d2efc35b9851"),
                        Index = "5",
                        Name = "NumericIdentifiers_A5",
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
                                Id = new Guid("d4a475df-6827-4d3b-b08f-fd198b68fe08"),
                                Index = "a",
                                Name = "HealthCardNumber_A5a",
                                Text = "Health Card Number",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("45f794d9-735d-4171-a522-801cbbdad3b8"),
                                Index = "b",
                                Name = "CaseRecordNumber_A5b",
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
                        Id = new Guid("0ab200ad-0464-4b02-9a56-496ccf06c193"),
                        Index = "6",
                        Name = "ProvinceOrTerritoryOfUsualLivingArrangementAndAgencyIdentifiers_A6",
                        Text = "PROVINCE OR TERRITORY OF USUAL LIVING ARRANGEMENT AND AGENCY IDENTIFIERS",
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
                                Id = new Guid("64e2636f-fab5-42a4-aa8f-acc1e6bc4327"),
                                Index = "a",
                                Name = "ProvinceOrTerritory_A6a",
                                Text = "Province or Territory",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("51e302be-9ce6-4a0c-a191-6cf54bac42c0"),
                                Index = "b",
                                Name = "AgencyIdentifier_A6b",
                                Text = "Agency Identifier",
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
                        Id = new Guid("eb094367-6443-4e33-8dbb-3f38ec668136"),
                        Index = "7",
                        Name = "CurrentPaymentSources_A7",
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
                                Id = new Guid("0ee66e32-bc76-497b-bfd9-6bd88da5bb37"),
                                Index = "a",
                                Name = "ProvincialOrTerritorialGovernmentPlan_A7a",
                                Text = "Provincial or territorial government plan",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("af41fecf-1d18-4076-b1cf-7436147f5e9a"),
                                Index = "b",
                                Name = "ProvincialOrTerritorialGovernmentPlan_A7b",
                                Text = "Provincial or territorial government plan",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("cd505573-f8a2-47fe-959b-931503e286e4"),
                                Index = "c",
                                Name = "FederalGovernmentVeteransAffairsCanadaVac_A7c",
                                Text = "Federal government—Veterans Affairs Canada (VAC)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4dc505ba-7e4c-45b2-b660-0809ec560910"),
                                Index = "d",
                                Name = "FederalGovernmentFirstNationsAndInuitHealthBranchFnihb_A7d",
                                Text = "Federal government—First Nations and Inuit Health Branch (FNIHB)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("eb0631fc-e560-49da-a7ef-ad5271d61ea0"),
                                Index = "e",
                                Name = "FederalGovernmentOther_A7e",
                                Text = "Federal government—Other",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("906eb1a0-7ba4-44eb-a8fe-1407dab0a95b"),
                                Index = "f",
                                Name = "WorkersCompensationBoardWcbWsib_A7f",
                                Text = "Workers Compensation Board (WCB / WSIB)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("60ed803c-dbac-41c1-9586-d241041eae23"),
                                Index = "g",
                                Name = "CanadianResidentInsurancePay_A7g",
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
                                Id = new Guid("16cdfedd-86f2-4916-9cac-5e3b16d3cb41"),
                                Index = "h",
                                Name = "CanadianResidentPublicTrusteePay_A7h",
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
                                Id = new Guid("831b3678-ffd4-4107-9e9c-740d01fb2674"),
                                Index = "i",
                                Name = "CanadianResidentSelfPay_A7i",
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
                                Id = new Guid("2d7cc139-7f32-4bf3-bc54-f8667e314bcc"),
                                Index = "j",
                                Name = "OtherCountryResidentSelfPay_A7j",
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
                                Id = new Guid("9dbe169d-ec8b-4b11-9f33-4f1f85af9e07"),
                                Index = "k",
                                Name = "ResponsibilityForPaymentUnknownOrUnavailable_A7k",
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
                        Id = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                        Index = "8",
                        Name = "ReasonForAssessment_A8",
                        Text = "REASON FOR ASSESSMENT",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("cceb29ea-2ec8-4ee0-b436-55d970453527"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "1",
                                Text = "First assessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("01cacb71-0aeb-4ddf-a05e-48bf70fbb1b6"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "2",
                                Text = "Routine reassessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("27905518-db53-4f79-b835-67089293ecb9"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "3",
                                Text = "Return assessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c80a5b2a-30ad-4404-891d-10d306411554"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "4",
                                Text = "Significant change in status reassessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("610d70fb-71e6-4bd2-ab37-ff409ee82f13"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "5",
                                Text = "Discharge assessment, covers last 3 days of service",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d1f49246-96fc-4181-bd35-04f28cbdd934"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "6",
                                Text = "Discharge tracking only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8a98970c-e28e-4f4c-88c9-376edc9ad174"),
                                QuestionId = new Guid("c818d992-f4db-4897-a9e6-cec573630f9f"),
                                Value = "7",
                                Text = "Other—e.g., research",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("bf0a51aa-0946-4958-9603-a20fef63d8b1"),
                        Index = "9",
                        Name = "AssessmentReferenceDate_A9",
                        Text = "ASSESSMENT REFERENCE DATE",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("771408b1-05a0-4a16-a696-f3aea1345281"),
                        Index = "10",
                        Name = "PersonSExpressedGoals_A10",
                        Text = "PERSON’S EXPRESSED GOALS",
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
                        Id = new Guid("8b23efd3-6d8d-4681-85bc-56f73cd15463"),
                        Index = "11",
                        Name = "ResponsibilityLegalGuardian_A11",
                        Text = "RESPONSIBILITY / LEGAL GUARDIAN",
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
                                Id = new Guid("c01a15b0-be63-4b9b-b21b-189d266d5f3f"),
                                Index = "a",
                                Name = "LegalGuardian_A11a",
                                Text = "Legal guardian",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("9856bfc5-2589-402e-bb59-1cd6728cd0cb"),
                                Index = "b",
                                Name = "OtherLegalOversight_A11b",
                                Text = "Other legal oversight",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("0218e4b1-e9ff-49fc-a8b0-1cfcfe02db7e"),
                                Index = "c",
                                Name = "DurablePowerOfAttorneyHealthCare_A11c",
                                Text = "Durable power of attorney (health care)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("eb748dce-d398-4356-894b-bf79c0e4d5d3"),
                                Index = "d",
                                Name = "DurablePowerOfAttorneyFinancial_A11d",
                                Text = "Durable power of attorney (financial)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("eef4cbd1-7276-4451-ab1a-5c1d8fa017ed"),
                                Index = "e",
                                Name = "FamilyMemberResponsible_A11e",
                                Text = "Family member responsible",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("60d92261-8dbb-4af5-9811-455ae9c406bc"),
                                Index = "f",
                                Name = "PersonResponsibleForSelf_A11f",
                                Text = "Person responsible for self",
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
                        Id = new Guid("338688e5-b374-45e7-a4d2-ab0235575460"),
                        Index = "12",
                        Name = "AdmittedFromAndUsualResidence_A12",
                        Text = "ADMITTED FROM AND USUAL RESIDENCE",
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
                                Id = new Guid("e3eaa39a-9422-41de-a531-15462c0ef4c9"),
                                Index = "a",
                                Name = "AdmittedFrom_A12a",
                                Text = "Admitted from",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b1f079f4-321c-44e1-86eb-ee0031aa4d6c"),
                                Index = "b",
                                Name = "UsualResidentialStatus_A12b",
                                Text = "Usual residential status",
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
                        Id = new Guid("c20eda1f-dedd-4d91-8bcb-f443231f43ad"),
                        Index = "13",
                        Name = "PostalCodeOfUsualLivingArrangement_A13",
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
                        Id = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                        Index = "14",
                        Name = "LivingArrangement_A14",
                        Text = "LIVING ARRANGEMENT",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("5355886d-b064-4762-a41c-1dd20fdb0746"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "1",
                                Text = "Alone",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f09297ef-fc8c-4607-8f60-a96030b40408"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "2",
                                Text = "With spouse / partner only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a851dde9-5f65-4490-b769-5464fd869ff6"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "3",
                                Text = "With spouse / partner and other(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("546ebc60-204e-4ab0-bdb2-46fcc9a285ca"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "4",
                                Text = "With child (not spouse / partner)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5568b1b9-743b-479e-bf45-b1296834f29e"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "5",
                                Text = "With parent(s) or guardian(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("75d58ce9-4b6e-489c-8dd1-a77f5d24b69d"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "6",
                                Text = "With sibling(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("118bc024-7e0c-46cc-8a0a-f56da118aa8d"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "7",
                                Text = "With other relative(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ecd77abf-2137-4e2b-b885-5f9a385acdb0"),
                                QuestionId = new Guid("a3da5ab6-eb4a-4a64-b5fc-de47fdbfca94"),
                                Value = "8",
                                Text = "With nonrelative(s)",
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
                Id = new Guid("083736fb-396a-4f07-84c9-1d8450c5945c"),
                Index = "B",
                Description = "Intake and Initial History ^^^ NOTE: Complete Section B at Admission / First Assessment only",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("2d9ef4ce-df25-4a3b-a8e1-304e2b8b5049"),
                        Index = "1",
                        Name = "DateCaseOpened_B1",
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
                        Id = new Guid("57710ee0-6357-4ce5-9862-be45bc661816"),
                        Index = "2",
                        Name = "AboriginalIdentity_B2",
                        Text = "ABORIGINAL IDENTITY",
                        SubText = "Person identifies self as First Nations, Metis, or Inuit",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("09f1840f-533d-4b7e-93fc-909ab3fde256"),
                                Index = "a",
                                Name = "FirstNations_B2a",
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
                                Id = new Guid("480e86fd-a186-419f-8eea-993454dfb4c8"),
                                Index = "b",
                                Name = "Metis_B2b",
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
                                Id = new Guid("fd0b5fde-09f6-45d9-9fb4-ebab290fd909"),
                                Index = "c",
                                Name = "Inuit_B2c",
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
                        Id = new Guid("756ddac1-af90-4f39-859b-199e9ab7f8c8"),
                        Index = "3",
                        Name = "PrimaryLanguage_B3",
                        Text = "PRIMARY LANGUAGE",
                        SubText = "See Language Codes in User’s Manual Appendix for additional codes",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("0459d1d8-96ca-4dea-bd86-ab5c570dff45"),
                                QuestionId = new Guid("756ddac1-af90-4f39-859b-199e9ab7f8c8"),
                                Value = "eng",
                                Text = "English",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("064fb328-19df-4d92-9be4-ef728ee00e41"),
                                QuestionId = new Guid("756ddac1-af90-4f39-859b-199e9ab7f8c8"),
                                Value = "fra",
                                Text = "French",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("6977481e-c85c-4743-b27f-d86b921f6d55"),
                        Index = "4",
                        Name = "NatureOfIntellectualDisability_B4",
                        Text = "NATURE OF INTELLECTUAL DISABILITY",
                        SubText = "See manual for additional codes",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("f9943db1-0f69-43b5-82c7-a6412811cdbc"),
                                QuestionId = new Guid("6977481e-c85c-4743-b27f-d86b921f6d55"),
                                Value = "1",
                                Text = "Cause unspecified (i.e., intellectual or developmental disability)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bcae000d-c248-4270-81e4-d34f47e85d8a"),
                                QuestionId = new Guid("6977481e-c85c-4743-b27f-d86b921f6d55"),
                                Value = "2",
                                Text = "Down syndrome",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("24f57bd0-056d-41a8-9a59-55b50cb918b0"),
                                QuestionId = new Guid("6977481e-c85c-4743-b27f-d86b921f6d55"),
                                Value = "3",
                                Text = "Autism spectrum disorder",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4db413a1-ca9b-449a-b08d-40e5c17f8bab"),
                                QuestionId = new Guid("6977481e-c85c-4743-b27f-d86b921f6d55"),
                                Value = "4",
                                Text = "Fragile X syndrome",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3f3c0789-fac0-4496-a7a8-307e20344e87"),
                                QuestionId = new Guid("6977481e-c85c-4743-b27f-d86b921f6d55"),
                                Value = "5",
                                Text = "Fetal alcohol spectrum disorder",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                        Index = "5",
                        Name = "DocumentedSeverityOfIntellectualDisability_B5",
                        Text = "DOCUMENTED SEVERITY OF INTELLECTUAL DISABILITY",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("0685a15a-a927-492a-a9c1-ba21423cd354"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "0",
                                Text = "No intellectual disability",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("fe09476c-b4a6-42ab-9d16-6ce6726c584b"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "1",
                                Text = "Borderline",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9aa16f77-9a87-4404-ba8a-519cc9b1eecf"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "2",
                                Text = "Mild",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("63a1f9e4-6ace-487b-abe6-5833d9b42dd3"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "3",
                                Text = "Moderate",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6b7ba953-7b37-4a13-af1b-c4daa5b93593"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "4",
                                Text = "Severe",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("07c18c50-5609-42dd-8ff4-e0a301f4cab7"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "5",
                                Text = "Profound",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("06aa3201-44c4-40c9-9c49-25a6e83d76d5"),
                                QuestionId = new Guid("5a141352-bbe7-4c2c-b1a0-08b065744b20"),
                                Value = "8",
                                Text = "Not documented",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("6de4efba-1728-4cb1-bf22-7552eb6db3e4"),
                        Index = "6",
                        Name = "AgeAtWhichPersonLeftFamilyHome_B6",
                        Text = "AGE AT WHICH PERSON LEFT FAMILY HOME",
                        SubText = "Code 88 if not applicable (i.e., person never left family home). Code 99 if unknown.",
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
                        Id = new Guid("5bc4a929-31ce-4281-a018-eb3536bfe912"),
                        Index = "7",
                        Name = "NumberOfYearsLifetimeSpentInAnInstitutionalSettingForPersonsWithIntellectualDisability_B7",
                        Text = "NUMBER OF YEARS (LIFETIME) SPENT IN AN INSTITUTIONAL SETTING FOR PERSONS WITH INTELLECTUAL DISABILITY",
                        SubText = "Code 0 if person was never in an institutional setting. Code 99 if unknown. If less than 1 year, code as 1 year.",
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
                        Id = new Guid("d6494ebf-17d3-4d3c-b209-2d729a91384d"),
                        Index = "8",
                        Name = "ResidentialHistoryOverLast5Years_B8",
                        Text = "RESIDENTIAL HISTORY OVER LAST 5 YEARS",
                        SubText = "Code for all settings person lived in during 5 YEARS prior to date case opened (Item B1)",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("8ca725b4-9fae-4ae6-976b-4379e8283339"),
                                Index = "a",
                                Name = "SemiIndependentLivingSil_B8a",
                                Text = "Semi-independent living (SIL)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("6af9629c-9e7b-48b2-b79e-923fa0951da6"),
                                Index = "b",
                                Name = "BoardAndCare_B8b",
                                Text = "Board and care",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e0fa4428-95a2-4a9f-ab9f-104a5f266884"),
                                Index = "c",
                                Name = "GroupHome_B8c",
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
                                Id = new Guid("7924cbb1-c0cc-4b17-b2bb-2944b947b94e"),
                                Index = "d",
                                Name = "InstitutionalSettingForPersonsWithIntellectualDisability_B8d",
                                Text = "Institutional setting for persons with intellectual disability",
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
                Id = new Guid("4ae306ca-a1c0-409a-8dc2-893515d756a2"),
                Index = "C",
                Description = "Community and Social Involvement",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("95c9f435-6cdc-443b-a9c8-14640647b691"),
                        Index = "1",
                        Name = "EmploymentStatus_C1",
                        Text = "EMPLOYMENT STATUS",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("5ad64f7a-8449-4fa5-bf54-12aad89bbdfa"),
                                QuestionId = new Guid("95c9f435-6cdc-443b-a9c8-14640647b691"),
                                Value = "1",
                                Text = "Employed",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("58cf1185-bdf5-4a81-83dd-59a2b6ec50a7"),
                                QuestionId = new Guid("95c9f435-6cdc-443b-a9c8-14640647b691"),
                                Value = "2",
                                Text = "Unemployed, seeking employment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("00b5840b-33de-48e6-9f1b-91ddf5768eb3"),
                                QuestionId = new Guid("95c9f435-6cdc-443b-a9c8-14640647b691"),
                                Value = "3",
                                Text = "Unemployed, not seeking employment",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("4339656e-0d96-4b6a-9365-1de8d9cf7816"),
                        Index = "2",
                        Name = "EmploymentArrangementsExcludeVolunteering_C2",
                        Text = "EMPLOYMENT ARRANGEMENTS (Exclude volunteering)",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("bdcf530d-9b59-4090-a14e-ab65e752c439"),
                                QuestionId = new Guid("4339656e-0d96-4b6a-9365-1de8d9cf7816"),
                                Value = "1",
                                Text = "Competitive employment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("16aa052c-f03e-43b6-90ac-31614a6d6295"),
                                QuestionId = new Guid("4339656e-0d96-4b6a-9365-1de8d9cf7816"),
                                Value = "2",
                                Text = "Supported employment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c840dd7b-7e02-433c-9bde-77d07a0b6261"),
                                QuestionId = new Guid("4339656e-0d96-4b6a-9365-1de8d9cf7816"),
                                Value = "3",
                                Text = "Vocational rehabilitation",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6eba8102-43c2-48a8-a35c-7b0d51cf3b33"),
                                QuestionId = new Guid("4339656e-0d96-4b6a-9365-1de8d9cf7816"),
                                Value = "8",
                                Text = "Not applicable",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("37a5f9b9-a36f-46b5-b722-942c05438deb"),
                        Index = "3",
                        Name = "InvolvementInStructuredActivities_C3",
                        Text = "INVOLVEMENT IN STRUCTURED ACTIVITIES",
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
                                Id = new Guid("8cd2627a-9409-4d7a-835f-47609e5c56e6"),
                                Index = "a",
                                Name = "FormalEducationProgram_C3a",
                                Text = "Formal education program",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("35bf584b-c1e1-4d9b-84aa-5f2ea641626c"),
                                Index = "b",
                                Name = "VolunteerismEGForCommunityServices_C3b",
                                Text = "Volunteerism—e.g., for community services",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a4925c80-11d9-4e48-980c-32b13ea7d987"),
                                Index = "c",
                                Name = "DayProgram_C3c",
                                Text = "Day program",
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
                        Id = new Guid("7c3e233f-d14c-44d0-a786-4676fa3bef15"),
                        Index = "4",
                        Name = "NumberOfDaysOfParticipationInPreferredRecreationAndLeisureActivitiesInLast7Days_C4",
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
                        Id = new Guid("0885a4f7-cb93-4958-a35a-bb98e5e8a74a"),
                        Index = "5",
                        Name = "SenseOfInvolvement_C5",
                        Text = "SENSE OF INVOLVEMENT",
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
                                Id = new Guid("f89f468c-dae5-46fa-90b3-86dba6f417f5"),
                                Index = "a",
                                Name = "AtEaseInteractingWithOthers_C5a",
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
                                Id = new Guid("71ea9576-dbcc-4adc-a828-4c1a03c69731"),
                                Index = "b",
                                Name = "AtEaseDoingPlannedOrStructuredActivities_C5b",
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
                                Id = new Guid("b69bbdaa-3f5f-45f6-af34-49b8fe166662"),
                                Index = "c",
                                Name = "PursuesInvolvementInActivitiesOfResidentialSettingOrCommunity_C5c",
                                Text = "Pursues involvement in activities of residential setting or community",
                                SubText = "e.g., makes or keeps friends; involved in group activities; responds positively to new activities; assists at religious services",
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
                        Id = new Guid("82f89400-551a-4cc0-8689-384d45304759"),
                        Index = "6",
                        Name = "PersonPrefersChangeWhenAsked_C6",
                        Text = "PERSON PREFERS CHANGE (When asked)",
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
                                Id = new Guid("de691a11-fca6-4081-bb83-c98379c47c8a"),
                                Index = "a",
                                Name = "PaidEmploymentEGTypeHoursPay_C6a",
                                Text = "Paid employment—e.g., type, hours, pay",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d2312472-7d2b-466e-82a8-3e4a042140a4"),
                                Index = "b",
                                Name = "RecreationalActivitiesEGTypeNumberOrLevelOfParticipation_C6b",
                                Text = "Recreational activities—e.g., type, number, or level of participation",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("7b798fed-e977-4ce9-92d9-8401c25e3b38"),
                                Index = "c",
                                Name = "LivingArrangementsEGLocationTypeWhoLivesWith_C6c",
                                Text = "Living arrangements—e.g., location, type, who lives with",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("390ab090-cfd8-4a9f-a7d2-fdd5515f3ac6"),
                                Index = "d",
                                Name = "DailyRoutineEGDietSleepScheduleClothesToWear_C6d",
                                Text = "Daily routine—e.g., diet, sleep schedule, clothes to wear",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d3dd6985-48f6-4b7e-adff-20ae3d44c1df"),
                                Index = "e",
                                Name = "SupportsAndServicesEGProgramsStaff_C6e",
                                Text = "Supports and services—e.g., programs, staff",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("dc74be41-7a0b-44ee-88cb-8e27f791650b"),
                                Index = "f",
                                Name = "RelationshipsEGEstablishingFriendshipsImprovingExistingRelationships_C6f",
                                Text = "Relationships—e.g., establishing friendships, improving existing relationships",
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
                Id = new Guid("08ed0c22-f326-44ff-9bbf-ea8912776850"),
                Index = "D",
                Description = "Strengths, Relationships, and Supports",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("f5ac9206-af58-4f9a-83a2-25596edb3f9e"),
                        Index = "1",
                        Name = "Strengths_D1",
                        Text = "STRENGTHS",
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
                                Id = new Guid("d96c0e2c-44de-425f-9354-8b54ca51bf26"),
                                Index = "a",
                                Name = "ConsistentPositiveOutlook_D1a",
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
                                Id = new Guid("8ee083d6-61cb-4db9-bada-3d06cafc3366"),
                                Index = "b",
                                Name = "FindsMeaningInDayToDayLife_D1b",
                                Text = "Finds meaning in day-to-day life",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b3a7380d-6fee-4d75-ac0f-86fdc63637e7"),
                                Index = "c",
                                Name = "ReportsHavingAConfidant_D1c",
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
                                Id = new Guid("52468234-84ea-4226-9f53-e7a719d3c9a9"),
                                Index = "d",
                                Name = "StrongAndSupportiveRelationshipWithFamily_D1d",
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
                                Id = new Guid("983e95a9-dd13-4f14-ac77-f66d51582113"),
                                Index = "e",
                                Name = "ReportsStrongSenseOfInvolvementInCommunity_D1e",
                                Text = "Reports strong sense of involvement in community",
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
                        Id = new Guid("54104fd1-b3f0-4572-8486-f793ab06de76"),
                        Index = "2",
                        Name = "SocialRelationships_D2",
                        Text = "SOCIAL RELATIONSHIPS",
                        SubText = "Note: Whenever possible, ask person",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("6736f596-6466-4cc9-a57d-82372985ee3e"),
                                Index = "a",
                                Name = "ParticipationInSocialActivitiesOfLongStandingInterest_D2a",
                                Text = "Participation in social activities of long-standing interest",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("61354dbd-e0f6-42ea-b2b8-7d0892620ab4"),
                                Index = "b",
                                Name = "VisitWithALongStandingSocialRelationOrFamilyMember_D2b",
                                Text = "Visit with a long-standing social relation or family member",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("751ab559-1c3e-4e18-9995-2beb73254af2"),
                                Index = "c",
                                Name = "OtherInteractionWithLongStandingSocialRelationOrFamilyMember_D2c",
                                Text = "Other interaction with long-standing social relation or family member",
                                SubText = "e.g., telephone, e-mail",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("81bf0c2e-6527-4679-8dc8-7a00c2a12872"),
                                Index = "d",
                                Name = "OvernightStayOf1OrMoreNightsAtHomeOfFamilyMemberOrLongStandingSocialRelation_D2d",
                                Text = "Overnight stay of 1 or more nights at home of family member or long-standing social relation",
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
                        Id = new Guid("029c5290-a591-4a08-b17e-42f875cd3cbe"),
                        Index = "3",
                        Name = "UnsettledRelationships_D3",
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
                                Id = new Guid("fca7f416-8655-4059-b1f1-72a11936caec"),
                                Index = "a",
                                Name = "ConflictWithOrRepeatedCriticismOfFamilyOrFriends_D3a",
                                Text = "Conflict with or repeated criticism of family or friends",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("ae8bf392-5457-4450-980e-ac3491b6916f"),
                                Index = "b",
                                Name = "ConflictWithOrRepeatedCriticismOfOtherClients_D3b",
                                Text = "Conflict with or repeated criticism of other clients",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d70baabb-483f-48de-be18-e163a0f24faf"),
                                Index = "c",
                                Name = "ConflictWithOrRepeatedCriticismOfStaff_D3c",
                                Text = "Conflict with or repeated criticism of staff",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("fe2a143b-e17d-4d40-9ed7-aa585949aad8"),
                                Index = "d",
                                Name = "FamilyOrCloseFriendsArePersistentlyHostileTowardPerson_D3d",
                                Text = "Family or close friends are persistently hostile toward person",
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
                        Id = new Guid("0f9d5fc3-b051-48a2-9cfe-6cb2d335f998"),
                        Index = "4",
                        Name = "TwoKeySupportsHelper1_D4",
                        Text = "TWO KEY SUPPORTS - Helper 1",
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
                                Id = new Guid("2463ec0f-61f8-458c-9342-a69429ab2a71"),
                                Index = "a",
                                Name = "RelationshipToPerson_D4a",
                                Text = "Relationship to person",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8ef1782e-a5f9-4c17-9702-ae61923f08cf"),
                                Index = "b",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysGeneralOversightOrCueing_D4b",
                                Text = "Areas of unpaid support during last 3 days: General oversight or cueing",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("314cffb2-5289-4bdb-ae99-98fc3c1c86a9"),
                                Index = "c",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysIadl_D4c",
                                Text = "Areas of unpaid support during last 3 days: IADL",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("1543242f-a036-4d5a-8a56-a2fdb4109a0e"),
                                Index = "d",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysAdl_D4d",
                                Text = "Areas of unpaid support during last 3 days: ADL",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e943a0ad-25e5-497a-b191-4e81e975300d"),
                                Index = "e",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysCrisisSupport_D4e",
                                Text = "Areas of unpaid support during last 3 days: Crisis support",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("bda0661e-8887-4888-8297-9964da16eff5"),
                                Index = "f",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysSocialInclusionAndParticipation_D4f",
                                Text = "Areas of unpaid support during last 3 days: Social inclusion and participation",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e4b11ca6-abbf-4e9d-bafb-832cbd67d79b"),
                                Index = "g",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysCompanionship_D4g",
                                Text = "Areas of unpaid support during last 3 days: Companionship",
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
                        Id = new Guid("ddc16ba5-5188-4a81-ad95-49bddb62f463"),
                        Index = "5",
                        Name = "TwoKeySupportsHelper2_D5",
                        Text = "TWO KEY SUPPORTS - Helper 2",
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
                                Id = new Guid("70f63ac9-b4c3-49bd-a70e-b0c95c585a9d"),
                                Index = "a",
                                Name = "RelationshipToPerson_D5a",
                                Text = "Relationship to person",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("38fbc08a-d422-464f-8ff1-91432fdc1a0f"),
                                Index = "b",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysGeneralOversightOrCueing_D5b",
                                Text = "Areas of unpaid support during last 3 days: General oversight or cueing",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("92e2b7b2-854e-443d-979c-202589450397"),
                                Index = "c",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysIadl_D5c",
                                Text = "Areas of unpaid support during last 3 days: IADL",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("703bb9ab-ce45-4be4-af03-f4be25e7d31f"),
                                Index = "d",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysAdl_D5d",
                                Text = "Areas of unpaid support during last 3 days: ADL",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a22a25f0-a100-49d5-b318-26f07d897971"),
                                Index = "e",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysCrisisSupport_D5e",
                                Text = "Areas of unpaid support during last 3 days: Crisis support",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("cd4d134e-29e3-463c-8d49-ed0845f4e088"),
                                Index = "f",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysSocialInclusionAndParticipation_D5f",
                                Text = "Areas of unpaid support during last 3 days: Social inclusion and participation",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4862f5fd-7673-42bb-978d-d2b0ce00dbaa"),
                                Index = "g",
                                Name = "AreasOfUnpaidSupportDuringLast3DaysCompanionship_D5g",
                                Text = "Areas of unpaid support during last 3 days: Companionship",
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
                        Id = new Guid("7fa5db72-e86a-4290-98fa-f40bc17d24b3"),
                        Index = "6",
                        Name = "SupportGivenToOthers_D6",
                        Text = "SUPPORT GIVEN TO OTHERS",
                        SubText = "Areas of support given by the person to others (exclude volunteer and paid activities)",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("be89716c-a470-417e-a0e4-c9e70c1ba17d"),
                                Index = "a",
                                Name = "Companionship_D6a",
                                Text = "Companionship",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("7f97c8a1-282a-493d-82e4-f5ed605c320d"),
                                Index = "b",
                                Name = "Iadl_D6b",
                                Text = "IADL",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("f601381c-b712-4761-8319-bea981388933"),
                                Index = "c",
                                Name = "Adl_D6c",
                                Text = "ADL",
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
                        Id = new Guid("3cfd2b60-6aca-4fb3-afba-3b925d759978"),
                        Index = "7",
                        Name = "HoursOfUnpaidSupportAndActiveMonitoringDuringLast3Days_D7",
                        Text = "HOURS OF UNPAID SUPPORT AND ACTIVE MONITORING DURING LAST 3 DAYS",
                        SubText = "For instrumental and personal activities of daily living in the LAST 3 DAYS, indicate the total number of hours of unpaid support received from ALL family, friends, and neighbours",
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
                        Id = new Guid("a3d20311-13fb-4440-a5dc-892806b0987d"),
                        Index = "8",
                        Name = "StatusOfSupportsExcludePaidHelp_D8",
                        Text = "STATUS OF SUPPORTS (exclude paid help)",
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
                                Id = new Guid("46ac2b19-f669-4f47-be3b-298b822d8f67"),
                                Index = "a",
                                Name = "SupportPersonSUnableToContinueInCaringActivities_D8a",
                                Text = "Support person(s) unable to continue in caring activities",
                                SubText = "e.g., decline in the health of the support person makes it difficult to continue",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("df91f2f5-1ed4-48dc-9067-47ad5c160777"),
                                Index = "b",
                                Name = "PrimarySupportPersonExpressesFeelingsOfDistressAngerOrDepression_D8b",
                                Text = "Primary support person expresses feelings of distress, anger, or depression",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("28eb0a5d-edf1-47c3-abc2-87d9cf0b6a37"),
                                Index = "c",
                                Name = "FamilyOrCloseFriendsReportFeelingOverwhelmedByPersonSSupportNeeds_D8c",
                                Text = "Family or close friends report feeling overwhelmed by person’s support needs",
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
                        Id = new Guid("8a6e5bd1-55d2-465e-89ff-7f1acf61cf56"),
                        Index = "9",
                        Name = "PlansForFutureNeeds_D9",
                        Text = "PLANS FOR FUTURE NEEDS",
                        SubText = "Plan in place for alternative future support or living arrangements, if required (e.g., if current support person is unable to continue in that role)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("4bc821bf-064b-49e2-9d97-e8f1f37419c3"),
                                QuestionId = new Guid("8a6e5bd1-55d2-465e-89ff-7f1acf61cf56"),
                                Value = "0",
                                Text = "Alternative plans not considered OR not required",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("986545ba-6350-49c1-8696-d160e94882f9"),
                                QuestionId = new Guid("8a6e5bd1-55d2-465e-89ff-7f1acf61cf56"),
                                Value = "1",
                                Text = "Alternative plans not made, but under consideration",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3928cff6-b9c1-4c11-84d5-cc81e9e70f5f"),
                                QuestionId = new Guid("8a6e5bd1-55d2-465e-89ff-7f1acf61cf56"),
                                Value = "2",
                                Text = "Alternative plans made",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("8c616c32-2395-4b83-94ea-4e2049ec108e"),
                        Index = "10",
                        Name = "LifeEvents_D10",
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
                                Id = new Guid("d9afe2d3-43e0-4c0f-b83d-d963a87326bc"),
                                Index = "a",
                                Name = "SeriousAccidentOrPhysicalImpairment_D10a",
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
                                Id = new Guid("104e9dc9-d6af-4e1a-b915-056a6cda0a53"),
                                Index = "b",
                                Name = "DistressAboutHealthOfAnotherPerson_D10b",
                                Text = "Distress about health of another person",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("257fbb1b-b4f2-4800-bc9d-34ec7bc259d9"),
                                Index = "c",
                                Name = "DeathOfCloseFamilyMemberOrFriend_D10c",
                                Text = "Death of close family member or friend",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4c8c8cc0-2e50-42d8-917c-28ed3e953313"),
                                Index = "d",
                                Name = "VictimOfSexualAssaultOrAbuse_D10d",
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
                                Id = new Guid("6b52f4b5-132d-4e51-9ed7-b12c97d08f9a"),
                                Index = "e",
                                Name = "VictimOfPhysicalAssaultOrAbuse_D10e",
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
                                Id = new Guid("3ec58c58-b3f6-4b8c-883f-064f7757fdb5"),
                                Index = "f",
                                Name = "VictimOfEmotionalAbuse_D10f",
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
                                Id = new Guid("ee59a817-9a8a-4d71-ba63-9c3374686b38"),
                                Index = "g",
                                Name = "VictimOfBullying_D10g",
                                Text = "Victim of bullying",
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
                        Id = new Guid("bf43ec25-9874-421f-8b7c-5c5ceb0129d7"),
                        Index = "11",
                        Name = "DescribesOneOrMoreOfTheseLifeEventsD9AsInvokingASenseOfHorrorOrIntenseFear_D11",
                        Text = "DESCRIBES ONE OR MORE OF THESE LIFE EVENTS (D9) AS INVOKING A SENSE OF HORROR OR INTENSE FEAR",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("a2e068e4-f6df-4d80-bc35-c13eaf42ab09"),
                                QuestionId = new Guid("bf43ec25-9874-421f-8b7c-5c5ceb0129d7"),
                                Value = "0",
                                Text = "No, or not applicable",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3417cfa2-1841-4912-8816-bb056e84bdc3"),
                                QuestionId = new Guid("bf43ec25-9874-421f-8b7c-5c5ceb0129d7"),
                                Value = "1",
                                Text = "Yes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8ac56f59-b450-485d-83d7-6c0ec9fc4977"),
                                QuestionId = new Guid("bf43ec25-9874-421f-8b7c-5c5ceb0129d7"),
                                Value = "8",
                                Text = "Could not (would not) respond",
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
                Id = new Guid("e315de31-f826-491a-923c-f35f7258c4d1"),
                Index = "E",
                Description = "Lifestyle",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("ca671c83-76ae-4a22-864c-b546e11b768f"),
                        Index = "1",
                        Name = "CaffeineUse_E1",
                        Text = "CAFFEINE USE",
                        SubText = "Highest number of caffeinated beverages consumed in any single day of the LAST 3 DAYS",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("a028361c-c0f1-4b6b-87ef-d9bb7663b7a5"),
                                QuestionId = new Guid("ca671c83-76ae-4a22-864c-b546e11b768f"),
                                Value = "0",
                                Text = "No coffee or caffeinated beverages",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b13e168f-e72b-4604-9a5e-e56969488e35"),
                                QuestionId = new Guid("ca671c83-76ae-4a22-864c-b546e11b768f"),
                                Value = "1",
                                Text = "1–2 cups of coffee or 1–4 caffeinated beverages",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3de3b264-631a-4327-879e-0fcbe384e266"),
                                QuestionId = new Guid("ca671c83-76ae-4a22-864c-b546e11b768f"),
                                Value = "2",
                                Text = "3–5 cups of coffee or 5–9 caffeinated beverages",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e75dee6c-6457-4d44-9417-348eb0d4fcdc"),
                                QuestionId = new Guid("ca671c83-76ae-4a22-864c-b546e11b768f"),
                                Value = "3",
                                Text = "6 or more cups of coffee or 10 or more caffeinated beverages",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("45a8d242-3faf-454c-8fd0-f976c21ea756"),
                        Index = "2",
                        Name = "SmokesTobaccoDaily_E2",
                        Text = "SMOKES TOBACCO DAILY",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("0202db99-e6ed-4c5b-994e-f6cfcf2f2e4e"),
                                QuestionId = new Guid("45a8d242-3faf-454c-8fd0-f976c21ea756"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bdeb5e2a-66d3-48ce-9314-12180c336cc5"),
                                QuestionId = new Guid("45a8d242-3faf-454c-8fd0-f976c21ea756"),
                                Value = "1",
                                Text = "Not in last 3 days, but is usually a daily smoker",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a0e49808-adac-4041-b613-f556ad1b4745"),
                                QuestionId = new Guid("45a8d242-3faf-454c-8fd0-f976c21ea756"),
                                Value = "2",
                                Text = "Yes",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("e7b2a2fc-7580-4de6-9a15-d9c90634d75a"),
                        Index = "3",
                        Name = "Alcohol_E3",
                        Text = "ALCOHOL",
                        SubText = "Highest number of drinks in any “single sitting” in LAST 14 DAYS",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("e9d79072-67a2-4e4e-a1db-d22ecdb81d66"),
                                QuestionId = new Guid("e7b2a2fc-7580-4de6-9a15-d9c90634d75a"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("81d48fac-e1a1-4e69-9c37-dae8db964421"),
                                QuestionId = new Guid("e7b2a2fc-7580-4de6-9a15-d9c90634d75a"),
                                Value = "1",
                                Text = "1",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("63749ff8-a736-4e50-a034-8397085f093b"),
                                QuestionId = new Guid("e7b2a2fc-7580-4de6-9a15-d9c90634d75a"),
                                Value = "2",
                                Text = "2–4",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6a354cfa-8037-40f6-9011-011391c45d1e"),
                                QuestionId = new Guid("e7b2a2fc-7580-4de6-9a15-d9c90634d75a"),
                                Value = "3",
                                Text = "5 or more",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("1ee66d29-17d5-469c-83b3-fe3cd141ecfb"),
                        Index = "4",
                        Name = "TotalHoursOfExerciseOrPhysicalActivityInLast3DaysEGWalking_E4",
                        Text = "TOTAL HOURS OF EXERCISE OR PHYSICAL ACTIVITY IN LAST 3 DAYS—e.g., walking",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("8da7601c-2311-44ff-b0bf-f2b3990b262a"),
                                QuestionId = new Guid("1ee66d29-17d5-469c-83b3-fe3cd141ecfb"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("564f9a7a-a560-4629-afc6-a761bb0464b5"),
                                QuestionId = new Guid("1ee66d29-17d5-469c-83b3-fe3cd141ecfb"),
                                Value = "1",
                                Text = "Less than 1 hour",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c84865d4-5a35-4baf-a28a-eadf0fdb7f3b"),
                                QuestionId = new Guid("1ee66d29-17d5-469c-83b3-fe3cd141ecfb"),
                                Value = "2",
                                Text = "1–2 hours",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b0249e12-30c4-499c-aa6f-5095db049747"),
                                QuestionId = new Guid("1ee66d29-17d5-469c-83b3-fe3cd141ecfb"),
                                Value = "3",
                                Text = "3–4 hours",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bd635d8b-22ed-441b-afd8-63cba26f3b27"),
                                QuestionId = new Guid("1ee66d29-17d5-469c-83b3-fe3cd141ecfb"),
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
                Id = new Guid("6f3db99a-d94f-4e1e-b61e-5d5f33394f12"),
                Index = "F",
                Description = "Environmental Assessment",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("fadbde22-5d86-4b2f-b776-864ae7623e83"),
                        Index = "1",
                        Name = "HomeEnvironment_F1",
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
                                Id = new Guid("64cb9730-9ef9-4974-870f-8bf41224517f"),
                                Index = "a",
                                Name = "DisrepairOfTheHome_F1a",
                                Text = "Disrepair of the home",
                                SubText = "e.g., hazardous clutter; inadequate or no lighting in living room, sleeping room, kitchen, toilet, corridors; holes in floor; leaking pipes",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e627af84-04cd-446e-b737-521b070f2424"),
                                Index = "b",
                                Name = "SqualidCondition_F1b",
                                Text = "Squalid condition",
                                SubText = "e.g., extremely dirty, infestation by rats or bugs",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("69d79de6-68d6-4343-b98b-f34b720a64bb"),
                                Index = "c",
                                Name = "InadequateHeatingOrCooling_F1c",
                                Text = "Inadequate heating or cooling",
                                SubText = "e.g., too hot in summer, too cold in winter",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2f75501e-4d10-4a5b-9c58-8d7c612e55b2"),
                                Index = "d",
                                Name = "LackOfPersonalSafety_F1d",
                                Text = "Lack of personal safety",
                                SubText = "e.g., fear of violence, safety problem in going to mailbox or visiting neighbours, heavy traffic in street",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("5a1e9f0d-ed52-4c08-9826-97a4349a99d3"),
                                Index = "e",
                                Name = "LimitedAccessToHomeOrRoomsInHome_F1e",
                                Text = "Limited access to home or rooms in home",
                                SubText = "e.g., difficulty entering or leaving home, unable to climb stairs, difficulty manoeuvring within rooms, no railings although needed",
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
                Id = new Guid("25eee073-de57-45e8-86f9-857d445941e6"),
                Index = "G",
                Description = "Communication and Vision",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("fc172d17-41a1-43e9-8951-b2ffd5550805"),
                        Index = "1",
                        Name = "CommunicationMethods_G1",
                        Text = "COMMUNICATION METHODS",
                        SubText = "Code for primary type of expressive communication",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("1b78fffa-7ca7-4bfd-b05b-8f42e31282d0"),
                                QuestionId = new Guid("fc172d17-41a1-43e9-8951-b2ffd5550805"),
                                Value = "0",
                                Text = "Verbal—i.e., speech",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1497e37e-e86c-47bc-b72d-93687d77992f"),
                                QuestionId = new Guid("fc172d17-41a1-43e9-8951-b2ffd5550805"),
                                Value = "1",
                                Text = "Nonverbal—e.g., gestures, sign language, sounds, writing",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("67822823-4b08-48ab-a860-ea165f7f5169"),
                        Index = "2",
                        Name = "MakingSelfUnderstoodExpression_G2",
                        Text = "MAKING SELF UNDERSTOOD (Expression)",
                        SubText = "Expressing information content—both verbal and nonverbal",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("16018dae-d2c8-4c04-9dfb-09ad6ed262a8"),
                                QuestionId = new Guid("67822823-4b08-48ab-a860-ea165f7f5169"),
                                Value = "0",
                                Text = "Understood—Expresses ideas without difficulty",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("adeafa21-c666-451e-9684-a5ecfc8d629d"),
                                QuestionId = new Guid("67822823-4b08-48ab-a860-ea165f7f5169"),
                                Value = "1",
                                Text = "Usually understood—Difficulty finding words or finishing thoughts BUT if given time, little or no prompting required",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e2cd5af9-6e03-4be3-9070-83d299330af7"),
                                QuestionId = new Guid("67822823-4b08-48ab-a860-ea165f7f5169"),
                                Value = "2",
                                Text = "Often understood—Difficulty finding words or finishing thoughts AND prompting usually required",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("cdf4b5c8-336e-4dd8-b9f7-2453c9db0b21"),
                                QuestionId = new Guid("67822823-4b08-48ab-a860-ea165f7f5169"),
                                Value = "3",
                                Text = "Sometimes understood—Ability is limited to making concrete requests",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a863357c-0944-4734-8bc4-b5c8cfb5bf3e"),
                                QuestionId = new Guid("67822823-4b08-48ab-a860-ea165f7f5169"),
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
                        Id = new Guid("4b37c461-8c0d-4106-8f5d-9fffbaa0f286"),
                        Index = "3",
                        Name = "AbilityToUnderstandOthersComprehension_G3",
                        Text = "ABILITY TO UNDERSTAND OTHERS (Comprehension)",
                        SubText = "Understanding verbal information content (however able; with hearing appliance normally used)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("877233c7-bb4c-4cfc-9ba1-d97fd623cb2a"),
                                QuestionId = new Guid("4b37c461-8c0d-4106-8f5d-9fffbaa0f286"),
                                Value = "0",
                                Text = "Understands—Clear comprehension",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a379425b-8eb6-4c6c-830a-513880f4c1c0"),
                                QuestionId = new Guid("4b37c461-8c0d-4106-8f5d-9fffbaa0f286"),
                                Value = "1",
                                Text = "Usually understands—Misses some part / intent of message BUT comprehends most conversation",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b195c9f2-b445-4a11-a117-060143771a4f"),
                                QuestionId = new Guid("4b37c461-8c0d-4106-8f5d-9fffbaa0f286"),
                                Value = "2",
                                Text = "Often understands—Misses some part / intent of message BUT with repetition or explanation can often comprehend conversation",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("85fc0237-35b2-43f9-8ac2-24a377472d21"),
                                QuestionId = new Guid("4b37c461-8c0d-4106-8f5d-9fffbaa0f286"),
                                Value = "3",
                                Text = "Sometimes understands—Responds adequately to simple, direct communication only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("85c8ca57-96d2-4da4-bdf0-ae5e3a725fe0"),
                                QuestionId = new Guid("4b37c461-8c0d-4106-8f5d-9fffbaa0f286"),
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
                        Id = new Guid("4874568c-61c9-4c7e-aabd-d63915a13814"),
                        Index = "4",
                        Name = "Hearing_G4",
                        Text = "HEARING",
                        SubText = "Ability to hear (with hearing appliance normally used)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("769f2808-43e4-42f7-9174-b759616c0a0c"),
                                QuestionId = new Guid("4874568c-61c9-4c7e-aabd-d63915a13814"),
                                Value = "0",
                                Text = "Adequate—No difficulty in normal conversation, social interaction, listening to TV",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1a622a25-f426-4e7e-bed2-07362ba16154"),
                                QuestionId = new Guid("4874568c-61c9-4c7e-aabd-d63915a13814"),
                                Value = "1",
                                Text = "Minimal difficulty—Difficulty in some environments (e.g., when person speaks softly or is more than 2 metres [6 feet] away)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("92d67b65-65ac-44cc-8859-50fdb67bd921"),
                                QuestionId = new Guid("4874568c-61c9-4c7e-aabd-d63915a13814"),
                                Value = "2",
                                Text = "Moderate difficulty—Problem hearing normal conversation, requires quiet setting to hear well",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c5103068-e322-4ca1-9650-3a9d210d0261"),
                                QuestionId = new Guid("4874568c-61c9-4c7e-aabd-d63915a13814"),
                                Value = "3",
                                Text = "Severe difficulty—Difficulty in all situations (e.g., speaker has to talk loudly or speak very slowly; or person reports that all speech is mumbled)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c683d186-2e8f-4626-9dc3-20258083da9e"),
                                QuestionId = new Guid("4874568c-61c9-4c7e-aabd-d63915a13814"),
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
                        Id = new Guid("4b20b73a-2072-4d2b-a65f-b17923961da2"),
                        Index = "5",
                        Name = "Vision_G5",
                        Text = "VISION",
                        SubText = "Ability to see in adequate light (with glasses or with other visual appliance normally used)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("4d0d8e14-5001-48ae-bf01-bd574cebeaba"),
                                QuestionId = new Guid("4b20b73a-2072-4d2b-a65f-b17923961da2"),
                                Value = "0",
                                Text = "Adequate—Sees fine detail, including regular print in newspapers / books",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0dcdb10c-dc92-430b-9f97-d2ee993b0152"),
                                QuestionId = new Guid("4b20b73a-2072-4d2b-a65f-b17923961da2"),
                                Value = "1",
                                Text = "Minimal difficulty—Sees large print, but not regular print in newspapers / books",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("df007610-7a05-4f94-befb-d89bd6188207"),
                                QuestionId = new Guid("4b20b73a-2072-4d2b-a65f-b17923961da2"),
                                Value = "2",
                                Text = "Moderate difficulty—Limited vision; not able to see newspaper headlines, but can identify objects",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5257938e-d013-49a8-9fb4-8ba58856873c"),
                                QuestionId = new Guid("4b20b73a-2072-4d2b-a65f-b17923961da2"),
                                Value = "3",
                                Text = "Severe difficulty—Object identification in question, but eyes appear to follow objects; sees only light, colours, shapes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f7a2567b-635c-4ca5-b1bd-c8acd7275dec"),
                                QuestionId = new Guid("4b20b73a-2072-4d2b-a65f-b17923961da2"),
                                Value = "4",
                                Text = "No vision",
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
                Id = new Guid("864e60f0-5877-466f-97cf-237444c930e0"),
                Index = "H",
                Description = "Cognition",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
                        Index = "1",
                        Name = "CognitiveSkillsForDailyDecisionMaking_H1",
                        Text = "COGNITIVE SKILLS FOR DAILY DECISION MAKING",
                        SubText = "Making decisions regarding tasks of daily life—e.g., when to get up or have meals, which clothes to wear or activities to do",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("df319d77-6982-4bd3-8baa-05de1368aaa5"),
                                QuestionId = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
                                Value = "0",
                                Text = "Independent—Decisions consistent, reasonable, and safe",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ecc28b27-4d2a-4506-9512-8ef02a1e7366"),
                                QuestionId = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
                                Value = "1",
                                Text = "Modified independence—Some difficulty in new situations only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("acd1e15a-67fb-4aba-8b7b-d56f908743c7"),
                                QuestionId = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
                                Value = "2",
                                Text = "Minimally impaired—In specific recurring situations, decisions become poor or unsafe; cues / supervision necessary at those times",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b9692d9a-dea3-4cd6-b73f-86003be98d2f"),
                                QuestionId = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
                                Value = "3",
                                Text = "Moderately impaired—Decisions consistently poor or unsafe; cues / supervision required at all times",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3c5444b4-1ad3-4c32-bf97-b7e2e26d507d"),
                                QuestionId = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
                                Value = "4",
                                Text = "Severely impaired—Never or rarely makes decisions",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2f84a49d-5df7-4745-9870-61cffb4389d6"),
                                QuestionId = new Guid("22d43d84-bb0f-44f8-9d6e-5ab972861cbe"),
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
                        Id = new Guid("e22a43e7-a181-422c-9600-9fe9e1137a39"),
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
                                Id = new Guid("bd895195-6854-4dee-97c6-39c5c3a62054"),
                                Index = "a",
                                Name = "ShortTermMemoryOk_H2a",
                                Text = "Short-term memory OK",
                                SubText = "Seems / appears to recall after 5 minutes",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("6c78a6b8-5cb2-4c98-bab4-28e81a8e1ecd"),
                                Index = "b",
                                Name = "ProceduralMemoryOk_H2b",
                                Text = "Procedural memory OK",
                                SubText = "Can perform all or almost all steps in a multitask sequence without cues",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("312f4c8a-5764-4ffc-8366-5d69e2ddc239"),
                                Index = "c",
                                Name = "SituationalMemoryOkBoth^^RecognizesCaregiversNamesFacesFrequentlyEncounteredAndKnowsLocationOfPlacesRegularlyVisitedBedr_H2c",
                                Text = "Situational memory OK—Both ^^ Recognizes caregivers’ names / faces frequently encountered AND knows location of places regularly visited (bedroom, dining room, activity room, therapy room)",
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
                        Id = new Guid("77b0f03f-334b-4ef2-a2d6-0e05d5c174c6"),
                        Index = "3",
                        Name = "PeriodicDisorderedThinkingOrAwareness_H3",
                        Text = "PERIODIC DISORDERED THINKING OR AWARENESS",
                        SubText = "Note: Accurate assessment requires conversations with staff, family, or others who have direct knowledge of the person’s behaviour over this time",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("00defef0-0ff7-4ba0-90f3-f3d9ee0e3712"),
                                Index = "a",
                                Name = "EasilyDistractedEGEpisodesOfDifficultyPayingAttentionGetsSidetracked_H3a",
                                Text = "Easily distracted—e.g., episodes of difficulty paying attention; gets sidetracked",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("abb55788-9138-4b28-a35c-abfe2d1c003d"),
                                Index = "b",
                                Name = "EpisodesOfDisorganizedSpeechEGSpeechIsNonsensicalIrrelevantOrRamblingFromSubjectToSubjectLosesTrainOfThought_H3b",
                                Text = "Episodes of disorganized speech—e.g., speech is nonsensical, irrelevant, or rambling from subject to subject; loses train of thought",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("f345a3ca-1e38-4d66-9983-db0afa46c43e"),
                                Index = "c",
                                Name = "MentalFunctionVariesOverTheCourseOfTheDayEGSometimesBetterSometimesWorse_H3c",
                                Text = "Mental function varies over the course of the day—e.g., sometimes better, sometimes worse",
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
                        Id = new Guid("883a9d96-4f8f-493c-aae3-fb86df45579c"),
                        Index = "4",
                        Name = "AcuteChangeInMentalStatusFromPersonSUsualFunctioning_H4",
                        Text = "ACUTE CHANGE IN MENTAL STATUS FROM PERSON’S USUAL FUNCTIONING",
                        SubText = "e.g., restlessness, lethargy, difficult to arouse, altered environmental perception",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("78442b34-3315-4a68-ac36-d95891286498"),
                                QuestionId = new Guid("883a9d96-4f8f-493c-aae3-fb86df45579c"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("98e163c8-8549-4fd3-8fb8-090987c94b43"),
                                QuestionId = new Guid("883a9d96-4f8f-493c-aae3-fb86df45579c"),
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
                        Id = new Guid("c5b8254d-f04f-4a0f-b465-bc92a1f782a8"),
                        Index = "5",
                        Name = "ChangeInDecisionMakingAsComparedTo90DaysAgoOrSinceLastAssessment_H5",
                        Text = "CHANGE IN DECISION MAKING AS COMPARED TO 90 DAYS AGO (or since last assessment)",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("4e887a65-7db0-471e-870a-fee1a14113a4"),
                                QuestionId = new Guid("c5b8254d-f04f-4a0f-b465-bc92a1f782a8"),
                                Value = "0",
                                Text = "Improved",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("37cd7a05-0067-4c18-8cc4-c92d4422bd0c"),
                                QuestionId = new Guid("c5b8254d-f04f-4a0f-b465-bc92a1f782a8"),
                                Value = "1",
                                Text = "No change",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8992e4ac-aae7-405c-a35b-85818037d4d1"),
                                QuestionId = new Guid("c5b8254d-f04f-4a0f-b465-bc92a1f782a8"),
                                Value = "2",
                                Text = "Declined",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3e5fb80e-6390-425b-bd14-a7793830e736"),
                                QuestionId = new Guid("c5b8254d-f04f-4a0f-b465-bc92a1f782a8"),
                                Value = "8",
                                Text = "Uncertain",
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
                Id = new Guid("72002721-2948-4700-877e-43242ed7624e"),
                Index = "I",
                Description = "Health Conditions",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("c893879e-95a0-4471-af6e-ca70231af1a2"),
                        Index = "1",
                        Name = "SelfReportedHealth_I1",
                        Text = "SELF-REPORTED HEALTH",
                        SubText = "Ask: “In general, how would you rate your health?”",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("a791d9b8-cacd-4865-b205-46e330928baf"),
                                QuestionId = new Guid("c893879e-95a0-4471-af6e-ca70231af1a2"),
                                Value = "0",
                                Text = "Excellent",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1f1e4745-211c-4569-989b-2331750ff55c"),
                                QuestionId = new Guid("c893879e-95a0-4471-af6e-ca70231af1a2"),
                                Value = "1",
                                Text = "Good",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("97204549-2ce0-4954-9469-560bebfe3564"),
                                QuestionId = new Guid("c893879e-95a0-4471-af6e-ca70231af1a2"),
                                Value = "2",
                                Text = "Fair",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("dfe9db4e-9970-4d85-85d6-4714ccae8b72"),
                                QuestionId = new Guid("c893879e-95a0-4471-af6e-ca70231af1a2"),
                                Value = "3",
                                Text = "Poor",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f29e568f-1116-44dc-bd6a-3e0bccaa2d46"),
                                QuestionId = new Guid("c893879e-95a0-4471-af6e-ca70231af1a2"),
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
                        Id = new Guid("5c88bbe7-24c3-4215-8e4e-32d3e0cad239"),
                        Index = "2",
                        Name = "ProblemFrequency_I2",
                        Text = "PROBLEM FREQUENCY",
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
                                Id = new Guid("efe46f36-37a8-4609-b4a3-f2a344fd091d"),
                                Index = "a",
                                Name = "BalanceDifficultOrUnableToMoveSelfToStandingPositionUnassisted_I2a",
                                Text = "Balance - Difficult or unable to move self to standing position unassisted",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("21d34074-4cce-4f18-bad6-b6dc82f4896b"),
                                Index = "b",
                                Name = "BalanceDifficultOrUnableToTurnSelfAroundAndFaceTheOppositeDirectionWhenStanding_I2b",
                                Text = "Balance - Difficult or unable to turn self around and face the opposite direction when standing",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("06ba951e-3f81-4e2d-ada4-fe638bff336d"),
                                Index = "c",
                                Name = "BalanceDizziness_I2c",
                                Text = "Balance - Dizziness",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("bed8f076-1b53-4bd1-a7e5-32f1ac340741"),
                                Index = "d",
                                Name = "BalanceUnsteadyGait_I2d",
                                Text = "Balance - Unsteady gait",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("bb0a2073-bca5-482d-a975-f3649dd3510d"),
                                Index = "e",
                                Name = "PsychiatricAbnormalThoughtProcessEGLooseningOfAssociationsBlockingFlightOfIdeasTangentialityCircumstantiality_I2e",
                                Text = "Psychiatric - Abnormal thought process—e.g., loosening of associations, blocking, flight of ideas, tangentiality, circumstantiality",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("c3d4fd60-cc09-4b82-8b03-8f8843c1d4ce"),
                                Index = "f",
                                Name = "PsychiatricDelusionsFixedFalseBeliefs_I2f",
                                Text = "Psychiatric - Delusions—Fixed false beliefs",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("28fa2a84-78ac-4d8d-b8ee-21b6bd4c2b37"),
                                Index = "g",
                                Name = "PsychiatricHallucinationsFalseSensoryPerceptions_I2g",
                                Text = "Psychiatric - Hallucinations—False sensory perceptions",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("77c48c0d-d536-4441-8c86-39f1b61138aa"),
                                Index = "h",
                                Name = "GiStatusAcidRefluxRegurgitationOfAcidFromStomachToThroat_I2h",
                                Text = "GI Status -Acid reflux—Regurgitation of acid from stomach to throat",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("1f6e1905-ead6-4473-a9a5-7484e88e06b5"),
                                Index = "i",
                                Name = "GiStatusConstipationNoBowelMovementIn3DaysOrDifficultPassageOfHardStool_I2i",
                                Text = "GI Status -Constipation—No bowel movement in 3 days or difficult passage of hard stool",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2c6e6a6d-0154-4f6d-b025-98ac34f42cb2"),
                                Index = "j",
                                Name = "GiStatusDiarrhea_I2j",
                                Text = "GI Status -Diarrhea",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d1a0dbe5-2f57-48eb-95ad-b8c3231ab34d"),
                                Index = "k",
                                Name = "GiStatusDryMouth_I2k",
                                Text = "GI Status -Dry mouth",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("beacd719-9dc8-431e-88b3-c4c2d3d5bc3e"),
                                Index = "l",
                                Name = "GiStatusHypersalivationOrDrooling_I2l",
                                Text = "GI Status -Hypersalivation or drooling",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b900a391-01a0-41a7-bb87-fb1e13d3ef01"),
                                Index = "m",
                                Name = "GiStatusIncreaseOrDecreaseInNormalAppetite_I2m",
                                Text = "GI Status -Increase or decrease in normal appetite",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a0eed1e3-48c4-4dee-be12-ea773102317b"),
                                Index = "n",
                                Name = "GiStatusVomiting_I2n",
                                Text = "GI Status -Vomiting",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("94678265-ae10-46f9-ae85-a9c2ee2a0243"),
                                Index = "o",
                                Name = "OtherAspiration_I2o",
                                Text = "Other - Aspiration",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e87d3750-5f6a-46e9-87b6-56b0e6ac2089"),
                                Index = "p",
                                Name = "OtherDaytimeDrowsinessOrSedation_I2p",
                                Text = "Other - Daytime drowsiness or sedation",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8e08bd55-9fb8-4a8c-bf6f-40ba92c6357b"),
                                Index = "q",
                                Name = "OtherHeadache_I2q",
                                Text = "Other - Headache",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a2fd4aa8-1530-4f51-ba15-839ce90fa972"),
                                Index = "r",
                                Name = "OtherPeripheralEdema_I2r",
                                Text = "Other - Peripheral edema",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("18eaa59a-86f8-48ec-86b6-3cfe81818db3"),
                                Index = "s",
                                Name = "OtherSeizures_I2s",
                                Text = "Other - Seizures",
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
                        Id = new Guid("3bd9216c-f67d-4b5d-a697-ecfae1460ecc"),
                        Index = "3",
                        Name = "DyspneaShortnessOfBreath_I3",
                        Text = "DYSPNEA (Shortness of breath)",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("43690a52-8569-444b-8860-ee880801fab7"),
                                QuestionId = new Guid("3bd9216c-f67d-4b5d-a697-ecfae1460ecc"),
                                Value = "0",
                                Text = "Absence of symptom",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("59d730f3-0513-413a-8bee-391c5230c779"),
                                QuestionId = new Guid("3bd9216c-f67d-4b5d-a697-ecfae1460ecc"),
                                Value = "1",
                                Text = "Absent at rest, but present when performed moderate activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("39093deb-dc54-45cf-a51f-fa32332d6f61"),
                                QuestionId = new Guid("3bd9216c-f67d-4b5d-a697-ecfae1460ecc"),
                                Value = "2",
                                Text = "Absent at rest, but present when performed normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5c479cea-bbfc-4adf-9144-a60e0c8ee799"),
                                QuestionId = new Guid("3bd9216c-f67d-4b5d-a697-ecfae1460ecc"),
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
                        Id = new Guid("7825a69a-ff06-4e79-bf8a-76bc3a8f45c5"),
                        Index = "4",
                        Name = "Fatigue_I4",
                        Text = "FATIGUE",
                        SubText = "Inability to complete normal daily activities- e.g., ADLs, IADLs",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("d6f512e9-f50d-4061-9a45-bdb9e751cecd"),
                                QuestionId = new Guid("7825a69a-ff06-4e79-bf8a-76bc3a8f45c5"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("61506e51-b76b-46bf-b08b-28bd9b3b669e"),
                                QuestionId = new Guid("7825a69a-ff06-4e79-bf8a-76bc3a8f45c5"),
                                Value = "1",
                                Text = "Minimal—Diminished energy but completes normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6d7c8548-83c3-470e-b60b-1ef509a092c2"),
                                QuestionId = new Guid("7825a69a-ff06-4e79-bf8a-76bc3a8f45c5"),
                                Value = "2",
                                Text = "Moderate—Due to diminished energy, UNABLE TO FINISH normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8c7bd98e-e2b8-4880-baaf-6b6df320f265"),
                                QuestionId = new Guid("7825a69a-ff06-4e79-bf8a-76bc3a8f45c5"),
                                Value = "3",
                                Text = "Severe—Due to diminished energy, UNABLE TO START SOME normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("cdfac11c-3817-45e8-9ce2-3aac6dd77ee2"),
                                QuestionId = new Guid("7825a69a-ff06-4e79-bf8a-76bc3a8f45c5"),
                                Value = "4",
                                Text = "Unable to commence any normal day-to-day activities—Due to diminished energy",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("7da04461-fb11-4122-a53c-9c6e2957d4bc"),
                        Index = "5",
                        Name = "ExtrapyramidalSymptomsDuringLast3Days_I5",
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
                                Id = new Guid("869e4701-add7-4c4d-9fa4-f1250b23a788"),
                                Index = "a",
                                Name = "Akathisia_I5a",
                                Text = "Akathisia",
                                SubText = "Subjective feeling of restlessness or need for movement",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("71e60d87-9022-4617-b7f0-ff819f78f66a"),
                                Index = "b",
                                Name = "Dyskinesia_I5b",
                                Text = "Dyskinesia",
                                SubText = "e.g., chewing, puckering movements of mouth; abnormal irregular movements of lips; rocking or writhing of trunk",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("faf5c8ae-0a74-418a-a562-45ed743064a5"),
                                Index = "c",
                                Name = "Tremor_I5c",
                                Text = "Tremor",
                                SubText = "Involuntary rhythmic movements of the fingers, limbs, head, mouth, tongue",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("1921fdb6-1f73-4417-9100-8201174e7f0b"),
                                Index = "d",
                                Name = "Bradykinesia_I5d",
                                Text = "Bradykinesia",
                                SubText = "Decrease in spontaneous movements (e.g., reduced body movement, or poverty of facial expression, gestures, speech)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("f9851b27-2c98-4238-a0c3-81c6001641f0"),
                                Index = "e",
                                Name = "Rigidity_I5e",
                                Text = "Rigidity",
                                SubText = "Resistance to flexion and extension of muscles (e.g., continuous or cogwheeling rigidity)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("1e7f7d77-c547-4837-ac40-dabf6c55ec94"),
                                Index = "f",
                                Name = "Dystonia_I5f",
                                Text = "Dystonia",
                                SubText = "Muscle hypertonicity (e.g., muscle spasms or stiffness, protruding tongue, upward deviation of the eyes)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("75c3b7e2-75ad-4916-9ffa-60283262ed34"),
                                Index = "g",
                                Name = "SlowShufflingGait_I5g",
                                Text = "Slow shuffling gait",
                                SubText = "Reduction in speed and stride length, usually with a decrease in pendular arm movement",
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
                        Id = new Guid("7410c1e4-4b8b-4cc4-a55d-507453db7397"),
                        Index = "6",
                        Name = "Falls_I6",
                        Text = "FALLS",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("9069cff8-3c6b-47e4-b59f-7982ae359740"),
                                QuestionId = new Guid("7410c1e4-4b8b-4cc4-a55d-507453db7397"),
                                Value = "0",
                                Text = "No fall in last 90 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("efd25493-5095-4134-bfc7-3c0bf02daa47"),
                                QuestionId = new Guid("7410c1e4-4b8b-4cc4-a55d-507453db7397"),
                                Value = "1",
                                Text = "No fall in last 30 days, but fell 31–90 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f5782346-ec74-4a19-abde-fda618a7d99d"),
                                QuestionId = new Guid("7410c1e4-4b8b-4cc4-a55d-507453db7397"),
                                Value = "2",
                                Text = "One fall in last 30 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c8bfc279-69fb-4fa5-b0b7-d8349a5c2bdc"),
                                QuestionId = new Guid("7410c1e4-4b8b-4cc4-a55d-507453db7397"),
                                Value = "3",
                                Text = "Two or more falls in last 30 days",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("bec85cd2-82dc-4b26-9067-2c45cec3d1ab"),
                        Index = "7",
                        Name = "PainSymptoms_I7",
                        Text = "PAIN SYMPTOMS",
                        SubText = "Note: Always ask the person about pain frequency, intensity, and control. Observe person and ask others who are in contact with the person.",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("98f3521d-fd99-4424-8d90-0676d3440ce1"),
                                Index = "a",
                                Name = "FrequencyWithWhichPersonComplainsOrShowsEvidenceOfPainIncludingGrimacingTeethClenchingMoaningWithdrawalWhenTouchedOrOthe_I7a",
                                Text = "Frequency with which person complains or shows evidence of pain (including grimacing, teeth clenching, moaning, withdrawal when touched, or other nonverbal signs suggesting pain)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4e1ac1f5-689e-4bf0-a9dd-dd538acb00c9"),
                                Index = "b",
                                Name = "IntensityOfHighestLevelOfPainPresent_I7b",
                                Text = "Intensity of highest level of pain present",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("88ce3c01-ec28-4e2a-b844-77932c7cdf88"),
                                Index = "c",
                                Name = "ConsistencyOfPain_I7c",
                                Text = "Consistency of pain",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("cf7ad530-982b-43d6-a536-d35a0a9c0951"),
                                Index = "d",
                                Name = "PainControlAdequacyOfCurrentTherapeuticRegimenToControlPainFromPersonSPointOfView_I7d",
                                Text = "Pain control—Adequacy of current therapeutic regimen to control pain (from person’s point of view)",
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
                        Id = new Guid("95293dd0-b83b-4a8c-9bc6-b79ae51707ba"),
                        Index = "8",
                        Name = "ScheduledToileting_I8",
                        Text = "SCHEDULED TOILETING",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("5871a93d-22c9-4ad6-b18a-6838bbaa1e5d"),
                                QuestionId = new Guid("95293dd0-b83b-4a8c-9bc6-b79ae51707ba"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b2ff40dd-f21f-4ad3-adc4-91134d9b314a"),
                                QuestionId = new Guid("95293dd0-b83b-4a8c-9bc6-b79ae51707ba"),
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
                        Id = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                        Index = "9",
                        Name = "BladderContinence_I9",
                        Text = "BLADDER CONTINENCE",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("e3df04ec-20c1-4b02-97dc-66c55fcffffc"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "0",
                                Text = "Continent—Complete control; DOES NOT USE any type of catheter or other urinary collection device",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ead12d23-2dfc-4bc6-9bf9-38b228d07e3c"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "1",
                                Text = "Control with any catheter or ostomy over last 3 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ee76e82a-caef-4f92-b936-d98f6c19d8d5"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "2",
                                Text = "Infrequently incontinent—Not incontinent over last 3 days, but does have incontinent episodes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5e4423f6-4734-4f5b-a921-c14b86037c6c"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "3",
                                Text = "Occasionally incontinent—Less than daily",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("549a1081-8d93-47a0-8f18-c57dfd6948f2"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "4",
                                Text = "Frequently incontinent—Daily, but some control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b31b0f13-49df-4780-adf7-26fd37504d91"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "5",
                                Text = "Incontinent—No control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("caac93eb-6555-4aa4-882d-b83ae37aa7a4"),
                                QuestionId = new Guid("902e6821-1c38-48b1-8cb8-b2f58d94ee3d"),
                                Value = "8",
                                Text = "Did not occur—No urine output from bladder in last 3 days",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                        Index = "10",
                        Name = "BowelContinence_I10",
                        Text = "BOWEL CONTINENCE",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("ee336648-fec1-4b16-8505-a272b548cc9d"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "0",
                                Text = "Continent—Complete control; DOES NOT USE any type of ostomy device",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2f3b8245-d511-4c1c-b4cf-6713cf2dbf4d"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "1",
                                Text = "Control with ostomy—Control with ostomy device over last 3 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5bca9a5a-5c17-4e04-b7ea-27acfdd0fbe9"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "2",
                                Text = "Infrequently incontinent—Not incontinent over last 3 days, but does have incontinent episodes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("023c46ad-ebf6-42e5-af8e-95d18c52817a"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "3",
                                Text = "Occasionally incontinent—Less than daily",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ef9fb42a-01dd-4e87-b6cd-1bf96c4ffb50"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "4",
                                Text = "Frequently incontinent—Daily, but some control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9488e60e-6b63-42f4-8f21-c907cfb72d95"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "5",
                                Text = "Incontinent—No control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8d9dd184-600e-4648-ba85-0a79d78df5bc"),
                                QuestionId = new Guid("7113e373-cb62-4c39-9807-06097cbde0cd"),
                                Value = "8",
                                Text = "Did not occur—No bowel movement in last 3 days",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                        Index = "11",
                        Name = "MostSeverePressureUlcer_I11",
                        Text = "MOST SEVERE PRESSURE ULCER",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("fe3463fb-0d29-43cf-8cb9-fd1ef6fa1c1c"),
                                QuestionId = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                                Value = "0",
                                Text = "No pressure ulcer",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f4568ef9-2778-4c49-bdda-6fd1b3f76df6"),
                                QuestionId = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                                Value = "1",
                                Text = "Any area of persistent skin redness",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e7ac8bf8-1926-4aac-8e82-1e683365de6b"),
                                QuestionId = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                                Value = "2",
                                Text = "Partial loss of skin layers",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6f62c4db-f000-45bf-b5d6-8934ee5b8292"),
                                QuestionId = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                                Value = "3",
                                Text = "Deep craters in the skin",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bbbb2c6f-8fad-4d21-afa2-ac0bd10c5ffe"),
                                QuestionId = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                                Value = "4",
                                Text = "Breaks in skin exposing muscle or bone",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b510fbde-7b41-4e02-b8b8-5ac6eae0cfff"),
                                QuestionId = new Guid("d11f2ef7-6243-4995-bdf6-a046291fc80d"),
                                Value = "5",
                                Text = "Not codeable—e.g., necrotic eschar predominant",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("aa9dffc3-be23-4aa1-bed7-4c191359db01"),
                        Index = "12",
                        Name = "PresenceOfSkinUlcerOtherThanPressureUlcer_I12",
                        Text = "PRESENCE OF SKIN ULCER OTHER THAN PRESSURE ULCER",
                        SubText = "e.g., venous ulcer, arterial ulcer, mixed venous-arterial ulcer, diabetic foot ulcer",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("725502d7-a380-497e-8963-f47f8d4387f7"),
                                QuestionId = new Guid("aa9dffc3-be23-4aa1-bed7-4c191359db01"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("01dcfa2c-21ac-424b-bf3c-c192f5a76c2a"),
                                QuestionId = new Guid("aa9dffc3-be23-4aa1-bed7-4c191359db01"),
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
                        Id = new Guid("219eb27d-b17e-457e-b80d-ae5b2e2afabc"),
                        Index = "13",
                        Name = "MajorSkinProblems_I13",
                        Text = "MAJOR SKIN PROBLEMS",
                        SubText = "e.g., lesions, second- or third-degree burns, healing surgical wounds",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("dd3e9740-e650-4458-aa68-54190c86fc21"),
                                QuestionId = new Guid("219eb27d-b17e-457e-b80d-ae5b2e2afabc"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("321328f0-2db6-40b1-a43f-0e745fbf97a3"),
                                QuestionId = new Guid("219eb27d-b17e-457e-b80d-ae5b2e2afabc"),
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
                        Id = new Guid("689797c5-26ae-42d9-b45c-f06fd41a56b4"),
                        Index = "14",
                        Name = "OtherSkinConditionsOrChangesInSkinCondition_I14",
                        Text = "OTHER SKIN CONDITIONS OR CHANGES IN SKIN CONDITION",
                        SubText = "e.g., bruises, rashes, itching, mottling, herpes zoster, intertrigo, eczema",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("04ea954c-8ea3-471c-b0c0-12c979be47d3"),
                                QuestionId = new Guid("689797c5-26ae-42d9-b45c-f06fd41a56b4"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e9d24b3a-16f7-407f-bf10-dfac56ee3218"),
                                QuestionId = new Guid("689797c5-26ae-42d9-b45c-f06fd41a56b4"),
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
                        Id = new Guid("1d315a5f-bdb4-47cf-b643-69da677a57f1"),
                        Index = "15",
                        Name = "FootProblems_I15",
                        Text = "FOOT PROBLEMS",
                        SubText = "e.g., bunions, hammertoes, overlapping toes, structural problems, infections, ulcers",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("0795a707-86c7-4f52-9768-e0bc8b572a47"),
                                QuestionId = new Guid("1d315a5f-bdb4-47cf-b643-69da677a57f1"),
                                Value = "0",
                                Text = "No foot problems",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e24e1ae9-e4cd-4f19-baf0-2af7f7562848"),
                                QuestionId = new Guid("1d315a5f-bdb4-47cf-b643-69da677a57f1"),
                                Value = "1",
                                Text = "Foot problems, no limitation in walking",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("06fb869f-7891-45ab-95e9-a1336867ebee"),
                                QuestionId = new Guid("1d315a5f-bdb4-47cf-b643-69da677a57f1"),
                                Value = "2",
                                Text = "Foot problems limit walking",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("10e8b47c-3ffe-4539-84ca-955266b72979"),
                                QuestionId = new Guid("1d315a5f-bdb4-47cf-b643-69da677a57f1"),
                                Value = "3",
                                Text = "Foot problems prevent walking",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("983ea418-34e2-416e-9140-33b6557cde65"),
                                QuestionId = new Guid("1d315a5f-bdb4-47cf-b643-69da677a57f1"),
                                Value = "4",
                                Text = "Foot problems, does not walk for other reasons",
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
                Id = new Guid("e3fada8e-540a-480c-b1a8-79dd933f25cc"),
                Index = "J",
                Description = "Independence in Everyday Activities",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("831a342d-afb6-4583-aa9b-dd8d26e6669e"),
                        Index = "1",
                        Name = "IadlSelfPerformanceAndCapacity_J1",
                        Text = "IADL SELF-PERFORMANCE AND CAPACITY",
                        SubText = "Code for PERFORMANCE in routine activities around the home or in the community during the LAST 3 DAYS",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("16fa0c3b-6bbb-4a06-b88f-04026b5e33f8"),
                                Index = "a",
                                Name = "MealPreparation_J1a",
                                Text = "Meal preparation",
                                SubText = "How meals are prepared (e.g., planning meals, assembling ingredients, cooking, setting out food and utensils)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("3b1f40aa-03be-4949-b5de-13d64a14a491"),
                                Index = "b",
                                Name = "OrdinaryHousework_J1b",
                                Text = "Ordinary housework",
                                SubText = "How ordinary work around the house is performed e.g., doing dishes, dusting, making bed, tidying up, laundry",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d6de2d3a-07eb-4136-a1a5-393c3a302232"),
                                Index = "c",
                                Name = "ManagingFinances_J1c",
                                Text = "Managing finances",
                                SubText = "How bills are paid, chequebook is balanced, household expenses are budgeted, credit card account is monitored",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("888e380f-9eb5-4041-98e7-4831ed30f3a4"),
                                Index = "d",
                                Name = "ManagingMedications_J1d",
                                Text = "Managing medications",
                                SubText = "How medications are managed e.g., remembering to take medicines, opening bottles, taking correct drug dosages, giving injections, applying ointments",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2064d610-dc88-4d26-adcd-31f49bcca603"),
                                Index = "e",
                                Name = "PhoneUse_J1e",
                                Text = "Phone use",
                                SubText = "How telephone calls are made or received (with assistive devices such as large numbers on telephone, amplification as needed)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("f8f5b2e7-4a3c-41fc-957a-4af307ac1b20"),
                                Index = "f",
                                Name = "Stairs_J1f",
                                Text = "Stairs",
                                SubText = "How manages full flight of stairs (12–14 stairs)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d0ec3733-acb2-44cf-bcc6-b26c1edcc499"),
                                Index = "g",
                                Name = "Shopping_J1g",
                                Text = "Shopping",
                                SubText = "How shopping for food and household items is performed (e.g., selecting items, paying money)—EXCLUDE TRANSPORTATION",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8f31dbcc-e728-4681-ba60-ae7f931db6cb"),
                                Index = "h",
                                Name = "Transportation_J1h",
                                Text = "Transportation",
                                SubText = "How travels by public transportation (navigating system, paying fare) or driving self (including getting out of house, in and out of vehicles)",
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
                        Id = new Guid("7c6aca67-44a8-4ca9-8949-2f905c13fac4"),
                        Index = "2",
                        Name = "IadlCapacity_J2",
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
                                Id = new Guid("0ffb5e84-81d3-4d04-a82a-f563e3ef1358"),
                                Index = "a",
                                Name = "MealPreparation_J2a",
                                Text = "Meal preparation",
                                SubText = "How meals are prepared (e.g., planning meals, assembling ingredients, cooking, setting out food and utensils)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b8a548c0-1785-495b-9bb4-d6e48bc463d4"),
                                Index = "b",
                                Name = "OrdinaryHousework_J2b",
                                Text = "Ordinary housework",
                                SubText = "How ordinary work around the house is performed e.g., doing dishes, dusting, making bed, tidying up, laundry",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("5f8d6856-c39d-4185-aaf2-18ba7c90ba56"),
                                Index = "c",
                                Name = "ManagingFinances_J2c",
                                Text = "Managing finances",
                                SubText = "How bills are paid, chequebook is balanced, household expenses are budgeted, credit card account is monitored",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("661fd57d-06bf-4f9f-b40c-6b788f39e872"),
                                Index = "d",
                                Name = "ManagingMedications_J2d",
                                Text = "Managing medications",
                                SubText = "How medications are managed e.g., remembering to take medicines, opening bottles, taking correct drug dosages, giving injections, applying ointments",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("665fe131-0824-46dc-a994-c624226510dc"),
                                Index = "e",
                                Name = "PhoneUse_J2e",
                                Text = "Phone use",
                                SubText = "How telephone calls are made or received (with assistive devices such as large numbers on telephone, amplification as needed)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e19fe759-60d8-48b4-95a5-f102b023afff"),
                                Index = "f",
                                Name = "Stairs_J2f",
                                Text = "Stairs",
                                SubText = "How manages full flight of stairs (12–14 stairs)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("843a37ff-3016-42ff-8e18-797c6f271314"),
                                Index = "g",
                                Name = "Shopping_J2g",
                                Text = "Shopping",
                                SubText = "How shopping for food and household items is performed (e.g., selecting items, paying money)—EXCLUDE TRANSPORTATION",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("431c5a38-9fc3-4a98-bb26-b5012182e303"),
                                Index = "h",
                                Name = "Transportation_J2h",
                                Text = "Transportation",
                                SubText = "How travels by public transportation (navigating system, paying fare) or driving self (including getting out of house, in and out of vehicles)",
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
                        Id = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                        Index = "3",
                        Name = "WorkPerformance_J3",
                        Text = "WORK - PERFORMANCE",
                        SubText = "Code performance (P) regarding job-related activities, including both cognitive (e.g., planning, sequencing of tasks, adherence to schedules) and physical aspects (e.g., strength, coordination, stamina)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("9487234d-fcf9-4261-8b6f-f1784bcddc17"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "0",
                                Text = "Independent—No help, set-up, or supervision",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a3bb24dc-93f6-44b3-a72a-a3ae9723b475"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "1",
                                Text = "Set-up help only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("36f971b0-efbf-40a0-9081-6e6f43244ee6"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "2",
                                Text = "Supervision—Oversight / cueing",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e4af5b29-6bdc-4251-874a-8a1d2846b278"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "3",
                                Text = "Limited assistance—Help on some occasions",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("49f0b29e-8dcf-46c5-8e0e-bd25622e9038"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "4",
                                Text = "Extensive assistance—Help throughout task, but performs 50% or more of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0432f437-ab35-4a1e-9fc6-25eab3f65f1c"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "5",
                                Text = "Maximal assistance—Help throughout task, but performs less than 50% of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5a96b1e8-cd50-4881-9dab-69042c95740b"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "6",
                                Text = "Total dependence—Full performance by others during entire period",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8fa31585-7593-4501-87fd-36bd4ecb4a5b"),
                                QuestionId = new Guid("16700822-3bc2-4800-8ca0-dd9bed08d8e9"),
                                Value = "8",
                                Text = "Activity did not occur—During entire period (DO NOT USE THIS CODE IN SCORING CAPACITY)",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                        Index = "4",
                        Name = "WorkCapacity_J4",
                        Text = "WORK - CAPACITY",
                        SubText = "Code capacity (C) regarding job-related activities, including both cognitive (e.g., planning, sequencing of tasks, adherence to schedules) and physical aspects (e.g., strength, coordination, stamina)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("f819430d-901d-4e9c-8c32-c363f9e9b250"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "0",
                                Text = "Independent—No help, set-up, or supervision",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5ba778dc-0d46-4cc3-a846-622e2218089c"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "1",
                                Text = "Set-up help only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0428b7dc-c884-4d15-a53c-b6ae617f8e2a"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "2",
                                Text = "Supervision—Oversight / cueing",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c4e44d52-31e4-4eb7-8e41-f5b861616547"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "3",
                                Text = "Limited assistance—Help on some occasions",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2e6d77bb-c1a8-4abb-a81c-46c1e6002fd6"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "4",
                                Text = "Extensive assistance—Help throughout task, but performs 50% or more of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4f2d96d2-cd42-4c7a-941f-28fc1ace2e7d"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "5",
                                Text = "Maximal assistance—Help throughout task, but performs less than 50% of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("02eac783-458b-499a-91bc-d09683f82778"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "6",
                                Text = "Total dependence—Full performance by others during entire period",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3284e361-4822-4481-9cd8-7ebad3d646a8"),
                                QuestionId = new Guid("a7762688-9981-439a-807c-cf6a252adc10"),
                                Value = "8",
                                Text = "Activity did not occur—During entire period (DO NOT USE THIS CODE IN SCORING CAPACITY)",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("342d80d9-bb4e-4704-b8cb-3415714466d6"),
                        Index = "5",
                        Name = "AdlSelfPerformance_J5",
                        Text = "ADL SELF-PERFORMANCE",
                        SubText = "Consider all episodes over 3-day period. If all episodes are performed at the same level, score ADL at that level. If any episodes at level 6, and others less dependent, score ADL as 5. Otherwise, focus on the three most dependent episodes (or all episodes if performed fewer than three times). If most dependent episode is 1, score ADL as 1. If not, score ADL as least dependent of those episodes in range 2–5.",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("0ca8ae1c-65ac-4749-b750-fa40ba3f9cae"),
                                Index = "a",
                                Name = "BathingHowTakesAFullBodyBathShower_J5a",
                                Text = "Bathing—How takes a full-body bath / shower",
                                SubText = "Includes how transfers in and out of tub or shower AND how each part of body is bathed: arms, upper and lower legs, chest, abdomen, perineal area—EXCLUDE WASHING OF BACK AND HAIR",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("0240e753-35fd-4460-b74c-6307174b6e8e"),
                                Index = "b",
                                Name = "PersonalHygieneHowManagesPersonalHygieneIncludingCombingHairBrushingTeethShavingApplyingMakeUpWashingAndDryingFaceAndHan_J5b",
                                Text = "Personal hygiene—How manages personal hygiene, including combing hair, brushing teeth, shaving, applying make-up, washing and drying face and hands",
                                SubText = "EXCLUDE BATHS AND SHOWERS",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("5aeeac36-725c-495b-bd9e-d31fa71ed5fc"),
                                Index = "c",
                                Name = "DressingUpperBodyHowDressesAndUndressesStreetClothesUnderwearAboveTheWaist_J5c",
                                Text = "Dressing upper body—How dresses and undresses (street clothes, underwear) above the waist",
                                SubText = "including prostheses, orthotics, fasteners, pullovers, etc.",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b3613235-044f-4dc3-a0f0-c0b7df4f7102"),
                                Index = "d",
                                Name = "DressingLowerBodyHowDressesAndUndressesStreetClothesUnderwearFromTheWaistDown_J5d",
                                Text = "Dressing lower body—How dresses and undresses (street clothes, underwear) from the waist down",
                                SubText = "including prostheses, orthotics, belts, pants, skirts, shoes, fasteners, etc.",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("065df841-4b26-40a6-95ca-ee8f90defc43"),
                                Index = "e",
                                Name = "Walking_J5e",
                                Text = "Walking",
                                SubText = "How walks between locations on same floor indoors",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("3da26e97-5487-4676-934f-374357b3035c"),
                                Index = "f",
                                Name = "Locomotion_J5f",
                                Text = "Locomotion",
                                SubText = "How moves between locations on same floor (walking or wheeling). If in wheelchair, self-sufficiency once in chair",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("fa36b013-9abe-44bc-b93b-2518ddfb3cd4"),
                                Index = "g",
                                Name = "TransferToilet_J5g",
                                Text = "Transfer toilet",
                                SubText = "How moves on and off toilet or commode",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("26c8efe7-edae-416f-b242-774cd25af322"),
                                Index = "h",
                                Name = "ToiletUse_J5h",
                                Text = "Toilet use",
                                SubText = "How uses the toilet room (or commode, bedpan, urinal), cleanses self after toilet use or incontinent episode(s), changes bed pad, manages ostomy or catheter, adjusts clothes—EXCLUDE TRANSFER ON AND OFF TOILET",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("41ccaae7-bdba-45ab-a535-a511c70c3b2d"),
                                Index = "i",
                                Name = "BedMobility_J5i",
                                Text = "Bed mobility",
                                SubText = "How moves to and from lying position, turns from side to side, and positions body while in bed",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a1f0682b-913d-4557-83cc-0bf086191b75"),
                                Index = "j",
                                Name = "Eating_J5j",
                                Text = "Eating",
                                SubText = "How eats and drinks (regardless of skill). Includes intake of nourishment by other means (e.g., tube feeding, total parenteral nutrition)",
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
                        Id = new Guid("e5205ade-39d0-4bd1-89b9-dcdb170e1993"),
                        Index = "6",
                        Name = "PrimaryModeOfLocomotion_J6",
                        Text = "PRIMARY MODE OF LOCOMOTION",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("5b5c165a-e0b1-40be-9d9f-b374a4afbc92"),
                                QuestionId = new Guid("e5205ade-39d0-4bd1-89b9-dcdb170e1993"),
                                Value = "0",
                                Text = "Walking, no assistive device",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("69b0f1dc-1a7d-46a9-826a-37418f5e0168"),
                                QuestionId = new Guid("e5205ade-39d0-4bd1-89b9-dcdb170e1993"),
                                Value = "1",
                                Text = "Walking, uses assistive device—e.g., cane, walker, crutch, pushing wheelchair",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("77d3e1ec-dc20-49fb-892e-1d119f45acea"),
                                QuestionId = new Guid("e5205ade-39d0-4bd1-89b9-dcdb170e1993"),
                                Value = "2",
                                Text = "Wheelchair, scooter",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a696142a-e559-4b97-a908-6f970413a2a3"),
                                QuestionId = new Guid("e5205ade-39d0-4bd1-89b9-dcdb170e1993"),
                                Value = "3",
                                Text = "Bed-bound",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                        Index = "7",
                        Name = "DistanceWheeledSelf_J7",
                        Text = "DISTANCE WHEELED SELF",
                        SubText = "Farthest distance wheeled self at one time in the LAST 3 DAYS (includes independent use of motorized wheelchair)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("cd3387df-f87f-4867-8add-57810bd0c754"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "0",
                                Text = "Wheeled by others",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b27833a8-ecb8-476f-8950-8a97ff355242"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "1",
                                Text = "Used motorized wheelchair / scooter",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3c7a5585-7959-40d4-801a-a241fee9b7e7"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "2",
                                Text = "Wheeled self less than 5 metres (under 15 feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bacf14b1-95cd-4a2c-833d-865d0e151ad5"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "3",
                                Text = "Wheeled self 5–49 metres (15–149 feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b4aba896-6d2a-4d95-a409-a6bcb0b5c27c"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "4",
                                Text = "Wheeled self 50–99 metres (150–299 feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("398b5f43-c0dd-4c64-bd17-3cdb24cd4c5e"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "5",
                                Text = "Wheeled self 100+ metres (300+ feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e50a016a-5ef3-416e-96a8-c65d768c846d"),
                                QuestionId = new Guid("8f5f5d94-b092-4207-b5df-98e1e138a62f"),
                                Value = "8",
                                Text = "Did not use wheelchair",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("dbea17e3-e3ae-4951-9316-935e9551428a"),
                        Index = "8",
                        Name = "PhysicallyRestrained_J8",
                        Text = "PHYSICALLY RESTRAINED",
                        SubText = "Limbs restrained, chair prevents rising",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("a294adbf-ce6d-453a-9ac5-214ecd3a0ce1"),
                                QuestionId = new Guid("dbea17e3-e3ae-4951-9316-935e9551428a"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0477cafb-8bc9-4487-a054-b399d5f22070"),
                                QuestionId = new Guid("dbea17e3-e3ae-4951-9316-935e9551428a"),
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
                        Id = new Guid("63983474-1d31-452d-814b-701e6b6a26de"),
                        Index = "9",
                        Name = "PhysicalFunctionImprovementPotential_J9",
                        Text = "PHYSICAL FUNCTION IMPROVEMENT POTENTIAL",
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
                                Id = new Guid("059d354d-abf9-4b9c-99a8-fb9e2e62f73c"),
                                Index = "a",
                                Name = "PersonBelievesHeSheIsCapableOfImprovedPerformanceInPhysicalFunction_J9a",
                                Text = "Person believes he / she is capable of improved performance in physical function",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4c86fd48-8c37-400a-b483-78e3a1d9012a"),
                                Index = "b",
                                Name = "CareProfessionalBelievesPersonIsCapableOfImprovedPerformanceInPhysicalFunction_J9b",
                                Text = "Care professional believes person is capable of improved performance in physical function",
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
                        Id = new Guid("7eccff5a-1752-4c46-8cb6-c83e85f77197"),
                        Index = "10",
                        Name = "ChangeInAdlStatusAsComparedTo90DaysAgoOrSinceLastAssessmentIfLessThan90DaysAgo_J10",
                        Text = "CHANGE IN ADL STATUS AS COMPARED TO 90 DAYS AGO, OR SINCE LAST ASSESSMENT IF LESS THAN 90 DAYS AGO",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("a939deb9-788d-43f6-97a2-62f27db308be"),
                                QuestionId = new Guid("7eccff5a-1752-4c46-8cb6-c83e85f77197"),
                                Value = "0",
                                Text = "Improved",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7b795ad6-236f-4b20-8fb8-75b8024cdef2"),
                                QuestionId = new Guid("7eccff5a-1752-4c46-8cb6-c83e85f77197"),
                                Value = "1",
                                Text = "No change",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c540e1a9-79f9-45f2-941b-9b41961a0cf2"),
                                QuestionId = new Guid("7eccff5a-1752-4c46-8cb6-c83e85f77197"),
                                Value = "2",
                                Text = "Declined",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9f16545e-c5b5-4b7e-9781-1e2c6ad78818"),
                                QuestionId = new Guid("7eccff5a-1752-4c46-8cb6-c83e85f77197"),
                                Value = "8",
                                Text = "Uncertain",
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
                Id = new Guid("0fb083c2-9ac5-48ef-a2f3-5e770c79b9c4"),
                Index = "K",
                Description = "Oral and Nutritional Status",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("9f2c480f-9f41-4860-9a5b-4aa9701e5e82"),
                        Index = "1",
                        Name = "HeightAndWeight_K1",
                        Text = "HEIGHT AND WEIGHT",
                        SubText = "Record (a.) height in centimetres and (b.) weight in kilograms. Base weight on most recent measure in LAST 30 DAYS.",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("c6b4cada-4f24-4e05-9384-9ae5f1949443"),
                                Index = "a",
                                Name = "HeightCm_K1a",
                                Text = "Height (cm)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("dfdd25a3-9552-49e2-a06b-a106ff633427"),
                                Index = "b",
                                Name = "WeightKg_K1b",
                                Text = "Weight (kg)",
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
                        Id = new Guid("f4f34a1e-4db3-44b4-9161-50068c750903"),
                        Index = "2",
                        Name = "NutritionalIssues_K2",
                        Text = "NUTRITIONAL ISSUES",
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
                                Id = new Guid("d399eab9-d8b9-4a51-8d3e-3f1a8a94b17c"),
                                Index = "a",
                                Name = "WeightLoss_K2a",
                                Text = "Weight loss",
                                SubText = "Of 5% or more in LAST 30 DAYS, or 10% or more in LAST 180 DAYS",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("5335147d-212a-45fd-8b44-43e67df2e531"),
                                Index = "b",
                                Name = "WeightGain_K2b",
                                Text = "Weight gain",
                                SubText = "Of 5% or more in LAST 30 DAYS, or 10% or more in LAST 180 DAYS",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("125f0bf8-8a1e-43bf-b4f2-a58b9a11a7db"),
                                Index = "c",
                                Name = "FluidIntake_K2c",
                                Text = "Fluid intake",
                                SubText = "Less than 1,000 cc per day (less than four 8-oz. cups / day)",
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
                        Id = new Guid("58b793b4-a8d3-4ef8-ad6e-912e0e524c8b"),
                        Index = "3",
                        Name = "ChewingProblem_K3",
                        Text = "CHEWING PROBLEM",
                        SubText = "e.g., pain while eating",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("894d9537-9580-4f7c-a3f6-263c3686b8cb"),
                                QuestionId = new Guid("58b793b4-a8d3-4ef8-ad6e-912e0e524c8b"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("eebce022-13f9-4ca0-b7fa-fb1bd388df72"),
                                QuestionId = new Guid("58b793b4-a8d3-4ef8-ad6e-912e0e524c8b"),
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
                        Id = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                        Index = "4",
                        Name = "ModeOfNutritionalIntake_K4",
                        Text = "MODE OF NUTRITIONAL INTAKE",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("1fde170d-c2f1-48e4-8cd5-8632de7ecd76"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "0",
                                Text = "Normal—Swallows all types of foods",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("572de815-a5e7-4f83-a4d5-bccea3142655"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "1",
                                Text = "Modified independent—e.g., liquid is sipped, takes limited solid food, need for modification may be unknown",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ca1bbc98-7580-460a-bc32-9ceaff30297e"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "2",
                                Text = "Requires diet modification to swallow solid food—e.g., mechanical diet (e.g., pureed, minced) or only able to ingest specific foods",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b68e78f7-70a9-4c24-b4c9-8d9fd550be20"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "3",
                                Text = "Requires modification to swallow liquids—e.g., thickened liquids",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("223024b3-b3b7-4716-88a7-001c092e9b31"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "4",
                                Text = "Can swallow only puréed solids—AND—thickened liquids",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3b0cdc7b-f901-4636-858c-22ac68413db2"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "5",
                                Text = "Combined oral and parenteral or tube feeding",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3e2935b8-7d23-48fb-8c95-b0f99c975e59"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "6",
                                Text = "Nasogastric tube feeding only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c6e36158-f1be-497e-ba0e-bc125d69e51b"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "7",
                                Text = "Abdominal tube feeding—e.g., PEG tube",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5dbe2a96-ac65-4a59-9b23-7a6f8c414bb6"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "8",
                                Text = "Parenteral feeding only—Includes all types of parenteral feedings, such as total parenteral nutrition (TPN)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4228cd8f-e34a-47eb-a7ad-64f7c5b45432"),
                                QuestionId = new Guid("c1c98bb4-e3eb-4b69-bc9c-dddd8f966e0e"),
                                Value = "9",
                                Text = "Activity did not occur—During entire period",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("cf1d92d0-2e86-447b-bf80-8d74fbbee446"),
                        Index = "5",
                        Name = "DentalOrOral_K5",
                        Text = "DENTAL OR ORAL",
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
                                Id = new Guid("687807af-1b4f-454e-bde2-06cc52982e02"),
                                Index = "a",
                                Name = "WearsADentureRemovableProsthesis_K5a",
                                Text = "Wears a denture (removable prosthesis)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("c4de1d8a-d0eb-431f-984a-4667d5abffbf"),
                                Index = "b",
                                Name = "HasBrokenFragmentedLooseOrOtherwiseNonIntactNaturalTeeth_K5b",
                                Text = "Has broken, fragmented, loose, or otherwise non-intact natural teeth",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2770b583-5acd-462d-8dea-119094bd12fd"),
                                Index = "c",
                                Name = "PresentsWithGumSoftTissueInflammationOrBleedingAdjacentToNaturalTeethOrToothFragments_K5c",
                                Text = "Presents with gum (soft tissue) inflammation or bleeding adjacent to natural teeth or tooth fragments",
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
                Id = new Guid("3c6db281-66df-4423-a086-3292800ed36f"),
                Index = "L",
                Description = "Mood and Behaviour",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("bf7f7754-e23f-4312-9312-c6c67645853a"),
                        Index = "1",
                        Name = "IndicatorsOfPossibleDepressedAnxiousOrSadMood_L1",
                        Text = "INDICATORS OF POSSIBLE DEPRESSED, ANXIOUS, OR SAD MOOD",
                        SubText = "Code for indicators observed in last 3 days, irrespective of the assumed cause [Note: Whenever possible, ask person]",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("7c7c3a0a-e3ae-4a8c-ab4d-d32f896beb4b"),
                                Index = "a",
                                Name = "MoodCheerfulHappyFacialExpressionsEGSmilesOrLaughsAppearsRelaxed_L1a",
                                Text = "Mood - Cheerful, happy facial expressions—e.g., smiles or laughs, appears relaxed",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e1f37468-d0b7-40bc-b4e8-8871b11ff10f"),
                                Index = "b",
                                Name = "MoodSadPainedOrWorriedFacialExpressionsEGFurrowedBrowConstantFrowning_L1b",
                                Text = "Mood - Sad, pained, or worried facial expressions—e.g., furrowed brow, constant frowning",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("fd015925-fd44-4ac7-b720-a4ce89f7bc66"),
                                Index = "c",
                                Name = "MoodCryingTearfulness_L1c",
                                Text = "Mood - Crying, tearfulness",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("35c1d8e2-eac1-4438-bc84-2be29629ef52"),
                                Index = "d",
                                Name = "MoodMadePositiveStatementsEGIHaveALotToLookForwardToIAmHappyIEnjoyWhatIAmDoing_L1d",
                                Text = "Mood - Made positive statements—e.g., “I have a lot to look forward to; I am happy; I enjoy what I am doing”",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("6b0e4725-852f-41bf-b0c1-a499d7e5f820"),
                                Index = "e",
                                Name = "MoodMadeNegativeStatementsEGNothingMattersWouldRatherBeDeadWhatSTheUseRegretHavingLivedSoLongLetMeDie_L1e",
                                Text = "Mood - Made negative statements—e.g., “Nothing matters; Would rather be dead; What’s the use; Regret having lived so long; Let me die”",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("310e686a-3964-4ac8-9054-d349b828ba04"),
                                Index = "f",
                                Name = "MoodHyperarousalMotorExcitationUnusuallyHighActivityIncreasedReactivity_L1f",
                                Text = "Mood - Hyperarousal—Motor excitation; unusually high activity; increased reactivity",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("ce235990-e290-4e83-ae95-39b38c5cd492"),
                                Index = "g",
                                Name = "MoodIrritabilityMarkedIncreaseInBeingShortTemperedOrEasilyUpset_L1g",
                                Text = "Mood - Irritability—Marked increase in being short-tempered or easily upset",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8ccb0583-c618-4e00-b557-48099f4fbb45"),
                                Index = "h",
                                Name = "MoodPressuredSpeechOrRacingThoughtsRapidSpeechRapidTransitionFromTopicToTopic_L1h",
                                Text = "Mood - Pressured speech or racing thoughts—Rapid speech, rapid transition from topic to topic",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4dd50eb2-d609-45b3-b136-ca09fe25da6b"),
                                Index = "i",
                                Name = "MoodLabileAffectAffectFluctuatesFrequentlyWithOrWithoutAnExternalExplanation_L1i",
                                Text = "Mood - Labile affect—Affect fluctuates frequently with or without an external explanation",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("c1064c70-28ef-427b-a464-b0549c1348b9"),
                                Index = "j",
                                Name = "MoodFlatOrBluntedAffectIndifferenceNonResponsivenessHardToGetToSmileEtc_L1j",
                                Text = "Mood - Flat or blunted affect—Indifference, non-responsiveness, hard to get to smile, etc.",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4f4c49aa-17bb-4c56-a07d-0f93d45adfe1"),
                                Index = "k",
                                Name = "AnxietyRepetitiveAnxiousComplaintsConcernsNonHealthRelatedEGPersistentlySeeksAttentionReassuranceRegardingSchedulesMeals_L1k",
                                Text = "Anxiety - Repetitive anxious complaints / concerns (non-health related)—e.g., persistently seeks attention / reassurance regarding schedules, meals, laundry, clothing, relationships",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e62186e5-56b9-4e19-a95f-4288e96931d9"),
                                Index = "l",
                                Name = "AnxietyExpressionsIncludingNonverbalOfWhatAppearToBeUnrealisticFearsEGFearOfBeingAbandonedBeingLeftAloneBeingWithOthersI_L1l",
                                Text = "Anxiety - Expressions, including nonverbal, of what appear to be unrealistic fears—e.g., fear of being abandoned, being left alone, being with others; intense fear of specific objects or situations",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e7072c4a-3989-410a-8826-9289aa365f94"),
                                Index = "m",
                                Name = "AnxietyObsessiveThoughtsUnwantedIdeasOrThoughtsThatCannotBeEliminated_L1m",
                                Text = "Anxiety - Obsessive thoughts—Unwanted ideas or thoughts that cannot be eliminated",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("27429ea1-56d1-4a59-8812-b6c21d2b4a45"),
                                Index = "n",
                                Name = "AnxietyCompulsiveBehaviourEGHandWashingRepetitiveCheckingOfRoomCounting_L1n",
                                Text = "Anxiety - Compulsive behaviour—e.g., hand washing, repetitive checking of room, counting",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("df406d56-75c4-46e3-adaf-6154b83019be"),
                                Index = "o",
                                Name = "AnxietyEpisodesOfPanicCascadeOfSymptomsOfFearAnxietyLossOfControl_L1o",
                                Text = "Anxiety - Episodes of panic—Cascade of symptoms of fear, anxiety, loss of control",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("38a534ca-eea6-4686-85c5-0c66d4f6eef9"),
                                Index = "p",
                                Name = "NegativeSymptomsExpressionsIncludingNonverbalOfALackOfPleasureInLifeAnhedoniaEGIDonTEnjoyAnythingAnymore_L1p",
                                Text = "Negative Symptoms - Expressions, including nonverbal, of a lack of pleasure in life (anhedonia)—e.g., “I don’t enjoy anything anymore”",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("3425c7b2-d329-41a6-b08d-6cc3d3433b43"),
                                Index = "q",
                                Name = "NegativeSymptomsWithdrawalFromActivitiesOfInterestEGLongStandingActivitiesBeingWithFamilyFriends_L1q",
                                Text = "Negative Symptoms - Withdrawal from activities of interest—e.g., long-standing activities, being with family / friends",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8900bf34-78d2-42a4-b3fe-d63cc32b980e"),
                                Index = "r",
                                Name = "NegativeSymptomsLackOfMotivationAbsenceOfSpontaneousGoalDirectedActivity_L1r",
                                Text = "Negative Symptoms - Lack of motivation—Absence of spontaneous goal-directed activity",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4b29c985-2d24-446c-a1d6-4d26c6167461"),
                                Index = "s",
                                Name = "NegativeSymptomsReducedSocialInteractions_L1s",
                                Text = "Negative Symptoms - Reduced social interactions",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a4a51f34-98fc-4b50-8fe7-e4e34d62445f"),
                                Index = "t",
                                Name = "OtherIndicatorsRepetitiveHealthComplaintsEGPersistentlySeeksMedicalAttentionIncessantConcernWithBodyFunctions_L1t",
                                Text = "Other Indicators - Repetitive health complaints—e.g., persistently seeks medical attention, incessant concern with body functions",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("631d1731-ca1f-4065-8040-21b1f4e3052c"),
                                Index = "u",
                                Name = "OtherIndicatorsRecurrentStatementsThatSomethingTerribleIsAboutToHappenEGBelievesHeOrSheIsAboutToDieHaveAHeartAttack_L1u",
                                Text = "Other Indicators - Recurrent statements that something terrible is about to happen—e.g., believes he or she is about to die, have a heart attack",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("7dd80ae0-5ef3-4685-bd7a-6bc3bcf28232"),
                                Index = "v",
                                Name = "OtherIndicatorsPersistentAngerWithSelfOrOthersEGEasilyAnnoyedAngerAtCareReceived_L1v",
                                Text = "Other Indicators - Persistent anger with self or others—e.g., easily annoyed, anger at care received",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("6a3e76c3-6288-48c4-a686-483127f186dd"),
                                Index = "w",
                                Name = "OtherIndicatorsUnusualOrAbnormalPhysicalMovementsUnusualFacialExpressionsOrMannerismsPeculiarMotorBehaviourOrBodyPosturi_L1w",
                                Text = "Other Indicators - Unusual or abnormal physical movements—Unusual facial expressions or mannerisms; peculiar motor behaviour or body posturing (e.g., stereotypies, waxy flexibility)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("6b50898a-0289-4254-9324-ace4390ce0fe"),
                                Index = "x",
                                Name = "OtherIndicatorsHygieneUnusuallyPoorHygieneUnkemptDishevelled_L1x",
                                Text = "Other Indicators - Hygiene—Unusually poor hygiene, unkempt, dishevelled",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4b1c6b9c-7ae3-4d13-8067-65faeed446ea"),
                                Index = "y",
                                Name = "OtherIndicatorsDifficultyFallingAsleepOrStayingAsleepWakingUpTooEarlyRestlessnessNonrestfulSleep_L1y",
                                Text = "Other Indicators - Difficulty falling asleep or staying asleep; waking up too early; restlessness; nonrestful sleep",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b5b98783-f806-4f28-abc0-5a6a896a248d"),
                                Index = "z",
                                Name = "OtherIndicatorsTooMuchSleepExcessiveAmountOfSleepThatInterferesWithPersonSNormalFunctioning_L1z",
                                Text = "Other Indicators - Too much sleep—Excessive amount of sleep that interferes with person’s normal functioning",
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
                        Id = new Guid("3d80fb26-f1d9-40dd-bf54-8eb30756d1b0"),
                        Index = "2",
                        Name = "SelfReportedMood_L2",
                        Text = "SELF-REPORTED MOOD",
                        SubText = "Ask: “In the last 3 days, how often have you felt . . .”",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("71c91c0a-cc6e-4ac2-a865-4468058202db"),
                                Index = "a",
                                Name = "LittleInterestOrPleasureInThingsYouNormallyEnjoy?_L2a",
                                Text = "Little interest or pleasure in things you normally enjoy?",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("6b77eebf-491a-4e7c-a96c-78d11fd0d58e"),
                                Index = "b",
                                Name = "AnxiousRestlessOrUneasy?_L2b",
                                Text = "Anxious, restless, or uneasy?",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("3a96807e-ceaa-4c5d-a04d-a8f7737badf8"),
                                Index = "c",
                                Name = "SadDepressedOrHopeless?_L2c",
                                Text = "Sad, depressed, or hopeless?",
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
                        Id = new Guid("4ce46912-23be-49a1-a25f-a13ceed23f6c"),
                        Index = "3",
                        Name = "AdjustedEasilyToChangesInRoutinesInLast30Days_L3",
                        Text = "ADJUSTED EASILY TO CHANGES IN ROUTINES IN LAST 30 DAYS",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("5ea0b0a4-9f36-4682-a084-dbe89aaa0f0f"),
                                QuestionId = new Guid("4ce46912-23be-49a1-a25f-a13ceed23f6c"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c1640c25-991c-4f20-a40f-e09ec622babc"),
                                QuestionId = new Guid("4ce46912-23be-49a1-a25f-a13ceed23f6c"),
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
                        Id = new Guid("5f907490-7bf1-4e28-ab75-d04fbf1101e0"),
                        Index = "4",
                        Name = "BehaviouralSymptoms_L4",
                        Text = "BEHAVIOURAL SYMPTOMS",
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
                                Id = new Guid("35617bb3-ccae-4fce-b4c1-2857e1e7e571"),
                                Index = "a",
                                Name = "Wandering_L4a",
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
                                Id = new Guid("c6a1e613-3864-4557-b3db-43f223b880df"),
                                Index = "b",
                                Name = "VerbalAbuse_L4b",
                                Text = "Verbal abuse",
                                SubText = "e.g., others were threatened, screamed at, cursed at",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("f1e4059b-1942-473f-972f-c8bde9aade40"),
                                Index = "c",
                                Name = "PhysicalAbuse_L4c",
                                Text = "Physical abuse",
                                SubText = "e.g., others were hit, shoved, scratched, sexually abused",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("b6ee866d-985a-4f49-b629-a74190f27086"),
                                Index = "d",
                                Name = "SociallyInappropriateOrDisruptiveBehaviour_L4d",
                                Text = "Socially inappropriate or disruptive behaviour",
                                SubText = "e.g., made disruptive sounds or noises, screamed out, smeared or threw food or feces, hoarded, rummaged through others’ belongings",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("169a1164-0188-4144-9742-a2c8c3be8f07"),
                                Index = "e",
                                Name = "InappropriatePublicSexualBehaviourOrPublicDisrobing_L4e",
                                Text = "Inappropriate public sexual behaviour or public disrobing",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("634942b4-46ed-4e28-b502-1e121741df5c"),
                                Index = "f",
                                Name = "ResistsCare_L4f",
                                Text = "Resists care",
                                SubText = "e.g., taking medications / injections, ADL assistance, eating",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8ee74f8c-fafc-4797-94f3-334cad3a16b9"),
                                Index = "g",
                                Name = "SelfInjuriousBehaviour_L4g",
                                Text = "Self-injurious behaviour",
                                SubText = "e.g., banging head on wall; pinching, biting, scratching, hitting, or punching self; pulling own hair",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("d10f048e-72a0-49f8-8f52-763935bc448e"),
                                Index = "h",
                                Name = "DestructiveBehaviour_L4h",
                                Text = "Destructive behaviour",
                                SubText = "e.g., throwing objects, turning over beds or tables, vandalism",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8e35b521-139c-4618-9c6e-e6393637c794"),
                                Index = "i",
                                Name = "OutburstOfAnger_L4i",
                                Text = "Outburst of anger",
                                SubText = "Intense flare-up of anger in reaction to a specific action or event (e.g., upset with decisions of others)",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2641235b-ea3c-4640-b0f1-0a4093ed14ec"),
                                Index = "j",
                                Name = "Echolalia_L4j",
                                Text = "Echolalia",
                                SubText = "Repeats the words spoken by others",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("bd5eecc1-521c-41b0-881d-06b94ca2dedd"),
                                Index = "k",
                                Name = "SelfTalk_L4k",
                                Text = "Self-talk",
                                SubText = "Talks to self",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("77e4a5d7-7805-4080-b026-28b446856647"),
                                Index = "l",
                                Name = "Pica_L4l",
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
                                Id = new Guid("ba9a649a-72ca-4396-94c9-c56e39e3b6a4"),
                                Index = "m",
                                Name = "Rumination_L4m",
                                Text = "Rumination",
                                SubText = "Regurgitation and re-chewing of previously swallowed food",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("fc377c10-02c2-41de-a538-138bf223812e"),
                                Index = "n",
                                Name = "Polydipsia_L4n",
                                Text = "Polydipsia",
                                SubText = "Inappropriate or excessive fluid consumption (e.g., drinks fluids many times during the day, drinks a huge amount at a time, refuses to stop drinking, drinks secretly from unusual sources)",
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
                        Id = new Guid("03223e3c-4017-4dde-90bf-7c32ff7d3970"),
                        Index = "5",
                        Name = "Violence_L5",
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
                                Id = new Guid("25938322-b206-4f8d-aa5a-40a04b396bc7"),
                                Index = "a",
                                Name = "IntimidationOfOthersOrThreatenedViolence_L5a",
                                Text = "Intimidation of others or threatened violence",
                                SubText = "e.g., threatening gestures or stance with no physical contact, shouting angrily, throwing furniture, explicit threats of violence",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a75908b9-2ef1-47d7-aec6-0b84f58e274c"),
                                Index = "b",
                                Name = "ViolenceToOthers_L5b",
                                Text = "Violence to others",
                                SubText = "Acts with purposeful, malicious, or vicious intent, resulting in physical harm to another (e.g., stabbing, choking, beating)",
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
                        Id = new Guid("6baf8886-32c9-4317-afda-eae60049df9a"),
                        Index = "6",
                        Name = "ExtremeBehaviourDisturbance_L6",
                        Text = "EXTREME BEHAVIOUR DISTURBANCE",
                        SubText = "History of extreme behaviour(s) that suggests serious risk of harm to self (e.g., severe self-mutilation) or others (e.g., fire setting, homicide)",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("3fe1d259-4e0f-46d7-a430-a2035a698a73"),
                                QuestionId = new Guid("6baf8886-32c9-4317-afda-eae60049df9a"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("00f761df-beb6-4f0e-a688-7c7ae024a466"),
                                QuestionId = new Guid("6baf8886-32c9-4317-afda-eae60049df9a"),
                                Value = "1",
                                Text = "Yes, but not exhibited in last 7 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("dbc3c665-e00f-4f41-9a12-f313d8998be7"),
                                QuestionId = new Guid("6baf8886-32c9-4317-afda-eae60049df9a"),
                                Value = "2",
                                Text = "Yes, exhibited in last 7 days",
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
                Id = new Guid("61b8cc90-a84a-45f9-9f64-618e4635a60d"),
                Index = "M",
                Description = "Medications",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("3c44faf3-e0cc-4460-9772-3b619e8f5796"),
                        Index = "1",
                        Name = "ListOfAllMedications_M1",
                        Text = "LIST OF ALL MEDICATIONS",
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
                        Id = new Guid("93cff65f-c1e2-4f7d-91aa-8844dddb112b"),
                        Index = "2",
                        Name = "AllergyToAnyDrug_M2",
                        Text = "ALLERGY TO ANY DRUG",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("7f48e8a4-ed4f-43fb-a215-ee1294161a63"),
                                QuestionId = new Guid("93cff65f-c1e2-4f7d-91aa-8844dddb112b"),
                                Value = "0",
                                Text = "No known drug allergies",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bad37c5c-4757-472b-a8df-c47a5844e3a3"),
                                QuestionId = new Guid("93cff65f-c1e2-4f7d-91aa-8844dddb112b"),
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
                        Id = new Guid("be408ff8-093c-4dbe-89a1-302273aa8802"),
                        Index = "3",
                        Name = "PhysicianReviewedPersonSMedicationsAsAWholeInLast180DaysOrSinceLastAssessment_M3",
                        Text = "PHYSICIAN REVIEWED PERSON’S MEDICATIONS AS A WHOLE IN LAST 180 DAYS OR SINCE LAST ASSESSMENT",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("32922769-1e83-49e1-862c-3b9703a04e97"),
                                QuestionId = new Guid("be408ff8-093c-4dbe-89a1-302273aa8802"),
                                Value = "0",
                                Text = "Discussed with at least one physician (or no medication taken)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("167780f4-8301-4a08-a5a4-298f21809205"),
                                QuestionId = new Guid("be408ff8-093c-4dbe-89a1-302273aa8802"),
                                Value = "1",
                                Text = "No single physician reviewed all medications",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("2625cf95-93f1-4be5-9979-c5c62ff85658"),
                        Index = "4",
                        Name = "AdherentWithMedicationsPrescribedByPhysician_M4",
                        Text = "ADHERENT WITH MEDICATIONS PRESCRIBED BY PHYSICIAN",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("dcef7101-7d4e-4de8-8f5f-78ea4ca8a889"),
                                QuestionId = new Guid("2625cf95-93f1-4be5-9979-c5c62ff85658"),
                                Value = "0",
                                Text = "Always adherent",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("be6c1e2a-223d-4299-81c8-636237dca7d8"),
                                QuestionId = new Guid("2625cf95-93f1-4be5-9979-c5c62ff85658"),
                                Value = "1",
                                Text = "Adherent 80% of time or more",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f5d1586d-ab15-418e-bfd8-b8b5b2b534e8"),
                                QuestionId = new Guid("2625cf95-93f1-4be5-9979-c5c62ff85658"),
                                Value = "2",
                                Text = "Adherent less than 80% of time, including failure to purchase prescribed medications",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7d0c781c-b285-44a5-8dfe-8f4d2aed5fc7"),
                                QuestionId = new Guid("2625cf95-93f1-4be5-9979-c5c62ff85658"),
                                Value = "8",
                                Text = "No medications prescribed",
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
                Id = new Guid("6079ac03-84b7-4e3f-b12b-012cf85688ac"),
                Index = "N",
                Description = "Supports and Services",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("798235fb-74fa-4a7f-a2a2-aee96d748fd4"),
                        Index = "1",
                        Name = "Prevention_N1",
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
                                Id = new Guid("d6f02174-1b3b-4404-bbc9-5378e142dccd"),
                                Index = "a",
                                Name = "CompletePhysicalExaminationInLastYear_N1a",
                                Text = "Complete physical examination in LAST YEAR",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("24fde0a6-7ccd-4672-8bd4-9d4fe300f534"),
                                Index = "b",
                                Name = "DentalExamInLastYear_N1b",
                                Text = "Dental exam in LAST YEAR",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("df07b95a-a159-43c6-b218-1c13d0c1551c"),
                                Index = "c",
                                Name = "EyeExamInLastYear_N1c",
                                Text = "Eye exam in LAST YEAR",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("0d093234-0f1d-4647-90e1-acd6aaa36e72"),
                                Index = "d",
                                Name = "HearingExamInLast2Years_N1d",
                                Text = "Hearing exam in LAST 2 YEARS",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("8ba3be32-82e1-4246-ac42-5bc70d637e12"),
                                Index = "e",
                                Name = "InfluenzaVaccineInLastYear_N1e",
                                Text = "Influenza vaccine in LAST YEAR",
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
                        Id = new Guid("d1bf8580-d39a-4218-9de6-9f2066680766"),
                        Index = "2",
                        Name = "FormalServiceProviders_N2",
                        Text = "FORMAL SERVICE PROVIDERS",
                        SubText = "Contact with paid care provider in last 30 days (or since admission if LESS THAN 30 DAYS)",
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
                        Id = new Guid("8e1e04be-ceb0-4d59-9f30-7d8616cc1d45"),
                        Index = "3",
                        Name = "FocusOfSupports_N3",
                        Text = "FOCUS OF SUPPORTS",
                        SubText = "Code for types of issues that were a major focus of formal services and training programs in LAST 30 DAYS or since admission if less than 30 days ago",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("8e654e7c-44ed-41d8-867b-75ed5d895c52"),
                                Index = "a",
                                Name = "SelfCareSkillsEGDressingEatingHygiene_N3a",
                                Text = "Self-care skills—e.g., dressing, eating, hygiene",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("9340287b-66a9-457d-a42e-ebe72a5c1fe4"),
                                Index = "b",
                                Name = "CommunitySkillsEGVocationalRehabilitationTransportationShopping_N3b",
                                Text = "Community skills—e.g., vocational rehabilitation, transportation, shopping",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a7940c5f-cb1f-4a7a-95e7-bd716c3bff42"),
                                Index = "c",
                                Name = "SocialSkillsEGInterpersonalSkillsEtiquette_N3c",
                                Text = "Social skills—e.g., interpersonal skills, etiquette",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("64136b12-10d5-4f10-ac76-406c3abefa03"),
                                Index = "d",
                                Name = "CognitiveSkillsEGReadingLettersColourRecognition_N3d",
                                Text = "Cognitive skills—e.g., reading, letters, colour recognition",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a1c150cb-7466-460b-b7c7-813eaba54598"),
                                Index = "e",
                                Name = "EducationOnSpecialTopicsEGSexualitySafety_N3e",
                                Text = "Education on special topics—e.g., sexuality, safety",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("532b3bac-a75f-4e89-89c5-bada9ca948c7"),
                                Index = "f",
                                Name = "BehaviourManagementEGProgramToReduceUnwantedBehaviourOrIncreaseProSocialBehaviour_N3f",
                                Text = "Behaviour management—e.g., program to reduce unwanted behaviour or increase pro-social behaviour",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("3eb822ff-67d2-47ce-90de-52e2974a878a"),
                                Index = "g",
                                Name = "SensoryStimulationEGAromatherapySnoezelenRoomMusicTherapy_N3g",
                                Text = "Sensory stimulation—e.g., aromatherapy, Snoezelen room, music therapy",
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
                        Id = new Guid("71233c67-8ac2-44d3-bc29-ab885bfee307"),
                        Index = "4",
                        Name = "HospitalUseEmergencyRoomUsePhysicianVisit_N4",
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
                                Id = new Guid("acb59490-d7c9-4285-a38a-83decdd5ae08"),
                                Index = "a",
                                Name = "InPatientAcuteHospitalWithOvernightStay_N4a",
                                Text = "In-patient acute hospital with overnight stay",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("5d11102c-78a4-45f2-953d-b14a5f53aa33"),
                                Index = "b",
                                Name = "EmergencyRoomVisitNotCountingOvernightStay_N4b",
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
                                Id = new Guid("cbd6b76a-41f9-4a2b-b3fe-2f6adcd09a63"),
                                Index = "c",
                                Name = "VisitWithPhysicianOrAuthorizedAssistantOrPractitioner_N4c",
                                Text = "Visit with physician (or authorized assistant or practitioner)",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("4ac3db2b-cc8e-422f-8e25-0f430b41509e"),
                                Index = "d",
                                Name = "VisitWithLicensedMentalHealthProfessionalEGPsychiatristPsychologistSocialWorkerBehaviouralTherapist_N4d",
                                Text = "Visit with licensed mental health professional—e.g., psychiatrist, psychologist, social worker, behavioural therapist",
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
                        Id = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                        Index = "5",
                        Name = "TimeSinceLastHospitalStay_N5",
                        Text = "TIME SINCE LAST HOSPITAL STAY",
                        SubText = "Code for most recent instance in LAST 90 DAYS",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("3da6465b-7ba6-4770-bbed-b46ab8a36fa2"),
                                QuestionId = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                                Value = "0",
                                Text = "No hospitalization within 90 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("73f82cc9-4c28-4c42-b4de-d693b508c5a7"),
                                QuestionId = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                                Value = "1",
                                Text = "31–90 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4af85b06-10ed-409e-b735-982531b98408"),
                                QuestionId = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                                Value = "2",
                                Text = "15–30 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("275ae343-f828-4d8b-b8bc-f53f7dcaacc2"),
                                QuestionId = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                                Value = "3",
                                Text = "8–14 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("336be118-19b1-4afb-b08a-5c19217c1930"),
                                QuestionId = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                                Value = "4",
                                Text = "In the last 7 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c1cb02f6-c929-4f45-9478-244e7a0773be"),
                                QuestionId = new Guid("f357a734-c0dd-4a61-b0a7-1ef940bc41b8"),
                                Value = "5",
                                Text = "Now in hospital",
                            },
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                        },
                    },
                    new QuestionModel
                    {
                        Id = new Guid("2a0213e2-202a-4058-9193-e4fad3044c12"),
                        Index = "6",
                        Name = "NumberOfLifetimePsychiatricHospitalUnitAdmissions_N6",
                        Text = "NUMBER OF LIFETIME PSYCHIATRIC HOSPITAL / UNIT ADMISSIONS",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("ea31547a-279d-4e59-82d6-8dbb3ec6a3e6"),
                                QuestionId = new Guid("2a0213e2-202a-4058-9193-e4fad3044c12"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("727727de-6fb6-4213-9967-ec779c9e9f6b"),
                                QuestionId = new Guid("2a0213e2-202a-4058-9193-e4fad3044c12"),
                                Value = "1",
                                Text = "1–3",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("49ee09ee-e429-41e9-ae38-bcbc38963077"),
                                QuestionId = new Guid("2a0213e2-202a-4058-9193-e4fad3044c12"),
                                Value = "2",
                                Text = "4–5",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0bccb0c4-847c-4f47-bb4a-0f14c250ce07"),
                                QuestionId = new Guid("2a0213e2-202a-4058-9193-e4fad3044c12"),
                                Value = "3",
                                Text = "6 or more",
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
                Id = new Guid("17504854-f9e5-41ac-84ac-dd3cc1ac1251"),
                Index = "O",
                Description = "Diagnostic Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("222fd217-e751-4728-a690-d2d2b0f93398"),
                        Index = "1",
                        Name = "MedicalDiagnoses_O1",
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
                                Id = new Guid("701a6612-17e7-4453-bc1f-cd19629e99ee"),
                                Index = "a",
                                Name = "Asthma_O1a",
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
                                Id = new Guid("4e32d5aa-579f-4be0-9dcf-b5db8c1e9536"),
                                Index = "b",
                                Name = "CerebralPalsy_O1b",
                                Text = "Cerebral palsy",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a01910a1-54e1-4a8e-878f-cbb5c5af9508"),
                                Index = "c",
                                Name = "DiabetesMellitus_O1c",
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
                                Id = new Guid("d11ef51f-9102-404c-b6c4-f03f05e92787"),
                                Index = "d",
                                Name = "EpilepsyOrSeizureDisorder_O1d",
                                Text = "Epilepsy or seizure disorder",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("33c63223-5219-4b8a-9a00-f8cf7d8b69ca"),
                                Index = "e",
                                Name = "Hypothyroidism_O1e",
                                Text = "Hypothyroidism",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("a8e2f657-ec37-4ab9-ab39-63581d6e51f1"),
                                Index = "f",
                                Name = "TraumaticBrainInjury_O1f",
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
                                Id = new Guid("0c5f9547-2b3f-4d16-867b-429d8527b729"),
                                Index = "g",
                                Name = "OtherMedicalDiagnosis1_O1g",
                                Text = "Other Medical Diagnosis 1",
                                SubText = "Format (Diagnosis), (Disease Code), (ICD-10-CA-Code)",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2a213b6e-0a55-445f-bddf-4e0dfd83ef57"),
                                Index = "h",
                                Name = "OtherMedicalDiagnosis2_O1h",
                                Text = "Other Medical Diagnosis 2",
                                SubText = "Format (Diagnosis), (Disease Code), (ICD-10-CA-Code)",
                                DefaultValue = null,
                                QuestionType = "TEXT",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("e3ebe191-504e-4d04-8f9a-06d74ed77d38"),
                                Index = "i",
                                Name = "OtherMedicalDiagnosis3_O1i",
                                Text = "Other Medical Diagnosis 3",
                                SubText = "Format (Diagnosis), (Disease Code), (ICD-10-CA-Code)",
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
                        Id = new Guid("909f9b8a-cfcf-44e5-8ec0-8618280c3ddb"),
                        Index = "2",
                        Name = "MentalHealthDiagnosisByCategory_O2",
                        Text = "MENTAL HEALTH DIAGNOSIS BY CATEGORY",
                        SubText = "See manual for help with diagnoses within each category",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("66d3dad2-943d-4797-b55c-21dc90f574eb"),
                                Index = "a",
                                Name = "DeliriumDementiaAndAmnesticAndOtherCognitiveDisorders_O2a",
                                Text = "Delirium, dementia, and amnestic and other cognitive disorders",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("0c0086ed-ebf2-4b57-9fe6-c35b5568aab1"),
                                Index = "b",
                                Name = "SchizophreniaAndOtherPsychoticDisorders_O2b",
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
                                Id = new Guid("44f7b674-2a9c-47b8-b0f9-5d7b88d8b9d0"),
                                Index = "c",
                                Name = "MoodDisorder_O2c",
                                Text = "Mood disorder",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("88da4cab-e8d3-474e-b434-7b253b9a8fe4"),
                                Index = "d",
                                Name = "AnxietyDisorder_O2d",
                                Text = "Anxiety disorder",
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
                Id = new Guid("eac356d2-47fe-4c32-9182-2aafb9254420"),
                Index = "P",
                Description = "Discharge Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("54dd9e83-f507-443e-8bb4-407c14b5a76f"),
                        Index = "1",
                        Name = "LastDayOfInvolvementWithProgramOrAgency_P1",
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
                        Id = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                        Index = "2",
                        Name = "DischargedTo_P2",
                        Text = "DISCHARGED TO",
                        SubText = "",
                        DefaultValue = null,
                        QuestionType = "DROPDOWN_LIST",
                        Choices = new List<ResponseModel>
                        {
                            new ResponseModel
                            {
                                Id = new Guid("5b006137-6bfa-4e31-ad0c-e7389544a0db"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "1",
                                Text = "Private home / apartment / rented room",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c2337e17-57b6-4720-b008-d409089360e6"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "2",
                                Text = "Board and care",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("24be0b5c-0454-4ed1-9044-f3b48f6afef2"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "3",
                                Text = "Assisted living or semi-independent living",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("750b28a5-857a-4d65-8634-1138f1b1d5d5"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "4",
                                Text = "Mental health residence—e.g., psychiatric group home",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9c1a02a5-ed01-4e9e-90ef-7b431ef34c97"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "5",
                                Text = "Group home for persons with physical disability",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b1401c27-821a-4e59-9170-aecc45f38754"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "6",
                                Text = "Setting for persons with intellectual disability",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("368c0a07-db29-46cd-b1b2-f84173cf6c5a"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "7",
                                Text = "Psychiatric hospital or unit",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f9a11b85-53f7-4716-9737-e87960d15f72"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "8",
                                Text = "Homeless (with or without shelter)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f14ace75-5eb8-4163-99f7-a872bb3805f7"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "9",
                                Text = "Long-term care facility (nursing home)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("69808357-e21a-42ac-bae4-7bf33c582d5e"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "10",
                                Text = "Rehabilitation hospital / unit",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f176875e-1bc0-4044-80ba-7473a9c2dd82"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "11",
                                Text = "Hospice facility / palliative care unit",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f8f06da6-e668-4fe7-a536-6862c36a5284"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "12",
                                Text = "Acute care hospital",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("39a924e7-8637-40d5-af8d-cb84ba264219"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "13",
                                Text = "Correctional facility",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b5087f4a-5688-4aa0-b9f7-609713b5de5e"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "14",
                                Text = "Other",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("76147ca6-b6c9-4531-9292-d555ac13d82e"),
                                QuestionId = new Guid("e90fc67c-9814-452f-99dc-09ce5386047d"),
                                Value = "15",
                                Text = "Deceased",
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
                Id = new Guid("e2cdb287-9ce4-45bd-b05f-6e57559f59d9"),
                Index = "Q",
                Description = "Assessment Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("dbcb7967-23c9-4bb5-af8a-636578c23ee3"),
                        Index = "1",
                        Name = "SignatureOfPersonCoordinatingCompletingTheAssessment_Q1",
                        Text = "SIGNATURE OF PERSON COORDINATING / COMPLETING THE ASSESSMENT",
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
                        Id = new Guid("10967a6b-6cfc-4eb8-9417-96fe0d28698d"),
                        Index = "2",
                        Name = "DateAssessmentSignedAsComplete_Q2",
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
