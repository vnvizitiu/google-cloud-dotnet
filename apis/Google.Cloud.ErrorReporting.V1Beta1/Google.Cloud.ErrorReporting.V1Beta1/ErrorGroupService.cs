// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/clouderrorreporting/v1beta1/error_group_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.ErrorReporting.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/devtools/clouderrorreporting/v1beta1/error_group_service.proto</summary>
  public static partial class ErrorGroupServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/clouderrorreporting/v1beta1/error_group_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorGroupServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvZGV2dG9vbHMvY2xvdWRlcnJvcnJlcG9ydGluZy92MWJldGEx",
            "L2Vycm9yX2dyb3VwX3NlcnZpY2UucHJvdG8SK2dvb2dsZS5kZXZ0b29scy5j",
            "bG91ZGVycm9ycmVwb3J0aW5nLnYxYmV0YTEaHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8aOGdvb2dsZS9kZXZ0b29scy9jbG91ZGVycm9ycmVwb3J0",
            "aW5nL3YxYmV0YTEvY29tbW9uLnByb3RvIiUKD0dldEdyb3VwUmVxdWVzdBIS",
            "Cgpncm91cF9uYW1lGAEgASgJIlwKElVwZGF0ZUdyb3VwUmVxdWVzdBJGCgVn",
            "cm91cBgBIAEoCzI3Lmdvb2dsZS5kZXZ0b29scy5jbG91ZGVycm9ycmVwb3J0",
            "aW5nLnYxYmV0YTEuRXJyb3JHcm91cDKOAwoRRXJyb3JHcm91cFNlcnZpY2US",
            "tAEKCEdldEdyb3VwEjwuZ29vZ2xlLmRldnRvb2xzLmNsb3VkZXJyb3JyZXBv",
            "cnRpbmcudjFiZXRhMS5HZXRHcm91cFJlcXVlc3QaNy5nb29nbGUuZGV2dG9v",
            "bHMuY2xvdWRlcnJvcnJlcG9ydGluZy52MWJldGExLkVycm9yR3JvdXAiMYLT",
            "5JMCKxIpL3YxYmV0YTEve2dyb3VwX25hbWU9cHJvamVjdHMvKi9ncm91cHMv",
            "Kn0SwQEKC1VwZGF0ZUdyb3VwEj8uZ29vZ2xlLmRldnRvb2xzLmNsb3VkZXJy",
            "b3JyZXBvcnRpbmcudjFiZXRhMS5VcGRhdGVHcm91cFJlcXVlc3QaNy5nb29n",
            "bGUuZGV2dG9vbHMuY2xvdWRlcnJvcnJlcG9ydGluZy52MWJldGExLkVycm9y",
            "R3JvdXAiOILT5JMCMhopL3YxYmV0YTEve2dyb3VwLm5hbWU9cHJvamVjdHMv",
            "Ki9ncm91cHMvKn06BWdyb3VwQtEBCi9jb20uZ29vZ2xlLmRldnRvb2xzLmNs",
            "b3VkZXJyb3JyZXBvcnRpbmcudjFiZXRhMUIWRXJyb3JHcm91cFNlcnZpY2VQ",
            "cm90b1ABWl5nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2RldnRvb2xzL2Nsb3VkZXJyb3JyZXBvcnRpbmcvdjFiZXRhMTtjbG91ZGVy",
            "cm9ycmVwb3J0aW5nqgIjR29vZ2xlLkNsb3VkLkVycm9yUmVwb3J0aW5nLlYx",
            "QmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.ErrorReporting.V1Beta1.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ErrorReporting.V1Beta1.GetGroupRequest), global::Google.Cloud.ErrorReporting.V1Beta1.GetGroupRequest.Parser, new[]{ "GroupName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.ErrorReporting.V1Beta1.UpdateGroupRequest), global::Google.Cloud.ErrorReporting.V1Beta1.UpdateGroupRequest.Parser, new[]{ "Group" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A request to return an individual group.
  /// </summary>
  public sealed partial class GetGroupRequest : pb::IMessage<GetGroupRequest> {
    private static readonly pb::MessageParser<GetGroupRequest> _parser = new pb::MessageParser<GetGroupRequest>(() => new GetGroupRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGroupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ErrorGroupServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGroupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGroupRequest(GetGroupRequest other) : this() {
      groupName_ = other.groupName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGroupRequest Clone() {
      return new GetGroupRequest(this);
    }

    /// <summary>Field number for the "group_name" field.</summary>
    public const int GroupNameFieldNumber = 1;
    private string groupName_ = "";
    /// <summary>
    /// [Required] The group resource name. Written as
    /// &lt;code>projects/&lt;var>projectID&lt;/var>/groups/&lt;var>group_name&lt;/var>&lt;/code>.
    /// Call
    /// &lt;a href="/error-reporting/reference/rest/v1beta1/projects.groupStats/list">
    /// &lt;code>groupStats.list&lt;/code>&lt;/a> to return a list of groups belonging to
    /// this project.
    ///
    /// Example: &lt;code>projects/my-project-123/groups/my-group&lt;/code>
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GroupName {
      get { return groupName_; }
      set {
        groupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGroupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGroupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupName != other.GroupName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupName.Length != 0) hash ^= GroupName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (GroupName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GroupName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GroupName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGroupRequest other) {
      if (other == null) {
        return;
      }
      if (other.GroupName.Length != 0) {
        GroupName = other.GroupName;
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
            GroupName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A request to replace the existing data for the given group.
  /// </summary>
  public sealed partial class UpdateGroupRequest : pb::IMessage<UpdateGroupRequest> {
    private static readonly pb::MessageParser<UpdateGroupRequest> _parser = new pb::MessageParser<UpdateGroupRequest>(() => new UpdateGroupRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateGroupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ErrorGroupServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateGroupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateGroupRequest(UpdateGroupRequest other) : this() {
      Group = other.group_ != null ? other.Group.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateGroupRequest Clone() {
      return new UpdateGroupRequest(this);
    }

    /// <summary>Field number for the "group" field.</summary>
    public const int GroupFieldNumber = 1;
    private global::Google.Cloud.ErrorReporting.V1Beta1.ErrorGroup group_;
    /// <summary>
    /// [Required] The group which replaces the resource on the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.ErrorReporting.V1Beta1.ErrorGroup Group {
      get { return group_; }
      set {
        group_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateGroupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateGroupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Group, other.Group)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (group_ != null) hash ^= Group.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (group_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Group);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (group_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Group);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdateGroupRequest other) {
      if (other == null) {
        return;
      }
      if (other.group_ != null) {
        if (group_ == null) {
          group_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ErrorGroup();
        }
        Group.MergeFrom(other.Group);
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
            if (group_ == null) {
              group_ = new global::Google.Cloud.ErrorReporting.V1Beta1.ErrorGroup();
            }
            input.ReadMessage(group_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
