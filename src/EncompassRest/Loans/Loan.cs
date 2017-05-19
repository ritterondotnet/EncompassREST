using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Loan
    {
        public decimal? BaseLoanAmount { get; set; }
        public decimal? RequestedInterestRatePercent { get; set; }
        public int? LoanAmortizationTermMonths { get; set; }
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get; set; }
        public List<Fee> Fees { get; set; }
        public RegulationZ RegulationZ { get; set; }
        public Property Property { get; set; }
        public FhaVaLoan FhaVaLoan { get; set; }
        public string TitleHolderName1 { get; set; }
        public DownPayment DownPayment { get; set; }
        public Application CurrentApplication { get; set; }
        public DateTime? MaturityDate { get; set; }
        public List<Contact> Contacts { get; set; }
        public bool? BorrowerCoBorrowerMarriedIndicator { get; set; }
        public Mcaw Mcaw { get; set; }
        public bool? EnforceCountyLoanLimit { get; set; }
        public decimal? PurchasePriceAmount { get; set; }
        public decimal? EstimatedClosingCostsAmount { get; set; }
        public decimal? EstimatedPrepaidItemsAmount { get; set; }
        public decimal? SubordinateLienAmount { get; set; }
        public List<PurchaseCredit> PurchaseCredits { get; set; }
        public decimal? CashFromToBorrowerAmount { get; set; }
        public decimal? SellerPaidClosingCostsAmount { get; set; }
        public FreddieMac FreddieMac { get; set; }
        public bool? PropertyEnergyEfficientHomeIndicator { get; set; }
        public LoanSubmission LoanSubmission { get; set; }
        public VaLoanData VaLoanData { get; set; }
        public decimal? ProposedFirstMortgageAmount { get; set; }
        public decimal? ProposedOtherMortgagesAmount { get; set; }
        public string ProposedHazardInsuranceAmount { get; set; }
        public string ProposedMortgageInsuranceAmount { get; set; }
        public string ProposedDuesAmount { get; set; }
        public decimal? ProposedOtherAmount { get; set; }
        public LoanProductData LoanProductData { get; set; }
        public string ArmTypeDescription { get; set; }
        public Gfe Gfe { get; set; }
        public string LenderCaseIdentifier { get; set; }
        public Tsum Tsum { get; set; }
        public decimal? Ltv { get; set; }
        public int? PropertyAppraisedValueAmount { get; set; }
        public decimal? LtvPropertyValue { get; set; }
        public DateTime? AprDisclosureDate { get; set; }
        public string LoanNumber { get; set; }
        public Hmda Hmda { get; set; }
        public ClosingCost ClosingCost { get; set; }
        public bool? BuydownIndicator { get; set; }
        public decimal? FirstSubordinateLienAmount { get; set; }
        public decimal? SecondSubordinateAmount { get; set; }
        public string LenderInvestorCode { get; set; }
        public string ApplicationTakenMethodType { get; set; }
        public ClosingDocument ClosingDocument { get; set; }
        public CommitmentTerms CommitmentTerms { get; set; }
        public string LoanAmortizationType { get; set; }
        public DateTime? OriginationDate { get; set; }
        public DateTime? AdverseActionDate { get; set; }
        public decimal? ProposedHousingExpenseTotal { get; set; }
        public bool? FirstTimeHomebuyersIndicator { get; set; }
        public decimal? BuydownRatePercent { get; set; }
        public decimal? AlterationsImprovementsOrRepairsAmount { get; set; }
        public decimal? LandIfAcquiredSeperatelyAmount { get; set; }
        public decimal? MiAndFundingFeeTotalAmount { get; set; }
        public decimal? Tltv { get; set; }
        public int? BLTV { get; set; }
        public decimal? CombinedLtv { get; set; }
        public HudLoanData HudLoanData { get; set; }
        public string CurrentFirstMortgageHolderType { get; set; }
        public string OtherAmortizationTypeDescription { get; set; }
        public Miscellaneous Miscellaneous { get; set; }
        public decimal? SubjectPropertyGrossRentalIncomeAmount { get; set; }
        public decimal? DiscountPoint { get; set; }
        public string SectionOfActType { get; set; }
        public string AgencyCaseIdentifier { get; set; }
        public decimal? MiAndFundingFeeFinancedAmount { get; set; }
        public string MersNumber { get; set; }
        public string OtherMortgageTypeDescription { get; set; }
        public decimal? TotalFeesCostAmount { get; set; }
        public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get; set; }
        public decimal? BorrowerPaidDiscountPointsAmount { get; set; }
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get; set; }
        public decimal? BorrowerRequestedLoanAmount { get; set; }
        public decimal? BorrowerPaidFHAVAClosingCostsAmount { get; set; }
        public decimal? FhaMiPremiumRefundAmount { get; set; }
        public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get; set; }
        public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get; set; }
        public string MortgageType { get; set; }
        public int? CollateralManagerScore { get; set; }
        public string LoanProgramName { get; set; }
        public string ProposedRealEstateTaxesAmount { get; set; }
        public string CopyLoanNumLenderCaseNum { get; set; }
        public decimal? HelocTeaserRate { get; set; }
        public decimal? SubjectPropertyOccupancyPercent { get; set; }
        public decimal? HcltvHtltv { get; set; }
        public bool? UnderwritingEscrowIndicator { get; set; }
        public decimal? LifeInsuranceEstimatedMonthlyAmount { get; set; }
        public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get; set; }
        public decimal? LifeInsuranceCoverageAmount { get; set; }
        public string MilestoneStage { get; set; }
        public string TitleHolderName2 { get; set; }
        public string InverviewerName { get; set; }
        public decimal? MipPaidInCashAmount { get; set; }
        public decimal? DownPaymentPercent { get; set; }
        public string ClosingCostProgram { get; set; }
        public decimal? MaxFrontRatio { get; set; }
        public decimal? MaxBackRatio { get; set; }
        public int? PropertyEstimatedValueAmount { get; set; }
        public string ReferralSource { get; set; }
        public string InterviewerPhoneNumber { get; set; }
        public string InterviewerEmail { get; set; }
        public string UseNew2015FormsIndicator { get; set; }
        public string InterviewerLicenseIdentifier { get; set; }
        public string InterviewersCompanyStateLicense { get; set; }
        public string Print2003Application { get; set; }
        public string ReferralAddress { get; set; }
        public string ReferralCity { get; set; }
        public string ReferralState { get; set; }
        public string ReferralPostalCode { get; set; }
        public decimal? ReferralFeeAmount { get; set; }
        public decimal? TotalFeesCreditAmount { get; set; }
        public decimal? NewFirstMortgageAmount { get; set; }
        public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get; set; }
        public decimal? ClosingCostsPaidByOthersAmount { get; set; }
        public bool? CopyBrokerToLenderIndicator { get; set; }
        public bool? DoNotPrintCompensationFees { get; set; }
        public string InsuranceAuthorizationIndicator { get; set; }
        public decimal? TotalPaidToBrokerAmount { get; set; }
        public decimal? TotalDeductionsAmount { get; set; }
        public decimal? LenderCreditsInFunding { get; set; }
        public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get; set; }
        public bool? IsRequiredInterestReserveCompoundInterest { get; set; }
        public bool? IsCreditorProhibitsBorrower { get; set; }
        public decimal? EstimatedConstructionInterest { get; set; }
        public int? UnimprovedEstimatedValue { get; set; }
        public int? UnimprovedAppraisedValue { get; set; }
        public decimal? TotalWireTransferAmount { get; set; }
        public decimal? OverwireAmount { get; set; }
        public Funding Funding { get; set; }
        public Shipping Shipping { get; set; }
        public DateTime? MersNumberRegistrationDate { get; set; }
        public string LoanSource { get; set; }
        public DateTime? LoanCreatedDateUtc { get; set; }
        public RateLock RateLock { get; set; }
        public UnderwriterSummary UnderwriterSummary { get; set; }
        public bool? Use2018DiIndicator { get; set; }
        public string UrlPage4Comments { get; set; }
        public List<SettlementServiceCharge> SettlementServiceCharges { get; set; }
        public string HasAbusinessRelationshipWith { get; set; }
        public string PercentageOfOwnership { get; set; }
        public bool? SetForSettlementServicesOfAnAttorney { get; set; }
        public decimal? PercentageOwnershipInterest { get; set; }
        public bool? SetForTheSettlementServicesListed { get; set; }
        public bool? NotRequiredForSettlementOfYourLoan { get; set; }
        public bool? NotRequiredForPurchaseSaleOrRefinance { get; set; }
        public decimal? BrokerPaidClosingCostsAmount { get; set; }
        public decimal? BorrowerPaidClosingCostsAmount { get; set; }
        public List<CustomField> CustomFields { get; set; }
        public StatementCreditDenial StatementCreditDenial { get; set; }
        public StateDisclosure StateDisclosure { get; set; }
        public string EncompassId { get; set; }
        public bool? IsEmployeeLoan { get; set; }
        public Hud1Es Hud1Es { get; set; }
        public decimal? LenderPaidClosingCostsAmount { get; set; }
        public decimal? LenderPaidClosignCostsDotAmount { get; set; }
        public string LinkId { get; set; }
        public List<LoanProgram> LoanPrograms { get; set; }
        public FannieMae FannieMae { get; set; }
        public bool? BelowMarketSubordinateFinancingIndicator { get; set; }
        public string MsaIdentifier { get; set; }
        public string FnmCommunityLendingProductName { get; set; }
        public bool? FnmNeighborsMortgageEligibilityIndicator { get; set; }
        public bool? FnmCommunitySecondsIndicator { get; set; }
        public decimal? HudMedianIncomeAmount { get; set; }
        public decimal? HudIncomeLimitAdjustmentFactor { get; set; }
        public decimal? HudLendingIncomeLimitAmount { get; set; }
        public decimal? GovernmentMortgageCreditCertificateAmount { get; set; }
        public string LoanPurposeOfRefinanceType { get; set; }
        public bool? SimpleRefinanceType { get; set; }
        public decimal? LesserAppraisedValueOrSalesPrice { get; set; }
        public DateTime? InterviewerApplicationSignedDate { get; set; }
        public decimal? SalesConcessionAmount { get; set; }
        public DateTime? MilestoneApprovedDate { get; set; }
        public DateTime? MilestoneApprovedDueDate { get; set; }
        public DateTime? MilestoneCompletedDate { get; set; }
        public DateTime? MilestoneCompletedDueDate { get; set; }
        public DateTime? MilestoneDocSignedDate { get; set; }
        public DateTime? MilestoneDocSignedDueDate { get; set; }
        public DateTime? MilestoneFundedDate { get; set; }
        public DateTime? MilestoneFundedDueDate { get; set; }
        public DateTime? MilestoneProcessedDate { get; set; }
        public DateTime? MilestoneFileStartedDate { get; set; }
        public string MilestoneCurrentName { get; set; }
        public int? MilestoneDuration { get; set; }
        public DateTime? MilestoneCurrentDateUtc { get; set; }
        public DateTime? MilestoneSubmittedDate { get; set; }
        public DateTime? MilestoneSubmittedDueDate { get; set; }
        public DisclosureNotices DisclosureNotices { get; set; }
        public PrivacyPolicy PrivacyPolicy { get; set; }
        public string OrganizationCode { get; set; }
        public string WebsiteId { get; set; }
        public string ConsumerConnectSiteID { get; set; }
        public decimal? OtherPaidClosingCostsAmount { get; set; }
        public ProfitManagement ProfitManagement { get; set; }
        public Prequalification Prequalification { get; set; }
        public AdditionalRequests AdditionalRequests { get; set; }
        public ServicingDisclosure ServicingDisclosure { get; set; }
        public Section32 Section32 { get; set; }
        public TrustAccount TrustAccount { get; set; }
        public decimal? TotalNonborrowerPaidClosingCostsAmount { get; set; }
        public decimal? TotalClosingCostsAmount { get; set; }
        public decimal? TotalPaidOutsideClosingAmount { get; set; }
        public decimal? VAEntitlementAmount { get; set; }
        public string SystemIdGuid { get; set; }
        public string ExportLoanNumber { get; set; }
        public decimal? BuydownMonthlyPaymentAmount { get; set; }
        public InterimServicing InterimServicing { get; set; }
        public string Channel { get; set; }
        public bool? ContactUpdatedIndicator { get; set; }
        public bool? DeductOverwireAmountIndicator { get; set; }
        public string CreditScoreToUse { get; set; }
        public bool? IsLSSecondaryFile { get; set; }
        public string LoanLinkSyncType { get; set; }
        public string FundingDeductionList { get; set; }
        public string FundingFeeList { get; set; }
        public string LeadSource { get; set; }
        public TPO TPO { get; set; }
        public decimal? MipBorrowerPaidInCashAmount { get; set; }
        public decimal? BiweeklyPaymentAmount { get; set; }
        public string DoNotCheckEmail { get; set; }
        public bool? LoanImportStatusIndicator { get; set; }
        public bool? UseNewHudIndicator { get; set; }
        public decimal? ContractSellerCreditAmount { get; set; }
        public Uldd Uldd { get; set; }
        public Usda Usda { get; set; }
        public List<AffiliatedBusinessArrangement> AffiliatedBusinessArrangements { get; set; }
        public List<HomeCounselingProvider> HomeCounselingProviders { get; set; }
        public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get; set; }
        public string HomeCounselingProvidersServiceNames { get; set; }
        public string HomeCounselingProvidersLanguageNames { get; set; }
        public string HomeCounselingProvidersDistance { get; set; }
        public List<ServiceProviderContact> ServiceProviderContacts { get; set; }
        public string ServiceProviderAdditionalInfo { get; set; }
        public DateTime? ServiceProviderDateIssued { get; set; }
        public NetTangibleBenefit NetTangibleBenefit { get; set; }
        public ATRQMCommon ATRQMCommon { get; set; }
        public TQL TQL { get; set; }
        public string NmlsLoanOriginatorId { get; set; }
        public string InterviewersId { get; set; }
        public DateTime? ClosingBillingDate { get; set; }
        public bool? DisableKeyPricingAlert { get; set; }
        public string LoanIdNumber { get; set; }
        public bool? DisableESignConsentAlert { get; set; }
        public DateTime? TilApplicationDate { get; set; }
        public decimal? UndiscountedRate { get; set; }
        public bool? PaymentScheduleCalcRequiredIndicator { get; set; }
        public DateTime? RepurchaseDate { get; set; }
        public decimal? RepurchaseCostAmount { get; set; }
        public string ConformingJumbo { get; set; }
        public string LenderChannel { get; set; }
        public string OccupancyType { get; set; }
        public bool? PmiIndicator { get; set; }
        public int? FraudScore { get; set; }
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }
        public bool? IncludeUSDAFeeInClosing { get; set; }
        public decimal? FirstAdjustmentMinimum { get; set; }
        public bool? NoClosingCostOption { get; set; }
        public string CommitmentNumber { get; set; }
        public string MasterCommitmentNumber { get; set; }
        public Correspondent Correspondent { get; set; }
        public decimal? InitialInterestRate { get; set; }
        public ElliLOCompensation LOCompensation { get; set; }
        public string DocEngine { get; set; }
        public string UsdaGovernmentLoanType { get; set; }
        public string OpeningDocsPlanId { get; set; }
        public string OpeningDocsPlanDescription { get; set; }
        public string OpeningDocsLoanProgramType { get; set; }
        public string OpeningDocsProgramCode { get; set; }
        public string OpeningDocsInvestorCode { get; set; }
        public string OpeningDocsStackingOrder { get; set; }
        public string ClosingDocsStackingOrder { get; set; }
        public EmDocument EmDocument { get; set; }
        public EmDocumentLender EmDocumentLender { get; set; }
        public EmDocumentInvestor EmDocumentInvestor { get; set; }
        public List<MilestoneTemplateLog> MilestoneTemplateLogs { get; set; }
        public string BillingCategory { get; set; }
        public ConstructionManagement ConstructionManagement { get; set; }
        public List<Application> Applications { get; set; }
        public string Id { get; set; }
        public List<ConversationLog> ConversationLogs { get; set; }
        public List<CrmLog> CrmLogs { get; set; }
        public CustomModelFields CustomModelFields { get; set; }
        public List<DataTracLog> DataTracLogs { get; set; }
        public bool? DBIndicator { get; set; }
        public List<DisclosureTrackingLog> DisclosureTrackingLogs { get; set; }
        public List<DisclosureTracking2015Log> DisclosureTracking2015Logs { get; set; }
        public List<DocumentLog> DocumentLogs { get; set; }
        public List<DownloadLog> DownloadLogs { get; set; }
        public List<EdmLog> EdmLogs { get; set; }
        public List<EmailTriggerLog> EmailTriggerLogs { get; set; }
        public string FHAVALoanOriginatorIdentifier { get; set; }
        public List<Form> Forms { get; set; }
        public List<FundingFee> FundingFees { get; set; }
        public string GovernmentLoanLenderIdentifier { get; set; }
        public string GovernmentLoanSponsorIdentifier { get; set; }
        public int? HouseholdSizeCount { get; set; }
        public List<HtmlEmailLog> HtmlEmailLogs { get; set; }
        public string LoanUnderwriterCHUMSIdentifier { get; set; }
        public string LoanVALoanProcedureType { get; set; }
        public decimal? LoanVARateReductionInitialComputationTotalAmount { get; set; }
        public decimal? LoanVAResidualIncomeAmount { get; set; }
        public List<LockConfirmLog> LockConfirmLogs { get; set; }
        public List<LockDenialLog> LockDenialLogs { get; set; }
        public List<LockRequestLog> LockRequestLogs { get; set; }
        public List<LogEntryLog> LogEntryLogs { get; set; }
        public List<MilestoneFreeRoleLog> MilestoneFreeRoleLogs { get; set; }
        public List<MilestoneLog> MilestoneLogs { get; set; }
        public List<MilestoneTaskLog> MilestoneTaskLogs { get; set; }
        public decimal? MortgageInsurancePremiumFHARefundAmount { get; set; }
        public List<PostClosingConditionLog> PostClosingConditionLogs { get; set; }
        public List<PreliminaryConditionLog> PreliminaryConditionLogs { get; set; }
        public List<PrintLog> PrintLogs { get; set; }
        public decimal? ProposedGroundRentAmount { get; set; }
        public List<RegistrationLog> RegistrationLogs { get; set; }
        public List<StatusOnlineLog> StatusOnlineLogs { get; set; }
        public List<UnderwritingConditionLog> UnderwritingConditionLogs { get; set; }
        public List<VerificationLog> VerificationLogs { get; set; }
        public int? CurrentApplicationIndex { get; set; }
        public string EmXmlVersionId { get; set; }
        public int? LoanVersionId { get; set; }
        public bool? CurrentApplicationIsPrimary { get; set; }
        public string LoanCreatedDate { get; set; }
        public decimal? StartingAdjRate { get; set; }
        public decimal? StartingAdjPrice { get; set; }
        public List<ComplianceTestLog> ComplianceTestLogs { get; set; }
        public List<FieldLockData> FieldLockData { get; set; }
        public List<LoanActionLog> LoanActionLogs { get; set; }
        public List<RemovedLogRecord> RemovedLogRecords { get; set; }
        public string VirtualFields { get; set; }
    }
}