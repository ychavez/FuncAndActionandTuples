namespace FuncAndAction
{
    public class ActionsAndTuple
    {
        public static void Run()
        {
            var personas = Crud<string>();

            personas.agregar("Sahib");
            personas.agregar("Omar");
            personas.agregar("David");
            personas.agregar("Juan Pablo");
            personas.agregar("Yael");
            personas.consultar();
            personas.cuenta();
            personas.eliminar("Yael");
            personas.consultar();
            personas.cuenta();





            var CrudNumeros = Crud<int>();

            CrudNumeros.agregar(1);
            CrudNumeros.agregar(2);
            CrudNumeros.agregar(3);
            CrudNumeros.agregar(44);
            CrudNumeros.agregar(77);
            CrudNumeros.consultar();
            CrudNumeros.cuenta();
            CrudNumeros.eliminar(77);
            CrudNumeros.consultar();
            CrudNumeros.cuenta();



            var CrudDeFechas = Crud<DateTime>();

            CrudDeFechas.agregar(DateTime.Now);
            CrudDeFechas.agregar(DateTime.Now);
            CrudDeFechas.agregar(DateTime.Now);
            CrudDeFechas.agregar(DateTime.Now);
            CrudDeFechas.agregar(DateTime.Now);
            CrudDeFechas.consultar();
            CrudDeFechas.cuenta();
            CrudDeFechas.eliminar(DateTime.Now);
            CrudDeFechas.consultar();
            CrudDeFechas.cuenta();


            // var a =  ImprimirNombre("Yael", "Chavez", 30);

            // var mitupla = ("Hola", "como", 45);

            //mitupla = ImprimirNombre("Yael", "Chavez", 30);


            Func<int,bool> validarFunc = (e) => true;
           
            var validar = (int e) => true;

            bool validacion = validar(1);


        }

        static (string nombre, string apellido, int edad) ImprimirNombre(string nombre, string apellido, int edad)
        => (nombre, apellido, edad);

        public static (Action<T> agregar, Action<T> eliminar, Action consultar, Func<int> cuenta) Crud<T>()
        {

            List<T> datos = new List<T>();

            var Consultar = () => datos.ForEach(x => Console.WriteLine(x));

            Action<T> Agregar = (s => datos.Add(s));

            Action<T> Eliminar = (s => datos.Remove(s));

            var Cuenta = () => datos.Count();

            return (
               Agregar,
               Eliminar,
               Consultar,
               Cuenta
               );

        }

    }


}
