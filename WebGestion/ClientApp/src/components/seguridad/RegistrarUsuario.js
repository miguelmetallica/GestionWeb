﻿import React, { useState } from 'react';
import { Container, Typography, Grid, TextField, Button } from '@material-ui/core';
import style from '../Tool/Style';
import { registrarUsuario } from '../actions/UsuarioAction';

const RegistrarUsuario = () => {
    const [usuario, setUsuario] = useState({
        NombreCompleto: '',
        Email: '',
        Password: '',
        ConfirmarPassword: '',
        UserName: ''        
    })
    const inserarValoresMemoria = e => {
        const { name, value } = e.target;
        setUsuario(anterior => ({
            ...anterior,
            [name]: value            
        }))
    }

    const registrarUsuarioBoton = e => {
        e.preventDefault();
        registrarUsuario(usuario).then(response => {
            console.log('se registro existosamente', response);
            window.localStorage.setItem("token_seguridad", response.data.token);
        })
    }

    return (
        <Container component="main" maxWidth="md" justify="center">
            <div style={style.paper}>
                <Typography component="h1" variant="h5">
                    Registro de Usuario
                </Typography>
                <form style={style.form}>
                    <Grid container spacing={2}>
                        <Grid item xs={12} md={12}>
                            <TextField name="NombreCompleto" value={usuario.NombreCompleto} onChange={inserarValoresMemoria} variant="outlined" fullWidth label="ingrese su nombre y apellido" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="Email" value={usuario.Email} onChange={inserarValoresMemoria} variant="outlined" fullWidth label="ingrese su email" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="UserName" value={usuario.UserName} onChange={inserarValoresMemoria} variant="outlined" fullWidth label="ingrese su usuario" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="Password" value={usuario.Password} onChange={inserarValoresMemoria} type="password" variant="outlined" fullWidth label="ingrese password" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="ConfirmarPassword" value={usuario.ConfirmarPassword} onChange={inserarValoresMemoria} type="password" variant="outlined" fullWidth label="confirmacion del password" />
                        </Grid>
                    </Grid>
                    <Grid container justify="center">
                        <Grid item xs={12} md={6}>
                            <Button type="submit" onClick={registrarUsuarioBoton} fullWidth variant="contained" color="primary" size="large" style={style.submit}>
                                Enviar
                            </Button>
                        </Grid>
                    </Grid>
                </form>
            </div>
        </Container>
        );
}

export default RegistrarUsuario;