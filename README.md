# IMC
Creacion de indice de masa corporal. Creado confines de conocimiento del manejo de .net form.

![Inicio](https://firebasestorage.googleapis.com/v0/b/curriculum-vatea.appspot.com/o/imc%2Finicio.png?alt=media&token=83bfb218-1a58-443d-b4a1-f27de98f5fa9 "Inicio")

# Validaciones
Las validaciones de tecla fue creado con la funcion keypress. Con esto podemos saber el usuario que tecla aprecionado usanda la tabla ASCII.

para la funcion de nombre se realizon con la siguente validacion:
```csharp
private void txtNombre_KeyPress(object sender, KeyPressEventArgs e){
 if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar>= 123 && e.KeyChar <= 255)){
   MessageBox.Show("Solo se permiten letras", "ERROR", MessageBoxButtons.OK,     MessageBoxIcon.Error);
     e.Handled = true;
     return;
  }
}
```

![Error](https://firebasestorage.googleapis.com/v0/b/curriculum-vatea.appspot.com/o/imc%2Ferror%20numero.PNG?alt=media&token=259b4db1-e44d-4766-931e-87934fedfb92 "Error")

para la funcion de numeros fue con la siguente:

```csharp
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
```
![error numero](https://firebasestorage.googleapis.com/v0/b/curriculum-vatea.appspot.com/o/imc%2Ferror%20nombre.png?alt=media&token=1926629f-2aaf-4f63-ba10-b97673e6e7f3 "error numero")

Badges:
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) 	![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
