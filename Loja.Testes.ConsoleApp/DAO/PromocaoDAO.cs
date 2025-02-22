﻿using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class PromocaoDAO : BaseDAO, IBaseDAO<Promocao>
    {
        public PromocaoDAO(LojaContext context) : base(context) { }

        public void Atualizar(Promocao promocao)
        {
            Context.Promocoes.Update(promocao);
            Context.SaveChanges();
        }

        public Promocao Carregar(int id)
        {
            return Context.Promocoes.Find(id);
        }

        public Promocao Carregar(Expression<Func<Promocao, bool>> filter)
        {
            return Context.Promocoes.Where(filter).FirstOrDefault();
        }

        public Promocao CarregarComProdutos(Expression<Func<Promocao, bool>> filter)
        {
            return Context.Promocoes.Where(filter)
                                    .Include(x=>x.Produtos)
                                    .ThenInclude(x=>x.Produto)
                                    .FirstOrDefault();
        }

        public IList<Promocao> Filtrar(Expression<Func<Promocao, bool>> filter)
        {
            return Context.Promocoes.Where(filter).ToList();
        }

        public void Inserir(Promocao promocao)
        {
            Context.Promocoes.Add(promocao);
            Context.SaveChanges();
        }


        public IList<Promocao> Listar()
        {
            return Context.Promocoes.ToList();
        }

        public void Remover(Promocao promocao)
        {
            Context.Remove(promocao);
            Context.SaveChanges();
        }
    }
}