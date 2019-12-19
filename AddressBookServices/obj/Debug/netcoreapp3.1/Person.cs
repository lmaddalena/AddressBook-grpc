// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/person.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AddressBookServices {

  /// <summary>Holder for reflection information generated from Protos/person.proto</summary>
  public static partial class PersonReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/person.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3MvcGVyc29uLnByb3RvEgtBZGRyZXNzQm9vayJCCgZQZXJzb24S",
            "CgoCaWQYASABKAkSDQoFZm5hbWUYAiABKAkSDQoFbG5hbWUYAyABKAkSDgoG",
            "YWRkZXNzGAQgASgJQhaqAhNBZGRyZXNzQm9va1NlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AddressBookServices.Person), global::AddressBookServices.Person.Parser, new[]{ "Id", "Fname", "Lname", "Addess" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Person message
  /// </summary>
  public sealed partial class Person : pb::IMessage<Person> {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AddressBookServices.PersonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person(Person other) : this() {
      id_ = other.id_;
      fname_ = other.fname_;
      lname_ = other.lname_;
      addess_ = other.addess_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fname" field.</summary>
    public const int FnameFieldNumber = 2;
    private string fname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Fname {
      get { return fname_; }
      set {
        fname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lname" field.</summary>
    public const int LnameFieldNumber = 3;
    private string lname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Lname {
      get { return lname_; }
      set {
        lname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "addess" field.</summary>
    public const int AddessFieldNumber = 4;
    private string addess_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Addess {
      get { return addess_; }
      set {
        addess_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Fname != other.Fname) return false;
      if (Lname != other.Lname) return false;
      if (Addess != other.Addess) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Fname.Length != 0) hash ^= Fname.GetHashCode();
      if (Lname.Length != 0) hash ^= Lname.GetHashCode();
      if (Addess.Length != 0) hash ^= Addess.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Fname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Fname);
      }
      if (Lname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Lname);
      }
      if (Addess.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Addess);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Fname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Fname);
      }
      if (Lname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lname);
      }
      if (Addess.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Addess);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Fname.Length != 0) {
        Fname = other.Fname;
      }
      if (other.Lname.Length != 0) {
        Lname = other.Lname;
      }
      if (other.Addess.Length != 0) {
        Addess = other.Addess;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Fname = input.ReadString();
            break;
          }
          case 26: {
            Lname = input.ReadString();
            break;
          }
          case 34: {
            Addess = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code