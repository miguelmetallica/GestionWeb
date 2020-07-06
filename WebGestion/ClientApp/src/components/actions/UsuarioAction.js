import HttpCliente from '../../servicios/HttpCliente';

export const registrarUsuario = usuario => {
    return new Promise((resolve, eject) => {
        HttpCliente.post('/Usuarios/registrar', usuario).then(response => {
            resolve(response);
        })
    })
}

export const obtenerUsuarioActual = dispatch => {
    return new Promise((resolve, eject) => {
        HttpCliente.get('/Usuarios').then(response => {            
            dispatch({
                type: 'INICIAR_SESION',
                sesion: response.data,
                autenticado: true
            })

            resolve(response);
        })        
    })
}

export const actualizaUsuario = usuario => {
    return new Promise((resolve, eject) => {
        HttpCliente.put('/Usuarios/actualizar', usuario)
            .then(response => {
                resolve(response);
            })
            .catch(error => {
                resolve(error.response);
            });
    })
}

export const loginUsuario = usuario => {
    return new Promise((resolve, eject) => {
        HttpCliente.post('/Usuarios/login', usuario).then(response => {
            resolve(response);
        })
    })
}