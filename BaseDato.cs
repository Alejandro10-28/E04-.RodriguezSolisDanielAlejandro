using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda
{

    class BaseDato
    {
        //Se instancian las listas de las clases existentes
        public List<Menu> listamenu { get; private set; }
        public List<Aperitivo> ListAperitivos { get; private set; }
        public List<Ensalada> Ensalada { get; private set; }

        public List<Carne> ListCarnes { get; private set; }
        public List<Pescado> ListPescado { get; private set; }
        public List<Pollo> ListPollo { get; private set; }
        public List<Pasta> ListPasta { get; private set; }
        public List<Sandwich> ListSandwich { get; private set; }
        public List<Panini> ListPaninis { get; private set; }
        public List<Postre> ListPostre { get; private set; }
        public List<Bebida> ListBebida { get; private set; }
        public List<Empty> Vacio { get; private set; }



        public BaseDato()
        {
            listamenu = new List<Menu>();
            ConstruirMenu();
        }
        //Construirmenu es el metodo donde haremos la seleccion de comida para cada categoria
        private void ConstruirMenu()
        {

            listamenu = new List<Menu>//El error que existia es que no estaba declarada la lista de tipo Menu
            {   new Menu{Id=0,Nombre="None"},
                new Menu {Id = 1, Nombre = "Aperitivos"},
                new Menu {Id = 2, Nombre = "Ensalada"},
                new Menu {Id = 3, Nombre = "Carne"},
                new Menu {Id = 4, Nombre = "Pescado"},
                new Menu {Id = 5, Nombre = "Pollo"},
                new Menu {Id = 6, Nombre = "Pasta"},
                new Menu {Id = 7, Nombre = "Sandwichs"},
                new Menu {Id = 8, Nombre = "Paninis"},
                new Menu {Id = 9, Nombre = "Postre"},
                new Menu {Id = 10, Nombre = "Bebidas"}
            };

            Ensalada = new List<Ensalada>
            {
             new Ensalada{Id=0,Nombre="None"},
             new Ensalada{Id=1,Nombre="Primavera"},
             new Ensalada{Id=2,Nombre="Clasica"},
             new Ensalada{Id=3,Nombre="Delizioso"},
             new Ensalada{Id=4,Nombre="Caesar con Pollo"},
             new Ensalada{Id=5,Nombre="Rustica con Camaron"},
             new Ensalada{Id=6,Nombre="Caprese"}

            };

            ListAperitivos = new List<Aperitivo>
            {
                new Aperitivo {Id=0,Nombre="None"},
                new Aperitivo {Id =1 , Nombre = "Calamar frito"},
                new Aperitivo {Id =2 , Nombre = "Plato siciliano"},
                new Aperitivo {Id =3 , Nombre = "Antipasti delizioso"},
                new Aperitivo {Id =4 , Nombre = "Fonduta Ahumada"},
                new Aperitivo {Id =5 , Nombre = "Mini albondigas delizioso"},
                new Aperitivo {Id =6 , Nombre = "Zuppa"},
                new Aperitivo {Id =7 , Nombre = "Crostini delizioso"},
                new Aperitivo {Id =8 , Nombre = "Champinones rellenos"},
            };

            ListCarnes = new List<Carne>
            {   new Carne {Id =0,   Nombre="None"},
                new Carne {Id =1 , Nombre = "Filete de la casa"},
                new Carne {Id =2 , Nombre = "Filete Mignon"},
                new Carne {Id =3 , Nombre = "Milanesa de Res Rellena"}
            };

            ListPescado = new List<Pescado>
            {
                new Pescado {Id =0,  Nombre="None"},
                new Pescado {Id =1 , Nombre = "Salmon"},//Las comillas estaban incompletas
                new Pescado {Id =2 , Nombre = "Risoto con camaron"},
                new Pescado {Id =3 , Nombre = "Mar Delizioso"},
                new Pescado {Id =4 , Nombre = "Tilapia parmesana"},
                new Pescado {Id =5 , Nombre = "Croquetas de cangrejo"},
                new Pescado {Id =6 , Nombre = "Ceviche"}
            };

            ListPollo = new List<Pollo>
            {
                new Pollo { Id = 0, Nombre = "None" },
                new Pollo {Id =1 , Nombre = "Marsala"},
                new Pollo {Id =2 , Nombre = "Rostizado en hierbas"},
                new Pollo {Id =3 , Nombre = "Parmigiana"},
                new Pollo {Id =4 , Nombre = "Picatta"},
                new Pollo {Id =5 , Nombre = "Pechuga de pollo rellena"},
            };
            ListPasta = new List<Pasta>
            {
                new Pasta {Id =0 ,  Nombre = "Spaguetti a la putanesca"},
                new Pasta {Id =1 ,  Nombre = "Spaguetti clasico"},
                new Pasta {Id =2 ,  Nombre = "Pasta bolognesa"},
                new Pasta {Id =3 ,  Nombre = "Pasta al beto"},
                new Pasta {Id =4 ,  Nombre = "Delizioso pasta"},
                new Pasta {Id =5 ,  Nombre = "Pasta nana lucia"},
                new Pasta {Id =6 ,  Nombre = "Pasta pescatore"},
                new Pasta {Id =7 ,  Nombre = "Pasta al marco"},
                new Pasta {Id =8 ,  Nombre = "Pasta al roy"},
                new Pasta {Id =9 ,  Nombre = "Alfredo fetuccine con pollo"},
                new Pasta {Id =10 , Nombre  = "Raviolis"},
                new Pasta {Id =11 , Nombre  = "Pasta al cuore"},
                new Pasta {Id =12 , Nombre  = "Lasagna"},
                new Pasta {Id =13 , Nombre  = "Raviolis portobello"},
                new Pasta {Id =14 , Nombre  = "Rigatoni Delizioso"},
                new Pasta {Id =15 , Nombre  = "Trio delizioso"}
            };
            ListSandwich = new List<Sandwich>
            {
                new Sandwich {Id =0 , Nombre = "De albondiga italiana"},
                new Sandwich {Id =1 , Nombre = "Atun fonduta"},
                new Sandwich {Id =2 , Nombre = "Clasico B.L.T."},
                new Sandwich {Id =3 , Nombre = "Pavo pesto"},
                new Sandwich {Id =4 , Nombre = "pastrami fonduta"},
                new Sandwich {Id =5 , Nombre = "De salchicha italiana"}
            };
            ListPaninis = new List<Panini>
            {
                new Panini {Id =0 , Nombre = "Panini de pollo"},
                new Panini {Id =1 , Nombre = "Panini vegetariano"},
                new Panini {Id =2 , Nombre = "Panini rosat beef"},
                new Panini {Id =3 , Nombre = "Panini jamon"},
                new Panini {Id =4 , Nombre = "Panini salami"},
                new Panini {Id =5 , Nombre = "Panini pastramia"},
            };
            ListPostre = new List<Postre>
            {
                new Postre {Id =0 , Nombre = "Cannoli"},
                new Postre {Id =1 , Nombre = "Tirasumi"},
                new Postre {Id =2 , Nombre = "Pastel de zanaoria"},
                new Postre {Id =3 , Nombre = "Gellato"},
                new Postre {Id =4 , Nombre = "Creme brulee"},
                new Postre {Id =5 , Nombre = "Pay de queso"},
                new Postre {Id =6 , Nombre = "Brownies"},
            };
            ListBebida = new List<Bebida>
            {
                new Bebida {Id =0 , Nombre = "Sodas"},
                new Bebida {Id =1 , Nombre = "Agua mineral"},
                new Bebida {Id =2 , Nombre = "Sangria preparada"},
                new Bebida {Id =3 , Nombre = "Jugo de naranja"},
                new Bebida {Id =4 , Nombre = "Jugo de manzana"},
                new Bebida {Id =5 , Nombre = "Te helado"},
                new Bebida {Id =6 , Nombre = "Limonada"},
                new Bebida {Id =7 , Nombre = "Cafe"},
                new Bebida {Id =8 , Nombre = "Te caliente"},
                new Bebida {Id =9 , Nombre = "Vino"},
                new Bebida {Id =10 ,Nombre = "Cerveza"},
            };
            // Este pedazo del metodo no estaba dentro de los corchetes de construir menu
            Vacio = new List<Empty>
            {
                new Empty {ID =0 , Nombre = "Nombre"},

            };



        }
    } }

