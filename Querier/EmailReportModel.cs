using System;

namespace Querier
{
    public class EmailReportModel
    {
        public int Id { get; set; }
        public bool IsBounced { get; set; }
        public int ProspectId { get; set; }
        public int CampaignProspectStatus { get; set; }
        public int OpensCount { get; set; }
        public bool IsReplied { get; set; }
        public bool IsOptedOut { get; set; }
        public int UserId { get; set; }
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int CampaignOwnerId { get; set; }
        public int ClicksCount { get; set; }
        public int UniqueClicksCount { get; set; }
        public string CampaignReplyInboxName { get; set; }
        public DateTime? BounceDate { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string EmailAccountEmail { get; set; }
        public int? EmailTemplateId { get; set; }
        public int? CampaignStepEmailId { get; set; }
        public int SequenceStepId { get; set; }
        public int CampaignProspectSubStatus { get; set; }
        public DateTime? ReplyDate { get; set; }
        public DateTime? ManualReplyDate { get; set; }
        public string EmailTemplateName { get; set; }
        public bool InvalidEmail { get; set; }
    }
}