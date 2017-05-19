using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class InterimServicing
    {
        public string MortgageAccount { get; set; }
        public string BorrowerFirstName { get; set; }
        public string BorrowerLastName { get; set; }
        public string MailingStreetAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingPostalCode { get; set; }
        public string ServicingStatus { get; set; }
        public DateTime? LastStatementPrintedDate { get; set; }
        public DateTime? PaymentDueDatePrinted { get; set; }
        public string PrintedByUserName { get; set; }
        public string PrintedByUserId { get; set; }
        public DateTime? NextPaymentStatementDueDate { get; set; }
        public DateTime? NextPaymentPaymentDueDate { get; set; }
        public DateTime? NextPaymentLatePaymentDate { get; set; }
        public decimal? NextPaymentIndexCurrentValuePercent { get; set; }
        public decimal? NextPaymentRequestedInterestRatePercent { get; set; }
        public decimal? NextPaymentPrincipal { get; set; }
        public decimal? NextPaymentInterest { get; set; }
        public decimal? NextPaymentEscrowAmount { get; set; }
        public decimal? NextPaymentPastDueAmount { get; set; }
        public decimal? NextPaymentUnpaidLateFee { get; set; }
        public decimal? NextPaymentMiscFee { get; set; }
        public decimal? NextPaymentTotalAmountDue { get; set; }
        public decimal? NextPaymentLateFee { get; set; }
        public decimal? NextPaymentTotalAmountWithLateFee { get; set; }
        public string LastPaymentGuid { get; set; }
        public int? LastPaymentNumber { get; set; }
        public DateTime? LastPaymentStatementDate { get; set; }
        public DateTime? LastPaymentReceivedDate { get; set; }
        public decimal? LastPaymentTotalAmountReceived { get; set; }
        public decimal? LastPaymentPrincipal { get; set; }
        public decimal? LastPaymentInterest { get; set; }
        public decimal? LastPaymentEscrowAmount { get; set; }
        public decimal? LastPaymentLateFee { get; set; }
        public decimal? LastPaymentAdditionalPrincipal { get; set; }
        public int? TotalNumberOfPayment { get; set; }
        public int? TotalNumberOfLatePayment { get; set; }
        public decimal? TotalPrincipal { get; set; }
        public decimal? TotalPrincipalYearToDate { get; set; }
        public decimal? TotalInterest { get; set; }
        public decimal? TotalInterestYearToDate { get; set; }
        public decimal? TotalPAndI { get; set; }
        public decimal? TotalPAndIYearToDate { get; set; }
        public decimal? TotalEscrow { get; set; }
        public decimal? TotalEscrowYearToDate { get; set; }
        public decimal? TotalLateFee { get; set; }
        public decimal? TotalLateFeeYearToDate { get; set; }
        public decimal? TotalAdditionalPrincipal { get; set; }
        public decimal? TotalAdditionalPrincipalYearToDate { get; set; }
        public decimal? TotalAdditionalEscrow { get; set; }
        public decimal? TotalAdditionalEscrowYearToDate { get; set; }
        public decimal? TotalPaymentCollected { get; set; }
        public decimal? TotalPaymentCollectedYearToDate { get; set; }
        public decimal? CurrentPrincipalBalance { get; set; }
        public decimal? NextEscrowTotalTax { get; set; }
        public DateTime? NextEscrowTotalTaxDueDate { get; set; }
        public decimal? NextEscrowTotalHazardInsurance { get; set; }
        public DateTime? NextEscrowTotalHazardInsuranceDueDate { get; set; }
        public decimal? NextEscrowTotalMortgageInsurance { get; set; }
        public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get; set; }
        public decimal? NextEscrowTotalFloodInsurance { get; set; }
        public DateTime? NextEscrowTotalFloodInsuranceDueDate { get; set; }
        public decimal? NextEscrowTotalPropertyTax { get; set; }
        public DateTime? NextEscrowTotalPropertyTaxDueDate { get; set; }
        public decimal? NextEscrowTotalOtherTax1 { get; set; }
        public DateTime? NextEscrowTotalOtherTax1DueDate { get; set; }
        public decimal? NextEscrowTotalOtherTax2 { get; set; }
        public DateTime? NextEscrowTotalOtherTax2DueDate { get; set; }
        public decimal? NextEscrowTotalOtherTax3 { get; set; }
        public DateTime? NextEscrowTotalOtherTax3DueDate { get; set; }
        public int? NumberOfDisbursement { get; set; }
        public decimal? TotalTaxes { get; set; }
        public decimal? TotalHazardInsurance { get; set; }
        public decimal? TotalMortgageInsurance { get; set; }
        public decimal? TotalOtherTaxes { get; set; }
        public decimal? TotalAmountDisbursed { get; set; }
        public decimal? EscrowBalance { get; set; }
        public decimal? NextPaymentPrincipalAndInterest { get; set; }
        public decimal? LastPaymentPrincipalAndInterest { get; set; }
        public decimal? LastPaymentMiscFee { get; set; }
        public decimal? LastPaymentAdditionalEscrow { get; set; }
        public decimal? TotalMiscFee { get; set; }
        public decimal? TotalMiscFeeYearToDate { get; set; }
        public decimal? FloodInsurance { get; set; }
        public decimal? CityInsurance { get; set; }
        public decimal? UnpaidPrincipal { get; set; }
        public decimal? UnpaidInterest { get; set; }
        public decimal? UnpaidEscrow { get; set; }
        public decimal? UnpaidMiscrFee { get; set; }
        public decimal? UnpaidLateFee { get; set; }
        public DateTime? NextPaymentPaymentIndexDate { get; set; }
        public decimal? NextPaymentBuydownSubsidyAmount { get; set; }
        public decimal? LastPaymentBuydownSubsidyAmount { get; set; }
        public decimal? TotalBuydownSubsidyAmount { get; set; }
        public decimal? TotalBuydownSubsidyAmountYearToDate { get; set; }
        public decimal? UnpaidBuydownSubsidyAmount { get; set; }
        public decimal? NextEscrowTotalUsdaMonthlyPremium { get; set; }
        public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get; set; }
        public decimal? TotalUsdaMonthlyPremium { get; set; }
        public string ServicerLoanNumber { get; set; }
        public DateTime? ServicingTransferDate { get; set; }
        public string SubServicer { get; set; }
        public string SubServicerLoanNumber { get; set; }
        public decimal? NextPaymentEscrowTax { get; set; }
        public decimal? NextPaymentEscrowHazardInsurance { get; set; }
        public decimal? NextPaymentEscrowMortgageInsurance { get; set; }
        public decimal? NextPaymentEscrowFloodInsurance { get; set; }
        public decimal? NextPaymentEscrowCityPropertyTax { get; set; }
        public decimal? NextPaymentEscrowOther1 { get; set; }
        public decimal? NextPaymentEscrowOther2 { get; set; }
        public decimal? NextPaymentEscrowOther3 { get; set; }
        public decimal? NextPaymentEscrowUSDAMonthlyPremium { get; set; }
        public decimal? LastPaymentEscrowTax { get; set; }
        public decimal? LastPaymentEscrowHazardInsurance { get; set; }
        public decimal? LastPaymentEscrowMortgageInsurance { get; set; }
        public decimal? LastPaymentEscrowFloodInsurance { get; set; }
        public decimal? LastPaymentEscrowCityPropertyTax { get; set; }
        public decimal? LastPaymentEscrowOther1 { get; set; }
        public decimal? LastPaymentEscrowOther2 { get; set; }
        public decimal? LastPaymentEscrowOther3 { get; set; }
        public decimal? LastPaymentEscrowUSDAMonthlyPremium { get; set; }
        public decimal? UnpaidEscrowTax { get; set; }
        public decimal? UnpaidEscrowMortgageInsurance { get; set; }
        public decimal? UnpaidEscrowHazardInsurance { get; set; }
        public decimal? UnpaidEscrowFloodInsurance { get; set; }
        public decimal? UnpaidEscrowCityPropertyTax { get; set; }
        public decimal? UnpaidEscrowOther1 { get; set; }
        public decimal? UnpaidEscrowOther2 { get; set; }
        public decimal? UnpaidEscrowOther3 { get; set; }
        public decimal? UnpaidEscrowUSDAMonthlyPremium { get; set; }
        public decimal? PurchasedPrincipal { get; set; }
        public string BorrHomePhoneNumber { get; set; }
        public string BorrWorkPhoneNumber { get; set; }
        public string BorrCellPhoneNumber { get; set; }
        public string BorrHomeEmail { get; set; }
        public string CalcTriggered { get; set; }
        public string Comments { get; set; }
        public string Id { get; set; }
        public List<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get; set; }
        public List<EscrowInterestTransaction> EscrowInterestTransactions { get; set; }
        public List<InterimServicingTransaction> InterimServicingTransactions { get; set; }
        public string LoanSnapshotXml { get; set; }
        public List<OtherTransaction> OtherTransactions { get; set; }
        public List<PaymentReversalTransaction> PaymentReversalTransactions { get; set; }
        public List<PaymentTransaction> PaymentTransactions { get; set; }
        public List<SchedulePaymentTransaction> SchedulePaymentTransactions { get; set; }
        public List<SchedulePaymentTransaction> ScheduledPayments { get; set; }
        public SchedulePaymentTransaction NextScheduledPayment { get; set; }
        public SchedulePaymentTransaction LastScheduledPayment { get; set; }
    }
}