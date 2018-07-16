// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/spanner/v1/query_plan.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Spanner.V1 {

  /// <summary>Holder for reflection information generated from google/spanner/v1/query_plan.proto</summary>
  public static partial class QueryPlanReflection {

    #region Descriptor
    /// <summary>File descriptor for google/spanner/v1/query_plan.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryPlanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvc3Bhbm5lci92MS9xdWVyeV9wbGFuLnByb3RvEhFnb29nbGUu",
            "c3Bhbm5lci52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxocZ29v",
            "Z2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90byL4BAoIUGxhbk5vZGUSDQoFaW5k",
            "ZXgYASABKAUSLgoEa2luZBgCIAEoDjIgLmdvb2dsZS5zcGFubmVyLnYxLlBs",
            "YW5Ob2RlLktpbmQSFAoMZGlzcGxheV9uYW1lGAMgASgJEjoKC2NoaWxkX2xp",
            "bmtzGAQgAygLMiUuZ29vZ2xlLnNwYW5uZXIudjEuUGxhbk5vZGUuQ2hpbGRM",
            "aW5rEk0KFHNob3J0X3JlcHJlc2VudGF0aW9uGAUgASgLMi8uZ29vZ2xlLnNw",
            "YW5uZXIudjEuUGxhbk5vZGUuU2hvcnRSZXByZXNlbnRhdGlvbhIpCghtZXRh",
            "ZGF0YRgGIAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3QSMAoPZXhlY3V0",
            "aW9uX3N0YXRzGAcgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0cnVjdBpACglD",
            "aGlsZExpbmsSEwoLY2hpbGRfaW5kZXgYASABKAUSDAoEdHlwZRgCIAEoCRIQ",
            "Cgh2YXJpYWJsZRgDIAEoCRqyAQoTU2hvcnRSZXByZXNlbnRhdGlvbhITCgtk",
            "ZXNjcmlwdGlvbhgBIAEoCRJTCgpzdWJxdWVyaWVzGAIgAygLMj8uZ29vZ2xl",
            "LnNwYW5uZXIudjEuUGxhbk5vZGUuU2hvcnRSZXByZXNlbnRhdGlvbi5TdWJx",
            "dWVyaWVzRW50cnkaMQoPU3VicXVlcmllc0VudHJ5EgsKA2tleRgBIAEoCRIN",
            "CgV2YWx1ZRgCIAEoBToCOAEiOAoES2luZBIUChBLSU5EX1VOU1BFQ0lGSUVE",
            "EAASDgoKUkVMQVRJT05BTBABEgoKBlNDQUxBUhACIjwKCVF1ZXJ5UGxhbhIv",
            "CgpwbGFuX25vZGVzGAEgAygLMhsuZ29vZ2xlLnNwYW5uZXIudjEuUGxhbk5v",
            "ZGVClwEKFWNvbS5nb29nbGUuc3Bhbm5lci52MUIOUXVlcnlQbGFuUHJvdG9Q",
            "AVo4Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9zcGFu",
            "bmVyL3YxO3NwYW5uZXKqAhdHb29nbGUuQ2xvdWQuU3Bhbm5lci5WMcoCF0dv",
            "b2dsZVxDbG91ZFxTcGFubmVyXFYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.PlanNode), global::Google.Cloud.Spanner.V1.PlanNode.Parser, new[]{ "Index", "Kind", "DisplayName", "ChildLinks", "ShortRepresentation", "Metadata", "ExecutionStats" }, null, new[]{ typeof(global::Google.Cloud.Spanner.V1.PlanNode.Types.Kind) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink), global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink.Parser, new[]{ "ChildIndex", "Type", "Variable" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.PlanNode.Types.ShortRepresentation), global::Google.Cloud.Spanner.V1.PlanNode.Types.ShortRepresentation.Parser, new[]{ "Description", "Subqueries" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.QueryPlan), global::Google.Cloud.Spanner.V1.QueryPlan.Parser, new[]{ "PlanNodes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Node information for nodes appearing in a [QueryPlan.plan_nodes][google.spanner.v1.QueryPlan.plan_nodes].
  /// </summary>
  public sealed partial class PlanNode : pb::IMessage<PlanNode> {
    private static readonly pb::MessageParser<PlanNode> _parser = new pb::MessageParser<PlanNode>(() => new PlanNode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlanNode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.QueryPlanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlanNode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlanNode(PlanNode other) : this() {
      index_ = other.index_;
      kind_ = other.kind_;
      displayName_ = other.displayName_;
      childLinks_ = other.childLinks_.Clone();
      shortRepresentation_ = other.shortRepresentation_ != null ? other.shortRepresentation_.Clone() : null;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      executionStats_ = other.executionStats_ != null ? other.executionStats_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlanNode Clone() {
      return new PlanNode(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    /// <summary>
    /// The `PlanNode`'s index in [node list][google.spanner.v1.QueryPlan.plan_nodes].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 2;
    private global::Google.Cloud.Spanner.V1.PlanNode.Types.Kind kind_ = 0;
    /// <summary>
    /// Used to determine the type of node. May be needed for visualizing
    /// different kinds of nodes differently. For example, If the node is a
    /// [SCALAR][google.spanner.v1.PlanNode.Kind.SCALAR] node, it will have a condensed representation
    /// which can be used to directly embed a description of the node in its
    /// parent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.PlanNode.Types.Kind Kind {
      get { return kind_; }
      set {
        kind_ = value;
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private string displayName_ = "";
    /// <summary>
    /// The display name for the node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "child_links" field.</summary>
    public const int ChildLinksFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink> _repeated_childLinks_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink> childLinks_ = new pbc::RepeatedField<global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink>();
    /// <summary>
    /// List of child node `index`es and their relationship to this parent.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Spanner.V1.PlanNode.Types.ChildLink> ChildLinks {
      get { return childLinks_; }
    }

    /// <summary>Field number for the "short_representation" field.</summary>
    public const int ShortRepresentationFieldNumber = 5;
    private global::Google.Cloud.Spanner.V1.PlanNode.Types.ShortRepresentation shortRepresentation_;
    /// <summary>
    /// Condensed representation for [SCALAR][google.spanner.v1.PlanNode.Kind.SCALAR] nodes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Spanner.V1.PlanNode.Types.ShortRepresentation ShortRepresentation {
      get { return shortRepresentation_; }
      set {
        shortRepresentation_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Struct metadata_;
    /// <summary>
    /// Attributes relevant to the node contained in a group of key-value pairs.
    /// For example, a Parameter Reference node could have the following
    /// information in its metadata:
    ///
    ///     {
    ///       "parameter_reference": "param1",
    ///       "parameter_type": "array"
    ///     }
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "execution_stats" field.</summary>
    public const int ExecutionStatsFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Struct executionStats_;
    /// <summary>
    /// The execution statistics associated with the node, contained in a group of
    /// key-value pairs. Only present if the plan was returned as a result of a
    /// profile query. For example, number of executions, number of rows/time per
    /// execution etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct ExecutionStats {
      get { return executionStats_; }
      set {
        executionStats_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlanNode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlanNode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (Kind != other.Kind) return false;
      if (DisplayName != other.DisplayName) return false;
      if(!childLinks_.Equals(other.childLinks_)) return false;
      if (!object.Equals(ShortRepresentation, other.ShortRepresentation)) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (!object.Equals(ExecutionStats, other.ExecutionStats)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (Kind != 0) hash ^= Kind.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      hash ^= childLinks_.GetHashCode();
      if (shortRepresentation_ != null) hash ^= ShortRepresentation.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (executionStats_ != null) hash ^= ExecutionStats.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (Kind != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Kind);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      childLinks_.WriteTo(output, _repeated_childLinks_codec);
      if (shortRepresentation_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ShortRepresentation);
      }
      if (metadata_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Metadata);
      }
      if (executionStats_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ExecutionStats);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (Kind != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Kind);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      size += childLinks_.CalculateSize(_repeated_childLinks_codec);
      if (shortRepresentation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShortRepresentation);
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (executionStats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExecutionStats);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlanNode other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.Kind != 0) {
        Kind = other.Kind;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      childLinks_.Add(other.childLinks_);
      if (other.shortRepresentation_ != null) {
        if (shortRepresentation_ == null) {
          shortRepresentation_ = new global::Google.Cloud.Spanner.V1.PlanNode.Types.ShortRepresentation();
        }
        ShortRepresentation.MergeFrom(other.ShortRepresentation);
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      if (other.executionStats_ != null) {
        if (executionStats_ == null) {
          executionStats_ = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        ExecutionStats.MergeFrom(other.ExecutionStats);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Index = input.ReadInt32();
            break;
          }
          case 16: {
            kind_ = (global::Google.Cloud.Spanner.V1.PlanNode.Types.Kind) input.ReadEnum();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            childLinks_.AddEntriesFrom(input, _repeated_childLinks_codec);
            break;
          }
          case 42: {
            if (shortRepresentation_ == null) {
              shortRepresentation_ = new global::Google.Cloud.Spanner.V1.PlanNode.Types.ShortRepresentation();
            }
            input.ReadMessage(shortRepresentation_);
            break;
          }
          case 50: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(metadata_);
            break;
          }
          case 58: {
            if (executionStats_ == null) {
              executionStats_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(executionStats_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PlanNode message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The kind of [PlanNode][google.spanner.v1.PlanNode]. Distinguishes between the two different kinds of
      /// nodes that can appear in a query plan.
      /// </summary>
      public enum Kind {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("KIND_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Denotes a Relational operator node in the expression tree. Relational
        /// operators represent iterative processing of rows during query execution.
        /// For example, a `TableScan` operation that reads rows from a table.
        /// </summary>
        [pbr::OriginalName("RELATIONAL")] Relational = 1,
        /// <summary>
        /// Denotes a Scalar node in the expression tree. Scalar nodes represent
        /// non-iterable entities in the query plan. For example, constants or
        /// arithmetic operators appearing inside predicate expressions or references
        /// to column names.
        /// </summary>
        [pbr::OriginalName("SCALAR")] Scalar = 2,
      }

      /// <summary>
      /// Metadata associated with a parent-child relationship appearing in a
      /// [PlanNode][google.spanner.v1.PlanNode].
      /// </summary>
      public sealed partial class ChildLink : pb::IMessage<ChildLink> {
        private static readonly pb::MessageParser<ChildLink> _parser = new pb::MessageParser<ChildLink>(() => new ChildLink());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ChildLink> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Spanner.V1.PlanNode.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ChildLink() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ChildLink(ChildLink other) : this() {
          childIndex_ = other.childIndex_;
          type_ = other.type_;
          variable_ = other.variable_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ChildLink Clone() {
          return new ChildLink(this);
        }

        /// <summary>Field number for the "child_index" field.</summary>
        public const int ChildIndexFieldNumber = 1;
        private int childIndex_;
        /// <summary>
        /// The node to which the link points.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int ChildIndex {
          get { return childIndex_; }
          set {
            childIndex_ = value;
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private string type_ = "";
        /// <summary>
        /// The type of the link. For example, in Hash Joins this could be used to
        /// distinguish between the build child and the probe child, or in the case
        /// of the child being an output variable, to represent the tag associated
        /// with the output variable.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Type {
          get { return type_; }
          set {
            type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "variable" field.</summary>
        public const int VariableFieldNumber = 3;
        private string variable_ = "";
        /// <summary>
        /// Only present if the child node is [SCALAR][google.spanner.v1.PlanNode.Kind.SCALAR] and corresponds
        /// to an output variable of the parent node. The field carries the name of
        /// the output variable.
        /// For example, a `TableScan` operator that reads rows from a table will
        /// have child links to the `SCALAR` nodes representing the output variables
        /// created for each column that is read by the operator. The corresponding
        /// `variable` fields will be set to the variable names assigned to the
        /// columns.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Variable {
          get { return variable_; }
          set {
            variable_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ChildLink);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ChildLink other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ChildIndex != other.ChildIndex) return false;
          if (Type != other.Type) return false;
          if (Variable != other.Variable) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ChildIndex != 0) hash ^= ChildIndex.GetHashCode();
          if (Type.Length != 0) hash ^= Type.GetHashCode();
          if (Variable.Length != 0) hash ^= Variable.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (ChildIndex != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(ChildIndex);
          }
          if (Type.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Type);
          }
          if (Variable.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Variable);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ChildIndex != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChildIndex);
          }
          if (Type.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
          }
          if (Variable.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Variable);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ChildLink other) {
          if (other == null) {
            return;
          }
          if (other.ChildIndex != 0) {
            ChildIndex = other.ChildIndex;
          }
          if (other.Type.Length != 0) {
            Type = other.Type;
          }
          if (other.Variable.Length != 0) {
            Variable = other.Variable;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                ChildIndex = input.ReadInt32();
                break;
              }
              case 18: {
                Type = input.ReadString();
                break;
              }
              case 26: {
                Variable = input.ReadString();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// Condensed representation of a node and its subtree. Only present for
      /// `SCALAR` [PlanNode(s)][google.spanner.v1.PlanNode].
      /// </summary>
      public sealed partial class ShortRepresentation : pb::IMessage<ShortRepresentation> {
        private static readonly pb::MessageParser<ShortRepresentation> _parser = new pb::MessageParser<ShortRepresentation>(() => new ShortRepresentation());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ShortRepresentation> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Spanner.V1.PlanNode.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ShortRepresentation() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ShortRepresentation(ShortRepresentation other) : this() {
          description_ = other.description_;
          subqueries_ = other.subqueries_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ShortRepresentation Clone() {
          return new ShortRepresentation(this);
        }

        /// <summary>Field number for the "description" field.</summary>
        public const int DescriptionFieldNumber = 1;
        private string description_ = "";
        /// <summary>
        /// A string representation of the expression subtree rooted at this node.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Description {
          get { return description_; }
          set {
            description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "subqueries" field.</summary>
        public const int SubqueriesFieldNumber = 2;
        private static readonly pbc::MapField<string, int>.Codec _map_subqueries_codec
            = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt32(16), 18);
        private readonly pbc::MapField<string, int> subqueries_ = new pbc::MapField<string, int>();
        /// <summary>
        /// A mapping of (subquery variable name) -> (subquery node id) for cases
        /// where the `description` string of this node references a `SCALAR`
        /// subquery contained in the expression subtree rooted at this node. The
        /// referenced `SCALAR` subquery may not necessarily be a direct child of
        /// this node.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, int> Subqueries {
          get { return subqueries_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ShortRepresentation);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ShortRepresentation other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Description != other.Description) return false;
          if (!Subqueries.Equals(other.Subqueries)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Description.Length != 0) hash ^= Description.GetHashCode();
          hash ^= Subqueries.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Description.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Description);
          }
          subqueries_.WriteTo(output, _map_subqueries_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Description.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
          }
          size += subqueries_.CalculateSize(_map_subqueries_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ShortRepresentation other) {
          if (other == null) {
            return;
          }
          if (other.Description.Length != 0) {
            Description = other.Description;
          }
          subqueries_.Add(other.subqueries_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Description = input.ReadString();
                break;
              }
              case 18: {
                subqueries_.AddEntriesFrom(input, _map_subqueries_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Contains an ordered list of nodes appearing in the query plan.
  /// </summary>
  public sealed partial class QueryPlan : pb::IMessage<QueryPlan> {
    private static readonly pb::MessageParser<QueryPlan> _parser = new pb::MessageParser<QueryPlan>(() => new QueryPlan());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryPlan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.QueryPlanReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryPlan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryPlan(QueryPlan other) : this() {
      planNodes_ = other.planNodes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryPlan Clone() {
      return new QueryPlan(this);
    }

    /// <summary>Field number for the "plan_nodes" field.</summary>
    public const int PlanNodesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Spanner.V1.PlanNode> _repeated_planNodes_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Spanner.V1.PlanNode.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Spanner.V1.PlanNode> planNodes_ = new pbc::RepeatedField<global::Google.Cloud.Spanner.V1.PlanNode>();
    /// <summary>
    /// The nodes in the query plan. Plan nodes are returned in pre-order starting
    /// with the plan root. Each [PlanNode][google.spanner.v1.PlanNode]'s `id` corresponds to its index in
    /// `plan_nodes`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Spanner.V1.PlanNode> PlanNodes {
      get { return planNodes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryPlan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryPlan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!planNodes_.Equals(other.planNodes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= planNodes_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      planNodes_.WriteTo(output, _repeated_planNodes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += planNodes_.CalculateSize(_repeated_planNodes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryPlan other) {
      if (other == null) {
        return;
      }
      planNodes_.Add(other.planNodes_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            planNodes_.AddEntriesFrom(input, _repeated_planNodes_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
