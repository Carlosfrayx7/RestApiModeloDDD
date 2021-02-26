using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        private IEnumerable<ClienteDto> clienteDtos = new List<ClienteDto>();

        public Cliente MapperDtoToEntity(ClienteDto clientDto)
        {
            var cliente = new Cliente()
            {
                Id = clientDto.Id,
                Nome = clientDto.Nome,
                Sobrenome = clientDto.Sobrenome,
                Email = clientDto.Email
            };

            return cliente;
        }

        public ClienteDto MapperEmtityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(p => new ClienteDto { Id = p.Id,
                Nome = p.Nome,
                Sobrenome = p.Sobrenome,
                Email = p.Email});
            return dto;
             
        }
    }
}