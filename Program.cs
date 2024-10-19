// See https://aka.ms/new-console-template for more information
using EjercicioClase;

SuperHeroe superHeroe1 = new SuperHeroe();

superHeroe1.Nombre = "Superman";
superHeroe1.IdentidadSecreta = "Clark Kent";
superHeroe1.Ciudad = "Metropolis";
superHeroe1.PuedeVolar = true;
superHeroe1.SuperPoder.Nombre = "Vision Infraroja";
superHeroe1.SuperPoder.Descripcion = "Capacidad de poder ver en la oscuridad";
superHeroe1.SuperPoder.Nivel = 4;
superHeroe1.Imprimir();

SuperHeroe superHeroe2 = new SuperHeroe();

superHeroe2.Nombre = "Batman";
superHeroe2.IdentidadSecreta = "Bruce Wayne";
superHeroe2.Ciudad = "Ciudad Gotica";
superHeroe2.PuedeVolar = false;
superHeroe2.SuperPoder.Nombre = "Inteligencia";
superHeroe2.SuperPoder.Descripcion = "Alta capacidad cognitiva";
superHeroe2.SuperPoder.Nivel = 8;
superHeroe2.Imprimir();

SuperHeroe superHeroe3 =  new SuperHeroe();

superHeroe3.Nombre = "Flash";
superHeroe3.IdentidadSecreta = "Barry Allen";
superHeroe3.Ciudad = "Ciudad Central";
superHeroe3.PuedeVolar = false;
superHeroe3.SuperPoder.Nombre = "Supervelocidad";
superHeroe3.SuperPoder.Descripcion = "Recorer distancias enormes en fracciones de segundo";
superHeroe3.SuperPoder.Nivel = 10;
superHeroe3.Imprimir();
