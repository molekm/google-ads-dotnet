// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/user_location_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/user_location_view.proto</summary>
  public static partial class UserLocationViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/user_location_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserLocationViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvdXNlcl9sb2Nh",
            "dGlvbl92aWV3LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5yZXNv",
            "dXJjZXMaHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byKcAQoQVXNlckxvY2F0aW9uVmlldxIV",
            "Cg1yZXNvdXJjZV9uYW1lGAEgASgJEjkKFGNvdW50cnlfY3JpdGVyaW9uX2lk",
            "GAIgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWUSNgoSdGFyZ2V0",
            "aW5nX2xvY2F0aW9uGAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLkJvb2xWYWx1",
            "ZUKCAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291cmNlc0IV",
            "VXNlckxvY2F0aW9uVmlld1Byb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXM7",
            "cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuUmVz",
            "b3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcUmVzb3VyY2Vz6gIl",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.UserLocationView), global::Google.Ads.GoogleAds.V2.Resources.UserLocationView.Parser, new[]{ "ResourceName", "CountryCriterionId", "TargetingLocation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A user location view.
  ///
  /// User Location View includes all metrics aggregated at the country level,
  /// one row per country. It reports metrics at the actual physical location of
  /// the user by targeted or not targeted location. If other segment fields are
  /// used, you may get more than one row per country.
  /// </summary>
  public sealed partial class UserLocationView : pb::IMessage<UserLocationView> {
    private static readonly pb::MessageParser<UserLocationView> _parser = new pb::MessageParser<UserLocationView>(() => new UserLocationView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLocationView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.UserLocationViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLocationView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLocationView(UserLocationView other) : this() {
      resourceName_ = other.resourceName_;
      CountryCriterionId = other.CountryCriterionId;
      TargetingLocation = other.TargetingLocation;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLocationView Clone() {
      return new UserLocationView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the user location view.
    /// UserLocation view resource names have the form:
    ///
    /// `customers/{customer_id}/userLocationViews/{country_criterion_id}~{targeting_location}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country_criterion_id" field.</summary>
    public const int CountryCriterionIdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_countryCriterionId_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? countryCriterionId_;
    /// <summary>
    /// Criterion Id for the country.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CountryCriterionId {
      get { return countryCriterionId_; }
      set {
        countryCriterionId_ = value;
      }
    }


    /// <summary>Field number for the "targeting_location" field.</summary>
    public const int TargetingLocationFieldNumber = 3;
    private static readonly pb::FieldCodec<bool?> _single_targetingLocation_codec = pb::FieldCodec.ForStructWrapper<bool>(26);
    private bool? targetingLocation_;
    /// <summary>
    /// Indicates whether location was targeted or not.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? TargetingLocation {
      get { return targetingLocation_; }
      set {
        targetingLocation_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLocationView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLocationView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CountryCriterionId != other.CountryCriterionId) return false;
      if (TargetingLocation != other.TargetingLocation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (countryCriterionId_ != null) hash ^= CountryCriterionId.GetHashCode();
      if (targetingLocation_ != null) hash ^= TargetingLocation.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (countryCriterionId_ != null) {
        _single_countryCriterionId_codec.WriteTagAndValue(output, CountryCriterionId);
      }
      if (targetingLocation_ != null) {
        _single_targetingLocation_codec.WriteTagAndValue(output, TargetingLocation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (countryCriterionId_ != null) {
        size += _single_countryCriterionId_codec.CalculateSizeWithTag(CountryCriterionId);
      }
      if (targetingLocation_ != null) {
        size += _single_targetingLocation_codec.CalculateSizeWithTag(TargetingLocation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLocationView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.countryCriterionId_ != null) {
        if (countryCriterionId_ == null || other.CountryCriterionId != 0L) {
          CountryCriterionId = other.CountryCriterionId;
        }
      }
      if (other.targetingLocation_ != null) {
        if (targetingLocation_ == null || other.TargetingLocation != false) {
          TargetingLocation = other.TargetingLocation;
        }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_countryCriterionId_codec.Read(input);
            if (countryCriterionId_ == null || value != 0L) {
              CountryCriterionId = value;
            }
            break;
          }
          case 26: {
            bool? value = _single_targetingLocation_codec.Read(input);
            if (targetingLocation_ == null || value != false) {
              TargetingLocation = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
