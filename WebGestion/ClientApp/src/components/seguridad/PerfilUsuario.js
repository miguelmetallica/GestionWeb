import React, { useState } from 'react';
import { Container, Typography, Grid, TextField, Button } from '@material-ui/core';
import style from '../Tool/Style';
import { useEffect } from 'react';
import { obtenerUsuarioActual, actualizaUsuario } from '../actions/UsuarioAction';
import { useStateValue } from '../../contexto/store';

const PerfilUsuario = () => {

    const [{ sesionUsuario }, dispatch] = useStateValue();

    const [usuario, setUsuario] = useState({
        nombreCompleto: '',
        username: '',
        email: '',
        password: '',
        confirmaPassword: '',
    })

    const inserarValoresMemoria = e => {
        const { name, value } = e.target;
        setUsuario(anterior => ({
            ...anterior,
            [name]: value
        }))
    }

    useEffect(() => {
        obtenerUsuarioActual(dispatch).then(response => {
            console.log('usuario actual', response);
            setUsuario(response.data);
        });
    }, [])

    const guardarUsuario = e => {
        e.preventDefault();
        actualizaUsuario(usuario).then(response => {
            console.log('se registro existosamente', response);
            //window.localStorage.setItem("token_seguridad", response.data.token);
        })
    }


    return (
        <Container component="main" maxWidth="md" justify="center">
            <div style={style.paper}>
                <Typography component="h1" variant="h5">
                    Perfil de Usuario
                </Typography>
                <form style={style.form}>
                    <Grid container spacing={2}>
                        <Grid item xs={12} md={12}>
                            <TextField name="nombreCompleto" value={usuario.nombreCompleto} onChange={inserarValoresMemoria} variant="outlined" fullWidth label="ingrese su nombre y apellido" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="username" value={usuario.username} onChange={inserarValoresMemoria} variant="outlined" fullWidth label="ingrese su usuario" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="email" value={usuario.email} onChange={inserarValoresMemoria} variant="outlined" fullWidth label="ingrese su email" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="password" value={usuario.password || ''} onChange={inserarValoresMemoria} type="password" variant="outlined" fullWidth label="ingrese password" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="confirmaPassword" value={usuario.confirmaPassword || ''} onChange={inserarValoresMemoria} type="password" variant="outlined" fullWidth label="confirmacion del password" />
                        </Grid>
                    </Grid>
                    <Grid container justify="center">
                        <Grid item xs={12} md={6}>
                            <Button type="submit" onClick={guardarUsuario} fullWidth variant="contained" color="primary" size="large" style={style.submit}>
                                Guardar Datos
                            </Button>
                        </Grid>
                    </Grid>
                </form>
            </div>
        </Container>
    );
}

export default PerfilUsuario;