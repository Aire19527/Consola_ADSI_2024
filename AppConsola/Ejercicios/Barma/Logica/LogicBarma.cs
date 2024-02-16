using AppConsola.Ejercicios.Barma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppConsola.Ejercicios.Barma.Logica
{
    public class LogicBarma
    {
        private List<BaldeModel> CargarBaldes()
        {
            //forma 1
            List<BaldeModel> baldes = new List<BaldeModel>();
            BaldeModel baldeA = new BaldeModel()
            {
                Balde = "A",
                Vino = 20,
                Ginebra = 30,
                JugoLimon = 50
            };
            baldes.Add(baldeA);

            //forma 2
            baldes.Add(new BaldeModel()
            {
                Balde = "B",
                Vino = 30,
                Ginebra = 20,
                JugoLimon = 60
            });

            //forma 3
            BaldeModel baldeC = new BaldeModel();
            baldeC.Balde = "C";
            baldeC.Vino = 30;
            baldeC.Ginebra = 30;
            baldeC.JugoLimon = 32;
            baldes.Add(baldeC);

            return baldes;
        }

        private List<PreciosModel> CargarPrecios()
        {
            List<PreciosModel> precios = new List<PreciosModel>();
            precios.AddRange(new List<PreciosModel>()
            {
                new PreciosModel()
                {
                    Liquido="Vino",
                    Precio=5
                },
                new PreciosModel()
                {
                    Liquido="Ginebra",
                    Precio=45
                },
                new PreciosModel()
                {
                    Liquido="Jugo de limon",
                    Precio=10
                }
            });


            return precios;
        }

        public void Barma()
        {
            List<BaldeModel> baldes = CargarBaldes();
            List<PreciosModel> precios = CargarPrecios();


            PreciosModel preciosVino = precios.Where(x => x.Liquido.ToLower() == "VINO".ToLower()).FirstOrDefault();
            PreciosModel preciosGinebra = precios.FirstOrDefault(x => x.Liquido.ToLower() == "ginebra");
            PreciosModel preciosLimon = precios.FirstOrDefault(x => x.Liquido.ToLower() == "jugo de limon");

            List<BaldePreciosModel> baldePrecios = new List<BaldePreciosModel>();
            foreach (var balde in baldes)
            {
                int precioTotalVino = balde.Vino * preciosVino.Precio;
                int precioTotalGinebra = balde.Ginebra * preciosGinebra.Precio;
                int precioTotalLimon = balde.JugoLimon * preciosLimon.Precio;
                int total = precioTotalVino + precioTotalGinebra + precioTotalLimon;

                baldePrecios.Add(new BaldePreciosModel()
                {
                    Balde = balde.Balde,
                    PrecioTotal = total
                });

                Console.WriteLine($"Balde: {balde.Balde} - Vino: {precioTotalVino} - Ginebra: {precioTotalGinebra} - Limon: {precioTotalLimon} - Total: {total}");
            }

            foreach (var item in baldePrecios)
            {
                if(item.Balde=="A")
                {
                    int valor=item.PrecioTotal*10;
                    Console.WriteLine($"El precio de 10 baldes tipo: {item.Balde} es de: {valor}");
                }

                if (item.Balde == "B")
                {
                    int valor = item.PrecioTotal * 4;
                    Console.WriteLine($"El precio de 4 baldes tipo: {item.Balde} es de: {valor}");
                }

                if (item.Balde == "C")
                {
                    int valor = item.PrecioTotal * 5;
                    Console.WriteLine($"El precio de 5 baldes tipo: {item.Balde} es de: {valor}");
                }
            }
        
        }

    }
}
