// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Data/Market/money.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.Type {

  /// <summary>Holder for reflection information generated from Data/Market/money.proto</summary>
  public static partial class MoneyReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Market/money.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MoneyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdEYXRhL01hcmtldC9tb25leS5wcm90bxILZ29vZ2xlLnR5cGUiPAoFTW9u",
            "ZXkSFQoNY3VycmVuY3lfY29kZRgBIAEoCRINCgV1bml0cxgCIAEoAxINCgVu",
            "YW5vcxgDIAEoBUJ3Cg9jb20uZ29vZ2xlLnR5cGVCCk1vbmV5UHJvdG9QAVo2",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy90eXBlL21v",
            "bmV5O21vbmV5+AEBogIDR1RQqgIUR29vZ2xlLlByb3RvYnVmLlR5cGViBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Type.Money), global::Google.Protobuf.Type.Money.Parser, new[]{ "CurrencyCode", "Units", "Nanos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents an amount of money with its currency type.
  /// </summary>
  public sealed partial class Money : pb::IMessage<Money>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Money> _parser = new pb::MessageParser<Money>(() => new Money());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Money> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.Type.MoneyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Money() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Money(Money other) : this() {
      currencyCode_ = other.currencyCode_;
      units_ = other.units_;
      nanos_ = other.nanos_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Money Clone() {
      return new Money(this);
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 1;
    private string currencyCode_ = "";
    /// <summary>
    /// The 3-letter currency code defined in ISO 4217.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "units" field.</summary>
    public const int UnitsFieldNumber = 2;
    private long units_;
    /// <summary>
    /// The whole units of the amount.
    /// For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Units {
      get { return units_; }
      set {
        units_ = value;
      }
    }

    /// <summary>Field number for the "nanos" field.</summary>
    public const int NanosFieldNumber = 3;
    private int nanos_;
    /// <summary>
    /// Number of nano (10^-9) units of the amount.
    /// The value must be between -999,999,999 and +999,999,999 inclusive.
    /// If `units` is positive, `nanos` must be positive or zero.
    /// If `units` is zero, `nanos` can be positive, zero, or negative.
    /// If `units` is negative, `nanos` must be negative or zero.
    /// For example $-1.75 is represented as `units`=-1 and `nanos`=-750,000,000.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Money);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Money other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrencyCode != other.CurrencyCode) return false;
      if (Units != other.Units) return false;
      if (Nanos != other.Nanos) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrencyCode.Length != 0) hash ^= CurrencyCode.GetHashCode();
      if (Units != 0L) hash ^= Units.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CurrencyCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrencyCode);
      }
      if (Units != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Units);
      }
      if (Nanos != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CurrencyCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrencyCode);
      }
      if (Units != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Units);
      }
      if (Nanos != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrencyCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (Units != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Units);
      }
      if (Nanos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nanos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Money other) {
      if (other == null) {
        return;
      }
      if (other.CurrencyCode.Length != 0) {
        CurrencyCode = other.CurrencyCode;
      }
      if (other.Units != 0L) {
        Units = other.Units;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 16: {
            Units = input.ReadInt64();
            break;
          }
          case 24: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 16: {
            Units = input.ReadInt64();
            break;
          }
          case 24: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
