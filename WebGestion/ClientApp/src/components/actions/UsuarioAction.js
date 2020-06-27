import HttpCliente from '../../servicios/HttpCliente';

export const registrarUsuario = usuario => {
    return new Promise((resolve, eject) => {
        HttpCliente.post('/Usuarios/registrar', usuario).then(response => {
            resolve(response);
        })
    })
}

export const obtenerUsuarioActual = () => {
    return new Promise((resolve, eject) => {
        HttpCliente.get('/Usuarios').then(response => {
            resolve(response);
        })
    })
}

export const actualizaUsuario = usuario => {
    return new Promise((resolve, eject) => {
        HttpCliente.put('/Usuarios/actualizar', usuario).then(response => {
            resolve(response);
        })
    })
}