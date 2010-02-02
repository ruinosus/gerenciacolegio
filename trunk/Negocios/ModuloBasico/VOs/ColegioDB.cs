#region Auto-generated classes for ColegioDB database on 2010-01-28 19:58:19Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from ColegioDB on 2010-01-28 19:58:19Z
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

public partial class ColegioDB : DataContext
{
    #region Extensibility Method Definitions

    partial void OnCreated();

    #endregion

    public ColegioDB(string connectionString)
        : base(connectionString)
    {
        OnCreated();
    }

    public ColegioDB(IDbConnection connection)
#if MONO_STRICT
		: base(connection)
#else   // MONO_STRICT
        : base(connection, new DbLinq.MySql.MySqlVendor())
#endif  // MONO_STRICT
    {
        OnCreated();
    }

    public ColegioDB(string connection, MappingSource mappingSource)
        : base(connection, mappingSource)
    {
        OnCreated();
    }

    public ColegioDB(IDbConnection connection, MappingSource mappingSource)
        : base(connection, mappingSource)
    {
        OnCreated();
    }

#if !MONO_STRICT
    public ColegioDB(IDbConnection connection, IVendor vendor)
        : base(connection, vendor)
    {
        OnCreated();
    }
#endif  // !MONO_STRICT

#if !MONO_STRICT
    public ColegioDB(IDbConnection connection, MappingSource mappingSource, IVendor vendor)
        : base(connection, mappingSource, vendor)
    {
        OnCreated();
    }
#endif  // !MONO_STRICT

    public Table<Aluno> Aluno { get { return GetTable<Aluno>(); } }
    public Table<AlunoAtividadeTurma> AlunoAtividadeTurma { get { return GetTable<AlunoAtividadeTurma>(); } }
    public Table<Atividade> Atividade { get { return GetTable<Atividade>(); } }
    public Table<AtividadeTurma> AtividadeTurma { get { return GetTable<AtividadeTurma>(); } }
    public Table<BoletoAtividade> BoletoAtividade { get { return GetTable<BoletoAtividade>(); } }
    public Table<BoletoMensalidade> BoletoMensalidade { get { return GetTable<BoletoMensalidade>(); } }
    public Table<Cheque> Cheque { get { return GetTable<Cheque>(); } }
    public Table<ChequeBoletoAtividade> ChequeBoletoAtividade { get { return GetTable<ChequeBoletoAtividade>(); } }
    public Table<ChequeBoletoMensalidade> ChequeBoletoMensalidade { get { return GetTable<ChequeBoletoMensalidade>(); } }
    public Table<ContasAPagar> ContasAPagar { get { return GetTable<ContasAPagar>(); } }
    public Table<Dependencia> Dependencia { get { return GetTable<Dependencia>(); } }
    public Table<Desconto> Desconto { get { return GetTable<Desconto>(); } }
    public Table<Disciplina> Disciplina { get { return GetTable<Disciplina>(); } }
    public Table<Funcionario> Funcionario { get { return GetTable<Funcionario>(); } }
    public Table<Matricula> Matricula { get { return GetTable<Matricula>(); } }
    public Table<MatriculaVinculo> MatriculaVinculo { get { return GetTable<MatriculaVinculo>(); } }
    public Table<Nota> Nota { get { return GetTable<Nota>(); } }
    public Table<Perfil> Perfil { get { return GetTable<Perfil>(); } }
    public Table<ProfessorDisciplinaSala> ProfessorDisciplinaSala { get { return GetTable<ProfessorDisciplinaSala>(); } }
    public Table<Responsavel> Responsavel { get { return GetTable<Responsavel>(); } }
    public Table<ResponsavelAluno> ResponsavelAluno { get { return GetTable<ResponsavelAluno>(); } }
    public Table<Sala> Sala { get { return GetTable<Sala>(); } }
    public Table<SalaPeriodo> SalaPeriodo { get { return GetTable<SalaPeriodo>(); } }
    public Table<Serie> Serie { get { return GetTable<Serie>(); } }
    public Table<Turma> Turma { get { return GetTable<Turma>(); } }
    public Table<Turno> Turno { get { return GetTable<Turno>(); } }

}

[Table(Name = "ColegioDB.aluno")]
public partial class Aluno : INotifyPropertyChanging, INotifyPropertyChanged
{

    public override string ToString()
    {
        
        return this.Nome;
    }
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
    partial void OnAlergicoChanged();
    partial void OnAlergicoChanging(string value);
    partial void OnBairroChanged();
    partial void OnBairroChanging(string value);
    partial void OnCepChanged();
    partial void OnCepChanging(string value);
    partial void OnCidadeChanged();
    partial void OnCidadeChanging(string value);
    partial void OnComplementoEnderecoChanged();
    partial void OnComplementoEnderecoChanging(string value);
    partial void OnContatoChanged();
    partial void OnContatoChanging(string value);
    partial void OnDescricaoMedicaChanged();
    partial void OnDescricaoMedicaChanging(string value);
    partial void OnEdificioChanged();
    partial void OnEdificioChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailChanging(string value);
    partial void OnFatorRhChanged();
    partial void OnFatorRhChanging(sbyte? value);
    partial void OnFoneAlunoChanged();
    partial void OnFoneAlunoChanging(string value);
    partial void OnFoneEmergenciaChanged();
    partial void OnFoneEmergenciaChanging(string value);
    partial void OnFoneMedicoChanged();
    partial void OnFoneMedicoChanging(string value);
    partial void OnFoneResidenciaChanged();
    partial void OnFoneResidenciaChanging(string value);
    partial void OnGrupoSanguineoChanged();
    partial void OnGrupoSanguineoChanging(string value);
    partial void OnHospitalChanged();
    partial void OnHospitalChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnImagemChanged();
    partial void OnImagemChanging(Byte[] value);
    partial void OnLoginChanged();
    partial void OnLoginChanging(string value);
    partial void OnLogradouroChanged();
    partial void OnLogradouroChanging(string value);
    partial void OnNacionalidadeChanged();
    partial void OnNacionalidadeChanging(string value);
    partial void OnNascimentoChanged();
    partial void OnNascimentoChanging(DateTime? value);
    partial void OnNaturalidadeChanged();
    partial void OnNaturalidadeChanging(string value);
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeMedicoChanged();
    partial void OnNomeMedicoChanging(string value);
    partial void OnPerfilIDChanged();
    partial void OnPerfilIDChanging(int? value);
    partial void OnPlanoSaudeChanged();
    partial void OnPlanoSaudeChanging(string value);
    partial void OnSenhaChanged();
    partial void OnSenhaChanging(string value);
    partial void OnSerieAtualChanged();
    partial void OnSerieAtualChanging(string value);
    partial void OnSexoChanged();
    partial void OnSexoChanging(sbyte? value);
    partial void OnSituacaoEspecialChanged();
    partial void OnSituacaoEspecialChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnUfChanged();
    partial void OnUfChanging(string value);

    #endregion

    #region string Alergico

    private string _alergico;
    [DebuggerNonUserCode]
    [Column(Storage = "_alergico", Name = "Alergico", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
    public string Alergico
    {
        get
        {
            return _alergico;
        }
        set
        {
            if (value != _alergico)
            {
                OnAlergicoChanging(value);
                SendPropertyChanging();
                _alergico = value;
                SendPropertyChanged("Alergico");
                OnAlergicoChanged();
            }
        }
    }

    #endregion

    #region string Bairro

    private string _bairro;
    [DebuggerNonUserCode]
    [Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Bairro
    {
        get
        {
            return _bairro;
        }
        set
        {
            if (value != _bairro)
            {
                OnBairroChanging(value);
                SendPropertyChanging();
                _bairro = value;
                SendPropertyChanged("Bairro");
                OnBairroChanged();
            }
        }
    }

    #endregion

    #region string Cep

    private string _cep;
    [DebuggerNonUserCode]
    [Column(Storage = "_cep", Name = "Cep", DbType = "varchar(9)", AutoSync = AutoSync.Never)]
    public string Cep
    {
        get
        {
            return _cep;
        }
        set
        {
            if (value != _cep)
            {
                OnCepChanging(value);
                SendPropertyChanging();
                _cep = value;
                SendPropertyChanged("Cep");
                OnCepChanged();
            }
        }
    }

    #endregion

    #region string Cidade

    private string _cidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_cidade", Name = "Cidade", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Cidade
    {
        get
        {
            return _cidade;
        }
        set
        {
            if (value != _cidade)
            {
                OnCidadeChanging(value);
                SendPropertyChanging();
                _cidade = value;
                SendPropertyChanged("Cidade");
                OnCidadeChanged();
            }
        }
    }

    #endregion

    #region string ComplementoEndereco

    private string _complementoEndereco;
    [DebuggerNonUserCode]
    [Column(Storage = "_complementoEndereco", Name = "ComplementoEndereco", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string ComplementoEndereco
    {
        get
        {
            return _complementoEndereco;
        }
        set
        {
            if (value != _complementoEndereco)
            {
                OnComplementoEnderecoChanging(value);
                SendPropertyChanging();
                _complementoEndereco = value;
                SendPropertyChanged("ComplementoEndereco");
                OnComplementoEnderecoChanged();
            }
        }
    }

    #endregion

    #region string Contato

    private string _contato;
    [DebuggerNonUserCode]
    [Column(Storage = "_contato", Name = "Contato", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
    public string Contato
    {
        get
        {
            return _contato;
        }
        set
        {
            if (value != _contato)
            {
                OnContatoChanging(value);
                SendPropertyChanging();
                _contato = value;
                SendPropertyChanged("Contato");
                OnContatoChanged();
            }
        }
    }

    #endregion

    #region string DescricaoMedica

    private string _descricaoMedica;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricaoMedica", Name = "DescricaoMedica", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
    public string DescricaoMedica
    {
        get
        {
            return _descricaoMedica;
        }
        set
        {
            if (value != _descricaoMedica)
            {
                OnDescricaoMedicaChanging(value);
                SendPropertyChanging();
                _descricaoMedica = value;
                SendPropertyChanged("DescricaoMedica");
                OnDescricaoMedicaChanged();
            }
        }
    }

    #endregion

    #region string Edificio

    private string _edificio;
    [DebuggerNonUserCode]
    [Column(Storage = "_edificio", Name = "Edificio", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Edificio
    {
        get
        {
            return _edificio;
        }
        set
        {
            if (value != _edificio)
            {
                OnEdificioChanging(value);
                SendPropertyChanging();
                _edificio = value;
                SendPropertyChanged("Edificio");
                OnEdificioChanged();
            }
        }
    }

    #endregion

    #region string Email

    private string _email;
    [DebuggerNonUserCode]
    [Column(Storage = "_email", Name = "Email", DbType = "varchar(40)", AutoSync = AutoSync.Never)]
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (value != _email)
            {
                OnEmailChanging(value);
                SendPropertyChanging();
                _email = value;
                SendPropertyChanged("Email");
                OnEmailChanged();
            }
        }
    }

    #endregion

    #region sbyte? FatorRh

    private sbyte? _fatorRh;
    [DebuggerNonUserCode]
    [Column(Storage = "_fatorRh", Name = "FatorRh", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? FatorRh
    {
        get
        {
            return _fatorRh;
        }
        set
        {
            if (value != _fatorRh)
            {
                OnFatorRhChanging(value);
                SendPropertyChanging();
                _fatorRh = value;
                SendPropertyChanged("FatorRh");
                OnFatorRhChanged();
            }
        }
    }

    #endregion

    #region string FoneAluno

    private string _foneAluno;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneAluno", Name = "FoneAluno", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneAluno
    {
        get
        {
            return _foneAluno;
        }
        set
        {
            if (value != _foneAluno)
            {
                OnFoneAlunoChanging(value);
                SendPropertyChanging();
                _foneAluno = value;
                SendPropertyChanged("FoneAluno");
                OnFoneAlunoChanged();
            }
        }
    }

    #endregion

    #region string FoneEmergencia

    private string _foneEmergencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneEmergencia", Name = "FoneEmergencia", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneEmergencia
    {
        get
        {
            return _foneEmergencia;
        }
        set
        {
            if (value != _foneEmergencia)
            {
                OnFoneEmergenciaChanging(value);
                SendPropertyChanging();
                _foneEmergencia = value;
                SendPropertyChanged("FoneEmergencia");
                OnFoneEmergenciaChanged();
            }
        }
    }

    #endregion

    #region string FoneMedico

    private string _foneMedico;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneMedico", Name = "FoneMedico", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneMedico
    {
        get
        {
            return _foneMedico;
        }
        set
        {
            if (value != _foneMedico)
            {
                OnFoneMedicoChanging(value);
                SendPropertyChanging();
                _foneMedico = value;
                SendPropertyChanged("FoneMedico");
                OnFoneMedicoChanged();
            }
        }
    }

    #endregion

    #region string FoneResidencia

    private string _foneResidencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneResidencia", Name = "FoneResidencia", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneResidencia
    {
        get
        {
            return _foneResidencia;
        }
        set
        {
            if (value != _foneResidencia)
            {
                OnFoneResidenciaChanging(value);
                SendPropertyChanging();
                _foneResidencia = value;
                SendPropertyChanged("FoneResidencia");
                OnFoneResidenciaChanged();
            }
        }
    }

    #endregion

    #region string GrupoSanguineo

    private string _grupoSanguineo;
    [DebuggerNonUserCode]
    [Column(Storage = "_grupoSanguineo", Name = "GrupoSanguineo", DbType = "varchar(3)", AutoSync = AutoSync.Never)]
    public string GrupoSanguineo
    {
        get
        {
            return _grupoSanguineo;
        }
        set
        {
            if (value != _grupoSanguineo)
            {
                OnGrupoSanguineoChanging(value);
                SendPropertyChanging();
                _grupoSanguineo = value;
                SendPropertyChanged("GrupoSanguineo");
                OnGrupoSanguineoChanged();
            }
        }
    }

    #endregion

    #region string Hospital

    private string _hospital;
    [DebuggerNonUserCode]
    [Column(Storage = "_hospital", Name = "Hospital", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Hospital
    {
        get
        {
            return _hospital;
        }
        set
        {
            if (value != _hospital)
            {
                OnHospitalChanging(value);
                SendPropertyChanging();
                _hospital = value;
                SendPropertyChanged("Hospital");
                OnHospitalChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region Byte[] Imagem

    private Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob", AutoSync = AutoSync.Never)]
    public Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                OnImagemChanging(value);
                SendPropertyChanging();
                _imagem = value;
                SendPropertyChanged("Imagem");
                OnImagemChanged();
            }
        }
    }

    #endregion

    #region string Login

    private string _login;
    [DebuggerNonUserCode]
    [Column(Storage = "_login", Name = "Login", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
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

    #region string Logradouro

    private string _logradouro;
    [DebuggerNonUserCode]
    [Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(60)", AutoSync = AutoSync.Never)]
    public string Logradouro
    {
        get
        {
            return _logradouro;
        }
        set
        {
            if (value != _logradouro)
            {
                OnLogradouroChanging(value);
                SendPropertyChanging();
                _logradouro = value;
                SendPropertyChanged("Logradouro");
                OnLogradouroChanged();
            }
        }
    }

    #endregion

    #region string Nacionalidade

    private string _nacionalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_nacionalidade", Name = "Nacionalidade", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Nacionalidade
    {
        get
        {
            return _nacionalidade;
        }
        set
        {
            if (value != _nacionalidade)
            {
                OnNacionalidadeChanging(value);
                SendPropertyChanging();
                _nacionalidade = value;
                SendPropertyChanged("Nacionalidade");
                OnNacionalidadeChanged();
            }
        }
    }

    #endregion

    #region DateTime? Nascimento

    private DateTime? _nascimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_nascimento", Name = "Nascimento", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? Nascimento
    {
        get
        {
            return _nascimento;
        }
        set
        {
            if (value != _nascimento)
            {
                OnNascimentoChanging(value);
                SendPropertyChanging();
                _nascimento = value;
                SendPropertyChanged("Nascimento");
                OnNascimentoChanged();
            }
        }
    }

    #endregion

    #region string Naturalidade

    private string _naturalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_naturalidade", Name = "Naturalidade", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Naturalidade
    {
        get
        {
            return _naturalidade;
        }
        set
        {
            if (value != _naturalidade)
            {
                OnNaturalidadeChanging(value);
                SendPropertyChanging();
                _naturalidade = value;
                SendPropertyChanged("Naturalidade");
                OnNaturalidadeChanged();
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region string NomeMedico

    private string _nomeMedico;
    [DebuggerNonUserCode]
    [Column(Storage = "_nomeMedico", Name = "NomeMedico", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string NomeMedico
    {
        get
        {
            return _nomeMedico;
        }
        set
        {
            if (value != _nomeMedico)
            {
                OnNomeMedicoChanging(value);
                SendPropertyChanging();
                _nomeMedico = value;
                SendPropertyChanged("NomeMedico");
                OnNomeMedicoChanged();
            }
        }
    }

    #endregion

    #region int? PerfilID

    private int? _perfilID;
    [DebuggerNonUserCode]
    [Column(Storage = "_perfilID", Name = "PerfilId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? PerfilID
    {
        get
        {
            return _perfilID;
        }
        set
        {
            if (value != _perfilID)
            {
                OnPerfilIDChanging(value);
                SendPropertyChanging();
                _perfilID = value;
                SendPropertyChanged("PerfilID");
                OnPerfilIDChanged();
            }
        }
    }

    #endregion

    #region string PlanoSaude

    private string _planoSaude;
    [DebuggerNonUserCode]
    [Column(Storage = "_planoSaude", Name = "PlanoSaude", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string PlanoSaude
    {
        get
        {
            return _planoSaude;
        }
        set
        {
            if (value != _planoSaude)
            {
                OnPlanoSaudeChanging(value);
                SendPropertyChanging();
                _planoSaude = value;
                SendPropertyChanged("PlanoSaude");
                OnPlanoSaudeChanged();
            }
        }
    }

    #endregion

    #region string Senha

    private string _senha;
    [DebuggerNonUserCode]
    [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
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

    #region string SerieAtual

    private string _serieAtual;
    [DebuggerNonUserCode]
    [Column(Storage = "_serieAtual", Name = "SerieAtual", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
    public string SerieAtual
    {
        get
        {
            return _serieAtual;
        }
        set
        {
            if (value != _serieAtual)
            {
                OnSerieAtualChanging(value);
                SendPropertyChanging();
                _serieAtual = value;
                SendPropertyChanged("SerieAtual");
                OnSerieAtualChanged();
            }
        }
    }

    #endregion

    #region sbyte? Sexo

    private sbyte? _sexo;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexo", Name = "Sexo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Sexo
    {
        get
        {
            return _sexo;
        }
        set
        {
            if (value != _sexo)
            {
                OnSexoChanging(value);
                SendPropertyChanging();
                _sexo = value;
                SendPropertyChanged("Sexo");
                OnSexoChanged();
            }
        }
    }

    #endregion

    #region string SituacaoEspecial

    private string _situacaoEspecial;
    [DebuggerNonUserCode]
    [Column(Storage = "_situacaoEspecial", Name = "SituacaoEspecial", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
    public string SituacaoEspecial
    {
        get
        {
            return _situacaoEspecial;
        }
        set
        {
            if (value != _situacaoEspecial)
            {
                OnSituacaoEspecialChanging(value);
                SendPropertyChanging();
                _situacaoEspecial = value;
                SendPropertyChanged("SituacaoEspecial");
                OnSituacaoEspecialChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region string Uf

    private string _uf;
    [DebuggerNonUserCode]
    [Column(Storage = "_uf", Name = "Uf", DbType = "varchar(2)", AutoSync = AutoSync.Never)]
    public string Uf
    {
        get
        {
            return _uf;
        }
        set
        {
            if (value != _uf)
            {
                OnUfChanging(value);
                SendPropertyChanging();
                _uf = value;
                SendPropertyChanged("Uf");
                OnUfChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<AlunoAtividadeTurma> _alUNoAtIvIdaDeTuRmA;
    [Association(Storage = "_alUNoAtIvIdaDeTuRmA", OtherKey = "AlunoID", ThisKey = "ID", Name = "fk_AlunoAtividadeTurma_Aluno")]
    [DebuggerNonUserCode]
    public EntitySet<AlunoAtividadeTurma> AlunoAtividadeTurma
    {
        get
        {
            return _alUNoAtIvIdaDeTuRmA;
        }
        set
        {
            _alUNoAtIvIdaDeTuRmA = value;
        }
    }

    private EntitySet<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "AlunoID", ThisKey = "ID", Name = "fk_Matricula_Aluno")]
    [DebuggerNonUserCode]
    public EntitySet<Matricula> Matricula
    {
        get
        {
            return _matRiCuLa;
        }
        set
        {
            _matRiCuLa = value;
        }
    }

    private EntitySet<ResponsavelAluno> _reSpOnSaveLaLuNo;
    [Association(Storage = "_reSpOnSaveLaLuNo", OtherKey = "AlunoID", ThisKey = "ID", Name = "fk_ResponsavelAluno_Aluno")]
    [DebuggerNonUserCode]
    public EntitySet<ResponsavelAluno> ResponsavelAluno
    {
        get
        {
            return _reSpOnSaveLaLuNo;
        }
        set
        {
            _reSpOnSaveLaLuNo = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Perfil> _perFiL;
    [Association(Storage = "_perFiL", OtherKey = "ID", ThisKey = "PerfilID", Name = "fk_Aluno_Perfil", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Perfil Perfil
    {
        get
        {
            return _perFiL.Entity;
        }
        set
        {
            if (value != _perFiL.Entity)
            {
                if (_perFiL.Entity != null)
                {
                    var previousPerfil = _perFiL.Entity;
                    _perFiL.Entity = null;
                    previousPerfil.Aluno.Remove(this);
                }
                _perFiL.Entity = value;
                if (value != null)
                {
                    value.Aluno.Add(this);
                    _perfilID = value.ID;
                }
                else
                {
                    _perfilID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void AlunoAtividadeTurma_Attach(AlunoAtividadeTurma entity)
    {
        entity.Aluno = this;
    }

    private void AlunoAtividadeTurma_Detach(AlunoAtividadeTurma entity)
    {
        entity.Aluno = null;
    }

    private void Matricula_Attach(Matricula entity)
    {
        entity.Aluno = this;
    }

    private void Matricula_Detach(Matricula entity)
    {
        entity.Aluno = null;
    }

    private void ResponsavelAluno_Attach(ResponsavelAluno entity)
    {
        entity.Aluno = this;
    }

    private void ResponsavelAluno_Detach(ResponsavelAluno entity)
    {
        entity.Aluno = null;
    }


    #endregion

    #region ctor

    public Aluno()
    {
        _alUNoAtIvIdaDeTuRmA = new EntitySet<AlunoAtividadeTurma>(AlunoAtividadeTurma_Attach, AlunoAtividadeTurma_Detach);
        _matRiCuLa = new EntitySet<Matricula>(Matricula_Attach, Matricula_Detach);
        _reSpOnSaveLaLuNo = new EntitySet<ResponsavelAluno>(ResponsavelAluno_Attach, ResponsavelAluno_Detach);
        _perFiL = new EntityRef<Perfil>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.alunoatividadeturma")]
public partial class AlunoAtividadeTurma : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAlunoIDChanged();
    partial void OnAlunoIDChanging(int? value);
    partial void OnAnoChanged();
    partial void OnAnoChanging(int? value);
    partial void OnAtividadeTurmaIDChanged();
    partial void OnAtividadeTurmaIDChanging(int? value);
    partial void OnDataMatriculaChanged();
    partial void OnDataMatriculaChanging(DateTime? value);
    partial void OnDescontoChanged();
    partial void OnDescontoChanging(double? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region int? AlunoID

    private int? _alunoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoID", Name = "AlunoId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? AlunoID
    {
        get
        {
            return _alunoID;
        }
        set
        {
            if (value != _alunoID)
            {
                OnAlunoIDChanging(value);
                SendPropertyChanging();
                _alunoID = value;
                SendPropertyChanged("AlunoID");
                OnAlunoIDChanged();
            }
        }
    }

    #endregion

    #region int? Ano

    private int? _ano;
    [DebuggerNonUserCode]
    [Column(Storage = "_ano", Name = "Ano", DbType = "int", AutoSync = AutoSync.Never)]
    public int? Ano
    {
        get
        {
            return _ano;
        }
        set
        {
            if (value != _ano)
            {
                OnAnoChanging(value);
                SendPropertyChanging();
                _ano = value;
                SendPropertyChanged("Ano");
                OnAnoChanged();
            }
        }
    }

    #endregion

    #region int? AtividadeTurmaID

    private int? _atividadeTurmaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_atividadeTurmaID", Name = "AtividadeTurmaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? AtividadeTurmaID
    {
        get
        {
            return _atividadeTurmaID;
        }
        set
        {
            if (value != _atividadeTurmaID)
            {
                OnAtividadeTurmaIDChanging(value);
                SendPropertyChanging();
                _atividadeTurmaID = value;
                SendPropertyChanged("AtividadeTurmaID");
                OnAtividadeTurmaIDChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataMatricula

    private DateTime? _dataMatricula;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataMatricula", Name = "DataMatricula", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataMatricula
    {
        get
        {
            return _dataMatricula;
        }
        set
        {
            if (value != _dataMatricula)
            {
                OnDataMatriculaChanging(value);
                SendPropertyChanging();
                _dataMatricula = value;
                SendPropertyChanged("DataMatricula");
                OnDataMatriculaChanged();
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Desconto
    {
        get
        {
            return _desconto;
        }
        set
        {
            if (value != _desconto)
            {
                OnDescontoChanging(value);
                SendPropertyChanging();
                _desconto = value;
                SendPropertyChanged("Desconto");
                OnDescontoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<BoletoAtividade> _boleToAtIvIDade;
    [Association(Storage = "_boleToAtIvIDade", OtherKey = "AlunoAtividadeTurmaID", ThisKey = "ID", Name = "fk_BoletoAtividade_AlunoAtividadeTurma")]
    [DebuggerNonUserCode]
    public EntitySet<BoletoAtividade> BoletoAtividade
    {
        get
        {
            return _boleToAtIvIDade;
        }
        set
        {
            _boleToAtIvIDade = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Aluno> _alUNo;
    [Association(Storage = "_alUNo", OtherKey = "ID", ThisKey = "AlunoID", Name = "fk_AlunoAtividadeTurma_Aluno", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Aluno Aluno
    {
        get
        {
            return _alUNo.Entity;
        }
        set
        {
            if (value != _alUNo.Entity)
            {
                if (_alUNo.Entity != null)
                {
                    var previousAluno = _alUNo.Entity;
                    _alUNo.Entity = null;
                    previousAluno.AlunoAtividadeTurma.Remove(this);
                }
                _alUNo.Entity = value;
                if (value != null)
                {
                    value.AlunoAtividadeTurma.Add(this);
                    _alunoID = value.ID;
                }
                else
                {
                    _alunoID = null;
                }
            }
        }
    }

    private EntityRef<AtividadeTurma> _atIvIdaDeTuRmA;
    [Association(Storage = "_atIvIdaDeTuRmA", OtherKey = "ID", ThisKey = "AtividadeTurmaID", Name = "fk_AlunoAtividadeTurma_AtividadeTurma", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public AtividadeTurma AtividadeTurma
    {
        get
        {
            return _atIvIdaDeTuRmA.Entity;
        }
        set
        {
            if (value != _atIvIdaDeTuRmA.Entity)
            {
                if (_atIvIdaDeTuRmA.Entity != null)
                {
                    var previousAtividadeTurma = _atIvIdaDeTuRmA.Entity;
                    _atIvIdaDeTuRmA.Entity = null;
                    previousAtividadeTurma.AlunoAtividadeTurma.Remove(this);
                }
                _atIvIdaDeTuRmA.Entity = value;
                if (value != null)
                {
                    value.AlunoAtividadeTurma.Add(this);
                    _atividadeTurmaID = value.ID;
                }
                else
                {
                    _atividadeTurmaID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void BoletoAtividade_Attach(BoletoAtividade entity)
    {
        entity.AlunoAtividadeTurma = this;
    }

    private void BoletoAtividade_Detach(BoletoAtividade entity)
    {
        entity.AlunoAtividadeTurma = null;
    }


    #endregion

    #region ctor

    public AlunoAtividadeTurma()
    {
        _boleToAtIvIDade = new EntitySet<BoletoAtividade>(BoletoAtividade_Attach, BoletoAtividade_Detach);
        _alUNo = new EntityRef<Aluno>();
        _atIvIdaDeTuRmA = new EntityRef<AtividadeTurma>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.atividade")]
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
    partial void OnDescricaoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnImagemChanged();
    partial void OnImagemChanging(Byte[] value);
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
    public string Descricao
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (value != _descricao)
            {
                OnDescricaoChanging(value);
                SendPropertyChanging();
                _descricao = value;
                SendPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region Byte[] Imagem

    private Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob", AutoSync = AutoSync.Never)]
    public Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                OnImagemChanging(value);
                SendPropertyChanging();
                _imagem = value;
                SendPropertyChanged("Imagem");
                OnImagemChanged();
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<AtividadeTurma> _atIvIdaDeTuRmA;
    [Association(Storage = "_atIvIdaDeTuRmA", OtherKey = "AtividadeID", ThisKey = "ID", Name = "fk_AtividadeTurma_Atividade")]
    [DebuggerNonUserCode]
    public EntitySet<AtividadeTurma> AtividadeTurma
    {
        get
        {
            return _atIvIdaDeTuRmA;
        }
        set
        {
            _atIvIdaDeTuRmA = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void AtividadeTurma_Attach(AtividadeTurma entity)
    {
        entity.Atividade = this;
    }

    private void AtividadeTurma_Detach(AtividadeTurma entity)
    {
        entity.Atividade = null;
    }


    #endregion

    #region ctor

    public Atividade()
    {
        _atIvIdaDeTuRmA = new EntitySet<AtividadeTurma>(AtividadeTurma_Attach, AtividadeTurma_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.atividadeturma")]
public partial class AtividadeTurma : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAtividadeIDChanged();
    partial void OnAtividadeIDChanging(int? value);
    partial void OnDomingoChanged();
    partial void OnDomingoChanging(sbyte? value);
    partial void OnFuncionarioIDChanged();
    partial void OnFuncionarioIDChanging(int? value);
    partial void OnHoraFimChanged();
    partial void OnHoraFimChanging(string value);
    partial void OnHoraInicioChanged();
    partial void OnHoraInicioChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnQuartaChanged();
    partial void OnQuartaChanging(sbyte? value);
    partial void OnQuintaChanged();
    partial void OnQuintaChanging(sbyte? value);
    partial void OnSabadoChanged();
    partial void OnSabadoChanging(sbyte? value);
    partial void OnSegundaChanged();
    partial void OnSegundaChanging(sbyte? value);
    partial void OnSextaChanged();
    partial void OnSextaChanging(sbyte? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnTercaChanged();
    partial void OnTercaChanging(sbyte? value);
    partial void OnTurmaChanged();
    partial void OnTurmaChanging(string value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region int? AtividadeID

    private int? _atividadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_atividadeID", Name = "AtividadeId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? AtividadeID
    {
        get
        {
            return _atividadeID;
        }
        set
        {
            if (value != _atividadeID)
            {
                OnAtividadeIDChanging(value);
                SendPropertyChanging();
                _atividadeID = value;
                SendPropertyChanged("AtividadeID");
                OnAtividadeIDChanged();
            }
        }
    }

    #endregion

    #region sbyte? Domingo

    private sbyte? _domingo;
    [DebuggerNonUserCode]
    [Column(Storage = "_domingo", Name = "Domingo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Domingo
    {
        get
        {
            return _domingo;
        }
        set
        {
            if (value != _domingo)
            {
                OnDomingoChanging(value);
                SendPropertyChanging();
                _domingo = value;
                SendPropertyChanged("Domingo");
                OnDomingoChanged();
            }
        }
    }

    #endregion

    #region int? FuncionarioID

    private int? _funcionarioID;
    [DebuggerNonUserCode]
    [Column(Storage = "_funcionarioID", Name = "FuncionarioId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? FuncionarioID
    {
        get
        {
            return _funcionarioID;
        }
        set
        {
            if (value != _funcionarioID)
            {
                OnFuncionarioIDChanging(value);
                SendPropertyChanging();
                _funcionarioID = value;
                SendPropertyChanged("FuncionarioID");
                OnFuncionarioIDChanged();
            }
        }
    }

    #endregion

    #region string HoraFim

    private string _horaFim;
    [DebuggerNonUserCode]
    [Column(Storage = "_horaFim", Name = "HoraFim", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string HoraFim
    {
        get
        {
            return _horaFim;
        }
        set
        {
            if (value != _horaFim)
            {
                OnHoraFimChanging(value);
                SendPropertyChanging();
                _horaFim = value;
                SendPropertyChanged("HoraFim");
                OnHoraFimChanged();
            }
        }
    }

    #endregion

    #region string HoraInicio

    private string _horaInicio;
    [DebuggerNonUserCode]
    [Column(Storage = "_horaInicio", Name = "HoraInicio", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string HoraInicio
    {
        get
        {
            return _horaInicio;
        }
        set
        {
            if (value != _horaInicio)
            {
                OnHoraInicioChanging(value);
                SendPropertyChanging();
                _horaInicio = value;
                SendPropertyChanged("HoraInicio");
                OnHoraInicioChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? Quarta

    private sbyte? _quarta;
    [DebuggerNonUserCode]
    [Column(Storage = "_quarta", Name = "Quarta", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Quarta
    {
        get
        {
            return _quarta;
        }
        set
        {
            if (value != _quarta)
            {
                OnQuartaChanging(value);
                SendPropertyChanging();
                _quarta = value;
                SendPropertyChanged("Quarta");
                OnQuartaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Quinta

    private sbyte? _quinta;
    [DebuggerNonUserCode]
    [Column(Storage = "_quinta", Name = "Quinta", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Quinta
    {
        get
        {
            return _quinta;
        }
        set
        {
            if (value != _quinta)
            {
                OnQuintaChanging(value);
                SendPropertyChanging();
                _quinta = value;
                SendPropertyChanged("Quinta");
                OnQuintaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Sabado

    private sbyte? _sabado;
    [DebuggerNonUserCode]
    [Column(Storage = "_sabado", Name = "Sabado", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Sabado
    {
        get
        {
            return _sabado;
        }
        set
        {
            if (value != _sabado)
            {
                OnSabadoChanging(value);
                SendPropertyChanging();
                _sabado = value;
                SendPropertyChanged("Sabado");
                OnSabadoChanged();
            }
        }
    }

    #endregion

    #region sbyte? Segunda

    private sbyte? _segunda;
    [DebuggerNonUserCode]
    [Column(Storage = "_segunda", Name = "Segunda", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Segunda
    {
        get
        {
            return _segunda;
        }
        set
        {
            if (value != _segunda)
            {
                OnSegundaChanging(value);
                SendPropertyChanging();
                _segunda = value;
                SendPropertyChanged("Segunda");
                OnSegundaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Sexta

    private sbyte? _sexta;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexta", Name = "Sexta", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Sexta
    {
        get
        {
            return _sexta;
        }
        set
        {
            if (value != _sexta)
            {
                OnSextaChanging(value);
                SendPropertyChanging();
                _sexta = value;
                SendPropertyChanged("Sexta");
                OnSextaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region sbyte? Terca

    private sbyte? _terca;
    [DebuggerNonUserCode]
    [Column(Storage = "_terca", Name = "Terca", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Terca
    {
        get
        {
            return _terca;
        }
        set
        {
            if (value != _terca)
            {
                OnTercaChanging(value);
                SendPropertyChanging();
                _terca = value;
                SendPropertyChanged("Terca");
                OnTercaChanged();
            }
        }
    }

    #endregion

    #region string Turma

    private string _turma;
    [DebuggerNonUserCode]
    [Column(Storage = "_turma", Name = "Turma", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Turma
    {
        get
        {
            return _turma;
        }
        set
        {
            if (value != _turma)
            {
                OnTurmaChanging(value);
                SendPropertyChanging();
                _turma = value;
                SendPropertyChanged("Turma");
                OnTurmaChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<AlunoAtividadeTurma> _alUNoAtIvIdaDeTuRmA;
    [Association(Storage = "_alUNoAtIvIdaDeTuRmA", OtherKey = "AtividadeTurmaID", ThisKey = "ID", Name = "fk_AlunoAtividadeTurma_AtividadeTurma")]
    [DebuggerNonUserCode]
    public EntitySet<AlunoAtividadeTurma> AlunoAtividadeTurma
    {
        get
        {
            return _alUNoAtIvIdaDeTuRmA;
        }
        set
        {
            _alUNoAtIvIdaDeTuRmA = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Atividade> _atIvIDade;
    [Association(Storage = "_atIvIDade", OtherKey = "ID", ThisKey = "AtividadeID", Name = "fk_AtividadeTurma_Atividade", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Atividade Atividade
    {
        get
        {
            return _atIvIDade.Entity;
        }
        set
        {
            if (value != _atIvIDade.Entity)
            {
                if (_atIvIDade.Entity != null)
                {
                    var previousAtividade = _atIvIDade.Entity;
                    _atIvIDade.Entity = null;
                    previousAtividade.AtividadeTurma.Remove(this);
                }
                _atIvIDade.Entity = value;
                if (value != null)
                {
                    value.AtividadeTurma.Add(this);
                    _atividadeID = value.ID;
                }
                else
                {
                    _atividadeID = null;
                }
            }
        }
    }

    private EntityRef<Funcionario> _funCiOnArIo;
    [Association(Storage = "_funCiOnArIo", OtherKey = "ID", ThisKey = "FuncionarioID", Name = "fk_AtividadeTurma_Funcionario", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Funcionario Funcionario
    {
        get
        {
            return _funCiOnArIo.Entity;
        }
        set
        {
            if (value != _funCiOnArIo.Entity)
            {
                if (_funCiOnArIo.Entity != null)
                {
                    var previousFuncionario = _funCiOnArIo.Entity;
                    _funCiOnArIo.Entity = null;
                    previousFuncionario.AtividadeTurma.Remove(this);
                }
                _funCiOnArIo.Entity = value;
                if (value != null)
                {
                    value.AtividadeTurma.Add(this);
                    _funcionarioID = value.ID;
                }
                else
                {
                    _funcionarioID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void AlunoAtividadeTurma_Attach(AlunoAtividadeTurma entity)
    {
        entity.AtividadeTurma = this;
    }

    private void AlunoAtividadeTurma_Detach(AlunoAtividadeTurma entity)
    {
        entity.AtividadeTurma = null;
    }


    #endregion

    #region ctor

    public AtividadeTurma()
    {
        _alUNoAtIvIdaDeTuRmA = new EntitySet<AlunoAtividadeTurma>(AlunoAtividadeTurma_Attach, AlunoAtividadeTurma_Detach);
        _atIvIDade = new EntityRef<Atividade>();
        _funCiOnArIo = new EntityRef<Funcionario>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.boletoatividade")]
public partial class BoletoAtividade : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAlunoAtividadeTurmaIDChanged();
    partial void OnAlunoAtividadeTurmaIDChanging(int? value);
    partial void OnDataEmissaoChanged();
    partial void OnDataEmissaoChanging(DateTime value);
    partial void OnDataPagamentoChanged();
    partial void OnDataPagamentoChanging(DateTime? value);
    partial void OnDataVencimentoChanged();
    partial void OnDataVencimentoChanging(DateTime value);
    partial void OnDescontoChanged();
    partial void OnDescontoChanging(double? value);
    partial void OnDescricaoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnMatriculaIDChanged();
    partial void OnMatriculaIDChanging(int? value);
    partial void OnMultaChanged();
    partial void OnMultaChanging(double? value);
    partial void OnParcelaChanged();
    partial void OnParcelaChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region int? AlunoAtividadeTurmaID

    private int? _alunoAtividadeTurmaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoAtividadeTurmaID", Name = "AlunoAtividadeTurmaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? AlunoAtividadeTurmaID
    {
        get
        {
            return _alunoAtividadeTurmaID;
        }
        set
        {
            if (value != _alunoAtividadeTurmaID)
            {
                OnAlunoAtividadeTurmaIDChanging(value);
                SendPropertyChanging();
                _alunoAtividadeTurmaID = value;
                SendPropertyChanged("AlunoAtividadeTurmaID");
                OnAlunoAtividadeTurmaIDChanged();
            }
        }
    }

    #endregion

    #region DateTime DataEmissao

    private DateTime _dataEmissao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataEmissao", Name = "DataEmissao", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
    public DateTime DataEmissao
    {
        get
        {
            return _dataEmissao;
        }
        set
        {
            if (value != _dataEmissao)
            {
                OnDataEmissaoChanging(value);
                SendPropertyChanging();
                _dataEmissao = value;
                SendPropertyChanged("DataEmissao");
                OnDataEmissaoChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataPagamento

    private DateTime? _dataPagamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPagamento", Name = "DataPagamento", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataPagamento
    {
        get
        {
            return _dataPagamento;
        }
        set
        {
            if (value != _dataPagamento)
            {
                OnDataPagamentoChanging(value);
                SendPropertyChanging();
                _dataPagamento = value;
                SendPropertyChanged("DataPagamento");
                OnDataPagamentoChanged();
            }
        }
    }

    #endregion

    #region DateTime DataVencimento

    private DateTime _dataVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVencimento", Name = "DataVencimento", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
    public DateTime DataVencimento
    {
        get
        {
            return _dataVencimento;
        }
        set
        {
            if (value != _dataVencimento)
            {
                OnDataVencimentoChanging(value);
                SendPropertyChanging();
                _dataVencimento = value;
                SendPropertyChanged("DataVencimento");
                OnDataVencimentoChanged();
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Desconto
    {
        get
        {
            return _desconto;
        }
        set
        {
            if (value != _desconto)
            {
                OnDescontoChanging(value);
                SendPropertyChanging();
                _desconto = value;
                SendPropertyChanged("Desconto");
                OnDescontoChanged();
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Descricao
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (value != _descricao)
            {
                OnDescricaoChanging(value);
                SendPropertyChanging();
                _descricao = value;
                SendPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int? MatriculaID

    private int? _matriculaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaID", Name = "MatriculaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? MatriculaID
    {
        get
        {
            return _matriculaID;
        }
        set
        {
            if (value != _matriculaID)
            {
                OnMatriculaIDChanging(value);
                SendPropertyChanging();
                _matriculaID = value;
                SendPropertyChanged("MatriculaID");
                OnMatriculaIDChanged();
            }
        }
    }

    #endregion

    #region double? Multa

    private double? _multa;
    [DebuggerNonUserCode]
    [Column(Storage = "_multa", Name = "Multa", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Multa
    {
        get
        {
            return _multa;
        }
        set
        {
            if (value != _multa)
            {
                OnMultaChanging(value);
                SendPropertyChanging();
                _multa = value;
                SendPropertyChanged("Multa");
                OnMultaChanged();
            }
        }
    }

    #endregion

    #region string Parcela

    private string _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Parcela
    {
        get
        {
            return _parcela;
        }
        set
        {
            if (value != _parcela)
            {
                OnParcelaChanging(value);
                SendPropertyChanging();
                _parcela = value;
                SendPropertyChanged("Parcela");
                OnParcelaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<ChequeBoletoAtividade> _chequeBoleToAtIvIDade;
    [Association(Storage = "_chequeBoleToAtIvIDade", OtherKey = "BoletoAtividadeID", ThisKey = "ID", Name = "fk_BoletoAtividade_has_Cheque_BoletoAtividade")]
    [DebuggerNonUserCode]
    public EntitySet<ChequeBoletoAtividade> ChequeBoletoAtividade
    {
        get
        {
            return _chequeBoleToAtIvIDade;
        }
        set
        {
            _chequeBoleToAtIvIDade = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<AlunoAtividadeTurma> _alUNoAtIvIdaDeTuRmA;
    [Association(Storage = "_alUNoAtIvIdaDeTuRmA", OtherKey = "ID", ThisKey = "AlunoAtividadeTurmaID", Name = "fk_BoletoAtividade_AlunoAtividadeTurma", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public AlunoAtividadeTurma AlunoAtividadeTurma
    {
        get
        {
            return _alUNoAtIvIdaDeTuRmA.Entity;
        }
        set
        {
            if (value != _alUNoAtIvIdaDeTuRmA.Entity)
            {
                if (_alUNoAtIvIdaDeTuRmA.Entity != null)
                {
                    var previousAlunoAtividadeTurma = _alUNoAtIvIdaDeTuRmA.Entity;
                    _alUNoAtIvIdaDeTuRmA.Entity = null;
                    previousAlunoAtividadeTurma.BoletoAtividade.Remove(this);
                }
                _alUNoAtIvIdaDeTuRmA.Entity = value;
                if (value != null)
                {
                    value.BoletoAtividade.Add(this);
                    _alunoAtividadeTurmaID = value.ID;
                }
                else
                {
                    _alunoAtividadeTurmaID = null;
                }
            }
        }
    }

    private EntityRef<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "ID", ThisKey = "MatriculaID", Name = "fk_BoletoAtividade_Matricula", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula Matricula
    {
        get
        {
            return _matRiCuLa.Entity;
        }
        set
        {
            if (value != _matRiCuLa.Entity)
            {
                if (_matRiCuLa.Entity != null)
                {
                    var previousMatricula = _matRiCuLa.Entity;
                    _matRiCuLa.Entity = null;
                    previousMatricula.BoletoAtividade.Remove(this);
                }
                _matRiCuLa.Entity = value;
                if (value != null)
                {
                    value.BoletoAtividade.Add(this);
                    _matriculaID = value.ID;
                }
                else
                {
                    _matriculaID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void ChequeBoletoAtividade_Attach(ChequeBoletoAtividade entity)
    {
        entity.BoletoAtividade = this;
    }

    private void ChequeBoletoAtividade_Detach(ChequeBoletoAtividade entity)
    {
        entity.BoletoAtividade = null;
    }


    #endregion

    #region ctor

    public BoletoAtividade()
    {
        _chequeBoleToAtIvIDade = new EntitySet<ChequeBoletoAtividade>(ChequeBoletoAtividade_Attach, ChequeBoletoAtividade_Detach);
        _alUNoAtIvIdaDeTuRmA = new EntityRef<AlunoAtividadeTurma>();
        _matRiCuLa = new EntityRef<Matricula>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.boletomensalidade")]
public partial class BoletoMensalidade : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnDataEmissaoChanged();
    partial void OnDataEmissaoChanging(DateTime value);
    partial void OnDataImpressaoChanged();
    partial void OnDataImpressaoChanging(DateTime? value);
    partial void OnDataPagamentoChanged();
    partial void OnDataPagamentoChanging(DateTime? value);
    partial void OnDataVencimentoChanged();
    partial void OnDataVencimentoChanging(DateTime value);
    partial void OnDescontoChanged();
    partial void OnDescontoChanging(double? value);
    partial void OnDescricaoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnJuncaoChanged();
    partial void OnJuncaoChanging(sbyte? value);
    partial void OnMatriculaIDChanged();
    partial void OnMatriculaIDChanging(int? value);
    partial void OnMultaChanged();
    partial void OnMultaChanging(double? value);
    partial void OnNumeroImpressaoChanged();
    partial void OnNumeroImpressaoChanging(int? value);
    partial void OnParcelaChanged();
    partial void OnParcelaChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region DateTime DataEmissao

    private DateTime _dataEmissao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataEmissao", Name = "DataEmissao", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
    public DateTime DataEmissao
    {
        get
        {
            return _dataEmissao;
        }
        set
        {
            if (value != _dataEmissao)
            {
                OnDataEmissaoChanging(value);
                SendPropertyChanging();
                _dataEmissao = value;
                SendPropertyChanged("DataEmissao");
                OnDataEmissaoChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataImpressao

    private DateTime? _dataImpressao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataImpressao", Name = "DataImpressao", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataImpressao
    {
        get
        {
            return _dataImpressao;
        }
        set
        {
            if (value != _dataImpressao)
            {
                OnDataImpressaoChanging(value);
                SendPropertyChanging();
                _dataImpressao = value;
                SendPropertyChanged("DataImpressao");
                OnDataImpressaoChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataPagamento

    private DateTime? _dataPagamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPagamento", Name = "DataPagamento", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataPagamento
    {
        get
        {
            return _dataPagamento;
        }
        set
        {
            if (value != _dataPagamento)
            {
                OnDataPagamentoChanging(value);
                SendPropertyChanging();
                _dataPagamento = value;
                SendPropertyChanged("DataPagamento");
                OnDataPagamentoChanged();
            }
        }
    }

    #endregion

    #region DateTime DataVencimento

    private DateTime _dataVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVencimento", Name = "DataVencimento", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
    public DateTime DataVencimento
    {
        get
        {
            return _dataVencimento;
        }
        set
        {
            if (value != _dataVencimento)
            {
                OnDataVencimentoChanging(value);
                SendPropertyChanging();
                _dataVencimento = value;
                SendPropertyChanged("DataVencimento");
                OnDataVencimentoChanged();
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Desconto
    {
        get
        {
            return _desconto;
        }
        set
        {
            if (value != _desconto)
            {
                OnDescontoChanging(value);
                SendPropertyChanging();
                _desconto = value;
                SendPropertyChanged("Desconto");
                OnDescontoChanged();
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Descricao
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (value != _descricao)
            {
                OnDescricaoChanging(value);
                SendPropertyChanging();
                _descricao = value;
                SendPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? Juncao

    private sbyte? _juncao;
    [DebuggerNonUserCode]
    [Column(Storage = "_juncao", Name = "Juncao", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Juncao
    {
        get
        {
            return _juncao;
        }
        set
        {
            if (value != _juncao)
            {
                OnJuncaoChanging(value);
                SendPropertyChanging();
                _juncao = value;
                SendPropertyChanged("Juncao");
                OnJuncaoChanged();
            }
        }
    }

    #endregion

    #region int? MatriculaID

    private int? _matriculaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaID", Name = "MatriculaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? MatriculaID
    {
        get
        {
            return _matriculaID;
        }
        set
        {
            if (value != _matriculaID)
            {
                OnMatriculaIDChanging(value);
                SendPropertyChanging();
                _matriculaID = value;
                SendPropertyChanged("MatriculaID");
                OnMatriculaIDChanged();
            }
        }
    }

    #endregion

    #region double? Multa

    private double? _multa;
    [DebuggerNonUserCode]
    [Column(Storage = "_multa", Name = "Multa", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Multa
    {
        get
        {
            return _multa;
        }
        set
        {
            if (value != _multa)
            {
                OnMultaChanging(value);
                SendPropertyChanging();
                _multa = value;
                SendPropertyChanged("Multa");
                OnMultaChanged();
            }
        }
    }

    #endregion

    #region int? NumeroImpressao

    private int? _numeroImpressao;
    [DebuggerNonUserCode]
    [Column(Storage = "_numeroImpressao", Name = "NumeroImpressao", DbType = "int", AutoSync = AutoSync.Never)]
    public int? NumeroImpressao
    {
        get
        {
            return _numeroImpressao;
        }
        set
        {
            if (value != _numeroImpressao)
            {
                OnNumeroImpressaoChanging(value);
                SendPropertyChanging();
                _numeroImpressao = value;
                SendPropertyChanged("NumeroImpressao");
                OnNumeroImpressaoChanged();
            }
        }
    }

    #endregion

    #region string Parcela

    private string _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Parcela
    {
        get
        {
            return _parcela;
        }
        set
        {
            if (value != _parcela)
            {
                OnParcelaChanging(value);
                SendPropertyChanging();
                _parcela = value;
                SendPropertyChanged("Parcela");
                OnParcelaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<ChequeBoletoMensalidade> _chequeBoleTomeNsAlIDAde;
    [Association(Storage = "_chequeBoleTomeNsAlIDAde", OtherKey = "BoletoMensalidadeID", ThisKey = "ID", Name = "fk_Cheque_has_BoletoMensalidade_BoletoMensalidade")]
    [DebuggerNonUserCode]
    public EntitySet<ChequeBoletoMensalidade> ChequeBoletoMensalidade
    {
        get
        {
            return _chequeBoleTomeNsAlIDAde;
        }
        set
        {
            _chequeBoleTomeNsAlIDAde = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "ID", ThisKey = "MatriculaID", Name = "fk_BoletoMensalidade_Matricula", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula Matricula
    {
        get
        {
            return _matRiCuLa.Entity;
        }
        set
        {
            if (value != _matRiCuLa.Entity)
            {
                if (_matRiCuLa.Entity != null)
                {
                    var previousMatricula = _matRiCuLa.Entity;
                    _matRiCuLa.Entity = null;
                    previousMatricula.BoletoMensalidade.Remove(this);
                }
                _matRiCuLa.Entity = value;
                if (value != null)
                {
                    value.BoletoMensalidade.Add(this);
                    _matriculaID = value.ID;
                }
                else
                {
                    _matriculaID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void ChequeBoletoMensalidade_Attach(ChequeBoletoMensalidade entity)
    {
        entity.BoletoMensalidade = this;
    }

    private void ChequeBoletoMensalidade_Detach(ChequeBoletoMensalidade entity)
    {
        entity.BoletoMensalidade = null;
    }


    #endregion

    #region ctor

    public BoletoMensalidade()
    {
        _chequeBoleTomeNsAlIDAde = new EntitySet<ChequeBoletoMensalidade>(ChequeBoletoMensalidade_Attach, ChequeBoletoMensalidade_Detach);
        _matRiCuLa = new EntityRef<Matricula>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.cheque")]
public partial class Cheque : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAgenciaChanged();
    partial void OnAgenciaChanging(string value);
    partial void OnBancoChanged();
    partial void OnBancoChanging(string value);
    partial void OnContaChanged();
    partial void OnContaChanging(string value);
    partial void OnCpfChanged();
    partial void OnCpfChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnNumChequeChanged();
    partial void OnNumChequeChanging(int? value);
    partial void OnParcelaChanged();
    partial void OnParcelaChanging(int? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnTipoChanged();
    partial void OnTipoChanging(int value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region string Agencia

    private string _agencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_agencia", Name = "Agencia", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string Agencia
    {
        get
        {
            return _agencia;
        }
        set
        {
            if (value != _agencia)
            {
                OnAgenciaChanging(value);
                SendPropertyChanging();
                _agencia = value;
                SendPropertyChanged("Agencia");
                OnAgenciaChanged();
            }
        }
    }

    #endregion

    #region string Banco

    private string _banco;
    [DebuggerNonUserCode]
    [Column(Storage = "_banco", Name = "Banco", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Banco
    {
        get
        {
            return _banco;
        }
        set
        {
            if (value != _banco)
            {
                OnBancoChanging(value);
                SendPropertyChanging();
                _banco = value;
                SendPropertyChanged("Banco");
                OnBancoChanged();
            }
        }
    }

    #endregion

    #region string Conta

    private string _conta;
    [DebuggerNonUserCode]
    [Column(Storage = "_conta", Name = "Conta", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Conta
    {
        get
        {
            return _conta;
        }
        set
        {
            if (value != _conta)
            {
                OnContaChanging(value);
                SendPropertyChanging();
                _conta = value;
                SendPropertyChanged("Conta");
                OnContaChanged();
            }
        }
    }

    #endregion

    #region string Cpf

    private string _cpf;
    [DebuggerNonUserCode]
    [Column(Storage = "_cpf", Name = "Cpf", DbType = "varchar(11)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Cpf
    {
        get
        {
            return _cpf;
        }
        set
        {
            if (value != _cpf)
            {
                OnCpfChanging(value);
                SendPropertyChanging();
                _cpf = value;
                SendPropertyChanged("Cpf");
                OnCpfChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int? NumCheque

    private int? _numCheque;
    [DebuggerNonUserCode]
    [Column(Storage = "_numCheque", Name = "NumCheque", DbType = "int", AutoSync = AutoSync.Never)]
    public int? NumCheque
    {
        get
        {
            return _numCheque;
        }
        set
        {
            if (value != _numCheque)
            {
                OnNumChequeChanging(value);
                SendPropertyChanging();
                _numCheque = value;
                SendPropertyChanged("NumCheque");
                OnNumChequeChanged();
            }
        }
    }

    #endregion

    #region int? Parcela

    private int? _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "int", AutoSync = AutoSync.Never)]
    public int? Parcela
    {
        get
        {
            return _parcela;
        }
        set
        {
            if (value != _parcela)
            {
                OnParcelaChanging(value);
                SendPropertyChanging();
                _parcela = value;
                SendPropertyChanged("Parcela");
                OnParcelaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
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

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<ChequeBoletoAtividade> _chequeBoleToAtIvIDade;
    [Association(Storage = "_chequeBoleToAtIvIDade", OtherKey = "ChequeID", ThisKey = "ID", Name = "fk_BoletoAtividade_has_Cheque_Cheque")]
    [DebuggerNonUserCode]
    public EntitySet<ChequeBoletoAtividade> ChequeBoletoAtividade
    {
        get
        {
            return _chequeBoleToAtIvIDade;
        }
        set
        {
            _chequeBoleToAtIvIDade = value;
        }
    }

    private EntitySet<ChequeBoletoMensalidade> _chequeBoleTomeNsAlIDAde;
    [Association(Storage = "_chequeBoleTomeNsAlIDAde", OtherKey = "ChequeID", ThisKey = "ID", Name = "fk_Cheque_has_BoletoMensalidade_Cheque")]
    [DebuggerNonUserCode]
    public EntitySet<ChequeBoletoMensalidade> ChequeBoletoMensalidade
    {
        get
        {
            return _chequeBoleTomeNsAlIDAde;
        }
        set
        {
            _chequeBoleTomeNsAlIDAde = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void ChequeBoletoAtividade_Attach(ChequeBoletoAtividade entity)
    {
        entity.Cheque = this;
    }

    private void ChequeBoletoAtividade_Detach(ChequeBoletoAtividade entity)
    {
        entity.Cheque = null;
    }

    private void ChequeBoletoMensalidade_Attach(ChequeBoletoMensalidade entity)
    {
        entity.Cheque = this;
    }

    private void ChequeBoletoMensalidade_Detach(ChequeBoletoMensalidade entity)
    {
        entity.Cheque = null;
    }


    #endregion

    #region ctor

    public Cheque()
    {
        _chequeBoleToAtIvIDade = new EntitySet<ChequeBoletoAtividade>(ChequeBoletoAtividade_Attach, ChequeBoletoAtividade_Detach);
        _chequeBoleTomeNsAlIDAde = new EntitySet<ChequeBoletoMensalidade>(ChequeBoletoMensalidade_Attach, ChequeBoletoMensalidade_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.chequeboletoatividade")]
public partial class ChequeBoletoAtividade : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnBoletoAtividadeIDChanged();
    partial void OnBoletoAtividadeIDChanging(int value);
    partial void OnChequeIDChanged();
    partial void OnChequeIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int BoletoAtividadeID

    private int _boletoAtividadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_boletoAtividadeID", Name = "BoletoAtividadeId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int BoletoAtividadeID
    {
        get
        {
            return _boletoAtividadeID;
        }
        set
        {
            if (value != _boletoAtividadeID)
            {
                OnBoletoAtividadeIDChanging(value);
                SendPropertyChanging();
                _boletoAtividadeID = value;
                SendPropertyChanged("BoletoAtividadeID");
                OnBoletoAtividadeIDChanged();
            }
        }
    }

    #endregion

    #region int ChequeID

    private int _chequeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_chequeID", Name = "ChequeId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int ChequeID
    {
        get
        {
            return _chequeID;
        }
        set
        {
            if (value != _chequeID)
            {
                OnChequeIDChanging(value);
                SendPropertyChanging();
                _chequeID = value;
                SendPropertyChanged("ChequeID");
                OnChequeIDChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Parents

    private EntityRef<BoletoAtividade> _boleToAtIvIDade;
    [Association(Storage = "_boleToAtIvIDade", OtherKey = "ID", ThisKey = "BoletoAtividadeID", Name = "fk_BoletoAtividade_has_Cheque_BoletoAtividade", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public BoletoAtividade BoletoAtividade
    {
        get
        {
            return _boleToAtIvIDade.Entity;
        }
        set
        {
            if (value != _boleToAtIvIDade.Entity)
            {
                if (_boleToAtIvIDade.Entity != null)
                {
                    var previousBoletoAtividade = _boleToAtIvIDade.Entity;
                    _boleToAtIvIDade.Entity = null;
                    previousBoletoAtividade.ChequeBoletoAtividade.Remove(this);
                }
                _boleToAtIvIDade.Entity = value;
                if (value != null)
                {
                    value.ChequeBoletoAtividade.Add(this);
                    _boletoAtividadeID = value.ID;
                }
                else
                {
                    _boletoAtividadeID = default(int);
                }
            }
        }
    }

    private EntityRef<Cheque> _cheque;
    [Association(Storage = "_cheque", OtherKey = "ID", ThisKey = "ChequeID", Name = "fk_BoletoAtividade_has_Cheque_Cheque", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Cheque Cheque
    {
        get
        {
            return _cheque.Entity;
        }
        set
        {
            if (value != _cheque.Entity)
            {
                if (_cheque.Entity != null)
                {
                    var previousCheque = _cheque.Entity;
                    _cheque.Entity = null;
                    previousCheque.ChequeBoletoAtividade.Remove(this);
                }
                _cheque.Entity = value;
                if (value != null)
                {
                    value.ChequeBoletoAtividade.Add(this);
                    _chequeID = value.ID;
                }
                else
                {
                    _chequeID = default(int);
                }
            }
        }
    }


    #endregion

    #region ctor

    public ChequeBoletoAtividade()
    {
        _boleToAtIvIDade = new EntityRef<BoletoAtividade>();
        _cheque = new EntityRef<Cheque>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.chequeboletomensalidade")]
public partial class ChequeBoletoMensalidade : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnBoletoMensalidadeIDChanged();
    partial void OnBoletoMensalidadeIDChanging(int value);
    partial void OnChequeIDChanged();
    partial void OnChequeIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int BoletoMensalidadeID

    private int _boletoMensalidadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_boletoMensalidadeID", Name = "BoletoMensalidadeId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int BoletoMensalidadeID
    {
        get
        {
            return _boletoMensalidadeID;
        }
        set
        {
            if (value != _boletoMensalidadeID)
            {
                OnBoletoMensalidadeIDChanging(value);
                SendPropertyChanging();
                _boletoMensalidadeID = value;
                SendPropertyChanged("BoletoMensalidadeID");
                OnBoletoMensalidadeIDChanged();
            }
        }
    }

    #endregion

    #region int ChequeID

    private int _chequeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_chequeID", Name = "ChequeId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int ChequeID
    {
        get
        {
            return _chequeID;
        }
        set
        {
            if (value != _chequeID)
            {
                OnChequeIDChanging(value);
                SendPropertyChanging();
                _chequeID = value;
                SendPropertyChanged("ChequeID");
                OnChequeIDChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Parents

    private EntityRef<BoletoMensalidade> _boleTomeNsAlIDAde;
    [Association(Storage = "_boleTomeNsAlIDAde", OtherKey = "ID", ThisKey = "BoletoMensalidadeID", Name = "fk_Cheque_has_BoletoMensalidade_BoletoMensalidade", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public BoletoMensalidade BoletoMensalidade
    {
        get
        {
            return _boleTomeNsAlIDAde.Entity;
        }
        set
        {
            if (value != _boleTomeNsAlIDAde.Entity)
            {
                if (_boleTomeNsAlIDAde.Entity != null)
                {
                    var previousBoletoMensalidade = _boleTomeNsAlIDAde.Entity;
                    _boleTomeNsAlIDAde.Entity = null;
                    previousBoletoMensalidade.ChequeBoletoMensalidade.Remove(this);
                }
                _boleTomeNsAlIDAde.Entity = value;
                if (value != null)
                {
                    value.ChequeBoletoMensalidade.Add(this);
                    _boletoMensalidadeID = value.ID;
                }
                else
                {
                    _boletoMensalidadeID = default(int);
                }
            }
        }
    }

    private EntityRef<Cheque> _cheque;
    [Association(Storage = "_cheque", OtherKey = "ID", ThisKey = "ChequeID", Name = "fk_Cheque_has_BoletoMensalidade_Cheque", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Cheque Cheque
    {
        get
        {
            return _cheque.Entity;
        }
        set
        {
            if (value != _cheque.Entity)
            {
                if (_cheque.Entity != null)
                {
                    var previousCheque = _cheque.Entity;
                    _cheque.Entity = null;
                    previousCheque.ChequeBoletoMensalidade.Remove(this);
                }
                _cheque.Entity = value;
                if (value != null)
                {
                    value.ChequeBoletoMensalidade.Add(this);
                    _chequeID = value.ID;
                }
                else
                {
                    _chequeID = default(int);
                }
            }
        }
    }


    #endregion

    #region ctor

    public ChequeBoletoMensalidade()
    {
        _boleTomeNsAlIDAde = new EntityRef<BoletoMensalidade>();
        _cheque = new EntityRef<Cheque>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.contasapagar")]
public partial class ContasAPagar : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnDataPagamentoChanged();
    partial void OnDataPagamentoChanging(DateTime? value);
    partial void OnDataVencimentoChanged();
    partial void OnDataVencimentoChanging(DateTime value);
    partial void OnDescontoChanged();
    partial void OnDescontoChanging(double? value);
    partial void OnDescricaoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnMultaChanged();
    partial void OnMultaChanging(double? value);
    partial void OnParcelaChanged();
    partial void OnParcelaChanging(int? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region DateTime? DataPagamento

    private DateTime? _dataPagamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPagamento", Name = "DataPagamento", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataPagamento
    {
        get
        {
            return _dataPagamento;
        }
        set
        {
            if (value != _dataPagamento)
            {
                OnDataPagamentoChanging(value);
                SendPropertyChanging();
                _dataPagamento = value;
                SendPropertyChanged("DataPagamento");
                OnDataPagamentoChanged();
            }
        }
    }

    #endregion

    #region DateTime DataVencimento

    private DateTime _dataVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVencimento", Name = "DataVencimento", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
    public DateTime DataVencimento
    {
        get
        {
            return _dataVencimento;
        }
        set
        {
            if (value != _dataVencimento)
            {
                OnDataVencimentoChanging(value);
                SendPropertyChanging();
                _dataVencimento = value;
                SendPropertyChanged("DataVencimento");
                OnDataVencimentoChanged();
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Desconto
    {
        get
        {
            return _desconto;
        }
        set
        {
            if (value != _desconto)
            {
                OnDescontoChanging(value);
                SendPropertyChanging();
                _desconto = value;
                SendPropertyChanged("Desconto");
                OnDescontoChanged();
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Descricao
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (value != _descricao)
            {
                OnDescricaoChanging(value);
                SendPropertyChanging();
                _descricao = value;
                SendPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region double? Multa

    private double? _multa;
    [DebuggerNonUserCode]
    [Column(Storage = "_multa", Name = "Multa", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Multa
    {
        get
        {
            return _multa;
        }
        set
        {
            if (value != _multa)
            {
                OnMultaChanging(value);
                SendPropertyChanging();
                _multa = value;
                SendPropertyChanged("Multa");
                OnMultaChanged();
            }
        }
    }

    #endregion

    #region int? Parcela

    private int? _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "int", AutoSync = AutoSync.Never)]
    public int? Parcela
    {
        get
        {
            return _parcela;
        }
        set
        {
            if (value != _parcela)
            {
                OnParcelaChanging(value);
                SendPropertyChanging();
                _parcela = value;
                SendPropertyChanged("Parcela");
                OnParcelaChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region ctor

    public ContasAPagar()
    {
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.dependencia")]
public partial class Dependencia : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAprovadoChanged();
    partial void OnAprovadoChanging(sbyte? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnProfessorDisciplinaSalaIDChanged();
    partial void OnProfessorDisciplinaSalaIDChanging(int? value);
    partial void OnRecChanged();
    partial void OnRecChanging(double? value);
    partial void OnRecFinalChanged();
    partial void OnRecFinalChanging(double? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnVc1Changed();
    partial void OnVc1Changing(double value);
    partial void OnVc2Changed();
    partial void OnVc2Changing(double value);
    partial void OnVpChanged();
    partial void OnVpChanging(double? value);

    #endregion

    #region sbyte? Aprovado

    private sbyte? _aprovado;
    [DebuggerNonUserCode]
    [Column(Storage = "_aprovado", Name = "Aprovado", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Aprovado
    {
        get
        {
            return _aprovado;
        }
        set
        {
            if (value != _aprovado)
            {
                OnAprovadoChanging(value);
                SendPropertyChanging();
                _aprovado = value;
                SendPropertyChanged("Aprovado");
                OnAprovadoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int? ProfessorDisciplinaSalaID

    private int? _professorDisciplinaSalaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_professorDisciplinaSalaID", Name = "ProfessorDisciplinaSalaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? ProfessorDisciplinaSalaID
    {
        get
        {
            return _professorDisciplinaSalaID;
        }
        set
        {
            if (value != _professorDisciplinaSalaID)
            {
                OnProfessorDisciplinaSalaIDChanging(value);
                SendPropertyChanging();
                _professorDisciplinaSalaID = value;
                SendPropertyChanged("ProfessorDisciplinaSalaID");
                OnProfessorDisciplinaSalaIDChanged();
            }
        }
    }

    #endregion

    #region double? Rec

    private double? _rec;
    [DebuggerNonUserCode]
    [Column(Storage = "_rec", Name = "Rec", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Rec
    {
        get
        {
            return _rec;
        }
        set
        {
            if (value != _rec)
            {
                OnRecChanging(value);
                SendPropertyChanging();
                _rec = value;
                SendPropertyChanged("Rec");
                OnRecChanged();
            }
        }
    }

    #endregion

    #region double? RecFinal

    private double? _recFinal;
    [DebuggerNonUserCode]
    [Column(Storage = "_recFinal", Name = "RecFinal", DbType = "double", AutoSync = AutoSync.Never)]
    public double? RecFinal
    {
        get
        {
            return _recFinal;
        }
        set
        {
            if (value != _recFinal)
            {
                OnRecFinalChanging(value);
                SendPropertyChanging();
                _recFinal = value;
                SendPropertyChanged("RecFinal");
                OnRecFinalChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double Vc1

    private double _vc1;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc1", Name = "Vc1", DbType = "double", AutoSync = AutoSync.Never, CanBeNull = false)]
    public double Vc1
    {
        get
        {
            return _vc1;
        }
        set
        {
            if (value != _vc1)
            {
                OnVc1Changing(value);
                SendPropertyChanging();
                _vc1 = value;
                SendPropertyChanged("Vc1");
                OnVc1Changed();
            }
        }
    }

    #endregion

    #region double Vc2

    private double _vc2;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc2", Name = "Vc2", DbType = "double", AutoSync = AutoSync.Never, CanBeNull = false)]
    public double Vc2
    {
        get
        {
            return _vc2;
        }
        set
        {
            if (value != _vc2)
            {
                OnVc2Changing(value);
                SendPropertyChanging();
                _vc2 = value;
                SendPropertyChanged("Vc2");
                OnVc2Changed();
            }
        }
    }

    #endregion

    #region double? Vp

    private double? _vp;
    [DebuggerNonUserCode]
    [Column(Storage = "_vp", Name = "Vp", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Vp
    {
        get
        {
            return _vp;
        }
        set
        {
            if (value != _vp)
            {
                OnVpChanging(value);
                SendPropertyChanging();
                _vp = value;
                SendPropertyChanged("Vp");
                OnVpChanged();
            }
        }
    }

    #endregion

    #region Parents

    private EntityRef<ProfessorDisciplinaSala> _professorDiscIpliNAsAla;
    [Association(Storage = "_professorDiscIpliNAsAla", OtherKey = "ID", ThisKey = "ProfessorDisciplinaSalaID", Name = "fk_Dependencia_ProfessorDisciplinaSala", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public ProfessorDisciplinaSala ProfessorDisciplinaSala
    {
        get
        {
            return _professorDiscIpliNAsAla.Entity;
        }
        set
        {
            if (value != _professorDiscIpliNAsAla.Entity)
            {
                if (_professorDiscIpliNAsAla.Entity != null)
                {
                    var previousProfessorDisciplinaSala = _professorDiscIpliNAsAla.Entity;
                    _professorDiscIpliNAsAla.Entity = null;
                    previousProfessorDisciplinaSala.Dependencia.Remove(this);
                }
                _professorDiscIpliNAsAla.Entity = value;
                if (value != null)
                {
                    value.Dependencia.Add(this);
                    _professorDisciplinaSalaID = value.ID;
                }
                else
                {
                    _professorDisciplinaSalaID = null;
                }
            }
        }
    }


    #endregion

    #region ctor

    public Dependencia()
    {
        _professorDiscIpliNAsAla = new EntityRef<ProfessorDisciplinaSala>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.desconto")]
public partial class Desconto : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnDescricaoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnPercentualChanged();
    partial void OnPercentualChanging(double value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Descricao
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (value != _descricao)
            {
                OnDescricaoChanging(value);
                SendPropertyChanging();
                _descricao = value;
                SendPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region double Percentual

    private double _percentual;
    [DebuggerNonUserCode]
    [Column(Storage = "_percentual", Name = "Percentual", DbType = "double", AutoSync = AutoSync.Never, CanBeNull = false)]
    public double Percentual
    {
        get
        {
            return _percentual;
        }
        set
        {
            if (value != _percentual)
            {
                OnPercentualChanging(value);
                SendPropertyChanging();
                _percentual = value;
                SendPropertyChanged("Percentual");
                OnPercentualChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "DescontoID", ThisKey = "ID", Name = "fk_Matricula_Desconto")]
    [DebuggerNonUserCode]
    public EntitySet<Matricula> Matricula
    {
        get
        {
            return _matRiCuLa;
        }
        set
        {
            _matRiCuLa = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void Matricula_Attach(Matricula entity)
    {
        entity.Desconto = this;
    }

    private void Matricula_Detach(Matricula entity)
    {
        entity.Desconto = null;
    }


    #endregion

    #region ctor

    public Desconto()
    {
        _matRiCuLa = new EntitySet<Matricula>(Matricula_Attach, Matricula_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.disciplina")]
public partial class Disciplina : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnTipoAvaliacaoChanged();
    partial void OnTipoAvaliacaoChanging(sbyte? value);

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region sbyte? TipoAvaliacao

    private sbyte? _tipoAvaliacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_tipoAvaliacao", Name = "TipoAvaliacao", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? TipoAvaliacao
    {
        get
        {
            return _tipoAvaliacao;
        }
        set
        {
            if (value != _tipoAvaliacao)
            {
                OnTipoAvaliacaoChanging(value);
                SendPropertyChanging();
                _tipoAvaliacao = value;
                SendPropertyChanged("TipoAvaliacao");
                OnTipoAvaliacaoChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<ProfessorDisciplinaSala> _professorDiscIpliNAsAla;
    [Association(Storage = "_professorDiscIpliNAsAla", OtherKey = "DisciplinaID", ThisKey = "ID", Name = "fk_ProfessorDisciplinaSala_Disciplina")]
    [DebuggerNonUserCode]
    public EntitySet<ProfessorDisciplinaSala> ProfessorDisciplinaSala
    {
        get
        {
            return _professorDiscIpliNAsAla;
        }
        set
        {
            _professorDiscIpliNAsAla = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void ProfessorDisciplinaSala_Attach(ProfessorDisciplinaSala entity)
    {
        entity.Disciplina = this;
    }

    private void ProfessorDisciplinaSala_Detach(ProfessorDisciplinaSala entity)
    {
        entity.Disciplina = null;
    }


    #endregion

    #region ctor

    public Disciplina()
    {
        _professorDiscIpliNAsAla = new EntitySet<ProfessorDisciplinaSala>(ProfessorDisciplinaSala_Attach, ProfessorDisciplinaSala_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.funcionario")]
public partial class Funcionario : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAlergicoChanged();
    partial void OnAlergicoChanging(string value);
    partial void OnBairroChanged();
    partial void OnBairroChanging(string value);
    partial void OnCargoChanged();
    partial void OnCargoChanging(string value);
    partial void OnCboChanged();
    partial void OnCboChanging(string value);
    partial void OnCepChanged();
    partial void OnCepChanging(string value);
    partial void OnCidadeChanged();
    partial void OnCidadeChanging(string value);
    partial void OnComplementoEnderecoChanged();
    partial void OnComplementoEnderecoChanging(string value);
    partial void OnContatoEmergenciaChanged();
    partial void OnContatoEmergenciaChanging(string value);
    partial void OnCorChanged();
    partial void OnCorChanging(string value);
    partial void OnCpfChanged();
    partial void OnCpfChanging(string value);
    partial void OnCtpsChanged();
    partial void OnCtpsChanging(string value);
    partial void OnCursoChanged();
    partial void OnCursoChanging(string value);
    partial void OnDataEfetivacaoChanged();
    partial void OnDataEfetivacaoChanging(DateTime? value);
    partial void OnDataFormacaoChanged();
    partial void OnDataFormacaoChanging(DateTime? value);
    partial void OnEdificioChanged();
    partial void OnEdificioChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailChanging(string value);
    partial void OnEstadoCivilChanged();
    partial void OnEstadoCivilChanging(string value);
    partial void OnFiliacaoMaeChanged();
    partial void OnFiliacaoMaeChanging(string value);
    partial void OnFiliacaoPaiChanged();
    partial void OnFiliacaoPaiChanging(string value);
    partial void OnFoneChanged();
    partial void OnFoneChanging(string value);
    partial void OnFoneEmergenciaChanged();
    partial void OnFoneEmergenciaChanging(string value);
    partial void OnFoneOpcionalChanged();
    partial void OnFoneOpcionalChanging(string value);
    partial void OnGrauInstrucaoChanged();
    partial void OnGrauInstrucaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnImagemChanged();
    partial void OnImagemChanging(Byte[] value);
    partial void OnInstituicaoChanged();
    partial void OnInstituicaoChanging(string value);
    partial void OnLoginChanged();
    partial void OnLoginChanging(string value);
    partial void OnLogradouroChanged();
    partial void OnLogradouroChanging(string value);
    partial void OnNacionalidadeChanged();
    partial void OnNacionalidadeChanging(string value);
    partial void OnNascimentoChanged();
    partial void OnNascimentoChanging(DateTime? value);
    partial void OnNaturalidadeChanged();
    partial void OnNaturalidadeChanging(string value);
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnPerfilIDChanged();
    partial void OnPerfilIDChanging(int? value);
    partial void OnPisChanged();
    partial void OnPisChanging(string value);
    partial void OnPrimeiroEmpregoChanged();
    partial void OnPrimeiroEmpregoChanging(sbyte? value);
    partial void OnRgChanged();
    partial void OnRgChanging(string value);
    partial void OnSenhaChanged();
    partial void OnSenhaChanging(string value);
    partial void OnSerieChanged();
    partial void OnSerieChanging(string value);
    partial void OnSexoChanged();
    partial void OnSexoChanging(sbyte? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnTituloEleitorChanged();
    partial void OnTituloEleitorChanging(string value);
    partial void OnUfChanged();
    partial void OnUfChanging(string value);
    partial void OnZonaChanged();
    partial void OnZonaChanging(string value);

    #endregion

    #region string Alergico

    private string _alergico;
    [DebuggerNonUserCode]
    [Column(Storage = "_alergico", Name = "Alergico", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
    public string Alergico
    {
        get
        {
            return _alergico;
        }
        set
        {
            if (value != _alergico)
            {
                OnAlergicoChanging(value);
                SendPropertyChanging();
                _alergico = value;
                SendPropertyChanged("Alergico");
                OnAlergicoChanged();
            }
        }
    }

    #endregion

    #region string Bairro

    private string _bairro;
    [DebuggerNonUserCode]
    [Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Bairro
    {
        get
        {
            return _bairro;
        }
        set
        {
            if (value != _bairro)
            {
                OnBairroChanging(value);
                SendPropertyChanging();
                _bairro = value;
                SendPropertyChanged("Bairro");
                OnBairroChanged();
            }
        }
    }

    #endregion

    #region string Cargo

    private string _cargo;
    [DebuggerNonUserCode]
    [Column(Storage = "_cargo", Name = "Cargo", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
    public string Cargo
    {
        get
        {
            return _cargo;
        }
        set
        {
            if (value != _cargo)
            {
                OnCargoChanging(value);
                SendPropertyChanging();
                _cargo = value;
                SendPropertyChanged("Cargo");
                OnCargoChanged();
            }
        }
    }

    #endregion

    #region string Cbo

    private string _cbo;
    [DebuggerNonUserCode]
    [Column(Storage = "_cbo", Name = "Cbo", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
    public string Cbo
    {
        get
        {
            return _cbo;
        }
        set
        {
            if (value != _cbo)
            {
                OnCboChanging(value);
                SendPropertyChanging();
                _cbo = value;
                SendPropertyChanged("Cbo");
                OnCboChanged();
            }
        }
    }

    #endregion

    #region string Cep

    private string _cep;
    [DebuggerNonUserCode]
    [Column(Storage = "_cep", Name = "Cep", DbType = "varchar(9)", AutoSync = AutoSync.Never)]
    public string Cep
    {
        get
        {
            return _cep;
        }
        set
        {
            if (value != _cep)
            {
                OnCepChanging(value);
                SendPropertyChanging();
                _cep = value;
                SendPropertyChanged("Cep");
                OnCepChanged();
            }
        }
    }

    #endregion

    #region string Cidade

    private string _cidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_cidade", Name = "Cidade", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Cidade
    {
        get
        {
            return _cidade;
        }
        set
        {
            if (value != _cidade)
            {
                OnCidadeChanging(value);
                SendPropertyChanging();
                _cidade = value;
                SendPropertyChanged("Cidade");
                OnCidadeChanged();
            }
        }
    }

    #endregion

    #region string ComplementoEndereco

    private string _complementoEndereco;
    [DebuggerNonUserCode]
    [Column(Storage = "_complementoEndereco", Name = "ComplementoEndereco", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string ComplementoEndereco
    {
        get
        {
            return _complementoEndereco;
        }
        set
        {
            if (value != _complementoEndereco)
            {
                OnComplementoEnderecoChanging(value);
                SendPropertyChanging();
                _complementoEndereco = value;
                SendPropertyChanged("ComplementoEndereco");
                OnComplementoEnderecoChanged();
            }
        }
    }

    #endregion

    #region string ContatoEmergencia

    private string _contatoEmergencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_contatoEmergencia", Name = "ContatoEmergencia", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string ContatoEmergencia
    {
        get
        {
            return _contatoEmergencia;
        }
        set
        {
            if (value != _contatoEmergencia)
            {
                OnContatoEmergenciaChanging(value);
                SendPropertyChanging();
                _contatoEmergencia = value;
                SendPropertyChanged("ContatoEmergencia");
                OnContatoEmergenciaChanged();
            }
        }
    }

    #endregion

    #region string Cor

    private string _cor;
    [DebuggerNonUserCode]
    [Column(Storage = "_cor", Name = "Cor", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
    public string Cor
    {
        get
        {
            return _cor;
        }
        set
        {
            if (value != _cor)
            {
                OnCorChanging(value);
                SendPropertyChanging();
                _cor = value;
                SendPropertyChanged("Cor");
                OnCorChanged();
            }
        }
    }

    #endregion

    #region string Cpf

    private string _cpf;
    [DebuggerNonUserCode]
    [Column(Storage = "_cpf", Name = "Cpf", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string Cpf
    {
        get
        {
            return _cpf;
        }
        set
        {
            if (value != _cpf)
            {
                OnCpfChanging(value);
                SendPropertyChanging();
                _cpf = value;
                SendPropertyChanged("Cpf");
                OnCpfChanged();
            }
        }
    }

    #endregion

    #region string Ctps

    private string _ctps;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctps", Name = "Ctps", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Ctps
    {
        get
        {
            return _ctps;
        }
        set
        {
            if (value != _ctps)
            {
                OnCtpsChanging(value);
                SendPropertyChanging();
                _ctps = value;
                SendPropertyChanged("Ctps");
                OnCtpsChanged();
            }
        }
    }

    #endregion

    #region string Curso

    private string _curso;
    [DebuggerNonUserCode]
    [Column(Storage = "_curso", Name = "Curso", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Curso
    {
        get
        {
            return _curso;
        }
        set
        {
            if (value != _curso)
            {
                OnCursoChanging(value);
                SendPropertyChanging();
                _curso = value;
                SendPropertyChanged("Curso");
                OnCursoChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataEfetivacao

    private DateTime? _dataEfetivacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataEfetivacao", Name = "DataEfetivacao", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataEfetivacao
    {
        get
        {
            return _dataEfetivacao;
        }
        set
        {
            if (value != _dataEfetivacao)
            {
                OnDataEfetivacaoChanging(value);
                SendPropertyChanging();
                _dataEfetivacao = value;
                SendPropertyChanged("DataEfetivacao");
                OnDataEfetivacaoChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataFormacao

    private DateTime? _dataFormacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataFormacao", Name = "DataFormacao", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataFormacao
    {
        get
        {
            return _dataFormacao;
        }
        set
        {
            if (value != _dataFormacao)
            {
                OnDataFormacaoChanging(value);
                SendPropertyChanging();
                _dataFormacao = value;
                SendPropertyChanged("DataFormacao");
                OnDataFormacaoChanged();
            }
        }
    }

    #endregion

    #region string Edificio

    private string _edificio;
    [DebuggerNonUserCode]
    [Column(Storage = "_edificio", Name = "Edificio", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Edificio
    {
        get
        {
            return _edificio;
        }
        set
        {
            if (value != _edificio)
            {
                OnEdificioChanging(value);
                SendPropertyChanging();
                _edificio = value;
                SendPropertyChanged("Edificio");
                OnEdificioChanged();
            }
        }
    }

    #endregion

    #region string Email

    private string _email;
    [DebuggerNonUserCode]
    [Column(Storage = "_email", Name = "Email", DbType = "varchar(40)", AutoSync = AutoSync.Never)]
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (value != _email)
            {
                OnEmailChanging(value);
                SendPropertyChanging();
                _email = value;
                SendPropertyChanged("Email");
                OnEmailChanged();
            }
        }
    }

    #endregion

    #region string EstadoCivil

    private string _estadoCivil;
    [DebuggerNonUserCode]
    [Column(Storage = "_estadoCivil", Name = "EstadoCivil", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string EstadoCivil
    {
        get
        {
            return _estadoCivil;
        }
        set
        {
            if (value != _estadoCivil)
            {
                OnEstadoCivilChanging(value);
                SendPropertyChanging();
                _estadoCivil = value;
                SendPropertyChanged("EstadoCivil");
                OnEstadoCivilChanged();
            }
        }
    }

    #endregion

    #region string FiliacaoMae

    private string _filiacaoMae;
    [DebuggerNonUserCode]
    [Column(Storage = "_filiacaoMae", Name = "FiliacaoMae", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string FiliacaoMae
    {
        get
        {
            return _filiacaoMae;
        }
        set
        {
            if (value != _filiacaoMae)
            {
                OnFiliacaoMaeChanging(value);
                SendPropertyChanging();
                _filiacaoMae = value;
                SendPropertyChanged("FiliacaoMae");
                OnFiliacaoMaeChanged();
            }
        }
    }

    #endregion

    #region string FiliacaoPai

    private string _filiacaoPai;
    [DebuggerNonUserCode]
    [Column(Storage = "_filiacaoPai", Name = "FiliacaoPai", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string FiliacaoPai
    {
        get
        {
            return _filiacaoPai;
        }
        set
        {
            if (value != _filiacaoPai)
            {
                OnFiliacaoPaiChanging(value);
                SendPropertyChanging();
                _filiacaoPai = value;
                SendPropertyChanged("FiliacaoPai");
                OnFiliacaoPaiChanged();
            }
        }
    }

    #endregion

    #region string Fone

    private string _fone;
    [DebuggerNonUserCode]
    [Column(Storage = "_fone", Name = "Fone", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string Fone
    {
        get
        {
            return _fone;
        }
        set
        {
            if (value != _fone)
            {
                OnFoneChanging(value);
                SendPropertyChanging();
                _fone = value;
                SendPropertyChanged("Fone");
                OnFoneChanged();
            }
        }
    }

    #endregion

    #region string FoneEmergencia

    private string _foneEmergencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneEmergencia", Name = "FoneEmergencia", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneEmergencia
    {
        get
        {
            return _foneEmergencia;
        }
        set
        {
            if (value != _foneEmergencia)
            {
                OnFoneEmergenciaChanging(value);
                SendPropertyChanging();
                _foneEmergencia = value;
                SendPropertyChanged("FoneEmergencia");
                OnFoneEmergenciaChanged();
            }
        }
    }

    #endregion

    #region string FoneOpcional

    private string _foneOpcional;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneOpcional", Name = "FoneOpcional", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneOpcional
    {
        get
        {
            return _foneOpcional;
        }
        set
        {
            if (value != _foneOpcional)
            {
                OnFoneOpcionalChanging(value);
                SendPropertyChanging();
                _foneOpcional = value;
                SendPropertyChanged("FoneOpcional");
                OnFoneOpcionalChanged();
            }
        }
    }

    #endregion

    #region string GrauInstrucao

    private string _grauInstrucao;
    [DebuggerNonUserCode]
    [Column(Storage = "_grauInstrucao", Name = "GrauInstrucao", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string GrauInstrucao
    {
        get
        {
            return _grauInstrucao;
        }
        set
        {
            if (value != _grauInstrucao)
            {
                OnGrauInstrucaoChanging(value);
                SendPropertyChanging();
                _grauInstrucao = value;
                SendPropertyChanged("GrauInstrucao");
                OnGrauInstrucaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region Byte[] Imagem

    private Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob", AutoSync = AutoSync.Never)]
    public Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                OnImagemChanging(value);
                SendPropertyChanging();
                _imagem = value;
                SendPropertyChanged("Imagem");
                OnImagemChanged();
            }
        }
    }

    #endregion

    #region string Instituicao

    private string _instituicao;
    [DebuggerNonUserCode]
    [Column(Storage = "_instituicao", Name = "Instituicao", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Instituicao
    {
        get
        {
            return _instituicao;
        }
        set
        {
            if (value != _instituicao)
            {
                OnInstituicaoChanging(value);
                SendPropertyChanging();
                _instituicao = value;
                SendPropertyChanged("Instituicao");
                OnInstituicaoChanged();
            }
        }
    }

    #endregion

    #region string Login

    private string _login;
    [DebuggerNonUserCode]
    [Column(Storage = "_login", Name = "Login", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
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

    #region string Logradouro

    private string _logradouro;
    [DebuggerNonUserCode]
    [Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(60)", AutoSync = AutoSync.Never)]
    public string Logradouro
    {
        get
        {
            return _logradouro;
        }
        set
        {
            if (value != _logradouro)
            {
                OnLogradouroChanging(value);
                SendPropertyChanging();
                _logradouro = value;
                SendPropertyChanged("Logradouro");
                OnLogradouroChanged();
            }
        }
    }

    #endregion

    #region string Nacionalidade

    private string _nacionalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_nacionalidade", Name = "Nacionalidade", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Nacionalidade
    {
        get
        {
            return _nacionalidade;
        }
        set
        {
            if (value != _nacionalidade)
            {
                OnNacionalidadeChanging(value);
                SendPropertyChanging();
                _nacionalidade = value;
                SendPropertyChanged("Nacionalidade");
                OnNacionalidadeChanged();
            }
        }
    }

    #endregion

    #region DateTime? Nascimento

    private DateTime? _nascimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_nascimento", Name = "Nascimento", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? Nascimento
    {
        get
        {
            return _nascimento;
        }
        set
        {
            if (value != _nascimento)
            {
                OnNascimentoChanging(value);
                SendPropertyChanging();
                _nascimento = value;
                SendPropertyChanged("Nascimento");
                OnNascimentoChanged();
            }
        }
    }

    #endregion

    #region string Naturalidade

    private string _naturalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_naturalidade", Name = "Naturalidade", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Naturalidade
    {
        get
        {
            return _naturalidade;
        }
        set
        {
            if (value != _naturalidade)
            {
                OnNaturalidadeChanging(value);
                SendPropertyChanging();
                _naturalidade = value;
                SendPropertyChanged("Naturalidade");
                OnNaturalidadeChanged();
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region int? PerfilID

    private int? _perfilID;
    [DebuggerNonUserCode]
    [Column(Storage = "_perfilID", Name = "PerfilId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? PerfilID
    {
        get
        {
            return _perfilID;
        }
        set
        {
            if (value != _perfilID)
            {
                OnPerfilIDChanging(value);
                SendPropertyChanging();
                _perfilID = value;
                SendPropertyChanged("PerfilID");
                OnPerfilIDChanged();
            }
        }
    }

    #endregion

    #region string Pis

    private string _pis;
    [DebuggerNonUserCode]
    [Column(Storage = "_pis", Name = "Pis", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Pis
    {
        get
        {
            return _pis;
        }
        set
        {
            if (value != _pis)
            {
                OnPisChanging(value);
                SendPropertyChanging();
                _pis = value;
                SendPropertyChanged("Pis");
                OnPisChanged();
            }
        }
    }

    #endregion

    #region sbyte? PrimeiroEmprego

    private sbyte? _primeiroEmprego;
    [DebuggerNonUserCode]
    [Column(Storage = "_primeiroEmprego", Name = "PrimeiroEmprego", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? PrimeiroEmprego
    {
        get
        {
            return _primeiroEmprego;
        }
        set
        {
            if (value != _primeiroEmprego)
            {
                OnPrimeiroEmpregoChanging(value);
                SendPropertyChanging();
                _primeiroEmprego = value;
                SendPropertyChanged("PrimeiroEmprego");
                OnPrimeiroEmpregoChanged();
            }
        }
    }

    #endregion

    #region string Rg

    private string _rg;
    [DebuggerNonUserCode]
    [Column(Storage = "_rg", Name = "Rg", DbType = "varchar(25)", AutoSync = AutoSync.Never)]
    public string Rg
    {
        get
        {
            return _rg;
        }
        set
        {
            if (value != _rg)
            {
                OnRgChanging(value);
                SendPropertyChanging();
                _rg = value;
                SendPropertyChanged("Rg");
                OnRgChanged();
            }
        }
    }

    #endregion

    #region string Senha

    private string _senha;
    [DebuggerNonUserCode]
    [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
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

    #region string Serie

    private string _serie;
    [DebuggerNonUserCode]
    [Column(Storage = "_serie", Name = "Serie", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Serie
    {
        get
        {
            return _serie;
        }
        set
        {
            if (value != _serie)
            {
                OnSerieChanging(value);
                SendPropertyChanging();
                _serie = value;
                SendPropertyChanged("Serie");
                OnSerieChanged();
            }
        }
    }

    #endregion

    #region sbyte? Sexo

    private sbyte? _sexo;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexo", Name = "Sexo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Sexo
    {
        get
        {
            return _sexo;
        }
        set
        {
            if (value != _sexo)
            {
                OnSexoChanging(value);
                SendPropertyChanging();
                _sexo = value;
                SendPropertyChanged("Sexo");
                OnSexoChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region string TituloEleitor

    private string _tituloEleitor;
    [DebuggerNonUserCode]
    [Column(Storage = "_tituloEleitor", Name = "TituloEleitor", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
    public string TituloEleitor
    {
        get
        {
            return _tituloEleitor;
        }
        set
        {
            if (value != _tituloEleitor)
            {
                OnTituloEleitorChanging(value);
                SendPropertyChanging();
                _tituloEleitor = value;
                SendPropertyChanged("TituloEleitor");
                OnTituloEleitorChanged();
            }
        }
    }

    #endregion

    #region string Uf

    private string _uf;
    [DebuggerNonUserCode]
    [Column(Storage = "_uf", Name = "Uf", DbType = "varchar(2)", AutoSync = AutoSync.Never)]
    public string Uf
    {
        get
        {
            return _uf;
        }
        set
        {
            if (value != _uf)
            {
                OnUfChanging(value);
                SendPropertyChanging();
                _uf = value;
                SendPropertyChanged("Uf");
                OnUfChanged();
            }
        }
    }

    #endregion

    #region string Zona

    private string _zona;
    [DebuggerNonUserCode]
    [Column(Storage = "_zona", Name = "Zona", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
    public string Zona
    {
        get
        {
            return _zona;
        }
        set
        {
            if (value != _zona)
            {
                OnZonaChanging(value);
                SendPropertyChanging();
                _zona = value;
                SendPropertyChanged("Zona");
                OnZonaChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<AtividadeTurma> _atIvIdaDeTuRmA;
    [Association(Storage = "_atIvIdaDeTuRmA", OtherKey = "FuncionarioID", ThisKey = "ID", Name = "fk_AtividadeTurma_Funcionario")]
    [DebuggerNonUserCode]
    public EntitySet<AtividadeTurma> AtividadeTurma
    {
        get
        {
            return _atIvIdaDeTuRmA;
        }
        set
        {
            _atIvIdaDeTuRmA = value;
        }
    }

    private EntitySet<ProfessorDisciplinaSala> _professorDiscIpliNAsAla;
    [Association(Storage = "_professorDiscIpliNAsAla", OtherKey = "FuncionarioID", ThisKey = "ID", Name = "fk_ProfessorDisciplinaSala_Funcionario")]
    [DebuggerNonUserCode]
    public EntitySet<ProfessorDisciplinaSala> ProfessorDisciplinaSala
    {
        get
        {
            return _professorDiscIpliNAsAla;
        }
        set
        {
            _professorDiscIpliNAsAla = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Perfil> _perFiL;
    [Association(Storage = "_perFiL", OtherKey = "ID", ThisKey = "PerfilID", Name = "fk_Funcionario_Perfil", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Perfil Perfil
    {
        get
        {
            return _perFiL.Entity;
        }
        set
        {
            if (value != _perFiL.Entity)
            {
                if (_perFiL.Entity != null)
                {
                    var previousPerfil = _perFiL.Entity;
                    _perFiL.Entity = null;
                    previousPerfil.Funcionario.Remove(this);
                }
                _perFiL.Entity = value;
                if (value != null)
                {
                    value.Funcionario.Add(this);
                    _perfilID = value.ID;
                }
                else
                {
                    _perfilID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void AtividadeTurma_Attach(AtividadeTurma entity)
    {
        entity.Funcionario = this;
    }

    private void AtividadeTurma_Detach(AtividadeTurma entity)
    {
        entity.Funcionario = null;
    }

    private void ProfessorDisciplinaSala_Attach(ProfessorDisciplinaSala entity)
    {
        entity.Funcionario = this;
    }

    private void ProfessorDisciplinaSala_Detach(ProfessorDisciplinaSala entity)
    {
        entity.Funcionario = null;
    }


    #endregion

    #region ctor

    public Funcionario()
    {
        _atIvIdaDeTuRmA = new EntitySet<AtividadeTurma>(AtividadeTurma_Attach, AtividadeTurma_Detach);
        _professorDiscIpliNAsAla = new EntitySet<ProfessorDisciplinaSala>(ProfessorDisciplinaSala_Attach, ProfessorDisciplinaSala_Detach);
        _perFiL = new EntityRef<Perfil>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.matricula")]
public partial class Matricula : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAlunoIDChanged();
    partial void OnAlunoIDChanging(int? value);
    partial void OnAnoChanged();
    partial void OnAnoChanging(int? value);
    partial void OnDataMatriculaChanged();
    partial void OnDataMatriculaChanging(DateTime? value);
    partial void OnDescontoIDChanged();
    partial void OnDescontoIDChanging(int? value);
    partial void OnDiaVencimentoChanged();
    partial void OnDiaVencimentoChanging(int? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnNumMatriculaChanged();
    partial void OnNumMatriculaChanging(string value);
    partial void OnSalaPeriodoIDChanged();
    partial void OnSalaPeriodoIDChanging(int? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region int? AlunoID

    private int? _alunoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoID", Name = "AlunoId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? AlunoID
    {
        get
        {
            return _alunoID;
        }
        set
        {
            if (value != _alunoID)
            {
                OnAlunoIDChanging(value);
                SendPropertyChanging();
                _alunoID = value;
                SendPropertyChanged("AlunoID");
                OnAlunoIDChanged();
            }
        }
    }

    #endregion

    #region int? Ano

    private int? _ano;
    [DebuggerNonUserCode]
    [Column(Storage = "_ano", Name = "Ano", DbType = "int", AutoSync = AutoSync.Never)]
    public int? Ano
    {
        get
        {
            return _ano;
        }
        set
        {
            if (value != _ano)
            {
                OnAnoChanging(value);
                SendPropertyChanging();
                _ano = value;
                SendPropertyChanged("Ano");
                OnAnoChanged();
            }
        }
    }

    #endregion

    #region DateTime? DataMatricula

    private DateTime? _dataMatricula;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataMatricula", Name = "DataMatricula", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataMatricula
    {
        get
        {
            return _dataMatricula;
        }
        set
        {
            if (value != _dataMatricula)
            {
                OnDataMatriculaChanging(value);
                SendPropertyChanging();
                _dataMatricula = value;
                SendPropertyChanged("DataMatricula");
                OnDataMatriculaChanged();
            }
        }
    }

    #endregion

    #region int? DescontoID

    private int? _descontoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_descontoID", Name = "DescontoId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? DescontoID
    {
        get
        {
            return _descontoID;
        }
        set
        {
            if (value != _descontoID)
            {
                OnDescontoIDChanging(value);
                SendPropertyChanging();
                _descontoID = value;
                SendPropertyChanged("DescontoID");
                OnDescontoIDChanged();
            }
        }
    }

    #endregion

    #region int? DiaVencimento

    private int? _diaVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_diaVencimento", Name = "DiaVencimento", DbType = "int", AutoSync = AutoSync.Never)]
    public int? DiaVencimento
    {
        get
        {
            return _diaVencimento;
        }
        set
        {
            if (value != _diaVencimento)
            {
                OnDiaVencimentoChanging(value);
                SendPropertyChanging();
                _diaVencimento = value;
                SendPropertyChanged("DiaVencimento");
                OnDiaVencimentoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region string NumMatricula

    private string _numMatricula;
    [DebuggerNonUserCode]
    [Column(Storage = "_numMatricula", Name = "NumMatricula", DbType = "varchar(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string NumMatricula
    {
        get
        {
            return _numMatricula;
        }
        set
        {
            if (value != _numMatricula)
            {
                OnNumMatriculaChanging(value);
                SendPropertyChanging();
                _numMatricula = value;
                SendPropertyChanged("NumMatricula");
                OnNumMatriculaChanged();
            }
        }
    }

    #endregion

    #region int? SalaPeriodoID

    private int? _salaPeriodoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_salaPeriodoID", Name = "SalaPeriodoId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? SalaPeriodoID
    {
        get
        {
            return _salaPeriodoID;
        }
        set
        {
            if (value != _salaPeriodoID)
            {
                OnSalaPeriodoIDChanging(value);
                SendPropertyChanging();
                _salaPeriodoID = value;
                SendPropertyChanged("SalaPeriodoID");
                OnSalaPeriodoIDChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<BoletoAtividade> _boleToAtIvIDade;
    [Association(Storage = "_boleToAtIvIDade", OtherKey = "MatriculaID", ThisKey = "ID", Name = "fk_BoletoAtividade_Matricula")]
    [DebuggerNonUserCode]
    public EntitySet<BoletoAtividade> BoletoAtividade
    {
        get
        {
            return _boleToAtIvIDade;
        }
        set
        {
            _boleToAtIvIDade = value;
        }
    }

    private EntitySet<BoletoMensalidade> _boleTomeNsAlIDAde;
    [Association(Storage = "_boleTomeNsAlIDAde", OtherKey = "MatriculaID", ThisKey = "ID", Name = "fk_BoletoMensalidade_Matricula")]
    [DebuggerNonUserCode]
    public EntitySet<BoletoMensalidade> BoletoMensalidade
    {
        get
        {
            return _boleTomeNsAlIDAde;
        }
        set
        {
            _boleTomeNsAlIDAde = value;
        }
    }

    private EntitySet<MatriculaVinculo> _matRiCuLaViNCuLo;
    [Association(Storage = "_matRiCuLaViNCuLo", OtherKey = "MatriculaMestreID", ThisKey = "ID", Name = "fk_MatriculaVinculo_Matricula1")]
    [DebuggerNonUserCode]
    public EntitySet<MatriculaVinculo> MatriculaVinculo
    {
        get
        {
            return _matRiCuLaViNCuLo;
        }
        set
        {
            _matRiCuLaViNCuLo = value;
        }
    }

    private EntitySet<MatriculaVinculo> _matRiCuLaViNCuLo1;
    [Association(Storage = "_matRiCuLaViNCuLo1", OtherKey = "MatriculaDependenteID", ThisKey = "ID", Name = "fk_MatriculaVinculo_Matricula2")]
    [DebuggerNonUserCode]
    public EntitySet<MatriculaVinculo> MatriculaVinculo1
    {
        get
        {
            return _matRiCuLaViNCuLo1;
        }
        set
        {
            _matRiCuLaViNCuLo1 = value;
        }
    }

    private EntitySet<Nota> _notA;
    [Association(Storage = "_notA", OtherKey = "MatriculaID", ThisKey = "ID", Name = "fk_Nota_Matricula")]
    [DebuggerNonUserCode]
    public EntitySet<Nota> Nota
    {
        get
        {
            return _notA;
        }
        set
        {
            _notA = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Aluno> _alUNo;
    [Association(Storage = "_alUNo", OtherKey = "ID", ThisKey = "AlunoID", Name = "fk_Matricula_Aluno", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Aluno Aluno
    {
        get
        {
            return _alUNo.Entity;
        }
        set
        {
            if (value != _alUNo.Entity)
            {
                if (_alUNo.Entity != null)
                {
                    var previousAluno = _alUNo.Entity;
                    _alUNo.Entity = null;
                    previousAluno.Matricula.Remove(this);
                }
                _alUNo.Entity = value;
                if (value != null)
                {
                    value.Matricula.Add(this);
                    _alunoID = value.ID;
                }
                else
                {
                    _alunoID = null;
                }
            }
        }
    }

    private EntityRef<Desconto> _desConTo;
    [Association(Storage = "_desConTo", OtherKey = "ID", ThisKey = "DescontoID", Name = "fk_Matricula_Desconto", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Desconto Desconto
    {
        get
        {
            return _desConTo.Entity;
        }
        set
        {
            if (value != _desConTo.Entity)
            {
                if (_desConTo.Entity != null)
                {
                    var previousDesconto = _desConTo.Entity;
                    _desConTo.Entity = null;
                    previousDesconto.Matricula.Remove(this);
                }
                _desConTo.Entity = value;
                if (value != null)
                {
                    value.Matricula.Add(this);
                    _descontoID = value.ID;
                }
                else
                {
                    _descontoID = null;
                }
            }
        }
    }

    private EntityRef<SalaPeriodo> _salApErIoDo;
    [Association(Storage = "_salApErIoDo", OtherKey = "ID", ThisKey = "SalaPeriodoID", Name = "fk_Matricula_SalaPeriodo", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public SalaPeriodo SalaPeriodo
    {
        get
        {
            return _salApErIoDo.Entity;
        }
        set
        {
            if (value != _salApErIoDo.Entity)
            {
                if (_salApErIoDo.Entity != null)
                {
                    var previousSalaPeriodo = _salApErIoDo.Entity;
                    _salApErIoDo.Entity = null;
                    previousSalaPeriodo.Matricula.Remove(this);
                }
                _salApErIoDo.Entity = value;
                if (value != null)
                {
                    value.Matricula.Add(this);
                    _salaPeriodoID = value.ID;
                }
                else
                {
                    _salaPeriodoID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void BoletoAtividade_Attach(BoletoAtividade entity)
    {
        entity.Matricula = this;
    }

    private void BoletoAtividade_Detach(BoletoAtividade entity)
    {
        entity.Matricula = null;
    }

    private void BoletoMensalidade_Attach(BoletoMensalidade entity)
    {
        entity.Matricula = this;
    }

    private void BoletoMensalidade_Detach(BoletoMensalidade entity)
    {
        entity.Matricula = null;
    }

    private void MatriculaVinculo_Attach(MatriculaVinculo entity)
    {
        entity.MatriculaMestre = this;
    }

    private void MatriculaVinculo_Detach(MatriculaVinculo entity)
    {
        entity.MatriculaMestre = null;
    }

    private void MatriculaVinculo1_Attach(MatriculaVinculo entity)
    {
        entity.MatriculaDependente = this;
    }

    private void MatriculaVinculo1_Detach(MatriculaVinculo entity)
    {
        entity.MatriculaDependente = null;
    }

    private void Nota_Attach(Nota entity)
    {
        entity.Matricula = this;
    }

    private void Nota_Detach(Nota entity)
    {
        entity.Matricula = null;
    }


    #endregion

    #region ctor

    public Matricula()
    {
        _boleToAtIvIDade = new EntitySet<BoletoAtividade>(BoletoAtividade_Attach, BoletoAtividade_Detach);
        _boleTomeNsAlIDAde = new EntitySet<BoletoMensalidade>(BoletoMensalidade_Attach, BoletoMensalidade_Detach);
        _matRiCuLaViNCuLo = new EntitySet<MatriculaVinculo>(MatriculaVinculo_Attach, MatriculaVinculo_Detach);
        _matRiCuLaViNCuLo1 = new EntitySet<MatriculaVinculo>(MatriculaVinculo1_Attach, MatriculaVinculo1_Detach);
        _notA = new EntitySet<Nota>(Nota_Attach, Nota_Detach);
        _alUNo = new EntityRef<Aluno>();
        _desConTo = new EntityRef<Desconto>();
        _salApErIoDo = new EntityRef<SalaPeriodo>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.matriculavinculo")]
public partial class MatriculaVinculo : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnDataVinculoChanged();
    partial void OnDataVinculoChanging(DateTime? value);
    partial void OnGrupoIDChanged();
    partial void OnGrupoIDChanging(int? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnMatriculaDependenteIDChanged();
    partial void OnMatriculaDependenteIDChanging(int value);
    partial void OnMatriculaMestreIDChanged();
    partial void OnMatriculaMestreIDChanging(int value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region DateTime? DataVinculo

    private DateTime? _dataVinculo;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVinculo", Name = "DataVinculo", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataVinculo
    {
        get
        {
            return _dataVinculo;
        }
        set
        {
            if (value != _dataVinculo)
            {
                OnDataVinculoChanging(value);
                SendPropertyChanging();
                _dataVinculo = value;
                SendPropertyChanged("DataVinculo");
                OnDataVinculoChanged();
            }
        }
    }

    #endregion

    #region int? GrupoID

    private int? _grupoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_grupoID", Name = "GrupoID", DbType = "int", AutoSync = AutoSync.Never)]
    public int? GrupoID
    {
        get
        {
            return _grupoID;
        }
        set
        {
            if (value != _grupoID)
            {
                OnGrupoIDChanging(value);
                SendPropertyChanging();
                _grupoID = value;
                SendPropertyChanged("GrupoID");
                OnGrupoIDChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int MatriculaDependenteID

    private int _matriculaDependenteID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaDependenteID", Name = "MatriculaDependenteId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int MatriculaDependenteID
    {
        get
        {
            return _matriculaDependenteID;
        }
        set
        {
            if (value != _matriculaDependenteID)
            {
                OnMatriculaDependenteIDChanging(value);
                SendPropertyChanging();
                _matriculaDependenteID = value;
                SendPropertyChanged("MatriculaDependenteID");
                OnMatriculaDependenteIDChanged();
            }
        }
    }

    #endregion

    #region int MatriculaMestreID

    private int _matriculaMestreID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaMestreID", Name = "MatriculaMestreId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int MatriculaMestreID
    {
        get
        {
            return _matriculaMestreID;
        }
        set
        {
            if (value != _matriculaMestreID)
            {
                OnMatriculaMestreIDChanging(value);
                SendPropertyChanging();
                _matriculaMestreID = value;
                SendPropertyChanged("MatriculaMestreID");
                OnMatriculaMestreIDChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Parents

    private EntityRef<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "ID", ThisKey = "MatriculaMestreID", Name = "fk_MatriculaVinculo_Matricula1", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula MatriculaMestre
    {
        get
        {
            return _matRiCuLa.Entity;
        }
        set
        {
            if (value != _matRiCuLa.Entity)
            {
                if (_matRiCuLa.Entity != null)
                {
                    var previousMatricula = _matRiCuLa.Entity;
                    _matRiCuLa.Entity = null;
                    previousMatricula.MatriculaVinculo.Remove(this);
                }
                _matRiCuLa.Entity = value;
                if (value != null)
                {
                    value.MatriculaVinculo.Add(this);
                    _matriculaMestreID = value.ID;
                }
                else
                {
                    _matriculaMestreID = default(int);
                }
            }
        }
    }

    private EntityRef<Matricula> _matRiCuLa1;
    [Association(Storage = "_matRiCuLa1", OtherKey = "ID", ThisKey = "MatriculaDependenteID", Name = "fk_MatriculaVinculo_Matricula2", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula MatriculaDependente
    {
        get
        {
            return _matRiCuLa1.Entity;
        }
        set
        {
            if (value != _matRiCuLa1.Entity)
            {
                if (_matRiCuLa1.Entity != null)
                {
                    var previousMatricula = _matRiCuLa1.Entity;
                    _matRiCuLa1.Entity = null;
                    previousMatricula.MatriculaVinculo1.Remove(this);
                }
                _matRiCuLa1.Entity = value;
                if (value != null)
                {
                    value.MatriculaVinculo1.Add(this);
                    _matriculaDependenteID = value.ID;
                }
                else
                {
                    _matriculaDependenteID = default(int);
                }
            }
        }
    }


    #endregion

    #region ctor

    public MatriculaVinculo()
    {
        _matRiCuLa = new EntityRef<Matricula>();
        _matRiCuLa1 = new EntityRef<Matricula>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.nota")]
public partial class Nota : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAprovadoChanged();
    partial void OnAprovadoChanging(sbyte? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnMatriculaIDChanged();
    partial void OnMatriculaIDChanging(int? value);
    partial void OnProfessorDisciplinaSalaIDChanged();
    partial void OnProfessorDisciplinaSalaIDChanging(int? value);
    partial void OnRecChanged();
    partial void OnRecChanging(double? value);
    partial void OnRecFinalChanged();
    partial void OnRecFinalChanging(double? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnVc1Changed();
    partial void OnVc1Changing(double value);
    partial void OnVc2Changed();
    partial void OnVc2Changing(double value);
    partial void OnVpChanged();
    partial void OnVpChanging(double? value);

    #endregion

    #region sbyte? Aprovado

    private sbyte? _aprovado;
    [DebuggerNonUserCode]
    [Column(Storage = "_aprovado", Name = "Aprovado", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Aprovado
    {
        get
        {
            return _aprovado;
        }
        set
        {
            if (value != _aprovado)
            {
                OnAprovadoChanging(value);
                SendPropertyChanging();
                _aprovado = value;
                SendPropertyChanged("Aprovado");
                OnAprovadoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int? MatriculaID

    private int? _matriculaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaID", Name = "MatriculaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? MatriculaID
    {
        get
        {
            return _matriculaID;
        }
        set
        {
            if (value != _matriculaID)
            {
                OnMatriculaIDChanging(value);
                SendPropertyChanging();
                _matriculaID = value;
                SendPropertyChanged("MatriculaID");
                OnMatriculaIDChanged();
            }
        }
    }

    #endregion

    #region int? ProfessorDisciplinaSalaID

    private int? _professorDisciplinaSalaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_professorDisciplinaSalaID", Name = "ProfessorDisciplinaSalaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? ProfessorDisciplinaSalaID
    {
        get
        {
            return _professorDisciplinaSalaID;
        }
        set
        {
            if (value != _professorDisciplinaSalaID)
            {
                OnProfessorDisciplinaSalaIDChanging(value);
                SendPropertyChanging();
                _professorDisciplinaSalaID = value;
                SendPropertyChanged("ProfessorDisciplinaSalaID");
                OnProfessorDisciplinaSalaIDChanged();
            }
        }
    }

    #endregion

    #region double? Rec

    private double? _rec;
    [DebuggerNonUserCode]
    [Column(Storage = "_rec", Name = "Rec", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Rec
    {
        get
        {
            return _rec;
        }
        set
        {
            if (value != _rec)
            {
                OnRecChanging(value);
                SendPropertyChanging();
                _rec = value;
                SendPropertyChanged("Rec");
                OnRecChanged();
            }
        }
    }

    #endregion

    #region double? RecFinal

    private double? _recFinal;
    [DebuggerNonUserCode]
    [Column(Storage = "_recFinal", Name = "RecFinal", DbType = "double", AutoSync = AutoSync.Never)]
    public double? RecFinal
    {
        get
        {
            return _recFinal;
        }
        set
        {
            if (value != _recFinal)
            {
                OnRecFinalChanging(value);
                SendPropertyChanging();
                _recFinal = value;
                SendPropertyChanged("RecFinal");
                OnRecFinalChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region double Vc1

    private double _vc1;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc1", Name = "Vc1", DbType = "double", AutoSync = AutoSync.Never, CanBeNull = false)]
    public double Vc1
    {
        get
        {
            return _vc1;
        }
        set
        {
            if (value != _vc1)
            {
                OnVc1Changing(value);
                SendPropertyChanging();
                _vc1 = value;
                SendPropertyChanged("Vc1");
                OnVc1Changed();
            }
        }
    }

    #endregion

    #region double Vc2

    private double _vc2;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc2", Name = "Vc2", DbType = "double", AutoSync = AutoSync.Never, CanBeNull = false)]
    public double Vc2
    {
        get
        {
            return _vc2;
        }
        set
        {
            if (value != _vc2)
            {
                OnVc2Changing(value);
                SendPropertyChanging();
                _vc2 = value;
                SendPropertyChanged("Vc2");
                OnVc2Changed();
            }
        }
    }

    #endregion

    #region double? Vp

    private double? _vp;
    [DebuggerNonUserCode]
    [Column(Storage = "_vp", Name = "Vp", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Vp
    {
        get
        {
            return _vp;
        }
        set
        {
            if (value != _vp)
            {
                OnVpChanging(value);
                SendPropertyChanging();
                _vp = value;
                SendPropertyChanged("Vp");
                OnVpChanged();
            }
        }
    }

    #endregion

    #region Parents

    private EntityRef<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "ID", ThisKey = "MatriculaID", Name = "fk_Nota_Matricula", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula Matricula
    {
        get
        {
            return _matRiCuLa.Entity;
        }
        set
        {
            if (value != _matRiCuLa.Entity)
            {
                if (_matRiCuLa.Entity != null)
                {
                    var previousMatricula = _matRiCuLa.Entity;
                    _matRiCuLa.Entity = null;
                    previousMatricula.Nota.Remove(this);
                }
                _matRiCuLa.Entity = value;
                if (value != null)
                {
                    value.Nota.Add(this);
                    _matriculaID = value.ID;
                }
                else
                {
                    _matriculaID = null;
                }
            }
        }
    }

    private EntityRef<ProfessorDisciplinaSala> _professorDiscIpliNAsAla;
    [Association(Storage = "_professorDiscIpliNAsAla", OtherKey = "ID", ThisKey = "ProfessorDisciplinaSalaID", Name = "fk_Nota_ProfessorDisciplinaSala", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public ProfessorDisciplinaSala ProfessorDisciplinaSala
    {
        get
        {
            return _professorDiscIpliNAsAla.Entity;
        }
        set
        {
            if (value != _professorDiscIpliNAsAla.Entity)
            {
                if (_professorDiscIpliNAsAla.Entity != null)
                {
                    var previousProfessorDisciplinaSala = _professorDiscIpliNAsAla.Entity;
                    _professorDiscIpliNAsAla.Entity = null;
                    previousProfessorDisciplinaSala.Nota.Remove(this);
                }
                _professorDiscIpliNAsAla.Entity = value;
                if (value != null)
                {
                    value.Nota.Add(this);
                    _professorDisciplinaSalaID = value.ID;
                }
                else
                {
                    _professorDisciplinaSalaID = null;
                }
            }
        }
    }


    #endregion

    #region ctor

    public Nota()
    {
        _matRiCuLa = new EntityRef<Matricula>();
        _professorDiscIpliNAsAla = new EntityRef<ProfessorDisciplinaSala>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.perfil")]
public partial class Perfil : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnCtrlAdvertenciasAtrasosChanged();
    partial void OnCtrlAdvertenciasAtrasosChanging(int? value);
    partial void OnCtrlAlunoChanged();
    partial void OnCtrlAlunoChanging(int? value);
    partial void OnCtrlAniversariantesChanged();
    partial void OnCtrlAniversariantesChanging(int? value);
    partial void OnCtrlAnotacoesChanged();
    partial void OnCtrlAnotacoesChanging(int? value);
    partial void OnCtrlAtividadeChanged();
    partial void OnCtrlAtividadeChanging(int? value);
    partial void OnCtrlBoletimChanged();
    partial void OnCtrlBoletimChanging(int? value);
    partial void OnCtrlCertificadosChanged();
    partial void OnCtrlCertificadosChanging(int? value);
    partial void OnCtrlChequesChanged();
    partial void OnCtrlChequesChanging(int? value);
    partial void OnCtrlContasPagarChanged();
    partial void OnCtrlContasPagarChanging(int? value);
    partial void OnCtrlDebitosChanged();
    partial void OnCtrlDebitosChanging(int? value);
    partial void OnCtrlDeclaracaoQuitacaoChanged();
    partial void OnCtrlDeclaracaoQuitacaoChanging(int? value);
    partial void OnCtrlEmailsChanged();
    partial void OnCtrlEmailsChanging(int? value);
    partial void OnCtrlFinanceiroChanged();
    partial void OnCtrlFinanceiroChanging(int? value);
    partial void OnCtrlFolhaChamadaChanged();
    partial void OnCtrlFolhaChamadaChanging(int? value);
    partial void OnCtrlFolhaPontoChanged();
    partial void OnCtrlFolhaPontoChanging(int? value);
    partial void OnCtrlFreqAlunosChanged();
    partial void OnCtrlFreqAlunosChanging(int? value);
    partial void OnCtrlFreqFuncionariosChanged();
    partial void OnCtrlFreqFuncionariosChanging(int? value);
    partial void OnCtrlFuncionarioChanged();
    partial void OnCtrlFuncionarioChanging(int? value);
    partial void OnCtrlGreChanged();
    partial void OnCtrlGreChanging(int? value);
    partial void OnCtrlMensalidadeChanged();
    partial void OnCtrlMensalidadeChanging(int? value);
    partial void OnCtrlNotasChanged();
    partial void OnCtrlNotasChanging(int? value);
    partial void OnCtrlRankingNotasChanged();
    partial void OnCtrlRankingNotasChanging(int? value);
    partial void OnCtrlRemanejamentoChanged();
    partial void OnCtrlRemanejamentoChanging(int? value);
    partial void OnCtrlSerieChanged();
    partial void OnCtrlSerieChanging(int? value);
    partial void OnCtrlTransfHistoricosChanged();
    partial void OnCtrlTransfHistoricosChanging(int? value);
    partial void OnCtrlTurmaChanged();
    partial void OnCtrlTurmaChanging(int? value);
    partial void OnCtrlTurnoChanged();
    partial void OnCtrlTurnoChanging(int? value);
    partial void OnDescricaoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int? CtrlAdvertenciasAtrasos

    private int? _ctrlAdvertenciasAtrasos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAdvertenciasAtrasos", Name = "CtrlAdvertenciasAtrasos", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlAdvertenciasAtrasos
    {
        get
        {
            return _ctrlAdvertenciasAtrasos;
        }
        set
        {
            if (value != _ctrlAdvertenciasAtrasos)
            {
                OnCtrlAdvertenciasAtrasosChanging(value);
                SendPropertyChanging();
                _ctrlAdvertenciasAtrasos = value;
                SendPropertyChanged("CtrlAdvertenciasAtrasos");
                OnCtrlAdvertenciasAtrasosChanged();
            }
        }
    }

    #endregion

    #region int? CtrlAluno

    private int? _ctrlAluno;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAluno", Name = "CtrlAluno", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlAluno
    {
        get
        {
            return _ctrlAluno;
        }
        set
        {
            if (value != _ctrlAluno)
            {
                OnCtrlAlunoChanging(value);
                SendPropertyChanging();
                _ctrlAluno = value;
                SendPropertyChanged("CtrlAluno");
                OnCtrlAlunoChanged();
            }
        }
    }

    #endregion

    #region int? CtrlAniversariantes

    private int? _ctrlAniversariantes;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAniversariantes", Name = "CtrlAniversariantes", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlAniversariantes
    {
        get
        {
            return _ctrlAniversariantes;
        }
        set
        {
            if (value != _ctrlAniversariantes)
            {
                OnCtrlAniversariantesChanging(value);
                SendPropertyChanging();
                _ctrlAniversariantes = value;
                SendPropertyChanged("CtrlAniversariantes");
                OnCtrlAniversariantesChanged();
            }
        }
    }

    #endregion

    #region int? CtrlAnotacoes

    private int? _ctrlAnotacoes;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAnotacoes", Name = "CtrlAnotacoes", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlAnotacoes
    {
        get
        {
            return _ctrlAnotacoes;
        }
        set
        {
            if (value != _ctrlAnotacoes)
            {
                OnCtrlAnotacoesChanging(value);
                SendPropertyChanging();
                _ctrlAnotacoes = value;
                SendPropertyChanged("CtrlAnotacoes");
                OnCtrlAnotacoesChanged();
            }
        }
    }

    #endregion

    #region int? CtrlAtividade

    private int? _ctrlAtividade;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAtividade", Name = "CtrlAtividade", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlAtividade
    {
        get
        {
            return _ctrlAtividade;
        }
        set
        {
            if (value != _ctrlAtividade)
            {
                OnCtrlAtividadeChanging(value);
                SendPropertyChanging();
                _ctrlAtividade = value;
                SendPropertyChanged("CtrlAtividade");
                OnCtrlAtividadeChanged();
            }
        }
    }

    #endregion

    #region int? CtrlBoletim

    private int? _ctrlBoletim;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlBoletim", Name = "CtrlBoletim", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlBoletim
    {
        get
        {
            return _ctrlBoletim;
        }
        set
        {
            if (value != _ctrlBoletim)
            {
                OnCtrlBoletimChanging(value);
                SendPropertyChanging();
                _ctrlBoletim = value;
                SendPropertyChanged("CtrlBoletim");
                OnCtrlBoletimChanged();
            }
        }
    }

    #endregion

    #region int? CtrlCertificados

    private int? _ctrlCertificados;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlCertificados", Name = "CtrlCertificados", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlCertificados
    {
        get
        {
            return _ctrlCertificados;
        }
        set
        {
            if (value != _ctrlCertificados)
            {
                OnCtrlCertificadosChanging(value);
                SendPropertyChanging();
                _ctrlCertificados = value;
                SendPropertyChanged("CtrlCertificados");
                OnCtrlCertificadosChanged();
            }
        }
    }

    #endregion

    #region int? CtrlCheques

    private int? _ctrlCheques;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlCheques", Name = "CtrlCheques", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlCheques
    {
        get
        {
            return _ctrlCheques;
        }
        set
        {
            if (value != _ctrlCheques)
            {
                OnCtrlChequesChanging(value);
                SendPropertyChanging();
                _ctrlCheques = value;
                SendPropertyChanged("CtrlCheques");
                OnCtrlChequesChanged();
            }
        }
    }

    #endregion

    #region int? CtrlContasPagar

    private int? _ctrlContasPagar;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlContasPagar", Name = "CtrlContasPagar", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlContasPagar
    {
        get
        {
            return _ctrlContasPagar;
        }
        set
        {
            if (value != _ctrlContasPagar)
            {
                OnCtrlContasPagarChanging(value);
                SendPropertyChanging();
                _ctrlContasPagar = value;
                SendPropertyChanged("CtrlContasPagar");
                OnCtrlContasPagarChanged();
            }
        }
    }

    #endregion

    #region int? CtrlDebitos

    private int? _ctrlDebitos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlDebitos", Name = "CtrlDebitos", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlDebitos
    {
        get
        {
            return _ctrlDebitos;
        }
        set
        {
            if (value != _ctrlDebitos)
            {
                OnCtrlDebitosChanging(value);
                SendPropertyChanging();
                _ctrlDebitos = value;
                SendPropertyChanged("CtrlDebitos");
                OnCtrlDebitosChanged();
            }
        }
    }

    #endregion

    #region int? CtrlDeclaracaoQuitacao

    private int? _ctrlDeclaracaoQuitacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlDeclaracaoQuitacao", Name = "CtrlDeclaracaoQuitacao", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlDeclaracaoQuitacao
    {
        get
        {
            return _ctrlDeclaracaoQuitacao;
        }
        set
        {
            if (value != _ctrlDeclaracaoQuitacao)
            {
                OnCtrlDeclaracaoQuitacaoChanging(value);
                SendPropertyChanging();
                _ctrlDeclaracaoQuitacao = value;
                SendPropertyChanged("CtrlDeclaracaoQuitacao");
                OnCtrlDeclaracaoQuitacaoChanged();
            }
        }
    }

    #endregion

    #region int? CtrlEmails

    private int? _ctrlEmails;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlEmails", Name = "CtrlEmails", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlEmails
    {
        get
        {
            return _ctrlEmails;
        }
        set
        {
            if (value != _ctrlEmails)
            {
                OnCtrlEmailsChanging(value);
                SendPropertyChanging();
                _ctrlEmails = value;
                SendPropertyChanged("CtrlEmails");
                OnCtrlEmailsChanged();
            }
        }
    }

    #endregion

    #region int? CtrlFinanceiro

    private int? _ctrlFinanceiro;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFinanceiro", Name = "CtrlFinanceiro", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlFinanceiro
    {
        get
        {
            return _ctrlFinanceiro;
        }
        set
        {
            if (value != _ctrlFinanceiro)
            {
                OnCtrlFinanceiroChanging(value);
                SendPropertyChanging();
                _ctrlFinanceiro = value;
                SendPropertyChanged("CtrlFinanceiro");
                OnCtrlFinanceiroChanged();
            }
        }
    }

    #endregion

    #region int? CtrlFolhaChamada

    private int? _ctrlFolhaChamada;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFolhaChamada", Name = "CtrlFolhaChamada", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlFolhaChamada
    {
        get
        {
            return _ctrlFolhaChamada;
        }
        set
        {
            if (value != _ctrlFolhaChamada)
            {
                OnCtrlFolhaChamadaChanging(value);
                SendPropertyChanging();
                _ctrlFolhaChamada = value;
                SendPropertyChanged("CtrlFolhaChamada");
                OnCtrlFolhaChamadaChanged();
            }
        }
    }

    #endregion

    #region int? CtrlFolhaPonto

    private int? _ctrlFolhaPonto;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFolhaPonto", Name = "CtrlFolhaPonto", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlFolhaPonto
    {
        get
        {
            return _ctrlFolhaPonto;
        }
        set
        {
            if (value != _ctrlFolhaPonto)
            {
                OnCtrlFolhaPontoChanging(value);
                SendPropertyChanging();
                _ctrlFolhaPonto = value;
                SendPropertyChanged("CtrlFolhaPonto");
                OnCtrlFolhaPontoChanged();
            }
        }
    }

    #endregion

    #region int? CtrlFreqAlunos

    private int? _ctrlFreqAlunos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFreqAlunos", Name = "CtrlFreqAlunos", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlFreqAlunos
    {
        get
        {
            return _ctrlFreqAlunos;
        }
        set
        {
            if (value != _ctrlFreqAlunos)
            {
                OnCtrlFreqAlunosChanging(value);
                SendPropertyChanging();
                _ctrlFreqAlunos = value;
                SendPropertyChanged("CtrlFreqAlunos");
                OnCtrlFreqAlunosChanged();
            }
        }
    }

    #endregion

    #region int? CtrlFreqFuncionarios

    private int? _ctrlFreqFuncionarios;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFreqFuncionarios", Name = "CtrlFreqFuncionarios", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlFreqFuncionarios
    {
        get
        {
            return _ctrlFreqFuncionarios;
        }
        set
        {
            if (value != _ctrlFreqFuncionarios)
            {
                OnCtrlFreqFuncionariosChanging(value);
                SendPropertyChanging();
                _ctrlFreqFuncionarios = value;
                SendPropertyChanged("CtrlFreqFuncionarios");
                OnCtrlFreqFuncionariosChanged();
            }
        }
    }

    #endregion

    #region int? CtrlFuncionario

    private int? _ctrlFuncionario;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFuncionario", Name = "CtrlFuncionario", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlFuncionario
    {
        get
        {
            return _ctrlFuncionario;
        }
        set
        {
            if (value != _ctrlFuncionario)
            {
                OnCtrlFuncionarioChanging(value);
                SendPropertyChanging();
                _ctrlFuncionario = value;
                SendPropertyChanged("CtrlFuncionario");
                OnCtrlFuncionarioChanged();
            }
        }
    }

    #endregion

    #region int? CtrlGre

    private int? _ctrlGre;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlGre", Name = "CtrlGRE", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlGre
    {
        get
        {
            return _ctrlGre;
        }
        set
        {
            if (value != _ctrlGre)
            {
                OnCtrlGreChanging(value);
                SendPropertyChanging();
                _ctrlGre = value;
                SendPropertyChanged("CtrlGre");
                OnCtrlGreChanged();
            }
        }
    }

    #endregion

    #region int? CtrlMensalidade

    private int? _ctrlMensalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlMensalidade", Name = "CtrlMensalidade", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlMensalidade
    {
        get
        {
            return _ctrlMensalidade;
        }
        set
        {
            if (value != _ctrlMensalidade)
            {
                OnCtrlMensalidadeChanging(value);
                SendPropertyChanging();
                _ctrlMensalidade = value;
                SendPropertyChanged("CtrlMensalidade");
                OnCtrlMensalidadeChanged();
            }
        }
    }

    #endregion

    #region int? CtrlNotas

    private int? _ctrlNotas;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlNotas", Name = "CtrlNotas", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlNotas
    {
        get
        {
            return _ctrlNotas;
        }
        set
        {
            if (value != _ctrlNotas)
            {
                OnCtrlNotasChanging(value);
                SendPropertyChanging();
                _ctrlNotas = value;
                SendPropertyChanged("CtrlNotas");
                OnCtrlNotasChanged();
            }
        }
    }

    #endregion

    #region int? CtrlRankingNotas

    private int? _ctrlRankingNotas;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlRankingNotas", Name = "CtrlRankingNotas", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlRankingNotas
    {
        get
        {
            return _ctrlRankingNotas;
        }
        set
        {
            if (value != _ctrlRankingNotas)
            {
                OnCtrlRankingNotasChanging(value);
                SendPropertyChanging();
                _ctrlRankingNotas = value;
                SendPropertyChanged("CtrlRankingNotas");
                OnCtrlRankingNotasChanged();
            }
        }
    }

    #endregion

    #region int? CtrlRemanejamento

    private int? _ctrlRemanejamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlRemanejamento", Name = "CtrlRemanejamento", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlRemanejamento
    {
        get
        {
            return _ctrlRemanejamento;
        }
        set
        {
            if (value != _ctrlRemanejamento)
            {
                OnCtrlRemanejamentoChanging(value);
                SendPropertyChanging();
                _ctrlRemanejamento = value;
                SendPropertyChanged("CtrlRemanejamento");
                OnCtrlRemanejamentoChanged();
            }
        }
    }

    #endregion

    #region int? CtrlSerie

    private int? _ctrlSerie;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlSerie", Name = "CtrlSerie", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlSerie
    {
        get
        {
            return _ctrlSerie;
        }
        set
        {
            if (value != _ctrlSerie)
            {
                OnCtrlSerieChanging(value);
                SendPropertyChanging();
                _ctrlSerie = value;
                SendPropertyChanged("CtrlSerie");
                OnCtrlSerieChanged();
            }
        }
    }

    #endregion

    #region int? CtrlTransfHistoricos

    private int? _ctrlTransfHistoricos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlTransfHistoricos", Name = "CtrlTransfHistoricos", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlTransfHistoricos
    {
        get
        {
            return _ctrlTransfHistoricos;
        }
        set
        {
            if (value != _ctrlTransfHistoricos)
            {
                OnCtrlTransfHistoricosChanging(value);
                SendPropertyChanging();
                _ctrlTransfHistoricos = value;
                SendPropertyChanged("CtrlTransfHistoricos");
                OnCtrlTransfHistoricosChanged();
            }
        }
    }

    #endregion

    #region int? CtrlTurma

    private int? _ctrlTurma;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlTurma", Name = "CtrlTurma", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlTurma
    {
        get
        {
            return _ctrlTurma;
        }
        set
        {
            if (value != _ctrlTurma)
            {
                OnCtrlTurmaChanging(value);
                SendPropertyChanging();
                _ctrlTurma = value;
                SendPropertyChanged("CtrlTurma");
                OnCtrlTurmaChanged();
            }
        }
    }

    #endregion

    #region int? CtrlTurno

    private int? _ctrlTurno;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlTurno", Name = "CtrlTurno", DbType = "int", AutoSync = AutoSync.Never)]
    public int? CtrlTurno
    {
        get
        {
            return _ctrlTurno;
        }
        set
        {
            if (value != _ctrlTurno)
            {
                OnCtrlTurnoChanging(value);
                SendPropertyChanging();
                _ctrlTurno = value;
                SendPropertyChanged("CtrlTurno");
                OnCtrlTurnoChanged();
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Descricao
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (value != _descricao)
            {
                OnDescricaoChanging(value);
                SendPropertyChanging();
                _descricao = value;
                SendPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Aluno> _alUNo;
    [Association(Storage = "_alUNo", OtherKey = "PerfilID", ThisKey = "ID", Name = "fk_Aluno_Perfil")]
    [DebuggerNonUserCode]
    public EntitySet<Aluno> Aluno
    {
        get
        {
            return _alUNo;
        }
        set
        {
            _alUNo = value;
        }
    }

    private EntitySet<Funcionario> _funCiOnArIo;
    [Association(Storage = "_funCiOnArIo", OtherKey = "PerfilID", ThisKey = "ID", Name = "fk_Funcionario_Perfil")]
    [DebuggerNonUserCode]
    public EntitySet<Funcionario> Funcionario
    {
        get
        {
            return _funCiOnArIo;
        }
        set
        {
            _funCiOnArIo = value;
        }
    }

    private EntitySet<Responsavel> _reSpOnSaveL;
    [Association(Storage = "_reSpOnSaveL", OtherKey = "PerfilID", ThisKey = "ID", Name = "fk_Responsavel_Perfil")]
    [DebuggerNonUserCode]
    public EntitySet<Responsavel> Responsavel
    {
        get
        {
            return _reSpOnSaveL;
        }
        set
        {
            _reSpOnSaveL = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void Aluno_Attach(Aluno entity)
    {
        entity.Perfil = this;
    }

    private void Aluno_Detach(Aluno entity)
    {
        entity.Perfil = null;
    }

    private void Funcionario_Attach(Funcionario entity)
    {
        entity.Perfil = this;
    }

    private void Funcionario_Detach(Funcionario entity)
    {
        entity.Perfil = null;
    }

    private void Responsavel_Attach(Responsavel entity)
    {
        entity.Perfil = this;
    }

    private void Responsavel_Detach(Responsavel entity)
    {
        entity.Perfil = null;
    }


    #endregion

    #region ctor

    public Perfil()
    {
        _alUNo = new EntitySet<Aluno>(Aluno_Attach, Aluno_Detach);
        _funCiOnArIo = new EntitySet<Funcionario>(Funcionario_Attach, Funcionario_Detach);
        _reSpOnSaveL = new EntitySet<Responsavel>(Responsavel_Attach, Responsavel_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.professordisciplinasala")]
public partial class ProfessorDisciplinaSala : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnDataPeriodoChanged();
    partial void OnDataPeriodoChanging(DateTime? value);
    partial void OnDisciplinaIDChanged();
    partial void OnDisciplinaIDChanging(int? value);
    partial void OnFuncionarioIDChanged();
    partial void OnFuncionarioIDChanging(int? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnSalaPeriodoIDChanged();
    partial void OnSalaPeriodoIDChanging(int? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region DateTime? DataPeriodo

    private DateTime? _dataPeriodo;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPeriodo", Name = "DataPeriodo", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? DataPeriodo
    {
        get
        {
            return _dataPeriodo;
        }
        set
        {
            if (value != _dataPeriodo)
            {
                OnDataPeriodoChanging(value);
                SendPropertyChanging();
                _dataPeriodo = value;
                SendPropertyChanged("DataPeriodo");
                OnDataPeriodoChanged();
            }
        }
    }

    #endregion

    #region int? DisciplinaID

    private int? _disciplinaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_disciplinaID", Name = "DisciplinaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? DisciplinaID
    {
        get
        {
            return _disciplinaID;
        }
        set
        {
            if (value != _disciplinaID)
            {
                OnDisciplinaIDChanging(value);
                SendPropertyChanging();
                _disciplinaID = value;
                SendPropertyChanged("DisciplinaID");
                OnDisciplinaIDChanged();
            }
        }
    }

    #endregion

    #region int? FuncionarioID

    private int? _funcionarioID;
    [DebuggerNonUserCode]
    [Column(Storage = "_funcionarioID", Name = "FuncionarioId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? FuncionarioID
    {
        get
        {
            return _funcionarioID;
        }
        set
        {
            if (value != _funcionarioID)
            {
                OnFuncionarioIDChanging(value);
                SendPropertyChanging();
                _funcionarioID = value;
                SendPropertyChanged("FuncionarioID");
                OnFuncionarioIDChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int? SalaPeriodoID

    private int? _salaPeriodoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_salaPeriodoID", Name = "SalaPeriodoId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? SalaPeriodoID
    {
        get
        {
            return _salaPeriodoID;
        }
        set
        {
            if (value != _salaPeriodoID)
            {
                OnSalaPeriodoIDChanging(value);
                SendPropertyChanging();
                _salaPeriodoID = value;
                SendPropertyChanged("SalaPeriodoID");
                OnSalaPeriodoIDChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Dependencia> _dependEnCia;
    [Association(Storage = "_dependEnCia", OtherKey = "ProfessorDisciplinaSalaID", ThisKey = "ID", Name = "fk_Dependencia_ProfessorDisciplinaSala")]
    [DebuggerNonUserCode]
    public EntitySet<Dependencia> Dependencia
    {
        get
        {
            return _dependEnCia;
        }
        set
        {
            _dependEnCia = value;
        }
    }

    private EntitySet<Nota> _notA;
    [Association(Storage = "_notA", OtherKey = "ProfessorDisciplinaSalaID", ThisKey = "ID", Name = "fk_Nota_ProfessorDisciplinaSala")]
    [DebuggerNonUserCode]
    public EntitySet<Nota> Nota
    {
        get
        {
            return _notA;
        }
        set
        {
            _notA = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Disciplina> _discIpliNA;
    [Association(Storage = "_discIpliNA", OtherKey = "ID", ThisKey = "DisciplinaID", Name = "fk_ProfessorDisciplinaSala_Disciplina", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Disciplina Disciplina
    {
        get
        {
            return _discIpliNA.Entity;
        }
        set
        {
            if (value != _discIpliNA.Entity)
            {
                if (_discIpliNA.Entity != null)
                {
                    var previousDisciplina = _discIpliNA.Entity;
                    _discIpliNA.Entity = null;
                    previousDisciplina.ProfessorDisciplinaSala.Remove(this);
                }
                _discIpliNA.Entity = value;
                if (value != null)
                {
                    value.ProfessorDisciplinaSala.Add(this);
                    _disciplinaID = value.ID;
                }
                else
                {
                    _disciplinaID = null;
                }
            }
        }
    }

    private EntityRef<Funcionario> _funCiOnArIo;
    [Association(Storage = "_funCiOnArIo", OtherKey = "ID", ThisKey = "FuncionarioID", Name = "fk_ProfessorDisciplinaSala_Funcionario", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Funcionario Funcionario
    {
        get
        {
            return _funCiOnArIo.Entity;
        }
        set
        {
            if (value != _funCiOnArIo.Entity)
            {
                if (_funCiOnArIo.Entity != null)
                {
                    var previousFuncionario = _funCiOnArIo.Entity;
                    _funCiOnArIo.Entity = null;
                    previousFuncionario.ProfessorDisciplinaSala.Remove(this);
                }
                _funCiOnArIo.Entity = value;
                if (value != null)
                {
                    value.ProfessorDisciplinaSala.Add(this);
                    _funcionarioID = value.ID;
                }
                else
                {
                    _funcionarioID = null;
                }
            }
        }
    }

    private EntityRef<SalaPeriodo> _salApErIoDo;
    [Association(Storage = "_salApErIoDo", OtherKey = "ID", ThisKey = "SalaPeriodoID", Name = "fk_ProfessorDisciplinaSala_SalaPeriodo", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public SalaPeriodo SalaPeriodo
    {
        get
        {
            return _salApErIoDo.Entity;
        }
        set
        {
            if (value != _salApErIoDo.Entity)
            {
                if (_salApErIoDo.Entity != null)
                {
                    var previousSalaPeriodo = _salApErIoDo.Entity;
                    _salApErIoDo.Entity = null;
                    previousSalaPeriodo.ProfessorDisciplinaSala.Remove(this);
                }
                _salApErIoDo.Entity = value;
                if (value != null)
                {
                    value.ProfessorDisciplinaSala.Add(this);
                    _salaPeriodoID = value.ID;
                }
                else
                {
                    _salaPeriodoID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void Dependencia_Attach(Dependencia entity)
    {
        entity.ProfessorDisciplinaSala = this;
    }

    private void Dependencia_Detach(Dependencia entity)
    {
        entity.ProfessorDisciplinaSala = null;
    }

    private void Nota_Attach(Nota entity)
    {
        entity.ProfessorDisciplinaSala = this;
    }

    private void Nota_Detach(Nota entity)
    {
        entity.ProfessorDisciplinaSala = null;
    }


    #endregion

    #region ctor

    public ProfessorDisciplinaSala()
    {
        _dependEnCia = new EntitySet<Dependencia>(Dependencia_Attach, Dependencia_Detach);
        _notA = new EntitySet<Nota>(Nota_Attach, Nota_Detach);
        _discIpliNA = new EntityRef<Disciplina>();
        _funCiOnArIo = new EntityRef<Funcionario>();
        _salApErIoDo = new EntityRef<SalaPeriodo>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.responsavel")]
public partial class Responsavel : INotifyPropertyChanging, INotifyPropertyChanged
{
    public override string ToString()
    {

        return this.Nome;
    }

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
    partial void OnBairroChanged();
    partial void OnBairroChanging(string value);
    partial void OnCepChanged();
    partial void OnCepChanging(string value);
    partial void OnCidadeChanged();
    partial void OnCidadeChanging(string value);
    partial void OnComplementoEnderecoChanged();
    partial void OnComplementoEnderecoChanging(string value);
    partial void OnCpfChanged();
    partial void OnCpfChanging(string value);
    partial void OnEdificioChanged();
    partial void OnEdificioChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailChanging(string value);
    partial void OnFoneChanged();
    partial void OnFoneChanging(string value);
    partial void OnFoneOpcionalChanged();
    partial void OnFoneOpcionalChanging(string value);
    partial void OnFoneTrabalhoChanged();
    partial void OnFoneTrabalhoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnImagemChanged();
    partial void OnImagemChanging(Byte[] value);
    partial void OnLocalTrabalhoChanged();
    partial void OnLocalTrabalhoChanging(string value);
    partial void OnLoginChanged();
    partial void OnLoginChanging(string value);
    partial void OnLogradouroChanged();
    partial void OnLogradouroChanging(string value);
    partial void OnNascimentoChanged();
    partial void OnNascimentoChanging(DateTime? value);
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnPerfilIDChanged();
    partial void OnPerfilIDChanging(int? value);
    partial void OnProfissaoChanged();
    partial void OnProfissaoChanging(string value);
    partial void OnRgChanged();
    partial void OnRgChanging(string value);
    partial void OnSenhaChanged();
    partial void OnSenhaChanging(string value);
    partial void OnSexoChanged();
    partial void OnSexoChanging(sbyte? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnUfChanged();
    partial void OnUfChanging(string value);

    #endregion

    #region string Bairro

    private string _bairro;
    [DebuggerNonUserCode]
    [Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Bairro
    {
        get
        {
            return _bairro;
        }
        set
        {
            if (value != _bairro)
            {
                OnBairroChanging(value);
                SendPropertyChanging();
                _bairro = value;
                SendPropertyChanged("Bairro");
                OnBairroChanged();
            }
        }
    }

    #endregion

    #region string Cep

    private string _cep;
    [DebuggerNonUserCode]
    [Column(Storage = "_cep", Name = "Cep", DbType = "varchar(9)", AutoSync = AutoSync.Never)]
    public string Cep
    {
        get
        {
            return _cep;
        }
        set
        {
            if (value != _cep)
            {
                OnCepChanging(value);
                SendPropertyChanging();
                _cep = value;
                SendPropertyChanged("Cep");
                OnCepChanged();
            }
        }
    }

    #endregion

    #region string Cidade

    private string _cidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_cidade", Name = "Cidade", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Cidade
    {
        get
        {
            return _cidade;
        }
        set
        {
            if (value != _cidade)
            {
                OnCidadeChanging(value);
                SendPropertyChanging();
                _cidade = value;
                SendPropertyChanged("Cidade");
                OnCidadeChanged();
            }
        }
    }

    #endregion

    #region string ComplementoEndereco

    private string _complementoEndereco;
    [DebuggerNonUserCode]
    [Column(Storage = "_complementoEndereco", Name = "ComplementoEndereco", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string ComplementoEndereco
    {
        get
        {
            return _complementoEndereco;
        }
        set
        {
            if (value != _complementoEndereco)
            {
                OnComplementoEnderecoChanging(value);
                SendPropertyChanging();
                _complementoEndereco = value;
                SendPropertyChanged("ComplementoEndereco");
                OnComplementoEnderecoChanged();
            }
        }
    }

    #endregion

    #region string Cpf

    private string _cpf;
    [DebuggerNonUserCode]
    [Column(Storage = "_cpf", Name = "Cpf", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string Cpf
    {
        get
        {
            return _cpf;
        }
        set
        {
            if (value != _cpf)
            {
                OnCpfChanging(value);
                SendPropertyChanging();
                _cpf = value;
                SendPropertyChanged("Cpf");
                OnCpfChanged();
            }
        }
    }

    #endregion

    #region string Edificio

    private string _edificio;
    [DebuggerNonUserCode]
    [Column(Storage = "_edificio", Name = "Edificio", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Edificio
    {
        get
        {
            return _edificio;
        }
        set
        {
            if (value != _edificio)
            {
                OnEdificioChanging(value);
                SendPropertyChanging();
                _edificio = value;
                SendPropertyChanged("Edificio");
                OnEdificioChanged();
            }
        }
    }

    #endregion

    #region string Email

    private string _email;
    [DebuggerNonUserCode]
    [Column(Storage = "_email", Name = "Email", DbType = "varchar(40)", AutoSync = AutoSync.Never)]
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (value != _email)
            {
                OnEmailChanging(value);
                SendPropertyChanging();
                _email = value;
                SendPropertyChanged("Email");
                OnEmailChanged();
            }
        }
    }

    #endregion

    #region string Fone

    private string _fone;
    [DebuggerNonUserCode]
    [Column(Storage = "_fone", Name = "Fone", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string Fone
    {
        get
        {
            return _fone;
        }
        set
        {
            if (value != _fone)
            {
                OnFoneChanging(value);
                SendPropertyChanging();
                _fone = value;
                SendPropertyChanged("Fone");
                OnFoneChanged();
            }
        }
    }

    #endregion

    #region string FoneOpcional

    private string _foneOpcional;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneOpcional", Name = "FoneOpcional", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneOpcional
    {
        get
        {
            return _foneOpcional;
        }
        set
        {
            if (value != _foneOpcional)
            {
                OnFoneOpcionalChanging(value);
                SendPropertyChanging();
                _foneOpcional = value;
                SendPropertyChanged("FoneOpcional");
                OnFoneOpcionalChanged();
            }
        }
    }

    #endregion

    #region string FoneTrabalho

    private string _foneTrabalho;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneTrabalho", Name = "FoneTrabalho", DbType = "varchar(14)", AutoSync = AutoSync.Never)]
    public string FoneTrabalho
    {
        get
        {
            return _foneTrabalho;
        }
        set
        {
            if (value != _foneTrabalho)
            {
                OnFoneTrabalhoChanging(value);
                SendPropertyChanging();
                _foneTrabalho = value;
                SendPropertyChanged("FoneTrabalho");
                OnFoneTrabalhoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region Byte[] Imagem

    private Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob", AutoSync = AutoSync.Never)]
    public Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                OnImagemChanging(value);
                SendPropertyChanging();
                _imagem = value;
                SendPropertyChanged("Imagem");
                OnImagemChanged();
            }
        }
    }

    #endregion

    #region string LocalTrabalho

    private string _localTrabalho;
    [DebuggerNonUserCode]
    [Column(Storage = "_localTrabalho", Name = "LocalTrabalho", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string LocalTrabalho
    {
        get
        {
            return _localTrabalho;
        }
        set
        {
            if (value != _localTrabalho)
            {
                OnLocalTrabalhoChanging(value);
                SendPropertyChanging();
                _localTrabalho = value;
                SendPropertyChanged("LocalTrabalho");
                OnLocalTrabalhoChanged();
            }
        }
    }

    #endregion

    #region string Login

    private string _login;
    [DebuggerNonUserCode]
    [Column(Storage = "_login", Name = "Login", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
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

    #region string Logradouro

    private string _logradouro;
    [DebuggerNonUserCode]
    [Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(60)", AutoSync = AutoSync.Never)]
    public string Logradouro
    {
        get
        {
            return _logradouro;
        }
        set
        {
            if (value != _logradouro)
            {
                OnLogradouroChanging(value);
                SendPropertyChanging();
                _logradouro = value;
                SendPropertyChanged("Logradouro");
                OnLogradouroChanged();
            }
        }
    }

    #endregion

    #region DateTime? Nascimento

    private DateTime? _nascimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_nascimento", Name = "Nascimento", DbType = "datetime", AutoSync = AutoSync.Never)]
    public DateTime? Nascimento
    {
        get
        {
            return _nascimento;
        }
        set
        {
            if (value != _nascimento)
            {
                OnNascimentoChanging(value);
                SendPropertyChanging();
                _nascimento = value;
                SendPropertyChanged("Nascimento");
                OnNascimentoChanged();
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region int? PerfilID

    private int? _perfilID;
    [DebuggerNonUserCode]
    [Column(Storage = "_perfilID", Name = "PerfilId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? PerfilID
    {
        get
        {
            return _perfilID;
        }
        set
        {
            if (value != _perfilID)
            {
                OnPerfilIDChanging(value);
                SendPropertyChanging();
                _perfilID = value;
                SendPropertyChanged("PerfilID");
                OnPerfilIDChanged();
            }
        }
    }

    #endregion

    #region string Profissao

    private string _profissao;
    [DebuggerNonUserCode]
    [Column(Storage = "_profissao", Name = "Profissao", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Profissao
    {
        get
        {
            return _profissao;
        }
        set
        {
            if (value != _profissao)
            {
                OnProfissaoChanging(value);
                SendPropertyChanging();
                _profissao = value;
                SendPropertyChanged("Profissao");
                OnProfissaoChanged();
            }
        }
    }

    #endregion

    #region string Rg

    private string _rg;
    [DebuggerNonUserCode]
    [Column(Storage = "_rg", Name = "Rg", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
    public string Rg
    {
        get
        {
            return _rg;
        }
        set
        {
            if (value != _rg)
            {
                OnRgChanging(value);
                SendPropertyChanging();
                _rg = value;
                SendPropertyChanged("Rg");
                OnRgChanged();
            }
        }
    }

    #endregion

    #region string Senha

    private string _senha;
    [DebuggerNonUserCode]
    [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
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

    #region sbyte? Sexo

    private sbyte? _sexo;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexo", Name = "Sexo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Sexo
    {
        get
        {
            return _sexo;
        }
        set
        {
            if (value != _sexo)
            {
                OnSexoChanging(value);
                SendPropertyChanging();
                _sexo = value;
                SendPropertyChanged("Sexo");
                OnSexoChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region string Uf

    private string _uf;
    [DebuggerNonUserCode]
    [Column(Storage = "_uf", Name = "Uf", DbType = "varchar(2)", AutoSync = AutoSync.Never)]
    public string Uf
    {
        get
        {
            return _uf;
        }
        set
        {
            if (value != _uf)
            {
                OnUfChanging(value);
                SendPropertyChanging();
                _uf = value;
                SendPropertyChanged("Uf");
                OnUfChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<ResponsavelAluno> _reSpOnSaveLaLuNo;
    [Association(Storage = "_reSpOnSaveLaLuNo", OtherKey = "ResponsavelID", ThisKey = "ID", Name = "fk_ResponsavelAluno_Responsavel")]
    [DebuggerNonUserCode]
    public EntitySet<ResponsavelAluno> ResponsavelAluno
    {
        get
        {
            return _reSpOnSaveLaLuNo;
        }
        set
        {
            _reSpOnSaveLaLuNo = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Perfil> _perFiL;
    [Association(Storage = "_perFiL", OtherKey = "ID", ThisKey = "PerfilID", Name = "fk_Responsavel_Perfil", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Perfil Perfil
    {
        get
        {
            return _perFiL.Entity;
        }
        set
        {
            if (value != _perFiL.Entity)
            {
                if (_perFiL.Entity != null)
                {
                    var previousPerfil = _perFiL.Entity;
                    _perFiL.Entity = null;
                    previousPerfil.Responsavel.Remove(this);
                }
                _perFiL.Entity = value;
                if (value != null)
                {
                    value.Responsavel.Add(this);
                    _perfilID = value.ID;
                }
                else
                {
                    _perfilID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void ResponsavelAluno_Attach(ResponsavelAluno entity)
    {
        entity.Responsavel = this;
    }

    private void ResponsavelAluno_Detach(ResponsavelAluno entity)
    {
        entity.Responsavel = null;
    }


    #endregion

    #region ctor

    public Responsavel()
    {
        _reSpOnSaveLaLuNo = new EntitySet<ResponsavelAluno>(ResponsavelAluno_Attach, ResponsavelAluno_Detach);
        _perFiL = new EntityRef<Perfil>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.responsavelaluno")]
public partial class ResponsavelAluno : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAlunoIDChanged();
    partial void OnAlunoIDChanging(int value);
    partial void OnGrauParentescoChanged();
    partial void OnGrauParentescoChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnResideComChanged();
    partial void OnResideComChanging(sbyte? value);
    partial void OnResponsavelIDChanged();
    partial void OnResponsavelIDChanging(int value);
    partial void OnRestricoesChanged();
    partial void OnRestricoesChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int AlunoID

    private int _alunoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoID", Name = "AlunoId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int AlunoID
    {
        get
        {
            return _alunoID;
        }
        set
        {
            if (value != _alunoID)
            {
                OnAlunoIDChanging(value);
                SendPropertyChanging();
                _alunoID = value;
                SendPropertyChanged("AlunoID");
                OnAlunoIDChanged();
            }
        }
    }

    #endregion

    #region string GrauParentesco

    private string _grauParentesco;
    [DebuggerNonUserCode]
    [Column(Storage = "_grauParentesco", Name = "GrauParentesco", DbType = "varchar(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
    public string GrauParentesco
    {
        get
        {
            return _grauParentesco;
        }
        set
        {
            if (value != _grauParentesco)
            {
                OnGrauParentescoChanging(value);
                SendPropertyChanging();
                _grauParentesco = value;
                SendPropertyChanged("GrauParentesco");
                OnGrauParentescoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region sbyte? ResideCom

    private sbyte? _resideCom;
    [DebuggerNonUserCode]
    [Column(Storage = "_resideCom", Name = "ResideCom", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? ResideCom
    {
        get
        {
            return _resideCom;
        }
        set
        {
            if (value != _resideCom)
            {
                OnResideComChanging(value);
                SendPropertyChanging();
                _resideCom = value;
                SendPropertyChanged("ResideCom");
                OnResideComChanged();
            }
        }
    }

    #endregion

    #region int ResponsavelID

    private int _responsavelID;
    [DebuggerNonUserCode]
    [Column(Storage = "_responsavelID", Name = "ResponsavelId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int ResponsavelID
    {
        get
        {
            return _responsavelID;
        }
        set
        {
            if (value != _responsavelID)
            {
                OnResponsavelIDChanging(value);
                SendPropertyChanging();
                _responsavelID = value;
                SendPropertyChanged("ResponsavelID");
                OnResponsavelIDChanged();
            }
        }
    }

    #endregion

    #region string Restricoes

    private string _restricoes;
    [DebuggerNonUserCode]
    [Column(Storage = "_restricoes", Name = "Restricoes", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
    public string Restricoes
    {
        get
        {
            return _restricoes;
        }
        set
        {
            if (value != _restricoes)
            {
                OnRestricoesChanging(value);
                SendPropertyChanging();
                _restricoes = value;
                SendPropertyChanged("Restricoes");
                OnRestricoesChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Parents

    private EntityRef<Aluno> _alUNo;
    [Association(Storage = "_alUNo", OtherKey = "ID", ThisKey = "AlunoID", Name = "fk_ResponsavelAluno_Aluno", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Aluno Aluno
    {
        get
        {
            return _alUNo.Entity;
        }
        set
        {
            if (value != _alUNo.Entity)
            {
                if (_alUNo.Entity != null)
                {
                    var previousAluno = _alUNo.Entity;
                    _alUNo.Entity = null;
                    previousAluno.ResponsavelAluno.Remove(this);
                }
                _alUNo.Entity = value;
                if (value != null)
                {
                    value.ResponsavelAluno.Add(this);
                    _alunoID = value.ID;
                }
                else
                {
                    _alunoID = default(int);
                }
            }
        }
    }

    private EntityRef<Responsavel> _reSpOnSaveL;
    [Association(Storage = "_reSpOnSaveL", OtherKey = "ID", ThisKey = "ResponsavelID", Name = "fk_ResponsavelAluno_Responsavel", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Responsavel Responsavel
    {
        get
        {
            return _reSpOnSaveL.Entity;
        }
        set
        {
            if (value != _reSpOnSaveL.Entity)
            {
                if (_reSpOnSaveL.Entity != null)
                {
                    var previousResponsavel = _reSpOnSaveL.Entity;
                    _reSpOnSaveL.Entity = null;
                    previousResponsavel.ResponsavelAluno.Remove(this);
                }
                _reSpOnSaveL.Entity = value;
                if (value != null)
                {
                    value.ResponsavelAluno.Add(this);
                    _responsavelID = value.ID;
                }
                else
                {
                    _responsavelID = default(int);
                }
            }
        }
    }


    #endregion

    #region ctor

    public ResponsavelAluno()
    {
        _alUNo = new EntityRef<Aluno>();
        _reSpOnSaveL = new EntityRef<Responsavel>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.sala")]
public partial class Sala : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnCicloChanged();
    partial void OnCicloChanging(string value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnSerieIDChanged();
    partial void OnSerieIDChanging(int? value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);
    partial void OnTurmaIDChanged();
    partial void OnTurmaIDChanging(int? value);
    partial void OnTurnoIDChanged();
    partial void OnTurnoIDChanging(int? value);
    partial void OnValorChanged();
    partial void OnValorChanging(double? value);

    #endregion

    #region string Ciclo

    private string _ciclo;
    [DebuggerNonUserCode]
    [Column(Storage = "_ciclo", Name = "Ciclo", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
    public string Ciclo
    {
        get
        {
            return _ciclo;
        }
        set
        {
            if (value != _ciclo)
            {
                OnCicloChanging(value);
                SendPropertyChanging();
                _ciclo = value;
                SendPropertyChanged("Ciclo");
                OnCicloChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int? SerieID

    private int? _serieID;
    [DebuggerNonUserCode]
    [Column(Storage = "_serieID", Name = "SerieId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? SerieID
    {
        get
        {
            return _serieID;
        }
        set
        {
            if (value != _serieID)
            {
                OnSerieIDChanging(value);
                SendPropertyChanging();
                _serieID = value;
                SendPropertyChanged("SerieID");
                OnSerieIDChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region int? TurmaID

    private int? _turmaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_turmaID", Name = "TurmaId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? TurmaID
    {
        get
        {
            return _turmaID;
        }
        set
        {
            if (value != _turmaID)
            {
                OnTurmaIDChanging(value);
                SendPropertyChanging();
                _turmaID = value;
                SendPropertyChanged("TurmaID");
                OnTurmaIDChanged();
            }
        }
    }

    #endregion

    #region int? TurnoID

    private int? _turnoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_turnoID", Name = "TurnoId", DbType = "int", AutoSync = AutoSync.Never)]
    public int? TurnoID
    {
        get
        {
            return _turnoID;
        }
        set
        {
            if (value != _turnoID)
            {
                OnTurnoIDChanging(value);
                SendPropertyChanging();
                _turnoID = value;
                SendPropertyChanged("TurnoID");
                OnTurnoIDChanged();
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double", AutoSync = AutoSync.Never)]
    public double? Valor
    {
        get
        {
            return _valor;
        }
        set
        {
            if (value != _valor)
            {
                OnValorChanging(value);
                SendPropertyChanging();
                _valor = value;
                SendPropertyChanged("Valor");
                OnValorChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<SalaPeriodo> _salApErIoDo;
    [Association(Storage = "_salApErIoDo", OtherKey = "SalaID", ThisKey = "ID", Name = "fk_SalaPeriodo_Sala")]
    [DebuggerNonUserCode]
    public EntitySet<SalaPeriodo> SalaPeriodo
    {
        get
        {
            return _salApErIoDo;
        }
        set
        {
            _salApErIoDo = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Serie> _seRie;
    [Association(Storage = "_seRie", OtherKey = "ID", ThisKey = "SerieID", Name = "fk_Sala_Serie", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Serie Serie
    {
        get
        {
            return _seRie.Entity;
        }
        set
        {
            if (value != _seRie.Entity)
            {
                if (_seRie.Entity != null)
                {
                    var previousSerie = _seRie.Entity;
                    _seRie.Entity = null;
                    previousSerie.Sala.Remove(this);
                }
                _seRie.Entity = value;
                if (value != null)
                {
                    value.Sala.Add(this);
                    _serieID = value.ID;
                }
                else
                {
                    _serieID = null;
                }
            }
        }
    }

    private EntityRef<Turma> _turmA;
    [Association(Storage = "_turmA", OtherKey = "ID", ThisKey = "TurmaID", Name = "fk_Sala_Turma", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Turma Turma
    {
        get
        {
            return _turmA.Entity;
        }
        set
        {
            if (value != _turmA.Entity)
            {
                if (_turmA.Entity != null)
                {
                    var previousTurma = _turmA.Entity;
                    _turmA.Entity = null;
                    previousTurma.Sala.Remove(this);
                }
                _turmA.Entity = value;
                if (value != null)
                {
                    value.Sala.Add(this);
                    _turmaID = value.ID;
                }
                else
                {
                    _turmaID = null;
                }
            }
        }
    }

    private EntityRef<Turno> _turnO;
    [Association(Storage = "_turnO", OtherKey = "ID", ThisKey = "TurnoID", Name = "fk_Sala_Turno", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Turno Turno
    {
        get
        {
            return _turnO.Entity;
        }
        set
        {
            if (value != _turnO.Entity)
            {
                if (_turnO.Entity != null)
                {
                    var previousTurno = _turnO.Entity;
                    _turnO.Entity = null;
                    previousTurno.Sala.Remove(this);
                }
                _turnO.Entity = value;
                if (value != null)
                {
                    value.Sala.Add(this);
                    _turnoID = value.ID;
                }
                else
                {
                    _turnoID = null;
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void SalaPeriodo_Attach(SalaPeriodo entity)
    {
        entity.Sala = this;
    }

    private void SalaPeriodo_Detach(SalaPeriodo entity)
    {
        entity.Sala = null;
    }


    #endregion

    #region ctor

    public Sala()
    {
        _salApErIoDo = new EntitySet<SalaPeriodo>(SalaPeriodo_Attach, SalaPeriodo_Detach);
        _seRie = new EntityRef<Serie>();
        _turmA = new EntityRef<Turma>();
        _turnO = new EntityRef<Turno>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.salaperiodo")]
public partial class SalaPeriodo : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnAnoChanged();
    partial void OnAnoChanging(int? value);
    partial void OnIDChanged();
    partial void OnIDChanging(int value);
    partial void OnSalaIDChanged();
    partial void OnSalaIDChanging(int value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int? Ano

    private int? _ano;
    [DebuggerNonUserCode]
    [Column(Storage = "_ano", Name = "Ano", DbType = "int", AutoSync = AutoSync.Never)]
    public int? Ano
    {
        get
        {
            return _ano;
        }
        set
        {
            if (value != _ano)
            {
                OnAnoChanging(value);
                SendPropertyChanging();
                _ano = value;
                SendPropertyChanged("Ano");
                OnAnoChanged();
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region int SalaID

    private int _salaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_salaID", Name = "SalaId", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
    public int SalaID
    {
        get
        {
            return _salaID;
        }
        set
        {
            if (value != _salaID)
            {
                OnSalaIDChanging(value);
                SendPropertyChanging();
                _salaID = value;
                SendPropertyChanged("SalaID");
                OnSalaIDChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", OtherKey = "SalaPeriodoID", ThisKey = "ID", Name = "fk_Matricula_SalaPeriodo")]
    [DebuggerNonUserCode]
    public EntitySet<Matricula> Matricula
    {
        get
        {
            return _matRiCuLa;
        }
        set
        {
            _matRiCuLa = value;
        }
    }

    private EntitySet<ProfessorDisciplinaSala> _professorDiscIpliNAsAla;
    [Association(Storage = "_professorDiscIpliNAsAla", OtherKey = "SalaPeriodoID", ThisKey = "ID", Name = "fk_ProfessorDisciplinaSala_SalaPeriodo")]
    [DebuggerNonUserCode]
    public EntitySet<ProfessorDisciplinaSala> ProfessorDisciplinaSala
    {
        get
        {
            return _professorDiscIpliNAsAla;
        }
        set
        {
            _professorDiscIpliNAsAla = value;
        }
    }


    #endregion

    #region Parents

    private EntityRef<Sala> _salA;
    [Association(Storage = "_salA", OtherKey = "ID", ThisKey = "SalaID", Name = "fk_SalaPeriodo_Sala", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Sala Sala
    {
        get
        {
            return _salA.Entity;
        }
        set
        {
            if (value != _salA.Entity)
            {
                if (_salA.Entity != null)
                {
                    var previousSala = _salA.Entity;
                    _salA.Entity = null;
                    previousSala.SalaPeriodo.Remove(this);
                }
                _salA.Entity = value;
                if (value != null)
                {
                    value.SalaPeriodo.Add(this);
                    _salaID = value.ID;
                }
                else
                {
                    _salaID = default(int);
                }
            }
        }
    }


    #endregion

    #region Attachement handlers

    private void Matricula_Attach(Matricula entity)
    {
        entity.SalaPeriodo = this;
    }

    private void Matricula_Detach(Matricula entity)
    {
        entity.SalaPeriodo = null;
    }

    private void ProfessorDisciplinaSala_Attach(ProfessorDisciplinaSala entity)
    {
        entity.SalaPeriodo = this;
    }

    private void ProfessorDisciplinaSala_Detach(ProfessorDisciplinaSala entity)
    {
        entity.SalaPeriodo = null;
    }


    #endregion

    #region ctor

    public SalaPeriodo()
    {
        _matRiCuLa = new EntitySet<Matricula>(Matricula_Attach, Matricula_Detach);
        _professorDiscIpliNAsAla = new EntitySet<ProfessorDisciplinaSala>(ProfessorDisciplinaSala_Attach, ProfessorDisciplinaSala_Detach);
        _salA = new EntityRef<Sala>();
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.serie")]
public partial class Serie : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Sala> _salA;
    [Association(Storage = "_salA", OtherKey = "SerieID", ThisKey = "ID", Name = "fk_Sala_Serie")]
    [DebuggerNonUserCode]
    public EntitySet<Sala> Sala
    {
        get
        {
            return _salA;
        }
        set
        {
            _salA = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void Sala_Attach(Sala entity)
    {
        entity.Serie = this;
    }

    private void Sala_Detach(Sala entity)
    {
        entity.Serie = null;
    }


    #endregion

    #region ctor

    public Serie()
    {
        _salA = new EntitySet<Sala>(Sala_Attach, Sala_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.turma")]
public partial class Turma : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Sala> _salA;
    [Association(Storage = "_salA", OtherKey = "TurmaID", ThisKey = "ID", Name = "fk_Sala_Turma")]
    [DebuggerNonUserCode]
    public EntitySet<Sala> Sala
    {
        get
        {
            return _salA;
        }
        set
        {
            _salA = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void Sala_Attach(Sala entity)
    {
        entity.Turma = this;
    }

    private void Sala_Detach(Sala entity)
    {
        entity.Turma = null;
    }


    #endregion

    #region ctor

    public Turma()
    {
        _salA = new EntitySet<Sala>(Sala_Attach, Sala_Detach);
        OnCreated();
    }

    #endregion

}

[Table(Name = "ColegioDB.turno")]
public partial class Turno : INotifyPropertyChanging, INotifyPropertyChanged
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
    partial void OnNomeChanged();
    partial void OnNomeChanging(string value);
    partial void OnStatusChanged();
    partial void OnStatusChanging(sbyte? value);

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
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

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value != _nome)
            {
                OnNomeChanging(value);
                SendPropertyChanging();
                _nome = value;
                SendPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
    }

    #endregion

    #region sbyte? Status

    private sbyte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
    public sbyte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                OnStatusChanging(value);
                SendPropertyChanging();
                _status = value;
                SendPropertyChanged("Status");
                OnStatusChanged();
            }
        }
    }

    #endregion

    #region Children

    private EntitySet<Sala> _salA;
    [Association(Storage = "_salA", OtherKey = "TurnoID", ThisKey = "ID", Name = "fk_Sala_Turno")]
    [DebuggerNonUserCode]
    public EntitySet<Sala> Sala
    {
        get
        {
            return _salA;
        }
        set
        {
            _salA = value;
        }
    }


    #endregion

    #region Attachement handlers

    private void Sala_Attach(Sala entity)
    {
        entity.Turno = this;
    }

    private void Sala_Detach(Sala entity)
    {
        entity.Turno = null;
    }


    #endregion

    #region ctor

    public Turno()
    {
        _salA = new EntitySet<Sala>(Sala_Attach, Sala_Detach);
        OnCreated();
    }

    #endregion

}
