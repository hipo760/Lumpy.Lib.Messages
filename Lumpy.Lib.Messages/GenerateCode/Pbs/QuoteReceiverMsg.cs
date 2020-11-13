// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Services/Quote/quote_receiver_msg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Htf.Schemas.V1.Service.Quote {

  /// <summary>Holder for reflection information generated from Services/Quote/quote_receiver_msg.proto</summary>
  public static partial class QuoteReceiverMsgReflection {

    #region Descriptor
    /// <summary>File descriptor for Services/Quote/quote_receiver_msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuoteReceiverMsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZXJ2aWNlcy9RdW90ZS9xdW90ZV9yZWNlaXZlcl9tc2cucHJvdG8SHGh0",
            "Zi5zY2hlbWFzLnYxLnNlcnZpY2UucXVvdGUaH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8i+wEKEVF1b3RlU3Vic2NyaXB0aW9uEkwKCW9wZXJh",
            "dGlvbhgBIAEoDjI5Lmh0Zi5zY2hlbWFzLnYxLnNlcnZpY2UucXVvdGUuUXVv",
            "dGVTdWJzY3JpcHRpb24uT3BlcmF0aW9uEhAKCGV4Y2hhbmdlGAIgASgJEg4K",
            "BnN5bWJvbBgDIAEoCRIZChFvaGxjX2ludGVydmFsX3NlYxgEIAEoBRIuCgpz",
            "dGFydF90aW1lGAUgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcCIr",
            "CglPcGVyYXRpb24SDQoJU1VCU0NSSUJFEAASDwoLVU5TVUJTQ1JJQkUQASJW",
            "ChJRdW90ZVN1YnNjcmlwdGlvbnMSQAoHc3ltYm9scxgBIAMoCzIvLmh0Zi5z",
            "Y2hlbWFzLnYxLnNlcnZpY2UucXVvdGUuUXVvdGVTdWJzY3JpcHRpb25CH6oC",
            "HEh0Zi5TY2hlbWFzLlYxLlNlcnZpY2UuUXVvdGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Htf.Schemas.V1.Service.Quote.QuoteSubscription), global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Parser, new[]{ "Operation", "Exchange", "Symbol", "OhlcIntervalSec", "StartTime" }, null, new[]{ typeof(global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Htf.Schemas.V1.Service.Quote.QuoteSubscriptions), global::Htf.Schemas.V1.Service.Quote.QuoteSubscriptions.Parser, new[]{ "Symbols" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuoteSubscription : pb::IMessage<QuoteSubscription>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuoteSubscription> _parser = new pb::MessageParser<QuoteSubscription>(() => new QuoteSubscription());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuoteSubscription> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Htf.Schemas.V1.Service.Quote.QuoteReceiverMsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuoteSubscription() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuoteSubscription(QuoteSubscription other) : this() {
      operation_ = other.operation_;
      exchange_ = other.exchange_;
      symbol_ = other.symbol_;
      ohlcIntervalSec_ = other.ohlcIntervalSec_;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuoteSubscription Clone() {
      return new QuoteSubscription(this);
    }

    /// <summary>Field number for the "operation" field.</summary>
    public const int OperationFieldNumber = 1;
    private global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation operation_ = global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation.Subscribe;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation Operation {
      get { return operation_; }
      set {
        operation_ = value;
      }
    }

    /// <summary>Field number for the "exchange" field.</summary>
    public const int ExchangeFieldNumber = 2;
    private string exchange_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Exchange {
      get { return exchange_; }
      set {
        exchange_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 3;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ohlc_interval_sec" field.</summary>
    public const int OhlcIntervalSecFieldNumber = 4;
    private int ohlcIntervalSec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OhlcIntervalSec {
      get { return ohlcIntervalSec_; }
      set {
        ohlcIntervalSec_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QuoteSubscription);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuoteSubscription other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Operation != other.Operation) return false;
      if (Exchange != other.Exchange) return false;
      if (Symbol != other.Symbol) return false;
      if (OhlcIntervalSec != other.OhlcIntervalSec) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Operation != global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation.Subscribe) hash ^= Operation.GetHashCode();
      if (Exchange.Length != 0) hash ^= Exchange.GetHashCode();
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (OhlcIntervalSec != 0) hash ^= OhlcIntervalSec.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
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
      if (Operation != global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation.Subscribe) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Operation);
      }
      if (Exchange.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Exchange);
      }
      if (Symbol.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Symbol);
      }
      if (OhlcIntervalSec != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(OhlcIntervalSec);
      }
      if (startTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(StartTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Operation != global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation.Subscribe) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Operation);
      }
      if (Exchange.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Exchange);
      }
      if (Symbol.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Symbol);
      }
      if (OhlcIntervalSec != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(OhlcIntervalSec);
      }
      if (startTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(StartTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Operation != global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation.Subscribe) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Operation);
      }
      if (Exchange.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Exchange);
      }
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (OhlcIntervalSec != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OhlcIntervalSec);
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuoteSubscription other) {
      if (other == null) {
        return;
      }
      if (other.Operation != global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation.Subscribe) {
        Operation = other.Operation;
      }
      if (other.Exchange.Length != 0) {
        Exchange = other.Exchange;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.OhlcIntervalSec != 0) {
        OhlcIntervalSec = other.OhlcIntervalSec;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
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
          case 8: {
            Operation = (global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation) input.ReadEnum();
            break;
          }
          case 18: {
            Exchange = input.ReadString();
            break;
          }
          case 26: {
            Symbol = input.ReadString();
            break;
          }
          case 32: {
            OhlcIntervalSec = input.ReadInt32();
            break;
          }
          case 42: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
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
          case 8: {
            Operation = (global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Types.Operation) input.ReadEnum();
            break;
          }
          case 18: {
            Exchange = input.ReadString();
            break;
          }
          case 26: {
            Symbol = input.ReadString();
            break;
          }
          case 32: {
            OhlcIntervalSec = input.ReadInt32();
            break;
          }
          case 42: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the QuoteSubscription message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Operation {
        [pbr::OriginalName("SUBSCRIBE")] Subscribe = 0,
        [pbr::OriginalName("UNSUBSCRIBE")] Unsubscribe = 1,
      }

    }
    #endregion

  }

  public sealed partial class QuoteSubscriptions : pb::IMessage<QuoteSubscriptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuoteSubscriptions> _parser = new pb::MessageParser<QuoteSubscriptions>(() => new QuoteSubscriptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuoteSubscriptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Htf.Schemas.V1.Service.Quote.QuoteReceiverMsgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuoteSubscriptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuoteSubscriptions(QuoteSubscriptions other) : this() {
      symbols_ = other.symbols_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuoteSubscriptions Clone() {
      return new QuoteSubscriptions(this);
    }

    /// <summary>Field number for the "symbols" field.</summary>
    public const int SymbolsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Htf.Schemas.V1.Service.Quote.QuoteSubscription> _repeated_symbols_codec
        = pb::FieldCodec.ForMessage(10, global::Htf.Schemas.V1.Service.Quote.QuoteSubscription.Parser);
    private readonly pbc::RepeatedField<global::Htf.Schemas.V1.Service.Quote.QuoteSubscription> symbols_ = new pbc::RepeatedField<global::Htf.Schemas.V1.Service.Quote.QuoteSubscription>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Htf.Schemas.V1.Service.Quote.QuoteSubscription> Symbols {
      get { return symbols_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QuoteSubscriptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuoteSubscriptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!symbols_.Equals(other.symbols_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= symbols_.GetHashCode();
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
      symbols_.WriteTo(output, _repeated_symbols_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      symbols_.WriteTo(ref output, _repeated_symbols_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += symbols_.CalculateSize(_repeated_symbols_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuoteSubscriptions other) {
      if (other == null) {
        return;
      }
      symbols_.Add(other.symbols_);
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
            symbols_.AddEntriesFrom(input, _repeated_symbols_codec);
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
            symbols_.AddEntriesFrom(ref input, _repeated_symbols_codec);
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
