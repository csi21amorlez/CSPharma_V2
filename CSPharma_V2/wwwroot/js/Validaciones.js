function validacionRegister() {


    //Obtenemos el valor de la contraseña desde la vista 
    let contrasenya = document.getElementsByName('contrasenya').values;
    //Obtenemos el valor de la confirmacion de la contraseña desde la vista
    let valContrasenya = document.getElementsByName('valContrasenya').values;
    //Obtenemos el valor numerico del rol desde la vista
    let valorRol = document.getElementsByName('rol').values;

    console.log(contrasenya)
    console.log(valContrasenya)
    console.log(valorRol);

    //Comprueba que ambas contraseñas coincidan, en caso contrario, detiene el flujo de la aplicacion y  obliga a introducirlas de nuevo
    if (contrasenya != valContrasenya) {
        alert('Los campos de contraseñas no coinciden');
        return false;
    }

    //Comrpueba que el valor introducido como rol sea valido, (0=Administrador, 1=Usuario Normal, 2=Aun por confirmar)
    if (valorRol < 0 || valorRol > 3) {
        alert('Valor de rol no valido');
        return false;
    }

    else
        return true;


}