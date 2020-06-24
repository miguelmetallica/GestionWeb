import React from 'react';
import { Container, Typography, TextField, Button } from '@material-ui/core';
import style from '../Tool/Style';
import LockOutlinedIcon from '@material-ui/icons/LockOutlined';
import { Avatar } from '@material-ui/core';

const Login = () => {

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
                    <TextField name="username" variant="outlined" fullWidth label="ingrese el usuario" margin="normal"/>
                    <TextField name="password" type="password" variant="outlined" fullWidth label="ingrese el password" margin="normal" />
                    <Button type="submit" fullWidth variant="contained" color="primary" style={style.submit}>
                        Ingresar
                    </Button>                                       
                </form>
            </div>
        </Container>
    );
}

export default Login;