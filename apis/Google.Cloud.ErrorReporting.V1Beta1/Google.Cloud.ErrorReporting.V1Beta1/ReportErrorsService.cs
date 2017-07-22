// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/clouderrorreporting/v1beta1/report_errors_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ErrorReporting.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/devtools/clouderrorreporting/v1beta1/report_errors_service.proto</summary>
  public static partial class ReportErrorsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/clouderrorreporting/v1beta1/report_errors_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportErrorsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvZGV2dG9vbHMvY2xvdWRlcnJvcnJlcG9ydGluZy92MWJldGEx",
            "L3JlcG9ydF9lcnJvcnNfc2VydmljZS5wcm90bxIrZ29vZ2xlLmRldnRvb2xz",
            "LmNsb3VkZXJyb3JyZXBvcnRpbmcudjFiZXRhMRocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90bxo4Z29vZ2xlL2RldnRvb2xzL2Nsb3VkZXJyb3JyZXBv",
            "cnRpbmcvdjFiZXRhMS9jb21tb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8ifwoXUmVwb3J0RXJyb3JFdmVudFJlcXVlc3QSFAoM",
            "cHJvamVjdF9uYW1lGAEgASgJEk4KBWV2ZW50GAIgASgLMj8uZ29vZ2xlLmRl",
            "dnRvb2xzLmNsb3VkZXJyb3JyZXBvcnRpbmcudjFiZXRhMS5SZXBvcnRlZEVy",
            "cm9yRXZlbnQiGgoYUmVwb3J0RXJyb3JFdmVudFJlc3BvbnNlIvcBChJSZXBv",
            "cnRlZEVycm9yRXZlbnQSLgoKZXZlbnRfdGltZRgBIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5UaW1lc3RhbXASVAoPc2VydmljZV9jb250ZXh0GAIgASgLMjsu",
            "Z29vZ2xlLmRldnRvb2xzLmNsb3VkZXJyb3JyZXBvcnRpbmcudjFiZXRhMS5T",
            "ZXJ2aWNlQ29udGV4dBIPCgdtZXNzYWdlGAMgASgJEkoKB2NvbnRleHQYBCAB",
            "KAsyOS5nb29nbGUuZGV2dG9vbHMuY2xvdWRlcnJvcnJlcG9ydGluZy52MWJl",
            "dGExLkVycm9yQ29udGV4dDL4AQoTUmVwb3J0RXJyb3JzU2VydmljZRLgAQoQ",
            "UmVwb3J0RXJyb3JFdmVudBJELmdvb2dsZS5kZXZ0b29scy5jbG91ZGVycm9y",
            "cmVwb3J0aW5nLnYxYmV0YTEuUmVwb3J0RXJyb3JFdmVudFJlcXVlc3QaRS5n",
            "b29nbGUuZGV2dG9vbHMuY2xvdWRlcnJvcnJlcG9ydGluZy52MWJldGExLlJl",
            "cG9ydEVycm9yRXZlbnRSZXNwb25zZSI/gtPkkwI5IjAvdjFiZXRhMS97cHJv",
            "amVjdF9uYW1lPXByb2plY3RzLyp9L2V2ZW50czpyZXBvcnQ6BWV2ZW50QtMB",
            "Ci9jb20uZ29vZ2xlLmRldnRvb2xzLmNsb3VkZXJyb3JyZXBvcnRpbmcudjFi",
            "ZXRhMUIYUmVwb3J0RXJyb3JzU2VydmljZVByb3RvUAFaXmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvZGV2dG9vbHMvY2xvdWRlcnJv",
            "cnJlcG9ydGluZy92MWJldGExO2Nsb3VkZXJyb3JyZXBvcnRpbmeqAiNHb29n",
            "bGUuQ2xvdWQuRXJyb3JSZXBvcnRpbmcuVjFCZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.ErrorReporting.V1Beta1.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest), global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest.Parser, new[]{ "ProjectName", "Event" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse), global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ErrorReporting.V1Beta1.ReportedErrorEvent), global::Google.Cloud.ErrorReporting.V1Beta1.ReportedErrorEvent.Parser, new[]{ "EventTime", "ServiceContext", "Message", "Context" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A request for reporting an individual error event.
  /// </summary>
  public sealed partial class ReportErrorEventRequest : pb::IMessage<ReportErrorEventRequest> {
    private static readonly pb::MessageParser<ReportErrorEventRequest> _parser = new pb::MessageParser<ReportErrorEventRequest>(() => new ReportErrorEventRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportErrorEventRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportErrorEventRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportErrorEventRequest(ReportErrorEventRequest other) : this() {
      projectName_ = other.projectName_;
      Event = other.event_ != null ? other.Event.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportErrorEventRequest Clone() {
      return new ReportErrorEventRequest(this);
    }

    /// <summary>Field number for the "project_name" field.</summary>
    public const int ProjectNameFieldNumber = 1;
    private string projectName_ = "";
    /// <summary>
    /// [Required] The resource name of the Google Cloud Platform project. Written
    /// as `projects/` plus the
    /// [Google Cloud Platform project ID](https://support.google.com/cloud/answer/6158840).
    /// Example: `projects/my-project-123`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProjectName {
      get { return projectName_; }
      set {
        projectName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 2;
    private global::Google.Cloud.ErrorReporting.V1Beta1.ReportedErrorEvent event_;
    /// <summary>
    /// [Required] The error event to be reported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.ErrorReporting.V1Beta1.ReportedErrorEvent Event {
      get { return event_; }
      set {
        event_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportErrorEventRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportErrorEventRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProjectName != other.ProjectName) return false;
      if (!object.Equals(Event, other.Event)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProjectName.Length != 0) hash ^= ProjectName.GetHashCode();
      if (event_ != null) hash ^= Event.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ProjectName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProjectName);
      }
      if (event_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Event);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProjectName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectName);
      }
      if (event_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Event);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportErrorEventRequest other) {
      if (other == null) {
        return;
      }
      if (other.ProjectName.Length != 0) {
        ProjectName = other.ProjectName;
      }
      if (other.event_ != null) {
        if (event_ == null) {
          event_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ReportedErrorEvent();
        }
        Event.MergeFrom(other.Event);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ProjectName = input.ReadString();
            break;
          }
          case 18: {
            if (event_ == null) {
              event_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ReportedErrorEvent();
            }
            input.ReadMessage(event_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response for reporting an individual error event.
  /// Data may be added to this message in the future.
  /// </summary>
  public sealed partial class ReportErrorEventResponse : pb::IMessage<ReportErrorEventResponse> {
    private static readonly pb::MessageParser<ReportErrorEventResponse> _parser = new pb::MessageParser<ReportErrorEventResponse>(() => new ReportErrorEventResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportErrorEventResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportErrorEventResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportErrorEventResponse(ReportErrorEventResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportErrorEventResponse Clone() {
      return new ReportErrorEventResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportErrorEventResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportErrorEventResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportErrorEventResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  /// An error event which is reported to the Error Reporting system.
  /// </summary>
  public sealed partial class ReportedErrorEvent : pb::IMessage<ReportedErrorEvent> {
    private static readonly pb::MessageParser<ReportedErrorEvent> _parser = new pb::MessageParser<ReportedErrorEvent>(() => new ReportedErrorEvent());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportedErrorEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportedErrorEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportedErrorEvent(ReportedErrorEvent other) : this() {
      EventTime = other.eventTime_ != null ? other.EventTime.Clone() : null;
      ServiceContext = other.serviceContext_ != null ? other.ServiceContext.Clone() : null;
      message_ = other.message_;
      Context = other.context_ != null ? other.Context.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportedErrorEvent Clone() {
      return new ReportedErrorEvent(this);
    }

    /// <summary>Field number for the "event_time" field.</summary>
    public const int EventTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp eventTime_;
    /// <summary>
    /// [Optional] Time when the event occurred.
    /// If not provided, the time when the event was received by the
    /// Error Reporting system will be used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EventTime {
      get { return eventTime_; }
      set {
        eventTime_ = value;
      }
    }

    /// <summary>Field number for the "service_context" field.</summary>
    public const int ServiceContextFieldNumber = 2;
    private global::Google.Cloud.ErrorReporting.V1Beta1.ServiceContext serviceContext_;
    /// <summary>
    /// [Required] The service context in which this error has occurred.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.ErrorReporting.V1Beta1.ServiceContext ServiceContext {
      get { return serviceContext_; }
      set {
        serviceContext_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 3;
    private string message_ = "";
    /// <summary>
    /// [Required] A message describing the error. The message can contain an
    /// exception stack in one of the supported programming languages and formats.
    /// In that case, the message is parsed and detailed exception information
    /// is returned when retrieving the error event again.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 4;
    private global::Google.Cloud.ErrorReporting.V1Beta1.ErrorContext context_;
    /// <summary>
    /// [Optional] A description of the context in which the error occurred.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.ErrorReporting.V1Beta1.ErrorContext Context {
      get { return context_; }
      set {
        context_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportedErrorEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportedErrorEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EventTime, other.EventTime)) return false;
      if (!object.Equals(ServiceContext, other.ServiceContext)) return false;
      if (Message != other.Message) return false;
      if (!object.Equals(Context, other.Context)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (eventTime_ != null) hash ^= EventTime.GetHashCode();
      if (serviceContext_ != null) hash ^= ServiceContext.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (context_ != null) hash ^= Context.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (eventTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EventTime);
      }
      if (serviceContext_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ServiceContext);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (context_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Context);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (eventTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EventTime);
      }
      if (serviceContext_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ServiceContext);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (context_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Context);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportedErrorEvent other) {
      if (other == null) {
        return;
      }
      if (other.eventTime_ != null) {
        if (eventTime_ == null) {
          eventTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EventTime.MergeFrom(other.EventTime);
      }
      if (other.serviceContext_ != null) {
        if (serviceContext_ == null) {
          serviceContext_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ServiceContext();
        }
        ServiceContext.MergeFrom(other.ServiceContext);
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.context_ != null) {
        if (context_ == null) {
          context_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ErrorContext();
        }
        Context.MergeFrom(other.Context);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (eventTime_ == null) {
              eventTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(eventTime_);
            break;
          }
          case 18: {
            if (serviceContext_ == null) {
              serviceContext_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ServiceContext();
            }
            input.ReadMessage(serviceContext_);
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 34: {
            if (context_ == null) {
              context_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ErrorContext();
            }
            input.ReadMessage(context_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
