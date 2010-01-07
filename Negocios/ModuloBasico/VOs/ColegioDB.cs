#region Auto-generated classes for colegiodb database on 2010-01-02 21:53:01Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from colegiodb on 2010-01-02 21:53:01Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;



public partial class ColegioDB : DbLinq.Data.Linq.DataContext
{
    public ColegioDB(System.Data.IDbConnection connection)
        : base(connection, new DbLinq.MySql.MySqlVendor())
    {
    }

    public ColegioDB(System.Data.IDbConnection connection, DbLinq.Vendor.IVendor vendor)
        : base(connection, vendor)
    {
    }

    public DbLinq.Data.Linq.Table<Aluno> Aluno { get { return GetTable<Aluno>(); } }
    public DbLinq.Data.Linq.Table<AlunoAtividade> AlunoAtividade { get { return GetTable<AlunoAtividade>(); } }
    public DbLinq.Data.Linq.Table<Atividade> Atividade { get { return GetTable<Atividade>(); } }
    public DbLinq.Data.Linq.Table<AtividadeData> AtividadeData { get { return GetTable<AtividadeData>(); } }
    public DbLinq.Data.Linq.Table<BoletoAtividade> BoletoAtividade { get { return GetTable<BoletoAtividade>(); } }
    public DbLinq.Data.Linq.Table<BoletoMensalidade> BoletoMensalidade { get { return GetTable<BoletoMensalidade>(); } }
    public DbLinq.Data.Linq.Table<Cheque> Cheque { get { return GetTable<Cheque>(); } }
    public DbLinq.Data.Linq.Table<ChequeBoletoAtividade> ChequeBoletoAtividade { get { return GetTable<ChequeBoletoAtividade>(); } }
    public DbLinq.Data.Linq.Table<ChequeBoletoMensalidade> ChequeBoletoMensalidade { get { return GetTable<ChequeBoletoMensalidade>(); } }
    public DbLinq.Data.Linq.Table<ContasAPagar> ContasAPagar { get { return GetTable<ContasAPagar>(); } }
    public DbLinq.Data.Linq.Table<Dependencia> Dependencia { get { return GetTable<Dependencia>(); } }
    public DbLinq.Data.Linq.Table<Desconto> Desconto { get { return GetTable<Desconto>(); } }
    public DbLinq.Data.Linq.Table<Disciplina> Disciplina { get { return GetTable<Disciplina>(); } }
    public DbLinq.Data.Linq.Table<Funcionario> Funcionario { get { return GetTable<Funcionario>(); } }
    public DbLinq.Data.Linq.Table<Matricula> Matricula { get { return GetTable<Matricula>(); } }
    public DbLinq.Data.Linq.Table<Nota> Nota { get { return GetTable<Nota>(); } }
    public DbLinq.Data.Linq.Table<Perfil> Perfil { get { return GetTable<Perfil>(); } }
    public DbLinq.Data.Linq.Table<ProfessorDisciplinaSala> ProfessorDisciplinaSala { get { return GetTable<ProfessorDisciplinaSala>(); } }
    public DbLinq.Data.Linq.Table<Responsavel> Responsavel { get { return GetTable<Responsavel>(); } }
    public DbLinq.Data.Linq.Table<ResponsavelAluno> ResponsavelAluno { get { return GetTable<ResponsavelAluno>(); } }
    public DbLinq.Data.Linq.Table<Sala> Sala { get { return GetTable<Sala>(); } }
    public DbLinq.Data.Linq.Table<SalaPeriodo> SalaPeriodo { get { return GetTable<SalaPeriodo>(); } }
    public DbLinq.Data.Linq.Table<Serie> Serie { get { return GetTable<Serie>(); } }
    public DbLinq.Data.Linq.Table<Turma> Turma { get { return GetTable<Turma>(); } }
    public DbLinq.Data.Linq.Table<Turno> Turno { get { return GetTable<Turno>(); } }

}

[Table(Name = "colegiodb.aluno")]
public partial class Aluno : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region string Alergico

    private string _alergico;
    [DebuggerNonUserCode]
    [Column(Storage = "_alergico", Name = "Alergico", DbType = "varchar(100)")]
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
                _alergico = value;
                OnPropertyChanged("Alergico");
            }
        }
    }

    #endregion

    #region string Bairro

    private string _bairro;
    [DebuggerNonUserCode]
    [Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(30)")]
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
                _bairro = value;
                OnPropertyChanged("Bairro");
            }
        }
    }

    #endregion

    #region string Cep

    private string _cep;
    [DebuggerNonUserCode]
    [Column(Storage = "_cep", Name = "Cep", DbType = "varchar(9)")]
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
                _cep = value;
                OnPropertyChanged("Cep");
            }
        }
    }

    #endregion

    #region string Cidade

    private string _cidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_cidade", Name = "Cidade", DbType = "varchar(30)")]
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
                _cidade = value;
                OnPropertyChanged("Cidade");
            }
        }
    }

    #endregion

    #region string ComplementoEndereco

    private string _complementoEndereco;
    [DebuggerNonUserCode]
    [Column(Storage = "_complementoEndereco", Name = "ComplementoEndereco", DbType = "varchar(30)")]
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
                _complementoEndereco = value;
                OnPropertyChanged("ComplementoEndereco");
            }
        }
    }

    #endregion

    #region string ContatoNome

    private string _contatoNome;
    [DebuggerNonUserCode]
    [Column(Storage = "_contatoNome", Name = "ContatoNome", DbType = "varchar(45)")]
    public string ContatoNome
    {
        get
        {
            return _contatoNome;
        }
        set
        {
            if (value != _contatoNome)
            {
                _contatoNome = value;
                OnPropertyChanged("ContatoNome");
            }
        }
    }

    #endregion

    #region string ContatoTelefone

    private string _contatoTelefone;
    [DebuggerNonUserCode]
    [Column(Storage = "_contatoTelefone", Name = "ContatoTelefone", DbType = "varchar(45)")]
    public string ContatoTelefone
    {
        get
        {
            return _contatoTelefone;
        }
        set
        {
            if (value != _contatoTelefone)
            {
                _contatoTelefone = value;
                OnPropertyChanged("ContatoTelefone");
            }
        }
    }

    #endregion

    #region string DescricaoMedica

    private string _descricaoMedica;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricaoMedica", Name = "DescricaoMedica", DbType = "varchar(300)")]
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
                _descricaoMedica = value;
                OnPropertyChanged("DescricaoMedica");
            }
        }
    }

    #endregion

    #region string Email

    private string _email;
    [DebuggerNonUserCode]
    [Column(Storage = "_email", Name = "Email", DbType = "varchar(40)")]
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
                _email = value;
                OnPropertyChanged("Email");
            }
        }
    }

    #endregion

    #region byte? FatorRh

    private byte? _fatorRh;
    [DebuggerNonUserCode]
    [Column(Storage = "_fatorRh", Name = "FatorRh", DbType = "tinyint(1)")]
    public byte? FatorRh
    {
        get
        {
            return _fatorRh;
        }
        set
        {
            if (value != _fatorRh)
            {
                _fatorRh = value;
                OnPropertyChanged("FatorRh");
            }
        }
    }

    #endregion

    #region string FoneAluno

    private string _foneAluno;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneAluno", Name = "FoneAluno", DbType = "varchar(14)")]
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
                _foneAluno = value;
                OnPropertyChanged("FoneAluno");
            }
        }
    }

    #endregion

    #region string FoneEmergencia

    private string _foneEmergencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneEmergencia", Name = "FoneEmergencia", DbType = "varchar(14)")]
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
                _foneEmergencia = value;
                OnPropertyChanged("FoneEmergencia");
            }
        }
    }

    #endregion

    #region string FoneMedico

    private string _foneMedico;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneMedico", Name = "FoneMedico", DbType = "varchar(14)")]
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
                _foneMedico = value;
                OnPropertyChanged("FoneMedico");
            }
        }
    }

    #endregion

    #region string FoneResidencia

    private string _foneResidencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneResidencia", Name = "FoneResidencia", DbType = "varchar(14)")]
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
                _foneResidencia = value;
                OnPropertyChanged("FoneResidencia");
            }
        }
    }

    #endregion

    #region string GrupoSanguineo

    private string _grupoSanguineo;
    [DebuggerNonUserCode]
    [Column(Storage = "_grupoSanguineo", Name = "GrupoSanguineo", DbType = "varchar(3)")]
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
                _grupoSanguineo = value;
                OnPropertyChanged("GrupoSanguineo");
            }
        }
    }

    #endregion

    #region string Hospital

    private string _hospital;
    [DebuggerNonUserCode]
    [Column(Storage = "_hospital", Name = "Hospital", DbType = "varchar(30)")]
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
                _hospital = value;
                OnPropertyChanged("Hospital");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region System.Byte[] Imagem

    private System.Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob")]
    public System.Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                _imagem = value;
                OnPropertyChanged("Imagem");
            }
        }
    }

    #endregion

    #region string Login

    private string _login;
    [DebuggerNonUserCode]
    [Column(Storage = "_login", Name = "Login", DbType = "varchar(30)")]
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
                _login = value;
                OnPropertyChanged("Login");
            }
        }
    }

    #endregion

    #region string Logradouro

    private string _logradouro;
    [DebuggerNonUserCode]
    [Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(60)")]
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
                _logradouro = value;
                OnPropertyChanged("Logradouro");
            }
        }
    }

    #endregion

    #region string Nacionalidade

    private string _nacionalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_nacionalidade", Name = "Nacionalidade", DbType = "varchar(30)")]
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
                _nacionalidade = value;
                OnPropertyChanged("Nacionalidade");
            }
        }
    }

    #endregion

    #region System.DateTime? Nascimento

    private System.DateTime? _nascimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_nascimento", Name = "Nascimento", DbType = "datetime")]
    public System.DateTime? Nascimento
    {
        get
        {
            return _nascimento;
        }
        set
        {
            if (value != _nascimento)
            {
                _nascimento = value;
                OnPropertyChanged("Nascimento");
            }
        }
    }

    #endregion

    #region string Naturalidade

    private string _naturalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_naturalidade", Name = "Naturalidade", DbType = "varchar(30)")]
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
                _naturalidade = value;
                OnPropertyChanged("Naturalidade");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", CanBeNull = false)]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region string NomeMedico

    private string _nomeMedico;
    [DebuggerNonUserCode]
    [Column(Storage = "_nomeMedico", Name = "NomeMedico", DbType = "varchar(50)")]
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
                _nomeMedico = value;
                OnPropertyChanged("NomeMedico");
            }
        }
    }

    #endregion

    #region int PerfilID

    private int _perfilID;
    [DebuggerNonUserCode]
    [Column(Storage = "_perfilID", Name = "PerfilId", DbType = "int", CanBeNull = false)]
    public int PerfilID
    {
        get
        {
            return _perfilID;
        }
        set
        {
            if (value != _perfilID)
            {
                _perfilID = value;
                OnPropertyChanged("PerfilID");
            }
        }
    }

    #endregion

    #region string PlanoSaude

    private string _planoSaude;
    [DebuggerNonUserCode]
    [Column(Storage = "_planoSaude", Name = "PlanoSaude", DbType = "varchar(30)")]
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
                _planoSaude = value;
                OnPropertyChanged("PlanoSaude");
            }
        }
    }

    #endregion

    #region string Senha

    private string _senha;
    [DebuggerNonUserCode]
    [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(20)")]
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
                _senha = value;
                OnPropertyChanged("Senha");
            }
        }
    }

    #endregion

    #region byte? Sexo

    private byte? _sexo;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexo", Name = "Sexo", DbType = "tinyint(1)")]
    public byte? Sexo
    {
        get
        {
            return _sexo;
        }
        set
        {
            if (value != _sexo)
            {
                _sexo = value;
                OnPropertyChanged("Sexo");
            }
        }
    }

    #endregion

    #region string SituacaoEspecial

    private string _situacaoEspecial;
    [DebuggerNonUserCode]
    [Column(Storage = "_situacaoEspecial", Name = "SituacaoEspecial", DbType = "varchar(300)")]
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
                _situacaoEspecial = value;
                OnPropertyChanged("SituacaoEspecial");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region string Uf

    private string _uf;
    [DebuggerNonUserCode]
    [Column(Storage = "_uf", Name = "Uf", DbType = "varchar(2)")]
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
                _uf = value;
                OnPropertyChanged("Uf");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.alunoatividade")]
public partial class AlunoAtividade : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint? AlunoID

    private uint? _alunoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoID", Name = "AlunoId", DbType = "int unsigned")]
    public uint? AlunoID
    {
        get
        {
            return _alunoID;
        }
        set
        {
            if (value != _alunoID)
            {
                _alunoID = value;
                OnPropertyChanged("AlunoID");
            }
        }
    }

    #endregion

    #region uint? AtividadeID

    private uint? _atividadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_atividadeID", Name = "AtividadeId", DbType = "int unsigned")]
    public uint? AtividadeID
    {
        get
        {
            return _atividadeID;
        }
        set
        {
            if (value != _atividadeID)
            {
                _atividadeID = value;
                OnPropertyChanged("AtividadeID");
            }
        }
    }

    #endregion

    #region uint? DescontoID

    private uint? _descontoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_descontoID", Name = "DescontoId", DbType = "int unsigned")]
    public uint? DescontoID
    {
        get
        {
            return _descontoID;
        }
        set
        {
            if (value != _descontoID)
            {
                _descontoID = value;
                OnPropertyChanged("DescontoID");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.atividade")]
public partial class Atividade : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(100)")]
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
                _descricao = value;
                OnPropertyChanged("Descricao");
            }
        }
    }

    #endregion

    #region uint? FuncionarioID

    private uint? _funcionarioID;
    [DebuggerNonUserCode]
    [Column(Storage = "_funcionarioID", Name = "FuncionarioId", DbType = "int unsigned")]
    public uint? FuncionarioID
    {
        get
        {
            return _funcionarioID;
        }
        set
        {
            if (value != _funcionarioID)
            {
                _funcionarioID = value;
                OnPropertyChanged("FuncionarioID");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region System.Byte[] Imagem

    private System.Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob")]
    public System.Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                _imagem = value;
                OnPropertyChanged("Imagem");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)")]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double")]
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
                _valor = value;
                OnPropertyChanged("Valor");
            }
        }
    }

    #endregion

    #region Children

    [Association(Storage = null, OtherKey = "AtividadeID", Name = "fk_AtividadeData_Atividade")]
    [DebuggerNonUserCode]
    public EntitySet<AtividadeData> AtividadeData
    {
        get;
        set;
    }


    #endregion

}

[Table(Name = "colegiodb.atividadedata")]
public partial class AtividadeData : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint? AtividadeID

    private uint? _atividadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_atividadeID", Name = "AtividadeId", DbType = "int unsigned")]
    public uint? AtividadeID
    {
        get
        {
            return _atividadeID;
        }
        set
        {
            if (value != _atividadeID)
            {
                _atividadeID = value;
                OnPropertyChanged("AtividadeID");
            }
        }
    }

    #endregion

    #region System.DateTime? DiaSemana

    private System.DateTime? _diaSemana;
    [DebuggerNonUserCode]
    [Column(Storage = "_diaSemana", Name = "DiaSemana", DbType = "date")]
    public System.DateTime? DiaSemana
    {
        get
        {
            return _diaSemana;
        }
        set
        {
            if (value != _diaSemana)
            {
                _diaSemana = value;
                OnPropertyChanged("DiaSemana");
            }
        }
    }

    #endregion

    #region System.DateTime? HoraFim

    private System.DateTime? _horaFim;
    [DebuggerNonUserCode]
    [Column(Storage = "_horaFim", Name = "HoraFim", DbType = "time")]
    public System.DateTime? HoraFim
    {
        get
        {
            return _horaFim;
        }
        set
        {
            if (value != _horaFim)
            {
                _horaFim = value;
                OnPropertyChanged("HoraFim");
            }
        }
    }

    #endregion

    #region System.DateTime? HoraInicio

    private System.DateTime? _horaInicio;
    [DebuggerNonUserCode]
    [Column(Storage = "_horaInicio", Name = "HoraInicio", DbType = "time")]
    public System.DateTime? HoraInicio
    {
        get
        {
            return _horaInicio;
        }
        set
        {
            if (value != _horaInicio)
            {
                _horaInicio = value;
                OnPropertyChanged("HoraInicio");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region Parents

    private System.Data.Linq.EntityRef<Atividade> _atIvIDade;
    [Association(Storage = "_atIvIDade", ThisKey = "AtividadeID", Name = "fk_AtividadeData_Atividade", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Atividade Atividade
    {
        get
        {
            return _atIvIDade.Entity;
        }
        set
        {
            _atIvIDade.Entity = value;
        }
    }


    #endregion

}

[Table(Name = "colegiodb.boletoatividade")]
public partial class BoletoAtividade : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region System.DateTime DataEmissao

    private System.DateTime _dataEmissao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataEmissao", Name = "DataEmissao", DbType = "datetime", CanBeNull = false)]
    public System.DateTime DataEmissao
    {
        get
        {
            return _dataEmissao;
        }
        set
        {
            if (value != _dataEmissao)
            {
                _dataEmissao = value;
                OnPropertyChanged("DataEmissao");
            }
        }
    }

    #endregion

    #region System.DateTime? DataPagamento

    private System.DateTime? _dataPagamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPagamento", Name = "DataPagamento", DbType = "datetime")]
    public System.DateTime? DataPagamento
    {
        get
        {
            return _dataPagamento;
        }
        set
        {
            if (value != _dataPagamento)
            {
                _dataPagamento = value;
                OnPropertyChanged("DataPagamento");
            }
        }
    }

    #endregion

    #region System.DateTime DataVencimento

    private System.DateTime _dataVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVencimento", Name = "DataVencimento", DbType = "datetime", CanBeNull = false)]
    public System.DateTime DataVencimento
    {
        get
        {
            return _dataVencimento;
        }
        set
        {
            if (value != _dataVencimento)
            {
                _dataVencimento = value;
                OnPropertyChanged("DataVencimento");
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double")]
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
                _desconto = value;
                OnPropertyChanged("Desconto");
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", CanBeNull = false)]
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
                _descricao = value;
                OnPropertyChanged("Descricao");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint? MatriculaID

    private uint? _matriculaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaID", Name = "MatriculaId", DbType = "int unsigned")]
    public uint? MatriculaID
    {
        get
        {
            return _matriculaID;
        }
        set
        {
            if (value != _matriculaID)
            {
                _matriculaID = value;
                OnPropertyChanged("MatriculaID");
            }
        }
    }

    #endregion

    #region double? Multa

    private double? _multa;
    [DebuggerNonUserCode]
    [Column(Storage = "_multa", Name = "Multa", DbType = "double")]
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
                _multa = value;
                OnPropertyChanged("Multa");
            }
        }
    }

    #endregion

    #region int? Parcela

    private int? _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "int")]
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
                _parcela = value;
                OnPropertyChanged("Parcela");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region Parents

    private System.Data.Linq.EntityRef<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", ThisKey = "MatriculaID", Name = "fk_BoletoAtividade_Matricula", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula Matricula
    {
        get
        {
            return _matRiCuLa.Entity;
        }
        set
        {
            _matRiCuLa.Entity = value;
        }
    }


    #endregion

}

[Table(Name = "colegiodb.boletomensalidade")]
public partial class BoletoMensalidade : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region System.DateTime DataEmissao

    private System.DateTime _dataEmissao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataEmissao", Name = "DataEmissao", DbType = "datetime", CanBeNull = false)]
    public System.DateTime DataEmissao
    {
        get
        {
            return _dataEmissao;
        }
        set
        {
            if (value != _dataEmissao)
            {
                _dataEmissao = value;
                OnPropertyChanged("DataEmissao");
            }
        }
    }

    #endregion

    #region System.DateTime? DataPagamento

    private System.DateTime? _dataPagamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPagamento", Name = "DataPagamento", DbType = "datetime")]
    public System.DateTime? DataPagamento
    {
        get
        {
            return _dataPagamento;
        }
        set
        {
            if (value != _dataPagamento)
            {
                _dataPagamento = value;
                OnPropertyChanged("DataPagamento");
            }
        }
    }

    #endregion

    #region System.DateTime DataVencimento

    private System.DateTime _dataVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVencimento", Name = "DataVencimento", DbType = "datetime", CanBeNull = false)]
    public System.DateTime DataVencimento
    {
        get
        {
            return _dataVencimento;
        }
        set
        {
            if (value != _dataVencimento)
            {
                _dataVencimento = value;
                OnPropertyChanged("DataVencimento");
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double")]
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
                _desconto = value;
                OnPropertyChanged("Desconto");
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", CanBeNull = false)]
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
                _descricao = value;
                OnPropertyChanged("Descricao");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint? MatriculaID

    private uint? _matriculaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaID", Name = "MatriculaId", DbType = "int unsigned")]
    public uint? MatriculaID
    {
        get
        {
            return _matriculaID;
        }
        set
        {
            if (value != _matriculaID)
            {
                _matriculaID = value;
                OnPropertyChanged("MatriculaID");
            }
        }
    }

    #endregion

    #region double? Multa

    private double? _multa;
    [DebuggerNonUserCode]
    [Column(Storage = "_multa", Name = "Multa", DbType = "double")]
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
                _multa = value;
                OnPropertyChanged("Multa");
            }
        }
    }

    #endregion

    #region int? Parcela

    private int? _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "int")]
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
                _parcela = value;
                OnPropertyChanged("Parcela");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region Parents

    private System.Data.Linq.EntityRef<Matricula> _matRiCuLa;
    [Association(Storage = "_matRiCuLa", ThisKey = "MatriculaID", Name = "fk_BoletoMensalidade_Matricula", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Matricula Matricula
    {
        get
        {
            return _matRiCuLa.Entity;
        }
        set
        {
            _matRiCuLa.Entity = value;
        }
    }


    #endregion

}

[Table(Name = "colegiodb.cheque")]
public partial class Cheque : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region string Agencia

    private string _agencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_agencia", Name = "Agencia", DbType = "varchar(50)")]
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
                _agencia = value;
                OnPropertyChanged("Agencia");
            }
        }
    }

    #endregion

    #region string Banco

    private string _banco;
    [DebuggerNonUserCode]
    [Column(Storage = "_banco", Name = "Banco", DbType = "varchar(45)")]
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
                _banco = value;
                OnPropertyChanged("Banco");
            }
        }
    }

    #endregion

    #region string Conta

    private string _conta;
    [DebuggerNonUserCode]
    [Column(Storage = "_conta", Name = "Conta", DbType = "varchar(45)")]
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
                _conta = value;
                OnPropertyChanged("Conta");
            }
        }
    }

    #endregion

    #region string Cpf

    private string _cpf;
    [DebuggerNonUserCode]
    [Column(Storage = "_cpf", Name = "Cpf", DbType = "varchar(11)", CanBeNull = false)]
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
                _cpf = value;
                OnPropertyChanged("Cpf");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region int? NumCheque

    private int? _numCheque;
    [DebuggerNonUserCode]
    [Column(Storage = "_numCheque", Name = "NumCheque", DbType = "int")]
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
                _numCheque = value;
                OnPropertyChanged("NumCheque");
            }
        }
    }

    #endregion

    #region int? Parcela

    private int? _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "int")]
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
                _parcela = value;
                OnPropertyChanged("Parcela");
            }
        }
    }

    #endregion

    #region int Tipo

    private int _tipo;
    [DebuggerNonUserCode]
    [Column(Storage = "_tipo", Name = "Tipo", DbType = "int", CanBeNull = false)]
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
                _tipo = value;
                OnPropertyChanged("Tipo");
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double")]
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
                _valor = value;
                OnPropertyChanged("Valor");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.chequeboletoatividade")]
public partial class ChequeBoletoAtividade : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region int BoletoAtividadeID

    private int _boletoAtividadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_boletoAtividadeID", Name = "BoletoAtividadeId", DbType = "int",  CanBeNull = false)]
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
                _boletoAtividadeID = value;
                OnPropertyChanged("BoletoAtividadeID");
            }
        }
    }

    #endregion

    #region int ChequeID

    private int _chequeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_chequeID", Name = "ChequeId", DbType = "int",  CanBeNull = false)]
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
                _chequeID = value;
                OnPropertyChanged("ChequeID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.chequeboletomensalidade")]
public partial class ChequeBoletoMensalidade : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region int BoletoMensalidadeID

    private int _boletoMensalidadeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_boletoMensalidadeID", Name = "BoletoMensalidadeId", DbType = "int", CanBeNull = false)]
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
                _boletoMensalidadeID = value;
                OnPropertyChanged("BoletoMensalidadeID");
            }
        }
    }

    #endregion

    #region int ChequeID

    private int _chequeID;
    [DebuggerNonUserCode]
    [Column(Storage = "_chequeID", Name = "ChequeId", DbType = "int",  CanBeNull = false)]
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
                _chequeID = value;
                OnPropertyChanged("ChequeID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.contasapagar")]
public partial class ContasAPagar : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region System.DateTime? DataPagamento

    private System.DateTime? _dataPagamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPagamento", Name = "DataPagamento", DbType = "datetime")]
    public System.DateTime? DataPagamento
    {
        get
        {
            return _dataPagamento;
        }
        set
        {
            if (value != _dataPagamento)
            {
                _dataPagamento = value;
                OnPropertyChanged("DataPagamento");
            }
        }
    }

    #endregion

    #region System.DateTime DataVencimento

    private System.DateTime _dataVencimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataVencimento", Name = "DataVencimento", DbType = "datetime", CanBeNull = false)]
    public System.DateTime DataVencimento
    {
        get
        {
            return _dataVencimento;
        }
        set
        {
            if (value != _dataVencimento)
            {
                _dataVencimento = value;
                OnPropertyChanged("DataVencimento");
            }
        }
    }

    #endregion

    #region double? Desconto

    private double? _desconto;
    [DebuggerNonUserCode]
    [Column(Storage = "_desconto", Name = "Desconto", DbType = "double")]
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
                _desconto = value;
                OnPropertyChanged("Desconto");
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(100)", CanBeNull = false)]
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
                _descricao = value;
                OnPropertyChanged("Descricao");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region double? Multa

    private double? _multa;
    [DebuggerNonUserCode]
    [Column(Storage = "_multa", Name = "Multa", DbType = "double")]
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
                _multa = value;
                OnPropertyChanged("Multa");
            }
        }
    }

    #endregion

    #region int? Parcela

    private int? _parcela;
    [DebuggerNonUserCode]
    [Column(Storage = "_parcela", Name = "Parcela", DbType = "int")]
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
                _parcela = value;
                OnPropertyChanged("Parcela");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double")]
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
                _valor = value;
                OnPropertyChanged("Valor");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.dependencia")]
public partial class Dependencia : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region byte? Aprovado

    private byte? _aprovado;
    [DebuggerNonUserCode]
    [Column(Storage = "_aprovado", Name = "Aprovado", DbType = "tinyint(1)")]
    public byte? Aprovado
    {
        get
        {
            return _aprovado;
        }
        set
        {
            if (value != _aprovado)
            {
                _aprovado = value;
                OnPropertyChanged("Aprovado");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint? ProfessorDisciplinaSalaID

    private uint? _professorDisciplinaSalaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_professorDisciplinaSalaID", Name = "ProfessorDisciplinaSalaId", DbType = "int unsigned")]
    public uint? ProfessorDisciplinaSalaID
    {
        get
        {
            return _professorDisciplinaSalaID;
        }
        set
        {
            if (value != _professorDisciplinaSalaID)
            {
                _professorDisciplinaSalaID = value;
                OnPropertyChanged("ProfessorDisciplinaSalaID");
            }
        }
    }

    #endregion

    #region double? Rec

    private double? _rec;
    [DebuggerNonUserCode]
    [Column(Storage = "_rec", Name = "Rec", DbType = "double")]
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
                _rec = value;
                OnPropertyChanged("Rec");
            }
        }
    }

    #endregion

    #region double? RecFinal

    private double? _recFinal;
    [DebuggerNonUserCode]
    [Column(Storage = "_recFinal", Name = "RecFinal", DbType = "double")]
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
                _recFinal = value;
                OnPropertyChanged("RecFinal");
            }
        }
    }

    #endregion

    #region double Vc1

    private double _vc1;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc1", Name = "Vc1", DbType = "double unsigned", CanBeNull = false)]
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
                _vc1 = value;
                OnPropertyChanged("Vc1");
            }
        }
    }

    #endregion

    #region double Vc2

    private double _vc2;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc2", Name = "Vc2", DbType = "double", CanBeNull = false)]
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
                _vc2 = value;
                OnPropertyChanged("Vc2");
            }
        }
    }

    #endregion

    #region double? Vp

    private double? _vp;
    [DebuggerNonUserCode]
    [Column(Storage = "_vp", Name = "Vp", DbType = "double unsigned")]
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
                _vp = value;
                OnPropertyChanged("Vp");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.desconto")]
public partial class Desconto : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(30)", CanBeNull = false)]
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
                _descricao = value;
                OnPropertyChanged("Descricao");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region double Percentual

    private double _percentual;
    [DebuggerNonUserCode]
    [Column(Storage = "_percentual", Name = "Percentual", DbType = "double", CanBeNull = false)]
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
                _percentual = value;
                OnPropertyChanged("Percentual");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.disciplina")]
public partial class Disciplina : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)")]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region byte? TipoAvaliacao

    private byte? _tipoAvaliacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_tipoAvaliacao", Name = "TipoAvaliacao", DbType = "tinyint(1)")]
    public byte? TipoAvaliacao
    {
        get
        {
            return _tipoAvaliacao;
        }
        set
        {
            if (value != _tipoAvaliacao)
            {
                _tipoAvaliacao = value;
                OnPropertyChanged("TipoAvaliacao");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.funcionario")]
public partial class Funcionario : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region string Alergico

    private string _alergico;
    [DebuggerNonUserCode]
    [Column(Storage = "_alergico", Name = "Alergico", DbType = "varchar(100)")]
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
                _alergico = value;
                OnPropertyChanged("Alergico");
            }
        }
    }

    #endregion

    #region string Bairro

    private string _bairro;
    [DebuggerNonUserCode]
    [Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(30)")]
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
                _bairro = value;
                OnPropertyChanged("Bairro");
            }
        }
    }

    #endregion

    #region string Cargo

    private string _cargo;
    [DebuggerNonUserCode]
    [Column(Storage = "_cargo", Name = "Cargo", DbType = "varchar(100)")]
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
                _cargo = value;
                OnPropertyChanged("Cargo");
            }
        }
    }

    #endregion

    #region string Cep

    private string _cep;
    [DebuggerNonUserCode]
    [Column(Storage = "_cep", Name = "Cep", DbType = "varchar(9)")]
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
                _cep = value;
                OnPropertyChanged("Cep");
            }
        }
    }

    #endregion

    #region string Cidade

    private string _cidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_cidade", Name = "Cidade", DbType = "varchar(30)")]
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
                _cidade = value;
                OnPropertyChanged("Cidade");
            }
        }
    }

    #endregion

    #region string ComplementoEndereco

    private string _complementoEndereco;
    [DebuggerNonUserCode]
    [Column(Storage = "_complementoEndereco", Name = "ComplementoEndereco", DbType = "varchar(30)")]
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
                _complementoEndereco = value;
                OnPropertyChanged("ComplementoEndereco");
            }
        }
    }

    #endregion

    #region string ContatoEmergencia

    private string _contatoEmergencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_contatoEmergencia", Name = "ContatoEmergencia", DbType = "varchar(50)")]
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
                _contatoEmergencia = value;
                OnPropertyChanged("ContatoEmergencia");
            }
        }
    }

    #endregion

    #region string Cpf

    private string _cpf;
    [DebuggerNonUserCode]
    [Column(Storage = "_cpf", Name = "Cpf", DbType = "varchar(11)")]
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
                _cpf = value;
                OnPropertyChanged("Cpf");
            }
        }
    }

    #endregion

    #region string Ctps

    private string _ctps;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctps", Name = "Ctps", DbType = "varchar(30)")]
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
                _ctps = value;
                OnPropertyChanged("Ctps");
            }
        }
    }

    #endregion

    #region System.DateTime? DataEfetivacao

    private System.DateTime? _dataEfetivacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataEfetivacao", Name = "DataEfetivacao", DbType = "datetime")]
    public System.DateTime? DataEfetivacao
    {
        get
        {
            return _dataEfetivacao;
        }
        set
        {
            if (value != _dataEfetivacao)
            {
                _dataEfetivacao = value;
                OnPropertyChanged("DataEfetivacao");
            }
        }
    }

    #endregion

    #region string Email

    private string _email;
    [DebuggerNonUserCode]
    [Column(Storage = "_email", Name = "Email", DbType = "varchar(40)")]
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
                _email = value;
                OnPropertyChanged("Email");
            }
        }
    }

    #endregion

    #region string Emisor

    private string _emisor;
    [DebuggerNonUserCode]
    [Column(Storage = "_emisor", Name = "Emisor", DbType = "varchar(30)")]
    public string Emisor
    {
        get
        {
            return _emisor;
        }
        set
        {
            if (value != _emisor)
            {
                _emisor = value;
                OnPropertyChanged("Emisor");
            }
        }
    }

    #endregion

    #region string Filiacao

    private string _filiacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_filiacao", Name = "Filiacao", DbType = "varchar(50)")]
    public string Filiacao
    {
        get
        {
            return _filiacao;
        }
        set
        {
            if (value != _filiacao)
            {
                _filiacao = value;
                OnPropertyChanged("Filiacao");
            }
        }
    }

    #endregion

    #region string FoneEmergencia

    private string _foneEmergencia;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneEmergencia", Name = "FoneEmergencia", DbType = "varchar(14)")]
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
                _foneEmergencia = value;
                OnPropertyChanged("FoneEmergencia");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region System.Byte[] Imagem

    private System.Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob")]
    public System.Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                _imagem = value;
                OnPropertyChanged("Imagem");
            }
        }
    }

    #endregion

    #region string Login

    private string _login;
    [DebuggerNonUserCode]
    [Column(Storage = "_login", Name = "Login", DbType = "varchar(30)")]
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
                _login = value;
                OnPropertyChanged("Login");
            }
        }
    }

    #endregion

    #region string Logradouro

    private string _logradouro;
    [DebuggerNonUserCode]
    [Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(60)")]
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
                _logradouro = value;
                OnPropertyChanged("Logradouro");
            }
        }
    }

    #endregion

    #region System.DateTime? Nascimento

    private System.DateTime? _nascimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_nascimento", Name = "Nascimento", DbType = "datetime")]
    public System.DateTime? Nascimento
    {
        get
        {
            return _nascimento;
        }
        set
        {
            if (value != _nascimento)
            {
                _nascimento = value;
                OnPropertyChanged("Nascimento");
            }
        }
    }

    #endregion

    #region string Naturalidade

    private string _naturalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_naturalidade", Name = "Naturalidade", DbType = "varchar(30)")]
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
                _naturalidade = value;
                OnPropertyChanged("Naturalidade");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", CanBeNull = false)]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region int? PerfilID

    private int? _perfilID;
    [DebuggerNonUserCode]
    [Column(Storage = "_perfilID", Name = "PerfilId", DbType = "int")]
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
                _perfilID = value;
                OnPropertyChanged("PerfilID");
            }
        }
    }

    #endregion

    #region string Pis

    private string _pis;
    [DebuggerNonUserCode]
    [Column(Storage = "_pis", Name = "Pis", DbType = "varchar(45)")]
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
                _pis = value;
                OnPropertyChanged("Pis");
            }
        }
    }

    #endregion

    #region string Senha

    private string _senha;
    [DebuggerNonUserCode]
    [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(20)")]
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
                _senha = value;
                OnPropertyChanged("Senha");
            }
        }
    }

    #endregion

    #region string Serie

    private string _serie;
    [DebuggerNonUserCode]
    [Column(Storage = "_serie", Name = "Serie", DbType = "varchar(30)")]
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
                _serie = value;
                OnPropertyChanged("Serie");
            }
        }
    }

    #endregion

    #region byte? Sexo

    private byte? _sexo;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexo", Name = "Sexo", DbType = "tinyint(1)")]
    public byte? Sexo
    {
        get
        {
            return _sexo;
        }
        set
        {
            if (value != _sexo)
            {
                _sexo = value;
                OnPropertyChanged("Sexo");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region string Uf

    private string _uf;
    [DebuggerNonUserCode]
    [Column(Storage = "_uf", Name = "Uf", DbType = "varchar(2)")]
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
                _uf = value;
                OnPropertyChanged("Uf");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.matricula")]
public partial class Matricula : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint? AlunoID

    private uint? _alunoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoID", Name = "AlunoId", DbType = "int unsigned")]
    public uint? AlunoID
    {
        get
        {
            return _alunoID;
        }
        set
        {
            if (value != _alunoID)
            {
                _alunoID = value;
                OnPropertyChanged("AlunoID");
            }
        }
    }

    #endregion

    #region System.DateTime? DataMatricula

    private System.DateTime? _dataMatricula;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataMatricula", Name = "DataMatricula", DbType = "datetime")]
    public System.DateTime? DataMatricula
    {
        get
        {
            return _dataMatricula;
        }
        set
        {
            if (value != _dataMatricula)
            {
                _dataMatricula = value;
                OnPropertyChanged("DataMatricula");
            }
        }
    }

    #endregion

    #region uint? DescontoID

    private uint? _descontoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_descontoID", Name = "DescontoId", DbType = "int unsigned")]
    public uint? DescontoID
    {
        get
        {
            return _descontoID;
        }
        set
        {
            if (value != _descontoID)
            {
                _descontoID = value;
                OnPropertyChanged("DescontoID");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region string NumMatricula

    private string _numMatricula;
    [DebuggerNonUserCode]
    [Column(Storage = "_numMatricula", Name = "NumMatricula", DbType = "varchar(30)", CanBeNull = false)]
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
                _numMatricula = value;
                OnPropertyChanged("NumMatricula");
            }
        }
    }

    #endregion

    #region int? SalaPeriodoID

    private int? _salaPeriodoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_salaPeriodoID", Name = "SalaPeriodoId", DbType = "int")]
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
                _salaPeriodoID = value;
                OnPropertyChanged("SalaPeriodoID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double")]
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
                _valor = value;
                OnPropertyChanged("Valor");
            }
        }
    }

    #endregion

    #region Children

    [Association(Storage = null, OtherKey = "MatriculaID", Name = "fk_BoletoAtividade_Matricula")]
    [DebuggerNonUserCode]
    public EntitySet<BoletoAtividade> BoletoAtividade
    {
        get;
        set;
    }

    [Association(Storage = null, OtherKey = "MatriculaID", Name = "fk_BoletoMensalidade_Matricula")]
    [DebuggerNonUserCode]
    public EntitySet<BoletoMensalidade> BoletoMensalidade
    {
        get;
        set;
    }


    #endregion

}

[Table(Name = "colegiodb.nota")]
public partial class Nota : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region byte? Aprovado

    private byte? _aprovado;
    [DebuggerNonUserCode]
    [Column(Storage = "_aprovado", Name = "Aprovado", DbType = "tinyint(1)")]
    public byte? Aprovado
    {
        get
        {
            return _aprovado;
        }
        set
        {
            if (value != _aprovado)
            {
                _aprovado = value;
                OnPropertyChanged("Aprovado");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint? MatriculaID

    private uint? _matriculaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_matriculaID", Name = "MatriculaId", DbType = "int unsigned")]
    public uint? MatriculaID
    {
        get
        {
            return _matriculaID;
        }
        set
        {
            if (value != _matriculaID)
            {
                _matriculaID = value;
                OnPropertyChanged("MatriculaID");
            }
        }
    }

    #endregion

    #region uint? ProfessorDisciplinaSalaID

    private uint? _professorDisciplinaSalaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_professorDisciplinaSalaID", Name = "ProfessorDisciplinaSalaId", DbType = "int unsigned")]
    public uint? ProfessorDisciplinaSalaID
    {
        get
        {
            return _professorDisciplinaSalaID;
        }
        set
        {
            if (value != _professorDisciplinaSalaID)
            {
                _professorDisciplinaSalaID = value;
                OnPropertyChanged("ProfessorDisciplinaSalaID");
            }
        }
    }

    #endregion

    #region double? Rec

    private double? _rec;
    [DebuggerNonUserCode]
    [Column(Storage = "_rec", Name = "Rec", DbType = "double")]
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
                _rec = value;
                OnPropertyChanged("Rec");
            }
        }
    }

    #endregion

    #region double? RecFinal

    private double? _recFinal;
    [DebuggerNonUserCode]
    [Column(Storage = "_recFinal", Name = "RecFinal", DbType = "double")]
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
                _recFinal = value;
                OnPropertyChanged("RecFinal");
            }
        }
    }

    #endregion

    #region double Vc1

    private double _vc1;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc1", Name = "Vc1", DbType = "double unsigned", CanBeNull = false)]
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
                _vc1 = value;
                OnPropertyChanged("Vc1");
            }
        }
    }

    #endregion

    #region double Vc2

    private double _vc2;
    [DebuggerNonUserCode]
    [Column(Storage = "_vc2", Name = "Vc2", DbType = "double", CanBeNull = false)]
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
                _vc2 = value;
                OnPropertyChanged("Vc2");
            }
        }
    }

    #endregion

    #region double? Vp

    private double? _vp;
    [DebuggerNonUserCode]
    [Column(Storage = "_vp", Name = "Vp", DbType = "double unsigned")]
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
                _vp = value;
                OnPropertyChanged("Vp");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.perfil")]
public partial class Perfil : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region int? CtrlAdvertenciasAtrasos

    private int? _ctrlAdvertenciasAtrasos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAdvertenciasAtrasos", Name = "CtrlAdvertenciasAtrasos", DbType = "int")]
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
                _ctrlAdvertenciasAtrasos = value;
                OnPropertyChanged("CtrlAdvertenciasAtrasos");
            }
        }
    }

    #endregion

    #region int? CtrlAluno

    private int? _ctrlAluno;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAluno", Name = "CtrlAluno", DbType = "int")]
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
                _ctrlAluno = value;
                OnPropertyChanged("CtrlAluno");
            }
        }
    }

    #endregion

    #region int? CtrlAniversariantes

    private int? _ctrlAniversariantes;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAniversariantes", Name = "CtrlAniversariantes", DbType = "int")]
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
                _ctrlAniversariantes = value;
                OnPropertyChanged("CtrlAniversariantes");
            }
        }
    }

    #endregion

    #region int? CtrlAnotacoes

    private int? _ctrlAnotacoes;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAnotacoes", Name = "CtrlAnotacoes", DbType = "int")]
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
                _ctrlAnotacoes = value;
                OnPropertyChanged("CtrlAnotacoes");
            }
        }
    }

    #endregion

    #region int? CtrlAtividade

    private int? _ctrlAtividade;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlAtividade", Name = "CtrlAtividade", DbType = "int")]
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
                _ctrlAtividade = value;
                OnPropertyChanged("CtrlAtividade");
            }
        }
    }

    #endregion

    #region int? CtrlBoletim

    private int? _ctrlBoletim;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlBoletim", Name = "CtrlBoletim", DbType = "int")]
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
                _ctrlBoletim = value;
                OnPropertyChanged("CtrlBoletim");
            }
        }
    }

    #endregion

    #region int? CtrlCertificados

    private int? _ctrlCertificados;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlCertificados", Name = "CtrlCertificados", DbType = "int")]
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
                _ctrlCertificados = value;
                OnPropertyChanged("CtrlCertificados");
            }
        }
    }

    #endregion

    #region int? CtrlCheques

    private int? _ctrlCheques;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlCheques", Name = "CtrlCheques", DbType = "int")]
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
                _ctrlCheques = value;
                OnPropertyChanged("CtrlCheques");
            }
        }
    }

    #endregion

    #region int? CtrlContasPagar

    private int? _ctrlContasPagar;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlContasPagar", Name = "CtrlContasPagar", DbType = "int")]
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
                _ctrlContasPagar = value;
                OnPropertyChanged("CtrlContasPagar");
            }
        }
    }

    #endregion

    #region int? CtrlDebitos

    private int? _ctrlDebitos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlDebitos", Name = "CtrlDebitos", DbType = "int")]
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
                _ctrlDebitos = value;
                OnPropertyChanged("CtrlDebitos");
            }
        }
    }

    #endregion

    #region int? CtrlDeclaracaoQuitacao

    private int? _ctrlDeclaracaoQuitacao;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlDeclaracaoQuitacao", Name = "CtrlDeclaracaoQuitacao", DbType = "int")]
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
                _ctrlDeclaracaoQuitacao = value;
                OnPropertyChanged("CtrlDeclaracaoQuitacao");
            }
        }
    }

    #endregion

    #region int? CtrlEmails

    private int? _ctrlEmails;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlEmails", Name = "CtrlEmails", DbType = "int")]
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
                _ctrlEmails = value;
                OnPropertyChanged("CtrlEmails");
            }
        }
    }

    #endregion

    #region int? CtrlFinanceiro

    private int? _ctrlFinanceiro;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFinanceiro", Name = "CtrlFinanceiro", DbType = "int")]
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
                _ctrlFinanceiro = value;
                OnPropertyChanged("CtrlFinanceiro");
            }
        }
    }

    #endregion

    #region int? CtrlFolhaChamada

    private int? _ctrlFolhaChamada;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFolhaChamada", Name = "CtrlFolhaChamada", DbType = "int")]
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
                _ctrlFolhaChamada = value;
                OnPropertyChanged("CtrlFolhaChamada");
            }
        }
    }

    #endregion

    #region int? CtrlFolhaPonto

    private int? _ctrlFolhaPonto;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFolhaPonto", Name = "CtrlFolhaPonto", DbType = "int")]
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
                _ctrlFolhaPonto = value;
                OnPropertyChanged("CtrlFolhaPonto");
            }
        }
    }

    #endregion

    #region int? CtrlFreqAlunos

    private int? _ctrlFreqAlunos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFreqAlunos", Name = "CtrlFreqAlunos", DbType = "int")]
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
                _ctrlFreqAlunos = value;
                OnPropertyChanged("CtrlFreqAlunos");
            }
        }
    }

    #endregion

    #region int? CtrlFreqFuncionarios

    private int? _ctrlFreqFuncionarios;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFreqFuncionarios", Name = "CtrlFreqFuncionarios", DbType = "int")]
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
                _ctrlFreqFuncionarios = value;
                OnPropertyChanged("CtrlFreqFuncionarios");
            }
        }
    }

    #endregion

    #region int? CtrlFuncionario

    private int? _ctrlFuncionario;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlFuncionario", Name = "CtrlFuncionario", DbType = "int")]
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
                _ctrlFuncionario = value;
                OnPropertyChanged("CtrlFuncionario");
            }
        }
    }

    #endregion

    #region int? CtrlGre

    private int? _ctrlGre;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlGre", Name = "CtrlGRE", DbType = "int")]
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
                _ctrlGre = value;
                OnPropertyChanged("CtrlGre");
            }
        }
    }

    #endregion

    #region int? CtrlMensalidade

    private int? _ctrlMensalidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlMensalidade", Name = "CtrlMensalidade", DbType = "int")]
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
                _ctrlMensalidade = value;
                OnPropertyChanged("CtrlMensalidade");
            }
        }
    }

    #endregion

    #region int? CtrlNotas

    private int? _ctrlNotas;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlNotas", Name = "CtrlNotas", DbType = "int")]
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
                _ctrlNotas = value;
                OnPropertyChanged("CtrlNotas");
            }
        }
    }

    #endregion

    #region int? CtrlRankingNotas

    private int? _ctrlRankingNotas;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlRankingNotas", Name = "CtrlRankingNotas", DbType = "int")]
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
                _ctrlRankingNotas = value;
                OnPropertyChanged("CtrlRankingNotas");
            }
        }
    }

    #endregion

    #region int? CtrlRemanejamento

    private int? _ctrlRemanejamento;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlRemanejamento", Name = "CtrlRemanejamento", DbType = "int")]
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
                _ctrlRemanejamento = value;
                OnPropertyChanged("CtrlRemanejamento");
            }
        }
    }

    #endregion

    #region int? CtrlSerie

    private int? _ctrlSerie;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlSerie", Name = "CtrlSerie", DbType = "int")]
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
                _ctrlSerie = value;
                OnPropertyChanged("CtrlSerie");
            }
        }
    }

    #endregion

    #region int? CtrlTransfHistoricos

    private int? _ctrlTransfHistoricos;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlTransfHistoricos", Name = "CtrlTransfHistoricos", DbType = "int")]
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
                _ctrlTransfHistoricos = value;
                OnPropertyChanged("CtrlTransfHistoricos");
            }
        }
    }

    #endregion

    #region int? CtrlTurma

    private int? _ctrlTurma;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlTurma", Name = "CtrlTurma", DbType = "int")]
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
                _ctrlTurma = value;
                OnPropertyChanged("CtrlTurma");
            }
        }
    }

    #endregion

    #region int? CtrlTurno

    private int? _ctrlTurno;
    [DebuggerNonUserCode]
    [Column(Storage = "_ctrlTurno", Name = "CtrlTurno", DbType = "int")]
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
                _ctrlTurno = value;
                OnPropertyChanged("CtrlTurno");
            }
        }
    }

    #endregion

    #region string Descricao

    private string _descricao;
    [DebuggerNonUserCode]
    [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", CanBeNull = false)]
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
                _descricao = value;
                OnPropertyChanged("Descricao");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.professordisciplinasala")]
public partial class ProfessorDisciplinaSala : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region System.DateTime? DataPeriodo

    private System.DateTime? _dataPeriodo;
    [DebuggerNonUserCode]
    [Column(Storage = "_dataPeriodo", Name = "DataPeriodo", DbType = "datetime")]
    public System.DateTime? DataPeriodo
    {
        get
        {
            return _dataPeriodo;
        }
        set
        {
            if (value != _dataPeriodo)
            {
                _dataPeriodo = value;
                OnPropertyChanged("DataPeriodo");
            }
        }
    }

    #endregion

    #region uint? DisciplinaID

    private uint? _disciplinaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_disciplinaID", Name = "DisciplinaId", DbType = "int unsigned")]
    public uint? DisciplinaID
    {
        get
        {
            return _disciplinaID;
        }
        set
        {
            if (value != _disciplinaID)
            {
                _disciplinaID = value;
                OnPropertyChanged("DisciplinaID");
            }
        }
    }

    #endregion

    #region uint? FuncionarioID

    private uint? _funcionarioID;
    [DebuggerNonUserCode]
    [Column(Storage = "_funcionarioID", Name = "FuncionarioId", DbType = "int unsigned")]
    public uint? FuncionarioID
    {
        get
        {
            return _funcionarioID;
        }
        set
        {
            if (value != _funcionarioID)
            {
                _funcionarioID = value;
                OnPropertyChanged("FuncionarioID");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region int? SalaPeriodoID

    private int? _salaPeriodoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_salaPeriodoID", Name = "SalaPeriodoId", DbType = "int")]
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
                _salaPeriodoID = value;
                OnPropertyChanged("SalaPeriodoID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.responsavel")]
public partial class Responsavel : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region string Bairro

    private string _bairro;
    [DebuggerNonUserCode]
    [Column(Storage = "_bairro", Name = "Bairro", DbType = "varchar(30)")]
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
                _bairro = value;
                OnPropertyChanged("Bairro");
            }
        }
    }

    #endregion

    #region string Cep

    private string _cep;
    [DebuggerNonUserCode]
    [Column(Storage = "_cep", Name = "Cep", DbType = "varchar(9)")]
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
                _cep = value;
                OnPropertyChanged("Cep");
            }
        }
    }

    #endregion

    #region string Cidade

    private string _cidade;
    [DebuggerNonUserCode]
    [Column(Storage = "_cidade", Name = "Cidade", DbType = "varchar(30)")]
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
                _cidade = value;
                OnPropertyChanged("Cidade");
            }
        }
    }

    #endregion

    #region string ComplementoEndereco

    private string _complementoEndereco;
    [DebuggerNonUserCode]
    [Column(Storage = "_complementoEndereco", Name = "ComplementoEndereco", DbType = "varchar(30)")]
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
                _complementoEndereco = value;
                OnPropertyChanged("ComplementoEndereco");
            }
        }
    }

    #endregion

    #region string Cpf

    private string _cpf;
    [DebuggerNonUserCode]
    [Column(Storage = "_cpf", Name = "Cpf", DbType = "varchar(11)")]
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
                _cpf = value;
                OnPropertyChanged("Cpf");
            }
        }
    }

    #endregion

    #region string Email

    private string _email;
    [DebuggerNonUserCode]
    [Column(Storage = "_email", Name = "Email", DbType = "varchar(40)")]
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
                _email = value;
                OnPropertyChanged("Email");
            }
        }
    }

    #endregion

    #region string Fone

    private string _fone;
    [DebuggerNonUserCode]
    [Column(Storage = "_fone", Name = "Fone", DbType = "varchar(14)")]
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
                _fone = value;
                OnPropertyChanged("Fone");
            }
        }
    }

    #endregion

    #region string FoneTrabalho

    private string _foneTrabalho;
    [DebuggerNonUserCode]
    [Column(Storage = "_foneTrabalho", Name = "FoneTrabalho", DbType = "varchar(14)")]
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
                _foneTrabalho = value;
                OnPropertyChanged("FoneTrabalho");
            }
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region System.Byte[] Imagem

    private System.Byte[] _imagem;
    [DebuggerNonUserCode]
    [Column(Storage = "_imagem", Name = "Imagem", DbType = "longblob")]
    public System.Byte[] Imagem
    {
        get
        {
            return _imagem;
        }
        set
        {
            if (value != _imagem)
            {
                _imagem = value;
                OnPropertyChanged("Imagem");
            }
        }
    }

    #endregion

    #region string LocalTrabalho

    private string _localTrabalho;
    [DebuggerNonUserCode]
    [Column(Storage = "_localTrabalho", Name = "LocalTrabalho", DbType = "varchar(30)")]
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
                _localTrabalho = value;
                OnPropertyChanged("LocalTrabalho");
            }
        }
    }

    #endregion

    #region string Login

    private string _login;
    [DebuggerNonUserCode]
    [Column(Storage = "_login", Name = "Login", DbType = "varchar(30)")]
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
                _login = value;
                OnPropertyChanged("Login");
            }
        }
    }

    #endregion

    #region string Logradouro

    private string _logradouro;
    [DebuggerNonUserCode]
    [Column(Storage = "_logradouro", Name = "Logradouro", DbType = "varchar(60)")]
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
                _logradouro = value;
                OnPropertyChanged("Logradouro");
            }
        }
    }

    #endregion

    #region System.DateTime? Nascimento

    private System.DateTime? _nascimento;
    [DebuggerNonUserCode]
    [Column(Storage = "_nascimento", Name = "Nascimento", DbType = "datetime")]
    public System.DateTime? Nascimento
    {
        get
        {
            return _nascimento;
        }
        set
        {
            if (value != _nascimento)
            {
                _nascimento = value;
                OnPropertyChanged("Nascimento");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", CanBeNull = false)]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region int? PerfilID

    private int? _perfilID;
    [DebuggerNonUserCode]
    [Column(Storage = "_perfilID", Name = "PerfilId", DbType = "int")]
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
                _perfilID = value;
                OnPropertyChanged("PerfilID");
            }
        }
    }

    #endregion

    #region string Profissao

    private string _profissao;
    [DebuggerNonUserCode]
    [Column(Storage = "_profissao", Name = "Profissao", DbType = "varchar(30)")]
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
                _profissao = value;
                OnPropertyChanged("Profissao");
            }
        }
    }

    #endregion

    #region string Rg

    private string _rg;
    [DebuggerNonUserCode]
    [Column(Storage = "_rg", Name = "Rg", DbType = "varchar(20)")]
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
                _rg = value;
                OnPropertyChanged("Rg");
            }
        }
    }

    #endregion

    #region string Senha

    private string _senha;
    [DebuggerNonUserCode]
    [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(20)")]
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
                _senha = value;
                OnPropertyChanged("Senha");
            }
        }
    }

    #endregion

    #region byte? Sexo

    private byte? _sexo;
    [DebuggerNonUserCode]
    [Column(Storage = "_sexo", Name = "Sexo", DbType = "tinyint(1)")]
    public byte? Sexo
    {
        get
        {
            return _sexo;
        }
        set
        {
            if (value != _sexo)
            {
                _sexo = value;
                OnPropertyChanged("Sexo");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region string Uf

    private string _uf;
    [DebuggerNonUserCode]
    [Column(Storage = "_uf", Name = "Uf", DbType = "varchar(2)")]
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
                _uf = value;
                OnPropertyChanged("Uf");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.responsavelaluno")]
public partial class ResponsavelAluno : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint AlunoID

    private uint _alunoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_alunoID", Name = "AlunoId", DbType = "int unsigned",  CanBeNull = false)]
    public uint AlunoID
    {
        get
        {
            return _alunoID;
        }
        set
        {
            if (value != _alunoID)
            {
                _alunoID = value;
                OnPropertyChanged("AlunoID");
            }
        }
    }

    #endregion

    #region uint GrauParentescoID

    private uint _grauParentescoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_grauParentescoID", Name = "GrauParentescoId", DbType = "int unsigned", CanBeNull = false)]
    public uint GrauParentescoID
    {
        get
        {
            return _grauParentescoID;
        }
        set
        {
            if (value != _grauParentescoID)
            {
                _grauParentescoID = value;
                OnPropertyChanged("GrauParentescoID");
            }
        }
    }

    #endregion

    #region byte? ResideCom

    private byte? _resideCom;
    [DebuggerNonUserCode]
    [Column(Storage = "_resideCom", Name = "ResideCom", DbType = "tinyint(1)")]
    public byte? ResideCom
    {
        get
        {
            return _resideCom;
        }
        set
        {
            if (value != _resideCom)
            {
                _resideCom = value;
                OnPropertyChanged("ResideCom");
            }
        }
    }

    #endregion

    #region uint ResponsavelID

    private uint _responsavelID;
    [DebuggerNonUserCode]
    [Column(Storage = "_responsavelID", Name = "ResponsavelId", DbType = "int unsigned",  CanBeNull = false)]
    public uint ResponsavelID
    {
        get
        {
            return _responsavelID;
        }
        set
        {
            if (value != _responsavelID)
            {
                _responsavelID = value;
                OnPropertyChanged("ResponsavelID");
            }
        }
    }

    #endregion

    #region string Restricoes

    private string _restricoes;
    [DebuggerNonUserCode]
    [Column(Storage = "_restricoes", Name = "Restricoes", DbType = "varchar(300)")]
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
                _restricoes = value;
                OnPropertyChanged("Restricoes");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.sala")]
public partial class Sala : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint? SerieID

    private uint? _serieID;
    [DebuggerNonUserCode]
    [Column(Storage = "_serieID", Name = "SerieId", DbType = "int unsigned")]
    public uint? SerieID
    {
        get
        {
            return _serieID;
        }
        set
        {
            if (value != _serieID)
            {
                _serieID = value;
                OnPropertyChanged("SerieID");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region uint? TurmaID

    private uint? _turmaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_turmaID", Name = "TurmaId", DbType = "int unsigned")]
    public uint? TurmaID
    {
        get
        {
            return _turmaID;
        }
        set
        {
            if (value != _turmaID)
            {
                _turmaID = value;
                OnPropertyChanged("TurmaID");
            }
        }
    }

    #endregion

    #region uint? TurnoID

    private uint? _turnoID;
    [DebuggerNonUserCode]
    [Column(Storage = "_turnoID", Name = "TurnoId", DbType = "int unsigned")]
    public uint? TurnoID
    {
        get
        {
            return _turnoID;
        }
        set
        {
            if (value != _turnoID)
            {
                _turnoID = value;
                OnPropertyChanged("TurnoID");
            }
        }
    }

    #endregion

    #region Children

    [Association(Storage = null, OtherKey = "SalaID", Name = "fk_SalaPeriodo_Sala")]
    [DebuggerNonUserCode]
    public EntitySet<SalaPeriodo> SalaPeriodo
    {
        get;
        set;
    }


    #endregion

}

[Table(Name = "colegiodb.salaperiodo")]
public partial class SalaPeriodo : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region int? Ano

    private int? _ano;
    [DebuggerNonUserCode]
    [Column(Storage = "_ano", Name = "Ano", DbType = "int")]
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
                _ano = value;
                OnPropertyChanged("Ano");
            }
        }
    }

    #endregion

    #region int ID

    private int _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
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
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region uint? SalaID

    private uint? _salaID;
    [DebuggerNonUserCode]
    [Column(Storage = "_salaID", Name = "SalaId", DbType = "int unsigned")]
    public uint? SalaID
    {
        get
        {
            return _salaID;
        }
        set
        {
            if (value != _salaID)
            {
                _salaID = value;
                OnPropertyChanged("SalaID");
            }
        }
    }

    #endregion

    #region Parents

    private System.Data.Linq.EntityRef<Sala> _salA;
    [Association(Storage = "_salA", ThisKey = "SalaID", Name = "fk_SalaPeriodo_Sala", IsForeignKey = true)]
    [DebuggerNonUserCode]
    public Sala Sala
    {
        get
        {
            return _salA.Entity;
        }
        set
        {
            _salA.Entity = value;
        }
    }


    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.serie")]
public partial class Serie : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(30)")]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

    #region double? Valor

    private double? _valor;
    [DebuggerNonUserCode]
    [Column(Storage = "_valor", Name = "Valor", DbType = "double")]
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
                _valor = value;
                OnPropertyChanged("Valor");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.turma")]
public partial class Turma : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)")]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}

[Table(Name = "colegiodb.turno")]
public partial class Turno : INotifyPropertyChanged
{
    #region INotifyPropertyChanged handling

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region uint ID

    private uint _id;
    [DebuggerNonUserCode]
    [Column(Storage = "_id", Name = "Id", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
    public uint ID
    {
        get
        {
            return _id;
        }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }

    #endregion

    #region string Nome

    private string _nome;
    [DebuggerNonUserCode]
    [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(30)")]
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
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
    }

    #endregion

    #region byte? Status

    private byte? _status;
    [DebuggerNonUserCode]
    [Column(Storage = "_status", Name = "Status", DbType = "tinyint(1)")]
    public byte? Status
    {
        get
        {
            return _status;
        }
        set
        {
            if (value != _status)
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
    }

    #endregion

}
