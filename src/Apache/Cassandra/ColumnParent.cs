/**
 * Autogenerated by Thrift Compiler (0.7.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Cassandra
{

  [Serializable]
  public partial class ColumnParent : TBase
  {
    private string _column_family;
    private byte[] _super_column;

    public string Column_family
    {
      get
      {
        return _column_family;
      }
      set
      {
        __isset.column_family = true;
        this._column_family = value;
      }
    }

    public byte[] Super_column
    {
      get
      {
        return _super_column;
      }
      set
      {
        __isset.super_column = true;
        this._super_column = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool column_family;
      public bool super_column;
    }

    public ColumnParent() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 3:
            if (field.Type == TType.String) {
              Column_family = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Super_column = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ColumnParent");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Column_family != null && __isset.column_family) {
        field.Name = "column_family";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Column_family);
        oprot.WriteFieldEnd();
      }
      if (Super_column != null && __isset.super_column) {
        field.Name = "super_column";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Super_column);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ColumnParent(");
      sb.Append("Column_family: ");
      sb.Append(Column_family);
      sb.Append(",Super_column: ");
      sb.Append(Super_column);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
