import React from 'react';
import { Container, Typography, Grid, TextField, Button } from '@material-ui/core';
import style from '../Tool/Style';

const PerfilUsuario = () => {

    return (
        <Container component="main" maxWidth="md" justify="center">
            <div style={style.paper}>
                <Typography component="h1" variant="h5">
                    Perfil de Usuario
                </Typography>
                <form style={style.form}>
                    <Grid container spacing={2}>
                        <Grid item xs={12} md={6}>
                            <TextField name="nombrecompleto" variant="outlined" fullWidth label="ingrese su nombre y apellido" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="email" variant="outlined" fullWidth label="ingrese su email" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="password" type="password" variant="outlined" fullWidth label="ingrese password" />
                        </Grid>
                        <Grid item xs={12} md={6}>
                            <TextField name="confirmacionpassword" type="password" variant="outlined" fullWidth label="confirmacion del password" />
                        </Grid>
                    </Grid>
                    <Grid container justify="center">
                        <Grid item xs={12} md={6}>
                            <Button type="submit" fullWidth variant="contained" color="primary" size="large" style={style.submit}>
                                Enviar
                            </Button>
                        </Grid>
                    </Grid>
                </form>
            </div>
        </Container>
    );
}

export default PerfilUsuario;