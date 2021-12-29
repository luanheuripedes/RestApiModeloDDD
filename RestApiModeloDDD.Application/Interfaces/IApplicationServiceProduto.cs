﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Remove(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll();

        ClienteDto GetById(int id);
    }
}
