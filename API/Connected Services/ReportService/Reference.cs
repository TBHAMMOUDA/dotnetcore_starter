//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace ReportService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportInfo", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class ReportInfo : object
    {
        
        private string DescriptionField;
        
        private string FullNameField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName
        {
            get
            {
                return this.FullNameField;
            }
            set
            {
                this.FullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExtensionInfo", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class ExtensionInfo : object
    {
        
        private string LocalizedNameField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocalizedName
        {
            get
            {
                return this.LocalizedNameField;
            }
            set
            {
                this.LocalizedNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Parameter", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Processing")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Parameter1))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ParameterValue[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ParameterValue))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<string, object>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Array))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ReportInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ReportInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ExtensionInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ExtensionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.RenderingResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ServiceOperationResultBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.RenderingSessionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ActionInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ActionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Action))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ActionType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.BookmarkNode[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.BookmarkNode))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Parameter1[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.PageInfo))]
    public partial class Parameter : object
    {
        
        private bool AllowBlankField;
        
        private bool AllowNullField;
        
        private bool AutoRefreshField;
        
        private ReportService.ParameterValue[] AvailableValuesField;
        
        private string[] ChildParametersField;
        
        private string IDField;
        
        private bool IsVisibleField;
        
        private bool MultivalueField;
        
        private string NameField;
        
        private string TextField;
        
        private string TypeField;
        
        private object ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowBlank
        {
            get
            {
                return this.AllowBlankField;
            }
            set
            {
                this.AllowBlankField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowNull
        {
            get
            {
                return this.AllowNullField;
            }
            set
            {
                this.AllowNullField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AutoRefresh
        {
            get
            {
                return this.AutoRefreshField;
            }
            set
            {
                this.AutoRefreshField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.ParameterValue[] AvailableValues
        {
            get
            {
                return this.AvailableValuesField;
            }
            set
            {
                this.AvailableValuesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] ChildParameters
        {
            get
            {
                return this.ChildParametersField;
            }
            set
            {
                this.ChildParametersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsVisible
        {
            get
            {
                return this.IsVisibleField;
            }
            set
            {
                this.IsVisibleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Multivalue
        {
            get
            {
                return this.MultivalueField;
            }
            set
            {
                this.MultivalueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Parameter", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class Parameter1 : ReportService.Parameter
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParameterValue", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Processing")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Parameter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ParameterValue[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<string, object>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Array))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ReportInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ReportInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ExtensionInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ExtensionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.RenderingResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ServiceOperationResultBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.RenderingSessionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ActionInfo[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ActionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Action))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.ActionType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.BookmarkNode[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.BookmarkNode))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Parameter1[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.Parameter1))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.PageInfo))]
    public partial class ParameterValue : object
    {
        
        private string NameField;
        
        private object ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RenderingResult", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class RenderingResult : ReportService.ServiceOperationResultBase
    {
        
        private byte[] DocumentBytesField;
        
        private string DocumentNameField;
        
        private string ExtensionField;
        
        private string MimeTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] DocumentBytes
        {
            get
            {
                return this.DocumentBytesField;
            }
            set
            {
                this.DocumentBytesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentName
        {
            get
            {
                return this.DocumentNameField;
            }
            set
            {
                this.DocumentNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Extension
        {
            get
            {
                return this.ExtensionField;
            }
            set
            {
                this.ExtensionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MimeType
        {
            get
            {
                return this.MimeTypeField;
            }
            set
            {
                this.MimeTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceOperationResultBase", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.RenderingSessionInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.PageInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ReportService.RenderingResult))]
    public partial class ServiceOperationResultBase : object
    {
        
        private string ErrorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error
        {
            get
            {
                return this.ErrorField;
            }
            set
            {
                this.ErrorField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RenderingSessionInfo", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class RenderingSessionInfo : ReportService.ServiceOperationResultBase
    {
        
        private ReportService.ActionInfo[] ActionsField;
        
        private ReportService.BookmarkNode[] BookmarksField;
        
        private string DocumentNameField;
        
        private bool HasDocumentMapField;
        
        private string InstanceIDField;
        
        private bool NavigateBackEnabledField;
        
        private bool NavigateForwardEnabledField;
        
        private int PageCountField;
        
        private int PageNumberField;
        
        private ReportService.Parameter1[] ParametersField;
        
        private string ReportField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.ActionInfo[] Actions
        {
            get
            {
                return this.ActionsField;
            }
            set
            {
                this.ActionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.BookmarkNode[] Bookmarks
        {
            get
            {
                return this.BookmarksField;
            }
            set
            {
                this.BookmarksField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentName
        {
            get
            {
                return this.DocumentNameField;
            }
            set
            {
                this.DocumentNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasDocumentMap
        {
            get
            {
                return this.HasDocumentMapField;
            }
            set
            {
                this.HasDocumentMapField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceID
        {
            get
            {
                return this.InstanceIDField;
            }
            set
            {
                this.InstanceIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NavigateBackEnabled
        {
            get
            {
                return this.NavigateBackEnabledField;
            }
            set
            {
                this.NavigateBackEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NavigateForwardEnabled
        {
            get
            {
                return this.NavigateForwardEnabledField;
            }
            set
            {
                this.NavigateForwardEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageCount
        {
            get
            {
                return this.PageCountField;
            }
            set
            {
                this.PageCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageNumber
        {
            get
            {
                return this.PageNumberField;
            }
            set
            {
                this.PageNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.Parameter1[] Parameters
        {
            get
            {
                return this.ParametersField;
            }
            set
            {
                this.ParametersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Report
        {
            get
            {
                return this.ReportField;
            }
            set
            {
                this.ReportField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActionInfo", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class ActionInfo : object
    {
        
        private ReportService.Action ActionField;
        
        private string IdField;
        
        private int PageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.Action Action
        {
            get
            {
                return this.ActionField;
            }
            set
            {
                this.ActionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Page
        {
            get
            {
                return this.PageField;
            }
            set
            {
                this.PageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Action", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class Action : object
    {
        
        private System.Collections.Generic.Dictionary<string, object> ParametersField;
        
        private string ReportDocumentTypeField;
        
        private string ServerActionIdentifierField;
        
        private string TargetField;
        
        private string TargetBookmarkIdField;
        
        private ReportService.ActionType TypeField;
        
        private string UrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, object> Parameters
        {
            get
            {
                return this.ParametersField;
            }
            set
            {
                this.ParametersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReportDocumentType
        {
            get
            {
                return this.ReportDocumentTypeField;
            }
            set
            {
                this.ReportDocumentTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerActionIdentifier
        {
            get
            {
                return this.ServerActionIdentifierField;
            }
            set
            {
                this.ServerActionIdentifierField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Target
        {
            get
            {
                return this.TargetField;
            }
            set
            {
                this.TargetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TargetBookmarkId
        {
            get
            {
                return this.TargetBookmarkIdField;
            }
            set
            {
                this.TargetBookmarkIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.ActionType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Url
        {
            get
            {
                return this.UrlField;
            }
            set
            {
                this.UrlField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActionType", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public enum ActionType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BookmarkNavigation = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UrlNavigation = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServerAction = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookmarkNode", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class BookmarkNode : object
    {
        
        private ReportService.BookmarkNode[] ChildrenField;
        
        private string IdField;
        
        private int PageField;
        
        private string TextField;
        
        private int XField;
        
        private int YField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ReportService.BookmarkNode[] Children
        {
            get
            {
                return this.ChildrenField;
            }
            set
            {
                this.ChildrenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Page
        {
            get
            {
                return this.PageField;
            }
            set
            {
                this.PageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int X
        {
            get
            {
                return this.XField;
            }
            set
            {
                this.XField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y
        {
            get
            {
                return this.YField;
            }
            set
            {
                this.YField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PageInfo", Namespace="http://schemas.datacontract.org/2004/07/Telerik.Reporting.Service")]
    public partial class PageInfo : ReportService.ServiceOperationResultBase
    {
        
        private byte[] BufferField;
        
        private int PageNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Buffer
        {
            get
            {
                return this.BufferField;
            }
            set
            {
                this.BufferField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageNumber
        {
            get
            {
                return this.PageNumberField;
            }
            set
            {
                this.PageNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Telerik.ReportService", ConfigurationName="ReportService.IReportService")]
    public interface IReportService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IReportService/ListAvailableReports", ReplyAction="Telerik.ReportService/IReportService/ListAvailableReportsResponse")]
        System.Threading.Tasks.Task<ReportService.ReportInfo[]> ListAvailableReportsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IReportService/ListRenderingExtensions", ReplyAction="Telerik.ReportService/IReportService/ListRenderingExtensionsResponse")]
        System.Threading.Tasks.Task<ReportService.ExtensionInfo[]> ListRenderingExtensionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IReportService/Render", ReplyAction="Telerik.ReportService/IReportService/RenderResponse")]
        System.Threading.Tasks.Task<ReportService.RenderingResult> RenderAsync(string format, string report, System.Collections.Generic.Dictionary<string, object> deviceInfo, System.Collections.Generic.Dictionary<string, object> parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IReportService/RenderAndCache", ReplyAction="Telerik.ReportService/IReportService/RenderAndCacheResponse")]
        System.Threading.Tasks.Task<ReportService.RenderingSessionInfo> RenderAndCacheAsync(string format, string report, System.Collections.Generic.Dictionary<string, object> deviceInfo, System.Collections.Generic.Dictionary<string, object> parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IReportService/GetPage", ReplyAction="Telerik.ReportService/IReportService/GetPageResponse")]
        System.Threading.Tasks.Task<ReportService.PageInfo> GetPageAsync(string instanceID, int pageNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IReportService/GetReportParameters", ReplyAction="Telerik.ReportService/IReportService/GetReportParametersResponse")]
        System.Threading.Tasks.Task<ReportService.Parameter1[]> GetReportParametersAsync(string report, System.Collections.Generic.Dictionary<string, object> deviceInfo, System.Collections.Generic.Dictionary<string, object> parameters);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IReportServiceChannel : ReportService.IReportService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ReportServiceClient : System.ServiceModel.ClientBase<ReportService.IReportService>, ReportService.IReportService
    {
        
    /// <summary>
    /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
    /// </summary>
    /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
    /// <param name="clientCredentials">Informations d'identification du client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ReportServiceClient() : 
                base(ReportServiceClient.GetDefaultBinding(), ReportServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IReportService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ReportServiceClient.GetBindingForEndpoint(endpointConfiguration), ReportServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ReportServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ReportServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ReportService.ReportInfo[]> ListAvailableReportsAsync()
        {
            return base.Channel.ListAvailableReportsAsync();
        }
        
        public System.Threading.Tasks.Task<ReportService.ExtensionInfo[]> ListRenderingExtensionsAsync()
        {
            return base.Channel.ListRenderingExtensionsAsync();
        }
        
        public System.Threading.Tasks.Task<ReportService.RenderingResult> RenderAsync(string format, string report, System.Collections.Generic.Dictionary<string, object> deviceInfo, System.Collections.Generic.Dictionary<string, object> parameters)
        {
            return base.Channel.RenderAsync(format, report, deviceInfo, parameters);
        }
        
        public System.Threading.Tasks.Task<ReportService.RenderingSessionInfo> RenderAndCacheAsync(string format, string report, System.Collections.Generic.Dictionary<string, object> deviceInfo, System.Collections.Generic.Dictionary<string, object> parameters)
        {
            return base.Channel.RenderAndCacheAsync(format, report, deviceInfo, parameters);
        }
        
        public System.Threading.Tasks.Task<ReportService.PageInfo> GetPageAsync(string instanceID, int pageNumber)
        {
            return base.Channel.GetPageAsync(instanceID, pageNumber);
        }
        
        public System.Threading.Tasks.Task<ReportService.Parameter1[]> GetReportParametersAsync(string report, System.Collections.Generic.Dictionary<string, object> deviceInfo, System.Collections.Generic.Dictionary<string, object> parameters)
        {
            return base.Channel.GetReportParametersAsync(report, deviceInfo, parameters);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IReportService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IReportService))
            {
                return new System.ServiceModel.EndpointAddress("http://10.1.1.105:8088/RapportService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ReportServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IReportService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ReportServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IReportService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IReportService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Telerik.ReportService", ConfigurationName="ReportService.IResourceService")]
    public interface IResourceService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IResourceService/GetRenderStream", ReplyAction="Telerik.ReportService/IResourceService/GetRenderStreamResponse")]
        System.Threading.Tasks.Task<ReportService.GetRenderStreamResponse> GetRenderStreamAsync(ReportService.GetRenderStreamRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IResourceService/Export", ReplyAction="Telerik.ReportService/IResourceService/ExportResponse")]
        System.Threading.Tasks.Task<ReportService.ExportResponse> ExportAsync(ReportService.ExportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="Telerik.ReportService/IResourceService/ExportCachedReport", ReplyAction="Telerik.ReportService/IResourceService/ExportCachedReportResponse")]
        System.Threading.Tasks.Task<ReportService.ExportCachedReportResponse> ExportCachedReportAsync(ReportService.ExportCachedReportRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRenderStreamRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRenderStream", Namespace="Telerik.ReportService", Order=0)]
        public ReportService.GetRenderStreamRequestBody Body;
        
        public GetRenderStreamRequest()
        {
        }
        
        public GetRenderStreamRequest(ReportService.GetRenderStreamRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Telerik.ReportService")]
    public partial class GetRenderStreamRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string instanceID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public GetRenderStreamRequestBody()
        {
        }
        
        public GetRenderStreamRequestBody(string instanceID, string name)
        {
            this.instanceID = instanceID;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRenderStreamResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRenderStreamResponse", Namespace="Telerik.ReportService", Order=0)]
        public ReportService.GetRenderStreamResponseBody Body;
        
        public GetRenderStreamResponse()
        {
        }
        
        public GetRenderStreamResponse(ReportService.GetRenderStreamResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Telerik.ReportService")]
    public partial class GetRenderStreamResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] GetRenderStreamResult;
        
        public GetRenderStreamResponseBody()
        {
        }
        
        public GetRenderStreamResponseBody(byte[] GetRenderStreamResult)
        {
            this.GetRenderStreamResult = GetRenderStreamResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Export", Namespace="Telerik.ReportService", Order=0)]
        public ReportService.ExportRequestBody Body;
        
        public ExportRequest()
        {
        }
        
        public ExportRequest(ReportService.ExportRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Telerik.ReportService")]
    public partial class ExportRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string format;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string report;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string deviceInfo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string parameterValues;
        
        public ExportRequestBody()
        {
        }
        
        public ExportRequestBody(string format, string report, string deviceInfo, string parameterValues)
        {
            this.format = format;
            this.report = report;
            this.deviceInfo = deviceInfo;
            this.parameterValues = parameterValues;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportResponse", Namespace="Telerik.ReportService", Order=0)]
        public ReportService.ExportResponseBody Body;
        
        public ExportResponse()
        {
        }
        
        public ExportResponse(ReportService.ExportResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Telerik.ReportService")]
    public partial class ExportResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] ExportResult;
        
        public ExportResponseBody()
        {
        }
        
        public ExportResponseBody(byte[] ExportResult)
        {
            this.ExportResult = ExportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportCachedReportRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportCachedReport", Namespace="Telerik.ReportService", Order=0)]
        public ReportService.ExportCachedReportRequestBody Body;
        
        public ExportCachedReportRequest()
        {
        }
        
        public ExportCachedReportRequest(ReportService.ExportCachedReportRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Telerik.ReportService")]
    public partial class ExportCachedReportRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string instanceID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string format;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string deviceInfo;
        
        public ExportCachedReportRequestBody()
        {
        }
        
        public ExportCachedReportRequestBody(string instanceID, string format, string deviceInfo)
        {
            this.instanceID = instanceID;
            this.format = format;
            this.deviceInfo = deviceInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportCachedReportResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExportCachedReportResponse", Namespace="Telerik.ReportService", Order=0)]
        public ReportService.ExportCachedReportResponseBody Body;
        
        public ExportCachedReportResponse()
        {
        }
        
        public ExportCachedReportResponse(ReportService.ExportCachedReportResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="Telerik.ReportService")]
    public partial class ExportCachedReportResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] ExportCachedReportResult;
        
        public ExportCachedReportResponseBody()
        {
        }
        
        public ExportCachedReportResponseBody(byte[] ExportCachedReportResult)
        {
            this.ExportCachedReportResult = ExportCachedReportResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IResourceServiceChannel : ReportService.IResourceService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ResourceServiceClient : System.ServiceModel.ClientBase<ReportService.IResourceService>, ReportService.IResourceService
    {
        
        public ResourceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReportService.GetRenderStreamResponse> ReportService.IResourceService.GetRenderStreamAsync(ReportService.GetRenderStreamRequest request)
        {
            return base.Channel.GetRenderStreamAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReportService.GetRenderStreamResponse> GetRenderStreamAsync(string instanceID, string name)
        {
            ReportService.GetRenderStreamRequest inValue = new ReportService.GetRenderStreamRequest();
            inValue.Body = new ReportService.GetRenderStreamRequestBody();
            inValue.Body.instanceID = instanceID;
            inValue.Body.name = name;
            return ((ReportService.IResourceService)(this)).GetRenderStreamAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReportService.ExportResponse> ReportService.IResourceService.ExportAsync(ReportService.ExportRequest request)
        {
            return base.Channel.ExportAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReportService.ExportResponse> ExportAsync(string format, string report, string deviceInfo, string parameterValues)
        {
            ReportService.ExportRequest inValue = new ReportService.ExportRequest();
            inValue.Body = new ReportService.ExportRequestBody();
            inValue.Body.format = format;
            inValue.Body.report = report;
            inValue.Body.deviceInfo = deviceInfo;
            inValue.Body.parameterValues = parameterValues;
            return ((ReportService.IResourceService)(this)).ExportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ReportService.ExportCachedReportResponse> ReportService.IResourceService.ExportCachedReportAsync(ReportService.ExportCachedReportRequest request)
        {
            return base.Channel.ExportCachedReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<ReportService.ExportCachedReportResponse> ExportCachedReportAsync(string instanceID, string format, string deviceInfo)
        {
            ReportService.ExportCachedReportRequest inValue = new ReportService.ExportCachedReportRequest();
            inValue.Body = new ReportService.ExportCachedReportRequestBody();
            inValue.Body.instanceID = instanceID;
            inValue.Body.format = format;
            inValue.Body.deviceInfo = deviceInfo;
            return ((ReportService.IResourceService)(this)).ExportCachedReportAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
