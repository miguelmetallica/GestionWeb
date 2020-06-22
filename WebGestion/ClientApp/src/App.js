import React, { Component } from 'react';
import MuithemeProvider from "@material-ui/core/styles/MuiThemeProvider";
import theme from "./theme/theme";
import { TextField, Button } from '@material-ui/core';

//import { Route } from 'react-router';
//import { Layout } from './components/Layout';
//import { Home } from './components/Home';
//import { FetchData } from './components/FetchData';
//import { Counter } from './components/Counter';

//import './custom.css'

function App()
{
    return(
        <MuithemeProvider theme={theme}>
            <h1>Hola Mundo</h1>
            <TextField variant="outlined" />
            <Button variant="contained" color="primary">hola boton</Button>
        </MuithemeProvider>
        )
}

export default App;