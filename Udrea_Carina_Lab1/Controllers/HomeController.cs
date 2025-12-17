using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Udrea_Carina_Lab1.Models;

    namespace NumeProiect.Controllers
    {
        public class ExempluController : Controller
        {
            public string Index()
            {
                return "Bine ați venit!";
            }
            public string Salut()
            {
                return "Salut!";
            }

            public string AfisareDetalii(string nume, int varsta)
            {
                string numeAfisat = string.IsNullOrEmpty(nume) ? "Necunoscut" : nume;

                string mesaj = $"Buna! Numele meu este {numeAfisat} si am {varsta} ani ";


            return mesaj;
            }
        }
    }