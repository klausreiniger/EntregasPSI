﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Cadastros;
using Persistencia.DAL.Cadastros;

namespace Servico.Cadastros
{
    public class ProdutoServico
    {
        private ProdutoDAL produtoDAL = new ProdutoDAL();
        public IQueryable<Produto> ObterProdutosClassificadosPorNome()
        {
            return produtoDAL.ObterProdutosClassificadosPorNome();
        }

        public Produto ObterProdutoPorId(long id)
        {
            return produtoDAL.ObterProdutoPorId(id);
        }

        public void GravarProduto(Produto produto)
        {
            produtoDAL.GravarProduto(produto);
        }
        public Produto EliminarProduto(long id)
        {
            return produtoDAL.EliminarProduto(id);
        }
    }
}
