function mostrarModalNuevo() {
    return Swal.fire({
        title: 'Deseas guardar los cambios?',
        text: "Deseas guardar los cambios en la base de datos",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si!'
    })
};


function mostrarModalEliminar() {
    return Swal.fire({
        title: 'Deseas eliminar el registro?',
        text: "Deseas eliminar el registro de la base de datos",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si!'
    })
};

function mostrarModalError() {
    return Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Se produjo un error al guardar los datos',        
    })
};

function mostrarModalOk() {
    return Swal.fire({
        icon: 'success',
        title: 'Los datos se guardaron correctamente',
        showConfirmButton: false,
        timer: 1500
    })
};


