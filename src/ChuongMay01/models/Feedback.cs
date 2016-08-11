using System;
using System.Collections.Generic;

namespace ChuongMay01.models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string FeedbackContent { get; set; }
        public string FeedbackName { get; set; }
        public bool? FeedbackStatus { get; set; }
        public string FeedbackReply { get; set; }
        public int? ManagerId { get; set; }

        public virtual Manager Manager { get; set; }
    }
}
