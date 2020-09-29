//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WiLinq.ProcessTemplates.Agile {
  using WiLinq.LinqProvider;
  
  
  [WiLinq.LinqProvider.WorkItemTypeAttribute("Bug")]
  public partial class Bug : WiLinq.LinqProvider.GenericWorkItem {
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ActivatedBy")]
    public virtual string ActivatedBy {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.ActivatedBy");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.ActivatedBy", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ActivatedDate")]
    public virtual System.Nullable<System.DateTime> ActivatedDate {
      get {
        return this.GetStructField<System.DateTime>("Microsoft.VSTS.Common.ActivatedDate");
      }
      set {
        this.SetStructField<System.DateTime>("Microsoft.VSTS.Common.ActivatedDate", value);
      }
    }
    
    /// <summary>Type of work involved</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.Activity")]
    public virtual string Activity {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.Activity");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.Activity", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("System.AuthorizedAs")]
    public virtual string AuthorizedAs {
      get {
        return this.GetRefField<string>("System.AuthorizedAs");
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("System.AuthorizedDate")]
    public virtual System.Nullable<System.DateTime> AuthorizedDate {
      get {
        return this.GetStructField<System.DateTime>("System.AuthorizedDate");
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ClosedBy")]
    public virtual string ClosedBy {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.ClosedBy");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.ClosedBy", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ClosedDate")]
    public virtual System.Nullable<System.DateTime> ClosedDate {
      get {
        return this.GetStructField<System.DateTime>("Microsoft.VSTS.Common.ClosedDate");
      }
      set {
        this.SetStructField<System.DateTime>("Microsoft.VSTS.Common.ClosedDate", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("System.CommentCount")]
    public virtual System.Nullable<long> CommentCount {
      get {
        return this.GetStructField<long>("System.CommentCount");
      }
    }
    
    /// <summary>The number of units of work that have been spent on this bug</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Scheduling.CompletedWork")]
    public virtual System.Nullable<double> CompletedWork {
      get {
        return this.GetStructField<double>("Microsoft.VSTS.Scheduling.CompletedWork");
      }
      set {
        this.SetStructField<double>("Microsoft.VSTS.Scheduling.CompletedWork", value);
      }
    }
    
    /// <summary>The build in which the bug was found</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Build.FoundIn")]
    public virtual string FoundIn {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Build.FoundIn");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Build.FoundIn", value);
      }
    }
    
    /// <summary>The build in which the bug was fixed</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Build.IntegrationBuild")]
    public virtual string IntegrationBuild {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Build.IntegrationBuild");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Build.IntegrationBuild", value);
      }
    }
    
    /// <summary>Initial value for Remaining Work - set once, when work begins</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Scheduling.OriginalEstimate")]
    public virtual System.Nullable<double> OriginalEstimate {
      get {
        return this.GetStructField<double>("Microsoft.VSTS.Scheduling.OriginalEstimate");
      }
      set {
        this.SetStructField<double>("Microsoft.VSTS.Scheduling.OriginalEstimate", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("System.Parent")]
    public virtual System.Nullable<long> Parent {
      get {
        return this.GetStructField<long>("System.Parent");
      }
    }
    
    /// <summary>Business importance. 1=must fix; 4=unimportant.</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.Priority")]
    public virtual System.Nullable<long> Priority {
      get {
        return this.GetStructField<long>("Microsoft.VSTS.Common.Priority");
      }
      set {
        this.SetStructField<long>("Microsoft.VSTS.Common.Priority", value);
      }
    }
    
    /// <summary>An estimate of the number of units of work remaining to complete this bug</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Scheduling.RemainingWork")]
    public virtual System.Nullable<double> RemainingWork {
      get {
        return this.GetStructField<double>("Microsoft.VSTS.Scheduling.RemainingWork");
      }
      set {
        this.SetStructField<double>("Microsoft.VSTS.Scheduling.RemainingWork", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("System.RemoteLinkCount")]
    public virtual System.Nullable<long> RemoteLinkCount {
      get {
        return this.GetStructField<long>("System.RemoteLinkCount");
      }
    }
    
    /// <summary>How to see the bug. End by contrasting expected with actual behavior.</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.TCM.ReproSteps")]
    public virtual string ReproSteps {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.TCM.ReproSteps");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.TCM.ReproSteps", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ResolvedBy")]
    public virtual string ResolvedBy {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.ResolvedBy");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.ResolvedBy", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ResolvedDate")]
    public virtual System.Nullable<System.DateTime> ResolvedDate {
      get {
        return this.GetStructField<System.DateTime>("Microsoft.VSTS.Common.ResolvedDate");
      }
      set {
        this.SetStructField<System.DateTime>("Microsoft.VSTS.Common.ResolvedDate", value);
      }
    }
    
    /// <summary>The reason why the bug was resolved</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ResolvedReason")]
    public virtual string ResolvedReason {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.ResolvedReason");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.ResolvedReason", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("System.RevisedDate")]
    public virtual System.Nullable<System.DateTime> RevisedDate {
      get {
        return this.GetStructField<System.DateTime>("System.RevisedDate");
      }
    }
    
    /// <summary>Assessment of the effect of the bug on the project.</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.Severity")]
    public virtual string Severity {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.Severity");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.Severity", value);
      }
    }
    
    /// <summary>Work first on items with lower-valued stack rank. Set in triage.</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.StackRank")]
    public virtual System.Nullable<double> StackRank {
      get {
        return this.GetStructField<double>("Microsoft.VSTS.Common.StackRank");
      }
      set {
        this.SetStructField<double>("Microsoft.VSTS.Common.StackRank", value);
      }
    }
    
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.StateChangeDate")]
    public virtual System.Nullable<System.DateTime> StateChangeDate {
      get {
        return this.GetStructField<System.DateTime>("Microsoft.VSTS.Common.StateChangeDate");
      }
      set {
        this.SetStructField<System.DateTime>("Microsoft.VSTS.Common.StateChangeDate", value);
      }
    }
    
    /// <summary>The size of work estimated for fixing the bug</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Scheduling.StoryPoints")]
    public virtual System.Nullable<double> StoryPoints {
      get {
        return this.GetStructField<double>("Microsoft.VSTS.Scheduling.StoryPoints");
      }
      set {
        this.SetStructField<double>("Microsoft.VSTS.Scheduling.StoryPoints", value);
      }
    }
    
    /// <summary>Test context, provided automatically by test infrastructure</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.TCM.SystemInfo")]
    public virtual string SystemInfo {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.TCM.SystemInfo");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.TCM.SystemInfo", value);
      }
    }
    
    /// <summary>The type should be set to Business primarily to represent customer-facing issues. Work to change the architecture should be added as a Requirement</summary>
    [WiLinq.LinqProvider.FieldAttribute("Microsoft.VSTS.Common.ValueArea")]
    public virtual string ValueArea {
      get {
        return this.GetRefField<string>("Microsoft.VSTS.Common.ValueArea");
      }
      set {
        this.SetRefField<string>("Microsoft.VSTS.Common.ValueArea", value);
      }
    }
  }
}
