namespace CapaDominioFSharp
open System
module Operacion_FSharp =

    let Calcular(num1:double)(num2:double)(operation:string) =
        if(operation="Sumar") then
            num1 + num2
        else if (operation="Restar") then
            num1 - num2
        else if (operation="Multiplicar") then
            num1 * num2
        else
            num1 / num2