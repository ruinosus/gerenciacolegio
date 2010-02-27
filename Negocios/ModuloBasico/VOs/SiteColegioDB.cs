#region Auto-generated classes for SiteColegioDB database on 2010-02-27 13:26:30Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from SiteColegioDB on 2010-02-27 13:26:30Z
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

        public Table<Atividade> Atividade { get { return GetTable<Atividade>(); } }
        public Table<Evento> Evento { get { return GetTable<Evento>(); } }
        public Table<Imagem> Imagem { get { return GetTable<Imagem>(); } }
        public Table<Postagem> Postagem { get { return GetTable<Postagem>(); } }
        public Table<Usuario> Usuario { get { return GetTable<Usuario>(); } }

    }

    [Table(Name = "SiteColegioDB.atividade")]
    public partial class Atividade : INotifyPropertyChanging, INotifyPropertyChanged
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
        partial void OnImagemIiChanged();
        partial void OnImagemIiChanging(Byte[] value);
        partial void OnImagemIiiChanged();
        partial void OnImagemIiiChanging(Byte[] value);
        partial void OnLegendaIChanged();
        partial void OnLegendaIChanging(string value);
        partial void OnLegendaIiChanged();
        partial void OnLegendaIiChanging(string value);
        partial void OnLegendaIiiChanged();
        partial void OnLegendaIiiChanging(string value);
        partial void OnLocalChanged();
        partial void OnLocalChanging(int value);
        partial void OnPaginaChanged();
        partial void OnPaginaChanging(int value);
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
                    OnImagemIiChanging(value);
                    SendPropertyChanging();
                    _imagemIi = value;
                    SendPropertyChanged("ImagemII");
                    OnImagemIiChanged();
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
                    OnImagemIiiChanging(value);
                    SendPropertyChanging();
                    _imagemIii = value;
                    SendPropertyChanged("ImagemIII");
                    OnImagemIiiChanged();
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

        #region string LegendaIi

        private string _legendaIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIi", Name = "LegendaII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIi
        {
            get
            {
                return _legendaIi;
            }
            set
            {
                if (value != _legendaIi)
                {
                    OnLegendaIiChanging(value);
                    SendPropertyChanging();
                    _legendaIi = value;
                    SendPropertyChanged("LegendaIi");
                    OnLegendaIiChanged();
                }
            }
        }

        #endregion

        #region string LegendaIii

        private string _legendaIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIii", Name = "LegendaIII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIii
        {
            get
            {
                return _legendaIii;
            }
            set
            {
                if (value != _legendaIii)
                {
                    OnLegendaIiiChanging(value);
                    SendPropertyChanging();
                    _legendaIii = value;
                    SendPropertyChanged("LegendaIii");
                    OnLegendaIiiChanged();
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

        #region ctor

        public Atividade()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "SiteColegioDB.evento")]
    public partial class Evento : INotifyPropertyChanging, INotifyPropertyChanged
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
        partial void OnEmDestaqueChanging(sbyte value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemIChanged();
        partial void OnImagemIChanging(Byte[] value);
        partial void OnImagemIiChanged();
        partial void OnImagemIiChanging(Byte[] value);
        partial void OnImagemIiiChanged();
        partial void OnImagemIiiChanging(Byte[] value);
        partial void OnLegendaIChanged();
        partial void OnLegendaIChanging(string value);
        partial void OnLegendaIiChanged();
        partial void OnLegendaIiChanging(string value);
        partial void OnLegendaIiiChanged();
        partial void OnLegendaIiiChanging(string value);
        partial void OnLocalChanged();
        partial void OnLocalChanging(int value);
        partial void OnPaginaChanged();
        partial void OnPaginaChanging(int value);
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

        #region sbyte EmDestaque

        private sbyte _emDestaque;
        [DebuggerNonUserCode]
        [Column(Storage = "_emDestaque", Name = "EmDestaque", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public sbyte EmDestaque
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
                    OnImagemIiChanging(value);
                    SendPropertyChanging();
                    _imagemIi = value;
                    SendPropertyChanged("ImagemII");
                    OnImagemIiChanged();
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
                    OnImagemIiiChanging(value);
                    SendPropertyChanging();
                    _imagemIii = value;
                    SendPropertyChanged("ImagemIII");
                    OnImagemIiiChanged();
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

        #region string LegendaIi

        private string _legendaIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIi", Name = "LegendaII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIi
        {
            get
            {
                return _legendaIi;
            }
            set
            {
                if (value != _legendaIi)
                {
                    OnLegendaIiChanging(value);
                    SendPropertyChanging();
                    _legendaIi = value;
                    SendPropertyChanged("LegendaIi");
                    OnLegendaIiChanged();
                }
            }
        }

        #endregion

        #region string LegendaIii

        private string _legendaIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIii", Name = "LegendaIII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIii
        {
            get
            {
                return _legendaIii;
            }
            set
            {
                if (value != _legendaIii)
                {
                    OnLegendaIiiChanging(value);
                    SendPropertyChanging();
                    _legendaIii = value;
                    SendPropertyChanged("LegendaIii");
                    OnLegendaIiiChanged();
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
        [Association(Storage = "_imageM", OtherKey = "EventoID", ThisKey = "ID", Name = "fk_Imagem_Evento1")]
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
            entity.Evento = this;
        }

        private void Imagem_Detach(Imagem entity)
        {
            entity.Evento = null;
        }


        #endregion

        #region ctor

        public Evento()
        {
            _imageM = new EntitySet<Imagem>(Imagem_Attach, Imagem_Detach);
            OnCreated();
        }

        #endregion

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
        partial void OnEventoIDChanged();
        partial void OnEventoIDChanging(int value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemIChanged();
        partial void OnImagemIChanging(Byte[] value);
        partial void OnImagemIiChanged();
        partial void OnImagemIiChanging(Byte[] value);
        partial void OnImagemIiiChanged();
        partial void OnImagemIiiChanging(Byte[] value);
        partial void OnLegendaIChanged();
        partial void OnLegendaIChanging(string value);
        partial void OnLegendaIiChanged();
        partial void OnLegendaIiChanging(string value);
        partial void OnLegendaIiiChanged();
        partial void OnLegendaIiiChanging(string value);
        partial void OnTituloChanged();
        partial void OnTituloChanging(string value);

        #endregion

        #region int EventoID

        private int _eventoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_eventoID", Name = "EventoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int EventoID
        {
            get
            {
                return _eventoID;
            }
            set
            {
                if (value != _eventoID)
                {
                    if (_eventO.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnEventoIDChanging(value);
                    SendPropertyChanging();
                    _eventoID = value;
                    SendPropertyChanged("EventoID");
                    OnEventoIDChanged();
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
                    OnImagemIiChanging(value);
                    SendPropertyChanging();
                    _imagemIi = value;
                    SendPropertyChanged("ImagemII");
                    OnImagemIiChanged();
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
                    OnImagemIiiChanging(value);
                    SendPropertyChanging();
                    _imagemIii = value;
                    SendPropertyChanged("ImagemIII");
                    OnImagemIiiChanged();
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

        #region string LegendaIi

        private string _legendaIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIi", Name = "LegendaII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIi
        {
            get
            {
                return _legendaIi;
            }
            set
            {
                if (value != _legendaIi)
                {
                    OnLegendaIiChanging(value);
                    SendPropertyChanging();
                    _legendaIi = value;
                    SendPropertyChanged("LegendaIi");
                    OnLegendaIiChanged();
                }
            }
        }

        #endregion

        #region string LegendaIii

        private string _legendaIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIii", Name = "LegendaIII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIii
        {
            get
            {
                return _legendaIii;
            }
            set
            {
                if (value != _legendaIii)
                {
                    OnLegendaIiiChanging(value);
                    SendPropertyChanging();
                    _legendaIii = value;
                    SendPropertyChanged("LegendaIii");
                    OnLegendaIiiChanged();
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

        private EntityRef<Evento> _eventO;
        [Association(Storage = "_eventO", OtherKey = "ID", ThisKey = "EventoID", Name = "fk_Imagem_Evento1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Evento Evento
        {
            get
            {
                return _eventO.Entity;
            }
            set
            {
                if (value != _eventO.Entity)
                {
                    if (_eventO.Entity != null)
                    {
                        var previousEvento = _eventO.Entity;
                        _eventO.Entity = null;
                        previousEvento.Imagem.Remove(this);
                    }
                    _eventO.Entity = value;
                    if (value != null)
                    {
                        value.Imagem.Add(this);
                        _eventoID = value.ID;
                    }
                    else
                    {
                        _eventoID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Imagem()
        {
            _eventO = new EntityRef<Evento>();
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
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemIChanged();
        partial void OnImagemIChanging(Byte[] value);
        partial void OnImagemIiChanged();
        partial void OnImagemIiChanging(Byte[] value);
        partial void OnImagemIiiChanged();
        partial void OnImagemIiiChanging(Byte[] value);
        partial void OnLegendaIChanged();
        partial void OnLegendaIChanging(string value);
        partial void OnLegendaIiChanged();
        partial void OnLegendaIiChanging(string value);
        partial void OnLegendaIiiChanged();
        partial void OnLegendaIiiChanging(string value);
        partial void OnLocalChanged();
        partial void OnLocalChanging(int value);
        partial void OnPaginaChanged();
        partial void OnPaginaChanging(int value);
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
                    OnImagemIiChanging(value);
                    SendPropertyChanging();
                    _imagemIi = value;
                    SendPropertyChanged("ImagemII");
                    OnImagemIiChanged();
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
                    OnImagemIiiChanging(value);
                    SendPropertyChanging();
                    _imagemIii = value;
                    SendPropertyChanged("ImagemIII");
                    OnImagemIiiChanged();
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

        #region string LegendaIi

        private string _legendaIi;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIi", Name = "LegendaII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIi
        {
            get
            {
                return _legendaIi;
            }
            set
            {
                if (value != _legendaIi)
                {
                    OnLegendaIiChanging(value);
                    SendPropertyChanging();
                    _legendaIi = value;
                    SendPropertyChanged("LegendaIi");
                    OnLegendaIiChanged();
                }
            }
        }

        #endregion

        #region string LegendaIii

        private string _legendaIii;
        [DebuggerNonUserCode]
        [Column(Storage = "_legendaIii", Name = "LegendaIII", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string LegendaIii
        {
            get
            {
                return _legendaIii;
            }
            set
            {
                if (value != _legendaIii)
                {
                    OnLegendaIiiChanging(value);
                    SendPropertyChanging();
                    _legendaIii = value;
                    SendPropertyChanged("LegendaIii");
                    OnLegendaIiiChanged();
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

        #region ctor

        public Postagem()
        {
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
