using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mapper
{
    public class MapperCliente : IMapperCliente
    {
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
            var dto = clientes.Select(p => new ClienteDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Sobrenome = p.Sobrenome,
                Email = p.Email
            });
            return dto;
        }
    }
}