using PruebaHerencia;

EmpleadoPorComision EmpleadoPorComision = new EmpleadoPorComision("Susana",
    "Lopez", "222-22-2222", .06M, 1000.00M);

Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoPorComision con referencia de"+
    "clase base", "a objeto de clase base", EmpleadoPorComision.ToString(),
    "ingresos", EmpleadoPorComision.Ingresos());






