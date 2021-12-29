using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this._serviceCliente = serviceCliente; 
            this._mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClientesDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}