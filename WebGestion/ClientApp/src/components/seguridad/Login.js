import React from 'react';
import { Container, Typography, TextField, Button } from '@material-ui/core';
import style from '../Tool/Style';
import LockOutlinedIcon from '@material-ui/icons/LockOutlined';
import { Avatar } from '@material-ui/core';
import { useState } from 'react';
import { loginUsuario } from '../actions/UsuarioAction';

const Login = () => {
    const [usuario, setUsuario] = useState({
        Email: '',
        Password : ''
    })

    const inserarValoresMemoria = e => {
        const { name, value } = e.target;
        setUsuario(anterior => ({
            ...anterior,
            [name]: value
        }))
    }

    const loginUsuarioBoton = e => {
        e.preventDefault();
        loginUsuario(usuario).then(response => {
            console.log('ingreso existosamente', response);
            window.localStorage.setItem("token_seguridad", response.data.token);
        })
    }


    return (
        <Container maxWidth="xs">
            <div style={style.paper}>
                <Avatar style={style.avatar}>
                    <LockOutlinedIcon style={style.icon} />
                </Avatar>

                <Typography component="h1" variant="h5">
                    Login de Usuario
                </Typography>
                <form style={style.form}>
                    <TextField name="Email" value={usuario.Email} onChange={inserarValoresMemoria} type="email" required variant="outlined" fullWidth label="ingrese el usuario" margin="normal" />
                    <TextField name="Password" value={usuario.Password} onChange={inserarValoresMemoria} type="password" required variant="outlined" fullWidth label="ingrese el password" margin="normal" />
                    <Button type="submit" onClick={loginUsuarioBoton} fullWidth variant="contained" color="primary" style={style.submit}>
                        Ingresar
                    </Button>                                       
                </form>
            </div>
        </Container>
    );
}

export default Login;