using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAluno.Excecoes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAluno.Repositorios
{
    public class AlunoRepositorio: IAlunoRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Aluno> Consultar()
        {
            return db.Aluno.ToList();
        }

        public List<Aluno> Consultar(Aluno aluno, TipoPesquisa tipoPesquisa)
        {
            List<Aluno> resultado = Consultar();
            bool pesquisa = false;
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (aluno.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.ID == aluno.ID
                                                    select a).ToList());
                            }
                            else 
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.ID == aluno.ID
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento.Value
                                                    select a).ToList());
                            }
                            else 
                            {
                                resultado = ((from a in resultado
                                              where
                                              a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento.Value
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Alergico))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Alergico.Contains(aluno.Alergico)
                                                    select a).ToList());
                            }
                            else 
                            {
                                resultado =((from a in resultado
                                                    where
                                                    a.Alergico.Contains(aluno.Alergico)
                                                    select a).ToList());
                            
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Bairro))
                        {

                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Bairro.Contains(aluno.Bairro)
                                                    select a).ToList());
                            }
                            else 
                            {
                                resultado = ((from a in resultado
                                                    where
                                                    a.Bairro.Contains(aluno.Bairro)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cep))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Cep.Contains(aluno.Cep)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Cep.Contains(aluno.Cep)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Cidade.Contains(aluno.Cidade)
                                                    select a).ToList());
                            }
                            else 
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.Cidade.Contains(aluno.Cidade)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.ComplementoEndereco))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.ComplementoEndereco.Contains(aluno.ComplementoEndereco)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.ComplementoEndereco.Contains(aluno.ComplementoEndereco)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                                              
                        if (!string.IsNullOrEmpty(aluno.DescricaoMedica))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.DescricaoMedica.Contains(aluno.DescricaoMedica)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.DescricaoMedica.Contains(aluno.DescricaoMedica)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Email))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Email.Contains(aluno.Email)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Email.Contains(aluno.Email)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.FatorRh.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.FatorRh.HasValue && a.FatorRh.Value == aluno.FatorRh.Value
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.FatorRh.HasValue && a.FatorRh.Value == aluno.FatorRh.Value
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneAluno))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.FoneAluno.Contains(aluno.FoneAluno)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.FoneAluno.Contains(aluno.FoneAluno)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneEmergencia))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.FoneEmergencia.Contains(aluno.FoneEmergencia)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.FoneEmergencia.Contains(aluno.FoneEmergencia)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneMedico))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.FoneMedico.Contains(aluno.FoneMedico)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.FoneMedico.Contains(aluno.FoneMedico)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneResidencia))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.FoneResidencia.Contains(aluno.FoneResidencia)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.FoneResidencia.Contains(aluno.FoneResidencia)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.GrupoSanguineo))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.GrupoSanguineo.Contains(aluno.GrupoSanguineo)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.GrupoSanguineo.Contains(aluno.GrupoSanguineo)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Hospital))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Hospital.Contains(aluno.Hospital)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Hospital.Contains(aluno.Hospital)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Login))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Login.Contains(aluno.Login)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Login.Contains(aluno.Login)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Logradouro))
                        {

                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Logradouro.Contains(aluno.Logradouro)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Logradouro.Contains(aluno.Logradouro)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nacionalidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Nacionalidade.Contains(aluno.Nacionalidade)
                                                    select a).ToList());
                            }
                            else {
                                resultado = ((from a in resultado
                                                    where
                                                    a.Nacionalidade.Contains(aluno.Nacionalidade)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Naturalidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Naturalidade.Contains(aluno.Naturalidade)
                                                    select a).ToList());
                            }
                            else {

                                resultado=((from a in resultado
                                                    where
                                                    a.Naturalidade.Contains(aluno.Naturalidade)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nome))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Nome.Contains(aluno.Nome)
                                                    select a).ToList());
                            }
                            else 
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.Nome.Contains(aluno.Nome)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.NomeMedico))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.NomeMedico.Contains(aluno.NomeMedico)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.NomeMedico.Contains(aluno.NomeMedico)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.PerfilID!=0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.PerfilID == aluno.PerfilID
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.PerfilID == aluno.PerfilID
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.PlanoSaude))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.PlanoSaude.Contains(aluno.PlanoSaude)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado=((from a in resultado
                                                    where
                                                    a.PlanoSaude.Contains(aluno.PlanoSaude)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Senha))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Senha.Contains(aluno.Senha)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Senha.Contains(aluno.Senha)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Sexo.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Sexo.HasValue && a.Sexo.Value == aluno.Sexo.Value
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Sexo.HasValue && a.Sexo.Value == aluno.Sexo.Value
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.SituacaoEspecial))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.SituacaoEspecial.Contains(aluno.SituacaoEspecial)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.SituacaoEspecial.Contains(aluno.SituacaoEspecial)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Uf))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Uf.Contains(aluno.Uf)
                                                    select a).ToList());
                            }
                            else {
                                resultado=((from a in resultado
                                                    where
                                                    a.Uf.Contains(aluno.Uf)
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }




                        if (aluno.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Status.HasValue && a.Status.Value == aluno.Status.Value
                                                    select a).ToList());
                            }
                            else {
                                resultado.AddRange((from a in resultado
                                                    where
                                                    a.Status.HasValue && a.Status.Value == aluno.Status.Value
                                                    select a).ToList());
                            } 
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (aluno.ID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.ID == aluno.ID
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.ID == aluno.ID
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento.Value
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento.Value
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Alergico))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Alergico.Contains(aluno.Alergico)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Alergico.Contains(aluno.Alergico)
                                              select a).ToList());

                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Bairro))
                        {

                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Bairro.Contains(aluno.Bairro)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Bairro.Contains(aluno.Bairro)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cep))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Cep.Contains(aluno.Cep)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Cep.Contains(aluno.Cep)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Cidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Cidade.Contains(aluno.Cidade)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Cidade.Contains(aluno.Cidade)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.ComplementoEndereco))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.ComplementoEndereco.Contains(aluno.ComplementoEndereco)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.ComplementoEndereco.Contains(aluno.ComplementoEndereco)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                       
                       
                        if (!string.IsNullOrEmpty(aluno.DescricaoMedica))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.DescricaoMedica.Contains(aluno.DescricaoMedica)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.DescricaoMedica.Contains(aluno.DescricaoMedica)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Email))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Email.Contains(aluno.Email)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Email.Contains(aluno.Email)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.FatorRh.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.FatorRh.HasValue && a.FatorRh.Value == aluno.FatorRh.Value
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.FatorRh.HasValue && a.FatorRh.Value == aluno.FatorRh.Value
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneAluno))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.FoneAluno.Contains(aluno.FoneAluno)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.FoneAluno.Contains(aluno.FoneAluno)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneEmergencia))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.FoneEmergencia.Contains(aluno.FoneEmergencia)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.FoneEmergencia.Contains(aluno.FoneEmergencia)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneMedico))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.FoneMedico.Contains(aluno.FoneMedico)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.FoneMedico.Contains(aluno.FoneMedico)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.FoneResidencia))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.FoneResidencia.Contains(aluno.FoneResidencia)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.FoneResidencia.Contains(aluno.FoneResidencia)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.GrupoSanguineo))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.GrupoSanguineo.Contains(aluno.GrupoSanguineo)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.GrupoSanguineo.Contains(aluno.GrupoSanguineo)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Hospital))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Hospital.Contains(aluno.Hospital)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Hospital.Contains(aluno.Hospital)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Login))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Login.Contains(aluno.Login)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Login.Contains(aluno.Login)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Logradouro))
                        {

                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Logradouro.Contains(aluno.Logradouro)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Logradouro.Contains(aluno.Logradouro)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nacionalidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Nacionalidade.Contains(aluno.Nacionalidade)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Nacionalidade.Contains(aluno.Nacionalidade)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Nascimento.HasValue && aluno.Nascimento.Value != default(DateTime))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Nascimento.HasValue && a.Nascimento.Value == aluno.Nascimento
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Naturalidade))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Naturalidade.Contains(aluno.Naturalidade)
                                                    select a).ToList());
                            }
                            else
                            {

                                resultado = ((from a in Consultar()
                                              where
                                              a.Naturalidade.Contains(aluno.Naturalidade)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Nome))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Nome.Contains(aluno.Nome)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Nome.Contains(aluno.Nome)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.NomeMedico))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.NomeMedico.Contains(aluno.NomeMedico)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.NomeMedico.Contains(aluno.NomeMedico)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.PerfilID != 0)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.PerfilID == aluno.PerfilID
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.PerfilID == aluno.PerfilID
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.PlanoSaude))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.PlanoSaude.Contains(aluno.PlanoSaude)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.PlanoSaude.Contains(aluno.PlanoSaude)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Senha))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Senha.Contains(aluno.Senha)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Senha.Contains(aluno.Senha)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (aluno.Sexo.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Sexo.HasValue && a.Sexo.Value == aluno.Sexo.Value
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Sexo.HasValue && a.Sexo.Value == aluno.Sexo.Value
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.SituacaoEspecial))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.SituacaoEspecial.Contains(aluno.SituacaoEspecial)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.SituacaoEspecial.Contains(aluno.SituacaoEspecial)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(aluno.Uf))
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Uf.Contains(aluno.Uf)
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado = ((from a in Consultar()
                                              where
                                              a.Uf.Contains(aluno.Uf)
                                              select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }




                        if (aluno.Status.HasValue)
                        {
                            if (pesquisa)
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Status.HasValue && a.Status.Value == aluno.Status.Value
                                                    select a).ToList());
                            }
                            else
                            {
                                resultado.AddRange((from a in Consultar()
                                                    where
                                                    a.Status.HasValue && a.Status.Value == aluno.Status.Value
                                                    select a).ToList());
                            }
                            pesquisa = true;
                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                
                default:
                    break;
            }

            return resultado;
        }

        public void Incluir(Aluno aluno)
        {
            try
            {
                db.Aluno.InsertOnSubmit(aluno);
            }
            catch (Exception)
            {
                
                throw new AlunoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Aluno aluno)
        {
            try
            {
                Aluno alunoAux = new Aluno();
                alunoAux.ID = aluno.ID;


                List<Aluno> resultado = this.Consultar(alunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoNaoExcluidoExcecao();

                alunoAux = resultado[0];

                db.Aluno.DeleteOnSubmit(alunoAux);
             
            }
            catch (Exception)
            {
                
               throw new AlunoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Aluno aluno)
        {
            try
            {
                Aluno alunoAux = new Aluno();
                alunoAux.ID = aluno.ID;


                List<Aluno> resultado = this.Consultar(alunoAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new AlunoNaoAlteradoExcecao();

                alunoAux = resultado[0];
                alunoAux.Alergico= aluno.Alergico;
                alunoAux.Bairro= aluno.Bairro;
                alunoAux.Cep = aluno.Cep;
                alunoAux.Cidade = aluno.Cidade;
                alunoAux.ComplementoEndereco= aluno.ComplementoEndereco;
                alunoAux.Contato = aluno.Contato;
                
                alunoAux.DescricaoMedica = aluno.DescricaoMedica;
                alunoAux.Email= aluno.Email;
                alunoAux.FatorRh = aluno.FatorRh;
                alunoAux.FoneAluno = aluno.FoneAluno;
                alunoAux.FoneEmergencia = aluno.FoneEmergencia;
                alunoAux.FoneMedico = aluno.FoneMedico;
                alunoAux.FoneResidencia= aluno.FoneResidencia;
                alunoAux.GrupoSanguineo = aluno.GrupoSanguineo;
                alunoAux.Hospital = aluno.Hospital;
                alunoAux.Imagem= aluno.Imagem;
                alunoAux.Login = aluno.Login;
                alunoAux.Logradouro = aluno.Logradouro;
                alunoAux.Nacionalidade = aluno.Nacionalidade;
                alunoAux.Nascimento = aluno.Nascimento;
                alunoAux.Naturalidade = aluno.Naturalidade;
                alunoAux.Nome = aluno.Nome;
                alunoAux.NomeMedico= aluno.NomeMedico;
                alunoAux.PerfilID = aluno.PerfilID;
                alunoAux.PlanoSaude = aluno.PlanoSaude;
                alunoAux.Senha = aluno.Senha;
                alunoAux.Sexo = aluno.Sexo;
                alunoAux.SituacaoEspecial = aluno.SituacaoEspecial;
                alunoAux.Status = aluno.Status;
                alunoAux.Uf = aluno.Uf;
                alunoAux.SerieAtual = aluno.SerieAtual;
                alunoAux.Edificio = aluno.Edificio;

                Confirmar();
            }
            catch (Exception)
            {
                
               throw new AlunoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}