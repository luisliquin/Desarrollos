﻿using CNTI.FACTUR.ENTITY.Parametros;
using CNTI365.FACTUR.BUSINESS;
using CNTI365.FACTUR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNTI365.FACTUR.Controllers {
    public class RegistroEmpresaController : Controller {
        private modelList model;
        private BUPais bupais;
        public RegistroEmpresaController() {
            model=new modelList();
            bupais=new BUPais();
        }

        public ActionResult RegistroEmpresa(ENRegistroEmpresa paramss) {
            string token = "";
            model.listPais = bupais.listarPaises(paramss, token);
            model.listMoneda =bupais.listarMoneda(paramss, token);
            model.listTImpuesto=bupais.listarTImpuestos(paramss, token);
            model.listPImpuestos=bupais.listarPImpuestos(paramss, token);
            return View(model);
        }
    }
}
