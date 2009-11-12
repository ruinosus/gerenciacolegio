using System;
using System.Reflection;

namespace Negocios.ModuloConexao
{
    /// <summary>
    /// Lista dos Locking Hints
    /// </summary>
    public enum Hints
    {
        [Atributos("")]
        None,
        [Atributos("FASTFIRSTROW")]
        FastFirstRow,
        [Atributos("HOLDLOCK")]
        HoldLock,
        [Atributos("NOLOCK")]
        NoLock,
        [Atributos("NOWAIT")]
        NoWait,
        [Atributos("PAGLOCK")]
        PagLock,
        [Atributos("READCOMMITTED")]
        ReadCommitted,
        [Atributos("READCOMMITTEDLOCK")]
        ReadCommittedLock,
        [Atributos("READPAST")]
        ReadPast,
        [Atributos("READUNCOMMITTED")]
        ReadUnCommitted,
        [Atributos("REPEATABLEREAD")]
        RepeatTableRead,
        [Atributos("ROWLOCK")]
        RowLock,
        [Atributos("SERIALIZABLE")]
        Serializable,
        [Atributos("TABLOCK")]
        TabLock,
        [Atributos("TABLOCKX")]
        TabLockX,
        [Atributos("UPDLOCK")]
        UpdLock,
        [Atributos("XLOCK")]
        XLock
    }

    internal class Atributos : Attribute
    {
        private string descricao;

        public Atributos(string descricao)
        {
            this.descricao = descricao;

        }

        public string Descricao
        {
            get
            {
                if (String.IsNullOrEmpty(descricao))
                    return " ";

                return String.Format(" WITH ({0}) ", descricao);
            }
        }
    }

    public static class LockingHints
    {
        public static string GetHint(Enum hint)
        {
            Type type = hint.GetType();

            MemberInfo[] memberInfo = type.GetMember(hint.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(Atributos), false);

                if (attrs != null && attrs.Length > 0)
                    return ((Atributos)attrs[0]).Descricao;
            }
            return hint.ToString();
        }
    }
}


