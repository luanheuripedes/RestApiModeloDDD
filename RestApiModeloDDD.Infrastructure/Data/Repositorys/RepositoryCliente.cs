using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;

namespace RestApiModeloDDD.Infrastructure.Data.Repositorys
{
    public  class RepositoryCliente : RepositoyBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
