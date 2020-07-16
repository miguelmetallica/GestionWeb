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
}
