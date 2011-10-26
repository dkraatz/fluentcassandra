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
  public partial class CqlResult : TBase
  {
    private CqlResultType _type;
    private List<CqlRow> _rows;
    private int _num;
    private CqlMetadata _schema;

    public CqlResultType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public List<CqlRow> Rows
    {
      get
      {
        return _rows;
      }
      set
      {
        __isset.rows = true;
        this._rows = value;
      }
    }

    public int Num
    {
      get
      {
        return _num;
      }
      set
      {
        __isset.num = true;
        this._num = value;
      }
    }

    public CqlMetadata Schema
    {
      get
      {
        return _schema;
      }
      set
      {
        __isset.schema = true;
        this._schema = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool rows;
      public bool num;
      public bool schema;
    }

    public CqlResult() {
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
          case 1:
            if (field.Type == TType.I32) {
              Type = (CqlResultType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Rows = new List<CqlRow>();
                TList _list75 = iprot.ReadListBegin();
                for( int _i76 = 0; _i76 < _list75.Count; ++_i76)
                {
                  CqlRow _elem77 = new CqlRow();
                  _elem77 = new CqlRow();
                  _elem77.Read(iprot);
                  Rows.Add(_elem77);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Struct) {
              Schema = new CqlMetadata();
              Schema.Read(iprot);
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
      TStruct struc = new TStruct("CqlResult");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Type);
        oprot.WriteFieldEnd();
      }
      if (Rows != null && __isset.rows) {
        field.Name = "rows";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Rows.Count));
          foreach (CqlRow _iter78 in Rows)
          {
            _iter78.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.num) {
        field.Name = "num";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Num);
        oprot.WriteFieldEnd();
      }
      if (Schema != null && __isset.schema) {
        field.Name = "schema";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        Schema.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CqlResult(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",Rows: ");
      sb.Append(Rows);
      sb.Append(",Num: ");
      sb.Append(Num);
      sb.Append(",Schema: ");
      sb.Append(Schema== null ? "<null>" : Schema.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
