namespace AssessmentAutogen.Model;

public static class AssessmentGeneration
{
    public static List<AssessmentModel> Assessments = new List<AssessmentModel>
{
    new AssessmentModel
    {
        Id = new Guid("7f2e9fba-6919-495c-b455-592f465b1127"),
        Name = "AdultMentalHealthAndDisability",
        Text = "Adult Intellectual Disability (ID) Assessment",
        Sections = new List<SectionModel>
        {
            new SectionModel
            {
                Id = new Guid("aea91ec8-ee2f-4673-9a97-11fd090ef920"),
                Index = "A",
                Description = "Identification Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("2f601181-7070-457f-86e9-f378aeee9371"),
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
                                Id = new Guid("643cee02-7f60-445c-afd0-73269f1635fa"),
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
                                Id = new Guid("c7c7de3c-b06a-4865-b316-ff498b31d67b"),
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
                                Id = new Guid("c22bca21-73e9-498d-8f62-3a97749c11fa"),
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
                                Id = new Guid("555484de-891c-4542-812e-88069be2659e"),
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
                        Id = new Guid("0ea4603a-d7f5-4e4c-81cd-3b09f0f3237a"),
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
                                Id = new Guid("9f277095-7ba8-4fd2-baf2-431226bceb78"),
                                QuestionId = new Guid("0ea4603a-d7f5-4e4c-81cd-3b09f0f3237a"),
                                Value = "1",
                                Text = "Male",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7391cd18-f324-42cb-aa02-af58e7a03708"),
                                QuestionId = new Guid("0ea4603a-d7f5-4e4c-81cd-3b09f0f3237a"),
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
                        Id = new Guid("a2d39618-6d97-4718-8114-83615ecc7c18"),
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
                        Id = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
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
                                Id = new Guid("ce08fb66-4be0-4771-b374-ffc92d1d053b"),
                                QuestionId = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
                                Value = "1",
                                Text = "Never married",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ed8fe105-4af1-48e5-94e6-5142c7cc134f"),
                                QuestionId = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
                                Value = "2",
                                Text = "Married",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3d838dd1-82ec-4886-8763-30b24b5649ca"),
                                QuestionId = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
                                Value = "3",
                                Text = "Partner / significant other",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8a21f2fd-7a98-43d2-9485-d55aba569bfc"),
                                QuestionId = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
                                Value = "4",
                                Text = "Widowed",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("49759972-6822-47fb-90b9-c1e39c0219ec"),
                                QuestionId = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
                                Value = "5",
                                Text = "Separated",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1dccd80b-59f7-43ef-a73c-254a9483b04e"),
                                QuestionId = new Guid("65670259-11fa-4d04-851e-e2a7a87eee11"),
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
                        Id = new Guid("732c4aa3-186b-49e0-a8d1-4f0761347df7"),
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
                                Id = new Guid("d381cc63-4691-43ff-a1d5-26d3c7a6bbf9"),
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
                                Id = new Guid("c363173b-1bd9-4621-8fe2-e043fa22bf4d"),
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
                        Id = new Guid("8c853f3c-8785-4d91-a8ab-d9ede4da9545"),
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
                                Id = new Guid("da0c0687-f228-461f-8fcb-936da1eaf3d3"),
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
                                Id = new Guid("d019ab73-3389-4316-bb52-ce8bbfb46899"),
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
                        Id = new Guid("15a85934-749b-4ad4-b50b-3b63e117c4d2"),
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
                                Id = new Guid("f16cda0e-72f4-4d62-b4cc-b6ebd7f1b2fa"),
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
                                Id = new Guid("7ab1c90b-4cb7-49b1-aa61-9216d2919f27"),
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
                                Id = new Guid("f5eb3826-de80-47b2-858f-8dc53978c1b0"),
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
                                Id = new Guid("6b47e38b-b2bc-42c1-8756-0a8b98f92818"),
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
                                Id = new Guid("2cbb7ab1-0df6-4d6d-9130-2779ab3f1300"),
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
                                Id = new Guid("5cfa5591-3be1-4f3a-a132-03ede6e224fd"),
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
                                Id = new Guid("791f50d9-6632-4291-a65a-5bcc77b16e06"),
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
                                Id = new Guid("56e17729-4171-4d55-838c-da9074dc5230"),
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
                                Id = new Guid("a7bcbcba-cba1-4e98-98e4-7933d8e72ad8"),
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
                                Id = new Guid("37e84068-bd80-4707-b042-d5af99c3b9ea"),
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
                                Id = new Guid("1d05d092-c3e6-42ec-a3da-0fbb2a10106b"),
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
                        Id = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
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
                                Id = new Guid("c7d14d25-7412-4159-ae34-bc843f7ef853"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
                                Value = "1",
                                Text = "First assessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4d21ae6b-0769-41b5-8296-142e7d86dee2"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
                                Value = "2",
                                Text = "Routine reassessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b793b21e-9a22-47bf-bd38-179a5954ebfe"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
                                Value = "3",
                                Text = "Return assessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d0c18458-527c-41f4-8f35-a91d170fb071"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
                                Value = "4",
                                Text = "Significant change in status reassessment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("04da8a9f-b153-446e-9c81-fe970d9e590d"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
                                Value = "5",
                                Text = "Discharge assessment, covers last 3 days of service",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f5cc34e1-9289-4fa3-aa0b-414c9726631f"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
                                Value = "6",
                                Text = "Discharge tracking only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("68dc21b7-a75f-4f03-8b90-28fa54b77506"),
                                QuestionId = new Guid("34a583fd-eb99-4b80-9276-5e17dd2e36ad"),
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
                        Id = new Guid("2361a2e5-a490-44b5-82f0-f872bab1defd"),
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
                        Id = new Guid("900911ae-14ad-4511-a786-8982db9b4bb6"),
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
                        Id = new Guid("dba6c3a2-5596-4d4d-ac53-8b3f87bbe0a8"),
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
                                Id = new Guid("7b917b2e-76ec-4a20-b715-68a49451acb5"),
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
                                Id = new Guid("11d59b15-399d-49fb-8326-bd0335e65be1"),
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
                                Id = new Guid("34c97e11-ac82-420c-8db0-77a32626e9cd"),
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
                                Id = new Guid("1651cf81-0146-4516-bb9d-6941b53a815f"),
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
                                Id = new Guid("3f394d8f-636a-43ee-8ae0-274e8e1089fe"),
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
                                Id = new Guid("855137de-94fa-490c-bfad-1c8bf2e3ab5e"),
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
                        Id = new Guid("0080879e-67ed-4029-8943-6ef8a0e860b5"),
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
                                Id = new Guid("8bc97cc5-1941-4674-86a4-1bc872a389c2"),
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
                                Id = new Guid("131ff533-c5fa-47fd-bf41-5fcb65c99476"),
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
                        Id = new Guid("8731461b-0ef3-4e18-8329-7ecf9426d366"),
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
                        Id = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
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
                                Id = new Guid("b37975e8-19e1-445d-88e0-62ad969ac0e9"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "1",
                                Text = "Alone",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("723a2489-0f13-46c9-9bcd-da36f776d0d2"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "2",
                                Text = "With spouse / partner only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f647e18d-3ebb-4bbc-8d47-c8b70a156442"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "3",
                                Text = "With spouse / partner and other(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c1272970-9195-4249-a611-5f8086fff22e"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "4",
                                Text = "With child (not spouse / partner)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("baef42d0-6ddd-4449-b42e-6c5918019aba"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "5",
                                Text = "With parent(s) or guardian(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c3476272-e182-411e-b23c-bc2329f16901"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "6",
                                Text = "With sibling(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5ec12ac3-d4c0-4b1f-a8d4-7a46b4267691"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
                                Value = "7",
                                Text = "With other relative(s)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d1285296-4aee-4bda-b52e-29e10215c5f8"),
                                QuestionId = new Guid("a327cdcd-58d7-4faf-86ab-d9978f9fbbed"),
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
                Id = new Guid("9a0e85da-9be5-4edf-8083-99da308bca8c"),
                Index = "B",
                Description = "Intake and Initial History (NOTE: Complete Section B at Admission / First Assessment only)",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("1cc03578-f83a-4aca-ba04-db136ad99ed1"),
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
                        Id = new Guid("a048c52e-76f5-41e3-9a27-fb987c75e888"),
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
                                Id = new Guid("b1db380a-10f5-4951-bec1-dc763f4d882c"),
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
                                Id = new Guid("7f2c66b0-7239-4540-b821-585e7bc36c9d"),
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
                                Id = new Guid("274cdab6-8d90-4617-a095-ea90361ca288"),
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
                        Id = new Guid("32ba0d66-4585-4b21-9e08-99770c83513f"),
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
                                Id = new Guid("8b9d04c9-73a2-4591-a4c8-1a23e3d31c5f"),
                                QuestionId = new Guid("32ba0d66-4585-4b21-9e08-99770c83513f"),
                                Value = "eng",
                                Text = "English",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("fd51085e-8bc9-4969-9e59-2a058479facf"),
                                QuestionId = new Guid("32ba0d66-4585-4b21-9e08-99770c83513f"),
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
                        Id = new Guid("90ff68a2-bfec-45da-b5be-489f179d0695"),
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
                                Id = new Guid("44819990-72da-4ecd-a006-2771b7115027"),
                                QuestionId = new Guid("90ff68a2-bfec-45da-b5be-489f179d0695"),
                                Value = "1",
                                Text = "Cause unspecified (i.e., intellectual or developmental disability)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("be4141ec-19d9-4980-a408-31b9f0a667f9"),
                                QuestionId = new Guid("90ff68a2-bfec-45da-b5be-489f179d0695"),
                                Value = "2",
                                Text = "Down syndrome",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("953bf0c1-b7df-4598-99e7-932f24edc2e5"),
                                QuestionId = new Guid("90ff68a2-bfec-45da-b5be-489f179d0695"),
                                Value = "3",
                                Text = "Autism spectrum disorder",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2aca9136-02f9-4550-8a57-ca85a4cd8645"),
                                QuestionId = new Guid("90ff68a2-bfec-45da-b5be-489f179d0695"),
                                Value = "4",
                                Text = "Fragile X syndrome",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bfcd72ba-0adc-472d-a599-977b3f833080"),
                                QuestionId = new Guid("90ff68a2-bfec-45da-b5be-489f179d0695"),
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
                        Id = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
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
                                Id = new Guid("408022b8-2bf5-4c73-b183-ea2ce24c48a4"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
                                Value = "0",
                                Text = "No intellectual disability",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("035040b2-9c34-412b-80a2-933da20292a2"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
                                Value = "1",
                                Text = "Borderline",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d4279de1-40e5-432d-937e-d56072bb6ee4"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
                                Value = "2",
                                Text = "Mild",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e260b3e3-a251-4f76-9328-9371cc08e0c8"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
                                Value = "3",
                                Text = "Moderate",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4a1f24b2-4549-4eb2-8064-f55dbad3fa73"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
                                Value = "4",
                                Text = "Severe",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ae6ef5dc-3064-452d-b909-b30f19e2b878"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
                                Value = "5",
                                Text = "Profound",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c48cac5f-91bb-49b1-9ace-62fa7e3ea8ce"),
                                QuestionId = new Guid("3b508232-2aad-46d5-9abb-914806835dc1"),
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
                        Id = new Guid("94cff81c-9514-448b-97a7-494113f20f49"),
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
                        Id = new Guid("da4c241e-5e19-4a34-8291-cac6f92d361c"),
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
                        Id = new Guid("a13ced47-68bc-4e34-81d3-406732b8e618"),
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
                                Id = new Guid("9923010a-8ba9-4af9-a56e-ba2a570fd1b2"),
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
                                Id = new Guid("4e214e66-0787-4d10-9c20-93d47a1a94c1"),
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
                                Id = new Guid("227b6459-66fa-4bb2-b9e8-45182952a290"),
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
                                Id = new Guid("d605024b-7821-4462-8196-79f37304a2f3"),
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
                Id = new Guid("3ea6485a-875b-499a-acff-432ffb51aecf"),
                Index = "C",
                Description = "Community and Social Involvement",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("687fd8ab-cb4d-4da7-b02c-195a69998f7a"),
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
                                Id = new Guid("cee2193e-8962-4c5f-8ae1-f9c6c112da9e"),
                                QuestionId = new Guid("687fd8ab-cb4d-4da7-b02c-195a69998f7a"),
                                Value = "1",
                                Text = "Employed",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a440bef6-0eb7-4979-a738-9472f74f1271"),
                                QuestionId = new Guid("687fd8ab-cb4d-4da7-b02c-195a69998f7a"),
                                Value = "2",
                                Text = "Unemployed, seeking employment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f03f6c03-9448-4eb0-a1cf-ef4799dab9c1"),
                                QuestionId = new Guid("687fd8ab-cb4d-4da7-b02c-195a69998f7a"),
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
                        Id = new Guid("0d9b97a0-c2d8-4833-8881-8a661445c029"),
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
                                Id = new Guid("04100177-bab2-45c1-a754-6d70e83023d7"),
                                QuestionId = new Guid("0d9b97a0-c2d8-4833-8881-8a661445c029"),
                                Value = "1",
                                Text = "Competitive employment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ffc8bc79-a657-43c8-a936-3ed955c91586"),
                                QuestionId = new Guid("0d9b97a0-c2d8-4833-8881-8a661445c029"),
                                Value = "2",
                                Text = "Supported employment",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("562f3003-918a-4d41-b1ad-d6f0c6ed7013"),
                                QuestionId = new Guid("0d9b97a0-c2d8-4833-8881-8a661445c029"),
                                Value = "3",
                                Text = "Vocational rehabilitation",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("69e579d4-c3be-445e-8d92-f4ecf7f9132c"),
                                QuestionId = new Guid("0d9b97a0-c2d8-4833-8881-8a661445c029"),
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
                        Id = new Guid("1258d5fe-0e00-424f-bc85-df307d5c3f41"),
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
                                Id = new Guid("e3617149-94a2-4c86-affc-445748f16abc"),
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
                                Id = new Guid("b5633346-0dc9-4a4d-a992-c798366b2361"),
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
                                Id = new Guid("b3a28357-e4b5-4dfa-99bd-d562031b6ee1"),
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
                        Id = new Guid("6d047bb0-e434-4c3a-a4b4-fedb740f0d9a"),
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
                        Id = new Guid("123632c6-c6fa-4f84-b52c-cb3c6d14fedb"),
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
                                Id = new Guid("97f374b2-7d00-4965-9816-af5a4fc81e4b"),
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
                                Id = new Guid("726c422e-d9eb-4a76-b5df-8e86950e50b4"),
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
                                Id = new Guid("bdab8052-c37b-4ab3-9e80-ab56b57f8da2"),
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
                        Id = new Guid("b7360ffa-bc9e-4e27-83e3-6d249b9f75c1"),
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
                                Id = new Guid("c136f42c-11aa-40e2-86ee-3a4d0f9c7ac0"),
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
                                Id = new Guid("268cf36f-2175-4d62-9392-cac8061fc300"),
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
                                Id = new Guid("469e5d27-6a0a-49a9-a716-186f816c9049"),
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
                                Id = new Guid("f755212f-5652-467e-94cd-b1c50b73bbd3"),
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
                                Id = new Guid("7ee07700-5973-4df9-bf75-e20217829828"),
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
                                Id = new Guid("f74a44c6-6a68-4bb2-bf37-e5e09e75e632"),
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
                Id = new Guid("c5446b95-cc78-4359-a40d-e97efae0b885"),
                Index = "D",
                Description = "Strengths, Relationships, and Supports",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("ba67e79b-911f-4078-9826-cc9df8419d86"),
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
                                Id = new Guid("05e96227-4387-4652-bf45-91ef2b3287bd"),
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
                                Id = new Guid("d6b5368e-38a5-4c18-9594-13141a82c6bb"),
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
                                Id = new Guid("257910ec-5827-44fa-8696-1bc11de1f4c2"),
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
                                Id = new Guid("c878fd4c-5fff-4975-a915-bf48cde4548a"),
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
                                Id = new Guid("125f8517-a3fe-4315-8ecb-246b9b01dbdc"),
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
                        Id = new Guid("3f7a17b7-4490-41d5-8263-60ab5b3e49e3"),
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
                                Id = new Guid("9b074a47-e031-4ba4-aef3-37cf4f84d029"),
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
                                Id = new Guid("8f457ca9-f973-4402-84c8-91be5ac3d838"),
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
                                Id = new Guid("a0b0d58b-62ad-4a7c-a05a-8203956cbd7c"),
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
                                Id = new Guid("43227d21-a723-4979-a501-3cf4040ce6f6"),
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
                        Id = new Guid("9fe3a6f3-bcfe-430e-a2ec-650713e0e63a"),
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
                                Id = new Guid("70e95ebb-aeb0-4e54-b663-2603c7d260dd"),
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
                                Id = new Guid("62293c72-a003-47c8-8d52-67528127b34b"),
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
                                Id = new Guid("1b052e25-fde8-4d83-bda9-92651c612832"),
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
                                Id = new Guid("1d56cc0c-fd7a-4354-9f3d-b6b69d9f49b7"),
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
                        Id = new Guid("1aeedfd1-27b4-48e5-b12a-df22aa6be48f"),
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
                                Id = new Guid("e297545f-431c-4c95-810e-921ddf6555fc"),
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
                                Id = new Guid("ad6f7e17-b54a-49e5-958c-503c3df61121"),
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
                                Id = new Guid("e84b3bf2-eb0d-4e27-a40b-836c3645e91e"),
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
                                Id = new Guid("2594d91a-5ad7-44e1-9877-74cbaff2eabf"),
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
                                Id = new Guid("e582bb85-eb9f-4b1c-8752-0e690db768c8"),
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
                                Id = new Guid("24951c44-8034-4ae2-a921-a7b2786904df"),
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
                                Id = new Guid("c2988da4-7cf8-4449-ba17-fb53ea43be9a"),
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
                        Id = new Guid("94507961-4930-4453-8eab-51ea289600a1"),
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
                                Id = new Guid("14491faf-8d83-4518-8204-f5aec2467358"),
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
                                Id = new Guid("78bdacc6-9272-444a-beca-15366ca26c35"),
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
                                Id = new Guid("22a4ab82-dda8-4e0f-a68a-5dbb98fb8947"),
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
                                Id = new Guid("adbcf4d4-3d75-401d-b441-e7de4361ab90"),
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
                                Id = new Guid("c269fc93-79c5-401d-a64c-0d39000c7e63"),
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
                                Id = new Guid("eb8b80bb-8ae9-444f-a990-14d164f7cd83"),
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
                                Id = new Guid("5ef52669-60f2-46d5-8042-70b1a841ae65"),
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
                        Id = new Guid("87f69406-022a-45c2-b837-f32a2b033993"),
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
                                Id = new Guid("cb93c815-ebac-4518-a853-93697ec0bbfb"),
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
                                Id = new Guid("8e0a2e49-6584-485c-a80f-f26ccb68b975"),
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
                                Id = new Guid("59c755b8-e6e9-467d-94e0-4373ea9419ff"),
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
                        Id = new Guid("e6247d73-89f3-452b-8caa-cc2c58f90aea"),
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
                        Id = new Guid("c9995995-630a-491a-b3b6-2d3541de2fba"),
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
                                Id = new Guid("e677d348-a7bc-487f-8652-c29c1c41d502"),
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
                                Id = new Guid("861b344d-4a21-4a72-a319-e8481d0c8a75"),
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
                                Id = new Guid("4801cad7-2e76-4030-ad04-52412baec9ac"),
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
                        Id = new Guid("46896297-4c7e-4265-8a31-10998417d460"),
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
                                Id = new Guid("99db998a-36aa-4b9d-87c8-6463a533a85d"),
                                QuestionId = new Guid("46896297-4c7e-4265-8a31-10998417d460"),
                                Value = "0",
                                Text = "Alternative plans not considered OR not required",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5a00386b-2b6f-46ac-ae47-59dd1f1bbc5f"),
                                QuestionId = new Guid("46896297-4c7e-4265-8a31-10998417d460"),
                                Value = "1",
                                Text = "Alternative plans not made, but under consideration",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3db3c030-d98f-419d-8d1e-0c2f77d9a467"),
                                QuestionId = new Guid("46896297-4c7e-4265-8a31-10998417d460"),
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
                        Id = new Guid("13798fdd-0206-4da4-9eb3-a4a684aa0b8e"),
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
                                Id = new Guid("3c9da6f5-415b-42e5-a836-29a3eb549826"),
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
                                Id = new Guid("4c7f78d7-15d9-4023-8b91-28f81b1c8230"),
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
                                Id = new Guid("a4f85e3c-37b6-4270-826d-0a28c24cc39f"),
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
                                Id = new Guid("e10f7293-8920-4a81-8d1e-356a71f12ea6"),
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
                                Id = new Guid("afb2fa3c-832a-490a-b4ed-6a1d85bfaf9c"),
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
                                Id = new Guid("07db937a-59a2-409b-96b0-c062ca60eb02"),
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
                                Id = new Guid("0dbc9b3a-b33d-4412-9e28-f3286ae82e95"),
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
                        Id = new Guid("c1e8ed23-51eb-4830-a005-c9099b3bece4"),
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
                                Id = new Guid("d63d8aab-aa9b-4be1-a7ed-d7ab91c053af"),
                                QuestionId = new Guid("c1e8ed23-51eb-4830-a005-c9099b3bece4"),
                                Value = "0",
                                Text = "No, or not applicable",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5991d608-9f40-4fa8-8f32-f5f2d526f35a"),
                                QuestionId = new Guid("c1e8ed23-51eb-4830-a005-c9099b3bece4"),
                                Value = "1",
                                Text = "Yes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6ee3efa2-ae86-48ab-9ba1-0d6ba87ec9b6"),
                                QuestionId = new Guid("c1e8ed23-51eb-4830-a005-c9099b3bece4"),
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
                Id = new Guid("0162c044-ab3b-47d4-bcc8-a010b8fe9e69"),
                Index = "E",
                Description = "Lifestyle",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("1405529a-5636-4428-b876-c8cf698487c9"),
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
                                Id = new Guid("c1ba7ff4-db13-4196-89da-a320a273cfcd"),
                                QuestionId = new Guid("1405529a-5636-4428-b876-c8cf698487c9"),
                                Value = "0",
                                Text = "No coffee or caffeinated beverages",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("11194f97-c929-441a-a7a1-c3f4689e3dc0"),
                                QuestionId = new Guid("1405529a-5636-4428-b876-c8cf698487c9"),
                                Value = "1",
                                Text = "1–2 cups of coffee or 1–4 caffeinated beverages",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("cac217c1-380d-48e3-b274-2454db49b309"),
                                QuestionId = new Guid("1405529a-5636-4428-b876-c8cf698487c9"),
                                Value = "2",
                                Text = "3–5 cups of coffee or 5–9 caffeinated beverages",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ca1074c0-a4ac-4307-83ce-e6fdc6b63ea2"),
                                QuestionId = new Guid("1405529a-5636-4428-b876-c8cf698487c9"),
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
                        Id = new Guid("755482f9-a42c-4fad-abc5-64922be731cf"),
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
                                Id = new Guid("a577e6e6-6957-4177-b636-95cb35e4fe68"),
                                QuestionId = new Guid("755482f9-a42c-4fad-abc5-64922be731cf"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("800b54f6-6482-4a5a-b74d-1320d7586fd4"),
                                QuestionId = new Guid("755482f9-a42c-4fad-abc5-64922be731cf"),
                                Value = "1",
                                Text = "Not in last 3 days, but is usually a daily smoker",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("60977c21-f5d9-4fb1-8f2d-979d8da96e0f"),
                                QuestionId = new Guid("755482f9-a42c-4fad-abc5-64922be731cf"),
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
                        Id = new Guid("78dd3cb9-44fa-4825-966f-c1a25bd2e091"),
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
                                Id = new Guid("78d47bbb-f815-4ae9-89c9-e57dba2a7213"),
                                QuestionId = new Guid("78dd3cb9-44fa-4825-966f-c1a25bd2e091"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("dd3e1f83-0cb9-4987-a631-6db1abba4971"),
                                QuestionId = new Guid("78dd3cb9-44fa-4825-966f-c1a25bd2e091"),
                                Value = "1",
                                Text = "1",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("dae66f40-c9f7-4571-86fc-dec1257c126a"),
                                QuestionId = new Guid("78dd3cb9-44fa-4825-966f-c1a25bd2e091"),
                                Value = "2",
                                Text = "2–4",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0de1aba6-cc7e-4df7-b8dd-f355ee199b8b"),
                                QuestionId = new Guid("78dd3cb9-44fa-4825-966f-c1a25bd2e091"),
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
                        Id = new Guid("48a1bf22-e7ef-40d9-a21a-aea9b0c0c641"),
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
                                Id = new Guid("0f2ccab9-c53e-4e4b-8ee3-519c6b4cdb95"),
                                QuestionId = new Guid("48a1bf22-e7ef-40d9-a21a-aea9b0c0c641"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("01006292-da0d-43b7-98db-f6442d95b71d"),
                                QuestionId = new Guid("48a1bf22-e7ef-40d9-a21a-aea9b0c0c641"),
                                Value = "1",
                                Text = "Less than 1 hour",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9c5a940a-c11b-4a3e-b2d3-9e4271e53ea8"),
                                QuestionId = new Guid("48a1bf22-e7ef-40d9-a21a-aea9b0c0c641"),
                                Value = "2",
                                Text = "1–2 hours",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("09fcdeae-c51a-42c7-ad4b-8f45229ae74e"),
                                QuestionId = new Guid("48a1bf22-e7ef-40d9-a21a-aea9b0c0c641"),
                                Value = "3",
                                Text = "3–4 hours",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6c8e5eef-ea9f-43de-a8b9-c74295f77645"),
                                QuestionId = new Guid("48a1bf22-e7ef-40d9-a21a-aea9b0c0c641"),
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
                Id = new Guid("88d2e763-0c2c-41b0-a741-60d5efa94d0e"),
                Index = "F",
                Description = "Environmental Assessment",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("0b3d32ee-6d2a-4a8a-9cc1-d598281659f0"),
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
                                Id = new Guid("ebc1cd37-2ac8-4cd2-96bf-0c7665683c01"),
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
                                Id = new Guid("3194a394-8323-4be6-8773-7d85ee593ba1"),
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
                                Id = new Guid("0b92b84d-bbb5-425a-9ad9-63a5a341811a"),
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
                                Id = new Guid("3ac54ebd-0141-47eb-81c6-e946cb826a7c"),
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
                                Id = new Guid("45a3e795-b1af-40e8-ab24-8a634d582dc6"),
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
                Id = new Guid("329f836d-ef72-4052-8734-99160e8cc30d"),
                Index = "G",
                Description = "Communication and Vision",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("a09be795-0c35-4493-93da-499074a7883a"),
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
                                Id = new Guid("1ab5381f-c372-44dc-aa45-da11710e25b3"),
                                QuestionId = new Guid("a09be795-0c35-4493-93da-499074a7883a"),
                                Value = "0",
                                Text = "Verbal—i.e., speech",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("482f6d4e-4ee3-4a6d-9183-d181da120602"),
                                QuestionId = new Guid("a09be795-0c35-4493-93da-499074a7883a"),
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
                        Id = new Guid("85cd59e3-a487-4090-902b-31891bf1dc7b"),
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
                                Id = new Guid("b6312496-95a6-444d-bb76-a9f0eea3cdb6"),
                                QuestionId = new Guid("85cd59e3-a487-4090-902b-31891bf1dc7b"),
                                Value = "0",
                                Text = "Understood—Expresses ideas without difficulty",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("aeaaf314-0418-475c-885e-9a6a5c60e5fb"),
                                QuestionId = new Guid("85cd59e3-a487-4090-902b-31891bf1dc7b"),
                                Value = "1",
                                Text = "Usually understood—Difficulty finding words or finishing thoughts BUT if given time, little or no prompting required",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("f93db557-bad9-4089-b119-133e104b0f7a"),
                                QuestionId = new Guid("85cd59e3-a487-4090-902b-31891bf1dc7b"),
                                Value = "2",
                                Text = "Often understood—Difficulty finding words or finishing thoughts AND prompting usually required",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b2510ce1-0094-400f-aa41-221f407361ba"),
                                QuestionId = new Guid("85cd59e3-a487-4090-902b-31891bf1dc7b"),
                                Value = "3",
                                Text = "Sometimes understood—Ability is limited to making concrete requests",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("734e02d9-da7c-47d9-84e3-ecac7b1d17d8"),
                                QuestionId = new Guid("85cd59e3-a487-4090-902b-31891bf1dc7b"),
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
                        Id = new Guid("0ab99b67-6b4a-4ca1-85a1-e46ddb68ae87"),
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
                                Id = new Guid("0690f02e-2e7b-40ce-b8cf-66f11aa197b7"),
                                QuestionId = new Guid("0ab99b67-6b4a-4ca1-85a1-e46ddb68ae87"),
                                Value = "0",
                                Text = "Understands—Clear comprehension",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("cca5368d-f4d2-4a37-9d76-57ce70fa0432"),
                                QuestionId = new Guid("0ab99b67-6b4a-4ca1-85a1-e46ddb68ae87"),
                                Value = "1",
                                Text = "Usually understands—Misses some part / intent of message BUT comprehends most conversation",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e618d1c4-b1d6-4942-af4a-d5445d4b84f8"),
                                QuestionId = new Guid("0ab99b67-6b4a-4ca1-85a1-e46ddb68ae87"),
                                Value = "2",
                                Text = "Often understands—Misses some part / intent of message BUT with repetition or explanation can often comprehend conversation",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("13143480-28be-4328-98ff-90eebcc4188b"),
                                QuestionId = new Guid("0ab99b67-6b4a-4ca1-85a1-e46ddb68ae87"),
                                Value = "3",
                                Text = "Sometimes understands—Responds adequately to simple, direct communication only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("51e7036e-1b67-484e-967b-bc09523b9432"),
                                QuestionId = new Guid("0ab99b67-6b4a-4ca1-85a1-e46ddb68ae87"),
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
                        Id = new Guid("7418017a-4477-4d11-8dec-8ae0efe121b5"),
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
                                Id = new Guid("334aee56-94f0-4182-869e-93d1433dc819"),
                                QuestionId = new Guid("7418017a-4477-4d11-8dec-8ae0efe121b5"),
                                Value = "0",
                                Text = "Adequate—No difficulty in normal conversation, social interaction, listening to TV",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("af12cad6-c4f9-4755-85d1-465f7bb0d5d5"),
                                QuestionId = new Guid("7418017a-4477-4d11-8dec-8ae0efe121b5"),
                                Value = "1",
                                Text = "Minimal difficulty—Difficulty in some environments (e.g., when person speaks softly or is more than 2 metres [6 feet] away)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("213609ce-7753-45a8-80ba-4e0daae66ef1"),
                                QuestionId = new Guid("7418017a-4477-4d11-8dec-8ae0efe121b5"),
                                Value = "2",
                                Text = "Moderate difficulty—Problem hearing normal conversation, requires quiet setting to hear well",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("fc21b75b-040c-44f8-b8dc-2e32106ea07f"),
                                QuestionId = new Guid("7418017a-4477-4d11-8dec-8ae0efe121b5"),
                                Value = "3",
                                Text = "Severe difficulty—Difficulty in all situations (e.g., speaker has to talk loudly or speak very slowly; or person reports that all speech is mumbled)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3ce0dda1-09fe-42c2-bc76-f139ca29d43e"),
                                QuestionId = new Guid("7418017a-4477-4d11-8dec-8ae0efe121b5"),
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
                        Id = new Guid("e34f4f90-c24b-4e97-bf64-f823a7e7805c"),
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
                                Id = new Guid("7ef3b916-8356-4827-8570-9a9b46fc935a"),
                                QuestionId = new Guid("e34f4f90-c24b-4e97-bf64-f823a7e7805c"),
                                Value = "0",
                                Text = "Adequate—Sees fine detail, including regular print in newspapers / books",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("56b94691-8630-4b9d-b427-909864273afb"),
                                QuestionId = new Guid("e34f4f90-c24b-4e97-bf64-f823a7e7805c"),
                                Value = "1",
                                Text = "Minimal difficulty—Sees large print, but not regular print in newspapers / books",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("cc23c2e9-513b-4d71-9a13-917334e8e099"),
                                QuestionId = new Guid("e34f4f90-c24b-4e97-bf64-f823a7e7805c"),
                                Value = "2",
                                Text = "Moderate difficulty—Limited vision; not able to see newspaper headlines, but can identify objects",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e2434c68-4277-4b27-9ad8-1a13224e62b3"),
                                QuestionId = new Guid("e34f4f90-c24b-4e97-bf64-f823a7e7805c"),
                                Value = "3",
                                Text = "Severe difficulty—Object identification in question, but eyes appear to follow objects; sees only light, colours, shapes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("33b93ce4-be41-4181-a03d-2a1955ec55d4"),
                                QuestionId = new Guid("e34f4f90-c24b-4e97-bf64-f823a7e7805c"),
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
                Id = new Guid("3181c1fb-c701-4add-8d41-7548348d27e1"),
                Index = "H",
                Description = "Cognition",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
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
                                Id = new Guid("1ba9d937-32d3-429d-a7ff-7fc88406abe7"),
                                QuestionId = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
                                Value = "0",
                                Text = "Independent—Decisions consistent, reasonable, and safe",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e437461c-d414-4dae-84e3-1d9f552a6553"),
                                QuestionId = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
                                Value = "1",
                                Text = "Modified independence—Some difficulty in new situations only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("69cc845d-7437-412f-84e8-6215471f9838"),
                                QuestionId = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
                                Value = "2",
                                Text = "Minimally impaired—In specific recurring situations, decisions become poor or unsafe; cues / supervision necessary at those times",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0c5e178f-e967-4ff7-90f7-741804cfcb71"),
                                QuestionId = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
                                Value = "3",
                                Text = "Moderately impaired—Decisions consistently poor or unsafe; cues / supervision required at all times",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3dfa396e-9705-48be-b5c5-cff7458b5415"),
                                QuestionId = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
                                Value = "4",
                                Text = "Severely impaired—Never or rarely makes decisions",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4aa90a59-4f74-4c0d-a4c3-52df7c502c04"),
                                QuestionId = new Guid("ca158a82-a17b-46d2-beb8-94882cad95f3"),
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
                        Id = new Guid("e77ecb56-e4bc-4df8-a4e4-c936d20c9036"),
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
                                Id = new Guid("c6e2b2f9-13c5-458e-a0b7-be19a50e67a7"),
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
                                Id = new Guid("f2639c9f-5ec2-483c-8382-4745939ff0de"),
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
                                Id = new Guid("51a8ab54-ab2f-4925-afda-668f56efbd43"),
                                Index = "c",
                                Name = "SituationalMemoryOkBoth_H2c",
                                Text = "Situational memory OK—Both",
                                SubText = "Recognizes caregivers’ names / faces frequently encountered AND knows location of places regularly visited (bedroom, dining room, activity room, therapy room)",
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
                        Id = new Guid("b21b4c6f-8f6b-48df-9364-83738d153812"),
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
                                Id = new Guid("431a8578-1662-461d-a86c-ba57440c3964"),
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
                                Id = new Guid("a2f015f7-6cbf-48d7-ae25-f31aa7e60df6"),
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
                                Id = new Guid("d8c33237-69b1-4c01-8c6e-52aa2ac6fd2b"),
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
                        Id = new Guid("83262fa2-f2b6-4cea-bc60-e3cd88d5b4b6"),
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
                                Id = new Guid("5ae4530f-2a33-40ed-92ce-14a0b96f91d4"),
                                QuestionId = new Guid("83262fa2-f2b6-4cea-bc60-e3cd88d5b4b6"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b6225c7e-fab4-4410-8290-c633ba5e26bb"),
                                QuestionId = new Guid("83262fa2-f2b6-4cea-bc60-e3cd88d5b4b6"),
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
                        Id = new Guid("83540986-553f-4d65-86b6-69b92f78dda6"),
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
                                Id = new Guid("e25e5901-250d-4aba-a044-39a025634427"),
                                QuestionId = new Guid("83540986-553f-4d65-86b6-69b92f78dda6"),
                                Value = "0",
                                Text = "Improved",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("69873188-60ba-4901-8b0a-d804a3b9fe57"),
                                QuestionId = new Guid("83540986-553f-4d65-86b6-69b92f78dda6"),
                                Value = "1",
                                Text = "No change",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1ccc1836-281a-434f-a72c-5d0d84e4cd9a"),
                                QuestionId = new Guid("83540986-553f-4d65-86b6-69b92f78dda6"),
                                Value = "2",
                                Text = "Declined",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4d0b1af2-45db-4c81-aa5c-ff78f1a43741"),
                                QuestionId = new Guid("83540986-553f-4d65-86b6-69b92f78dda6"),
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
                Id = new Guid("e6e03aae-eac5-44bf-89ec-5bbdc67187b6"),
                Index = "I",
                Description = "Health Conditions",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("888b1e99-53f6-4faf-b16e-33afa56e8962"),
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
                                Id = new Guid("9a7b7ab6-7325-4056-8ad0-e6c53e93b62f"),
                                QuestionId = new Guid("888b1e99-53f6-4faf-b16e-33afa56e8962"),
                                Value = "0",
                                Text = "Excellent",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c698b9c8-e865-4f7d-a5cc-beea4d070204"),
                                QuestionId = new Guid("888b1e99-53f6-4faf-b16e-33afa56e8962"),
                                Value = "1",
                                Text = "Good",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9553c5e0-5f5a-4820-877a-86ba5b32e636"),
                                QuestionId = new Guid("888b1e99-53f6-4faf-b16e-33afa56e8962"),
                                Value = "2",
                                Text = "Fair",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a814be79-e830-4ced-9795-554c24089439"),
                                QuestionId = new Guid("888b1e99-53f6-4faf-b16e-33afa56e8962"),
                                Value = "3",
                                Text = "Poor",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c1894313-d7d4-48b5-a629-52f6fca0c792"),
                                QuestionId = new Guid("888b1e99-53f6-4faf-b16e-33afa56e8962"),
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
                        Id = new Guid("e3475f0e-921b-4b26-a32e-7029505c5058"),
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
                                Id = new Guid("d6f5d5b6-986c-40ee-bcaf-9b72bd9b323f"),
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
                                Id = new Guid("133d662f-5f8c-4a91-b965-7db9d288ad3f"),
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
                                Id = new Guid("9c2c1e75-bdd1-4c9a-ba65-7665dfff9407"),
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
                                Id = new Guid("3d3726d8-799e-4e73-910b-28419963658d"),
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
                                Id = new Guid("99a690d1-8d2f-4ebe-811b-ead782961dae"),
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
                                Id = new Guid("b837310e-815d-47a5-83ea-94a2aa9f67bb"),
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
                                Id = new Guid("da23340d-2776-4c02-8b01-14bdfbd00d1d"),
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
                                Id = new Guid("00f89fd3-6081-4150-8971-aa4260689869"),
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
                                Id = new Guid("444bc1c6-e21c-4ed8-986d-c0fbc19a4bb8"),
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
                                Id = new Guid("38d0745d-1286-4191-9b34-15861c393a0e"),
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
                                Id = new Guid("0315f1af-1194-4942-9df7-fe3513df0c7c"),
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
                                Id = new Guid("754ac655-330d-4c01-8e61-6b738c04e7a1"),
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
                                Id = new Guid("d478b114-9567-48ef-b15f-1fc52b64d30c"),
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
                                Id = new Guid("2297c645-8f8e-4dbf-b366-50205317df37"),
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
                                Id = new Guid("ec35e72d-e139-4618-9019-f780703a7335"),
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
                                Id = new Guid("8c4028da-2365-4a10-9253-8636aeaf597c"),
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
                                Id = new Guid("befb2d00-9247-4225-be04-88199fab910a"),
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
                                Id = new Guid("cffbfa32-b4ed-462f-9728-6ad7baa6624f"),
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
                                Id = new Guid("9971048d-38a0-46a9-8b43-bed824485812"),
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
                        Id = new Guid("ac704393-e70e-4c3a-a498-9d88a751a799"),
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
                                Id = new Guid("997f09b0-6516-4edf-9f7b-e684d1340f81"),
                                QuestionId = new Guid("ac704393-e70e-4c3a-a498-9d88a751a799"),
                                Value = "0",
                                Text = "Absence of symptom",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7584c006-c73b-4534-9514-ba1ef9c1797c"),
                                QuestionId = new Guid("ac704393-e70e-4c3a-a498-9d88a751a799"),
                                Value = "1",
                                Text = "Absent at rest, but present when performed moderate activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("bbf12218-e30c-4cfb-9d7c-9e6d18087502"),
                                QuestionId = new Guid("ac704393-e70e-4c3a-a498-9d88a751a799"),
                                Value = "2",
                                Text = "Absent at rest, but present when performed normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("26bff11a-6887-4f88-927d-11bb2f44c6e2"),
                                QuestionId = new Guid("ac704393-e70e-4c3a-a498-9d88a751a799"),
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
                        Id = new Guid("0b8aa8d2-3698-4516-b307-85af3aeac9dd"),
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
                                Id = new Guid("a320f9e8-0ebb-4671-8e62-ae0f02928450"),
                                QuestionId = new Guid("0b8aa8d2-3698-4516-b307-85af3aeac9dd"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("fcddf8a2-8f5a-488a-a367-cce0bd70fc9a"),
                                QuestionId = new Guid("0b8aa8d2-3698-4516-b307-85af3aeac9dd"),
                                Value = "1",
                                Text = "Minimal—Diminished energy but completes normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6571c558-bb44-4758-a111-48e4a92ecde9"),
                                QuestionId = new Guid("0b8aa8d2-3698-4516-b307-85af3aeac9dd"),
                                Value = "2",
                                Text = "Moderate—Due to diminished energy, UNABLE TO FINISH normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c6c3e74c-635e-4e23-8cb5-f2df5204deff"),
                                QuestionId = new Guid("0b8aa8d2-3698-4516-b307-85af3aeac9dd"),
                                Value = "3",
                                Text = "Severe—Due to diminished energy, UNABLE TO START SOME normal day-to-day activities",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9b07ad11-9f06-4d9c-8281-724d701a6bf2"),
                                QuestionId = new Guid("0b8aa8d2-3698-4516-b307-85af3aeac9dd"),
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
                        Id = new Guid("5724d527-4d3e-4366-b2e0-ad03db177561"),
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
                                Id = new Guid("63486d96-86c2-4fc2-b6b2-90f45fdc9afe"),
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
                                Id = new Guid("71dbff85-7b0d-4eeb-a4e1-a57044774220"),
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
                                Id = new Guid("c8688e9d-007f-4655-858c-a922429ad191"),
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
                                Id = new Guid("c3f03a2d-6087-4236-a53a-5c7f4af80203"),
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
                                Id = new Guid("c825395c-1806-421c-83f2-0645256dca4a"),
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
                                Id = new Guid("2a2bfb64-d177-4ddc-ab5c-b0abaf3d9276"),
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
                                Id = new Guid("584322b0-a79f-4586-ad66-dfd3e418ee30"),
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
                        Id = new Guid("ca797f2e-3e3a-4493-8f21-07cf6525bb47"),
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
                                Id = new Guid("a67c52d3-32cb-4f70-8628-dd845852d9cd"),
                                QuestionId = new Guid("ca797f2e-3e3a-4493-8f21-07cf6525bb47"),
                                Value = "0",
                                Text = "No fall in last 90 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("fae6ba7c-f8a5-49e8-9fe8-8f51ce3b2f8b"),
                                QuestionId = new Guid("ca797f2e-3e3a-4493-8f21-07cf6525bb47"),
                                Value = "1",
                                Text = "No fall in last 30 days, but fell 31–90 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("19315365-620d-4963-a023-ed23352b88c3"),
                                QuestionId = new Guid("ca797f2e-3e3a-4493-8f21-07cf6525bb47"),
                                Value = "2",
                                Text = "One fall in last 30 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d3816b01-1fd2-4bcf-8d64-368f805d773f"),
                                QuestionId = new Guid("ca797f2e-3e3a-4493-8f21-07cf6525bb47"),
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
                        Id = new Guid("b2df4ee3-9e9c-40b8-ab78-9420901aed5c"),
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
                                Id = new Guid("1c4ee25e-2ab2-478d-99f3-384d49212d4b"),
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
                                Id = new Guid("8cef1f79-108d-4e10-9339-785792a4a28e"),
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
                                Id = new Guid("5aa9dd0c-78ca-4917-9464-5d93cda3f96c"),
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
                                Id = new Guid("b31f5104-8c1e-46a5-9ca5-e19c4bb81bd6"),
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
                        Id = new Guid("863f2e97-6107-4c4a-8726-92145d66ab94"),
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
                                Id = new Guid("111d7c3f-719b-496a-84bf-d6318756d1a9"),
                                QuestionId = new Guid("863f2e97-6107-4c4a-8726-92145d66ab94"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("657e70fb-1661-4696-8535-9a8affe551a3"),
                                QuestionId = new Guid("863f2e97-6107-4c4a-8726-92145d66ab94"),
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
                        Id = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
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
                                Id = new Guid("9f094ad8-3bed-46f8-990c-bed62904133e"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
                                Value = "0",
                                Text = "Continent—Complete control; DOES NOT USE any type of catheter or other urinary collection device",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("843acf06-f9df-467e-85e0-a59407f8970e"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
                                Value = "1",
                                Text = "Control with any catheter or ostomy over last 3 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9034af2b-1988-43f0-b48a-0b475ce6dc02"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
                                Value = "2",
                                Text = "Infrequently incontinent—Not incontinent over last 3 days, but does have incontinent episodes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4543ea96-1ef0-4a69-87cc-f9a601b6c53b"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
                                Value = "3",
                                Text = "Occasionally incontinent—Less than daily",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ee9f6deb-1784-45ad-a599-4008193c08ce"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
                                Value = "4",
                                Text = "Frequently incontinent—Daily, but some control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("435cc0f3-639f-4625-a825-cf121ef7f457"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
                                Value = "5",
                                Text = "Incontinent—No control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("611c77d6-d5f3-4f59-bc55-f82914de397a"),
                                QuestionId = new Guid("fa34304d-8e33-46a6-afbb-1b9285a2c941"),
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
                        Id = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
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
                                Id = new Guid("e431880d-2815-4c61-a56c-22d4241856df"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
                                Value = "0",
                                Text = "Continent—Complete control; DOES NOT USE any type of ostomy device",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("457b5554-0a97-4a8b-87b6-f119472bf848"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
                                Value = "1",
                                Text = "Control with ostomy—Control with ostomy device over last 3 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d1a8a442-d57f-413e-9001-d21c4020f518"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
                                Value = "2",
                                Text = "Infrequently incontinent—Not incontinent over last 3 days, but does have incontinent episodes",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2bd6e48a-9101-49cc-9917-9a4a9b81c478"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
                                Value = "3",
                                Text = "Occasionally incontinent—Less than daily",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("55d04927-af68-42b3-b887-9c4201824bbb"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
                                Value = "4",
                                Text = "Frequently incontinent—Daily, but some control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9ab59fd3-47b2-4b46-b650-d367f2271ba9"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
                                Value = "5",
                                Text = "Incontinent—No control present",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4a951928-002a-4f44-9a03-566196cfd58b"),
                                QuestionId = new Guid("ca20407d-04e3-4626-b14f-d2876a49cd28"),
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
                        Id = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
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
                                Id = new Guid("8857fb1b-2de9-4bd1-8c21-aa657af52b49"),
                                QuestionId = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
                                Value = "0",
                                Text = "No pressure ulcer",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("e564f0b5-a8ec-4436-987e-9dabace37919"),
                                QuestionId = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
                                Value = "1",
                                Text = "Any area of persistent skin redness",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("51ed0758-5bdc-4e36-88e7-73e0030fc714"),
                                QuestionId = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
                                Value = "2",
                                Text = "Partial loss of skin layers",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("9dd5c2b6-ca63-4461-9324-9244d417274c"),
                                QuestionId = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
                                Value = "3",
                                Text = "Deep craters in the skin",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4068f45f-9318-4333-976b-829dc98180e4"),
                                QuestionId = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
                                Value = "4",
                                Text = "Breaks in skin exposing muscle or bone",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("49b9b04c-5231-4956-9381-488f096949cd"),
                                QuestionId = new Guid("8a9e809a-3932-49c6-b0e6-1a09a9f2671f"),
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
                        Id = new Guid("8c968b12-c349-4dd2-a2dd-e8ba57a9768e"),
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
                                Id = new Guid("2ae393c9-dc38-4d53-8218-2d9b3c28523f"),
                                QuestionId = new Guid("8c968b12-c349-4dd2-a2dd-e8ba57a9768e"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("3c8ab1de-ed4d-41ca-a3f2-2a232b103ead"),
                                QuestionId = new Guid("8c968b12-c349-4dd2-a2dd-e8ba57a9768e"),
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
                        Id = new Guid("af63077d-6bbc-4989-b64e-9dc5092ffe0b"),
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
                                Id = new Guid("697e7d54-344b-4b26-9392-30514fc25b13"),
                                QuestionId = new Guid("af63077d-6bbc-4989-b64e-9dc5092ffe0b"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b6303b41-12d9-4fee-969f-c6a69569c5ae"),
                                QuestionId = new Guid("af63077d-6bbc-4989-b64e-9dc5092ffe0b"),
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
                        Id = new Guid("cad9fdf3-63a1-4b4c-b9c3-cca4e2940c34"),
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
                                Id = new Guid("6b9c562f-8876-4c3d-906e-7f2706ae139e"),
                                QuestionId = new Guid("cad9fdf3-63a1-4b4c-b9c3-cca4e2940c34"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("42584378-831b-4957-8522-42ca93a9ccb1"),
                                QuestionId = new Guid("cad9fdf3-63a1-4b4c-b9c3-cca4e2940c34"),
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
                        Id = new Guid("b2fad60b-5b5d-480a-b5fa-32dce4f35f50"),
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
                                Id = new Guid("651e65e6-ce48-45c4-94e5-659f3eb82e08"),
                                QuestionId = new Guid("b2fad60b-5b5d-480a-b5fa-32dce4f35f50"),
                                Value = "0",
                                Text = "No foot problems",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("db4ec387-6dc0-4923-a1c8-99ff0164019d"),
                                QuestionId = new Guid("b2fad60b-5b5d-480a-b5fa-32dce4f35f50"),
                                Value = "1",
                                Text = "Foot problems, no limitation in walking",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b319273b-b42d-43d9-988e-d7045b2d0ef7"),
                                QuestionId = new Guid("b2fad60b-5b5d-480a-b5fa-32dce4f35f50"),
                                Value = "2",
                                Text = "Foot problems limit walking",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d5d0bc8b-1884-466a-8873-10a11aaf3309"),
                                QuestionId = new Guid("b2fad60b-5b5d-480a-b5fa-32dce4f35f50"),
                                Value = "3",
                                Text = "Foot problems prevent walking",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c4c768b6-8bcc-4a59-be61-cb867994cf2e"),
                                QuestionId = new Guid("b2fad60b-5b5d-480a-b5fa-32dce4f35f50"),
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
                Id = new Guid("f8ae62d5-b947-438f-8dff-61d32a1e3316"),
                Index = "J",
                Description = "Independence in Everyday Activities",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("3e5920ac-5dff-4793-970b-7032cc9c21bd"),
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
                                Id = new Guid("885b3382-1420-4834-981d-730f38152d4b"),
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
                                Id = new Guid("aefd6406-6e69-48b2-9c7e-11d0be7c5c48"),
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
                                Id = new Guid("16087b30-8cd3-4e02-af68-db4f06e58978"),
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
                                Id = new Guid("91f64d07-f747-4a94-883a-6f356936846e"),
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
                                Id = new Guid("354c3bbe-2b1b-4bbc-ac31-932d5fd10eeb"),
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
                                Id = new Guid("3c7055a5-4b85-4cf9-8581-5f0c28b7c945"),
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
                                Id = new Guid("e9e4582a-e452-4337-8e99-da2870da507f"),
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
                                Id = new Guid("7085805b-0d2c-4cc6-9893-8e7c2eb0c552"),
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
                        Id = new Guid("6c650791-8a5e-4f32-a30c-bb5954770fae"),
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
                                Id = new Guid("bc03950f-e80b-4208-be59-372ff5a0f40f"),
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
                                Id = new Guid("3a664c8b-5cce-4659-98d5-8fe2d3688647"),
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
                                Id = new Guid("03a862a3-f548-4c34-8eec-29af6b20d4f7"),
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
                                Id = new Guid("3008f91d-7401-4546-a0fc-4b0bb4eaa683"),
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
                                Id = new Guid("06bc925a-b5ca-4cd4-92a7-c22f8ec149d0"),
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
                                Id = new Guid("ec748a15-4ee9-4fee-bc3e-494c6e10ca06"),
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
                                Id = new Guid("7cd79822-6d9b-4691-8ce0-ba6694aa4f55"),
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
                                Id = new Guid("a00d0dcc-2465-47d2-9691-faf0541d2fb5"),
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
                        Id = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
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
                                Id = new Guid("78fef833-6f4b-4896-a184-e1a4564d14d5"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "0",
                                Text = "Independent—No help, set-up, or supervision",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("97704996-2919-44eb-baa9-0558835b9baf"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "1",
                                Text = "Set-up help only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d4b89029-a74e-4292-8a47-8af505040765"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "2",
                                Text = "Supervision—Oversight / cueing",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2dea3868-3388-4202-a8a6-177ee554c244"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "3",
                                Text = "Limited assistance—Help on some occasions",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6690b011-a3a0-4c92-84f4-60be08816237"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "4",
                                Text = "Extensive assistance—Help throughout task, but performs 50% or more of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("dad202c7-1f9d-4d8d-8f5b-0fb6f5615d8b"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "5",
                                Text = "Maximal assistance—Help throughout task, but performs less than 50% of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7f17e3f3-4392-4d91-9b0c-9ce650665163"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
                                Value = "6",
                                Text = "Total dependence—Full performance by others during entire period",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4394621b-6272-41ed-9387-8d2cce4d18e6"),
                                QuestionId = new Guid("0525d21a-421d-44ac-95ed-c02c759d79d7"),
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
                        Id = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
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
                                Id = new Guid("54590c30-11dd-4445-a238-713c5d18e174"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "0",
                                Text = "Independent—No help, set-up, or supervision",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("014f7001-92f1-4766-aae7-ff1444b5d94a"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "1",
                                Text = "Set-up help only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4c670598-1c16-4ced-9ccc-8b5480f3f86b"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "2",
                                Text = "Supervision—Oversight / cueing",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("91e8eef8-85b5-4e90-b378-18c296db932a"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "3",
                                Text = "Limited assistance—Help on some occasions",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1e4d8260-153e-42ce-8e33-5c896f4f9375"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "4",
                                Text = "Extensive assistance—Help throughout task, but performs 50% or more of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("622e4245-71f5-46f4-9b93-704ef3115e15"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "5",
                                Text = "Maximal assistance—Help throughout task, but performs less than 50% of task on own",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2296963e-d722-430d-922c-c4900332b105"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
                                Value = "6",
                                Text = "Total dependence—Full performance by others during entire period",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("709e94fb-4f6e-41e8-8953-eddc6559941a"),
                                QuestionId = new Guid("49d778f6-4c5a-42d8-bf76-aa04318d2866"),
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
                        Id = new Guid("f9223571-dbeb-4fe8-bc46-813c48d6a7f1"),
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
                                Id = new Guid("e6277492-1c86-4293-bc01-898af538388f"),
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
                                Id = new Guid("c301a4ad-6c3f-472b-a0f4-72da10820e37"),
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
                                Id = new Guid("679c6969-a15e-47f8-a101-3a88b79b2ed6"),
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
                                Id = new Guid("f8e40394-6fac-4cc2-af6f-5ca4dcbd4715"),
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
                                Id = new Guid("38c76641-07ab-43ff-bc67-4dc05048d51a"),
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
                                Id = new Guid("2c7e4d73-7cd3-435b-85b9-3497a42c1db0"),
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
                                Id = new Guid("32e29b77-58e6-4bd3-99a1-d6f937959812"),
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
                                Id = new Guid("ede06e1a-85c4-4339-a2e9-18468eb80d02"),
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
                                Id = new Guid("ddbe3969-1cce-4b8b-aa1a-ac776e53f1ff"),
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
                                Id = new Guid("06a31d2d-eda5-40e8-bb70-a8e2ed302dd4"),
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
                        Id = new Guid("e212d531-9272-4b23-8e29-aa6d8756c4b3"),
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
                                Id = new Guid("4ee2d0a0-a34b-4481-a59d-ee15fb080df8"),
                                QuestionId = new Guid("e212d531-9272-4b23-8e29-aa6d8756c4b3"),
                                Value = "0",
                                Text = "Walking, no assistive device",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("42cf047a-63ea-4507-a13a-bbaeefa3b99b"),
                                QuestionId = new Guid("e212d531-9272-4b23-8e29-aa6d8756c4b3"),
                                Value = "1",
                                Text = "Walking, uses assistive device—e.g., cane, walker, crutch, pushing wheelchair",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ac29ee2b-1a63-438a-87a2-a863ca005170"),
                                QuestionId = new Guid("e212d531-9272-4b23-8e29-aa6d8756c4b3"),
                                Value = "2",
                                Text = "Wheelchair, scooter",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("18ac07fe-e60a-492c-a640-ac26e98e78c9"),
                                QuestionId = new Guid("e212d531-9272-4b23-8e29-aa6d8756c4b3"),
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
                        Id = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
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
                                Id = new Guid("762c4407-3875-47bc-a563-c596fc7b9f81"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
                                Value = "0",
                                Text = "Wheeled by others",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("55b2b035-3b7c-4470-8043-b9b8c22f9c4a"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
                                Value = "1",
                                Text = "Used motorized wheelchair / scooter",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d8491ff6-2994-4d6e-a041-549e95ba9190"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
                                Value = "2",
                                Text = "Wheeled self less than 5 metres (under 15 feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("611b2477-6dde-4cd5-82c1-f8e1c8409c24"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
                                Value = "3",
                                Text = "Wheeled self 5–49 metres (15–149 feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("595d3239-0109-4b80-8cf9-8e2d8292e396"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
                                Value = "4",
                                Text = "Wheeled self 50–99 metres (150–299 feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c668b62d-b248-4492-a979-985a8ab61b57"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
                                Value = "5",
                                Text = "Wheeled self 100+ metres (300+ feet)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("fcebd04d-b950-4ea7-9b5f-55b4f1241b78"),
                                QuestionId = new Guid("24f60ade-b71d-4f18-94fc-20f7c5fc1f97"),
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
                        Id = new Guid("6a4dfd69-355d-497f-887d-e98ec7a728b7"),
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
                                Id = new Guid("40b6c09d-8bdc-450e-9609-4c0a9903955a"),
                                QuestionId = new Guid("6a4dfd69-355d-497f-887d-e98ec7a728b7"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ce67b002-75a2-4f2f-a6ba-2fe9ae2c1da8"),
                                QuestionId = new Guid("6a4dfd69-355d-497f-887d-e98ec7a728b7"),
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
                        Id = new Guid("2477edbd-43f5-4b7f-8726-7a613d489858"),
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
                                Id = new Guid("26548cbf-2882-45b7-9c35-e68bac3a0b1a"),
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
                                Id = new Guid("815139cc-c6ea-4224-9219-5a36cb139756"),
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
                        Id = new Guid("c71619ed-edd1-4ade-a2b0-ef4ba473fb90"),
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
                                Id = new Guid("7507fcf2-0822-4ce6-9fd4-f12006198722"),
                                QuestionId = new Guid("c71619ed-edd1-4ade-a2b0-ef4ba473fb90"),
                                Value = "0",
                                Text = "Improved",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("119257a1-a32f-4f61-8b97-5db4c78828ad"),
                                QuestionId = new Guid("c71619ed-edd1-4ade-a2b0-ef4ba473fb90"),
                                Value = "1",
                                Text = "No change",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d6ec93fe-11fd-4905-a7aa-68d96fe81ea4"),
                                QuestionId = new Guid("c71619ed-edd1-4ade-a2b0-ef4ba473fb90"),
                                Value = "2",
                                Text = "Declined",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7fc04d3c-6eff-4138-b4d6-19427e5c6392"),
                                QuestionId = new Guid("c71619ed-edd1-4ade-a2b0-ef4ba473fb90"),
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
                Id = new Guid("c9001bcb-dcbb-40ea-8c0c-298b32cbe934"),
                Index = "K",
                Description = "Oral and Nutritional Status",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("ff3f80bb-0cb5-4542-afc7-b4b731a5b99c"),
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
                                Id = new Guid("769acc09-5d4a-489a-956a-7e4ae9956231"),
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
                                Id = new Guid("711818a3-6c0f-4962-84bd-fd9e1a8a2fd2"),
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
                        Id = new Guid("522b8a12-b418-4365-a6a2-039a381244da"),
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
                                Id = new Guid("cca567a3-14f9-4348-8885-28d5c30677bd"),
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
                                Id = new Guid("7dc89f4e-0616-4742-9e58-e76fd2558b6b"),
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
                                Id = new Guid("00544c75-6c21-4b71-bf8d-864396e298cd"),
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
                        Id = new Guid("8fa72800-6914-4e6e-91f1-0898124afead"),
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
                                Id = new Guid("9f353dca-6f74-4bf9-9021-4b3be78a66ec"),
                                QuestionId = new Guid("8fa72800-6914-4e6e-91f1-0898124afead"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("08d92cf2-3423-4f02-ae35-5420979b747d"),
                                QuestionId = new Guid("8fa72800-6914-4e6e-91f1-0898124afead"),
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
                        Id = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
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
                                Id = new Guid("586f86b5-27a0-47ce-9da3-1e09b977cba0"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "0",
                                Text = "Normal—Swallows all types of foods",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5011fe0b-fb2f-4ae0-9193-f259c9eb3a74"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "1",
                                Text = "Modified independent—e.g., liquid is sipped, takes limited solid food, need for modification may be unknown",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2f991a79-38e1-4b33-8213-cdec26aa80a6"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "2",
                                Text = "Requires diet modification to swallow solid food—e.g., mechanical diet (e.g., pureed, minced) or only able to ingest specific foods",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("b7fe6f1f-ebd3-4e86-91b2-f048719601d9"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "3",
                                Text = "Requires modification to swallow liquids—e.g., thickened liquids",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c0615cf0-6b1d-4b61-957b-5344a32efeda"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "4",
                                Text = "Can swallow only puréed solids—AND—thickened liquids",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("aa094f7e-dc37-426f-9d6a-4ff5efb4770b"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "5",
                                Text = "Combined oral and parenteral or tube feeding",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("90ec8329-2e32-44fe-bae3-853e3c0330a0"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "6",
                                Text = "Nasogastric tube feeding only",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6538e29f-7034-4c5a-aef7-ac61b1e560a5"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "7",
                                Text = "Abdominal tube feeding—e.g., PEG tube",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a2dd6f24-d23e-4002-88b3-bd9f68a7990c"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
                                Value = "8",
                                Text = "Parenteral feeding only—Includes all types of parenteral feedings, such as total parenteral nutrition (TPN)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a759d017-f33a-44f6-a2bd-ab1613318e69"),
                                QuestionId = new Guid("0f401ec5-8466-4c8b-9fdc-f9d1c9c67ef1"),
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
                        Id = new Guid("314cae70-03dd-44ab-a49c-93535507e1d6"),
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
                                Id = new Guid("344279ab-4342-48c7-894e-29aeb3087f22"),
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
                                Id = new Guid("963cebd0-31fe-4563-8fbd-a8061041cbcb"),
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
                                Id = new Guid("a283ebd9-9264-45db-9c83-e3fb06d0313b"),
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
                Id = new Guid("5dd8bf4a-c30c-4a7c-b80f-028f02870430"),
                Index = "L",
                Description = "Mood and Behaviour",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("f02320b8-abf1-4787-900e-23552bfda033"),
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
                                Id = new Guid("1aea33c4-0436-4748-a6dc-c7fd038a12da"),
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
                                Id = new Guid("939ecb1c-7b69-41e4-be06-ff2ac0e8e3f0"),
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
                                Id = new Guid("a486985c-19cb-46a5-9d35-0a0ee3f0d954"),
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
                                Id = new Guid("3a9c6868-4eac-4743-ab3a-aa3c78dde463"),
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
                                Id = new Guid("e68ceba0-85df-4e8b-8790-fc96ee42b97b"),
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
                                Id = new Guid("80408917-49a3-4377-adee-b3ce26161b1a"),
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
                                Id = new Guid("e1974ce2-154a-4561-971d-79578cd5f036"),
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
                                Id = new Guid("0a8db1a4-6471-4f98-8bda-656f700cb6b3"),
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
                                Id = new Guid("2a9e9d16-5ff8-446f-89de-54c0305842a6"),
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
                                Id = new Guid("5ba8237f-c27a-418d-ab02-a4bcd4525a10"),
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
                                Id = new Guid("33014548-1b1f-49be-9132-635dbe4dff44"),
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
                                Id = new Guid("002d935f-0190-4118-ae1b-db9b68c5c173"),
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
                                Id = new Guid("59b5449d-3ce3-4e08-9152-bb3043a56bd2"),
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
                                Id = new Guid("a79d4ad0-607a-44e8-9a77-79f00832bfbd"),
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
                                Id = new Guid("15d5bfa3-d3d4-4f2b-bf5e-3bf3e3a78c3d"),
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
                                Id = new Guid("edaa3a15-53ae-4d3d-b7f6-2fc30d60d4e9"),
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
                                Id = new Guid("426ebc1e-127b-465c-9741-bf7f07fb6f19"),
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
                                Id = new Guid("502c5883-55b6-429a-a01b-bcd344fa2842"),
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
                                Id = new Guid("36e52925-2e4d-45b1-b085-e0adae83e914"),
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
                                Id = new Guid("8f99902f-84bb-48e2-8e39-65fc53f3d713"),
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
                                Id = new Guid("5e166b3e-15de-4968-a5ab-e9cffb8975a0"),
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
                                Id = new Guid("759990d9-0ce8-4142-a77a-dff506e7dd83"),
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
                                Id = new Guid("4fd0e472-f254-4a77-bbaa-e2da58a928cc"),
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
                                Id = new Guid("8d0c2505-b5a6-49ac-8ebb-77fbbbedc515"),
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
                                Id = new Guid("7a0b34f0-e1d3-4299-94c2-5ae8bef5325b"),
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
                                Id = new Guid("60b310b1-2c6a-4bd8-8b25-106c01dba43b"),
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
                        Id = new Guid("e74a5e5d-caaf-4983-82c5-7185da100395"),
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
                                Id = new Guid("fa5cdc86-cf2f-476e-8688-13398b0327e6"),
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
                                Id = new Guid("1b5d2b4d-01cd-43df-8b72-73492ce2b306"),
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
                                Id = new Guid("d522cdc1-ea6f-4235-8854-318951e85f2c"),
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
                        Id = new Guid("ed1e3afa-0d34-4dd5-8fcd-074ad5b46bc1"),
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
                                Id = new Guid("0f59cec8-3910-456f-b968-d3a0c5a870e7"),
                                QuestionId = new Guid("ed1e3afa-0d34-4dd5-8fcd-074ad5b46bc1"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("010cefee-e14b-4056-8c68-93032c9de784"),
                                QuestionId = new Guid("ed1e3afa-0d34-4dd5-8fcd-074ad5b46bc1"),
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
                        Id = new Guid("4bf699e3-329a-48b3-b6fc-346b2acfe753"),
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
                                Id = new Guid("ed1eaaa6-7b02-4412-bed9-b6c9536dc838"),
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
                                Id = new Guid("6f16df84-a8e4-4431-bb91-bdd56e88a0bc"),
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
                                Id = new Guid("0affc837-d1a2-4cdd-aefd-eb14c1ff27d7"),
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
                                Id = new Guid("6e304b66-66a9-41c2-9699-05417a1d56f5"),
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
                                Id = new Guid("7bf6bc37-2bda-4626-a216-65ce508cde14"),
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
                                Id = new Guid("43e661a9-d29c-4b74-b252-dfbbfdb459d2"),
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
                                Id = new Guid("7bbef020-689f-4b80-b6a6-dfd1da1678c6"),
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
                                Id = new Guid("e0918bcc-7789-4e56-ab44-827aeea5d250"),
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
                                Id = new Guid("923d4445-d403-4429-b6b7-9dbb97a0e9d7"),
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
                                Id = new Guid("6cd7df5d-f734-41f0-88a7-e9ffbcdd577a"),
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
                                Id = new Guid("d2d32435-fb68-45da-ac44-087b19be9c09"),
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
                                Id = new Guid("2c5fbbd5-0282-4f56-861f-dd3b52954a01"),
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
                                Id = new Guid("9991559b-f7ce-41db-ad85-30de557275ac"),
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
                                Id = new Guid("f9c5587c-0a6f-45ae-94ed-ad483da758fd"),
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
                        Id = new Guid("a9ea680c-ee00-42e8-9ac7-0fce43584b4f"),
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
                                Id = new Guid("e18efd26-51f6-4745-8245-e05b3e1490ca"),
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
                                Id = new Guid("900b64e2-66f7-43a8-91e6-d989a7f889b6"),
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
                        Id = new Guid("cdf5e414-2a20-473f-8c92-7a801ce81c1e"),
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
                                Id = new Guid("bcce0b17-0edb-4555-9394-f85c00a8d5ae"),
                                QuestionId = new Guid("cdf5e414-2a20-473f-8c92-7a801ce81c1e"),
                                Value = "0",
                                Text = "No",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("469a1e2a-1027-4cca-9088-0a80a4d77d73"),
                                QuestionId = new Guid("cdf5e414-2a20-473f-8c92-7a801ce81c1e"),
                                Value = "1",
                                Text = "Yes, but not exhibited in last 7 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7a87f4e4-079a-41d8-8940-e407f76df908"),
                                QuestionId = new Guid("cdf5e414-2a20-473f-8c92-7a801ce81c1e"),
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
                Id = new Guid("e08cad40-da7f-4bbf-94bc-6cd5411f6d78"),
                Index = "M",
                Description = "Medications",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("6b082611-73b5-4eef-b865-299088865c68"),
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
                        Id = new Guid("6a7fb066-ffdd-476a-8b28-3c9075ecb7b0"),
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
                                Id = new Guid("4fe5a4d0-5895-48c0-919b-5ad04115918d"),
                                QuestionId = new Guid("6a7fb066-ffdd-476a-8b28-3c9075ecb7b0"),
                                Value = "0",
                                Text = "No known drug allergies",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4759bab5-96c8-46d6-a77c-b2d3b0d36832"),
                                QuestionId = new Guid("6a7fb066-ffdd-476a-8b28-3c9075ecb7b0"),
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
                        Id = new Guid("72836316-4a36-41b9-8785-c6fc7cfb93bb"),
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
                                Id = new Guid("fb552cbc-3b08-458c-a1b1-31a022ab7eb8"),
                                QuestionId = new Guid("72836316-4a36-41b9-8785-c6fc7cfb93bb"),
                                Value = "0",
                                Text = "Discussed with at least one physician (or no medication taken)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2082a94f-dc3c-4220-9a4f-44782b02359f"),
                                QuestionId = new Guid("72836316-4a36-41b9-8785-c6fc7cfb93bb"),
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
                        Id = new Guid("7c7321d5-512c-44dc-a62e-ae27fbab51f4"),
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
                                Id = new Guid("3711d516-6d17-4a6e-bd63-85645b7982c5"),
                                QuestionId = new Guid("7c7321d5-512c-44dc-a62e-ae27fbab51f4"),
                                Value = "0",
                                Text = "Always adherent",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6c939e40-0f61-4692-9485-def3504ed314"),
                                QuestionId = new Guid("7c7321d5-512c-44dc-a62e-ae27fbab51f4"),
                                Value = "1",
                                Text = "Adherent 80% of time or more",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("62f907b0-5427-43a9-88e0-0c67d064e78b"),
                                QuestionId = new Guid("7c7321d5-512c-44dc-a62e-ae27fbab51f4"),
                                Value = "2",
                                Text = "Adherent less than 80% of time, including failure to purchase prescribed medications",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("85692f5b-e5c4-453d-83a8-7fa7270f84e9"),
                                QuestionId = new Guid("7c7321d5-512c-44dc-a62e-ae27fbab51f4"),
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
                Id = new Guid("065a1014-2f30-46be-8139-7eb21b9dcd84"),
                Index = "N",
                Description = "Supports and Services",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("bbf2107b-bbea-4495-b024-2ee5a2ab94fb"),
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
                                Id = new Guid("947389c0-8dac-445c-81f0-c060c4dd5f04"),
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
                                Id = new Guid("52db1876-27e3-4e83-b8ee-b6eb3e350ef2"),
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
                                Id = new Guid("4aaaadc2-6a01-413d-a6a3-6edd858c887f"),
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
                                Id = new Guid("452a4124-6a70-4195-9e9b-83d20a773619"),
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
                                Id = new Guid("6ee700b8-a64f-4b9e-875e-0ac4aeb48e84"),
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
                        Id = new Guid("f3a9dfff-28aa-4190-9198-55fc4b96890d"),
                        Index = "2",
                        Name = "FormalServiceProviders_N2",
                        Text = "FORMAL SERVICE PROVIDERS",
                        SubText = "Contact with paid care provider in last 30 days (or since admission if LESS THAN 30 DAYS)",
                        DefaultValue = null,
                        QuestionType = "QUESTION_BREAKDOWN",
                        Choices = new List<ResponseModel>
                        {
                        },
                        SubQuestions = new List<QuestionModel>
                        {
                            new QuestionModel
                            {
                                Id = new Guid("d8d2d953-56ba-42f4-9a35-01eb9c3b9878"),
                                Index = "a",
                                Name = "DevelopmentalServicesWorkerOrDirectCareStaff_N2a",
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
                                Id = new Guid("84f97e8e-04da-4611-bcc7-13e3557de036"),
                                Index = "b",
                                Name = "OccupationalTherapistPhysicalTherapistOrSpeechTherapist_N2b",
                                Text = "Occupational therapist, physical therapist, or speech therapist",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("0e3dc1c0-46fe-4b51-bba8-56a99f094022"),
                                Index = "c",
                                Name = "RecreationTherapist_N2c",
                                Text = "Recreation therapist",
                                SubText = "",
                                DefaultValue = null,
                                QuestionType = "DROPDOWN_LIST",
                                Choices = new List<ResponseModel>
                                {
                                },
                            },
                            new QuestionModel
                            {
                                Id = new Guid("2e8c47b2-1460-41d4-b24d-e078fd5ba157"),
                                Index = "d",
                                Name = "Nurse_N2d",
                                Text = "Nurse",
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
                        Id = new Guid("64e9184a-d1ff-45ac-8eb6-07b45a024dfc"),
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
                                Id = new Guid("c57883df-cd5a-4952-873e-2674a9520298"),
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
                                Id = new Guid("c3b3c936-aac3-476e-8a57-12e513a7c944"),
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
                                Id = new Guid("2e502aaf-0279-4175-84c0-226d701d0403"),
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
                                Id = new Guid("55982196-3e63-473a-88b2-c1a8e9e8f680"),
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
                                Id = new Guid("69b0f79b-d381-48b8-a66e-4f332c46377c"),
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
                                Id = new Guid("d6e320bb-1f18-4f67-bdda-9e8e007ee475"),
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
                                Id = new Guid("9a07c8e4-3d03-4dde-8aab-97d71d55e771"),
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
                        Id = new Guid("c696dc50-ad19-46d1-949d-a1cf5fa515dc"),
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
                                Id = new Guid("260e5020-4182-49f2-ae18-e8c9f84fb1b2"),
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
                                Id = new Guid("537aa6d4-3e9c-441e-95f0-a9548a2a0f62"),
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
                                Id = new Guid("7a9990be-3809-445b-abac-2b9bf34f2d72"),
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
                                Id = new Guid("245adbb2-0bca-426d-bb6d-612492d5153d"),
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
                        Id = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
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
                                Id = new Guid("aaa2de2b-2a3e-4a5c-83d9-4381b9cf3dbd"),
                                QuestionId = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
                                Value = "0",
                                Text = "No hospitalization within 90 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("becdbcde-5312-4811-90bf-94e25eff2af7"),
                                QuestionId = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
                                Value = "1",
                                Text = "31–90 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("c0656685-50d8-40ba-9c02-75a9501b56f1"),
                                QuestionId = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
                                Value = "2",
                                Text = "15–30 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4d78da90-e00f-4802-ad43-8b03b53a6495"),
                                QuestionId = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
                                Value = "3",
                                Text = "8–14 days ago",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4dac0545-63f3-496a-bcad-6b03c0d08475"),
                                QuestionId = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
                                Value = "4",
                                Text = "In the last 7 days",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("4667b944-6af6-4af5-a186-d134d8403e8a"),
                                QuestionId = new Guid("c44fe45b-f976-452a-926e-10096f53fb70"),
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
                        Id = new Guid("a9611609-1017-469f-9e71-00e204cf657e"),
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
                                Id = new Guid("e368e48a-f237-4837-9639-00326653467d"),
                                QuestionId = new Guid("a9611609-1017-469f-9e71-00e204cf657e"),
                                Value = "0",
                                Text = "None",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("8b25eda4-1bf2-4a52-a9d1-428f12cf1354"),
                                QuestionId = new Guid("a9611609-1017-469f-9e71-00e204cf657e"),
                                Value = "1",
                                Text = "1–3",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("7858cf84-1565-4082-a3a4-948e00dd71b1"),
                                QuestionId = new Guid("a9611609-1017-469f-9e71-00e204cf657e"),
                                Value = "2",
                                Text = "4–5",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("0b03110b-31bd-4359-a778-6543f7a948c0"),
                                QuestionId = new Guid("a9611609-1017-469f-9e71-00e204cf657e"),
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
                Id = new Guid("582d09b5-301c-420c-bbcf-6bc13b15b174"),
                Index = "O",
                Description = "Diagnostic Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("f876148c-e7c0-4c61-a18d-391e6aeb88d0"),
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
                                Id = new Guid("416df9c2-765c-492e-98e9-63f30527efc5"),
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
                                Id = new Guid("e077f902-8574-4e35-8ef5-f739258abf5e"),
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
                                Id = new Guid("0208d6d2-da6d-453c-a91c-92a0119773ac"),
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
                                Id = new Guid("cb68682d-9724-4822-80d5-2fd841982070"),
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
                                Id = new Guid("ff5ba900-2852-4aea-8e7f-eeb9b05d20c0"),
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
                                Id = new Guid("f7ed024e-f533-46ce-919b-7ba0074d662e"),
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
                                Id = new Guid("74d101fc-e210-4b02-8dfa-56ed76fd00ca"),
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
                                Id = new Guid("08f58b4f-3f06-4765-baeb-3d1fec607853"),
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
                                Id = new Guid("3ae6a397-4a8f-4447-b5c0-23c5d37525fb"),
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
                        Id = new Guid("54af1075-c4fb-44e9-87c4-acd1407167c0"),
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
                                Id = new Guid("e432418a-1364-4a36-84a9-5362b922cc7b"),
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
                                Id = new Guid("cd563bcd-33f2-41d0-8422-7016ed0684a0"),
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
                                Id = new Guid("f59baef2-c041-4192-8737-581002c85564"),
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
                                Id = new Guid("252e771b-3a01-4c04-bea9-03281912c31a"),
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
                Id = new Guid("4ae8bc33-acd3-443d-bf9d-e71e57110df6"),
                Index = "P",
                Description = "Discharge Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("bd2faa42-457d-4c76-a373-9209b6630f09"),
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
                        Id = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
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
                                Id = new Guid("3f43d7d8-b430-4ad7-97bc-815d4b82f791"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "1",
                                Text = "Private home / apartment / rented room",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("22fc9ad8-3928-479c-9419-4ee07b37623b"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "2",
                                Text = "Board and care",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("5cd6134a-6f87-468d-8e4c-0a4e77b63cb1"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "3",
                                Text = "Assisted living or semi-independent living",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("a4dd5108-b9cc-430c-9a20-b618abc4e80e"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "4",
                                Text = "Mental health residence—e.g., psychiatric group home",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d3d5b669-d90b-4c82-bfba-e23fe4c042ba"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "5",
                                Text = "Group home for persons with physical disability",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("6d32cf92-d59e-4117-8429-aa11f43a3a93"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "6",
                                Text = "Setting for persons with intellectual disability",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("1289c585-4b8d-4fef-bc78-7521b98ff224"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "7",
                                Text = "Psychiatric hospital or unit",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("dbdbe740-5675-46e3-987d-b3a108395404"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "8",
                                Text = "Homeless (with or without shelter)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("32e4be70-db65-499f-85ce-7285f20863be"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "9",
                                Text = "Long-term care facility (nursing home)",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("2001b0c0-950a-4263-acda-14bf3c5552bd"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "10",
                                Text = "Rehabilitation hospital / unit",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("d68a1677-c55d-4e52-98e7-4fe96a715158"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "11",
                                Text = "Hospice facility / palliative care unit",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("989cd965-65cd-4f80-ac33-eff11fc075c4"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "12",
                                Text = "Acute care hospital",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ef138c7d-c117-4884-b239-3af3d8f49d20"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "13",
                                Text = "Correctional facility",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("39da9890-7cf5-4c28-8fd4-b99039879e75"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
                                Value = "14",
                                Text = "Other",
                            },
                            new ResponseModel
                            {
                                Id = new Guid("ae7981d0-fe14-4635-a2a4-5cc84ad2cc67"),
                                QuestionId = new Guid("bee33d7d-c152-40d9-9efa-1fa2a4730967"),
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
                Id = new Guid("1117c4ef-653c-4a24-91c5-d6063c50233b"),
                Index = "Q",
                Description = "Assessment Information",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Id = new Guid("27c6b441-b711-4bbd-9402-6b7aa72eda47"),
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
                        Id = new Guid("caca6a28-8a66-4170-8a17-64dd986eb3ca"),
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
