#region Auto-generated classes for SiteColegioDB database on 2010-03-04 00:24:10Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from SiteColegioDB on 2010-03-04 00:24:10Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
#if MONO_STRICT
using System.Data.Linq;
#else   // MONO_STRICT
using DbLinq.Data.Linq;
using DbLinq.Vendor;
#endif  // MONO_STRICT
using System.ComponentModel;

namespace Negocios.ModuloBasico.VOs
{
    public partial class SiteColegioDB : DataContext
    {
        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion

        public SiteColegioDB(string connectionString)
            : base(connectionString)
        {
            OnCreated();
        }

        public SiteColegioDB(IDbConnection connection)
#if MONO_STRICT
			: base(connection)
#else   // MONO_STRICT
            : base(connection, new DbLinq.MySql.MySqlVendor())
#endif  // MONO_STRICT
        {
            OnCreated();
        }

        public SiteColegioDB(string connection, MappingSource mappingSource)
            : base(connection, mappingSource)
        {
            OnCreated();
        }

        public SiteColegioDB(IDbConnection connection, MappingSource mappingSource)
            : base(connection, mappingSource)
        {
            OnCreated();
        }

#if !MONO_STRICT
        public SiteColegioDB(IDbConnection connection, IVendor vendor)
            : base(connection, vendor)
        {
            OnCreated();
        }
#endif  // !MONO_STRICT

#if !MONO_STRICT
        public SiteColegioDB(IDbConnection connection, MappingSource mappingSource, IVendor vendor)
            : base(connection, mappingSource, vendor)
        {
            OnCreated();
        }
#endif  // !MONO_STRICT

        public Table<Imagem> Imagem { get { return GetTable<Imagem>(); } }
        public Table<Postagem> Postagem { get { return GetTable<Postagem>(); } }
        public Table<Usuario> Usuario { get { return GetTable<Usuario>(); } }

    }

    [Table(Name = "SiteColegioDB.imagem")]
    public partial class Imagem : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnCorpoChanged();
        partial void OnCorpoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemIChanged();
        partial void OnImagemIChanging(Byte[] value);
        partial void OnImagemIIChanged();
        partial void OnImagemIIChanging(Byte[] value);
        partial void OnImagemIIIChanged();
        partial void OnImagemIIIChanging(Byte[] value);
        partial void OnLegendaIChanged();
        partial void OnLegendaIChanging(string value);
        partial void OnLegendaIIChanged();
        partial void OnLegendaIIChanging(string value);
        partial void OnLegendaIIIChanged();
        partial void OnLegendaIIIChanging(string value);
        partial void OnPostagemIDChanged();
        partial void OnPostagemIDChanging(int value);
        partial void OnSubTituloChanged();
        partial void OnSubTituloChanging(string value);
        partial void OnTituloChanged();
        partial void OnTituloChanging(string value);

        #endregion

        #region string Corpo

        private string _corpo;
        [DebuggerNonUserCode]
        [Column(Storage = "_corpo", Name = "Corpo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Corpo
        {
            get
            {
                return _corpo;
            }
            set
            {
                if (value != _corpo)
                {
                    OnCorpoChanging(value);
                    SendPropertyChanging();
                    _corpo = value;
                    SendPropertyChanged("Corpo");
                    OnCorpoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemI

        private Byte[] _imagemI;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemI", Name = "ImagemI", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemI
        {
            get
            {
                return _imagemI;
            }
            set
            {
                if (value != _imagemI)
                {
                    OnImagemIChanging(value);
                    SendPropertyChanging();
                    _imagemI = value;
                    SendPropertyChanged("ImagemI");
                    OnImagemIChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemII

        private Byte[] _imagemIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemIi", Name = "ImagemII", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemII
        {
            get
            {
                return _imagemIi;
            }
            set
            {
                if (value != _imagemIi)
                {
                    OnImagemIIChanging(value);
                    SendPropertyChanging();
                    _imagemIi = value;
                    SendPropertyChanged("ImagemII");
                    OnImagemIIChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemIII

        private Byte[] _imagemIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemIii", Name = "ImagemIII", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemIII
        {
            get
            {
                return _imagemIii;
            }
            set
            {
                if (value != _imagemIii)
                {
                    OnImagemIIIChanging(value);
                    SendPropertyChanging();
                    _imagemIii = value;
                    SendPropertyChanged("ImagemIII");
                    OnImagemIIIChanged();
                }
            }
        }

        #endregion

        #region string LegendaI

        private string _legendaI;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaI", Name = "LegendaI", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaI
        {
            get
            {
                return _legendaI;
            }
            set
            {
                if (value != _legendaI)
                {
                    OnLegendaIChanging(value);
                    SendPropertyChanging();
                    _legendaI = value;
                    SendPropertyChanged("LegendaI");
                    OnLegendaIChanged();
                }
            }
        }

        #endregion

        #region string LegendaII

        private string _legendaIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIi", Name = "LegendaII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaII
        {
            get
            {
                return _legendaIi;
            }
            set
            {
                if (value != _legendaIi)
                {
                    OnLegendaIIChanging(value);
                    SendPropertyChanging();
                    _legendaIi = value;
                    SendPropertyChanged("LegendaII");
                    OnLegendaIIChanged();
                }
            }
        }

        #endregion

        #region string LegendaIII

        private string _legendaIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIii", Name = "LegendaIII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIII
        {
            get
            {
                return _legendaIii;
            }
            set
            {
                if (value != _legendaIii)
                {
                    OnLegendaIIIChanging(value);
                    SendPropertyChanging();
                    _legendaIii = value;
                    SendPropertyChanged("LegendaIII");
                    OnLegendaIIIChanged();
                }
            }
        }

        #endregion

        #region int PostagemID

        private int _postagemID;
        [DebuggerNonUserCode]
        [Column(Storage = "_postagemID", Name = "PostagemID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PostagemID
        {
            get
            {
                return _postagemID;
            }
            set
            {
                if (value != _postagemID)
                {
                    if (_postageM.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPostagemIDChanging(value);
                    SendPropertyChanging();
                    _postagemID = value;
                    SendPropertyChanged("PostagemID");
                    OnPostagemIDChanged();
                }
            }
        }

        #endregion

        #region string SubTitulo

        private string _subTitulo;
        [DebuggerNonUserCode]
        [Column(Storage = "_subTitulo", Name = "SubTitulo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string SubTitulo
        {
            get
            {
                return _subTitulo;
            }
            set
            {
                if (value != _subTitulo)
                {
                    OnSubTituloChanging(value);
                    SendPropertyChanging();
                    _subTitulo = value;
                    SendPropertyChanged("SubTitulo");
                    OnSubTituloChanged();
                }
            }
        }

        #endregion

        #region string Titulo

        private string _titulo;
        [DebuggerNonUserCode]
        [Column(Storage = "_titulo", Name = "Titulo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                if (value != _titulo)
                {
                    OnTituloChanging(value);
                    SendPropertyChanging();
                    _titulo = value;
                    SendPropertyChanged("Titulo");
                    OnTituloChanged();
                }
            }
        }

        #endregion

        #region Parents

        private EntityRef<Postagem> _postageM;
        [Association(Storage = "_postageM", OtherKey = "ID", ThisKey = "PostagemID", Name = "fk_Imagem_Postagem", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Postagem Postagem
        {
            get
            {
                return _postageM.Entity;
            }
            set
            {
                if (value != _postageM.Entity)
                {
                    if (_postageM.Entity != null)
                    {
                        var previousPostagem = _postageM.Entity;
                        _postageM.Entity = null;
                        previousPostagem.Imagem.Remove(this);
                    }
                    _postageM.Entity = value;
                    if (value != null)
                    {
                        value.Imagem.Add(this);
                        _postagemID = value.ID;
                    }
                    else
                    {
                        _postagemID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Imagem()
        {
            _postageM = new EntityRef<Postagem>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "SiteColegioDB.postagem")]
    public partial class Postagem : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnCorpoChanged();
        partial void OnCorpoChanging(string value);
        partial void OnEmDestaqueChanged();
        partial void OnEmDestaqueChanging(sbyte? value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemIChanged();
        partial void OnImagemIChanging(Byte[] value);
        partial void OnImagemIIChanged();
        partial void OnImagemIIChanging(Byte[] value);
        partial void OnImagemIIIChanged();
        partial void OnImagemIIIChanging(Byte[] value);
        partial void OnLegendaIChanged();
        partial void OnLegendaIChanging(string value);
        partial void OnLegendaIIChanged();
        partial void OnLegendaIIChanging(string value);
        partial void OnLegendaIIIChanged();
        partial void OnLegendaIIIChanging(string value);
        partial void OnLocalChanged();
        partial void OnLocalChanging(int value);
        partial void OnPaginaChanged();
        partial void OnPaginaChanging(int value);
        partial void OnSubTituloChanged();
        partial void OnSubTituloChanging(string value);
        partial void OnTipoChanged();
        partial void OnTipoChanging(int value);
        partial void OnTituloChanged();
        partial void OnTituloChanging(string value);

        #endregion

        #region string Corpo

        private string _corpo;
        [DebuggerNonUserCode]
        [Column(Storage = "_corpo", Name = "Corpo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Corpo
        {
            get
            {
                return _corpo;
            }
            set
            {
                if (value != _corpo)
                {
                    OnCorpoChanging(value);
                    SendPropertyChanging();
                    _corpo = value;
                    SendPropertyChanged("Corpo");
                    OnCorpoChanged();
                }
            }
        }

        #endregion

        #region sbyte? EmDestaque

        private sbyte? _emDestaque;
        [DebuggerNonUserCode]
        [Column(Storage = "_emDestaque", Name = "EmDestaque", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
        public sbyte? EmDestaque
        {
            get
            {
                return _emDestaque;
            }
            set
            {
                if (value != _emDestaque)
                {
                    OnEmDestaqueChanging(value);
                    SendPropertyChanging();
                    _emDestaque = value;
                    SendPropertyChanged("EmDestaque");
                    OnEmDestaqueChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemI

        private Byte[] _imagemI;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemI", Name = "ImagemI", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemI
        {
            get
            {
                return _imagemI;
            }
            set
            {
                if (value != _imagemI)
                {
                    OnImagemIChanging(value);
                    SendPropertyChanging();
                    _imagemI = value;
                    SendPropertyChanged("ImagemI");
                    OnImagemIChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemII

        private Byte[] _imagemIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemIi", Name = "ImagemII", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemII
        {
            get
            {
                return _imagemIi;
            }
            set
            {
                if (value != _imagemIi)
                {
                    OnImagemIIChanging(value);
                    SendPropertyChanging();
                    _imagemIi = value;
                    SendPropertyChanged("ImagemII");
                    OnImagemIIChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemIII

        private Byte[] _imagemIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemIii", Name = "ImagemIII", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemIII
        {
            get
            {
                return _imagemIii;
            }
            set
            {
                if (value != _imagemIii)
                {
                    OnImagemIIIChanging(value);
                    SendPropertyChanging();
                    _imagemIii = value;
                    SendPropertyChanged("ImagemIII");
                    OnImagemIIIChanged();
                }
            }
        }

        #endregion

        #region string LegendaI

        private string _legendaI;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaI", Name = "LegendaI", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaI
        {
            get
            {
                return _legendaI;
            }
            set
            {
                if (value != _legendaI)
                {
                    OnLegendaIChanging(value);
                    SendPropertyChanging();
                    _legendaI = value;
                    SendPropertyChanged("LegendaI");
                    OnLegendaIChanged();
                }
            }
        }

        #endregion

        #region string LegendaII

        private string _legendaIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIi", Name = "LegendaII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaII
        {
            get
            {
                return _legendaIi;
            }
            set
            {
                if (value != _legendaIi)
                {
                    OnLegendaIIChanging(value);
                    SendPropertyChanging();
                    _legendaIi = value;
                    SendPropertyChanged("LegendaII");
                    OnLegendaIIChanged();
                }
            }
        }

        #endregion

        #region string LegendaIII

        private string _legendaIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIii", Name = "LegendaIII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIII
        {
            get
            {
                return _legendaIii;
            }
            set
            {
                if (value != _legendaIii)
                {
                    OnLegendaIIIChanging(value);
                    SendPropertyChanging();
                    _legendaIii = value;
                    SendPropertyChanged("LegendaIII");
                    OnLegendaIIIChanged();
                }
            }
        }

        #endregion

        #region int Local

        private int _local;
        [DebuggerNonUserCode]
        [Column(Storage = "_local", Name = "Local", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int Local
        {
            get
            {
                return _local;
            }
            set
            {
                if (value != _local)
                {
                    OnLocalChanging(value);
                    SendPropertyChanging();
                    _local = value;
                    SendPropertyChanged("Local");
                    OnLocalChanged();
                }
            }
        }

        #endregion

        #region int Pagina

        private int _pagina;
        [DebuggerNonUserCode]
        [Column(Storage = "_pagina", Name = "Pagina", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int Pagina
        {
            get
            {
                return _pagina;
            }
            set
            {
                if (value != _pagina)
                {
                    OnPaginaChanging(value);
                    SendPropertyChanging();
                    _pagina = value;
                    SendPropertyChanged("Pagina");
                    OnPaginaChanged();
                }
            }
        }

        #endregion

        #region string SubTitulo

        private string _subTitulo;
        [DebuggerNonUserCode]
        [Column(Storage = "_subTitulo", Name = "SubTitulo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string SubTitulo
        {
            get
            {
                return _subTitulo;
            }
            set
            {
                if (value != _subTitulo)
                {
                    OnSubTituloChanging(value);
                    SendPropertyChanging();
                    _subTitulo = value;
                    SendPropertyChanged("SubTitulo");
                    OnSubTituloChanged();
                }
            }
        }

        #endregion

        #region int Tipo

        private int _tipo;
        [DebuggerNonUserCode]
        [Column(Storage = "_tipo", Name = "Tipo", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                if (value != _tipo)
                {
                    OnTipoChanging(value);
                    SendPropertyChanging();
                    _tipo = value;
                    SendPropertyChanged("Tipo");
                    OnTipoChanged();
                }
            }
        }

        #endregion

        #region string Titulo

        private string _titulo;
        [DebuggerNonUserCode]
        [Column(Storage = "_titulo", Name = "Titulo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                if (value != _titulo)
                {
                    OnTituloChanging(value);
                    SendPropertyChanging();
                    _titulo = value;
                    SendPropertyChanged("Titulo");
                    OnTituloChanged();
                }
            }
        }

        #endregion

        #region Children

        private EntitySet<Imagem> _imageM;
        [Association(Storage = "_imageM", OtherKey = "PostagemID", ThisKey = "ID", Name = "fk_Imagem_Postagem")]
        [DebuggerNonUserCode]
        public EntitySet<Imagem> Imagem
        {
            get
            {
                return _imageM;
            }
            set
            {
                _imageM = value;
            }
        }


        #endregion

        #region Attachement handlers

        private void Imagem_Attach(Imagem entity)
        {
            entity.Postagem = this;
        }

        private void Imagem_Detach(Imagem entity)
        {
            entity.Postagem = null;
        }


        #endregion

        #region ctor

        public Postagem()
        {
            _imageM = new EntitySet<Imagem>(Imagem_Attach, Imagem_Detach);
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "SiteColegioDB.usuario")]
    public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnLoginChanged();
        partial void OnLoginChanging(string value);
        partial void OnSenhaChanged();
        partial void OnSenhaChanging(string value);

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region string Login

        private string _login;
        [DebuggerNonUserCode]
        [Column(Storage = "_login", Name = "Login", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value != _login)
                {
                    OnLoginChanging(value);
                    SendPropertyChanging();
                    _login = value;
                    SendPropertyChanged("Login");
                    OnLoginChanged();
                }
            }
        }

        #endregion

        #region string Senha

        private string _senha;
        [DebuggerNonUserCode]
        [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (value != _senha)
                {
                    OnSenhaChanging(value);
                    SendPropertyChanging();
                    _senha = value;
                    SendPropertyChanged("Senha");
                    OnSenhaChanged();
                }
            }
        }

        #endregion

        #region ctor

        public Usuario()
        {
            OnCreated();
        }

        #endregion

    }
}
