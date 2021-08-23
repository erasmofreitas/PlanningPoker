using PlanningPoker.Application.DTO;
using PlanningPoker.CrossCutting.Interfaces;
using PlanningPoker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.CrossCutting.Mappings
{
   public class MapperCartas : IMapperCartas
    {
        #region properties

        List<CartasDTO> CartasDTOs = new List<CartasDTO>();

        #endregion


        #region methods

        public Cartas MapperToEntity(CartasDTO CartasDTO)
        {
            Cartas Cartas = new Cartas
            {
                Id = CartasDTO.Id
                ,
                ValorCarta = CartasDTO.ValorCarta
            };

            return Cartas;

        }


        public IEnumerable<CartasDTO> MapperListCartas(IEnumerable<Cartas> Cartass)
        {
            foreach (var item in Cartass)
            {


                CartasDTO CartasDTO = new CartasDTO
                {
                    Id = item.Id
                   ,
                    ValorCarta = item.ValorCarta
                };



                CartasDTOs.Add(CartasDTO);

            }

            return CartasDTOs;
        }

        public CartasDTO MapperToDTO(Cartas Cartas)
        {

            CartasDTO CartasDTO = new CartasDTO
            {
                Id = Cartas.Id
                ,
                ValorCarta = Cartas.ValorCarta
            };

            return CartasDTO;

        }

        #endregion

    }
}