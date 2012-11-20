/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FluentCassandra.Thrift;
using FluentCassandra.Thrift.Collections;
using System.Runtime.Serialization;
using FluentCassandra.Thrift.Protocol;
using FluentCassandra.Thrift.Transport;

namespace Apache.Cassandra
{

  /// <summary>
  /// RPC timeout was exceeded.  either a node failed mid-operation, or load was too high, or the requested op was too large.
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TimedOutException : Exception, TBase
  {

    public TimedOutException() {
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
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TimedOutException");
      oprot.WriteStructBegin(struc);
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TimedOutException(");
      sb.Append(")");
      return sb.ToString();
    }

  }

}
