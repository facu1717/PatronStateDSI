﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStateDSI.Clases
{
    class PedienteDePreparacion : Estado
    {
        private string ambito;
        private string nombre;

        public PedienteDePreparacion(string ambito, string nombre)
        {
            this.ambito = ambito;
            this.nombre = nombre;
        }

        public override void cancelar()
        {
            throw new NotImplementedException();
        }

        public override bool esPendienteDePreparacion()
        {
            throw new NotImplementedException();
        }

        public override string getAmbito()
        {
            return ambito;
        }

        public override string getNombre()
        {
            return nombre;
        }

        public override void preparar()
        {
            throw new NotImplementedException();
        }

        //Metodos que no implementa
        public override void buscarHistoriaActual()
        {
            throw new NotImplementedException();
        }

        public override void crearHistorialEstado()
        {
            throw new NotImplementedException();
        }

        public override void crearProximoEstado()
        {
            throw new NotImplementedException();
        }

        public override bool esCancelado()
        {
            throw new NotImplementedException();
        }

        public override bool esEnPreparacion()
        {
            throw new NotImplementedException();
        }

        public override bool esNotificado()
        {
            throw new NotImplementedException();
        }

        public override bool esPendienteDeServir()
        {
            throw new NotImplementedException();
        }

        public override bool esServido()
        {
            throw new NotImplementedException();
        }

        public override void finalizarPreparacion()
        {
            throw new NotImplementedException();
        }

        public override void notificar()
        {
            throw new NotImplementedException();
        }

        public override void servir()
        {
            throw new NotImplementedException();
        }
    }
}
